using FinalProjectOOP;
using FinalProjectOOP.Classes;
using FinalProjectPOO.Classes;

namespace FinalProjectPOO;

public partial class FormMainMenu : Form
{
    private Button _currentButton;                                       // Current button being used
    private Form _activeForm;                                            // Active form displayed in the main form

    private const string _pathAirports = "Airports.xml";
    private const string _pathAirplanes = "Airplanes.xml";
    private const string _pathClients = "Clients.xml";
    private const string _pathFlights = "Flights.xml";
    private const string _pathTickets = "Tickets.xml";

    public List<Airport> Airports { get; set; }
    public List<Airplane> Airplanes { get; set; }
    public List<Flight> Flights { get; set; }
    public List<Ticket> Tickets { get; set; }
    public List<Client> Clients { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FormMainMenu"/> class.
    /// </summary>
    public FormMainMenu()
    {
        InitializeComponent();

        Airports = new List<Airport>();
        Airplanes = new List<Airplane>();
        Flights = new List<Flight>();
        Tickets = new List<Ticket>();
        Clients = new List<Client>();
    }

    /// <summary>
    /// Activates the specified button and sets the color.
    /// </summary>
    /// <param name="btnSender">The button sender.</param>
    /// <param name="color">The color to set for the button and UI elements.</param>
    private void ActivateButton(object btnSender, Color color)
    {
        if (btnSender != null) // If the button clicked is not null
        {
            if (_currentButton != (Button)btnSender) // If the current button is different from the button clicked
            {
                DisableButton(); // Disable the current button
                _currentButton = (Button)btnSender; // Set the current button to the button clicked
                _currentButton.BackColor = color; // Set the background color of the current button
                _currentButton.ForeColor = Color.White; // Set the text color of the current button to white
                _currentButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0); // Set the font of the current button to bold
                panelTitleBar.BackColor = color; // Set the background color of the title bar panel
                panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3); // Set the background color of the logo panel with reduced brightness
            }
        }
    }

    /// <summary>
    /// Disables the currently active button.
    /// </summary>
    private void DisableButton()
    {
        foreach (Control previousBtn in panelMenu.Controls) // For each control in the panelMenu
        {
            if (previousBtn.GetType() == typeof(Button)) // If the control is a button
            {
                previousBtn.BackColor = Color.FromArgb(51, 51, 76); // Set the background color to gray
                previousBtn.ForeColor = Color.Gainsboro; // Set the text color to light gray
                previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0); // Set the font to regular
            }
        }
    }

    /// <summary>
    /// Opens a child form inside the main form.
    /// </summary>
    /// <param name="childForm">The child form to open.</param>
    /// <param name="btnSender">The button sender.</param>
    /// <param name="color">The color to set for the button and UI elements.</param>
    private void OpenChildForm(Form childForm, object btnSender, Color color)
    {
        if (_activeForm != null) // If there is an active form
        {
            _activeForm.Close(); // Close the active form
        }
        ActivateButton(btnSender, color); // Activate the button clicked
        _activeForm = childForm; // Set the active form to the child form
        childForm.TopLevel = false; // Set the child form to not be top-level
        childForm.FormBorderStyle = FormBorderStyle.None; // Remove the border of the child form
        childForm.Dock = DockStyle.Fill; // Fill the child form in the main form
        this.panelDesktopPane.Controls.Add(childForm); // Add the child form to the panel
        this.panelDesktopPane.Tag = childForm; // Set the child form as the tag of the panel
        childForm.BringToFront(); // Bring the child form to the front
        childForm.Show(); // Show the child form
        labelTitle.Text = childForm.Text; // Set the title label to the text of the child form
    }

    /// <summary>
    /// Handles the click event for the Airports button. Opens the FormCRUDAirports form.
    /// </summary>
    private void buttonAirports_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormCRUDAirports(Airports), sender, ColorTranslator.FromHtml("#3F51B5"));
    }

    /// <summary>
    /// Handles the click event for the Airplanes button. Opens the FormCRUDAirplanes form.
    /// </summary>
    private void buttonAirplanes_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormCRUDAirplanes(Airplanes), sender, ColorTranslator.FromHtml("#009688"));
    }

    /// <summary>
    /// Handles the click event for the Flights button. Opens the FormCRUDFlights form.
    /// </summary>
    private void buttonFlights_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormCRUDFlights(Airports, Airplanes, Flights), sender, ColorTranslator.FromHtml("#FF5722"));
    }

    /// <summary>
    /// Handles the click event for the Clients button. Opens the FormCRUDClients form.
    /// </summary>
    private void buttonClients_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormCRUDClients(Clients, Tickets), sender, ColorTranslator.FromHtml("#607D8B"));
    }

    /// <summary>
    /// Handles the click event for the Tickets button. Opens the FormCRUDTickets form.
    /// </summary>
    private void buttonTickets_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormCRUDTickets(Flights, Clients, Tickets, Airplanes), sender, ColorTranslator.FromHtml("#FF9800"));
    }

    /// <summary>
    /// Handles the click event for the About button. Opens the FormAbout form.
    /// </summary>
    private void button1_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormAbout(), sender, ColorTranslator.FromHtml("#9C27B0"));
    }

    /// <summary>
    /// Loads the data from XML files when the main form loads.
    /// </summary>
    private void FormMainMenu_Load(object sender, EventArgs e)
    {
        Airports = FileManagement.LoadAirports(_pathAirports);
        Airplanes = FileManagement.LoadAirplanes(_pathAirplanes);
        Clients = FileManagement.LoadClients(_pathClients);
        Flights = FileManagement.LoadFlights(_pathFlights, Airports, Airplanes, Clients);
        Tickets = FileManagement.LoadTickets(_pathTickets, Flights, Clients);

        Init();
    }

    /// <summary>
    /// Saves the data to XML files when the main form is closing.
    /// </summary>
    private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
        FileManagement.SaveAirports(Airports, _pathAirports);
        FileManagement.SaveAirplanes(Airplanes, _pathAirplanes);
        FileManagement.SaveClients(Clients, _pathClients);
        FileManagement.SaveFlights(Flights, _pathFlights);
        FileManagement.SaveTickets(Tickets, _pathTickets);
    }

    /// <summary>
    /// Handles the click event for the home label. Closes the active form and reinitializes the main form.
    /// </summary>
    private void label1_Click(object sender, EventArgs e)
    {
        if (_activeForm != null)
        {
            _activeForm.Close();
        }
        labelTitle.Text = "HOME";
        Init();
    }

    /// <summary>
    /// Initializes the statistics labels.
    /// </summary>
    private void Init()
    {
        labelNumberAirports.Text = Airports.Count.ToString();
        labelNumberAirplanes.Text = Airplanes.Count.ToString();
        labelNumberFlights.Text = Flights.Count.ToString();
        labelNumberClients.Text = Clients.Count.ToString();
        labelNumberTickets.Text = Tickets.Count.ToString();

        // Initialize the labels for additional statistics
        labelAirportWithMostFlights.Text = GetAirportWithMostFlights();
        labelFlightWithMostPassengers.Text = GetFlightWithMostPassengers();
        labelClientWithMostTickets.Text = GetClientWithMostTickets();
    }

    /// <summary>
    /// Gets the name of the airport with the most flights.
    /// </summary>
    /// <returns>The name of the airport with the most flights.</returns>
    private string GetAirportWithMostFlights()
    {
        var airportFlightCount = Flights.GroupBy(f => f.Origin)
                                        .Select(group => new { Airport = group.Key, Count = group.Count() })
                                        .OrderByDescending(g => g.Count)
                                        .FirstOrDefault();
        return airportFlightCount != null ? $"{airportFlightCount.Airport.Name} ({airportFlightCount.Count} flights)" : "N/A";
    }

    /// <summary>
    /// Gets the flight number with the most passengers.
    /// </summary>
    /// <returns>The flight number with the most passengers.</returns>
    private string GetFlightWithMostPassengers()
    {
        var flightPassengerCount = Flights.Select(f => new { Flight = f, Count = f.TicketsBought.Count })
                                          .OrderByDescending(f => f.Count)
                                          .FirstOrDefault();
        return flightPassengerCount != null ? $"{flightPassengerCount.Flight.Number} ({flightPassengerCount.Count} passengers)" : "N/A";
    }

    /// <summary>
    /// Gets the name of the client with the most tickets.
    /// </summary>
    /// <returns>The name of the client with the most tickets.</returns>
    private string GetClientWithMostTickets()
    {
        var clientTicketCount = Tickets.GroupBy(t => t.Client)
                                       .Select(group => new { Client = group.Key, Count = group.Count() })
                                       .OrderByDescending(g => g.Count)
                                       .FirstOrDefault();
        return clientTicketCount != null ? $"{clientTicketCount.Client.Name} ({clientTicketCount.Count} tickets)" : "N/A";
    }

}

