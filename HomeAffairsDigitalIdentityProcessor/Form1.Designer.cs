namespace HomeAffairsDigitalIdentityProcessor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picCoatOfArms = new PictureBox();
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblID = new Label();
            txtID = new TextBox();
            lblCitizenship = new Label();
            cmbCitizenship = new ComboBox();
            btnValidateID = new Button();
            lblValidationResult = new Label();
            txtSummary = new TextBox();
            btnGenerateProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)picCoatOfArms).BeginInit();
            SuspendLayout();
            // 
            // picCoatOfArms
            // 
            picCoatOfArms.BackColor = Color.Transparent;
            picCoatOfArms.Image = Properties.Resources.coat_of_arms;
            picCoatOfArms.Location = new Point(0, 60);
            picCoatOfArms.Name = "picCoatOfArms";
            picCoatOfArms.Size = new Size(300, 440);
            picCoatOfArms.SizeMode = PictureBoxSizeMode.Zoom;
            picCoatOfArms.TabIndex = 0;
            picCoatOfArms.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Green;
            lblTitle.Location = new Point(300, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(488, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Home Affairs Digital Identity Processor";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblName.Location = new Point(300, 82);
            lblName.Name = "lblName";
            lblName.Size = new Size(124, 16);
            lblName.TabIndex = 2;
            lblName.Text = "Enter your Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.Location = new Point(470, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 3;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblID.Location = new Point(300, 127);
            lblID.Name = "lblID";
            lblID.Size = new Size(101, 16);
            lblID.TabIndex = 4;
            lblID.Text = "Enter your ID:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 9F);
            txtID.Location = new Point(470, 124);
            txtID.MaxLength = 13;
            txtID.Name = "txtID";
            txtID.Size = new Size(300, 23);
            txtID.TabIndex = 5;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // lblCitizenship
            // 
            lblCitizenship.AutoSize = true;
            lblCitizenship.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblCitizenship.Location = new Point(300, 172);
            lblCitizenship.Name = "lblCitizenship";
            lblCitizenship.Size = new Size(151, 16);
            lblCitizenship.TabIndex = 6;
            lblCitizenship.Text = "Choose your Citizen:";
            // 
            // cmbCitizenship
            // 
            cmbCitizenship.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCitizenship.Font = new Font("Segoe UI", 9F);
            cmbCitizenship.FormattingEnabled = true;
            cmbCitizenship.Items.AddRange(new object[] { "Citizen", "Permanent Resident", "Visitor" });
            cmbCitizenship.Location = new Point(470, 169);
            cmbCitizenship.Name = "cmbCitizenship";
            cmbCitizenship.Size = new Size(300, 23);
            cmbCitizenship.TabIndex = 7;
            // 
            // btnValidateID
            // 
            btnValidateID.BackColor = Color.Green;
            btnValidateID.Cursor = Cursors.Hand;
            btnValidateID.FlatAppearance.BorderColor = Color.White;
            btnValidateID.FlatAppearance.BorderSize = 2;
            btnValidateID.FlatStyle = FlatStyle.Flat;
            btnValidateID.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnValidateID.ForeColor = Color.Black;
            btnValidateID.Location = new Point(560, 212);
            btnValidateID.Name = "btnValidateID";
            btnValidateID.Size = new Size(120, 32);
            btnValidateID.TabIndex = 8;
            btnValidateID.Text = "Validate ID";
            btnValidateID.UseVisualStyleBackColor = false;
            btnValidateID.Click += btnValidateID_Click;
            // 
            // lblValidationResult
            // 
            lblValidationResult.AutoSize = true;
            lblValidationResult.Font = new Font("Segoe UI", 9F);
            lblValidationResult.Location = new Point(470, 258);
            lblValidationResult.Name = "lblValidationResult";
            lblValidationResult.Size = new Size(0, 15);
            lblValidationResult.TabIndex = 9;
            // 
            // txtSummary
            // 
            txtSummary.BackColor = Color.White;
            txtSummary.Font = new Font("Segoe UI", 9F);
            txtSummary.Location = new Point(470, 285);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(300, 160);
            txtSummary.TabIndex = 10;
            // 
            // btnGenerateProfile
            // 
            btnGenerateProfile.BackColor = Color.Green;
            btnGenerateProfile.Cursor = Cursors.Hand;
            btnGenerateProfile.FlatAppearance.BorderColor = Color.White;
            btnGenerateProfile.FlatAppearance.BorderSize = 2;
            btnGenerateProfile.FlatStyle = FlatStyle.Flat;
            btnGenerateProfile.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnGenerateProfile.ForeColor = Color.Black;
            btnGenerateProfile.Location = new Point(550, 455);
            btnGenerateProfile.Name = "btnGenerateProfile";
            btnGenerateProfile.Size = new Size(140, 32);
            btnGenerateProfile.TabIndex = 11;
            btnGenerateProfile.Text = "Generate Profile";
            btnGenerateProfile.UseVisualStyleBackColor = false;
            btnGenerateProfile.Click += btnGenerateProfile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 500);
            Controls.Add(btnGenerateProfile);
            Controls.Add(txtSummary);
            Controls.Add(lblValidationResult);
            Controls.Add(btnValidateID);
            Controls.Add(cmbCitizenship);
            Controls.Add(lblCitizenship);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Controls.Add(picCoatOfArms);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picCoatOfArms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCoatOfArms;
        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblID;
        private TextBox txtID;
        private Label lblCitizenship;
        private ComboBox cmbCitizenship;
        private Button btnValidateID;
        private Label lblValidationResult;
        private TextBox txtSummary;
        private Button btnGenerateProfile;
    }
}
