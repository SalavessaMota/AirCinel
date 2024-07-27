
namespace FinalProjectOOP
{
    partial class FormCRUDFlights
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
            buttonDeleteFlight = new Button();
            buttonEditFlight = new Button();
            panel2 = new Panel();
            label10 = new Label();
            comboBoxFilterArrival = new ComboBox();
            label9 = new Label();
            comboBoxFilterDeparture = new ComboBox();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            buttonClearFilters = new Button();
            buttonApplyFilters = new Button();
            comboBoxFilterAirplane = new ComboBox();
            comboBoxFilterDestiny = new ComboBox();
            comboBoxFilterOrigin = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            listBoxAvailableFlights = new ListBox();
            panel1 = new Panel();
            listBoxDestinyAirports = new ListBox();
            listBoxOriginAirports = new ListBox();
            comboBoxPlane = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            dateTimePickerArrival = new DateTimePicker();
            label12 = new Label();
            dateTimePickerDeparture1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDeleteFlight
            // 
            buttonDeleteFlight.BackColor = Color.Tomato;
            buttonDeleteFlight.FlatStyle = FlatStyle.Popup;
            buttonDeleteFlight.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteFlight.Image = FinalProjectPOO.Properties.Resources.delete;
            buttonDeleteFlight.Location = new Point(1016, 1213);
            buttonDeleteFlight.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteFlight.Name = "buttonDeleteFlight";
            buttonDeleteFlight.Size = new Size(108, 108);
            buttonDeleteFlight.TabIndex = 10;
            buttonDeleteFlight.UseVisualStyleBackColor = false;
            buttonDeleteFlight.Click += buttonDeleteFlight_Click;
            // 
            // buttonEditFlight
            // 
            buttonEditFlight.BackColor = Color.Bisque;
            buttonEditFlight.FlatStyle = FlatStyle.Popup;
            buttonEditFlight.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditFlight.Image = FinalProjectPOO.Properties.Resources.edit;
            buttonEditFlight.Location = new Point(1251, 1213);
            buttonEditFlight.Margin = new Padding(3, 4, 3, 4);
            buttonEditFlight.Name = "buttonEditFlight";
            buttonEditFlight.Size = new Size(108, 108);
            buttonEditFlight.TabIndex = 9;
            buttonEditFlight.UseVisualStyleBackColor = false;
            buttonEditFlight.Click += buttonEditFlight_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(comboBoxFilterArrival);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBoxFilterDeparture);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(buttonClearFilters);
            panel2.Controls.Add(buttonApplyFilters);
            panel2.Controls.Add(comboBoxFilterAirplane);
            panel2.Controls.Add(comboBoxFilterDestiny);
            panel2.Controls.Add(comboBoxFilterOrigin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBoxAvailableFlights);
            panel2.Location = new Point(12, 552);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(2350, 645);
            panel2.TabIndex = 8;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(745, 579);
            label10.Name = "label10";
            label10.Size = new Size(152, 20);
            label10.TabIndex = 37;
            label10.Text = "Arrival";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxFilterArrival
            // 
            comboBoxFilterArrival.FormattingEnabled = true;
            comboBoxFilterArrival.Location = new Point(745, 607);
            comboBoxFilterArrival.Name = "comboBoxFilterArrival";
            comboBoxFilterArrival.Size = new Size(151, 28);
            comboBoxFilterArrival.TabIndex = 36;
            comboBoxFilterArrival.Text = "Arrival";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(586, 579);
            label9.Name = "label9";
            label9.Size = new Size(152, 20);
            label9.TabIndex = 35;
            label9.Text = "Departure";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxFilterDeparture
            // 
            comboBoxFilterDeparture.FormattingEnabled = true;
            comboBoxFilterDeparture.Location = new Point(586, 607);
            comboBoxFilterDeparture.Name = "comboBoxFilterDeparture";
            comboBoxFilterDeparture.Size = new Size(151, 28);
            comboBoxFilterDeparture.TabIndex = 34;
            comboBoxFilterDeparture.Text = "Departure";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(428, 579);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 33;
            label8.Text = "Airplane";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(273, 579);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 32;
            label4.Text = "Destiny";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(114, 576);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 31;
            label3.Text = "Origin";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonClearFilters
            // 
            buttonClearFilters.FlatStyle = FlatStyle.Popup;
            buttonClearFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClearFilters.Location = new Point(2187, 606);
            buttonClearFilters.Name = "buttonClearFilters";
            buttonClearFilters.Size = new Size(155, 29);
            buttonClearFilters.TabIndex = 30;
            buttonClearFilters.Text = "CLEAR FILTERS";
            buttonClearFilters.UseVisualStyleBackColor = true;
            buttonClearFilters.Click += buttonClearFilters_Click;
            // 
            // buttonApplyFilters
            // 
            buttonApplyFilters.FlatStyle = FlatStyle.Popup;
            buttonApplyFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonApplyFilters.Location = new Point(2087, 607);
            buttonApplyFilters.Name = "buttonApplyFilters";
            buttonApplyFilters.Size = new Size(94, 29);
            buttonApplyFilters.TabIndex = 29;
            buttonApplyFilters.Text = "APPLY";
            buttonApplyFilters.UseVisualStyleBackColor = true;
            buttonApplyFilters.Click += buttonApplyFilters_Click;
            // 
            // comboBoxFilterAirplane
            // 
            comboBoxFilterAirplane.FormattingEnabled = true;
            comboBoxFilterAirplane.Location = new Point(428, 607);
            comboBoxFilterAirplane.Name = "comboBoxFilterAirplane";
            comboBoxFilterAirplane.Size = new Size(151, 28);
            comboBoxFilterAirplane.TabIndex = 28;
            comboBoxFilterAirplane.Text = "Airplane";
            // 
            // comboBoxFilterDestiny
            // 
            comboBoxFilterDestiny.FormattingEnabled = true;
            comboBoxFilterDestiny.Location = new Point(272, 607);
            comboBoxFilterDestiny.Name = "comboBoxFilterDestiny";
            comboBoxFilterDestiny.Size = new Size(151, 28);
            comboBoxFilterDestiny.TabIndex = 27;
            comboBoxFilterDestiny.Text = "Destiny";
            // 
            // comboBoxFilterOrigin
            // 
            comboBoxFilterOrigin.FormattingEnabled = true;
            comboBoxFilterOrigin.Location = new Point(114, 607);
            comboBoxFilterOrigin.Name = "comboBoxFilterOrigin";
            comboBoxFilterOrigin.Size = new Size(151, 28);
            comboBoxFilterOrigin.TabIndex = 26;
            comboBoxFilterOrigin.Text = "Origin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(5, 611);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 25;
            label2.Text = "Apply Filters:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(1048, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 37);
            label1.TabIndex = 1;
            label1.Text = "Current Flight List:";
            // 
            // listBoxAvailableFlights
            // 
            listBoxAvailableFlights.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxAvailableFlights.FormattingEnabled = true;
            listBoxAvailableFlights.ItemHeight = 31;
            listBoxAvailableFlights.Location = new Point(5, 62);
            listBoxAvailableFlights.Margin = new Padding(3, 4, 3, 4);
            listBoxAvailableFlights.Name = "listBoxAvailableFlights";
            listBoxAvailableFlights.ScrollAlwaysVisible = true;
            listBoxAvailableFlights.Size = new Size(2337, 500);
            listBoxAvailableFlights.TabIndex = 2;
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
            panel1.Controls.Add(dateTimePickerDeparture1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonCancel);
            panel1.Location = new Point(12, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2350, 531);
            panel1.TabIndex = 7;
            // 
            // listBoxDestinyAirports
            // 
            listBoxDestinyAirports.Font = new Font("Segoe UI", 12F);
            listBoxDestinyAirports.FormattingEnabled = true;
            listBoxDestinyAirports.ItemHeight = 28;
            listBoxDestinyAirports.Location = new Point(1176, 91);
            listBoxDestinyAirports.Name = "listBoxDestinyAirports";
            listBoxDestinyAirports.ScrollAlwaysVisible = true;
            listBoxDestinyAirports.Size = new Size(1166, 228);
            listBoxDestinyAirports.TabIndex = 30;
            // 
            // listBoxOriginAirports
            // 
            listBoxOriginAirports.Font = new Font("Segoe UI", 12F);
            listBoxOriginAirports.FormattingEnabled = true;
            listBoxOriginAirports.ItemHeight = 28;
            listBoxOriginAirports.Location = new Point(5, 91);
            listBoxOriginAirports.Name = "listBoxOriginAirports";
            listBoxOriginAirports.ScrollAlwaysVisible = true;
            listBoxOriginAirports.Size = new Size(1165, 228);
            listBoxOriginAirports.TabIndex = 29;
            listBoxOriginAirports.SelectedIndexChanged += listBoxOriginAirports_SelectedIndexChanged;
            // 
            // comboBoxPlane
            // 
            comboBoxPlane.FormattingEnabled = true;
            comboBoxPlane.Location = new Point(976, 364);
            comboBoxPlane.Name = "comboBoxPlane";
            comboBoxPlane.Size = new Size(473, 28);
            comboBoxPlane.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(828, 360);
            label14.Name = "label14";
            label14.Size = new Size(142, 28);
            label14.TabIndex = 27;
            label14.Text = "Select Airplane";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(1575, 329);
            label13.Name = "label13";
            label13.Size = new Size(116, 28);
            label13.TabIndex = 26;
            label13.Text = "Arrival Time";
            // 
            // dateTimePickerArrival
            // 
            dateTimePickerArrival.CustomFormat = "dd MMM yyyy - HH:mm";
            dateTimePickerArrival.Format = DateTimePickerFormat.Custom;
            dateTimePickerArrival.Location = new Point(1696, 331);
            dateTimePickerArrival.Name = "dateTimePickerArrival";
            dateTimePickerArrival.ShowUpDown = true;
            dateTimePickerArrival.Size = new Size(250, 27);
            dateTimePickerArrival.TabIndex = 25;
            dateTimePickerArrival.ValueChanged += dateTimePickerArrival_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(328, 329);
            label12.Name = "label12";
            label12.Size = new Size(147, 28);
            label12.TabIndex = 24;
            label12.Text = "Departure Time";
            // 
            // dateTimePickerDeparture1
            // 
            dateTimePickerDeparture1.CustomFormat = "dd MMM yyyy - HH:mm";
            dateTimePickerDeparture1.Format = DateTimePickerFormat.Custom;
            dateTimePickerDeparture1.Location = new Point(496, 332);
            dateTimePickerDeparture1.Name = "dateTimePickerDeparture1";
            dateTimePickerDeparture1.ShowUpDown = true;
            dateTimePickerDeparture1.Size = new Size(250, 27);
            dateTimePickerDeparture1.TabIndex = 23;
            dateTimePickerDeparture1.ValueChanged += dateTimePickerDeparture_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1681, 59);
            label7.Name = "label7";
            label7.Size = new Size(222, 28);
            label7.TabIndex = 14;
            label7.Text = "Select Destiny Airport";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(427, 59);
            label6.Name = "label6";
            label6.Size = new Size(209, 28);
            label6.TabIndex = 13;
            label6.Text = "Select Origin Airport";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.Location = new Point(1041, 10);
            label5.Name = "label5";
            label5.Size = new Size(269, 37);
            label5.TabIndex = 9;
            label5.Text = "Register New Flight";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightGreen;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Image = FinalProjectPOO.Properties.Resources.accept;
            buttonSave.Location = new Point(1239, 414);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(108, 108);
            buttonSave.TabIndex = 5;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Tomato;
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancel.Image = FinalProjectPOO.Properties.Resources.cancel;
            buttonCancel.Location = new Point(1004, 414);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(108, 108);
            buttonCancel.TabIndex = 4;
            buttonCancel.TextAlign = ContentAlignment.MiddleRight;
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormCRUDFlights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2374, 1348);
            Controls.Add(buttonDeleteFlight);
            Controls.Add(buttonEditFlight);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCRUDFlights";
            Text = "Flight Management";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonDeleteFlight;
        private Button buttonEditFlight;
        private Panel panel2;
        private Label label1;
        private ListBox listBoxAvailableFlights;
        private Panel panel1;
        private Label label5;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label7;
        private Label label6;
        private Label label12;
        private DateTimePicker dateTimePickerDeparture1;
        private Label label13;
        private DateTimePicker dateTimePickerArrival;
        private ComboBox comboBoxPlane;
        private Label label14;
        private ListBox listBoxDestinyAirports;
        private ListBox listBoxOriginAirports;
        private Label label2;
        private ComboBox comboBoxFilterAirplane;
        private ComboBox comboBoxFilterDestiny;
        private ComboBox comboBoxFilterOrigin;
        private Button buttonApplyFilters;
        private Button buttonClearFilters;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label10;
        private ComboBox comboBoxFilterArrival;
        private Label label9;
        private ComboBox comboBoxFilterDeparture;
    }
}