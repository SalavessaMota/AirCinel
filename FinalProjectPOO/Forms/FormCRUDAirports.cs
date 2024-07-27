using FinalProjectOOP.Classes;

namespace FinalProjectOOP;

public partial class FormCRUDAirports : Form
{
    public List<Airport> Airports { get; set; }

    // Load the list of available airports
    private List<Airport> AvailableAirports = AirportList.LoadAirports();

    public FormCRUDAirports(List<Airport> airports)
    {
        Airports = airports;
        InitializeComponent();
        PopulateCountryComboBoxes();
        InitList();
    }

    /// <summary>
    /// Initializes the list of available airports and updates the UI.
    /// </summary>
    public void InitList()
    {
        // Reset the data source of the list box to refresh the display
        listBoxAvailableAirports.DataSource = null;
        listBoxAvailableAirports.DataSource = Airports;

        // Disable city and name combo boxes initially
        comboBoxCity.Enabled = false;
        comboBoxName.Enabled = false;

        // Reset the selected indices of the combo boxes
        comboBoxCountry.SelectedIndex = -1;
        comboBoxCity.SelectedIndex = -1;
        comboBoxName.SelectedIndex = -1;
    }

    /// <summary>
    /// Handles the click event for the Reset button. Resets the combo box selections.
    /// </summary>
    private void button2_Click(object sender, EventArgs e)
    {
        // Reset the selected indices of the combo boxes and disable them
        comboBoxCountry.SelectedIndex = -1;
        comboBoxCity.SelectedIndex = -1;
        comboBoxCity.Enabled = false;
        comboBoxName.SelectedIndex = -1;
        comboBoxName.Enabled = false;
    }

    /// <summary>
    /// Handles the click event for the Add Airport button. Validates the form and adds a new airport to the list.
    /// </summary>
    private void button3_Click(object sender, EventArgs e)
    {
        if (ValidateForm())
        {
            // Get selected values from combo boxes
            string selectedCountry = comboBoxCountry.SelectedItem.ToString();
            string selectedCity = comboBoxCity.SelectedItem.ToString();
            string selectedName = comboBoxName.SelectedItem.ToString();

            // Check if the airport already exists in the list
            if (Airports.Any(a => a.Name.Equals(selectedName)))
            {
                MessageBox.Show("We have already added that airport!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Airport object and add it to the list
            var newAirport = new Airport
            {
                Id = GetNextId(),
                Country = selectedCountry,
                City = selectedCity,
                Name = selectedName
            };

            Airports.Add(newAirport);
            InitList();
            //MessageBox.Show("Airport successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        InitList();
    }

    /// <summary>
    /// Handles the click event for the Delete Airport button. Deletes the selected airport from the list.
    /// </summary>
    private void buttonDeleteAirport_Click(object sender, EventArgs e)
    {
        // Get the selected airport from the list box
        var airportToDelete = (Airport)listBoxAvailableAirports.SelectedItem;
        if (airportToDelete != null)
        {
            var deletedAirport = FindAirportById(airportToDelete.Id);

            if (deletedAirport != null)
            {
                // Show confirmation dialog before deleting
                DialogResult answer = MessageBox.Show($"Are you sure you want to delete '{deletedAirport.Name}' ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (answer == DialogResult.OK)
                {
                    // Remove the airport from the list and update the UI
                    Airports.Remove(deletedAirport);
                    InitList();
                }
            }
        }
    }

    /// <summary>
    /// Handles the click event for the Edit Airport button. Opens a form to edit the selected airport.
    /// </summary>
    private void buttonEditAirport_Click(object sender, EventArgs e)
    {
        // Get the selected airport from the list box
        var airportToEdit = (Airport)listBoxAvailableAirports.SelectedItem;
        if (airportToEdit != null)
        {
            var editedAirport = FindAirportById(airportToEdit.Id);
            if (editedAirport != null)
            {
                // Open the form to edit the airport
                var formEditAirport = new FormEditAirport(this, editedAirport);
                formEditAirport.Show();
            }
        }
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event for the city combo box.
    /// Updates the name combo box based on the selected city.
    /// </summary>
    private void comboBoxCity_SelectedIndexChanged_1(object sender, EventArgs e)
    {
        if (comboBoxCountry.SelectedItem != null && comboBoxCity.SelectedItem != null)
        {
            // Get the selected city and update the name combo box
            string selectedCity = comboBoxCity.SelectedItem.ToString();
            var airports = AvailableAirports.Where(a => a.City == selectedCity).Select(a => a.Name).Distinct().ToList();
            comboBoxName.DataSource = airports;
            comboBoxName.SelectedIndex = -1;
        }
        comboBoxName.Enabled = true;
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event for the country combo box.
    /// Updates the city combo box based on the selected country.
    /// </summary>
    private void comboBoxCountry_SelectedIndexChanged_1(object sender, EventArgs e)
    {
        if (comboBoxCountry.SelectedItem != null)
        {
            // Get the selected country and update the city combo box
            string selectedCountry = comboBoxCountry.SelectedItem.ToString();
            var cities = AvailableAirports.Where(a => a.Country == selectedCountry).Select(a => a.City).Distinct().ToList();
            comboBoxCity.DataSource = cities;
            comboBoxCity.SelectedIndex = -1;
        }
        comboBoxCity.Enabled = true;
        comboBoxName.Enabled = false;
    }

    /// <summary>
    /// Finds an airport by its ID.
    /// </summary>
    /// <param name="id">The ID of the airport to find.</param>
    /// <returns>The airport with the specified ID, or null if not found.</returns>
    private Airport FindAirportById(int id)
    {
        return Airports.FirstOrDefault(a => a.Id == id);
    }

    /// <summary>
    /// Gets the next available ID for a new airport.
    /// </summary>
    /// <returns>The next available ID.</returns>
    private int GetNextId()
    {
        return Airports.Count == 0 ? 1 : Airports.Max(a => a.Id) + 1;
    }

    /// <summary>
    /// Checks if a combo box has a selected item.
    /// </summary>
    /// <param name="comboBox">The combo box to check.</param>
    /// <param name="errorMessage">The error message to display if no item is selected.</param>
    /// <returns>True if an item is selected, otherwise false.</returns>
    private bool IsComboBoxSelected(ComboBox comboBox, string errorMessage)
    {
        if (comboBox.SelectedItem == null)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

    /// <summary>
    /// Populates the country combo box with available airport countries.
    /// </summary>
    private void PopulateCountryComboBoxes()
    {
        // Populate the country combo box with distinct country names from available airports
        comboBoxCountry.DataSource = AvailableAirports.Select(a => a.Country).Distinct().ToList();
        comboBoxCountry.SelectedIndex = -1;
    }

    /// <summary>
    /// Validates the form to ensure required combo boxes are selected.
    /// </summary>
    /// <returns>True if the form is valid, otherwise false.</returns>
    private bool ValidateForm()
    {
        // Validate if the required combo boxes have a selected item
        if (!IsComboBoxSelected(comboBoxCountry, "Select the country of the airport") ||
            !IsComboBoxSelected(comboBoxCity, "Select the city of the airport") ||
            !IsComboBoxSelected(comboBoxName, "Select the airport"))
        {
            return false;
        }
        return true;
    }
}
