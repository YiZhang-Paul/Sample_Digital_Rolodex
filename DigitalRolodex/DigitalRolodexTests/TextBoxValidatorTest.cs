using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using DigitalRolodexClassLibrary;

namespace DigitalRolodexTests {
    [TestClass]
    public class TextBoxValidatorTest {

        TextBoxValidator validator;

        [TestInitialize]
        public void Setup() {

            validator = new TextBoxValidator();
        }

        [TestMethod]
        public void EmptyTextBox() {

            var textBox = new TextBox();

            Assert.IsTrue(validator.IsEmpty(textBox));
        }

        [TestMethod]
        public void NonEmptyTextBox() {

            var textBox = new TextBox();
            textBox.Text = "some text";

            Assert.IsFalse(validator.IsEmpty(textBox));
        }

        [TestMethod]
        public void EmptyMaskedTextBox() {

            var textBox = new MaskedTextBox("(000)000-0000");

            Assert.IsTrue(validator.IsEmpty(textBox));
        }

        [TestMethod]
        public void NonEmptyMaskedTextBox() {

            var textBox = new MaskedTextBox("(000)000-0000");
            textBox.Text = "123";

            Assert.IsFalse(validator.IsEmpty(textBox));
        }

        [TestMethod]
        public void NoFieldIsEmpty() {

            var textBox1 = new TextBox();
            textBox1.Text = "some text";
            var textBox2 = new TextBox();
            textBox2.Text = "some text";
            var textBox3 = new TextBox();
            textBox3.Text = "some text";
            var maskedTextBox = new MaskedTextBox("(000)000-0000");
            maskedTextBox.Text = "123";

            TextBoxBase[] textBoxes = { 
                         
                textBox1,
                textBox2,
                textBox3,
                maskedTextBox
            };

            Assert.IsFalse(validator.HasEmptyField(textBoxes));
        }

        [TestMethod]
        public void AllFieldsAreEmpty() {

            TextBoxBase[] textBoxes = { 
                         
                new TextBox(),
                new TextBox(),
                new TextBox(),
                new MaskedTextBox("(000)000-0000"),
                new MaskedTextBox("(000)000-0000")
            };

            Assert.IsTrue(validator.HasEmptyField(textBoxes));
        }

        [TestMethod]
        public void SomeFieldsAreEmpty() {

            var nonEmpty = new TextBox();
            nonEmpty.Text = "some text";

            TextBoxBase[] textBoxes = { 
                         
                new TextBox(),
                new TextBox(),
                nonEmpty,
                new MaskedTextBox("(000)000-0000"),
                new MaskedTextBox("(000)000-0000")
            };

            Assert.IsTrue(validator.HasEmptyField(textBoxes));
        }
    }
}