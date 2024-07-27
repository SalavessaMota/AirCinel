namespace FinalProjectOOP;

/// <summary>
/// Represents a form that displays information about the application.
/// </summary>
public partial class FormAbout : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FormAbout"/> class.
    /// </summary>
    public FormAbout()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Handles the Click event of the Close button.
    /// Closes the form when the button is clicked.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An EventArgs that contains the event data.</param>
    private void buttonClose_Click(object sender, EventArgs e)
    {
        // Close the form
        this.Close();
    }
}
