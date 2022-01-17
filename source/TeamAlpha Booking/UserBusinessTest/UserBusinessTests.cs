using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;
using Business_Layer;
using System.Collections.Generic;

namespace UserBusinessTest
{
    [TestClass]
    public class UserBusinessTests
    {
        private Mock<IUserRepository> mockUserRepository = new Mock<IUserRepository>();
        private UserBusiness userBusiness;
        private List<User> listOfUsers = new List<User>();

        private User user = new User
        {
            Ime = "Marko",
            Prezime = "Markovic",
            Broj_telefona = "062-286-4635",
            Datum_rodjenja = DateTime.Parse("02/10/1995 12:00:00 PM"),
            Email = "markovic@gmail.com",
            Lozinka = "legionarGTX",
            Stanodavac = false
        };

        private User user2 = new User
        {
            Ime = "Veljko",
            Prezime = "Loncarevic",
            Broj_telefona = "+381 65 123 4567",
            Datum_rodjenja = DateTime.Parse("17-Mar-95 12:00:00 AM"),
            Email = "veljkoloncarevic@gmail.com",
            Lozinka = "qwerty12345",
            Stanodavac = true
        };

        public UserBusinessTests()
        {
            listOfUsers.Add(user);
            listOfUsers.Add(user2);
        }

        [TestMethod]
        public void GetAllUsersTest()
        {
            // Arrange
            mockUserRepository.Setup(x => x.GetAllUsers()).Returns(listOfUsers);
            this.userBusiness = new UserBusiness(mockUserRepository.Object);

            // Act
            var result = userBusiness.GetAllUsers();

            // Assert
            Assert.AreEqual(2, result.Count); 
        }

        [TestMethod]
        public void IsUserRegistered()
        {
            // Arrange
            mockUserRepository.Setup(x => x.InsertUser(user)).Returns(1);
            this.userBusiness = new UserBusiness(mockUserRepository.Object);

            // Act
            var result = userBusiness.RegisterUser(user); 

            // Assert
            Assert.AreEqual(1, result); 
        }

        [TestMethod]
        public void AreUsersCounted()
        {
            // Arrange
            mockUserRepository.Setup(x => x.GetUserCount()).Returns(2);
            this.userBusiness = new UserBusiness(mockUserRepository.Object);

            // Act
            var result = userBusiness.GetUserCount();

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void IsUserUpdated()
        {
            // Arrange
            mockUserRepository.Setup(x => x.UpdateUserData(user)).Returns(1);
            this.userBusiness = new UserBusiness(mockUserRepository.Object);

            // Act
            var result = userBusiness.UpdateUserData(user);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IsUserRemoved()
        {
            // Arrange
            mockUserRepository.Setup(x => x.RemoveUser(user.Id_Korisnika)).Returns(1);
            this.userBusiness = new UserBusiness(mockUserRepository.Object);

            // Act
            var result = userBusiness.RemoveUser(user.Id_Korisnika);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetUserByEmailTest()
        {
            // Arrange
            mockUserRepository.Setup(x => x.GetUserByEmail("markovic@gmail.com")).Returns(user);
            this.userBusiness = new UserBusiness(mockUserRepository.Object);

            // Act
            var result = userBusiness.GetUserByEmail("markovic@gmail.com");

            // Assert
            Assert.AreEqual(user, result);
        }

        [TestMethod]
        public void GetUserNameByIdTest()
        {
            // Arrange
            mockUserRepository.Setup(x => x.GetUserNameById(user2.Id_Korisnika)).Returns("Veljko");
            this.userBusiness = new UserBusiness(mockUserRepository.Object);

            // Act
            var result = userBusiness.GetUserNameById(user2.Id_Korisnika);

            // Assert
            Assert.AreEqual("Veljko", result);
        }

    }
}
