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
            Assert.IsFalse(validator.IsValidName("".PadLeft(5, " "[0])));
        }

        [TestMethod]
        public void NameWithDigit() {

            Assert.IsFalse(validator.IsValidName("John Do5"));
            Assert.IsFalse(validator.IsValidName("5 52"));
            Assert.IsFalse(validator.IsValidName("Jane1e"));
        }

        [TestMethod]
        public void NameWithOneCharacter() {

            Assert.IsFalse(validator.IsValidName("J"));
        }

        [TestMethod]
        public void NameWithMoreThanTwentyFiveCharacter() {

            Assert.IsFalse(validator.IsValidName("J".PadLeft(26, 'J')));
        }

        [TestMethod]
        public void NameWithSpecialCharacters() {

            Assert.IsFalse(validator.IsValidName("Doe *Ann"));
            Assert.IsFalse(validator.IsValidName("Jos&h"));
            Assert.IsFalse(validator.IsValidName("#$ !"));
        }

        [TestMethod]
        public void ValidClientName() {

            Assert.IsTrue(validator.IsValidName("John Doe"));
            Assert.IsTrue(validator.IsValidName("Ji"));
            Assert.IsTrue(validator.IsValidName("Ronnie O'Sullivan"));
        }
    }
}