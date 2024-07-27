namespace FinalProjectOOP.Classes;

/// <summary>
/// Class responsible for generating a list of Airplane objects with predefined data.
/// </summary>
public class AirplaneList
{
    /// <summary>
    /// Loads a list of airplanes with predefined data.
    /// </summary>
    /// <returns>A List of Airplane objects</returns>
    public static List<Airplane> LoadAvioes()
    {
        List<Airplane> output = new List<Airplane>();


        // Add Airbus models to the list
        output.Add(new Airplane(1, "Airbus", "A320", 180, 30, 6));
        output.Add(new Airplane(2, "Airbus", "A330", 277, 35, 8));
        output.Add(new Airplane(3, "Airbus", "A350", 315, 35, 9));
        output.Add(new Airplane(4, "Airbus", "A380", 525, 56, 10));
        output.Add(new Airplane(5, "Airbus", "A220-300", 140, 28, 5));
        output.Add(new Airplane(6, "Airbus", "A321neo", 240, 40, 6));
        output.Add(new Airplane(7, "Airbus", "A319", 156, 26, 6));
        output.Add(new Airplane(8, "Airbus", "A340", 295, 40, 9));
        output.Add(new Airplane(9, "Airbus", "A310", 280, 40, 7));
        output.Add(new Airplane(10, "Airbus", "A318", 107, 18, 6));
        output.Add(new Airplane(11, "Airbus", "A220-100", 135, 27, 5));
        output.Add(new Airplane(12, "Airbus", "A350-1000", 366, 40, 9));
        output.Add(new Airplane(13, "Airbus", "A380-800", 575, 60, 10));
        output.Add(new Airplane(14, "Airbus", "A330-900", 287, 36, 8));

        // Add Boeing models to the list
        output.Add(new Airplane(15, "Boeing", "737-800", 189, 32, 6));
        output.Add(new Airplane(16, "Boeing", "777-300ER", 396, 40, 10));
        output.Add(new Airplane(17, "Boeing", "787-9", 296, 33, 9));
        output.Add(new Airplane(18, "Boeing", "747-8", 410, 42, 10));
        output.Add(new Airplane(19, "Boeing", "737 MAX 8", 210, 35, 6));
        output.Add(new Airplane(20, "Boeing", "767-300", 269, 40, 7));
        output.Add(new Airplane(21, "Boeing", "737-900", 180, 30, 6));
        output.Add(new Airplane(22, "Boeing", "777-200", 317, 35, 9));
        output.Add(new Airplane(23, "Boeing", "757-200", 239, 30, 8));
        output.Add(new Airplane(24, "Boeing", "767-400ER", 245, 35, 7));
        output.Add(new Airplane(25, "Boeing", "787-10", 318, 35, 9));
        output.Add(new Airplane(26, "Boeing", "737-700", 149, 25, 6));
        output.Add(new Airplane(27, "Boeing", "777X", 426, 43, 10));
        output.Add(new Airplane(28, "Boeing", "717", 134, 23, 6));

        // Add Bombardier models to the list
        output.Add(new Airplane(29, "Bombardier", "CRJ900", 90, 15, 5));
        output.Add(new Airplane(30, "Bombardier", "CRJ700", 78, 13, 4));
        output.Add(new Airplane(31, "Bombardier", "CS300", 145, 29, 5));
        output.Add(new Airplane(32, "Bombardier", "CRJ1000", 104, 17, 6));

        // Add Comac models to the list
        output.Add(new Airplane(37, "Comac", "C919", 168, 28, 6));

        // Add Embraer models to the list
        output.Add(new Airplane(33, "Embraer", "E190", 100, 17, 6));
        output.Add(new Airplane(34, "Embraer", "E175", 88, 15, 4));
        output.Add(new Airplane(35, "Embraer", "E170", 80, 13, 4));
        output.Add(new Airplane(36, "Embraer", "E195-E2", 146, 29, 5));

        // Add other manufacturers models to the list
        output.Add(new Airplane(38, "Irkut", "MC-21", 211, 35, 6));

        output.Add(new Airplane(39, "Mitsubishi", "MRJ90", 90, 15, 5));

        output.Add(new Airplane(40, "Sukhoi", "Superjet 100", 98, 16, 5));

        return output;
    }
}
