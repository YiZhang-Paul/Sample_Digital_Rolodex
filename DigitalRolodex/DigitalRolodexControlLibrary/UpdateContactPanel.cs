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
    public partial class UpdateContactPanel : NewContactPanel {

        public UpdateContactPanel() {

            InitializeComponent();
            AddCustomStyle();
            AddCustomHandler();
        }

        public void LoadContact(DataRow information) {

            NameInputBox.Text = information.Field<string>("Name");
            PhoneInputBox.Text = information.Field<string>("Phone");
            EmailInputBox.Text = information.Field<string>("Email");
            AddressInputBox.Text = information.Field<string>("Address");
        }

        #region Custom Style and Events Handling
        private void AddCustomStyle() {

            AddButton.Text = "Update";
            AddButton.Image = Properties.Resources.save_contact_button;
            ResetButton.Text = "Cancel";
            ResetButton.Image = Properties.Resources.delete_contact_button;
        }

        private void AddCustomHandler() {

            ResetButton.Click += this.CancelButtonClick;
        }
        #endregion

        private void CancelButtonClick(object sender, EventArgs e) {

            this.Visible = false;
        }
    }
}