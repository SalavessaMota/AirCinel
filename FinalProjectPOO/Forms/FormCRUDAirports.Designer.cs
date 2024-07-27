namespace FinalProjectOOP
{
    partial class FormCRUDAirports
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
            label1 = new Label();
            listBoxAvailableAirports = new ListBox();
            panel1 = new Panel();
            comboBoxName = new ComboBox();
            comboBoxCity = new ComboBox();
            comboBoxCountry = new ComboBox();
            label5 = new Label();
            button3 = new Button();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            buttonDeleteAirport = new Button();
            buttonEditAirport = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(642, 7);
            label1.Name = "label1";
            label1.Size = new Size(287, 37);
            label1.TabIndex = 1;
            label1.Text = "Current Airports List:";
            // 
            // listBoxAvailableAirports
            // 
            listBoxAvailableAirports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxAvailableAirports.FormattingEnabled = true;
            listBoxAvailableAirports.ItemHeight = 28;
            listBoxAvailableAirports.Location = new Point(0, 90);
            listBoxAvailableAirports.Margin = new Padding(3, 4, 3, 4);
            listBoxAvailableAirports.Name = "listBoxAvailableAirports";
            listBoxAvailableAirports.Size = new Size(1567, 1096);
            listBoxAvailableAirports.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(comboBoxName);
            panel1.Controls.Add(comboBoxCity);
            panel1.Controls.Add(comboBoxCountry);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 496);
            panel1.TabIndex = 3;
            // 
            // comboBoxName
            // 
            comboBoxName.Enabled = false;
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(222, 286);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(513, 28);
            comboBoxName.TabIndex = 12;
            // 
            // comboBoxCity
            // 
            comboBoxCity.Enabled = false;
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(222, 202);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(513, 28);
            comboBoxCity.TabIndex = 11;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged_1;
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(222, 138);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(513, 28);
            comboBoxCountry.TabIndex = 10;
            comboBoxCountry.SelectedIndexChanged += comboBoxCountry_SelectedIndexChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.Location = new Point(232, 14);
            label5.Name = "label5";
            label5.Size = new Size(290, 37);
            label5.TabIndex = 9;
            label5.Text = "Register New Airport";
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button3.Image = FinalProjectPOO.Properties.Resources.accept;
            button3.Location = new Point(446, 373);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(108, 108);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button2.Image = FinalProjectPOO.Properties.Resources.cancel;
            button2.Location = new Point(199, 373);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(108, 108);
            button2.TabIndex = 4;
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(77, 138);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 3;
            label4.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(113, 202);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 2;
            label3.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(95, 282);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBoxAvailableAirports);
            panel2.Location = new Point(772, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1566, 1220);
            panel2.TabIndex = 4;
            // 
            // buttonDeleteAirport
            // 
            buttonDeleteAirport.BackColor = Color.Tomato;
            buttonDeleteAirport.FlatStyle = FlatStyle.Popup;
            buttonDeleteAirport.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteAirport.Image = FinalProjectPOO.Properties.Resources.delete;
            buttonDeleteAirport.Location = new Point(639, 683);
            buttonDeleteAirport.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteAirport.Name = "buttonDeleteAirport";
            buttonDeleteAirport.Size = new Size(108, 108);
            buttonDeleteAirport.TabIndex = 10;
            buttonDeleteAirport.UseVisualStyleBackColor = false;
            buttonDeleteAirport.Click += buttonDeleteAirport_Click;
            // 
            // buttonEditAirport
            // 
            buttonEditAirport.BackColor = Color.Bisque;
            buttonEditAirport.FlatStyle = FlatStyle.Popup;
            buttonEditAirport.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditAirport.Image = FinalProjectPOO.Properties.Resources.edit;
            buttonEditAirport.Location = new Point(639, 533);
            buttonEditAirport.Margin = new Padding(3, 4, 3, 4);
            buttonEditAirport.Name = "buttonEditAirport";
            buttonEditAirport.Size = new Size(108, 108);
            buttonEditAirport.TabIndex = 9;
            buttonEditAirport.UseVisualStyleBackColor = false;
            buttonEditAirport.Click += buttonEditAirport_Click;
            // 
            // FormCRUDAirports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2374, 1350);
            Controls.Add(buttonDeleteAirport);
            Controls.Add(buttonEditAirport);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCRUDAirports";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Airports";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ListBox listBoxAvailableAirports;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private Button buttonDeleteAirport;
        private Button buttonEditAirport;
        private ComboBox comboBoxCity;
        private ComboBox comboBoxCountry;
        private ComboBox comboBoxName;
    }
}