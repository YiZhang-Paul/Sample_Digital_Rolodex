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
    public partial class Sidebar : UserControl {

        #region Custom Events
        public delegate void OptionSelectedHandler(object sender, EventArgs e);

        public event OptionSelectedHandler OnOptionSelected;
        #endregion

        private bool Collapsed { get; set; }
        private string[] ButtonText { get; set; }

        public Sidebar() {

            InitializeComponent();
        }

        private IEnumerable<Button> GetOptionButtons() {

            return SidebarButtonLayout.Controls.OfType<Button>();
        }

        private void ResetButtonStyle(IEnumerable<Button> buttons, Color color) {

            foreach(Button button in buttons) {

                button.BackColor = color;
                button.Paint -= this.DrawMarker;
            }
        }

        private void UpdateButtonStyle(IEnumerable<Button> buttons, Button activeButton) {

            ResetButtonStyle(buttons, Color.FromArgb(31, 38, 51));
            activeButton.BackColor = activeButton.FlatAppearance.MouseOverBackColor;
            activeButton.Paint += this.DrawMarker;
        }

        private void Collapse() {

            var buttons = GetOptionButtons();
            ButtonText = buttons.Select(button => button.Text).ToArray();

            foreach(Button button in buttons) {

                button.ImageAlign = ContentAlignment.MiddleCenter;
                button.Text = string.Empty;
            }

            LogoBox.Visible = false;
            this.Width /= 3;
        }

        private void Expand() {

            int index = 0;

            foreach(Button button in GetOptionButtons()) {

                button.ImageAlign = ContentAlignment.MiddleRight;
                button.Text = ButtonText[index++];
            }

            LogoBox.Visible = true;
            this.Width *= 3;
        }

        #region Event Listeners
        private void ToggleSidebarButtonClick(object sender, EventArgs e) {

            if(Collapsed) Expand();
            else Collapse();

            Collapsed = !Collapsed;
        }

        private void NewContactButtonClick(object sender, EventArgs e) {

            UpdateButtonStyle(GetOptionButtons(), (Button)sender);
            OnOptionSelected(sender, e);
        }

        private void ViewContactButtonClick(object sender, EventArgs e) {

            UpdateButtonStyle(GetOptionButtons(), (Button)sender);
            OnOptionSelected(sender, e);
        }

        private void DrawMarker(object sender, PaintEventArgs e) {

            var button = (Button)sender;
            var color = Color.FromArgb(248, 251, 50);
            int width = (int)(button.Width * (Collapsed ? 0.075 : 0.025));

            e.Graphics.FillRectangle(new SolidBrush(color), 0, 0, width, button.Height);
        }
        #endregion
    }
}