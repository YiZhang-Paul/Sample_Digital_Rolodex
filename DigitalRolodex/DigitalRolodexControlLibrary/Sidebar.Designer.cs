namespace DigitalRolodexControlLibrary {
    partial class Sidebar {
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SidebarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SidebarButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.ViewContactButton = new System.Windows.Forms.Button();
            this.NewContactButton = new System.Windows.Forms.Button();
            this.ToggleSidebarButton = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.SidebarLayout.SuspendLayout();
            this.SidebarButtonLayout.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.MainPanel.Controls.Add(this.SidebarLayout);
            this.MainPanel.Controls.Add(this.LogoPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(162, 476);
            this.MainPanel.TabIndex = 5;
            // 
            // SidebarLayout
            // 
            this.SidebarLayout.ColumnCount = 1;
            this.SidebarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SidebarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SidebarLayout.Controls.Add(this.SidebarButtonLayout, 0, 0);
            this.SidebarLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidebarLayout.Location = new System.Drawing.Point(0, 61);
            this.SidebarLayout.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarLayout.Name = "SidebarLayout";
            this.SidebarLayout.RowCount = 2;
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.98851F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.0115F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SidebarLayout.Size = new System.Drawing.Size(162, 415);
            this.SidebarLayout.TabIndex = 3;
            // 
            // SidebarButtonLayout
            // 
            this.SidebarButtonLayout.ColumnCount = 1;
            this.SidebarButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SidebarButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SidebarButtonLayout.Controls.Add(this.ViewContactButton, 0, 1);
            this.SidebarButtonLayout.Controls.Add(this.NewContactButton, 0, 0);
            this.SidebarButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidebarButtonLayout.Location = new System.Drawing.Point(0, 0);
            this.SidebarButtonLayout.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarButtonLayout.Name = "SidebarButtonLayout";
            this.SidebarButtonLayout.RowCount = 2;
            this.SidebarButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SidebarButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SidebarButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SidebarButtonLayout.Size = new System.Drawing.Size(162, 95);
            this.SidebarButtonLayout.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.LogoPanel.Controls.Add(this.ToggleSidebarButton);
            this.LogoPanel.Controls.Add(this.LogoBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(162, 61);
            this.LogoPanel.TabIndex = 2;
            // 
            // ViewContactButton
            // 
            this.ViewContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewContactButton.FlatAppearance.BorderSize = 0;
            this.ViewContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.ViewContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.ViewContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewContactButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewContactButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ViewContactButton.Image = global::DigitalRolodexControlLibrary.Properties.Resources.view_contact;
            this.ViewContactButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewContactButton.Location = new System.Drawing.Point(0, 47);
            this.ViewContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.ViewContactButton.Name = "ViewContactButton";
            this.ViewContactButton.Size = new System.Drawing.Size(162, 48);
            this.ViewContactButton.TabIndex = 1;
            this.ViewContactButton.Text = "   View Contact";
            this.ViewContactButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewContactButton.UseVisualStyleBackColor = true;
            this.ViewContactButton.Click += new System.EventHandler(this.ViewContactButtonClick);
            // 
            // NewContactButton
            // 
            this.NewContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewContactButton.FlatAppearance.BorderSize = 0;
            this.NewContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.NewContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.NewContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewContactButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewContactButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NewContactButton.Image = global::DigitalRolodexControlLibrary.Properties.Resources.add_contact;
            this.NewContactButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewContactButton.Location = new System.Drawing.Point(0, 0);
            this.NewContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.NewContactButton.Name = "NewContactButton";
            this.NewContactButton.Size = new System.Drawing.Size(162, 47);
            this.NewContactButton.TabIndex = 0;
            this.NewContactButton.Text = "   New Contact";
            this.NewContactButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewContactButton.UseVisualStyleBackColor = true;
            this.NewContactButton.Click += new System.EventHandler(this.NewContactButtonClick);
            // 
            // ToggleSidebarButton
            // 
            this.ToggleSidebarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToggleSidebarButton.FlatAppearance.BorderSize = 0;
            this.ToggleSidebarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.ToggleSidebarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.ToggleSidebarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleSidebarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleSidebarButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ToggleSidebarButton.Image = global::DigitalRolodexControlLibrary.Properties.Resources.menu_icon;
            this.ToggleSidebarButton.Location = new System.Drawing.Point(0, 0);
            this.ToggleSidebarButton.Margin = new System.Windows.Forms.Padding(0);
            this.ToggleSidebarButton.Name = "ToggleSidebarButton";
            this.ToggleSidebarButton.Size = new System.Drawing.Size(54, 61);
            this.ToggleSidebarButton.TabIndex = 5;
            this.ToggleSidebarButton.UseVisualStyleBackColor = true;
            this.ToggleSidebarButton.Click += new System.EventHandler(this.ToggleSidebarButtonClick);
            // 
            // LogoBox
            // 
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoBox.Image = global::DigitalRolodexControlLibrary.Properties.Resources.top_logo;
            this.LogoBox.Location = new System.Drawing.Point(54, 0);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(108, 61);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // Sidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.MainPanel);
            this.Name = "Sidebar";
            this.Size = new System.Drawing.Size(162, 476);
            this.MainPanel.ResumeLayout(false);
            this.SidebarLayout.ResumeLayout(false);
            this.SidebarButtonLayout.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel SidebarLayout;
        private System.Windows.Forms.TableLayoutPanel SidebarButtonLayout;
        private System.Windows.Forms.Button ViewContactButton;
        private System.Windows.Forms.Button NewContactButton;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Button ToggleSidebarButton;
        private System.Windows.Forms.PictureBox LogoBox;

    }
}
