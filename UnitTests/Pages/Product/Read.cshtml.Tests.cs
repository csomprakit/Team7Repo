﻿using NUnit.Framework;
using ContosoCrafts.WebSite.Pages.Product;

namespace UnitTests.Pages.Product.Read
{
    /// <summary>
    /// A class to test Read.
    /// </summary>
    public class ReadTests
    {
        #region TestSetup
        /// <summary>
        /// Generates a new model for testing.
        /// </summary>
        public static PetInformation pageModel;

        /// <summary>
        /// Initializes the tests herein.
        /// </summary>
        [SetUp]
        public void TestInitialize()
        {
            pageModel = new PetInformation(TestHelper.ProductService)
            {
            };
        }
        #endregion TestSetup

        #region OnGet
        /// <summary>
        /// Testing the OnGet method.
        /// </summary>
        [Test]
        public void OnGet_Valid_Should_Return_Products()
        {
            // Arrange

            // Act
            pageModel.OnGet("1");

            // Assert
            Assert.AreEqual(true, pageModel.ModelState.IsValid);
            Assert.AreEqual("Playful,  Socialable, Curiosity", pageModel.Product.Description);
        }
        #endregion OnGet
    }
}