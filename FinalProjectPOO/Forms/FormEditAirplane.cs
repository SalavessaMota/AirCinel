using FinalProjectOOP.Classes;

namespace FinalProjectOOP;

public partial class FormEditAirplane : Form
{
    // Private fields to hold the airplane being edited and the parent form
    private Airplane _airplaneToEdit;
    private FormCRUDAirplanes _form;

    /// <summary>
    /// Initializes a new instance of the <see cref="FormEditAirplane"/> class.
    /// </summary>
    /// <param name="form">The parent form that opened this form.</param>
    /// <param name="editedAirplane">The airplane object to be edited.</param>
    public FormEditAirplane(FormCRUDAirplanes form, Airplane editedAirplane)
    {
        this._form = form;
        this._airplaneToEdit = editedAirplane;
        InitializeComponent();

        // Initialize the text boxes with the airplane's current details
        textBoxAirplaneBrand.Text = editedAirplane.Brand;
        textBoxAirplaneModel.Text = editedAirplane.Model;
        textBoxAirplaneCapacity.Text = editedAirplane.Capacity.ToString();
    }

    /// <summary>
    /// Handles the click event for the Cancel button. Closes the form without saving changes.
    /// </summary>
    private void buttonCancel_Click(object sender, EventArgs e)
    {
        this.Close(); // Close the form
    }

    /// <summary>
    /// Validates the form input fields to ensure they are not empty.
    /// </summary>
    /// <returns>True if all fields are valid, otherwise false.</returns>
    private bool ValidateForm()
    {
        bool output = true;

        // Check if the brand text box is empty
        if (string.IsNullOrEmpty(textBoxAirplaneBrand.Text))
        {
            MessageBox.Show("Insert the name of the Brand", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }

        // Check if the model text box is empty
        if (string.IsNullOrEmpty(textBoxAirplaneModel.Text))
        {
            MessageBox.Show("Insert the name of the Model", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }

        // Check if the capacity text box is empty
        if (string.IsNullOrEmpty(textBoxAirplaneCapacity.Text))
        {
            MessageBox.Show("Insert the capacity of the airplane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }

        return output; // Return the validation result
    }

    /// <summary>
    /// Handles the click event for the Save button. Saves the changes made to the airplane.
    /// </summary>
    private void buttonSave_Click(object sender, EventArgs e)
    {
        // Validate the form before saving
        if (ValidateForm())
        {
            // Update the airplane details with the new values from the text boxes
            _airplaneToEdit.Brand = textBoxAirplaneBrand.Text;
            _airplaneToEdit.Model = textBoxAirplaneModel.Text;
            _airplaneToEdit.Capacity = Convert.ToInt32(textBoxAirplaneCapacity.Text);

            // Refresh the airplane list in the parent form
            _form.InitList();

            // Close the form
            this.Close();
        }
    }
}
