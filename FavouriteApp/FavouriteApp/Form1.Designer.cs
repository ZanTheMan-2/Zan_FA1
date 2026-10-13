namespace FavouriteApp
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
            InputBox = new TextBox();
            ListTextBox = new ListBox();
            MainLabel = new Label();
            InfoLabel = new Label();
            AddBTN = new Button();
            RemoveBTN = new Button();
            SuspendLayout();
            // 
            // InputBox
            // 
            InputBox.Location = new Point(57, 338);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(587, 31);
            InputBox.TabIndex = 0;
            InputBox.Text = "Enter programming language";
            InputBox.TextChanged += textBox1_TextChanged;
            // 
            // ListTextBox
            // 
            ListTextBox.FormattingEnabled = true;
            ListTextBox.Location = new Point(59, 64);
            ListTextBox.Name = "ListTextBox";
            ListTextBox.Size = new Size(587, 254);
            ListTextBox.TabIndex = 1;
            ListTextBox.SelectedIndexChanged += ListTextBox_SelectedIndexChanged;
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.BackColor = SystemColors.ControlLight;
            MainLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            MainLabel.Location = new Point(57, 9);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(499, 41);
            MainLabel.TabIndex = 2;
            MainLabel.Text = "The Best Programming Languages";
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Location = new Point(59, 432);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(44, 25);
            InfoLabel.TabIndex = 3;
            InfoLabel.Text = "Info";
            // 
            // AddBTN
            // 
            AddBTN.BackColor = Color.Lime;
            AddBTN.Location = new Point(57, 384);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(112, 34);
            AddBTN.TabIndex = 4;
            AddBTN.Text = "Add ";
            AddBTN.UseVisualStyleBackColor = false;
            AddBTN.Click += AddBTN_Click;
            // 
            // RemoveBTN
            // 
            RemoveBTN.BackColor = Color.FromArgb(192, 0, 0);
            RemoveBTN.Location = new Point(189, 384);
            RemoveBTN.Name = "RemoveBTN";
            RemoveBTN.Size = new Size(112, 34);
            RemoveBTN.TabIndex = 5;
            RemoveBTN.Text = "Remove";
            RemoveBTN.UseVisualStyleBackColor = false;
            RemoveBTN.Click += RemoveBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(RemoveBTN);
            Controls.Add(AddBTN);
            Controls.Add(InfoLabel);
            Controls.Add(MainLabel);
            Controls.Add(ListTextBox);
            Controls.Add(InputBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputBox;
        private ListBox ListTextBox;
        private Label MainLabel;
        private Label InfoLabel;
        private Button AddBTN;
        private Button RemoveBTN;
    }
}
