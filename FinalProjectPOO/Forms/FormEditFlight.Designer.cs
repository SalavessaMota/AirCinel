namespace FinalProjectOOP
{
    partial class FormEditFlight
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
            buttonSave = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            panel1 = new Panel();
            listBoxDestinyAirports = new ListBox();
            listBoxOriginAirports = new ListBox();
            comboBoxPlane = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            dateTimePickerArrival = new DateTimePicker();
            label12 = new Label();
            dateTimePickerDeparture = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            textBoxFlightNumber = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightGreen;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            buttonSave.Image = FinalProjectPOO.Properties.Resources.accept;
            buttonSave.Location = new Point(1170, 836);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 135);
            buttonSave.TabIndex = 16;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Tomato;
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.Image = FinalProjectPOO.Properties.Resources.cancel;
            buttonCancel.Location = new Point(868, 836);
            buttonCancel.Margin = new Padding(4, 5, 4, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(135, 135);
            buttonCancel.TabIndex = 15;
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(862, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(512, 128);
            label1.TabIndex = 14;
            label1.Text = "Edit Flight";
            // 
            // panel1
            // 
            panel1.Controls.Add(listBoxDestinyAirports);
            panel1.Controls.Add(listBoxOriginAirports);
            panel1.Controls.Add(comboBoxPlane);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(dateTimePickerArrival);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(dateTimePickerDeparture);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(89, 270);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2020, 480);
            panel1.TabIndex = 17;
            // 
            // listBoxDestinyAirports
            // 
            listBoxDestinyAirports.Font = new Font("Segoe UI", 12F);
            listBoxDestinyAirports.FormattingEnabled = true;
            listBoxDestinyAirports.ItemHeight = 32;
            listBoxDestinyAirports.Location = new Point(1062, 56);
            listBoxDestinyAirports.Margin = new Padding(4);
            listBoxDestinyAirports.Name = "listBoxDestinyAirports";
            listBoxDestinyAirports.Size = new Size(950, 196);
            listBoxDestinyAirports.TabIndex = 30;
            // 
            // listBoxOriginAirports
            // 
            listBoxOriginAirports.Font = new Font("Segoe UI", 12F);
            listBoxOriginAirports.FormattingEnabled = true;
            listBoxOriginAirports.ItemHeight = 32;
            listBoxOriginAirports.Location = new Point(4, 56);
            listBoxOriginAirports.Margin = new Padding(4);
            listBoxOriginAirports.Name = "listBoxOriginAirports";
            listBoxOriginAirports.Size = new Size(950, 196);
            listBoxOriginAirports.TabIndex = 29;
            listBoxOriginAirports.SelectedIndexChanged += listBoxOriginAirports_SelectedIndexChanged;
            // 
            // comboBoxPlane
            // 
            comboBoxPlane.FormattingEnabled = true;
            comboBoxPlane.Location = new Point(786, 410);
            comboBoxPlane.Margin = new Padding(4);
            comboBoxPlane.Name = "comboBoxPlane";
            comboBoxPlane.Size = new Size(590, 33);
            comboBoxPlane.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(629, 415);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(128, 25);
            label14.TabIndex = 27;
            label14.Text = "Select Airplane";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1301, 331);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(105, 25);
            label13.TabIndex = 26;
            label13.Text = "Arrival Time";
            // 
            // dateTimePickerArrival
            // 
            dateTimePickerArrival.CustomFormat = "dd MMM yyyy - HH:mm";
            dateTimePickerArrival.Format = DateTimePickerFormat.Custom;
            dateTimePickerArrival.Location = new Point(1420, 326);
            dateTimePickerArrival.Margin = new Padding(4);
            dateTimePickerArrival.Name = "dateTimePickerArrival";
            dateTimePickerArrival.ShowUpDown = true;
            dateTimePickerArrival.Size = new Size(312, 31);
            dateTimePickerArrival.TabIndex = 25;
            dateTimePickerArrival.ValueChanged += dateTimePickerArrival_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(221, 331);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(134, 25);
            label12.TabIndex = 24;
            label12.Text = "Departure Time";
            // 
            // dateTimePickerDeparture
            // 
            dateTimePickerDeparture.CustomFormat = "dd MMM yyyy - HH:mm";
            dateTimePickerDeparture.Format = DateTimePickerFormat.Custom;
            dateTimePickerDeparture.Location = new Point(370, 326);
            dateTimePickerDeparture.Margin = new Padding(4);
            dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            dateTimePickerDeparture.ShowUpDown = true;
            dateTimePickerDeparture.Size = new Size(312, 31);
            dateTimePickerDeparture.TabIndex = 23;
            dateTimePickerDeparture.ValueChanged += dateTimePickerDeparture_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1068, 16);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(265, 32);
            label7.TabIndex = 14;
            label7.Text = "Select Destiny Airport";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(284, 16);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(251, 32);
            label6.TabIndex = 13;
            label6.Text = "Select Origin Airport";
            // 
            // label2
            // 
            label2.Location = new Point(914, 195);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(212, 39);
            label2.TabIndex = 18;
            label2.Text = "Flight Number:    AC";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxFlightNumber
            // 
            textBoxFlightNumber.Location = new Point(1136, 195);
            textBoxFlightNumber.Margin = new Padding(4, 5, 4, 5);
            textBoxFlightNumber.Name = "textBoxFlightNumber";
            textBoxFlightNumber.Size = new Size(120, 31);
            textBoxFlightNumber.TabIndex = 19;
            // 
            // FormEditFlight
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(2172, 1049);
            Controls.Add(textBoxFlightNumber);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormEditFlight";
            Text = "Edit Flight";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private Label label1;
        private Panel panel1;
        private ListBox listBoxDestinyAirports;
        private ListBox listBoxOriginAirports;
        private ComboBox comboBoxPlane;
        private Label label14;
        private Label label13;
        private DateTimePicker dateTimePickerArrival;
        private Label label12;
        private DateTimePicker dateTimePickerDeparture;
        private Label label7;
        private Label label6;
        private Label label2;
        private TextBox textBoxFlightNumber;
    }
}