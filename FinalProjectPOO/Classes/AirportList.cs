namespace FinalProjectOOP.Classes;

/// <summary>
/// Class responsible for generating a list of Airport objects with predefined data.
/// </summary>
public class AirportList
{
    /// <summary>
    /// Loads a list of airports with predefined data.
    /// </summary>
    /// <returns>A List of Airport objects.</returns>
    public static List<Airport> LoadAirports()
    {
        List<Airport> output = new List<Airport>();

        // Europe
        output.Add(new Airport { Id = 1, Country = "France", City = "Paris", Name = "Charles de Gaulle Airport" });
        output.Add(new Airport { Id = 2, Country = "France", City = "Paris", Name = "Orly Airport" });
        output.Add(new Airport { Id = 3, Country = "Germany", City = "Frankfurt", Name = "Frankfurt Airport" });
        output.Add(new Airport { Id = 4, Country = "Germany", City = "Munich", Name = "Munich Airport" });
        output.Add(new Airport { Id = 5, Country = "Netherlands", City = "Amsterdam", Name = "Amsterdam Airport Schiphol" });
        output.Add(new Airport { Id = 6, Country = "Portugal", City = "Lisbon", Name = "Lisbon Humberto Delgado Airport" });
        output.Add(new Airport { Id = 7, Country = "Spain", City = "Barcelona", Name = "Barcelona-El Prat Airport" });
        output.Add(new Airport { Id = 8, Country = "Spain", City = "Madrid", Name = "Madrid-Barajas Airport" });
        output.Add(new Airport { Id = 9, Country = "United Kingdom", City = "London", Name = "Heathrow Airport" });
        output.Add(new Airport { Id = 10, Country = "United Kingdom", City = "London", Name = "Gatwick Airport" });
        output.Add(new Airport { Id = 11, Country = "Italy", City = "Rome", Name = "Leonardo da Vinci–Fiumicino Airport" });
        output.Add(new Airport { Id = 12, Country = "Italy", City = "Rome", Name = "Ciampino–G. B. Pastine International Airport" });
        output.Add(new Airport { Id = 13, Country = "Switzerland", City = "Zurich", Name = "Zurich Airport" });
        output.Add(new Airport { Id = 14, Country = "Belgium", City = "Brussels", Name = "Brussels Airport" });
        output.Add(new Airport { Id = 15, Country = "Denmark", City = "Copenhagen", Name = "Copenhagen Airport" });
        output.Add(new Airport { Id = 16, Country = "Austria", City = "Vienna", Name = "Vienna International Airport" });
        output.Add(new Airport { Id = 17, Country = "Ireland", City = "Dublin", Name = "Dublin Airport" });
        output.Add(new Airport { Id = 18, Country = "Greece", City = "Athens", Name = "Athens International Airport" });
        output.Add(new Airport { Id = 19, Country = "Sweden", City = "Stockholm", Name = "Stockholm Arlanda Airport" });
        output.Add(new Airport { Id = 20, Country = "Sweden", City = "Stockholm", Name = "Bromma Stockholm Airport" });
        output.Add(new Airport { Id = 21, Country = "Norway", City = "Oslo", Name = "Oslo Gardermoen Airport" });
        output.Add(new Airport { Id = 22, Country = "Finland", City = "Helsinki", Name = "Helsinki-Vantaa Airport" });
        output.Add(new Airport { Id = 23, Country = "Russia", City = "Moscow", Name = "Sheremetyevo International Airport" });
        output.Add(new Airport { Id = 24, Country = "Russia", City = "Moscow", Name = "Domodedovo International Airport" });
        output.Add(new Airport { Id = 25, Country = "Poland", City = "Warsaw", Name = "Warsaw Chopin Airport" });
        output.Add(new Airport { Id = 26, Country = "Czech Republic", City = "Prague", Name = "Václav Havel Airport Prague" });
        output.Add(new Airport { Id = 27, Country = "Hungary", City = "Budapest", Name = "Budapest Ferenc Liszt International Airport" });
        output.Add(new Airport { Id = 28, Country = "Turkey", City = "Istanbul", Name = "Istanbul Airport" });
        output.Add(new Airport { Id = 29, Country = "Turkey", City = "Istanbul", Name = "Istanbul Sabiha Gökçen International Airport" });

        // America
        output.Add(new Airport { Id = 30, Country = "Canada", City = "Toronto", Name = "Toronto Pearson International Airport" });
        output.Add(new Airport { Id = 31, Country = "Canada", City = "Toronto", Name = "Billy Bishop Toronto City Airport" });
        output.Add(new Airport { Id = 32, Country = "United States", City = "Atlanta", Name = "Hartsfield-Jackson Atlanta International Airport" });
        output.Add(new Airport { Id = 33, Country = "United States", City = "Chicago", Name = "O'Hare International Airport" });
        output.Add(new Airport { Id = 34, Country = "United States", City = "Chicago", Name = "Midway International Airport" });
        output.Add(new Airport { Id = 35, Country = "United States", City = "Dallas", Name = "Dallas/Fort Worth International Airport" });
        output.Add(new Airport { Id = 36, Country = "United States", City = "Dallas", Name = "Dallas Love Field" });
        output.Add(new Airport { Id = 37, Country = "United States", City = "Denver", Name = "Denver International Airport" });
        output.Add(new Airport { Id = 38, Country = "United States", City = "Los Angeles", Name = "Los Angeles International Airport" });
        output.Add(new Airport { Id = 39, Country = "United States", City = "Los Angeles", Name = "Hollywood Burbank Airport" });
        output.Add(new Airport { Id = 40, Country = "United States", City = "Miami", Name = "Miami International Airport" });
        output.Add(new Airport { Id = 41, Country = "United States", City = "Miami", Name = "Fort Lauderdale-Hollywood International Airport" });
        output.Add(new Airport { Id = 42, Country = "United States", City = "New York", Name = "John F. Kennedy International Airport" });
        output.Add(new Airport { Id = 43, Country = "United States", City = "New York", Name = "LaGuardia Airport" });
        output.Add(new Airport { Id = 44, Country = "United States", City = "New York", Name = "Newark Liberty International Airport" });

        // Asia
        output.Add(new Airport { Id = 45, Country = "China", City = "Beijing", Name = "Beijing Capital International Airport" });
        output.Add(new Airport { Id = 46, Country = "China", City = "Beijing", Name = "Beijing Daxing International Airport" });
        output.Add(new Airport { Id = 47, Country = "China", City = "Chengdu", Name = "Chengdu Shuangliu International Airport" });
        output.Add(new Airport { Id = 48, Country = "China", City = "Chengdu", Name = "Chengdu Tianfu International Airport" });
        output.Add(new Airport { Id = 49, Country = "China", City = "Guangzhou", Name = "Guangzhou Baiyun International Airport" });
        output.Add(new Airport { Id = 50, Country = "China", City = "Shanghai", Name = "Shanghai Pudong International Airport" });
        output.Add(new Airport { Id = 51, Country = "China", City = "Shanghai", Name = "Shanghai Hongqiao International Airport" });
        output.Add(new Airport { Id = 52, Country = "Hong Kong", City = "Hong Kong", Name = "Hong Kong International Airport" });
        output.Add(new Airport { Id = 53, Country = "Indonesia", City = "Jakarta", Name = "Soekarno-Hatta International Airport" });
        output.Add(new Airport { Id = 54, Country = "Japan", City = "Tokyo", Name = "Tokyo Haneda Airport" });
        output.Add(new Airport { Id = 55, Country = "Japan", City = "Tokyo", Name = "Narita International Airport" });
        output.Add(new Airport { Id = 56, Country = "Malaysia", City = "Kuala Lumpur", Name = "Kuala Lumpur International Airport" });
        output.Add(new Airport { Id = 57, Country = "Singapore", City = "Singapore", Name = "Singapore Changi Airport" });
        output.Add(new Airport { Id = 58, Country = "South Korea", City = "Seoul", Name = "Incheon International Airport" });
        output.Add(new Airport { Id = 59, Country = "South Korea", City = "Seoul", Name = "Gimpo International Airport" });
        output.Add(new Airport { Id = 60, Country = "Turkey", City = "Istanbul", Name = "Istanbul Airport" });
        output.Add(new Airport { Id = 61, Country = "Turkey", City = "Istanbul", Name = "Istanbul Sabiha Gökçen International Airport" });
        output.Add(new Airport { Id = 62, Country = "United Arab Emirates", City = "Dubai", Name = "Dubai International Airport" });

        // Australia
        output.Add(new Airport { Id = 63, Country = "Australia", City = "Sydney", Name = "Sydney Kingsford Smith Airport" });

        // Africa
        output.Add(new Airport { Id = 64, Country = "Egypt", City = "Cairo", Name = "Cairo International Airport" });
        output.Add(new Airport { Id = 65, Country = "South Africa", City = "Johannesburg", Name = "O. R. Tambo International Airport" });

        return output;
    }
}
