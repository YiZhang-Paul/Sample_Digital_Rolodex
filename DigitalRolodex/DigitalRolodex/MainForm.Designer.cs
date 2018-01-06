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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SearchBox = new DigitalRolodexControlLibrary.SearchBox();
            this.ControlButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Sidebar = new DigitalRolodexControlLibrary.Sidebar();
            this.UIPanel = new System.Windows.Forms.Panel();
            this.UserViewLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UserViewPanel = new System.Windows.Forms.Panel();
            this.NewContactPanel = new DigitalRolodexControlLibrary.NewContactPanel();
            this.ViewContactPanel = new DigitalRolodexControlLibrary.ViewContactPanel();
            this.TopPanel.SuspendLayout();
            this.ControlButtonLayout.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.UIPanel.SuspendLayout();
            this.UserViewLayout.SuspendLayout();
            this.UserViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.TopPanel.Controls.Add(this.SearchBox);
            this.TopPanel.Controls.Add(this.ControlButtonLayout);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(540, 61);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.DoubleClick += new System.EventHandler(this.ToggleWindowSize);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GetMouseXY);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.SearchBox.Location = new System.Drawing.Point(48, 20);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(187, 25);
            this.SearchBox.TabIndex = 3;
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
            this.ControlButtonLayout.Location = new System.Drawing.Point(454, 0);
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
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButtonMouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
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
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButtonClick);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButtonMouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.Sidebar, 0, 0);
            this.MainLayout.Controls.Add(this.UIPanel, 1, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(701, 476);
            this.MainLayout.TabIndex = 5;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(161, 476);
            this.Sidebar.TabIndex = 4;
            this.Sidebar.OnOptionSelected += new DigitalRolodexControlLibrary.Sidebar.OptionSelectedHandler(this.SidebarOnOptionSelected);
            // 
            // UIPanel
            // 
            this.UIPanel.Controls.Add(this.UserViewLayout);
            this.UIPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UIPanel.Location = new System.Drawing.Point(161, 0);
            this.UIPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UIPanel.Name = "UIPanel";
            this.UIPanel.Size = new System.Drawing.Size(540, 476);
            this.UIPanel.TabIndex = 5;
            // 
            // UserViewLayout
            // 
            this.UserViewLayout.ColumnCount = 1;
            this.UserViewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserViewLayout.Controls.Add(this.TopPanel, 0, 0);
            this.UserViewLayout.Controls.Add(this.UserViewPanel, 0, 1);
            this.UserViewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserViewLayout.Location = new System.Drawing.Point(0, 0);
            this.UserViewLayout.Name = "UserViewLayout";
            this.UserViewLayout.RowCount = 2;
            this.UserViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.UserViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserViewLayout.Size = new System.Drawing.Size(540, 476);
            this.UserViewLayout.TabIndex = 4;
            // 
            // UserViewPanel
            // 
            this.UserViewPanel.Controls.Add(this.NewContactPanel);
            this.UserViewPanel.Controls.Add(this.ViewContactPanel);
            this.UserViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserViewPanel.Location = new System.Drawing.Point(0, 61);
            this.UserViewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UserViewPanel.Name = "UserViewPanel";
            this.UserViewPanel.Size = new System.Drawing.Size(540, 415);
            this.UserViewPanel.TabIndex = 2;
            // 
            // NewContactPanel
            // 
            this.NewContactPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewContactPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.NewContactPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewContactPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewContactPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NewContactPanel.Location = new System.Drawing.Point(0, 0);
            this.NewContactPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NewContactPanel.Name = "NewContactPanel";
            this.NewContactPanel.Size = new System.Drawing.Size(540, 415);
            this.NewContactPanel.TabIndex = 3;
            this.NewContactPanel.Visible = false;
            this.NewContactPanel.OnContactAdding += new DigitalRolodexControlLibrary.NewContactPanel.ContactAddingHandler(this.NewContactPanelOnContactAdding);
            // 
            // ViewContactPanel
            // 
            this.ViewContactPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewContactPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.ViewContactPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewContactPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewContactPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ViewContactPanel.Location = new System.Drawing.Point(0, 0);
            this.ViewContactPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ViewContactPanel.Name = "ViewContactPanel";
            this.ViewContactPanel.Size = new System.Drawing.Size(540, 415);
            this.ViewContactPanel.TabIndex = 2;
            this.ViewContactPanel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(701, 476);
            this.Controls.Add(this.MainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Rolodex";
            this.TopPanel.ResumeLayout(false);
            this.ControlButtonLayout.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.UIPanel.ResumeLayout(false);
            this.UserViewLayout.ResumeLayout(false);
            this.UserViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TableLayoutPanel ControlButtonLayout;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private DigitalRolodexControlLibrary.ViewContactPanel ViewContactPanel;
        private DigitalRolodexControlLibrary.NewContactPanel NewContactPanel;
        private DigitalRolodexControlLibrary.SearchBox SearchBox;
        private DigitalRolodexControlLibrary.Sidebar Sidebar;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Panel UIPanel;
        private System.Windows.Forms.TableLayoutPanel UserViewLayout;
        private System.Windows.Forms.Panel UserViewPanel;
    }
}

