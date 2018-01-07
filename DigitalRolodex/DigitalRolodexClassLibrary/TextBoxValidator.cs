using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DigitalRolodexClassLibrary {
    public class TextBoxValidator : ITextBoxValidator {

        public bool IsEmpty(TextBoxBase textBox) {

            if(textBox.GetType() == typeof(MaskedTextBox)) {

                return !Regex.IsMatch(textBox.Text, @"\d");
            }

            return textBox.Text.Trim() == string.Empty;
        }

        public bool HasEmptyField(TextBoxBase[] textBoxes) {

            return textBoxes.Any(textBox => IsEmpty(textBox));
        }
    }
}