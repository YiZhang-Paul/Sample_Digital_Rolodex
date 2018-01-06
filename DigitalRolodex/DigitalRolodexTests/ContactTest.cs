using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitalRolodexClassLibrary;

namespace DigitalRolodexTests {
    [TestClass]
    public class ContactTest {

        Contact contact;

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "Phone Number Must Contain Exactly 10 Digits.")]
        public void PhoneDigitsLengthExceeded() {

            contact = new Contact("", "(647)131-21241", "", "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "Phone Number Must Contain Exactly 10 Digits.")]
        public void NotEnoughDigitsInPhoneNumber() {

            contact = new Contact("", "(647)131-211", "", "");
        }

        [TestMethod]
        public void PhoneNumberFormatted() {

            contact = new Contact("", "*647!13@10211", "", "");

            Assert.AreEqual("(647)131-0211", contact.Phone);
        }
    }
}