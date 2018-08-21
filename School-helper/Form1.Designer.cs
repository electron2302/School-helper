namespace School_helper
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SchoolSubjectAddButton = new System.Windows.Forms.Button();
            this.SchoolSubjectRemoveButton = new System.Windows.Forms.Button();
            this.FromDisappear = new System.Windows.Forms.Button();
            this.AddNameBox = new System.Windows.Forms.TextBox();
            this.SchoolSubjectRemoveBox = new System.Windows.Forms.ComboBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "School-helper";
            this.notifyIcon.Visible = true;
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.Location = new System.Drawing.Point(13, 70);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextBox.Size = new System.Drawing.Size(459, 50);
            this.TextBox.TabIndex = 1;
            this.TextBox.UseWaitCursor = true;
            // 
            // SchoolSubjectAddButton
            // 
            this.SchoolSubjectAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SchoolSubjectAddButton.Location = new System.Drawing.Point(397, 12);
            this.SchoolSubjectAddButton.Name = "SchoolSubjectAddButton";
            this.SchoolSubjectAddButton.Size = new System.Drawing.Size(75, 23);
            this.SchoolSubjectAddButton.TabIndex = 2;
            this.SchoolSubjectAddButton.Text = "Hinzufügen";
            this.SchoolSubjectAddButton.UseVisualStyleBackColor = true;
            this.SchoolSubjectAddButton.Click += new System.EventHandler(this.SchoolSubjectAddButton_Click);
            // 
            // SchoolSubjectRemoveButton
            // 
            this.SchoolSubjectRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SchoolSubjectRemoveButton.Location = new System.Drawing.Point(397, 38);
            this.SchoolSubjectRemoveButton.Name = "SchoolSubjectRemoveButton";
            this.SchoolSubjectRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.SchoolSubjectRemoveButton.TabIndex = 3;
            this.SchoolSubjectRemoveButton.Text = "Entfernen";
            this.SchoolSubjectRemoveButton.UseVisualStyleBackColor = true;
            this.SchoolSubjectRemoveButton.Click += new System.EventHandler(this.SchoolSubjectRemoveButton_Click);
            // 
            // FromDisappear
            // 
            this.FromDisappear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDisappear.Location = new System.Drawing.Point(397, 126);
            this.FromDisappear.Name = "FromDisappear";
            this.FromDisappear.Size = new System.Drawing.Size(75, 23);
            this.FromDisappear.TabIndex = 4;
            this.FromDisappear.Text = "Fertig";
            this.FromDisappear.UseVisualStyleBackColor = true;
            this.FromDisappear.Click += new System.EventHandler(this.FromDisappear_Click);
            // 
            // AddNameBox
            // 
            this.AddNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNameBox.Location = new System.Drawing.Point(14, 12);
            this.AddNameBox.Name = "AddNameBox";
            this.AddNameBox.Size = new System.Drawing.Size(378, 20);
            this.AddNameBox.TabIndex = 5;
            // 
            // SchoolSubjectRemoveBox
            // 
            this.SchoolSubjectRemoveBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SchoolSubjectRemoveBox.FormattingEnabled = true;
            this.SchoolSubjectRemoveBox.Location = new System.Drawing.Point(14, 38);
            this.SchoolSubjectRemoveBox.Name = "SchoolSubjectRemoveBox";
            this.SchoolSubjectRemoveBox.Size = new System.Drawing.Size(378, 21);
            this.SchoolSubjectRemoveBox.TabIndex = 6;
            // 
            // Restart
            // 
            this.Restart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Restart.Location = new System.Drawing.Point(271, 126);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(120, 23);
            this.Restart.TabIndex = 7;
            this.Restart.Text = "Anwenden (Restart)";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.SchoolSubjectRemoveBox);
            this.Controls.Add(this.AddNameBox);
            this.Controls.Add(this.FromDisappear);
            this.Controls.Add(this.SchoolSubjectRemoveButton);
            this.Controls.Add(this.SchoolSubjectAddButton);
            this.Controls.Add(this.TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button SchoolSubjectAddButton;
        private System.Windows.Forms.Button SchoolSubjectRemoveButton;
        private System.Windows.Forms.Button FromDisappear;
        private System.Windows.Forms.TextBox AddNameBox;
        private System.Windows.Forms.ComboBox SchoolSubjectRemoveBox;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button Restart;
    }
}

