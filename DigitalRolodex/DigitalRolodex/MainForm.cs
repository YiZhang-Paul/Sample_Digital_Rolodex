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

        private RolodexValidator Validator { get; set; }
        private Point MouseXY { get; set; }
        private bool Maximized { get { return WindowState == FormWindowState.Maximized; } }

        public MainForm() {

            InitializeComponent();
            var phoneValidator = new PhoneNumberValidator("areaCode.txt");
            Validator = new RolodexValidator(phoneValidator);
        }

        private void ShowPanel(UserControl panel) {

            panel.Visible = true;
            panel.BringToFront();
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

            //TODO: On Contact Adding Event Handling
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