using System;
using CustomerPreferences.Interfaces;
using CustomerPreferences.Controllers;
using Moq;
using NUnit.Framework;

namespace CustomerPreferences.Test
{
    [TestFixture]
    public class CustomerPreferenceControllerTests
    {
        private Mock<IReportHelper> _mockReportHelper;

        [SetUp]
        public void Setup() {
            _mockReportHelper = new Mock<IReportHelper>();
        }

        [Test]
        public void Get_WhenCalled_ItCallsTheReportHelperCreateReportMethod()
        {
            // Arrange
            var controller = new CustomerPreferencesController();

            // Act
            controller.Get();

            // Assert
            _mockReportHelper.Verify(rh => rh.GetCustomerPreferencesReport(), Times.Once);
        }

    }
}

