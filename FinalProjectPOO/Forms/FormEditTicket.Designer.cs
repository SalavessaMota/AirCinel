namespace FinalProjectPOO.Forms
{
    partial class FormEditTicket
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
            buttonSaveChanges = new Button();
            panel1 = new Panel();
            label4 = new Label();
            listBoxClients = new ListBox();
            buttonCancel = new Button();
            panel2 = new Panel();
            label5 = new Label();
            comboBoxFilterArrival = new ComboBox();
            label12 = new Label();
            comboBoxFilterDeparture = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonClearFilters = new Button();
            buttonApplyFilters = new Button();
            comboBoxFilterAirplane = new ComboBox();
            comboBoxFilterDestiny = new ComboBox();
            comboBoxFilterOrigin = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            listBoxFlights = new ListBox();
            label9 = new Label();
            comboBoxSeats = new ComboBox();
            label3 = new Label();
            comboBoxRows = new ComboBox();
            panel3 = new Panel();
            label11 = new Label();
            label10 = new Label();
            panelSeats = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.LightGreen;
            buttonSaveChanges.FlatStyle = FlatStyle.Popup;
            buttonSaveChanges.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonSaveChanges.Image = Properties.Resources.accept;
            buttonSaveChanges.Location = new Point(1491, 793);
            buttonSaveChanges.Margin = new Padding(3, 4, 3, 4);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(108, 108);
            buttonSaveChanges.TabIndex = 37;
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveTicket_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(listBoxClients);
            panel1.Location = new Point(1205, 11);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 538);
            panel1.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(161, 12);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 1;
            label4.Text = "Client List:";
            // 
            // listBoxClients
            // 
            listBoxClients.Font = new Font("Segoe UI", 12F);
            listBoxClients.FormattingEnabled = true;
            listBoxClients.ItemHeight = 28;
            listBoxClients.Location = new Point(3, 44);
            listBoxClients.Margin = new Padding(3, 4, 3, 4);
            listBoxClients.Name = "listBoxClients";
            listBoxClients.ScrollAlwaysVisible = true;
            listBoxClients.Size = new Size(430, 424);
            listBoxClients.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Tomato;
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.Image = Properties.Resources.cancel;
            buttonCancel.Location = new Point(1235, 793);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(108, 108);
            buttonCancel.TabIndex = 39;
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBoxFilterArrival);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(comboBoxFilterDeparture);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(buttonClearFilters);
            panel2.Controls.Add(buttonApplyFilters);
            panel2.Controls.Add(comboBoxFilterAirplane);
            panel2.Controls.Add(comboBoxFilterDestiny);
            panel2.Controls.Add(comboBoxFilterOrigin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBoxFlights);
            panel2.Location = new Point(10, 11);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1189, 1174);
            panel2.TabIndex = 40;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(881, 975);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 41;
            label5.Text = "Arrival";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxFilterArrival
            // 
            comboBoxFilterArrival.FormattingEnabled = true;
            comboBoxFilterArrival.Location = new Point(884, 998);
            comboBoxFilterArrival.Name = "comboBoxFilterArrival";
            comboBoxFilterArrival.Size = new Size(151, 28);
            comboBoxFilterArrival.TabIndex = 40;
            comboBoxFilterArrival.Text = "Arrival";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(723, 975);
            label12.Name = "label12";
            label12.Size = new Size(152, 20);
            label12.TabIndex = 39;
            label12.Text = "Departure";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxFilterDeparture
            // 
            comboBoxFilterDeparture.FormattingEnabled = true;
            comboBoxFilterDeparture.Location = new Point(725, 998);
            comboBoxFilterDeparture.Name = "comboBoxFilterDeparture";
            comboBoxFilterDeparture.Size = new Size(151, 28);
            comboBoxFilterDeparture.TabIndex = 38;
            comboBoxFilterDeparture.Text = "Departure";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(565, 975);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 36;
            label8.Text = "Airplane";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(409, 975);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 35;
            label6.Text = "Destiny";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(253, 975);
            label7.Name = "label7";
            label7.Size = new Size(152, 20);
            label7.TabIndex = 34;
            label7.Text = "Origin";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonClearFilters
            // 
            buttonClearFilters.FlatStyle = FlatStyle.Popup;
            buttonClearFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClearFilters.Location = new Point(567, 1123);
            buttonClearFilters.Name = "buttonClearFilters";
            buttonClearFilters.Size = new Size(155, 29);
            buttonClearFilters.TabIndex = 30;
            buttonClearFilters.Text = "CLEAR FILTERS";
            buttonClearFilters.UseVisualStyleBackColor = true;
            buttonClearFilters.Click += buttonClearFilters_Click_1;
            // 
            // buttonApplyFilters
            // 
            buttonApplyFilters.FlatStyle = FlatStyle.Popup;
            buttonApplyFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonApplyFilters.Location = new Point(466, 1123);
            buttonApplyFilters.Name = "buttonApplyFilters";
            buttonApplyFilters.Size = new Size(94, 29);
            buttonApplyFilters.TabIndex = 29;
            buttonApplyFilters.Text = "APPLY";
            buttonApplyFilters.UseVisualStyleBackColor = true;
            buttonApplyFilters.Click += buttonApplyFilters_Click_1;
            // 
            // comboBoxFilterAirplane
            // 
            comboBoxFilterAirplane.FormattingEnabled = true;
            comboBoxFilterAirplane.Location = new Point(566, 998);
            comboBoxFilterAirplane.Name = "comboBoxFilterAirplane";
            comboBoxFilterAirplane.Size = new Size(151, 28);
            comboBoxFilterAirplane.TabIndex = 28;
            comboBoxFilterAirplane.Text = "Airplane";
            // 
            // comboBoxFilterDestiny
            // 
            comboBoxFilterDestiny.FormattingEnabled = true;
            comboBoxFilterDestiny.Location = new Point(410, 998);
            comboBoxFilterDestiny.Name = "comboBoxFilterDestiny";
            comboBoxFilterDestiny.Size = new Size(151, 28);
            comboBoxFilterDestiny.TabIndex = 27;
            comboBoxFilterDestiny.Text = "Destiny";
            // 
            // comboBoxFilterOrigin
            // 
            comboBoxFilterOrigin.FormattingEnabled = true;
            comboBoxFilterOrigin.Location = new Point(253, 998);
            comboBoxFilterOrigin.Name = "comboBoxFilterOrigin";
            comboBoxFilterOrigin.Size = new Size(151, 28);
            comboBoxFilterOrigin.TabIndex = 26;
            comboBoxFilterOrigin.Text = "Origin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(153, 1001);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 25;
            label2.Text = "Apply Filters:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(501, 12);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 1;
            label1.Text = "Current Flight List:";
            // 
            // listBoxFlights
            // 
            listBoxFlights.Font = new Font("Microsoft Sans Serif", 9.75F);
            listBoxFlights.FormattingEnabled = true;
            listBoxFlights.Location = new Point(3, 44);
            listBoxFlights.Margin = new Padding(3, 4, 3, 4);
            listBoxFlights.Name = "listBoxFlights";
            listBoxFlights.ScrollAlwaysVisible = true;
            listBoxFlights.Size = new Size(1183, 884);
            listBoxFlights.TabIndex = 2;
            listBoxFlights.SelectedIndexChanged += listBoxAvailableFlights_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1239, 649);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 46;
            label9.Text = "Choose Seat";
            // 
            // comboBoxSeats
            // 
            comboBoxSeats.FormattingEnabled = true;
            comboBoxSeats.Location = new Point(1469, 646);
            comboBoxSeats.Name = "comboBoxSeats";
            comboBoxSeats.Size = new Size(151, 28);
            comboBoxSeats.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1239, 586);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 44;
            label3.Text = "Choose Row";
            // 
            // comboBoxRows
            // 
            comboBoxRows.FormattingEnabled = true;
            comboBoxRows.Location = new Point(1469, 583);
            comboBoxRows.Name = "comboBoxRows";
            comboBoxRows.Size = new Size(151, 28);
            comboBoxRows.TabIndex = 43;
            // 
            // panel3
            // 
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panelSeats);
            panel3.Location = new Point(1644, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(698, 1325);
            panel3.TabIndex = 47;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(240, 57);
            label11.Name = "label11";
            label11.Size = new Size(218, 28);
            label11.TabIndex = 44;
            label11.Text = "(Front of the Airplane)";
            label11.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(299, 12);
            label10.Name = "label10";
            label10.Size = new Size(101, 28);
            label10.TabIndex = 43;
            label10.Text = "Seat Map\r\n\r\n";
            // 
            // panelSeats
            // 
            panelSeats.AutoScroll = true;
            panelSeats.Location = new Point(3, 88);
            panelSeats.Name = "panelSeats";
            panelSeats.Size = new Size(692, 1224);
            panelSeats.TabIndex = 42;
            // 
            // FormEditTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(2374, 1348);
            Controls.Add(panel3);
            Controls.Add(label9);
            Controls.Add(comboBoxSeats);
            Controls.Add(label3);
            Controls.Add(comboBoxRows);
            Controls.Add(panel2);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSaveChanges);
            Controls.Add(panel1);
            Name = "FormEditTicket";
            Text = "Edit Ticket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSaveChanges;
        private Panel panel1;
        private Label label4;
        private ListBox listBoxClients;
        private Button buttonCancel;
        private Panel panel2;
        private Label label8;
        private Label label6;
        private Label label7;
        private Button buttonClearFilters;
        private Button buttonApplyFilters;
        private ComboBox comboBoxFilterAirplane;
        private ComboBox comboBoxFilterDestiny;
        private ComboBox comboBoxFilterOrigin;
        private Label label2;
        private Label label1;
        private ListBox listBoxFlights;
        private Label label9;
        private ComboBox comboBoxSeats;
        private Label label3;
        private ComboBox comboBoxRows;
        private Panel panel3;
        private Label label11;
        private Label label10;
        private Panel panelSeats;
        private Label label5;
        private ComboBox comboBoxFilterArrival;
        private Label label12;
        private ComboBox comboBoxFilterDeparture;
    }
}