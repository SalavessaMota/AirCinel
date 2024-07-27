using FinalProjectOOP.Classes;

namespace FinalProjectOOP;

public partial class FormEditFlight : Form
{
    private Flight _flightToEdit; // Flight being edited
    private FormCRUDFlights _form; // Reference to the parent form

    public List<Airport> Airports { get; set; } // List of available airports

    /// <summary>
    /// Initializes a new instance of the <see cref="FormEditFlight"/> class.
    /// </summary>
    /// <param name="form">The parent form that opened this form.</param>
    /// <param name="flightToEdit">The flight object to be edited.</param>
    /// <param name="airports">The list of available airports.</param>
    public FormEditFlight(FormCRUDFlights form, Flight flightToEdit, List<Airport> airports)
    {
        InitializeComponent();
        this._form = form;
        this._flightToEdit = flightToEdit;
        Airports = airports;

        // Initialize the form fields with the flight's current details
        textBoxFlightNumber.Text = flightToEdit.Number.Substring(2);
        listBoxOriginAirports.DataSource = null;
        listBoxOriginAirports.DataSource = Airports;
        listBoxOriginAirports.SelectedItem = flightToEdit.Origin;
        dateTimePickerDeparture.Value = flightToEdit.DepartureTime;
        dateTimePickerArrival.Value = flightToEdit.ArrivalTime;
        comboBoxPlane.DataSource = null;
        comboBoxPlane.DataSource = form.Airplanes;
    }

    /// <summary>
    /// Handles the click event for the Save button. Saves the changes made to the flight.
    /// </summary>
    private void buttonSave_Click(object sender, EventArgs e)
    {
        // Validate the form before saving
        if (ValidateForm())
        {
            // Update the flight details with the new values from the form fields
            _flightToEdit.Number = "AC" + textBoxFlightNumber.Text;
            _flightToEdit.Origin = (Airport)listBoxOriginAirports.SelectedItem;
            _flightToEdit.Destiny = (Airport)listBoxDestinyAirports.SelectedItem;
            _flightToEdit.DepartureTime = dateTimePickerDeparture.Value;
            _flightToEdit.ArrivalTime = dateTimePickerArrival.Value;
            _flightToEdit.Airplane = (Airplane)comboBoxPlane.SelectedItem;

            // Refresh the flight list in the parent form
            _form.Init();

            // Close the form
            this.Close();
        }
    }

    /// <summary>
    /// Handles the click event for the Cancel button. Closes the form without saving changes.
    /// </summary>
    private void buttonCancel_Click(object sender, EventArgs e)
    {
        this.Close(); // Close the form
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event for the origin airports list box.
    /// Updates the destiny airports list based on the selected origin airport.
    /// </summary>
    private void listBoxOriginAirports_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxOriginAirports.SelectedItem is Airport selectedOriginAirport)
        {
            var filteredDestinyAirports = Airports.Where(a => a != selectedOriginAirport).ToList();

            listBoxDestinyAirports.DataSource = null;
            listBoxDestinyAirports.DataSource = filteredDestinyAirports;
        }
    }

    /// <summary>
    /// Validates the form input fields to ensure they are not empty and follow the required constraints.
    /// </summary>
    /// <returns>True if all fields are valid, otherwise false.</returns>
    private bool ValidateForm()
    {
        bool output = true;

        // Check if the flight number text box is empty or not a valid number
        if (string.IsNullOrEmpty(textBoxFlightNumber.Text) || !int.TryParse(textBoxFlightNumber.Text, out _))
        {
            MessageBox.Show("Insert a valid flight number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }
        // Check if an origin airport is selected
        if (listBoxOriginAirports.SelectedItem == null)
        {
            MessageBox.Show("Select the origin airport", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }
        // Check if a destiny airport is selected
        if (listBoxDestinyAirports.SelectedItem == null)
        {
            MessageBox.Show("Select the destiny airport", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }
        // Check if an airplane is selected
        if (comboBoxPlane.SelectedItem == null)
        {
            MessageBox.Show("Select the airplane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }
        // Check if the departure time is not later than the arrival time
        if (dateTimePickerDeparture.Value >= dateTimePickerArrival.Value)
        {
            MessageBox.Show("Arrival date cannot be earlier than departure date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }

        return output; // Return the validation result
    }

    /// <summary>
    /// Handles the ValueChanged event for the departure date picker.
    /// Ensures the arrival date is at least 30 minutes after the departure date.
    /// </summary>
    private void dateTimePickerDeparture_ValueChanged(object sender, EventArgs e)
    {
        dateTimePickerArrival.Value = dateTimePickerDeparture.Value.AddMinutes(30);
        ValidateDates();
    }

    /// <summary>
    /// Ensures that the arrival date is not earlier than the departure date.
    /// </summary>
    private void ValidateDates()
    {
        if (dateTimePickerArrival.Value < dateTimePickerDeparture.Value)
        {
            MessageBox.Show("Arrival date cannot be earlier than departure date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dateTimePickerArrival.Value = dateTimePickerDeparture.Value;
        }
    }

    /// <summary>
    /// Handles the ValueChanged event for the arrival date picker.
    /// Validates the dates.
    /// </summary>
    private void dateTimePickerArrival_ValueChanged(object sender, EventArgs e)
    {
        ValidateDates();
    }
}
