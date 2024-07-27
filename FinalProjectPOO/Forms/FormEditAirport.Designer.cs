namespace FinalProjectOOP
{
    partial class FormEditAirport
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
            textBoxAirportCountry = new TextBox();
            textBoxAirportCity = new TextBox();
            textBoxAirportName = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(584, 128);
            label1.TabIndex = 0;
            label1.Text = "Edit Airport";
            // 
            // textBoxAirportCountry
            // 
            textBoxAirportCountry.Location = new Point(479, 446);
            textBoxAirportCountry.Margin = new Padding(4, 5, 4, 5);
            textBoxAirportCountry.Name = "textBoxAirportCountry";
            textBoxAirportCountry.Size = new Size(360, 31);
            textBoxAirportCountry.TabIndex = 16;
            // 
            // textBoxAirportCity
            // 
            textBoxAirportCity.Location = new Point(479, 364);
            textBoxAirportCity.Margin = new Padding(4, 5, 4, 5);
            textBoxAirportCity.Name = "textBoxAirportCity";
            textBoxAirportCity.Size = new Size(360, 31);
            textBoxAirportCity.TabIndex = 15;
            // 
            // textBoxAirportName
            // 
            textBoxAirportName.Location = new Point(479, 286);
            textBoxAirportName.Margin = new Padding(4, 5, 4, 5);
            textBoxAirportName.Name = "textBoxAirportName";
            textBoxAirportName.Size = new Size(360, 31);
            textBoxAirportName.TabIndex = 14;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightGreen;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            buttonSave.Image = FinalProjectPOO.Properties.Resources.accept;
            buttonSave.Location = new Point(635, 534);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 135);
            buttonSave.TabIndex = 13;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Tomato;
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.Image = FinalProjectPOO.Properties.Resources.cancel;
            buttonCancel.Location = new Point(373, 534);
            buttonCancel.Margin = new Padding(4, 5, 4, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(135, 135);
            buttonCancel.TabIndex = 12;
            buttonCancel.TextAlign = ContentAlignment.MiddleRight;
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.Location = new Point(240, 429);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(156, 48);
            label4.TabIndex = 11;
            label4.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(310, 345);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 48);
            label3.TabIndex = 10;
            label3.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(278, 269);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 48);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // FormEditAirport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1142, 750);
            Controls.Add(textBoxAirportCountry);
            Controls.Add(textBoxAirportCity);
            Controls.Add(textBoxAirportName);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormEditAirport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Airport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAirportCountry;
        private TextBox textBoxAirportCity;
        private TextBox textBoxAirportName;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}