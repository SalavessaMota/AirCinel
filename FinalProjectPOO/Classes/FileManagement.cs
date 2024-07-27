namespace FinalProjectOOP.Classes;

/// <summary>
/// Class responsible for managing file reading and writing.
/// </summary>
public static class FileManagement
{
    /// <summary>
    /// Saves a list of airports to a specified file.
    /// </summary>
    /// <param name="airports">List of airports to be saved.</param>
    /// <param name="path">Path of the file where the airports will be saved.</param>
    public static void SaveAirports(List<Airport> airports, string path)
    {
        try
        {
            // Create a StreamWriter to write to the file at the specified path
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                // Write each airport's details as a comma-separated string
                foreach (Airport airport in airports)
                {
                    string lineAirport = $"{airport.Id},{airport.Country},{airport.City},{airport.Name}";
                    writer.WriteLine(lineAirport);
                }
            }
        }
        catch (Exception ex)
        {
            // Show an error message if there is an issue saving the airports
            MessageBox.Show($"Error saving airports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Loads a list of airports from a specified file.
    /// </summary>
    /// <param name="path">Path of the file from where the airports will be loaded.</param>
    /// <returns>A list of airports.</returns>
    public static List<Airport> LoadAirports(string path)
    {
        List<Airport> airports = new List<Airport>();
        try
        {
            // Check if the file exists before attempting to read it
            if (File.Exists(path))
            {
                // Create a StreamReader to read from the file at the specified path
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    // Read each line from the file
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');

                        // Ensure the line has the correct number of parts
                        if (parts.Length == 4)
                        {
                            var airport = new Airport
                            {
                                Id = int.Parse(parts[0]),
                                Country = parts[1],
                                City = parts[2],
                                Name = parts[3]
                            };
                            airports.Add(airport);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Show an error message if there is an issue loading the airports
            MessageBox.Show($"Error loading airports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return airports;
    }

    /// <summary>
    /// Saves a list of airplanes to a specified file.
    /// </summary>
    /// <param name="airplanes">List of airplanes to be saved.</param>
    /// <param name="path">Path of the file where the airplanes will be saved.</param>
    public static void SaveAirplanes(List<Airplane> airplanes, string path)
    {
        try
        {
            // Create a StreamWriter to write to the file at the specified path
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                // Write each airplane's basic details and seat configuration
                foreach (Airplane airplane in airplanes)
                {
                    string lineAirplane = $"{airplane.Id},{airplane.Brand},{airplane.Model},{airplane.Capacity}";
                    writer.WriteLine(lineAirplane);

                    // Write the seat configuration for the airplane
                    int rows = airplane.Seats.GetLength(0);
                    int seatsPerRow = airplane.Seats.GetLength(1);
                    writer.WriteLine($"{rows},{seatsPerRow}");

                    writer.WriteLine();
                }
            }
        }
        catch (Exception ex)
        {
            // Show an error message if there is an issue saving the airplanes
            MessageBox.Show($"Error saving airplanes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Loads a list of airplanes from a specified file.
    /// </summary>
    /// <param name="path">Path of the file from where the airplanes will be loaded.</param>
    /// <returns>A list of airplanes.</returns>
    public static List<Airplane> LoadAirplanes(string path)
    {
        List<Airplane> airplanes = new List<Airplane>();
        try
        {
            // Check if the file exists before attempting to read it
            if (File.Exists(path))
            {
                // Create a StreamReader to read from the file at the specified path
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    // Read each line from the file
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        var parts = line.Split(',');

                        // Ensure the line has the correct number of parts
                        if (parts.Length == 4)
                        {
                            int id = int.Parse(parts[0]);
                            string brand = parts[1];
                            string model = parts[2];
                            int capacity = int.Parse(parts[3]);

                            // Read the seat configuration for the airplane
                            line = reader.ReadLine();
                            var seatConfig = line.Split(',');
                            int rows = int.Parse(seatConfig[0]);
                            int seatsPerRow = int.Parse(seatConfig[1]);

                            // Create a new Airplane object and add it to the list
                            var airplane = new Airplane(id, brand, model, capacity, rows, seatsPerRow);
                            airplanes.Add(airplane);

                            reader.ReadLine();
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Show an error message if there is an issue loading the airplanes
            MessageBox.Show($"Error loading airplanes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return airplanes;
    }

    /// <summary>
    /// Saves a list of clients to a specified file.
    /// </summary>
    /// <param name="clients">List of clients to be saved.</param>
    /// <param name="path">Path of the file where the clients will be saved.</param>
    public static void SaveClients(List<Client> clients, string path)
    {
        try
        {
            // Create a StreamWriter to write to the file at the specified path
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                // Write each client's details as a comma-separated string
                foreach (var client in clients)
                {
                    string lineClient = $"{client.Id},{client.Name},{client.PhoneNumber},{client.Email},{client.PassportNumber}";
                    writer.WriteLine(lineClient);
                }
            }
        }
        catch (Exception ex)
        {
            // Show an error message if there is an issue saving the clients
            MessageBox.Show($"Error saving clients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Loads a list of clients from a specified file.
    /// </summary>
    /// <param name="path">Path of the file from where the clients will be loaded.</param>
    /// <returns>A list of clients.</returns>
    public static List<Client> LoadClients(string path)
    {
        List<Client> clients = new List<Client>();
        try
        {
            // Check if the file exists before attempting to read it
            if (File.Exists(path))
            {
                // Create a StreamReader to read from the file at the specified path
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    // Read each line from the file
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');

                        // Ensure the line has the correct number of parts
                        if (parts.Length == 5)
                        {
                            int id = int.Parse(parts[0]);
                            string name = parts[1];
                            string phoneNumber = parts[2];
                            string email = parts[3];
                            string passportNumber = parts[4];

                            // Create a new Client object and add it to the list
                            var client = new Client
                            {
                                Id = id,
                                Name = name,
                                PhoneNumber = phoneNumber,
                                Email = email,
                                PassportNumber = passportNumber
                            };

                            clients.Add(client);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Show an error message if there is an issue loading the clients
            MessageBox.Show($"Error loading clients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return clients;
    }

    /// <summary>
    /// Saves a list of flights to a specified file.
    /// </summary>
    /// <param name="flights">List of flights to be saved.</param>
    /// <param name="path">Path of the file where the flights will be saved.</param>
    public static void SaveFlights(List<Flight> flights, string path)
    {
        try
        {
            // Create a StreamWriter to write to the file at the specified path
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                // Write each flight's details and tickets bought for the flight
                foreach (var flight in flights)
                {
                    string lineFlight = $"{flight.Number},{flight.DepartureTime},{flight.ArrivalTime},{flight.Origin.Id},{flight.Destiny.Id},{flight.Airplane.Id}";
                    writer.WriteLine(lineFlight);

                    // Write the tickets bought for the flight
                    foreach (var ticket in flight.TicketsBought)
                    {
                        writer.WriteLine($"{ticket.Id},{ticket.Client.Id},{ticket.Seat.Row},{ticket.Seat.Chair},{ticket.BuyDate}");
                    }

                    writer.WriteLine();
                }
            }
        }
        catch (Exception ex)
        {
            // Show an error message if there is an issue saving the flights
            MessageBox.Show($"Error saving flights: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Loads a list of flights from a specified file.
    /// </summary>
    /// <param name="path">Path of the file from where the flights will be loaded.</param>
    /// <param name="airports">List of airports to find the origin and destination airports.</param>
    /// <param name="airplanes">List of airplanes to find the airplane used in the flight.</param>
    /// <param name="clients">List of clients to find the clients who bought tickets for the flight.</param>
    /// <returns>A list of flights.</returns>
    public static List<Flight> LoadFlights(string path, List<Airport> airports, List<Airplane> airplanes, List<Client> clients)
    {
        List<Flight> flights = new List<Flight>();
        try
        {
            // Check if the file exists before attempting to read it
            if (File.Exists(path))
            {
                // Create a StreamReader to read from the file at the specified path
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    // Read each line from the file
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        var parts = line.Split(',');

                        // Ensure the line has the correct number of parts
                        if (parts.Length == 6)
                        {
                            string number = parts[0];
                            DateTime departureTime = DateTime.Parse(parts[1]);
                            DateTime arrivalTime = DateTime.Parse(parts[2]);
                            int originId = int.Parse(parts[3]);
                            int destinyId = int.Parse(parts[4]);
                            int airplaneId = int.Parse(parts[5]);

                            // Find the origin, destiny airports and the airplane using the provided ids
                            var origin = airports.First(a => a.Id == originId);
                            var destiny = airports.First(a => a.Id == destinyId);
                            var airplane = airplanes.First(a => a.Id == airplaneId);

                            // Create a new Flight object
                            var flight = new Flight
                            {
                                Number = number,
                                DepartureTime = departureTime,
                                ArrivalTime = arrivalTime,
                                Origin = origin,
                                Destiny = destiny,
                                Airplane = airplane,
                                TicketsBought = new List<Ticket>()
                            };

                            // Read the tickets bought for the flight
                            while ((line = reader.ReadLine()) != null && !string.IsNullOrWhiteSpace(line))
                            {
                                var ticketParts = line.Split(',');
                                if (ticketParts.Length == 5)
                                {
                                    int ticketId = int.Parse(ticketParts[0]);
                                    int clientId = int.Parse(ticketParts[1]);
                                    int seatRow = int.Parse(ticketParts[2]);
                                    int seatChair = int.Parse(ticketParts[3]);
                                    DateTime buyDate = DateTime.Parse(ticketParts[4]);

                                    // Find the client and seat using the provided ids
                                    var client = clients.First(c => c.Id == clientId);
                                    var seat = airplane.Seats[seatRow - 1, seatChair];

                                    // Create a new Ticket object
                                    var ticket = new Ticket
                                    {
                                        Id = ticketId,
                                        Flight = flight,
                                        Client = client,
                                        Seat = seat,
                                        BuyDate = buyDate
                                    };

                                    // Add the ticket to the flight's tickets if it doesn't already exist
                                    if (!flight.TicketsBought.Any(t => t.Id == ticket.Id))
                                    {
                                        flight.TicketsBought.Add(ticket);
                                    }
                                }
                            }

                            // Add the flight to the list of flights
                            flights.Add(flight);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Show an error message if there is an issue loading the flights
            MessageBox.Show($"Error loading flights: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return flights;
    }

    /// <summary>
    /// Saves a list of tickets to a specified file.
    /// </summary>
    /// <param name="tickets">List of tickets to be saved.</param>
    /// <param name="path">Path of the file where the tickets will be saved.</param>
    public static void SaveTickets(List<Ticket> tickets, string path)
    {
        try
        {
            // Create a StreamWriter to write to the file at the specified path
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                // Write each ticket's details as a comma-separated string
                foreach (var ticket in tickets)
                {
                    string lineTicket = $"{ticket.Id},{ticket.Flight.Number},{ticket.Client.Id},{ticket.Seat.Row},{ticket.Seat.Chair},{ticket.BuyDate}";
                    writer.WriteLine(lineTicket);
                }
            }
        }
        catch (Exception ex)
        {
            // Show an error message if there is an issue saving the tickets
            MessageBox.Show($"Error saving tickets: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Loads a list of tickets from a specified file.
    /// </summary>
    /// <param name="path">Path of the file from where the tickets will be loaded.</param>
    /// <param name="flights">List of flights to find the flight for each ticket.</param>
    /// <param name="clients">List of clients to find the client for each ticket.</param>
    /// <returns>A list of tickets.</returns>
    public static List<Ticket> LoadTickets(string path, List<Flight> flights, List<Client> clients)
    {
        List<Ticket> tickets = new List<Ticket>();
        try
        {
            // Check if the file exists before attempting to read it
            if (File.Exists(path))
            {
                // Create a StreamReader to read from the file at the specified path
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    // Read each line from the file
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');

                        // Ensure the line has the correct number of parts
                        if (parts.Length == 6)
                        {
                            int id = int.Parse(parts[0]);
                            string flightNumber = parts[1];
                            int clientId = int.Parse(parts[2]);
                            int seatRow = int.Parse(parts[3]);
                            int seatChair = int.Parse(parts[4]);
                            DateTime buyDate = DateTime.Parse(parts[5]);

                            // Find the flight and client using the provided ids
                            var flight = flights.First(f => f.Number == flightNumber);
                            var client = clients.First(c => c.Id == clientId);
                            var seat = flight.Airplane.Seats[seatRow - 1, seatChair];

                            // Create a new Ticket object
                            var ticket = new Ticket
                            {
                                Id = id,
                                Flight = flight,
                                Client = client,
                                Seat = seat,
                                BuyDate = buyDate
                            };

                            // Add the ticket to the flight's tickets if it doesn't already exist
                            if (!flight.TicketsBought.Any(t => t.Id == id))
                            {
                                flight.TicketsBought.Add(ticket);
                            }
                            // Add the ticket to the list of tickets
                            tickets.Add(ticket);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Show an error message if there is an issue loading the tickets
            MessageBox.Show($"Error loading tickets: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return tickets;
    }
}

