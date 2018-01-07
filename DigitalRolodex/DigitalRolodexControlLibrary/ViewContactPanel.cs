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
    public partial class ViewContactPanel : UserControl {

        #region Custom Events
        public delegate void ContactUpdatingHandler(object sender, EventArgs e);
        public delegate void ContactDeletingHandler(object sender, EventArgs e);

        public event ContactUpdatingHandler OnContactUpdating;
        public event ContactDeletingHandler OnContactDeleting;
        #endregion

        private bool EditPanelOff { get; set; }

        #region Public Properties
        public int SelectedID {

            get {

                var idCell = ContactDisplayTable.SelectedRows[0].Cells[0];

                return int.Parse(idCell.FormattedValue.ToString());
            }
        }
        #endregion

        public ViewContactPanel() {

            InitializeComponent();
            ContactDisplayTable.AutoGenerateColumns = true;
            Reset();
        }

        private void Reset() {

            ContactDisplayTable.ClearSelection();
            CollapseEditPanel();
        }

        private void CollapseEditPanel() {

            if(!EditPanelOff) {

                EditContactPanel.Height = 0;
                EditPanelOff = !EditPanelOff;
            }
        }

        private void ExpandEditPanel() {

            if(EditPanelOff) {
            
                EditContactPanel.Height = (int)(this.Height * 0.2);
                EditPanelOff = !EditPanelOff;
            }
        }

        public void ShowContacts(DataSet contacts) {

            ContactDisplayTable.DataSource = contacts;
            ContactDisplayTable.DataMember = "Contact";
            ContactDisplayTable.Columns["id"].Visible = false;
        }

        #region Button Event Listeners
        private void UpdateButtonClick(object sender, EventArgs e) {

            OnContactUpdating(sender, e);
        }

        private void DeleteButtonClick(object sender, EventArgs e) {

            OnContactDeleting(sender, e);
        }

        private void ButtonMouseEnter(object sender, EventArgs e) {

            ((Button)sender).ForeColor = Color.Red;
        }

        private void ButtonMouseLeave(object sender, EventArgs e) {

            ((Button)sender).ForeColor = SystemColors.ControlText;
        }

        private void ButtonMouseDown(object sender, MouseEventArgs e) {

            ((Button)sender).ForeColor = SystemColors.ControlLightLight;
        }

        private void ButtonMouseUp(object sender, MouseEventArgs e) {

            ((Button)sender).ForeColor = Color.Red;
        }
        #endregion

        #region Contact Display Table Event Listeners
        private void ContactDisplayTableDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {

            Reset();
        }

        private void ContactDisplayTableRowEnter(object sender, DataGridViewCellEventArgs e) {

            ExpandEditPanel();
        }
        #endregion
    }
}