namespace FinalProjectOOP
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelProgramName = new Label();
            labelVersion = new Label();
            SuspendLayout();
            // 
            // labelProgramName
            // 
            labelProgramName.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProgramName.Location = new Point(703, 204);
            labelProgramName.Name = "labelProgramName";
            labelProgramName.Size = new Size(969, 231);
            labelProgramName.TabIndex = 0;
            labelProgramName.Text = "AirCinel Management";
            labelProgramName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            labelVersion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVersion.Location = new Point(920, 470);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(535, 409);
            labelVersion.TabIndex = 1;
            labelVersion.Text = "Winforms software for managing AirCinel Airlines database\r\n\r\n\r\n\r\nVersion: 1.0.0\r\nAuthor: Nuno Salavessa Mota\r\n© 2024 All Rights Reserved\r\n\r\n\r\n\r\n\r\n";
            labelVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2374, 1348);
            Controls.Add(labelVersion);
            Controls.Add(labelProgramName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAbout";
            Text = "About";
            ResumeLayout(false);
        }

        #endregion

        private Label labelProgramName;
        private Label labelVersion;
    }
}