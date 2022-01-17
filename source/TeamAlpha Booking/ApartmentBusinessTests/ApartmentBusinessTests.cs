using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;
using Business_Layer;
using System.Collections.Generic;

namespace ApartmentBusinessTests
{
    [TestClass]
    public class ApartmentBusinessTests
    {
        private Mock<IApartmentRepository> mockApartmentRepository = new Mock<IApartmentRepository>();

        private ApartmentBusiness apartmentBusiness;
        private List<Apartment> listOfApartments = new List<Apartment>();

        private Apartment apartment = new Apartment
        {
            Adresa = "Ljubicka 5",
            Broj_soba = 3,
            Broj_sprata = 2,
            Depozit = 25,
            Cena_nocenja = 30,
            Id_Korisnika = 1,
            Kvadratura = 77,
            Mesto = "Cacak",
            Postanski_broj = 32103
        };

        private Apartment apartment2 = new Apartment
        {
            Adresa = "Dr Gutmana 5A",
            Broj_soba = 3,
            Broj_sprata = 1,
            Depozit = 20,
            Cena_nocenja = 33,
            Id_Korisnika = 2,
            Kvadratura = 80,
            Mesto = "Cajetina",
            Postanski_broj = 31310
        };

        private Apartment apartment3 = new Apartment
        {
            Adresa = "Sloboda 4",
            Broj_soba = 4,
            Broj_sprata = 2,
            Depozit = 50,
            Cena_nocenja = 50,
            Id_Korisnika = 3,
            Kvadratura = 76,
            Mesto = "Zlatibor",
            Postanski_broj = 31315
        };

        public ApartmentBusinessTests()
        {
            listOfApartments.Add(apartment);
            listOfApartments.Add(apartment2);
            listOfApartments.Add(apartment3);
        }

        [TestMethod]
        public void GetAllUsersTest()
        {
            // Arrange
            mockApartmentRepository.Setup(x => x.GetAllApartments()).Returns(listOfApartments);
            this.apartmentBusiness = new ApartmentBusiness(mockApartmentRepository.Object);

            // Act
            var result = apartmentBusiness.GetAllApartments();

            // Assert
            Assert.AreEqual(3, result.Count);
        }

        

    }
}
