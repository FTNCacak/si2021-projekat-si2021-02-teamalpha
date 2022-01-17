using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Interfaces;
using Shared.Models;
using Moq;
using Business_Layer;
using System.Collections.Generic;

namespace RentBusinessTest
{
    [TestClass]
    public class RentBusinessTests
    {
        private Mock<IRentRepository> mockRentRepository = new Mock<IRentRepository>();

        private RentBusiness rentBusiness;
        private List<Rent> listOfRents = new List<Rent>();

        private Rent rent = new Rent
        {
            Id_Rente = 1,
            Id_Korisnika = 1,
            Broj_dana = 6,
            Broj_kartice = "6785",
            Datum_pocetka = DateTime.Parse("05/01/2021 12:00:00 PM"),
            Id_Stana = 3,
            Id_Stanodavca = 2,
            Nacin_placanja = true
        };

        private Rent rent2 = new Rent
        {
            Id_Rente = 2,
            Id_Korisnika = 2,
            Broj_dana = 8,
            Broj_kartice = "4751",
            Datum_pocetka = DateTime.Parse("03/05/2021 12:00:00 PM"),
            Id_Stana = 2,
            Id_Stanodavca = 1,
            Nacin_placanja = true
        };

        public RentBusinessTests()
        {
            listOfRents.Add(rent);
            listOfRents.Add(rent2);
        }

        [TestMethod]
        public void GetAllRents()
        {
            // Arrange
            mockRentRepository.Setup(x => x.GetAllRents()).Returns(listOfRents);
            this.rentBusiness = new RentBusiness(mockRentRepository.Object);

            // Act
            var result = rentBusiness.GetAllRents();

            // Assert
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void IsRentInserted()
        {
            // Arrange
            mockRentRepository.Setup(x => x.InsertRent(rent)).Returns(1);
            this.rentBusiness = new RentBusiness(mockRentRepository.Object);

            // Act
            var result = rentBusiness.InsertRent(rent);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IsRentUpdated()
        {
            // Arrange
            mockRentRepository.Setup(x => x.UpdateRentData(rent)).Returns(1);
            this.rentBusiness = new RentBusiness(mockRentRepository.Object);

            // Act
            var result = rentBusiness.UpdateRentData(rent);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IsRentRemoved()
        {
            // Arrange
            mockRentRepository.Setup(x => x.RemoveRent(rent2.Id_Rente)).Returns(1);
            this.rentBusiness = new RentBusiness(mockRentRepository.Object);

            // Act
            var result = rentBusiness.RemoveRent(rent2.Id_Rente);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetRentCountTest()
        {
            // Arrange
            mockRentRepository.Setup(x => x.GetRentCount()).Returns(2);
            this.rentBusiness = new RentBusiness(mockRentRepository.Object);

            // Act
            var result = rentBusiness.GetRentCount();

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}
