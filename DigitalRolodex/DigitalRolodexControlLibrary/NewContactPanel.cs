using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalRolodexControlLibrary {
    public partial class NewContactPanel : UserControl {

        public delegate void ContactAddingHandler(object sender, EventArgs e);
        public event ContactAddingHandler OnContactAdding;

        #region Input Field Values
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        #endregion

        public NewContactPanel() {

            InitializeComponent();
        }

        #region Add Contact Button Event Listeners
        private void AddContactButtonClick(object sender, EventArgs e) {

            OnContactAdding(sender, e);
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

            NameInputTextBox.Clear();
            PhoneInputTextBox.Clear();
            EmailInputTextBox.Clear();
            AddressInputTextBox.Clear();
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