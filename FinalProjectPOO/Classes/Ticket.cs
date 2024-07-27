namespace FinalProjectOOP.Classes;

/// <summary>
/// Represents a ticket for a flight, including details about the flight, client, seat, and purchase date.
/// </summary>
public class Ticket
{
    /// <summary>
    /// Gets or sets the unique identifier of the ticket.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the flight associated with the ticket.
    /// </summary>
    public Flight Flight { get; set; }

    /// <summary>
    /// Gets or sets the client who purchased the ticket.
    /// </summary>
    public Client Client { get; set; }

    /// <summary>
    /// Gets or sets the seat assigned to the ticket.
    /// </summary>
    public Seat Seat { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the ticket was purchased.
    /// </summary>
    public DateTime BuyDate { get; set; }

    /// <summary>
    /// Returns a string representation of the Ticket object, including its details.
    /// </summary>
    /// <returns>A string that represents the Ticket object.</returns>
    public override string ToString()
    {
        // Format and return ticket details as a string
        return $"Id: {Id} - Flight: {Flight.Number} - Client: {Client.Name} - Seat: {Seat.Position} - Buy Date: {BuyDate}";
    }
}
