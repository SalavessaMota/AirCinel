using FinalProjectOOP.Classes;
using FinalProjectPOO.Forms;
using System.Text.RegularExpressions;

namespace FinalProjectOOP;

public partial class FormCRUDClients : Form
{
    public List<Client> Clients { get; set; }
    public List<Ticket> Tickets { get; set; }

    public FormCRUDClients(List<Client> clients, List<Ticket> tickets)
    {
        Tickets = tickets;
        Clients = clients;
        InitializeComponent();
        InitList();
    }

    /// <summary>
    /// Initializes the list of clients and updates the User Interface.
    /// </summary>
    public void InitList()
    {
        listBoxClients.DataSource = null;
        listBoxClients.DataSource = Clients;
    }

    /// <summary>
    /// Handles the click event for the Save New Client button. Validates the form and adds a new client to the list.
    /// </summary>
    private void buttonSaveNewClient_Click(object sender, EventArgs e)
    {
        Client newClient;

        if (ValidateForm())
        {
            // Create a new client object and set its properties
            newClient = new Client
            {
                Id = GetNextId(),
                Name = textBoxNewClientName.Text,
                PhoneNumber = textBoxNewClientPhoneNumber.Text,
                Email = textBoxNewClientEmail.Text,
                PassportNumber = textBoxNewClientPassportNumber.Text,
            };

            // Add the new client to the list
            Clients.Add(newClient);

            InitList();

            //MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the text boxes
            textBoxNewClientName.Text = string.Empty;
            textBoxNewClientPhoneNumber.Text = string.Empty;
            textBoxNewClientEmail.Text = string.Empty;
            textBoxNewClientPassportNumber.Text = string.Empty;
        }
        else
        {
            MessageBox.Show("Please type in all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Clear the text boxes again (in case validation failed)
        textBoxNewClientName.Text = string.Empty;
        textBoxNewClientPhoneNumber.Text = string.Empty;
        textBoxNewClientEmail.Text = string.Empty;
        textBoxNewClientPassportNumber.Text = string.Empty;
    }

    /// <summary>
    /// Validates the form to ensure all required fields are filled correctly.
    /// </summary>
    /// <returns>True if the form is valid, otherwise false.</returns>
    private bool ValidateForm()
    {
        bool output = true;

        if (string.IsNullOrEmpty(textBoxNewClientName.Text))
        {
            MessageBox.Show("Please type in the client name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }
        else
        {
            string namePattern = @"^[a-zA-Z\s]+$"; // Regex pattern for name (letters and spaces only)
            if (!Regex.IsMatch(textBoxNewClientName.Text, namePattern))
            {
                MessageBox.Show("Please enter a valid name (letters and spaces only)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
        }

        if (string.IsNullOrEmpty(textBoxNewClientPhoneNumber.Text))
        {
            MessageBox.Show("Please type in the client phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }
        else
        {
            string phonePattern = @"^[0-9]+$"; // Regex pattern for phone number (numbers only)
            if (!Regex.IsMatch(textBoxNewClientPhoneNumber.Text, phonePattern))
            {
                MessageBox.Show("Please enter a valid phone number (numbers only)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
        }

        if (string.IsNullOrEmpty(textBoxNewClientEmail.Text))
        {
            MessageBox.Show("Please type in the client email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }
        else
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Regex pattern for email
            if (!Regex.IsMatch(textBoxNewClientEmail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
        }

        if (string.IsNullOrEmpty(textBoxNewClientPassportNumber.Text))
        {
            MessageBox.Show("Please type in the client Passport Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            output = false;
        }
        else
        {
            string passportPattern = @"^[a-zA-Z0-9]+$"; // Regex pattern for passport number (alphanumeric)
            if (!Regex.IsMatch(textBoxNewClientPassportNumber.Text, passportPattern))
            {
                MessageBox.Show("Please enter a valid passport number (alphanumeric characters only)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
        }

        return output;
    }

    /// <summary>
    /// Gets the next available ID for a new client.
    /// </summary>
    /// <returns>The next available ID.</returns>
    private int GetNextId()
    {
        // Get the next available ID by finding the max ID in the list and adding 1
        return Clients.Count == 0 ? 1 : Clients.Max(a => a.Id) + 1;
    }

    /// <summary>
    /// Handles the click event for the Edit Client button. Opens a form to edit the selected client.
    /// </summary>
    private void buttonEditClient_Click(object sender, EventArgs e)
    {
        // Get the selected client from the list box
        var clientToEdit = (Client)listBoxClients.SelectedItem;
        if (clientToEdit != null)
        {
            var editedClient = FindClientById(clientToEdit.Id);
            if (editedClient != null)
            {
                // Open the form to edit the client
                var formEditClient = new FormEditClient(this, editedClient);
                formEditClient.Show();
            }
        }
    }

    /// <summary>
    /// Finds a client by its ID.
    /// </summary>
    /// <param name="id">The ID of the client to find.</param>
    /// <returns>The client with the specified ID, or null if not found.</returns>
    private Client FindClientById(int id)
    {
        // Find the client by ID in the list
        return Clients.FirstOrDefault(a => a.Id == id);
    }

    /// <summary>
    /// Handles the click event for the Delete Client button. Deletes the selected client from the list.
    /// </summary>
    private void buttonDeleteClient_Click(object sender, EventArgs e)
    {
        // Get the selected client from the list box
        var clientToDelete = (Client)listBoxClients.SelectedItem;
        if (clientToDelete != null)
        {
            var deletedClient = FindClientById(clientToDelete.Id);

            if (deletedClient != null)
            {
                // Check if the client has associated tickets
                var associatedTickets = Tickets.Where(t => t.Client.Id == deletedClient.Id).ToList();

                string message = $"Are you sure you want to delete the client: '{deletedClient.Name}'?";
                if (associatedTickets.Count > 0)
                {
                    // Inform the user if the client has associated tickets
                    message += $" This client is associated with {associatedTickets.Count} ticket(s). These tickets will also be deleted.";
                }

                // Show confirmation dialog before deleting
                DialogResult answer = MessageBox.Show(message, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (answer == DialogResult.OK)
                {
                    // Remove associated tickets and the client
                    foreach (var ticket in associatedTickets)
                    {
                        Tickets.Remove(ticket);
                    }

                    Clients.Remove(deletedClient);
                    InitList();
                }
            }
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        textBoxNewClientName.Text = string.Empty;
        textBoxNewClientPhoneNumber.Text = string.Empty;
        textBoxNewClientEmail.Text = string.Empty;
        textBoxNewClientPassportNumber.Text = string.Empty;
    }
}
