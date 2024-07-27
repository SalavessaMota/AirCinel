using FinalProjectOOP.Classes;
using System.Data;

namespace FinalProjectOOP;

public partial class FormCRUDFlights : Form
{
    public List<Airport> Airports { get; set; }
    public List<Airplane> Airplanes { get; set; }
    public List<Flight> Flights { get; set; }

    public FormCRUDFlights(List<Airport> airports, List<Airplane> airplanes, List<Flight> flights)
    {
        Airports = airports;
        Airplanes = airplanes;
        Flights = flights;
        InitializeComponent();
        Init();
    }

    /// <summary>
    /// Handles the click event for the close button. Closes the form.
    /// </summary>
    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    /// <summary>
    /// Initializes the form with data and sets up the UI elements.
    /// </summary>
    public void Init()
    {
        // Initialize the list of origin airports
        listBoxOriginAirports.DataSource = null;
        listBoxOriginAirports.DataSource = Airports;
        listBoxOriginAirports.SelectedItem = null;

        // Initialize the list of available flights
        listBoxAvailableFlights.DataSource = null;
        listBoxAvailableFlights.DataSource = Flights;
        listBoxAvailableFlights.SelectedItem = null;

        // Clear and initialize the destination airports list
        listBoxDestinyAirports.DataSource = null;

        // Initialize the airplane combo box
        comboBoxPlane.DataSource = null;
        comboBoxPlane.DataSource = Airplanes;
        comboBoxPlane.SelectedIndex = -1;

        // Initialize the filter combo boxes
        comboBoxFilterOrigin.DataSource = null;
        comboBoxFilterOrigin.DataSource = Flights.Select(f => f.Origin.Country).Distinct().ToList();
        comboBoxFilterOrigin.SelectedIndex = -1;

        comboBoxFilterDestiny.DataSource = null;
        comboBoxFilterDestiny.DataSource = Flights.Select(f => f.Destiny.Country).Distinct().ToList();
        comboBoxFilterDestiny.SelectedIndex = -1;

        comboBoxFilterAirplane.DataSource = null;
        comboBoxFilterAirplane.DataSource = Airplanes.Select(a => a.Model).Distinct().ToList();
        comboBoxFilterAirplane.SelectedIndex = -1;

        comboBoxFilterDeparture.DataSource = null;
        comboBoxFilterDeparture.DataSource = Flights.Select(f => f.DepartureTime.Date).Distinct().ToList();
        comboBoxFilterDeparture.SelectedIndex = -1;

        comboBoxFilterArrival.DataSource = null;
        comboBoxFilterArrival.DataSource = Flights.Select(f => f.ArrivalTime.Date).Distinct().ToList();
        comboBoxFilterArrival.SelectedIndex = -1;
    }

    /// <summary>
    /// Updates the list of destination airports based on the selected origin airport.
    /// </summary>
    private void UpdateDestinyAirports()
    {
        if (listBoxOriginAirports.SelectedItem is Airport selectedOriginAirport)
        {
            var filteredDestinyAirports = Airports.Where(a => a != selectedOriginAirport).ToList();

            listBoxDestinyAirports.DataSource = null;
            listBoxDestinyAirports.DataSource = filteredDestinyAirports;
        }
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event for the origin airports list box.
    /// Updates the list of destination airports.
    /// </summary>
    private void listBoxOriginAirports_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateDestinyAirports();
    }

