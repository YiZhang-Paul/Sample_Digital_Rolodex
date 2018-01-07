namespace DigitalRolodexControlLibrary {
    partial class SearchBox {
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.SearchIconBox = new System.Windows.Forms.PictureBox();
            this.SearchBoxLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ExpandTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIconBox)).BeginInit();
            this.SearchBoxLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.DarkGray;
            this.InputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InputBox.Location = new System.Drawing.Point(0, 0);
            this.InputBox.Margin = new System.Windows.Forms.Padding(0);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(158, 25);
            this.InputBox.TabIndex = 4;
            this.InputBox.Text = "search contact name...";
            this.InputBox.TextChanged += new System.EventHandler(this.InputBoxTextChanged);
            this.InputBox.Enter += new System.EventHandler(this.InputBoxEnter);
            this.InputBox.Leave += new System.EventHandler(this.InputBoxLeave);
            // 
            // SearchIconBox
            // 
            this.SearchIconBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchIconBox.Image = global::DigitalRolodexControlLibrary.Properties.Resources.search;
            this.SearchIconBox.Location = new System.Drawing.Point(161, 3);
            this.SearchIconBox.Name = "SearchIconBox";
            this.SearchIconBox.Size = new System.Drawing.Size(23, 19);
            this.SearchIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchIconBox.TabIndex = 5;
            this.SearchIconBox.TabStop = false;
            // 
            // SearchBoxLayout
            // 
            this.SearchBoxLayout.ColumnCount = 2;
            this.SearchBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.5F));
            this.SearchBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.5F));
            this.SearchBoxLayout.Controls.Add(this.InputBox, 0, 0);
            this.SearchBoxLayout.Controls.Add(this.SearchIconBox, 1, 0);
            this.SearchBoxLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBoxLayout.Location = new System.Drawing.Point(0, 0);
            this.SearchBoxLayout.Margin = new System.Windows.Forms.Padding(0);
            this.SearchBoxLayout.Name = "SearchBoxLayout";
            this.SearchBoxLayout.RowCount = 1;
            this.SearchBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SearchBoxLayout.Size = new System.Drawing.Size(187, 25);
            this.SearchBoxLayout.TabIndex = 6;
            // 
            // ExpandTimer
            // 
            this.ExpandTimer.Interval = 1;
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.SearchBoxLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(187, 25);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIconBox)).EndInit();
            this.SearchBoxLayout.ResumeLayout(false);
            this.SearchBoxLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.PictureBox SearchIconBox;
        private System.Windows.Forms.TableLayoutPanel SearchBoxLayout;
        private System.Windows.Forms.Timer ExpandTimer;
    }
}
