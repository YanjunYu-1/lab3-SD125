using lab3.Data;
using lab3.Data.BLL;
using lab3.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace TestLab3
{
    [TestClass]
    public class UnitTest1
    {
        Mock<Irepository<Pass>> PassMRepo;
        PassBLL PassBl;

        [TestInitialize]
        public void InitializedTest()
        {
            PassMRepo = new Mock<Irepository<Pass>>();

            PassBl = new PassBLL(PassMRepo.Object);
        }

        [TestMethod]
        public void Under3ThrowException()
        {
            //Arrang
            string purchase = "yy";
            var newPass = new Pass(purchase);

            // Act&Assert

            Assert.ThrowsException<Exception>(() => PassBl.CreatePass(newPass));
        }
    }
}