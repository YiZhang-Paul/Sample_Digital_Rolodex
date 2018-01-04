using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitalRolodexClassLibrary;

namespace DigitalRolodexTests {
    [TestClass]
    public class RolodexValidatorTest {

        RolodexValidator validator;

        [TestInitialize]
        public void Setup() {

            validator = new RolodexValidator();
        }

        [TestMethod]
        public void NameIsEmpty() {

            Assert.IsFalse(validator.IsValidName(""));
            Assert.IsFalse(validator.IsValidName("".PadLeft(5, '\0')));
        }
    }
}