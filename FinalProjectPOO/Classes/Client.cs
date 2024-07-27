namespace FinalProjectOOP.Classes;

/// <summary>
/// Represents a client, with properties for identification, name, phone number, email, and passport number.
/// </summary>
public class Client
{
    /// <summary>
    /// Gets or sets the unique identifier of the client.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Gets or sets the name of the client.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Gets or sets the phone number of the client.
    /// </summary>
    public string PhoneNumber { get; set; }
    /// <summary>
    /// Gets or sets the email of the client.
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Gets or sets the passport number of the client.
    /// </summary>
    public string PassportNumber { get; set; }

    /// <summary>
    /// Returns a string representation of the Client object, including all its fields.
    /// </summary>
    /// <returns>A String that represents the Client object.</returns>
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Phone Number: {PhoneNumber}, Email: {Email}, Passport Number: {PassportNumber}";
    }
}
