namespace FinalProjectOOP.Classes;

/// <summary>
/// Represents an airport, with properties for identification and location.
/// </summary>
public class Airport
{
    /// <summary>
    /// Gets or sets the unique identifier of the airport.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the country where the airport is located.
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the city where the airport is located.
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the name of the airport.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Returns a string representation of the Airport object, including all its fields.
    /// </summary>
    /// <returns>A string that represents the Airport object.</returns>
    public override string ToString()
    {
        // Format and return airport data as a string
        return $"Id: {Id}, Country: {Country}, City: {City}, Name: {Name}";
    }
}
