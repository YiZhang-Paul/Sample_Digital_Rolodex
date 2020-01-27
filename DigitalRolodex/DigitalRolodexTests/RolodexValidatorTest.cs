using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitalRolodexClassLibrary;
using Moq;

namespace DigitalRolodexTests {
    [TestClass]
    public class RolodexValidatorTest {

        Mock<IPhoneNumberValidator> phoneNumberValidator;
        RolodexValidator rolodexValidator;

        [TestInitialize]
        public void Setup() {

            phoneNumberValidator = new Mock<IPhoneNumberValidator>();
            rolodexValidator = new RolodexValidator(phoneNumberValidator.Object);
        }

        [TestMethod]
        public void EmptyName() {

            Assert.IsFalse(rolodexValidator.IsValidName(""));
            Assert.IsFalse(rolodexValidator.IsValidName("".PadLeft(5, " "[0])));
        }

        [TestMethod]
        public void NameWithDigit() {

            Assert.IsFalse(rolodexValidator.IsValidName("John Do5"));
            Assert.IsFalse(rolodexValidator.IsValidName("5 52"));
            Assert.IsFalse(rolodexValidator.IsValidName("Jane1e"));
        }

        [TestMethod]
        public void NameWithOneCharacter() {

            Assert.IsFalse(rolodexValidator.IsValidName("J"));
        }

        [TestMethod]
        public void NameWithMoreThanTwentyFiveCharacter() {

            Assert.IsFalse(rolodexValidator.IsValidName("".PadLeft(26, 'J')));
        }

        [TestMethod]
        public void NameWithSpecialCharacters() {

            Assert.IsFalse(rolodexValidator.IsValidName("Doe *Ann"));
            Assert.IsFalse(rolodexValidator.IsValidName("Jos&h"));
            Assert.IsFalse(rolodexValidator.IsValidName("#$ !"));
        }

        [TestMethod]
        public void ValidClientName() {

            Assert.IsTrue(rolodexValidator.IsValidName("John Doe"));
            Assert.IsTrue(rolodexValidator.IsValidName("Ji"));
            Assert.IsTrue(rolodexValidator.IsValidName("Ronnie O'Sullivan"));
        }

        [TestMethod]
        public void EmptyPhoneNumber() {

            Assert.IsFalse(rolodexValidator.IsValidPhoneNumber(""));
            Assert.IsFalse(rolodexValidator.IsValidPhoneNumber("".PadLeft(5, " "[0])));
        }

        [TestMethod]
        public void InvalidPhoneNumber() {

            phoneNumberValidator.Setup(mock => mock.IsValidPhoneNumber(It.IsAny<string>()))
                                .Returns(false);

            Assert.IsFalse(rolodexValidator.IsValidPhoneNumber("HJ2042990292"));
        }

        [TestMethod]
        public void ValidPhoneNumber() {

            phoneNumberValidator.Setup(mock => mock.IsValidPhoneNumber(It.IsAny<string>()))
                                .Returns(true);

            Assert.IsTrue(rolodexValidator.IsValidPhoneNumber("(647)299-0292"));
        }

        [TestMethod]
        public void EmptyAddress() {

            Assert.IsFalse(rolodexValidator.IsValidAddress(""));
            Assert.IsFalse(rolodexValidator.IsValidAddress("".PadLeft(20, " "[0])));
        }

        [TestMethod]
        public void AddressLengthLessThanSixCharacters() {

            Assert.IsFalse(rolodexValidator.IsValidAddress("Zoo"));
        }

        [TestMethod]
        public void AddressLengthMoreThanFiftyCharacters() {

            Assert.IsFalse(rolodexValidator.IsValidAddress("".PadLeft(51, 'A')));
        }

        [TestMethod]
        public void AddressWithSpecialCharacters() {

            Assert.IsFalse(rolodexValidator.IsValidAddress("3!@30*4 !#$Is^sac Dr."));
        }

        [TestMethod]
        public void ValidAddress() {

            Assert.IsTrue(rolodexValidator.IsValidAddress("3304 Issac Dr."));
        }

        [TestMethod]
        public void EmailLessThanSixCharacters() {

            Assert.IsFalse(rolodexValidator.IsValidEmail("x@x.c"));
        }

        [TestMethod]
        public void EmailMoreThanFortyCharacters() {

            Assert.IsFalse(rolodexValidator.IsValidEmail("".PadLeft(37, 'x') + "@x.com"));
        }

        [TestMethod]
        public void InvalidEmailFormat() {

            Assert.IsFalse(rolodexValidator.IsValidEmail("xx x@ x.com"));
            Assert.IsFalse(rolodexValidator.IsValidEmail("xxx@xcom"));
            Assert.IsFalse(rolodexValidator.IsValidEmail("xxx~xx.com"));
        }

        [TestMethod]
        public void ValidEmail() {

            Assert.IsTrue(rolodexValidator.IsValidEmail("name1234@example.com"));
            Assert.IsTrue(rolodexValidator.IsValidEmail("xx_x@example.org"));
            Assert.IsTrue(rolodexValidator.IsValidEmail("xxxxx@xx.com"));
        }

        [TestMethod]
        public void IsEmptySearchText() {

            string searchText = string.Empty;
            string placeholder = "some text";

            Assert.IsFalse(rolodexValidator.IsValidSearchText(searchText, placeholder));
        }

        [TestMethod]
        public void SearchTextIsPlaceholder() {

            string placeholder = "some text";
            string searchText = placeholder;

            Assert.IsFalse(rolodexValidator.IsValidSearchText(searchText, placeholder));
        }

        [TestMethod]
        public void ValidSearchText() {

            string searchText = "some text";
            string placeholder = "everything but placeholder";

            Assert.IsTrue(rolodexValidator.IsValidSearchText(searchText, placeholder));
        }

        [TestMethod]
        public void HasInputErrors() {

            string[] inputs = { "", "", "", "" };
            var errors = rolodexValidator.FindInputErrors(inputs);

            Assert.AreEqual(4, errors.Length);
            Assert.AreEqual("email", errors[2].Type);
        }

        [TestMethod]
        public void HasNoInputError() {

            phoneNumberValidator.Setup(mock => mock.IsValidPhoneNumber(It.IsAny<string>()))
                                .Returns(true);

            string[] inputs = { "name", "(647)123-1122", "xxx@xxx.com", "xxxxx dr." };
            var errors = rolodexValidator.FindInputErrors(inputs);

            Assert.AreEqual(0, errors.Length);
        }
    }
}
