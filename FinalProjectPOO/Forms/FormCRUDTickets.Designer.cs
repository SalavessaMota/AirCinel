namespace FinalProjectOOP
{
    partial class FormCRUDTickets
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
            panel2 = new Panel();
            label12 = new Label();
            comboBoxFilterArrival = new ComboBox();
            label13 = new Label();
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
            listBoxAvailableFlights = new ListBox();
            panel1 = new Panel();
            label4 = new Label();
            listBoxClients = new ListBox();
            buttonSaveTicket = new Button();
            panel4 = new Panel();
            buttonDeleteTicket = new Button();
            buttonEditTicket = new Button();
            listBoxTickets = new ListBox();
            label5 = new Label();
            buttonPrintTicket = new Button();
            comboBoxRows = new ComboBox();
            label3 = new Label();
            label9 = new Label();
            comboBoxSeats = new ComboBox();
            panelSeats = new Panel();
            panel3 = new Panel();
            label11 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label12);
            panel2.Controls.Add(comboBoxFilterArrival);
            panel2.Controls.Add(label13);
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
            panel2.Controls.Add(listBoxAvailableFlights);
            panel2.Location = new Point(10, 11);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1302, 538);
            panel2.TabIndex = 9;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(741, 484);
            label12.Name = "label12";
            label12.Size = new Size(152, 20);
            label12.TabIndex = 41;
            label12.Text = "Arrival";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxFilterArrival
            // 
            comboBoxFilterArrival.FormattingEnabled = true;
            comboBoxFilterArrival.Location = new Point(741, 507);
            comboBoxFilterArrival.Name = "comboBoxFilterArrival";
            comboBoxFilterArrival.Size = new Size(151, 28);
            comboBoxFilterArrival.TabIndex = 40;
            comboBoxFilterArrival.Text = "Arrival";
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(582, 484);
            label13.Name = "label13";
            label13.Size = new Size(152, 20);
            label13.TabIndex = 39;
            label13.Text = "Departure";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxFilterDeparture
            // 
            comboBoxFilterDeparture.FormattingEnabled = true;
            comboBoxFilterDeparture.Location = new Point(582, 507);
            comboBoxFilterDeparture.Name = "comboBoxFilterDeparture";
            comboBoxFilterDeparture.Size = new Size(151, 28);
            comboBoxFilterDeparture.TabIndex = 38;
            comboBoxFilterDeparture.Text = "Departure";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(426, 487);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 36;
            label8.Text = "Airplane";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(271, 487);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 35;
            label6.Text = "Destiny";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(112, 484);
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
            buttonClearFilters.Location = new Point(1031, 506);
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
            buttonApplyFilters.Location = new Point(930, 506);
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
            comboBoxFilterAirplane.Location = new Point(425, 507);
            comboBoxFilterAirplane.Name = "comboBoxFilterAirplane";
            comboBoxFilterAirplane.Size = new Size(151, 28);
            comboBoxFilterAirplane.TabIndex = 28;
            comboBoxFilterAirplane.Text = "Airplane";
            // 
            // comboBoxFilterDestiny
            // 
            comboBoxFilterDestiny.FormattingEnabled = true;
            comboBoxFilterDestiny.Location = new Point(269, 507);
            comboBoxFilterDestiny.Name = "comboBoxFilterDestiny";
            comboBoxFilterDestiny.Size = new Size(151, 28);
            comboBoxFilterDestiny.TabIndex = 27;
            comboBoxFilterDestiny.Text = "Destiny";
            // 
            // comboBoxFilterOrigin
            // 
            comboBoxFilterOrigin.FormattingEnabled = true;
            comboBoxFilterOrigin.Location = new Point(112, 507);
            comboBoxFilterOrigin.Name = "comboBoxFilterOrigin";
            comboBoxFilterOrigin.Size = new Size(151, 28);
            comboBoxFilterOrigin.TabIndex = 26;
            comboBoxFilterOrigin.Text = "Origin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(6, 510);
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
            label1.Size = new Size(182, 28);
            label1.TabIndex = 1;
            label1.Text = "Current Flight List";
            // 
            // listBoxAvailableFlights
            // 
            listBoxAvailableFlights.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxAvailableFlights.FormattingEnabled = true;
            listBoxAvailableFlights.ItemHeight = 22;
            listBoxAvailableFlights.Location = new Point(3, 44);
            listBoxAvailableFlights.Margin = new Padding(3, 4, 3, 4);
            listBoxAvailableFlights.Name = "listBoxAvailableFlights";
            listBoxAvailableFlights.ScrollAlwaysVisible = true;
            listBoxAvailableFlights.Size = new Size(1296, 400);
            listBoxAvailableFlights.TabIndex = 2;
            listBoxAvailableFlights.SelectedIndexChanged += listBoxAvailableFlights_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(listBoxClients);
            panel1.Location = new Point(1318, 11);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 538);
            panel1.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(107, 12);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 1;
            label4.Text = "Client List";
            // 
            // listBoxClients
            // 
            listBoxClients.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxClients.FormattingEnabled = true;
            listBoxClients.ItemHeight = 25;
            listBoxClients.Location = new Point(3, 44);
            listBoxClients.Margin = new Padding(3, 4, 3, 4);
            listBoxClients.Name = "listBoxClients";
            listBoxClients.ScrollAlwaysVisible = true;
            listBoxClients.Size = new Size(312, 379);
            listBoxClients.TabIndex = 2;
            // 
            // buttonSaveTicket
            // 
            buttonSaveTicket.BackColor = Color.LightGreen;
            buttonSaveTicket.FlatStyle = FlatStyle.Popup;
            buttonSaveTicket.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonSaveTicket.Image = FinalProjectPOO.Properties.Resources.accept;
            buttonSaveTicket.Location = new Point(148, 333);
            buttonSaveTicket.Margin = new Padding(3, 4, 3, 4);
            buttonSaveTicket.Name = "buttonSaveTicket";
            buttonSaveTicket.Size = new Size(108, 108);
            buttonSaveTicket.TabIndex = 33;
            buttonSaveTicket.UseVisualStyleBackColor = false;
            buttonSaveTicket.Click += buttonSaveTicket_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonDeleteTicket);
            panel4.Controls.Add(buttonEditTicket);
            panel4.Controls.Add(listBoxTickets);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(10, 566);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1189, 757);
            panel4.TabIndex = 36;
            // 
            // buttonDeleteTicket
            // 
            buttonDeleteTicket.BackColor = Color.Tomato;
            buttonDeleteTicket.FlatStyle = FlatStyle.Popup;
            buttonDeleteTicket.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonDeleteTicket.Image = FinalProjectPOO.Properties.Resources.delete;
            buttonDeleteTicket.Location = new Point(380, 574);
            buttonDeleteTicket.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteTicket.Name = "buttonDeleteTicket";
            buttonDeleteTicket.Size = new Size(108, 108);
            buttonDeleteTicket.TabIndex = 38;
            buttonDeleteTicket.UseVisualStyleBackColor = false;
            buttonDeleteTicket.Click += buttonDeleteTicket_Click;
            // 
            // buttonEditTicket
            // 
            buttonEditTicket.BackColor = Color.Bisque;
            buttonEditTicket.FlatStyle = FlatStyle.Popup;
            buttonEditTicket.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonEditTicket.Image = FinalProjectPOO.Properties.Resources.edit;
            buttonEditTicket.Location = new Point(702, 574);
            buttonEditTicket.Margin = new Padding(3, 4, 3, 4);
            buttonEditTicket.Name = "buttonEditTicket";
            buttonEditTicket.Size = new Size(108, 108);
            buttonEditTicket.TabIndex = 37;
            buttonEditTicket.UseVisualStyleBackColor = false;
            buttonEditTicket.Click += buttonEditTicket_Click;
            // 
            // listBoxTickets
            // 
            listBoxTickets.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxTickets.FormattingEnabled = true;
            listBoxTickets.ItemHeight = 31;
            listBoxTickets.Location = new Point(25, 55);
            listBoxTickets.Margin = new Padding(3, 4, 3, 4);
            listBoxTickets.Name = "listBoxTickets";
            listBoxTickets.ScrollAlwaysVisible = true;
            listBoxTickets.Size = new Size(1131, 438);
            listBoxTickets.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(486, 17);
            label5.Name = "label5";
            label5.Size = new Size(221, 28);
            label5.TabIndex = 2;
            label5.Text = "Current Issued Tickets";
            // 
            // buttonPrintTicket
            // 
            buttonPrintTicket.FlatStyle = FlatStyle.Popup;
            buttonPrintTicket.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonPrintTicket.Image = FinalProjectPOO.Properties.Resources.print;
            buttonPrintTicket.ImageAlign = ContentAlignment.BottomCenter;
            buttonPrintTicket.Location = new Point(121, 471);
            buttonPrintTicket.Margin = new Padding(3, 4, 3, 4);
            buttonPrintTicket.Name = "buttonPrintTicket";
            buttonPrintTicket.Size = new Size(167, 149);
            buttonPrintTicket.TabIndex = 37;
            buttonPrintTicket.Text = "Print Ticket";
            buttonPrintTicket.TextAlign = ContentAlignment.TopCenter;
            buttonPrintTicket.UseVisualStyleBackColor = true;
            buttonPrintTicket.Click += button1_Click;
            // 
            // comboBoxRows
            // 
            comboBoxRows.FormattingEnabled = true;
            comboBoxRows.Location = new Point(240, 146);
            comboBoxRows.Name = "comboBoxRows";
            comboBoxRows.Size = new Size(151, 28);
            comboBoxRows.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(15, 137);
            label3.Name = "label3";
            label3.Size = new Size(174, 37);
            label3.TabIndex = 39;
            label3.Text = "Choose Row";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label9.Location = new Point(15, 200);
            label9.Name = "label9";
            label9.Size = new Size(174, 37);
            label9.TabIndex = 41;
            label9.Text = "Choose Seat";
            // 
            // comboBoxSeats
            // 
            comboBoxSeats.FormattingEnabled = true;
            comboBoxSeats.Location = new Point(240, 209);
            comboBoxSeats.Name = "comboBoxSeats";
            comboBoxSeats.Size = new Size(151, 28);
            comboBoxSeats.TabIndex = 40;
            // 
            // panelSeats
            // 
            panelSeats.AutoScroll = true;
            panelSeats.Location = new Point(3, 88);
            panelSeats.Name = "panelSeats";
            panelSeats.Size = new Size(712, 1224);
            panelSeats.TabIndex = 42;
            // 
            // panel3
            // 
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panelSeats);
            panel3.Location = new Point(1644, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(718, 1325);
            panel3.TabIndex = 43;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(250, 57);
            label11.Name = "label11";
            label11.Size = new Size(218, 28);
            label11.TabIndex = 44;
            label11.Text = "(Front of the Airplane)";
            label11.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(309, 12);
            label10.Name = "label10";
            label10.Size = new Size(101, 28);
            label10.TabIndex = 43;
            label10.Text = "Seat Map\r\n\r\n";
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(buttonSaveTicket);
            panel5.Controls.Add(comboBoxSeats);
            panel5.Controls.Add(buttonPrintTicket);
            panel5.Controls.Add(comboBoxRows);
            panel5.Location = new Point(1216, 566);
            panel5.Name = "panel5";
            panel5.Size = new Size(407, 757);
            panel5.TabIndex = 0;
            // 
            // FormCRUDTickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2374, 1348);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormCRUDTickets";
            Text = "Ticket Management";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button buttonClearFilters;
        private Button buttonApplyFilters;
        private ComboBox comboBoxFilterAirplane;
        private ComboBox comboBoxFilterDestiny;
        private ComboBox comboBoxFilterOrigin;
        private Label label2;
        private Label label1;
        private ListBox listBoxAvailableFlights;
        private Panel panel1;
        private Label label4;
        private ListBox listBoxClients;
        private Button buttonSaveTicket;
        private Panel panel4;
        private ListBox listBoxTickets;
        private Label label5;
        private Button buttonDeleteTicket;
        private Button buttonEditTicket;
        private Label label8;
        private Label label6;
        private Label label7;
        private Button buttonPrintTicket;
        private ComboBox comboBoxRows;
        private Label label3;
        private Label label9;
        private ComboBox comboBoxSeats;
        private Panel panelSeats;
        private Panel panel3;
        private Label label10;
        private Label label11;
        private Panel panel5;
        private Label label12;
        private ComboBox comboBoxFilterArrival;
        private Label label13;
        private ComboBox comboBoxFilterDeparture;
    }
}