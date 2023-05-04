﻿using System.Linq;

using NUnit.Framework;

using ContosoCrafts.WebSite.Pages.Product;

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace UnitTests.Pages.Product.Create
{
    public class CreateTests
    {
        #region TestSetup
        public static CreateModel pageModel;

        /// <summary>
        /// Sets up the tests herein.
        /// </summary>
        [SetUp]
        public void TestInitialize()
        {
            pageModel = new CreateModel(TestHelper.ProductService)
            {
            };
        }

        #endregion TestSetup

        #region OnGet
        /// <summary>
        /// Tests the Create method, which creates a new pet in our website.
        /// </summary>
        [Test]
        public void OnGet_Valid_Should_Return_Products()
        {
            // Arrange
            var oldCount = TestHelper.ProductService.GetProducts().Count();

            // Act
            pageModel.OnGet();

            // Assert
            Assert.AreEqual(true, pageModel.ModelState.IsValid);
            Assert.AreEqual(oldCount + 1, TestHelper.ProductService.GetProducts().Count());
        }
        #endregion OnGet
    }
}
