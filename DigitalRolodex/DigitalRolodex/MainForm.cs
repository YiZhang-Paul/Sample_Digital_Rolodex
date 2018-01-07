using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigitalRolodexClassLibrary;

namespace DigitalRolodex {
    public partial class MainForm : Form {

        //TODO: Refactor
        private IContactDataAccess DataAccess { get; set; }
        private DataSet Contacts { get; set; }



        private RolodexValidator Validator { get; set; }
        private Point MouseXY { get; set; }
        private bool Maximized { get { return WindowState == FormWindowState.Maximized; } }

        public MainForm() {

            InitializeComponent();
            var phoneValidator = new PhoneNumberValidator("areaCode.txt");
            Validator = new RolodexValidator(phoneValidator);
            NewContactPanel.InjectValidator(new TextBoxValidator());

            //TODO: Refactor
            DataAccess = new ContactDataAccess();
            LoadContacts();
        }

        private void LoadContacts() {

            Contacts = DataAccess.Retrieve();
            ViewContactPanel.ShowContacts(Contacts);
        }

        private void ShowPanel(UserControl panel) {

            panel.Visible = true;
            panel.BringToFront();
        }

        private string[] CheckInputErrors(string[] inputs) {

            var errors = new List<string>();

            if(!Validator.IsValidName(inputs[0])) errors.Add("name");
            if(!Validator.IsValidPhoneNumber(inputs[1])) errors.Add("phone");
            if(!Validator.IsValidEmail(inputs[2])) errors.Add("email");
            if(!Validator.IsValidAddress(inputs[3])) errors.Add("address");

            return errors.ToArray();
        }

        private void AddContact() { 
        
            //TODO: not yet implemented

            var inputs = NewContactPanel.Inputs;
            DataAccess.Insert(new Contact(inputs[0], inputs[1], inputs[2], inputs[3]));
            LoadContacts();
        }

        private void UpdateContact() {

            //TODO: not yet implemented
        }

        private void DeleteContact() {

            //TODO: not yet implemented

            DataAccess.Delete(ViewContactPanel.SelectedID);
            LoadContacts();
        }

        #region Event Listeners
        private void SidebarOnOptionSelected(object sender, EventArgs e) {

            switch(((Button)sender).Tag.ToString()) {
            
                case "newContact" :

                    ShowPanel(NewContactPanel);
                    break;

                case "viewContact" :

                    ShowPanel(ViewContactPanel);
                    break;
            }
        }

        private void NewContactPanelOnContactAdding(object sender, EventArgs e) {

            var errors = CheckInputErrors(NewContactPanel.Inputs);

            if(errors.Length > 0) {

                NewContactPanel.ShowInvalidFields(errors);
            }
            else {

                AddContact();
                NewContactPanel.ShowSuccessMessage();
                NewContactPanel.Reset();
            }
        }

        private void ViewContactPanelOnContactUpdating(object sender, EventArgs e) {

            UpdateContact();
        }

        private void ViewContactPanelOnContactDeleting(object sender, EventArgs e) {

            DeleteContact();
        }

        private void SearchBoxOnSearch(object sender, EventArgs e) {

            //TODO: not yet implemented
        }

        private void GetMouseXY(object sender, MouseEventArgs e) {

            MouseXY = e.Location;
        }

        private void DragWindow(object sender, MouseEventArgs e) {

            if(e.Button == MouseButtons.Left) {

                Top += e.Y - MouseXY.Y;
                Left += e.X - MouseXY.X;
            }
        }

        private void ToggleWindowSize(object sender, EventArgs e) {

            WindowState = Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void MinimizeButtonClick(object sender, EventArgs e) {

            WindowState = FormWindowState.Minimized;
        }

        private void MinimizeButtonMouseEnter(object sender, EventArgs e) {

            ((Button)sender).ForeColor = SystemColors.ControlDarkDark;
        }

        private void ExitButtonMouseEnter(object sender, EventArgs e) {

            ((Button)sender).ForeColor = Color.FromArgb(204, 44, 68);
        }

        private void ButtonMouseLeave(object sender, EventArgs e) {

            ((Button)sender).ForeColor = SystemColors.ControlDark;
        }

        private void ExitButtonClick(object sender, EventArgs e) {

            Application.Exit();
        }
        #endregion
    }
}