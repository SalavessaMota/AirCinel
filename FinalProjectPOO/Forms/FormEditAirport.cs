using FinalProjectOOP.Classes;

namespace FinalProjectOOP;

public partial class FormEditAirport : Form
{
    // Private fields to hold the airport being edited and the parent form
    private Airport _airportToEdit;
    private FormCRUDAirports _form;

    /// <summary>
    /// Initializes a new instance of the <see cref="FormEditAirport"/> class.
    /// </summary>
    /// <param name="form">The parent form that opened this form.</param>
    /// <param name="airportToEdit">The airport object to be edited.</param>
    public FormEditAirport(FormCRUDAirports form, Airport airportToEdit)
    {
        InitializeComponent();
        this._form = form;
        this._airportToEdit = airportToEdit;

        // Initialize the text boxes with the airport's current details
        textBoxAirportName.Text = airportToEdit.Name;
        textBoxAirportCity.Text = airportToEdit.City;
        textBoxAirportCountry.Text = airportToEdit.Country;
    }

    /// <summary>
    /// Validates the form input fields to ensure they are not empty.
    /// </summary>
    /// <returns>True if all fields are valid, otherwise false.</returns>
    private bool ValidateForm()
    {
        bool output = true;

        // Check if the airport name text box is empty
        if (string.IsNullOrEmpty(textBoxAirportName.Text))
        {
            MessageBox.Show("Insert the name of the airport", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }

        // Check if the airport city text box is empty
        if (string.IsNullOrEmpty(textBoxAirportCity.Text))
        {
            MessageBox.Show("Insert the city of the airport", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }

        // Check if the airport country text box is empty
        if (string.IsNullOrEmpty(textBoxAirportCountry.Text))
        {
            MessageBox.Show("Insert the country of the airport", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }

        return output; // Return the validation result
    }

    /// <summary>
    /// Handles the click event for the Cancel button. Closes the form without saving changes.
    /// </summary>
    private void buttonCancel_Click(object sender, EventArgs e)
    {
        this.Close(); // Close the form
    }

    /// <summary>
    /// Handles the click event for the Save button. Saves the changes made to the airport.
    /// </summary>
    private void buttonSave_Click(object sender, EventArgs e)
    {
        // Validate the form before saving
        if (ValidateForm())
        {
            // Update the airport details with the new values from the text boxes
            _airportToEdit.Name = textBoxAirportName.Text;
            _airportToEdit.City = textBoxAirportCity.Text;
            _airportToEdit.Country = textBoxAirportCountry.Text;

            // Refresh the airport list in the parent form
            _form.InitList();

            // Close the form
            this.Close();
        }
    }
}
