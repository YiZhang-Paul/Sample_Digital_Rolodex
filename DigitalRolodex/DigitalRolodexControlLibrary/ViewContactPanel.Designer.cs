namespace DigitalRolodexControlLibrary {
    partial class ViewContactPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.EditContactPanel = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ContactDisplayLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ContactDisplayTable = new System.Windows.Forms.DataGridView();
            this.EditPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.EditContactPanel.SuspendLayout();
            this.ContactDisplayLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactDisplayTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EditContactPanel
            // 
            this.EditContactPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.EditContactPanel.Controls.Add(this.UpdateButton);
            this.EditContactPanel.Controls.Add(this.DeleteButton);
            this.EditContactPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditContactPanel.Location = new System.Drawing.Point(0, 348);
            this.EditContactPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EditContactPanel.Name = "EditContactPanel";
            this.EditContactPanel.Size = new System.Drawing.Size(539, 67);
            this.EditContactPanel.TabIndex = 1;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.UpdateButton.BackgroundImage = global::DigitalRolodexControlLibrary.Properties.Resources.round_corner_button_gradient_green;
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateButton.Image = global::DigitalRolodexControlLibrary.Properties.Resources.save_contact_button;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.Location = new System.Drawing.Point(174, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.UpdateButton.Size = new System.Drawing.Size(84, 28);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            this.UpdateButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
            this.UpdateButton.MouseEnter += new System.EventHandler(this.ButtonMouseEnter);
            this.UpdateButton.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            this.UpdateButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseUp);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.DeleteButton.BackgroundImage = global::DigitalRolodexControlLibrary.Properties.Resources.round_corner_button_gradient_green;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Image = global::DigitalRolodexControlLibrary.Properties.Resources.delete_contact_button;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.Location = new System.Drawing.Point(278, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DeleteButton.Size = new System.Drawing.Size(86, 28);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            this.DeleteButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
            this.DeleteButton.MouseEnter += new System.EventHandler(this.ButtonMouseEnter);
            this.DeleteButton.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            this.DeleteButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseUp);
            // 
            // ContactDisplayLayout
            // 
            this.ContactDisplayLayout.ColumnCount = 3;
            this.ContactDisplayLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.ContactDisplayLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.ContactDisplayLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.ContactDisplayLayout.Controls.Add(this.ContactDisplayTable, 1, 1);
            this.ContactDisplayLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactDisplayLayout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactDisplayLayout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContactDisplayLayout.Location = new System.Drawing.Point(0, 0);
            this.ContactDisplayLayout.Margin = new System.Windows.Forms.Padding(0);
            this.ContactDisplayLayout.Name = "ContactDisplayLayout";
            this.ContactDisplayLayout.RowCount = 3;
            this.ContactDisplayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.ContactDisplayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.ContactDisplayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.ContactDisplayLayout.Size = new System.Drawing.Size(539, 348);
            this.ContactDisplayLayout.TabIndex = 2;
            // 
            // ContactDisplayTable
            // 
            this.ContactDisplayTable.AllowUserToAddRows = false;
            this.ContactDisplayTable.AllowUserToDeleteRows = false;
            this.ContactDisplayTable.AllowUserToResizeRows = false;
            this.ContactDisplayTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContactDisplayTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactDisplayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactDisplayTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactDisplayTable.Location = new System.Drawing.Point(43, 27);
            this.ContactDisplayTable.Margin = new System.Windows.Forms.Padding(0);
            this.ContactDisplayTable.MultiSelect = false;
            this.ContactDisplayTable.Name = "ContactDisplayTable";
            this.ContactDisplayTable.ReadOnly = true;
            this.ContactDisplayTable.RowHeadersVisible = false;
            this.ContactDisplayTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContactDisplayTable.ShowEditingIcon = false;
            this.ContactDisplayTable.Size = new System.Drawing.Size(452, 292);
            this.ContactDisplayTable.TabIndex = 5;
            this.ContactDisplayTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ContactDisplayTableCellMouseClick);
            this.ContactDisplayTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ContactDisplayTableDataBindingComplete);
            // 
            // EditPanelTimer
            // 
            this.EditPanelTimer.Interval = 1;
            // 
            // ViewContactPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.ContactDisplayLayout);
            this.Controls.Add(this.EditContactPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ViewContactPanel";
            this.Size = new System.Drawing.Size(539, 415);
            this.EditContactPanel.ResumeLayout(false);
            this.ContactDisplayLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContactDisplayTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EditContactPanel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TableLayoutPanel ContactDisplayLayout;
        private System.Windows.Forms.DataGridView ContactDisplayTable;
        private System.Windows.Forms.Timer EditPanelTimer;

    }
}
