using FinalProjectOOP.Classes;

namespace FinalProjectPOO.Helpers;

public static class SeatDisplayHelper
{
    /// <summary>
    /// Displays the seats of the airplane with their occupancy status.
    /// </summary>
    /// <param name="airplane">The airplane containing the seats to be displayed.</param>
    /// <param name="ticketsBought">The list of tickets bought, used to determine seat occupancy.</param>
    /// <param name="panelSeats">The panel where the seats will be displayed.</param>
    public static void DisplaySeats(Airplane airplane, List<Ticket> ticketsBought, Panel panelSeats)
    {
        panelSeats.Controls.Clear();
        int rows = airplane.Seats.GetLength(0);
        int cols = airplane.Seats.GetLength(1);

        var occupiedSeats = ticketsBought.Select(t => t.Seat).ToList();

        // Determine the positions of the corridors based on the number of seats per row
        List<int> corridorPositions = GetCorridorPositions(cols);

        int seatWidth = 50;
        int seatHeight = 30;
        int corridorWidth = 50;

        // Calculate the total width of the seating area including corridors
        int totalWidth = cols * seatWidth + corridorPositions.Count * corridorWidth;

        // Calculate the starting X position to center the seating area in the panel
        int startX = (panelSeats.Width - totalWidth) / 2;
        if (startX < 0) startX = 0;  // Ensure startX is not negative

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                var seat = airplane.Seats[row, col];
                bool isOccupied = occupiedSeats.Any(s => s.Row == seat.Row && s.Chair == seat.Chair);

                Label seatLabel = new Label
                {
                    Width = seatWidth,
                    Height = seatHeight,
                    Text = $"{seat.Row}{(char)('A' + seat.Chair)}",
                    BackColor = isOccupied ? Color.Red : Color.Green,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = seat
                };

                // Calculate the X position for the seat, taking into account the corridors
                int xPos = startX + col * seatWidth;
                foreach (int corridorPos in corridorPositions)
                {
                    if (col >= corridorPos)
                    {
                        xPos += corridorWidth; // Add space for the corridor
                    }
                }

                panelSeats.Controls.Add(seatLabel);
                seatLabel.Location = new Point(xPos, row * seatHeight);
            }
        }

        // Draw corridors
        foreach (int corridorPos in corridorPositions)
        {
            int corridorXPos = startX + corridorPos * seatWidth + corridorPositions.TakeWhile(p => p <= corridorPos).Count() * corridorWidth;

            Label corridorLabel = new Label
            {
                Width = corridorWidth,
                Height = rows * seatHeight,
                BackColor = Color.LightGray,
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.None
            };

            panelSeats.Controls.Add(corridorLabel);
            corridorLabel.Location = new Point(corridorXPos, 0);
        }
    }

    /// <summary>
    /// Determines the positions of the corridors based on the number of seats per row.
    /// </summary>
    /// <param name="cols">The number of columns (seats) per row in the airplane.</param>
    /// <returns>Returns a list of integers representing the positions of the corridors.</returns>
    public static List<int> GetCorridorPositions(int cols)
    {
        List<int> corridorPositions = new List<int>();

        if (cols <= 6)
        {
            // For planes with 4-6 seats per row, add one corridor in the middle
            corridorPositions.Add(cols / 2);
        }
        else if (cols == 7)
        {
            // For planes with 7 seats per row, add two corridors (2-3-2 layout)
            corridorPositions.Add(2);
            corridorPositions.Add(5);
        }
        else if (cols == 8)
        {
            // For planes with 8 seats per row, add two corridors (2-4-2 layout)
            corridorPositions.Add(2);
            corridorPositions.Add(6);
        }
        else if (cols == 9)
        {
            // For planes with 9 seats per row, add two corridors (3-3-3 layout)
            corridorPositions.Add(3);
            corridorPositions.Add(6);
        }
        else if (cols == 10)
        {
            // For planes with 10 seats per row, add two corridors (3-4-3 layout)
            corridorPositions.Add(3);
            corridorPositions.Add(7);
        }

        return corridorPositions;
    }
}
