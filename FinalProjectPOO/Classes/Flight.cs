namespace FinalProjectOOP.Classes;

/// <summary>
/// Represents a flight, with properties for flight number, departure and arrival times, origin and destination airports, airplane, and tickets bought.
/// </summary>
public class Flight
{
    /// <summary>
    /// Gets or sets the flight number.
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// Gets or sets the departure time of the flight.
    /// </summary>
    public DateTime DepartureTime { get; set; }

    /// <summary>
    /// Gets or sets the arrival time of the flight.
    /// </summary>
    public DateTime ArrivalTime { get; set; }

    /// <summary>
    /// Gets or sets the origin airport of the flight.
    /// </summary>
    public Airport Origin { get; set; }

    /// <summary>
    /// Gets or sets the destination airport of the flight.
    /// </summary>
    public Airport Destiny { get; set; }

    /// <summary>
    /// Gets or sets the airplane used for the flight.
    /// </summary>
    public Airplane Airplane { get; set; }

    /// <summary>
    /// Gets or sets the list of tickets bought for the flight.
    /// </summary>
    public List<Ticket> TicketsBought { get; set; }

    /// <summary>
    /// Returns a string representation of the Flight object, including its details.
    /// </summary>
    /// <returns>A string that represents the Flight object.</returns>
    public override string ToString()
    {
        // Format the departure and arrival times
        string departure = DepartureTime.ToString("g");
        string arrival = ArrivalTime.ToString("g");

        // Return a formatted string with flight details
        return $"Number: {Number} - Departure Date: {departure} - Arrival Date: {arrival} - Origin: {Origin.City} / {Origin.Country} - Destiny: {Destiny.City} / {Destiny.Country} - Airplane: {Airplane.Model}";
    }
}
