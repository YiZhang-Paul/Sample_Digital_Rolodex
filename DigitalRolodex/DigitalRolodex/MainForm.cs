using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalRolodex {
    public partial class MainForm : Form {

        private Point MouseXY { get; set; }

        private bool Maximized {

            get {

                return WindowState == FormWindowState.Maximized;
            }
        }

        public MainForm() {

            InitializeComponent();
        }

        private void ShowPanel(UserControl panel) {

            panel.Visible = true;
            panel.BringToFront();
        }
        /**
         * event listeners
         */
        private void GetMouseXY(object sender, MouseEventArgs e) {

            MouseXY = e.Location;
        }

        private void DragWindow(object sender, MouseEventArgs e) {

            if(e.Button == MouseButtons.Left) {

                Top += e.Y - MouseXY.Y;
                Left += e.X - MouseXY.X;
            }
        }

        private void MinimizeButtonEnter(object sender, EventArgs e) {

            ((Button)sender).ForeColor = SystemColors.ControlDarkDark;
        }

        private void ExitButtonEnter(object sender, EventArgs e) {

            ((Button)sender).ForeColor = Color.FromArgb(204, 44, 68);
        }

        private void ButtonLeave(object sender, EventArgs e) {

            ((Button)sender).ForeColor = SystemColors.ControlDark;
        }

        private void ToggleWindowSize(object sender, EventArgs e) {

            WindowState = Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void MinimizeClick(object sender, EventArgs e) {

            WindowState = FormWindowState.Minimized;
        }

        private void ExitClick(object sender, EventArgs e) {

            Application.Exit();
        }
    }
}