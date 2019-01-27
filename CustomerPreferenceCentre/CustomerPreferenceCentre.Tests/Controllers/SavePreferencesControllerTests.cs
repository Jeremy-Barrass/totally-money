using System;
using System.Web.Mvc;
using CustomerPreferenceCentre.Controllers;
using NUnit.Framework;

namespace CustomerPreferenceCentre.Tests.Controllers
{
    [TestFixture]
    public class SavePreferencesControllerTests
    {
        [Test]
        public void Save_WhenItReceivesValidData_ItSavesItToAFile() {
            // Arrange
            var controller = new SavePreferencesController();

            // Act
            var result = (ViewResult)controller.Save();

            // Assert
            Assert.AreEqual(, result.);
        }
    }
}
