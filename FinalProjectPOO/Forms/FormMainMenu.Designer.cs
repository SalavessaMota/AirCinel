namespace FinalProjectPOO
{
    partial class FormMainMenu
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
            panelMenu = new Panel();
            buttonAbout = new Button();
            buttonTickets = new Button();
            buttonClients = new Button();
            buttonFlights = new Button();
            buttonAirplanes = new Button();
            buttonAirports = new Button();
            panelLogo = new Panel();
            labelReturnHome = new Label();
            panelTitleBar = new Panel();
            labelTitle = new Label();
            panelDesktopPane = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            labelClientWithMostTicketsText = new Label();
            labelClientWithMostTickets = new Label();
            panel4 = new Panel();
            labelFlightWithMostPassengersText = new Label();
            labelFlightWithMostPassengers = new Label();
            panel3 = new Panel();
            labelAirportWithMostFlightsText = new Label();
            labelAirportWithMostFlights = new Label();
            panel1 = new Panel();
            labelNumberTickets = new Label();
            labelNumberClients = new Label();
            labelNumberFlights = new Label();
            labelNumberAirplanes = new Label();
            labelNumberAirports = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(buttonAbout);
            panelMenu.Controls.Add(buttonTickets);
            panelMenu.Controls.Add(buttonClients);
            panelMenu.Controls.Add(buttonFlights);
            panelMenu.Controls.Add(buttonAirplanes);
            panelMenu.Controls.Add(buttonAirports);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 1475);
            panelMenu.TabIndex = 0;
            // 
            // buttonAbout
            // 
            buttonAbout.Dock = DockStyle.Bottom;
            buttonAbout.FlatAppearance.BorderSize = 0;
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Font = new Font("Segoe UI", 11F);
            buttonAbout.ForeColor = Color.White;
            buttonAbout.Image = Properties.Resources.about;
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.ImeMode = ImeMode.NoControl;
            buttonAbout.Location = new Point(0, 1348);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Padding = new Padding(11, 0, 0, 0);
            buttonAbout.Size = new Size(219, 127);
            buttonAbout.TabIndex = 6;
            buttonAbout.Text = "         About";
            buttonAbout.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += button1_Click;
            // 
            // buttonTickets
            // 
            buttonTickets.Cursor = Cursors.Hand;
            buttonTickets.Dock = DockStyle.Top;
            buttonTickets.FlatAppearance.BorderSize = 0;
            buttonTickets.FlatStyle = FlatStyle.Flat;
            buttonTickets.Font = new Font("Segoe UI", 11F);
            buttonTickets.ForeColor = Color.White;
            buttonTickets.Image = Properties.Resources.ticket;
            buttonTickets.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTickets.ImeMode = ImeMode.NoControl;
            buttonTickets.Location = new Point(0, 480);
            buttonTickets.Name = "buttonTickets";
            buttonTickets.Padding = new Padding(11, 0, 0, 0);
            buttonTickets.Size = new Size(219, 100);
            buttonTickets.TabIndex = 5;
            buttonTickets.Text = "         Tickets";
            buttonTickets.TextAlign = ContentAlignment.MiddleRight;
            buttonTickets.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTickets.UseVisualStyleBackColor = true;
            buttonTickets.Click += buttonTickets_Click;
            // 
            // buttonClients
            // 
            buttonClients.Cursor = Cursors.Hand;
            buttonClients.Dock = DockStyle.Top;
            buttonClients.FlatAppearance.BorderSize = 0;
            buttonClients.FlatStyle = FlatStyle.Flat;
            buttonClients.Font = new Font("Segoe UI", 11F);
            buttonClients.ForeColor = Color.White;
            buttonClients.Image = Properties.Resources.client;
            buttonClients.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClients.ImeMode = ImeMode.NoControl;
            buttonClients.Location = new Point(0, 380);
            buttonClients.Name = "buttonClients";
            buttonClients.Padding = new Padding(11, 0, 0, 0);
            buttonClients.Size = new Size(219, 100);
            buttonClients.TabIndex = 4;
            buttonClients.Text = "        Clients";
            buttonClients.TextAlign = ContentAlignment.MiddleRight;
            buttonClients.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClients.UseVisualStyleBackColor = true;
            buttonClients.Click += buttonClients_Click;
            // 
            // buttonFlights
            // 
            buttonFlights.Cursor = Cursors.Hand;
            buttonFlights.Dock = DockStyle.Top;
            buttonFlights.FlatAppearance.BorderSize = 0;
            buttonFlights.FlatStyle = FlatStyle.Flat;
            buttonFlights.Font = new Font("Segoe UI", 11F);
            buttonFlights.ForeColor = Color.White;
            buttonFlights.Image = Properties.Resources.flight;
            buttonFlights.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFlights.ImeMode = ImeMode.NoControl;
            buttonFlights.Location = new Point(0, 280);
            buttonFlights.Name = "buttonFlights";
            buttonFlights.Padding = new Padding(11, 0, 0, 0);
            buttonFlights.Size = new Size(219, 100);
            buttonFlights.TabIndex = 3;
            buttonFlights.Text = "     Flights";
            buttonFlights.TextAlign = ContentAlignment.MiddleRight;
            buttonFlights.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFlights.UseVisualStyleBackColor = true;
            buttonFlights.Click += buttonFlights_Click;
            // 
            // buttonAirplanes
            // 
            buttonAirplanes.Cursor = Cursors.Hand;
            buttonAirplanes.Dock = DockStyle.Top;
            buttonAirplanes.FlatAppearance.BorderSize = 0;
            buttonAirplanes.FlatStyle = FlatStyle.Flat;
            buttonAirplanes.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAirplanes.ForeColor = Color.White;
            buttonAirplanes.Image = Properties.Resources.airplane;
            buttonAirplanes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAirplanes.ImeMode = ImeMode.NoControl;
            buttonAirplanes.Location = new Point(0, 180);
            buttonAirplanes.Name = "buttonAirplanes";
            buttonAirplanes.Padding = new Padding(11, 0, 0, 0);
            buttonAirplanes.Size = new Size(219, 100);
            buttonAirplanes.TabIndex = 2;
            buttonAirplanes.Text = "          Airplanes";
            buttonAirplanes.TextAlign = ContentAlignment.MiddleRight;
            buttonAirplanes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAirplanes.UseVisualStyleBackColor = true;
            buttonAirplanes.Click += buttonAirplanes_Click;
            // 
            // buttonAirports
            // 
            buttonAirports.Cursor = Cursors.Hand;
            buttonAirports.Dock = DockStyle.Top;
            buttonAirports.FlatAppearance.BorderSize = 0;
            buttonAirports.FlatStyle = FlatStyle.Flat;
            buttonAirports.Font = new Font("Segoe UI", 11F);
            buttonAirports.ForeColor = Color.White;
            buttonAirports.Image = Properties.Resources.airport;
            buttonAirports.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAirports.ImeMode = ImeMode.NoControl;
            buttonAirports.Location = new Point(0, 80);
            buttonAirports.Name = "buttonAirports";
            buttonAirports.Padding = new Padding(11, 0, 0, 0);
            buttonAirports.Size = new Size(219, 100);
            buttonAirports.TabIndex = 1;
            buttonAirports.Text = "         Airports";
            buttonAirports.TextAlign = ContentAlignment.MiddleRight;
            buttonAirports.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAirports.UseVisualStyleBackColor = true;
            buttonAirports.Click += buttonAirports_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(labelReturnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(219, 80);
            panelLogo.TabIndex = 0;
            // 
            // labelReturnHome
            // 
            labelReturnHome.AutoSize = true;
            labelReturnHome.Cursor = Cursors.Hand;
            labelReturnHome.Font = new Font("Segoe UI", 16.2F);
            labelReturnHome.ForeColor = Color.White;
            labelReturnHome.ImeMode = ImeMode.NoControl;
            labelReturnHome.Location = new Point(53, 21);
            labelReturnHome.Name = "labelReturnHome";
            labelReturnHome.Size = new Size(114, 38);
            labelReturnHome.TabIndex = 0;
            labelReturnHome.Text = "AirCinel";
            labelReturnHome.Click += label1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(labelTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(219, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(2394, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 22.2F);
            labelTitle.ForeColor = Color.White;
            labelTitle.ImeMode = ImeMode.NoControl;
            labelTitle.Location = new Point(1134, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(128, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.AutoScroll = true;
            panelDesktopPane.BackColor = Color.White;
            panelDesktopPane.BackgroundImage = Properties.Resources.logoAirCinel2;
            panelDesktopPane.BackgroundImageLayout = ImageLayout.Center;
            panelDesktopPane.Controls.Add(panel2);
            panelDesktopPane.Controls.Add(panel1);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(219, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(2394, 1395);
            panelDesktopPane.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(53, 882);
            panel2.Name = "panel2";
            panel2.Size = new Size(2260, 407);
            panel2.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(labelClientWithMostTicketsText);
            panel5.Controls.Add(labelClientWithMostTickets);
            panel5.Location = new Point(1609, 92);
            panel5.Name = "panel5";
            panel5.Size = new Size(618, 222);
            panel5.TabIndex = 17;
            // 
            // labelClientWithMostTicketsText
            // 
            labelClientWithMostTicketsText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClientWithMostTicketsText.Location = new Point(168, 28);
            labelClientWithMostTicketsText.Name = "labelClientWithMostTicketsText";
            labelClientWithMostTicketsText.Size = new Size(280, 37);
            labelClientWithMostTicketsText.TabIndex = 11;
            labelClientWithMostTicketsText.Text = "Client With Most Tickets";
            labelClientWithMostTicketsText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelClientWithMostTickets
            // 
            labelClientWithMostTickets.Font = new Font("Segoe UI", 13.8F);
            labelClientWithMostTickets.Location = new Point(49, 87);
            labelClientWithMostTickets.Name = "labelClientWithMostTickets";
            labelClientWithMostTickets.Size = new Size(519, 87);
            labelClientWithMostTickets.TabIndex = 14;
            labelClientWithMostTickets.Text = "-";
            labelClientWithMostTickets.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(labelFlightWithMostPassengersText);
            panel4.Controls.Add(labelFlightWithMostPassengers);
            panel4.Location = new Point(821, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(618, 222);
            panel4.TabIndex = 16;
            // 
            // labelFlightWithMostPassengersText
            // 
            labelFlightWithMostPassengersText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFlightWithMostPassengersText.Location = new Point(157, 32);
            labelFlightWithMostPassengersText.Name = "labelFlightWithMostPassengersText";
            labelFlightWithMostPassengersText.Size = new Size(302, 37);
            labelFlightWithMostPassengersText.TabIndex = 10;
            labelFlightWithMostPassengersText.Text = "Flight With Most Passengers";
            labelFlightWithMostPassengersText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFlightWithMostPassengers
            // 
            labelFlightWithMostPassengers.Font = new Font("Segoe UI", 13.8F);
            labelFlightWithMostPassengers.Location = new Point(49, 87);
            labelFlightWithMostPassengers.Name = "labelFlightWithMostPassengers";
            labelFlightWithMostPassengers.Size = new Size(519, 87);
            labelFlightWithMostPassengers.TabIndex = 13;
            labelFlightWithMostPassengers.Text = "-";
            labelFlightWithMostPassengers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(labelAirportWithMostFlightsText);
            panel3.Controls.Add(labelAirportWithMostFlights);
            panel3.Location = new Point(33, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(618, 222);
            panel3.TabIndex = 15;
            // 
            // labelAirportWithMostFlightsText
            // 
            labelAirportWithMostFlightsText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAirportWithMostFlightsText.Location = new Point(169, 28);
            labelAirportWithMostFlightsText.Name = "labelAirportWithMostFlightsText";
            labelAirportWithMostFlightsText.Size = new Size(279, 37);
            labelAirportWithMostFlightsText.TabIndex = 9;
            labelAirportWithMostFlightsText.Text = "Airport With Most Flights";
            labelAirportWithMostFlightsText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAirportWithMostFlights
            // 
            labelAirportWithMostFlights.Font = new Font("Segoe UI", 13.8F);
            labelAirportWithMostFlights.Location = new Point(49, 87);
            labelAirportWithMostFlights.Name = "labelAirportWithMostFlights";
            labelAirportWithMostFlights.Size = new Size(519, 87);
            labelAirportWithMostFlights.TabIndex = 12;
            labelAirportWithMostFlights.Text = "-";
            labelAirportWithMostFlights.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelNumberTickets);
            panel1.Controls.Add(labelNumberClients);
            panel1.Controls.Add(labelNumberFlights);
            panel1.Controls.Add(labelNumberAirplanes);
            panel1.Controls.Add(labelNumberAirports);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(67, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(2260, 407);
            panel1.TabIndex = 1;
            // 
            // labelNumberTickets
            // 
            labelNumberTickets.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            labelNumberTickets.Location = new Point(1964, 175);
            labelNumberTickets.Name = "labelNumberTickets";
            labelNumberTickets.Size = new Size(156, 91);
            labelNumberTickets.TabIndex = 10;
            labelNumberTickets.Text = "-";
            labelNumberTickets.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumberClients
            // 
            labelNumberClients.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            labelNumberClients.Location = new Point(1508, 175);
            labelNumberClients.Name = "labelNumberClients";
            labelNumberClients.Size = new Size(156, 91);
            labelNumberClients.TabIndex = 9;
            labelNumberClients.Text = "-";
            labelNumberClients.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumberFlights
            // 
            labelNumberFlights.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            labelNumberFlights.Location = new Point(1052, 175);
            labelNumberFlights.Name = "labelNumberFlights";
            labelNumberFlights.Size = new Size(156, 91);
            labelNumberFlights.TabIndex = 8;
            labelNumberFlights.Text = "-";
            labelNumberFlights.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumberAirplanes
            // 
            labelNumberAirplanes.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            labelNumberAirplanes.Location = new Point(596, 175);
            labelNumberAirplanes.Name = "labelNumberAirplanes";
            labelNumberAirplanes.Size = new Size(156, 91);
            labelNumberAirplanes.TabIndex = 7;
            labelNumberAirplanes.Text = "-";
            labelNumberAirplanes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumberAirports
            // 
            labelNumberAirports.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            labelNumberAirports.Location = new Point(140, 175);
            labelNumberAirports.Name = "labelNumberAirports";
            labelNumberAirports.Size = new Size(156, 91);
            labelNumberAirports.TabIndex = 6;
            labelNumberAirports.Text = "-";
            labelNumberAirports.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1964, 110);
            label6.Name = "label6";
            label6.Size = new Size(156, 28);
            label6.TabIndex = 5;
            label6.Text = "Tickets";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1508, 110);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 4;
            label5.Text = "Clients";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1052, 110);
            label4.Name = "label4";
            label4.Size = new Size(156, 28);
            label4.TabIndex = 3;
            label4.Text = "Flights";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(596, 110);
            label3.Name = "label3";
            label3.Size = new Size(156, 28);
            label3.TabIndex = 2;
            label3.Text = "Airplanes";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 110);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 1;
            label2.Text = "Airports";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(967, 16);
            label1.Name = "label1";
            label1.Size = new Size(326, 41);
            label1.TabIndex = 0;
            label1.Text = "CURRENT STATISTICS";
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.LogoAirCinel;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(2613, 1475);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            DoubleBuffered = true;
            Name = "FormMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AirCinel";
            FormClosing += FormMainMenu_FormClosing;
            Load += FormMainMenu_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button buttonAirports;
        private Panel panelLogo;
        private Button buttonTickets;
        private Button buttonClients;
        private Button buttonFlights;
        private Button buttonAirplanes;
        private Panel panelTitleBar;
        private Label labelTitle;
        private Label labelReturnHome;
        private Panel panelDesktopPane;
        private Button buttonAbout;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label labelNumberTickets;
        private Label labelNumberClients;
        private Label labelNumberFlights;
        private Label labelNumberAirplanes;
        private Label labelNumberAirports;
        private Label label6;
        public Label label5;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Label labelClientWithMostTickets;
        private Label labelFlightWithMostPassengers;
        private Label labelAirportWithMostFlights;
        private Label labelClientWithMostTicketsText;
        private Label labelFlightWithMostPassengersText;
        private Label labelAirportWithMostFlightsText;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
    }
}
