using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DigitalRolodexControlLibrary {
    public partial class NewContactPanel : UserControl {

        public delegate void ContactAddingHandler(object sender, EventArgs e);

        public event ContactAddingHandler OnContactAdding;

        #region Input Boxes and Validation Labels
        private TextBoxBase[] InputBoxes { get; set; }
        private Label[] ErrorDisplays { get; set; }
        private Dictionary<TextBoxBase, Label> ErrorDisplayLink { get; set; }
        #endregion

        #region Input Field Values
        public string[] Inputs {

            get {

                return new string[] {
                
                    NameInputTextBox.Text.Trim(),
                    PhoneInputTextBox.Text.Trim(),
                    EmailInputTextBox.Text.Trim(),
                    AddressInputTextBox.Text.Trim()
                };
            }
        }
        #endregion

        public NewContactPanel() {

            InitializeComponent();
            LoadAssets();
        }

        private void LoadAssets() {

            InputBoxes = AddInputBoxes();
            ErrorDisplays = AddErrorDisplays();
            ErrorDisplayLink = LinkErrorDisplays();
        }

        public void Reset() {

            foreach(var textBox in InputBoxes) {

                textBox.Clear();
                GetErrorDisplay(textBox).Text = string.Empty;
            }
        }

        #region Resources Setups and Initializations
        private TextBoxBase[] AddInputBoxes() { 
        
            var textBoxes = new List<TextBoxBase>();
            textBoxes.Add(NameInputTextBox);
            textBoxes.Add(PhoneInputTextBox);
            textBoxes.Add(EmailInputTextBox);
            textBoxes.Add(AddressInputTextBox);

            return textBoxes.ToArray();
        }

        private Label[] AddErrorDisplays() { 
        
            var displays = new List<Label>();
            displays.Add(NameValidationLabel);
            displays.Add(PhoneValidationLabel);
            displays.Add(EmailValidationLabel);
            displays.Add(AddressValidationLabel);

            return displays.ToArray();
        }

        private Dictionary<TextBoxBase, Label> LinkErrorDisplays() {

            var link = new Dictionary<TextBoxBase, Label>();

            for(int i = 0; i < InputBoxes.Length; i++) {

                link[InputBoxes[i]] = ErrorDisplays[i];
            }

            return link;
        }
        #endregion

        #region Handle Error Display
        private Label GetErrorDisplay(TextBoxBase textBox) { 
        
            if(!ErrorDisplayLink.ContainsKey(textBox)) {

                return null;
            }

            return ErrorDisplayLink[textBox];
        }

        private void ShowError(Label errorDisplay, string message) {

            errorDisplay.Text = message;
        }

        private void RemoveError(Label errorDisplay) {

            errorDisplay.Text = string.Empty;
        }

        public void ShowErrors(string[] errors) { 
        
            foreach(string error in errors) {

                if(error == "name") {

                    ShowError(GetErrorDisplay(NameInputTextBox), "* Invalid Name (Length: 2-25)");
                }
                else if(error == "phone") {

                    ShowError(GetErrorDisplay(PhoneInputTextBox), "* Invalid Phone Number");
                }
                else if(error == "email") {

                    ShowError(GetErrorDisplay(EmailInputTextBox), "* Invalid Email (xxx@example.com)");
                }
                else if(error == "address") {

                    ShowError(GetErrorDisplay(AddressInputTextBox), "* Invalid Address (Length: 6-50)");
                }
            }
        }
        #endregion

        #region Check for Empty Fields
        private bool IsEmpty(TextBoxBase textBox) { 
        
            if(textBox.GetType() == typeof(TextBox)) {

                return textBox.Text.Trim() == string.Empty;
            }

            return !Regex.IsMatch(textBox.Text, @"\d");
        }

        private bool CheckEmptyFields() {

            bool hasError = false;

            foreach(var textBox in InputBoxes) {

                if(IsEmpty(textBox)) {

                    hasError = true;
                    ShowError(GetErrorDisplay(textBox), "* Field Required");
                }
            }

            return hasError;
        }
        #endregion

        public void ShowSuccessMessage() {

            SuccessMessageLabel.ForeColor = Color.Red;
            StartFadeOut();
        }

        private void StartFadeOut() {

            this.FadeTimer.Tick += this.FadeOut;
            this.FadeTimer.Start();
        }

        #region Text Fade Event Listeners
        private void FadeOut(object sender, EventArgs e) {

            int r = Math.Max(SuccessMessageLabel.ForeColor.R - 5, 32);
            int g = Math.Max(SuccessMessageLabel.ForeColor.G - 1, 40);
            int b = Math.Max(SuccessMessageLabel.ForeColor.B - 1, 55);

            SuccessMessageLabel.ForeColor = Color.FromArgb(r, g, b);

            if(r == 32 && g == 40 && b == 55) {

                this.FadeTimer.Tick -= this.FadeOut;
                this.FadeTimer.Stop();
            }
        }
        #endregion

        #region Input Boxes Event Listeners
        private void InputTextChanged(object sender, EventArgs e) {

            var textBox = (TextBoxBase)sender;

            if(!IsEmpty(textBox)) {
            
                RemoveError(GetErrorDisplay(textBox));
            }
        }
        #endregion

        #region Add Contact Button Event Listeners
        private void AddContactButtonClick(object sender, EventArgs e) {

            bool hasError = CheckEmptyFields();

            if(!hasError) {

                OnContactAdding(sender, e);
            }
        }

        private void AddContactButtonMouseEnter(object sender, EventArgs e) {

            ((Button)sender).BackgroundImage = Properties.Resources.round_button_darkpink;
        }

        private void AddContactButtonMouseLeave(object sender, EventArgs e) {

            ((Button)sender).BackgroundImage = Properties.Resources.round_button_lightpink;
        }

        private void AddContactButtonMouseDown(object sender, MouseEventArgs e) {

            ((Button)sender).BackgroundImage = Properties.Resources.round_button_lightgreen;
        }

        private void AddContactButtonMouseUp(object sender, MouseEventArgs e) {

            ((Button)sender).BackgroundImage = Properties.Resources.round_button_darkpink;
        }
        #endregion

        #region Reset Input Button Event Listeners
        private void ResetInputButtonClick(object sender, EventArgs e) {

            Reset();
        }

        private void ResetInputButtonMouseEnter(object sender, EventArgs e) {

            ((Button)sender).BackgroundImage = Properties.Resources.round_button_blue;
        }

        private void ResetInputButtonMouseLeave(object sender, EventArgs e) {

            ((Button)sender).BackgroundImage = Properties.Resources.round_button_lightskyblue;
        }

        private void ResetInputButtonMouseDown(object sender, MouseEventArgs e) {

            ((Button)sender).BackgroundImage = Properties.Resources.round_button_lightgreen;
        }

        private void ResetInputButtonMouseUp(object sender, MouseEventArgs e) {

            ((Button)sender).BackgroundImage = Properties.Resources.round_button_blue;
        }
        #endregion
    }
}