using FinalProjectOOP.Classes;
using Syncfusion.Windows.Forms.Chart;

namespace FinalProjectOOP;

public partial class FormCRUDAirplanes : Form
{
    // Load the list of available airplanes
    private List<Airplane> AvailableAirplanes = AirplaneList.LoadAvioes();

    public List<Airplane> Airplanes { get; set; }

    public FormCRUDAirplanes(List<Airplane> airplanes)
    {
        Airplanes = airplanes;
        InitializeComponent();
        PopulateBrandComboBox();
        InitList();
    }

    /// <summary>
    /// Populates the brand combo box with available airplane brands.
    /// </summary>
    private void PopulateBrandComboBox()
    {
        // Populate the combo box with distinct airplane brands
        comboBoxBrand.DataSource = AvailableAirplanes.Select(a => a.Brand).Distinct().ToList();
        comboBoxBrand.SelectedIndex = -1;
    }

    /// <summary>
    /// Validates the form to ensure required combo boxes are selected.
    /// </summary>
    /// <returns>True if the form is valid, otherwise false.</returns>
    private bool ValidateForm()
    {
        // Validate if the brand and model combo boxes have selected items
        if (!IsComboBoxSelected(comboBoxBrand, "Select the brand of the airplane") ||
            !IsComboBoxSelected(comboBoxModel, "Select the model of the airplane"))
        {
            return false;
        }
        return true;
    }

    /// <summary>
    /// Checks if a combo box has a selected item.
    /// </summary>
    /// <param name="comboBox">The combo box to check.</param>
    /// <param name="errorMessage">The error message to display if no item is selected.</param>
    /// <returns>True if an item is selected, otherwise false.</returns>
    private bool IsComboBoxSelected(ComboBox comboBox, string errorMessage)
    {
        // Check if a combo box has a selected item, and show an error message if not
        if (comboBox.SelectedItem == null)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

    /// <summary>
    /// Initializes the list of available airplanes and updates the UI.
    /// </summary>
    public void InitList()
    {
        // Reset the data source of the list box to refresh the display
        listBoxAvailableAirplanes.DataSource = null;
        listBoxAvailableAirplanes.DataSource = Airplanes;
        comboBoxBrand.SelectedIndex = -1;
        comboBoxModel.SelectedIndex = -1;
        comboBoxModel.Enabled = false;
        labelCapacity.Text = string.Empty;

    }

    /// <summary>
    /// Gets the next available ID for a new airplane.
    /// </summary>
    /// <returns>The next available ID.</returns>
    private int GetNextId()
    {
        // Get the next available ID by finding the max ID in the list and adding 1
        return Airplanes.Count == 0 ? 1 : Airplanes.Max(a => a.Id) + 1;
    }

    /// <summary>
    /// Handles the click event for the Save button. Validates the form and adds a new airplane to the list.
    /// </summary>
    private void buttonSave_Click(object sender, EventArgs e)
    {
        if (ValidateForm())
        {
            // Get the selected brand and model from the combo boxes
            string selectedBrand = comboBoxBrand.SelectedItem.ToString();
            string selectedModel = comboBoxModel.SelectedItem.ToString();
            var selectedAirplane = AvailableAirplanes.FirstOrDefault(a => a.Brand == selectedBrand && a.Model == selectedModel);

            if (selectedAirplane != null)
            {
                // Create a deep copy of the seats
                var newSeats = new Seat[selectedAirplane.Seats.GetLength(0), selectedAirplane.Seats.GetLength(1)];
                for (int row = 0; row < selectedAirplane.Seats.GetLength(0); row++)
                {
                    for (int chair = 0; chair < selectedAirplane.Seats.GetLength(1); chair++)
                    {
                        var seat = selectedAirplane.Seats[row, chair];
                        newSeats[row, chair] = new Seat { Row = seat.Row, Chair = seat.Chair };
                    }
                }

                // Create a new airplane with the next available ID
                var newAirplane = new Airplane(
                    GetNextId(),
                    selectedBrand,
                    selectedModel,
                    selectedAirplane.Capacity,
                    newSeats
                );

                // Add the new airplane to the list and update the UI
                Airplanes.Add(newAirplane);
                InitList();
                //MessageBox.Show("Airplane added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event for the brand combo box.
    /// Updates the model combo box based on the selected brand.
    /// </summary>
    private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxBrand.SelectedItem != null)
        {
            // Get the selected brand and update the model combo box
            string selectedBrand = comboBoxBrand.SelectedItem.ToString();
            var models = AvailableAirplanes.Where(a => a.Brand == selectedBrand).Select(a => a.Model).Distinct().ToList();
            comboBoxModel.DataSource = models;
            comboBoxModel.SelectedIndex = -1;
            labelCapacity.Text = string.Empty;
        }
        comboBoxModel.Enabled = true;
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event for the model combo box.
    /// Updates the capacity label based on the selected model.
    /// </summary>
    private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxBrand.SelectedItem != null && comboBoxModel.SelectedItem != null)
        {
            // Get the selected brand and model and update the capacity label
            string selectedBrand = comboBoxBrand.SelectedItem.ToString();
            string selectedModel = comboBoxModel.SelectedItem.ToString();
            var selectedAirplane = AvailableAirplanes.FirstOrDefault(a => a.Brand == selectedBrand && a.Model == selectedModel);
            if (selectedAirplane != null)
            {
                labelCapacity.Text = selectedAirplane.Capacity.ToString();
            }
        }
    }

    /// <summary>
    /// Handles the click event for the Delete Airplane button. Deletes the selected airplane from the list.
    /// </summary>
    private void buttonDeleteAirplane_Click(object sender, EventArgs e)
    {
        // Get the selected airplane from the list box
        var airplaneToDelete = (Airplane)listBoxAvailableAirplanes.SelectedItem;
        if (airplaneToDelete != null)
        {
            var deletedAirplane = FindAirplaneById(airplaneToDelete.Id);

            if (deletedAirplane != null)
            {
                // Show confirmation dialog before deleting
                DialogResult answer = MessageBox.Show($"Are you sure you want to delete this {deletedAirplane.Brand} {deletedAirplane.Model} airplane?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (answer == DialogResult.OK)
                {
                    // Remove the airplane from the list and update the UI
                    Airplanes.Remove(deletedAirplane);
                    InitList();
                }
            }
        }
    }

    /// <summary>
    /// Handles the click event for the Edit Airplane button. Opens a form to edit the selected airplane.
    /// </summary>
    private void buttonEditAirplane_Click(object sender, EventArgs e)
    {
        // Get the selected airplane from the list box
        var airplaneToEdit = (Airplane)listBoxAvailableAirplanes.SelectedItem;
        if (airplaneToEdit != null)
        {
            var editedAirplane = FindAirplaneById(airplaneToEdit.Id);
            if (editedAirplane != null)
            {
                // Open the form to edit the airplane
                var formEditAirplane = new FormEditAirplane(this, editedAirplane);
                formEditAirplane.Show();
            }
        }
    }

    /// <summary>
    /// Finds an airplane by its ID.
    /// </summary>
    /// <param name="id">The ID of the airplane to find.</param>
    /// <returns>The airplane with the specified ID, or null if not found.</returns>
    private Airplane FindAirplaneById(int id)
    {
        // Find the airplane by ID in the list
        return Airplanes.FirstOrDefault(a => a.Id == id);
    }

    /// <summary>
    /// Handles the click event for the Refresh button. Reinitializes the list.
    /// </summary>
    private void button2_Click(object sender, EventArgs e)
    {
        // Reinitialize the list of available airplanes
        InitList();
    }
}