    /// <summary>
    /// Validates the selected dates to ensure the arrival date is not earlier than the departure date.
    /// </summary>
    private void ValidateDates()
    {
        if (dateTimePickerArrival.Value < dateTimePickerDeparture1.Value)
        {
            MessageBox.Show("Arrival date cannot be earlier than departure date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dateTimePickerArrival.Value = dateTimePickerDeparture1.Value;
        }
    }

    /// <summary>
    /// Handles the ValueChanged event for the departure date picker.
    /// Sets the arrival date to at least 30 minutes after the departure date.
    /// </summary>
    private void dateTimePickerDeparture_ValueChanged(object sender, EventArgs e)
    {
        dateTimePickerArrival.Value = dateTimePickerDeparture1.Value.AddMinutes(30);    // Set the arrival date to at least 30 minutes after the departure date
        ValidateDates();
    }

    /// <summary>
    /// Handles the ValueChanged event for the arrival date picker.
    /// Validates the selected dates.
    /// </summary>
    private void dateTimePickerArrival_ValueChanged(object sender, EventArgs e)
    {
        ValidateDates();    // Validate the selected dates
    }

    /// <summary>
    /// Handles the click event for the Save button. Validates the form and adds a new flight to the list.
    /// </summary>
    private void buttonSave_Click(object sender, EventArgs e)
    {
        // Validate the form
        if (listBoxOriginAirports.SelectedItem is Airport originAirport &&
            listBoxDestinyAirports.SelectedItem is Airport destinyAirport &&
            comboBoxPlane.SelectedItem is Airplane selectedPlane)
        {
            var newFlight = new Flight
            {
                Number = GenerateFlightNumber(),
                DepartureTime = dateTimePickerDeparture1.Value,
                ArrivalTime = dateTimePickerArrival.Value,
                Origin = originAirport,
                Destiny = destinyAirport,
                Airplane = selectedPlane,
                TicketsBought = new List<Ticket>()
            };

            Flights.Add(newFlight);

            //MessageBox.Show("Flight added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Please make sure all fields are filled out correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        Init();
    }

    /// <summary>
    /// Generates a unique flight number.
    /// </summary>
    /// <returns>A new flight number.</returns>
    private string GenerateFlightNumber()
    {
        if (Flights.Count == 0)
        {
            return "AC001";
        }

        // Extract the number part from the last flight number and increment it
        var lastFlightNumber = Flights.Select(f => int.Parse(f.Number.Substring(2))).Max();
        var newFlightNumber = lastFlightNumber + 1;

        return "AC" + newFlightNumber.ToString("D3");
    }

    /// <summary>
    /// Handles the click event for the Delete Flight button. Deletes the selected flight from the list.
    /// </summary>
    private void buttonDeleteFlight_Click(object sender, EventArgs e)
    {
        var flightToDelete = (Flight)listBoxAvailableFlights.SelectedItem;
        if (flightToDelete != null)
        {
            if (flightToDelete.TicketsBought.Count > 0)
            {
                MessageBox.Show("This flight has tickets bought and cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var deletedFlight = FindFlightByNumber(flightToDelete.Number);

            if (deletedFlight != null)
            {
                DialogResult answer = MessageBox.Show($"Are you sure you want to delete flight number {deletedFlight.Number} ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (answer == DialogResult.OK)
                {
                    Flights.Remove(flightToDelete);
                    Init();
                }
            }
        }
    }

    /// <summary>
    /// Handles the click event for the Edit Flight button. Opens a form to edit the selected flight.
    /// </summary>
    private void buttonEditFlight_Click(object sender, EventArgs e)
    {
        var flightToEdit = (Flight)listBoxAvailableFlights.SelectedItem;
        if (flightToEdit != null)
        {
            var editedFlight = FindFlightByNumber(flightToEdit.Number);
            if (editedFlight != null)
            {
                var formEditFlight = new FormEditFlight(this, editedFlight, Airports);
                formEditFlight.Show();
            }
        }
    }

    /// <summary>
    /// Finds a flight by its number.
    /// </summary>
    /// <param name="id">The flight number to find.</param>
    /// <returns>The flight with the specified number, or null if not found.</returns>
    private Flight FindFlightByNumber(string id)
    {
        // Find the flight by its number
        return Flights.FirstOrDefault(a => a.Number == id);
    }

    /// <summary>
    /// Handles the click event for the Apply Filters button. Filters the list of flights based on selected criteria.
    /// </summary>
    private void buttonApplyFilters_Click(object sender, EventArgs e)
    {
        List<Flight> filteredFlights;

        string selectedOrigin = comboBoxFilterOrigin.SelectedItem?.ToString();
        string selectedDestiny = comboBoxFilterDestiny.SelectedItem?.ToString();
        string selectedAirplane = comboBoxFilterAirplane.SelectedItem?.ToString();
        DateTime? selectedDepartureDate = comboBoxFilterDeparture.SelectedItem as DateTime?;
        DateTime? selectedArrivalDate = comboBoxFilterArrival.SelectedItem as DateTime?;

        // Filter flights based on selected criteria
        filteredFlights = Flights.Where(f => (selectedOrigin == null || f.Origin.Country == selectedOrigin) && (selectedDestiny == null || f.Destiny.Country == selectedDestiny) && (selectedAirplane == null || f.Airplane.Model == selectedAirplane) && (!selectedDepartureDate.HasValue || f.DepartureTime.Date == selectedDepartureDate.Value) && (!selectedArrivalDate.HasValue || f.ArrivalTime.Date == selectedArrivalDate.Value)).ToList();

        listBoxAvailableFlights.DataSource = null;
        listBoxAvailableFlights.DataSource = filteredFlights;
    }

    /// <summary>
    /// Handles the click event for the Clear Filters button. Clears all filters and shows the complete list of flights.
    /// </summary>
    private void buttonClearFilters_Click(object sender, EventArgs e)
    {
        listBoxAvailableFlights.DataSource = null;
        listBoxAvailableFlights.DataSource = Flights;
        Init();

        comboBoxFilterOrigin.Text = "Origin";
        comboBoxFilterDestiny.Text = "Destiny";
        comboBoxFilterAirplane.Text = "Airplane";
        comboBoxFilterDeparture.Text = "Departure";
        comboBoxFilterArrival.Text = "Arrival";
    }

    /// <summary>
    /// Handles the click event for the Cancel button. Reinitializes the form.
    /// </summary>
    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Init();
    }
}

