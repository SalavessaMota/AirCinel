namespace FinalProjectOOP
{
    partial class FormCRUDClients
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
            buttonDeleteClient = new Button();
            buttonEditClient = new Button();
            listBoxClients = new ListBox();
            panel3 = new Panel();
            button1 = new Button();
            textBoxNewClientPhoneNumber = new TextBox();
            label1 = new Label();
            buttonSaveNewClient = new Button();
            textBoxNewClientPassportNumber = new TextBox();
            label7 = new Label();
            textBoxNewClientEmail = new TextBox();
            label6 = new Label();
            textBoxNewClientName = new TextBox();
            label5 = new Label();
            label3 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDeleteClient
            // 
            buttonDeleteClient.BackColor = Color.Tomato;
            buttonDeleteClient.FlatStyle = FlatStyle.Popup;
            buttonDeleteClient.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonDeleteClient.Image = FinalProjectPOO.Properties.Resources.delete;
            buttonDeleteClient.Location = new Point(1416, 504);
            buttonDeleteClient.Margin = new Padding(4, 2, 4, 2);
            buttonDeleteClient.Name = "buttonDeleteClient";
            buttonDeleteClient.Size = new Size(135, 135);
            buttonDeleteClient.TabIndex = 8;
            buttonDeleteClient.UseVisualStyleBackColor = false;
            buttonDeleteClient.Click += buttonDeleteClient_Click;
            // 
            // buttonEditClient
            // 
            buttonEditClient.BackColor = Color.Bisque;
            buttonEditClient.FlatStyle = FlatStyle.Popup;
            buttonEditClient.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonEditClient.Image = FinalProjectPOO.Properties.Resources.edit;
            buttonEditClient.Location = new Point(1416, 231);
            buttonEditClient.Margin = new Padding(4, 2, 4, 2);
            buttonEditClient.Name = "buttonEditClient";
            buttonEditClient.Size = new Size(135, 135);
            buttonEditClient.TabIndex = 7;
            buttonEditClient.UseVisualStyleBackColor = false;
            buttonEditClient.Click += buttonEditClient_Click;
            // 
            // listBoxClients
            // 
            listBoxClients.Font = new Font("Segoe UI", 12F);
            listBoxClients.FormattingEnabled = true;
            listBoxClients.ItemHeight = 32;
            listBoxClients.Location = new Point(1601, 101);
            listBoxClients.Margin = new Padding(4, 2, 4, 2);
            listBoxClients.Name = "listBoxClients";
            listBoxClients.Size = new Size(1350, 1348);
            listBoxClients.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBoxNewClientPhoneNumber);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(buttonSaveNewClient);
            panel3.Controls.Add(textBoxNewClientPassportNumber);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBoxNewClientEmail);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBoxNewClientName);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(199, 101);
            panel3.Margin = new Padding(4, 2, 4, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1164, 1370);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button1.Image = FinalProjectPOO.Properties.Resources.cancel;
            button1.Location = new Point(362, 812);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(135, 135);
            button1.TabIndex = 9;
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxNewClientPhoneNumber
            // 
            textBoxNewClientPhoneNumber.BackColor = Color.White;
            textBoxNewClientPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxNewClientPhoneNumber.ForeColor = SystemColors.WindowText;
            textBoxNewClientPhoneNumber.Location = new Point(261, 346);
            textBoxNewClientPhoneNumber.Margin = new Padding(4, 2, 4, 2);
            textBoxNewClientPhoneNumber.Multiline = true;
            textBoxNewClientPhoneNumber.Name = "textBoxNewClientPhoneNumber";
            textBoxNewClientPhoneNumber.Size = new Size(801, 42);
            textBoxNewClientPhoneNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(46, 346);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 8;
            label1.Text = "Phone Number";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSaveNewClient
            // 
            buttonSaveNewClient.BackColor = Color.LightGreen;
            buttonSaveNewClient.FlatStyle = FlatStyle.Popup;
            buttonSaveNewClient.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonSaveNewClient.Image = FinalProjectPOO.Properties.Resources.accept;
            buttonSaveNewClient.Location = new Point(665, 812);
            buttonSaveNewClient.Margin = new Padding(4, 2, 4, 2);
            buttonSaveNewClient.Name = "buttonSaveNewClient";
            buttonSaveNewClient.Size = new Size(135, 135);
            buttonSaveNewClient.TabIndex = 5;
            buttonSaveNewClient.UseVisualStyleBackColor = false;
            buttonSaveNewClient.Click += buttonSaveNewClient_Click;
            // 
            // textBoxNewClientPassportNumber
            // 
            textBoxNewClientPassportNumber.BackColor = Color.White;
            textBoxNewClientPassportNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxNewClientPassportNumber.Location = new Point(261, 626);
            textBoxNewClientPassportNumber.Margin = new Padding(4, 2, 4, 2);
            textBoxNewClientPassportNumber.Multiline = true;
            textBoxNewClientPassportNumber.Name = "textBoxNewClientPassportNumber";
            textBoxNewClientPassportNumber.Size = new Size(801, 42);
            textBoxNewClientPassportNumber.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(18, 620);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(214, 32);
            label7.TabIndex = 5;
            label7.Text = "Passport Number";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNewClientEmail
            // 
            textBoxNewClientEmail.BackColor = Color.White;
            textBoxNewClientEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxNewClientEmail.ForeColor = SystemColors.WindowText;
            textBoxNewClientEmail.Location = new Point(261, 486);
            textBoxNewClientEmail.Margin = new Padding(4, 2, 4, 2);
            textBoxNewClientEmail.Multiline = true;
            textBoxNewClientEmail.Name = "textBoxNewClientEmail";
            textBoxNewClientEmail.Size = new Size(801, 42);
            textBoxNewClientEmail.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(159, 480);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 32);
            label6.TabIndex = 3;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNewClientName
            // 
            textBoxNewClientName.BackColor = Color.White;
            textBoxNewClientName.BorderStyle = BorderStyle.FixedSingle;
            textBoxNewClientName.Location = new Point(261, 130);
            textBoxNewClientName.Margin = new Padding(4, 2, 4, 2);
            textBoxNewClientName.Multiline = true;
            textBoxNewClientName.Name = "textBoxNewClientName";
            textBoxNewClientName.Size = new Size(801, 118);
            textBoxNewClientName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(154, 124);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 32);
            label5.TabIndex = 1;
            label5.Text = "Name";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(339, 12);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(325, 45);
            label3.TabIndex = 0;
            label3.Text = "Register New Client";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormCRUDClients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2968, 1685);
            Controls.Add(panel3);
            Controls.Add(buttonEditClient);
            Controls.Add(buttonDeleteClient);
            Controls.Add(listBoxClients);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormCRUDClients";
            Text = "Clients";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonDeleteClient;
        private Button buttonEditClient;
        private ListBox listBoxClients;
        private Panel panel3;
        private Button buttonSaveNewClient;
        private TextBox textBoxNewClientPassportNumber;
        private Label label7;
        private TextBox textBoxNewClientEmail;
        private Label label6;
        private TextBox textBoxNewClientName;
        private Label label5;
        private Label label3;
        private TextBox textBoxNewClientPhoneNumber;
        private Label label1;
        private Button button1;
    }
}