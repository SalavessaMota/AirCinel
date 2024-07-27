namespace FinalProjectOOP.Classes;

/// <summary>
/// Represents a seat on an airplane, with properties for row, chair position, and availability.
/// </summary>
public class Seat
{
    /// <summary>
    /// Gets or sets the row number of the seat.
    /// </summary>
    public int Row { get; set; }

    /// <summary>
    /// Gets or sets the chair number within the row.
    /// </summary>
    public int Chair { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the seat is free.
    /// Default value is true.
    /// </summary>
    public bool Free { get; set; } = true;

    /// <summary>
    /// Gets the position of the seat in a human-readable format.
    /// The format is "RowLetter" (e.g., "12A").
    /// </summary>
    public string Position
    {
        get
        {
            // Combine the row number with the corresponding letter for the chair
            return $"{Row}{(char)('A' + Chair)}";
        }
    }

    /// <summary>
    /// Returns a string representation of the Seat object.
    /// </summary>
    /// <returns>A string that represents the Seat object.</returns>
    public override string ToString()
    {
        // Return the row and chair as a concatenated string
        return $"{Row}{Chair}";
    }
}
