using FinalProjectOOP;
using FinalProjectOOP.Classes;
using System.Text.RegularExpressions;

namespace FinalProjectPOO.Forms;

public partial class FormEditClient : Form
{
    // Private fields to hold the client being edited and the parent form
    private Client _client;
    private FormCRUDClients form;

    /// <summary>
    /// Initializes a new instance of the <see cref="FormEditClient"/> class.
    /// </summary>
    /// <param name="form">The parent form that opened this form.</param>
    /// <param name="client">The client object to be edited.</param>
    public FormEditClient(FormCRUDClients form, Client client)
    {
        this._client = client;
        this.form = form;
        InitializeComponent();

        // Initialize the text boxes with the client's current details
        textBoxName.Text = client.Name;
        textBoxPhoneNumber.Text = client.PhoneNumber;
        textBoxEmail.Text = client.Email;
        textBoxPassportNumber.Text = client.PassportNumber;
    }

    /// <summary>
    /// Validates the form input fields to ensure they are not empty and follow the required patterns.
    /// </summary>
    /// <returns>True if all fields are valid, otherwise false.</returns>
    private bool ValidateForm()
    {
        bool output = true;

        // Check if the client name text box is empty
        if (string.IsNullOrEmpty(textBoxName.Text))
        {
            MessageBox.Show("Please type in the client name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }
        else
        {
            string namePattern = @"^[a-zA-Z\s]+$"; // REGEX pattern for Name
            if (!Regex.IsMatch(textBoxName.Text, namePattern))
            {
                MessageBox.Show("Please enter a valid name (letters and spaces only)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
        }

        // Check if the client phone number text box is empty
        if (string.IsNullOrEmpty(textBoxPhoneNumber.Text))
        {
            MessageBox.Show("Please type in the client phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }
        else
        {
            string phonePattern = @"^[0-9]+$"; // REGEX pattern for Phone Number (numbers only)
            if (!Regex.IsMatch(textBoxPhoneNumber.Text, phonePattern))
            {
                MessageBox.Show("Please enter a valid phone number (numbers only)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
        }

        // Check if the client email text box is empty
        if (string.IsNullOrEmpty(textBoxEmail.Text))
        {
            MessageBox.Show("Please type in the client email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }
        else
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // REGEX pattern for Email
            if (!Regex.IsMatch(textBoxEmail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
        }

        // Check if the client passport number text box is empty
        if (string.IsNullOrEmpty(textBoxPassportNumber.Text))
        {
            MessageBox.Show("Please type in the client Passport Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }
        else
        {
            string passportPattern = @"^[a-zA-Z0-9]+$"; // REGEX pattern for Passport Number (alphanumeric)
            if (!Regex.IsMatch(textBoxPassportNumber.Text, passportPattern))
            {
                MessageBox.Show("Please enter a valid passport number (alphanumeric characters only)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
        }

        return output; // Return the validation result
    }

    /// <summary>
    /// Handles the click event for the Save button. Saves the changes made to the client.
    /// </summary>
    private void buttonSave_Click(object sender, EventArgs e)
    {
        // Validate the form before saving
        if (ValidateForm())
        {
            // Update the client details with the new values from the text boxes
            _client.Name = textBoxName.Text;
            _client.PhoneNumber = textBoxPhoneNumber.Text;
            _client.Email = textBoxEmail.Text;
            _client.PassportNumber = textBoxPassportNumber.Text;

            // Refresh the client list in the parent form
            form.InitList();

            // Close the form
            this.Close();
        }
    }

    /// <summary>
    /// Handles the click event for the Cancel button. Closes the form without saving changes.
    /// </summary>
    private void buttonCancel_Click_1(object sender, EventArgs e)
    {
        this.Close(); // Close the form
    }
}
