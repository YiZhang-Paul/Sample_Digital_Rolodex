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
    public partial class SearchBox : UserControl {

        #region Custom Events
        public delegate void SearchHandler(object sender, EventArgs e);
        
        public event SearchHandler OnSearch;
        #endregion

        #region Public Properties
        public string PlaceHolder { get; private set; }
        public string SearchText { get { return InputBox.Text; } }
        #endregion

        public SearchBox() {

            InitializeComponent();
        }

        #region Search Box Styles and Appearances
        private void AddSearchIcon() {

            var icon = new Label();
            icon.AutoSize = false;
            icon.BackColor = Color.Transparent;
            icon.Text = string.Empty;
            icon.Image = Properties.Resources.search;
            icon.ImageAlign = ContentAlignment.MiddleCenter;
            icon.Size = icon.Image.Size;
            icon.Parent = InputBox;
            icon.Location = new Point(icon.Parent.ClientSize.Width - icon.Image.Width, 0);
        }

        private void RemoveSearchIcon() { 
        
            foreach(Label icon in InputBox.Controls.OfType<Label>()) {

                icon.Dispose();
            }
        }

        private void SetBoxStyle(Color foreColor, Color backColor) {

            InputBox.ForeColor = foreColor;
            InputBox.BackColor = backColor;
        }

        private void ExpandSearchBox() {

            SearchIconBox.Visible = false;
            PlaceHolder = InputBox.Text;
            InputBox.Clear();
            this.Width *= 2;
        }

        private void ShrinkSearchBox() {

            SearchIconBox.Visible = true;
            InputBox.Text = PlaceHolder;
            this.Width /= 2;
        }
        #endregion

        #region Search Box Event Listeners
        private void InputBoxTextChanged(object sender, EventArgs e) {

            OnSearch(sender, e);
        }

        private void InputBoxEnter(object sender, EventArgs e) {

            ExpandSearchBox();
            SetBoxStyle(SystemColors.ControlText, SystemColors.ControlDarkDark);
            AddSearchIcon();
        }

        private void InputBoxLeave(object sender, EventArgs e) {

            ShrinkSearchBox();
            SetBoxStyle(SystemColors.ControlDarkDark, Color.DarkGray);
            RemoveSearchIcon();
        }
        #endregion
    }
}