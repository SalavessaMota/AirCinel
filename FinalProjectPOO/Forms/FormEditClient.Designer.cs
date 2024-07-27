namespace FinalProjectPOO.Forms
{
    partial class FormEditClient
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
            textBoxPassportNumber = new TextBox();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxPhoneNumber = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxPassportNumber
            // 
            textBoxPassportNumber.Location = new Point(591, 625);
            textBoxPassportNumber.Margin = new Padding(4, 5, 4, 5);
            textBoxPassportNumber.Name = "textBoxPassportNumber";
            textBoxPassportNumber.Size = new Size(360, 31);
            textBoxPassportNumber.TabIndex = 34;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(591, 538);
            textBoxEmail.Margin = new Padding(4, 5, 4, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(360, 31);
            textBoxEmail.TabIndex = 33;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(592, 300);
            textBoxName.Margin = new Padding(4, 5, 4, 5);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(360, 95);
            textBoxName.TabIndex = 32;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightGreen;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            buttonSave.Image = Properties.Resources.accept;
            buttonSave.Location = new Point(643, 771);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 135);
            buttonSave.TabIndex = 31;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Tomato;
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.Image = Properties.Resources.cancel;
            buttonCancel.Location = new Point(364, 771);
            buttonCancel.Margin = new Padding(4, 5, 4, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(135, 135);
            buttonCancel.TabIndex = 30;
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.Location = new Point(189, 608);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(313, 48);
            label4.TabIndex = 29;
            label4.Text = "Passport Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(399, 520);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 48);
            label3.TabIndex = 28;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(391, 282);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 48);
            label2.TabIndex = 27;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(515, 128);
            label1.TabIndex = 26;
            label1.Text = "Edit Client";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(594, 450);
            textBoxPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(360, 31);
            textBoxPhoneNumber.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.Location = new Point(230, 432);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(275, 48);
            label5.TabIndex = 35;
            label5.Text = "Phone Number";
            // 
            // FormEditClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1142, 1022);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(label5);
            Controls.Add(textBoxPassportNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormEditClient";
            Text = "Edit Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassportNumber;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxPhoneNumber;
        private Label label5;
    }
}