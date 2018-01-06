namespace DigitalRolodexControlLibrary {
    partial class NewContactPanel {
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
            this.AddContactLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddressInputPanel = new System.Windows.Forms.Panel();
            this.AddressInputTextBox = new System.Windows.Forms.TextBox();
            this.AddressInputLabel = new System.Windows.Forms.Label();
            this.AddressValidationLabel = new System.Windows.Forms.Label();
            this.NameInputPanel = new System.Windows.Forms.Panel();
            this.NameInputTextBox = new System.Windows.Forms.TextBox();
            this.NameInputLabel = new System.Windows.Forms.Label();
            this.NameValidationLabel = new System.Windows.Forms.Label();
            this.PhoneInputPanel = new System.Windows.Forms.Panel();
            this.PhoneInputTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneInputLabel = new System.Windows.Forms.Label();
            this.PhoneValidationLabel = new System.Windows.Forms.Label();
            this.EmailInputPanel = new System.Windows.Forms.Panel();
            this.EmailInputTextBox = new System.Windows.Forms.TextBox();
            this.EmailInputLabel = new System.Windows.Forms.Label();
            this.EmailValidationLabel = new System.Windows.Forms.Label();
            this.NewContactButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.ResetInputButton = new System.Windows.Forms.Button();
            this.SuccessMessageLabel = new System.Windows.Forms.Label();
            this.FadeTimer = new System.Windows.Forms.Timer(this.components);
            this.AddContactLayout.SuspendLayout();
            this.AddressInputPanel.SuspendLayout();
            this.NameInputPanel.SuspendLayout();
            this.PhoneInputPanel.SuspendLayout();
            this.EmailInputPanel.SuspendLayout();
            this.NewContactButtonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddContactLayout
            // 
            this.AddContactLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddContactLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.AddContactLayout.ColumnCount = 3;
            this.AddContactLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AddContactLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.AddContactLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AddContactLayout.Controls.Add(this.AddressInputPanel, 1, 4);
            this.AddContactLayout.Controls.Add(this.NameInputPanel, 1, 1);
            this.AddContactLayout.Controls.Add(this.PhoneInputPanel, 1, 2);
            this.AddContactLayout.Controls.Add(this.EmailInputPanel, 1, 3);
            this.AddContactLayout.Controls.Add(this.NewContactButtonLayout, 1, 5);
            this.AddContactLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddContactLayout.Location = new System.Drawing.Point(0, 0);
            this.AddContactLayout.Margin = new System.Windows.Forms.Padding(0);
            this.AddContactLayout.Name = "AddContactLayout";
            this.AddContactLayout.RowCount = 7;
            this.AddContactLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.AddContactLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.AddContactLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.AddContactLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.AddContactLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.AddContactLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AddContactLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.AddContactLayout.Size = new System.Drawing.Size(539, 415);
            this.AddContactLayout.TabIndex = 1;
            // 
            // AddressInputPanel
            // 
            this.AddressInputPanel.Controls.Add(this.AddressInputTextBox);
            this.AddressInputPanel.Controls.Add(this.AddressInputLabel);
            this.AddressInputPanel.Controls.Add(this.AddressValidationLabel);
            this.AddressInputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressInputPanel.Location = new System.Drawing.Point(107, 206);
            this.AddressInputPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AddressInputPanel.Name = "AddressInputPanel";
            this.AddressInputPanel.Size = new System.Drawing.Size(323, 62);
            this.AddressInputPanel.TabIndex = 3;
            // 
            // AddressInputTextBox
            // 
            this.AddressInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressInputTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressInputTextBox.Location = new System.Drawing.Point(101, 30);
            this.AddressInputTextBox.Name = "AddressInputTextBox";
            this.AddressInputTextBox.Size = new System.Drawing.Size(201, 29);
            this.AddressInputTextBox.TabIndex = 2;
            this.AddressInputTextBox.TextChanged += new System.EventHandler(this.InputTextChanged);
            // 
            // AddressInputLabel
            // 
            this.AddressInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddressInputLabel.AutoSize = true;
            this.AddressInputLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressInputLabel.Location = new System.Drawing.Point(4, 34);
            this.AddressInputLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.AddressInputLabel.Name = "AddressInputLabel";
            this.AddressInputLabel.Size = new System.Drawing.Size(70, 21);
            this.AddressInputLabel.TabIndex = 1;
            this.AddressInputLabel.Text = "Address";
            // 
            // AddressValidationLabel
            // 
            this.AddressValidationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddressValidationLabel.AutoSize = true;
            this.AddressValidationLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressValidationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddressValidationLabel.Location = new System.Drawing.Point(104, 11);
            this.AddressValidationLabel.Name = "AddressValidationLabel";
            this.AddressValidationLabel.Size = new System.Drawing.Size(0, 17);
            this.AddressValidationLabel.TabIndex = 0;
            // 
            // NameInputPanel
            // 
            this.NameInputPanel.Controls.Add(this.NameInputTextBox);
            this.NameInputPanel.Controls.Add(this.NameInputLabel);
            this.NameInputPanel.Controls.Add(this.NameValidationLabel);
            this.NameInputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameInputPanel.Location = new System.Drawing.Point(107, 20);
            this.NameInputPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NameInputPanel.Name = "NameInputPanel";
            this.NameInputPanel.Size = new System.Drawing.Size(323, 62);
            this.NameInputPanel.TabIndex = 0;
            // 
            // NameInputTextBox
            // 
            this.NameInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameInputTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInputTextBox.Location = new System.Drawing.Point(101, 30);
            this.NameInputTextBox.Name = "NameInputTextBox";
            this.NameInputTextBox.Size = new System.Drawing.Size(201, 29);
            this.NameInputTextBox.TabIndex = 2;
            this.NameInputTextBox.TextChanged += new System.EventHandler(this.InputTextChanged);
            // 
            // NameInputLabel
            // 
            this.NameInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NameInputLabel.AutoSize = true;
            this.NameInputLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInputLabel.Location = new System.Drawing.Point(4, 34);
            this.NameInputLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.NameInputLabel.Name = "NameInputLabel";
            this.NameInputLabel.Size = new System.Drawing.Size(53, 21);
            this.NameInputLabel.TabIndex = 1;
            this.NameInputLabel.Text = "Name";
            // 
            // NameValidationLabel
            // 
            this.NameValidationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameValidationLabel.AutoSize = true;
            this.NameValidationLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameValidationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NameValidationLabel.Location = new System.Drawing.Point(104, 11);
            this.NameValidationLabel.Name = "NameValidationLabel";
            this.NameValidationLabel.Size = new System.Drawing.Size(0, 17);
            this.NameValidationLabel.TabIndex = 0;
            // 
            // PhoneInputPanel
            // 
            this.PhoneInputPanel.Controls.Add(this.PhoneInputTextBox);
            this.PhoneInputPanel.Controls.Add(this.PhoneInputLabel);
            this.PhoneInputPanel.Controls.Add(this.PhoneValidationLabel);
            this.PhoneInputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneInputPanel.Location = new System.Drawing.Point(107, 82);
            this.PhoneInputPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PhoneInputPanel.Name = "PhoneInputPanel";
            this.PhoneInputPanel.Size = new System.Drawing.Size(323, 62);
            this.PhoneInputPanel.TabIndex = 1;
            // 
            // PhoneInputTextBox
            // 
            this.PhoneInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneInputTextBox.Location = new System.Drawing.Point(101, 30);
            this.PhoneInputTextBox.Mask = "(999) 000-0000";
            this.PhoneInputTextBox.Name = "PhoneInputTextBox";
            this.PhoneInputTextBox.Size = new System.Drawing.Size(109, 29);
            this.PhoneInputTextBox.TabIndex = 2;
            this.PhoneInputTextBox.TextChanged += new System.EventHandler(this.InputTextChanged);
            // 
            // PhoneInputLabel
            // 
            this.PhoneInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PhoneInputLabel.AutoSize = true;
            this.PhoneInputLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneInputLabel.Location = new System.Drawing.Point(4, 34);
            this.PhoneInputLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.PhoneInputLabel.Name = "PhoneInputLabel";
            this.PhoneInputLabel.Size = new System.Drawing.Size(86, 21);
            this.PhoneInputLabel.TabIndex = 1;
            this.PhoneInputLabel.Text = "Phone No.";
            // 
            // PhoneValidationLabel
            // 
            this.PhoneValidationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PhoneValidationLabel.AutoSize = true;
            this.PhoneValidationLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneValidationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PhoneValidationLabel.Location = new System.Drawing.Point(104, 11);
            this.PhoneValidationLabel.Name = "PhoneValidationLabel";
            this.PhoneValidationLabel.Size = new System.Drawing.Size(0, 17);
            this.PhoneValidationLabel.TabIndex = 0;
            // 
            // EmailInputPanel
            // 
            this.EmailInputPanel.Controls.Add(this.EmailInputTextBox);
            this.EmailInputPanel.Controls.Add(this.EmailInputLabel);
            this.EmailInputPanel.Controls.Add(this.EmailValidationLabel);
            this.EmailInputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailInputPanel.Location = new System.Drawing.Point(107, 144);
            this.EmailInputPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EmailInputPanel.Name = "EmailInputPanel";
            this.EmailInputPanel.Size = new System.Drawing.Size(323, 62);
            this.EmailInputPanel.TabIndex = 2;
            // 
            // EmailInputTextBox
            // 
            this.EmailInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailInputTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInputTextBox.Location = new System.Drawing.Point(101, 30);
            this.EmailInputTextBox.Name = "EmailInputTextBox";
            this.EmailInputTextBox.Size = new System.Drawing.Size(201, 29);
            this.EmailInputTextBox.TabIndex = 3;
            this.EmailInputTextBox.TextChanged += new System.EventHandler(this.InputTextChanged);
            // 
            // EmailInputLabel
            // 
            this.EmailInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmailInputLabel.AutoSize = true;
            this.EmailInputLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInputLabel.Location = new System.Drawing.Point(4, 34);
            this.EmailInputLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.EmailInputLabel.Name = "EmailInputLabel";
            this.EmailInputLabel.Size = new System.Drawing.Size(48, 21);
            this.EmailInputLabel.TabIndex = 1;
            this.EmailInputLabel.Text = "Email";
            // 
            // EmailValidationLabel
            // 
            this.EmailValidationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EmailValidationLabel.AutoSize = true;
            this.EmailValidationLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailValidationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EmailValidationLabel.Location = new System.Drawing.Point(104, 11);
            this.EmailValidationLabel.Name = "EmailValidationLabel";
            this.EmailValidationLabel.Size = new System.Drawing.Size(0, 17);
            this.EmailValidationLabel.TabIndex = 0;
            // 
            // NewContactButtonLayout
            // 
            this.NewContactButtonLayout.ColumnCount = 2;
            this.NewContactButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NewContactButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NewContactButtonLayout.Controls.Add(this.AddContactButton, 0, 1);
            this.NewContactButtonLayout.Controls.Add(this.ResetInputButton, 1, 1);
            this.NewContactButtonLayout.Controls.Add(this.SuccessMessageLabel, 0, 0);
            this.NewContactButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewContactButtonLayout.Location = new System.Drawing.Point(107, 268);
            this.NewContactButtonLayout.Margin = new System.Windows.Forms.Padding(0);
            this.NewContactButtonLayout.Name = "NewContactButtonLayout";
            this.NewContactButtonLayout.RowCount = 2;
            this.NewContactButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.86408F));
            this.NewContactButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.13592F));
            this.NewContactButtonLayout.Size = new System.Drawing.Size(323, 103);
            this.NewContactButtonLayout.TabIndex = 4;
            // 
            // AddContactButton
            // 
            this.AddContactButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.AddContactButton.BackgroundImage = global::DigitalRolodexControlLibrary.Properties.Resources.round_button_lightpink;
            this.AddContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddContactButton.FlatAppearance.BorderSize = 0;
            this.AddContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.AddContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddContactButton.Image = global::DigitalRolodexControlLibrary.Properties.Resources.add_contact_button;
            this.AddContactButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddContactButton.Location = new System.Drawing.Point(5, 44);
            this.AddContactButton.Margin = new System.Windows.Forms.Padding(5, 5, 13, 5);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.AddContactButton.Size = new System.Drawing.Size(143, 54);
            this.AddContactButton.TabIndex = 0;
            this.AddContactButton.Text = "Add";
            this.AddContactButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddContactButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddContactButton.UseVisualStyleBackColor = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButtonClick);
            this.AddContactButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddContactButtonMouseDown);
            this.AddContactButton.MouseEnter += new System.EventHandler(this.AddContactButtonMouseEnter);
            this.AddContactButton.MouseLeave += new System.EventHandler(this.AddContactButtonMouseLeave);
            this.AddContactButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddContactButtonMouseUp);
            // 
            // ResetInputButton
            // 
            this.ResetInputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.ResetInputButton.BackgroundImage = global::DigitalRolodexControlLibrary.Properties.Resources.round_button_lightskyblue;
            this.ResetInputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetInputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetInputButton.FlatAppearance.BorderSize = 0;
            this.ResetInputButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.ResetInputButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.ResetInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetInputButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ResetInputButton.Image = global::DigitalRolodexControlLibrary.Properties.Resources.reset_contact_button;
            this.ResetInputButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResetInputButton.Location = new System.Drawing.Point(174, 44);
            this.ResetInputButton.Margin = new System.Windows.Forms.Padding(13, 5, 5, 5);
            this.ResetInputButton.Name = "ResetInputButton";
            this.ResetInputButton.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.ResetInputButton.Size = new System.Drawing.Size(144, 54);
            this.ResetInputButton.TabIndex = 1;
            this.ResetInputButton.Text = "Reset";
            this.ResetInputButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetInputButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ResetInputButton.UseVisualStyleBackColor = false;
            this.ResetInputButton.Click += new System.EventHandler(this.ResetInputButtonClick);
            this.ResetInputButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResetInputButtonMouseDown);
            this.ResetInputButton.MouseEnter += new System.EventHandler(this.ResetInputButtonMouseEnter);
            this.ResetInputButton.MouseLeave += new System.EventHandler(this.ResetInputButtonMouseLeave);
            this.ResetInputButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResetInputButtonMouseUp);
            // 
            // SuccessMessageLabel
            // 
            this.SuccessMessageLabel.AutoSize = true;
            this.SuccessMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuccessMessageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.SuccessMessageLabel.Location = new System.Drawing.Point(3, 0);
            this.SuccessMessageLabel.Name = "SuccessMessageLabel";
            this.SuccessMessageLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.SuccessMessageLabel.Size = new System.Drawing.Size(155, 39);
            this.SuccessMessageLabel.TabIndex = 2;
            this.SuccessMessageLabel.Text = "Contact Added";
            this.SuccessMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FadeTimer
            // 
            this.FadeTimer.Interval = 1;
            // 
            // NewContactPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.AddContactLayout);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NewContactPanel";
            this.Size = new System.Drawing.Size(539, 415);
            this.AddContactLayout.ResumeLayout(false);
            this.AddressInputPanel.ResumeLayout(false);
            this.AddressInputPanel.PerformLayout();
            this.NameInputPanel.ResumeLayout(false);
            this.NameInputPanel.PerformLayout();
            this.PhoneInputPanel.ResumeLayout(false);
            this.PhoneInputPanel.PerformLayout();
            this.EmailInputPanel.ResumeLayout(false);
            this.EmailInputPanel.PerformLayout();
            this.NewContactButtonLayout.ResumeLayout(false);
            this.NewContactButtonLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AddContactLayout;
        private System.Windows.Forms.Panel AddressInputPanel;
        private System.Windows.Forms.TextBox AddressInputTextBox;
        private System.Windows.Forms.Label AddressInputLabel;
        private System.Windows.Forms.Label AddressValidationLabel;
        private System.Windows.Forms.Panel NameInputPanel;
        private System.Windows.Forms.TextBox NameInputTextBox;
        private System.Windows.Forms.Label NameInputLabel;
        private System.Windows.Forms.Label NameValidationLabel;
        private System.Windows.Forms.Panel PhoneInputPanel;
        private System.Windows.Forms.MaskedTextBox PhoneInputTextBox;
        private System.Windows.Forms.Label PhoneInputLabel;
        private System.Windows.Forms.Label PhoneValidationLabel;
        private System.Windows.Forms.Panel EmailInputPanel;
        private System.Windows.Forms.TextBox EmailInputTextBox;
        private System.Windows.Forms.Label EmailInputLabel;
        private System.Windows.Forms.Label EmailValidationLabel;
        private System.Windows.Forms.TableLayoutPanel NewContactButtonLayout;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Button ResetInputButton;
        private System.Windows.Forms.Label SuccessMessageLabel;
        private System.Windows.Forms.Timer FadeTimer;
    }
}
