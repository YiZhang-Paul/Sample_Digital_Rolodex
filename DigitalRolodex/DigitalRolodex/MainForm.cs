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
using DigitalRolodexControlLibrary;

namespace DigitalRolodex {
    public partial class MainForm : Form {

        #region Private Fields
        private IContactDataAccess DataAccess { get; set; }
        private RolodexValidator Validator { get; set; }
        private UpdateContactPanel UpdateContactPanel { get; set; }
        private DataSet Contacts { get; set; }
        private Point MouseXY { get; set; }
        private bool Maximized { get { return WindowState == FormWindowState.Maximized; } }
        #endregion

        public MainForm() {

            InitializeComponent();
            LoadAssets();
            LoadContact();
        }

        #region Setups and Initializations
        private void CreateValidators() {

            DataAccess = new ContactDataAccess();
            var phoneValidator = new PhoneNumberValidator("areaCode.txt");
            Validator = new RolodexValidator(phoneValidator);
        }

        private void AddUpdateContactPanel() { 
        
            UpdateContactPanel = new UpdateContactPanel();
            UpdateContactPanel.Dock = DockStyle.Fill;
            UpdateContactPanel.Visible = false;
            UpdateContactPanel.OnContactAdding += this.UpdateContactPanelOnContactAdding;
            UserViewPanel.Controls.Add(UpdateContactPanel);
        }

        private void InjectServices() {

            var service = new TextBoxValidator();
            NewContactPanel.InjectService(service);
            UpdateContactPanel.InjectService(service);
        }

        private void LoadAssets() {

            CreateValidators();
            AddUpdateContactPanel();
            InjectServices();
        }
        #endregion

        private void ShowPanel(UserControl panel) {

            panel.Visible = true;
            panel.BringToFront();
        }

        private Contact CreateContact(IInputPanel panel) {

            string name = panel.Inputs[0];
            string phone = panel.Inputs[1];
            string email = panel.Inputs[2];
            string address = panel.Inputs[3];

            return new Contact(name, phone, email, address);
        }

        private void LoadUpdateInformation() {

            int id = ViewContactPanel.SelectedID;
            var toUpdate = Contacts.Tables["Contact"]
                                   .AsEnumerable()
                                   .Where(contact => contact.Field<int>("id") == id)
                                   .First();

            UpdateContactPanel.LoadContact(toUpdate);
        }

        #region CRUD Operations Handling
        private void AddContact() {

            DataAccess.Insert(CreateContact(NewContactPanel));
            LoadContact();
        }

        private void LoadContact() {

            Contacts = DataAccess.Retrieve();
            ViewContactPanel.ShowContacts(Contacts);
        }

        private void UpdateContact() {

            var contact = CreateContact(UpdateContactPanel);
            DataAccess.Update(contact, ViewContactPanel.SelectedID);
            LoadContact();
        }

        private void DeleteContact() {

            DataAccess.Delete(ViewContactPanel.SelectedID);
            LoadContact();
        }
        #endregion

        #region User Control Event Listeners
        private void SidebarOnOptionSelected(object sender, EventArgs e) {

            string tag = ((Button)sender).Tag.ToString();

            if(tag == "newContact") ShowPanel(NewContactPanel);
            else if(tag == "viewContact") ShowPanel(ViewContactPanel);
        }

        private void NewContactPanelOnContactAdding(object sender, EventArgs e) {

            var errors = Validator.FindInputErrors(NewContactPanel.Inputs);

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

            ShowPanel(UpdateContactPanel);
            LoadUpdateInformation();
        }

        private void ViewContactPanelOnContactDeleting(object sender, EventArgs e) {

            DeleteContact();
        }

        private void UpdateContactPanelOnContactAdding(object sender, EventArgs e) {

            var errors = Validator.FindInputErrors(UpdateContactPanel.Inputs);

            if(errors.Length > 0) {

                UpdateContactPanel.ShowInvalidFields(errors);
            }
            else {

                UpdateContact();
                ViewContactPanel.CollapseEditPanel();
                UpdateContactPanel.Reset();
                UpdateContactPanel.Visible = false;
            }
        }

        private void SearchBoxOnSearch(object sender, EventArgs e) {

            //TODO: not yet implemented
        }
        #endregion

        #region Basic UI Control Event Listeners
        private void GetMouseLocation(object sender, MouseEventArgs e) {

            MouseXY = e.Location;
        }

        private void DragWindow(object sender, MouseEventArgs e) {

            if(e.Button == MouseButtons.Left) {

                Top += e.Y - MouseXY.Y;
                Left += e.X - MouseXY.X;
            }
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

        private void ToggleWindowSize(object sender, EventArgs e) {

            WindowState = Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void MinimizeButtonClick(object sender, EventArgs e) {

            WindowState = FormWindowState.Minimized;
        }

        private void ExitButtonClick(object sender, EventArgs e) {

            Application.Exit();
        }
        #endregion
    }
}