namespace DigitalRolodex {
    partial class MainForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Sidebar = new System.Windows.Forms.Panel();
            this.SidebarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SidebarButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ViewContactButton = new System.Windows.Forms.Button();
            this.NewContactButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.ToggleSidebarButton = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ControlButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.NewContactPanel = new DigitalRolodexControlLibrary.NewContactPanel();
            this.ViewContactPanel = new DigitalRolodexControlLibrary.ViewContactPanel();
            this.searchBox1 = new DigitalRolodexControlLibrary.SearchBox();
            this.Sidebar.SuspendLayout();
            this.SidebarLayout.SuspendLayout();
            this.SidebarButtonLayout.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.ControlButtonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.Sidebar.Controls.Add(this.SidebarLayout);
            this.Sidebar.Controls.Add(this.LogoPanel);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(162, 476);
            this.Sidebar.TabIndex = 0;
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
            // ViewContactButton
            // 
            this.ViewContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewContactButton.FlatAppearance.BorderSize = 0;
            this.ViewContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.ViewContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.ViewContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewContactButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewContactButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ViewContactButton.Image = global::DigitalRolodex.Properties.Resources.view_contact;
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
            this.NewContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewContactButton.FlatAppearance.BorderSize = 0;
            this.NewContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.NewContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.NewContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewContactButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewContactButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NewContactButton.Image = global::DigitalRolodex.Properties.Resources.add_contact;
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
            this.LogoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GetMouseXY);
            this.LogoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
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
            this.ToggleSidebarButton.Image = ((System.Drawing.Image)(resources.GetObject("ToggleSidebarButton.Image")));
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
            this.LogoBox.Image = global::DigitalRolodex.Properties.Resources.logo_icon;
            this.LogoBox.Location = new System.Drawing.Point(54, 0);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(108, 61);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            this.LogoBox.DoubleClick += new System.EventHandler(this.ToggleWindowSize);
            this.LogoBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GetMouseXY);
            this.LogoBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.TopPanel.Controls.Add(this.searchBox1);
            this.TopPanel.Controls.Add(this.ControlButtonLayout);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(162, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(539, 61);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.DoubleClick += new System.EventHandler(this.ToggleWindowSize);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GetMouseXY);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // ControlButtonLayout
            // 
            this.ControlButtonLayout.ColumnCount = 3;
            this.ControlButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ControlButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ControlButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ControlButtonLayout.Controls.Add(this.ExitButton, 1, 1);
            this.ControlButtonLayout.Controls.Add(this.MinimizeButton, 0, 1);
            this.ControlButtonLayout.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlButtonLayout.Location = new System.Drawing.Point(453, 0);
            this.ControlButtonLayout.Margin = new System.Windows.Forms.Padding(0);
            this.ControlButtonLayout.Name = "ControlButtonLayout";
            this.ControlButtonLayout.RowCount = 3;
            this.ControlButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ControlButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ControlButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ControlButtonLayout.Size = new System.Drawing.Size(86, 61);
            this.ControlButtonLayout.TabIndex = 2;
            this.ControlButtonLayout.DoubleClick += new System.EventHandler(this.ToggleWindowSize);
            this.ControlButtonLayout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GetMouseXY);
            this.ControlButtonLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ExitButton.Location = new System.Drawing.Point(38, 15);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(38, 30);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "✕";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitClick);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButtonEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MinimizeButton.Location = new System.Drawing.Point(0, 15);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(38, 30);
            this.MinimizeButton.TabIndex = 8;
            this.MinimizeButton.Text = "➖";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeClick);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButtonEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // NewContactPanel
            // 
            this.NewContactPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.NewContactPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewContactPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewContactPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NewContactPanel.Location = new System.Drawing.Point(162, 61);
            this.NewContactPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NewContactPanel.Name = "NewContactPanel";
            this.NewContactPanel.Size = new System.Drawing.Size(539, 415);
            this.NewContactPanel.TabIndex = 3;
            this.NewContactPanel.Visible = false;
            // 
            // ViewContactPanel
            // 
            this.ViewContactPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.ViewContactPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewContactPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewContactPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ViewContactPanel.Location = new System.Drawing.Point(162, 61);
            this.ViewContactPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ViewContactPanel.Name = "ViewContactPanel";
            this.ViewContactPanel.Size = new System.Drawing.Size(539, 415);
            this.ViewContactPanel.TabIndex = 2;
            this.ViewContactPanel.Visible = false;
            // 
            // searchBox1
            // 
            this.searchBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.searchBox1.Location = new System.Drawing.Point(48, 20);
            this.searchBox1.Margin = new System.Windows.Forms.Padding(0);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(187, 25);
            this.searchBox1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(701, 476);
            this.Controls.Add(this.NewContactPanel);
            this.Controls.Add(this.ViewContactPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Rolodex";
            this.Sidebar.ResumeLayout(false);
            this.SidebarLayout.ResumeLayout(false);
            this.SidebarButtonLayout.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ControlButtonLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.TableLayoutPanel ControlButtonLayout;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.TableLayoutPanel SidebarLayout;
        private System.Windows.Forms.TableLayoutPanel SidebarButtonLayout;
        private System.Windows.Forms.Button ViewContactButton;
        private System.Windows.Forms.Button NewContactButton;
        private System.Windows.Forms.Button ToggleSidebarButton;
        private System.Windows.Forms.PictureBox LogoBox;
        private DigitalRolodexControlLibrary.ViewContactPanel ViewContactPanel;
        private DigitalRolodexControlLibrary.NewContactPanel NewContactPanel;
        private DigitalRolodexControlLibrary.SearchBox searchBox1;
    }
}

