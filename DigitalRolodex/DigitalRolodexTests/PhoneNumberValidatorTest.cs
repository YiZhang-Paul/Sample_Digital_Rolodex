using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitalRolodexClassLibrary;
using System.IO;

namespace DigitalRolodexTests {
    [TestClass]
    public class PhoneNumberValidatorTest {

        PhoneNumberValidator validator;

        [TestInitialize]
        public void Setup() {

            validator = new PhoneNumberValidator("areaCode.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), 
         "Empty File Name is Not Allowed.")]
        public void EmptyAreaCodeFileName() {

            validator = new PhoneNumberValidator("");
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException),
         "File Does not Exist.")]
        public void NonExistAreaCodeFileName() {

            validator = new PhoneNumberValidator("notexist");
        }

        [TestMethod]
        public void EmptyAreaCode() {

            Assert.IsFalse(validator.IsValidAreaCode(""));
        }

        [TestMethod]
        public void InvalidAreaCode() {

            Assert.IsFalse(validator.IsValidAreaCode("205"));
            Assert.IsFalse(validator.IsValidAreaCode("2"));
        }

        [TestMethod]
        public void ValidAreaCode() {

            Assert.IsTrue(validator.IsValidAreaCode("204"));
            Assert.IsTrue(validator.IsValidAreaCode("647"));
        }

        [TestMethod]
        public void EmptyPhoneNumber() {

            Assert.IsFalse(validator.IsValidPhoneNumber(""));
            Assert.IsFalse(validator.IsValidPhoneNumber("".PadLeft(5, " "[0])));
        }

        [TestMethod]
        public void PhoneNumberWithLetters() {

            Assert.IsFalse(validator.IsValidPhoneNumber("ABC-DEF-GHIJ"));
            Assert.IsFalse(validator.IsValidPhoneNumber("(647)299-A292"));
            Assert.IsFalse(validator.IsValidPhoneNumber("509-0AB-ABAA"));
        }

        [TestMethod]
        public void InvalidPhoneNumberLength() {

            Assert.IsFalse(validator.IsValidPhoneNumber("647-299-01292"));
            Assert.IsFalse(validator.IsValidPhoneNumber("(6474)299 01292"));
            Assert.IsFalse(validator.IsValidPhoneNumber("6292"));
        }

        [TestMethod]
        public void PhoneNumberWithInvalidAreaCode() {

            Assert.IsFalse(validator.IsValidPhoneNumber("(648)299-0292"));
            Assert.IsFalse(validator.IsValidPhoneNumber("(205)299-0292"));
            Assert.IsFalse(validator.IsValidPhoneNumber("(904)299-0292"));
        }

        [TestMethod]
        public void ValidPhoneNumber() {

            Assert.IsTrue(validator.IsValidPhoneNumber("(647)299-0292"));
            Assert.IsTrue(validator.IsValidPhoneNumber("2042990292"));
            Assert.IsTrue(validator.IsValidPhoneNumber("905-299 0292"));
        }
    }
}