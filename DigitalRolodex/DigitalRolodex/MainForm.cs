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
        private bool SidebarExpanded { get; set; }
        private string[] OptionButtonText { get; set; }

        private bool Maximized {

            get {

                return WindowState == FormWindowState.Maximized;
            }
        }

        public MainForm() {

            InitializeComponent();
            SidebarExpanded = true;
        }

        private void SetButtonBackColor(Button button, Color color) {

            button.BackColor = color;
        }

        private void SetButtonBackColor(IEnumerable<Button> buttons, Color color) {

            foreach(Button button in buttons) {

                SetButtonBackColor(button, color);
            }
        }

        private void SetActiveAppearance(Button button, Color color) {

            SetButtonBackColor(button, color);
            button.Paint += this.DrawActiveIndicator;
        }

        private void ResetButtonAppearance(IEnumerable<Button> buttons, Color color) { 
        
            SetButtonBackColor(buttons, color);

            foreach(Button button in buttons) {

                button.Paint -= this.DrawActiveIndicator;
            }
        }

        private void UpdateOptionButtonAppearance(Button button) {

            ResetButtonAppearance(GetOptionButtons(), Color.FromArgb(31, 38, 51));
            SetActiveAppearance(button, button.FlatAppearance.MouseOverBackColor);
        }

        private IEnumerable<Button> GetOptionButtons() {

            return SidebarButtonLayout.Controls.OfType<Button>();
        }

        private string[] GetOptionButtonText() {

            return GetOptionButtons().Select(button => button.Text).ToArray();
        }

        private void CollapseSidebar() {

            OptionButtonText = GetOptionButtonText();

            foreach(Button button in GetOptionButtons()) {

                button.ImageAlign = ContentAlignment.MiddleCenter;
                button.Text = string.Empty;
            }

            LogoBox.Visible = false;
            Sidebar.Width = Sidebar.Width / 3;
        }

        private void ExpandSidebar() {

            int index = 0;

            foreach(Button button in GetOptionButtons()) {

                button.ImageAlign = ContentAlignment.MiddleRight;
                button.Text = OptionButtonText[index++];
            }

            LogoBox.Visible = true;
            Sidebar.Width = Sidebar.Width * 3;
        }

        private void ShowPanel(Panel panel) {

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

        private void ToggleSidebar(object sender, EventArgs e) {

            if(SidebarExpanded) CollapseSidebar();
            else ExpandSidebar();

            SidebarExpanded = !SidebarExpanded;
        }

        private void DrawActiveIndicator(object sender, PaintEventArgs e) {

            var button = (Button)sender;
            var color = Color.FromArgb(248, 251, 50);
            int width = (int)(button.Width * (SidebarExpanded ? 0.025 : 0.075));

            e.Graphics.FillRectangle(new SolidBrush(color), 0, 0, width, button.Height);
        }

        private void NewContactButtonClick(object sender, EventArgs e) {

            UpdateOptionButtonAppearance((Button)sender);
            ShowPanel(NewContactPanel);
        }

        private void ViewContactButtonClick(object sender, EventArgs e) {

            UpdateOptionButtonAppearance((Button)sender);
            ShowPanel(ViewContactPanel);
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

        private void MinimizeClick(object sender, EventArgs e) {

            WindowState = FormWindowState.Minimized;
        }

        private void ExitClick(object sender, EventArgs e) {

            Application.Exit();
        }
    }
}