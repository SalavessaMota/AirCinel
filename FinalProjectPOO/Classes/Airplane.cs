namespace FinalProjectOOP.Classes
{
    /// <summary>
    /// Represents an airplane, with properties for identification, brand, model, passenger capacity, and available seats.
    /// </summary>
    public class Airplane
    {
        /// <summary>
        /// Gets or sets the unique identifier of the airplane.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the brand of the airplane.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets the model of the airplane.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the total passenger capacity of the airplane.
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Matrix of available seats on the airplane.
        /// </summary>
        public Seat[,] Seats { get; set; }

        /// <summary>
        /// Constructor to create an instance of Airplane with specific parameters.
        /// </summary>
        /// <param name="id">The identifier of the airplane.</param>
        /// <param name="brand">The brand of the airplane.</param>
        /// <param name="model">The model of the airplane.</param>
        /// <param name="capacity">The total passenger capacity of the airplane.</param>
        /// <param name="seats">Matrix of seats on the airplane.</param>
        public Airplane(int id, string brand, string model, int capacity, Seat[,] seats)
        {
            // Initialize properties with the constructor parameters
            Id = id;
            Brand = brand;
            Model = model;
            Capacity = capacity;
            Seats = seats;
        }

        /// <summary>
        /// Constructor to create an instance of Airplane with a specific configuration of rows and seats per row.
        /// </summary>
        /// <param name="id">The identifier of the airplane.</param>
        /// <param name="brand">The brand of the airplane.</param>
        /// <param name="model">The model of the airplane.</param>
        /// <param name="capacity">The total passenger capacity of the airplane.</param>
        /// <param name="rows">Number of rows of seats.</param>
        /// <param name="seatsPerRow">Number of seats per row.</param>
        public Airplane(int id, string brand, string model, int capacity, int rows, int seatsPerRow)
        {
            // Initialize properties with the constructor parameters
            Id = id;
            Brand = brand;
            Model = model;
            Capacity = capacity;

            // Creating the matrix of seats based on rows and seats per row
            Seats = new Seat[rows, seatsPerRow];
            for (int row = 0; row < rows; row++)
            {
                for (int seat = 0; seat < seatsPerRow; seat++)
                {
                    // Initialize each seat in the matrix
                    Seats[row, seat] = new Seat { Row = row + 1, Chair = seat };
                }
            }
        }

        /// <summary>
        /// Returns a string representation of the Airplane object, showing brand, model, and capacity.
        /// </summary>
        /// <returns>A string that represents the Airplane object.</returns>
        public override string ToString()
        {
            // Format and return airplane data as a string
            return $"Id: {Id}, Brand: {Brand}, Model: {Model}, Capacity: {Capacity}";
        }
    }
}
