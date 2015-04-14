﻿namespace WindowsFormsTestApplication.Tests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;

    #endregion

    public class GetElementAttributeTests : BaseTest
    {
        #region Fields

        private IWebElement textBox;

        #endregion

        #region Public Methods and Operators

        [SetUp]
        public void FindBaseElement()
        {
            this.textBox = this.Driver.FindElementById("Form1").FindElement(By.Id("TextBox1"));
        }

        [Test]
        public void GetNotSupportedAttribute()
        {
            var value = this.textBox.GetAttribute("InvalidAttributeName");

            Assert.AreEqual(null, value);
        }

        [Test]
        public void GetSupportedAttributeByFullPropertyName()
        {
            var value = this.textBox.GetAttribute("NameProperty");

            Assert.AreEqual("TextBox1", value);
        }

        [Test]
        public void GetSupportedAttributeByShortPropertyName()
        {
            var value = this.textBox.GetAttribute("Name");

            Assert.AreEqual("TextBox1", value);
        }

        #endregion
    }
}
