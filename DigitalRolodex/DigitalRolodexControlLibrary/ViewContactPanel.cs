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
            CollapseEditPanel();
        }

        public void CollapseEditPanel() {

            if(!EditPanelOff) {

                EditContactPanel.Height = 0;
                EditPanelOff = !EditPanelOff;
            }
        }

        private void StartExpand() {

            EditPanelTimer.Tick += this.PanelExpanding;
            EditPanelTimer.Start();
        }

        private void ExpandEditPanel() {

            if(EditPanelOff) {

                StartExpand();
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
            CollapseEditPanel();
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

            ContactDisplayTable.ClearSelection();
        }

        private void ContactDisplayTableCellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {

            if(ContactDisplayTable.SelectedRows.Count == 1) {

                ExpandEditPanel();
            }
        }
        #endregion

        private void PanelExpanding(object sender, EventArgs e) {

            int maxHeight = (int)(this.Height * 0.2);
            EditContactPanel.Height = Math.Min(maxHeight, EditContactPanel.Height + 10);

            if(EditContactPanel.Height == maxHeight) {

                EditPanelTimer.Tick -= this.PanelExpanding;
                EditPanelTimer.Stop();
                EditPanelOff = !EditPanelOff;
            }
        }
    }
}