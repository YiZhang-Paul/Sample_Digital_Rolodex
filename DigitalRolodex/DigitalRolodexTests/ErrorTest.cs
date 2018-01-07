using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitalRolodexClassLibrary;

namespace DigitalRolodexTests {
    [TestClass]
    public class ErrorTest {

        Error error;

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "Type Cannot be Empty.")]
        public void EmptyType() {

            error = new Error("".PadLeft(10, " "[0]), "some message");
        }

        [TestMethod]
        public void NonEmptyType() {

            string type = "some type";
            error = new Error(type, "some message");

            Assert.AreEqual(type, error.Type);
        }
    }
}