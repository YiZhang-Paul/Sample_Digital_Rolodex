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

        public delegate void SearchHandler(object sender, EventArgs e);
        
        public event SearchHandler OnSearch;

        private string PlaceHolder { get; set; }

        public string SearchText { get { return InputBox.Text; } }

        public SearchBox() {

            InitializeComponent();
        }

        private bool IsValidSearchText() {

            string text = InputBox.Text.Trim();

            return text != string.Empty && text != PlaceHolder;
        }

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

        #region Search Box Event Listeners
        private void InputBoxKeyUp(object sender, KeyEventArgs e) {
            //search when enter key is pressed
            if(e.KeyValue == 13 && IsValidSearchText()) {

                OnSearch(sender, e);
            }
        }

        private void InputBoxTextChanged(object sender, EventArgs e) {

            if(IsValidSearchText()) {

                OnSearch(sender, e);
            }
        }

        private void InputBoxEnter(object sender, EventArgs e) {

            SearchIconBox.Visible = false;
            PlaceHolder = InputBox.Text;
            InputBox.Clear();
            InputBox.ForeColor = SystemColors.ControlText;
            InputBox.BackColor = SystemColors.ControlDarkDark;
            this.Width *= 2;
            AddSearchIcon();
        }

        private void InputBoxLeave(object sender, EventArgs e) {

            SearchIconBox.Visible = true;
            InputBox.Text = PlaceHolder;
            InputBox.ForeColor = SystemColors.ControlDarkDark;
            InputBox.BackColor = Color.DarkGray;
            this.Width /= 2;
            RemoveSearchIcon();
        }
        #endregion
    }
}