using FinalProjectOOP.Classes;
using FinalProjectPOO.Forms;
using FinalProjectPOO.Helpers;
using FinalProjectPOO.Properties;
using QRCoder;
using System.Data;
using System.Drawing.Printing;

namespace FinalProjectOOP;

public partial class FormCRUDTickets : Form
{
    private Airplane _selectedAirplane;

    public List<Flight> Flights { get; set; }
    public List<Client> Clients { get; set; }
    public List<Ticket> Tickets { get; set; }

    public List<Airplane> Airplanes { get; set; }

    public FormCRUDTickets(List<Flight> flights, List<Client> clients, List<Ticket> tickets, List<Airplane> airplanes)
    {
        Flights = flights;
        Clients = clients;
        Tickets = tickets;
        Airplanes = airplanes;
        InitializeComponent();
        Init();
        panelSeats.Controls.Clear();
    }

    public void Init()
    {
        listBoxAvailableFlights.DataSource = null;
        listBoxAvailableFlights.DataSource = Flights;
        listBoxAvailableFlights.SelectedIndex = -1;

        comboBoxFilterOrigin.DataSource = null;
        comboBoxFilterOrigin.DataSource = Flights.Select(f => f.Origin.Country).Distinct().ToList();
        comboBoxFilterOrigin.SelectedIndex = -1;

        comboBoxFilterDestiny.DataSource = null;
        comboBoxFilterDestiny.DataSource = Flights.Select(f => f.Destiny.Country).Distinct().ToList();
        comboBoxFilterDestiny.SelectedIndex = -1;

        comboBoxFilterAirplane.DataSource = null;
        comboBoxFilterAirplane.DataSource = Flights.Select(f => f.Airplane.Model).Distinct().ToList();
        comboBoxFilterAirplane.SelectedIndex = -1;

        comboBoxFilterDeparture.DataSource = null;
        comboBoxFilterDeparture.DataSource = Flights.Select(f => f.DepartureTime.Date).Distinct().ToList();
        comboBoxFilterDeparture.SelectedIndex = -1;

        comboBoxFilterArrival.DataSource = null;
        comboBoxFilterArrival.DataSource = Flights.Select(f => f.ArrivalTime.Date).Distinct().ToList();
        comboBoxFilterArrival.SelectedIndex = -1;

        listBoxClients.DataSource = null;
        listBoxClients.DataSource = Clients;
        listBoxClients.DisplayMember = "Name";
        listBoxClients.SelectedIndex = -1;

        listBoxTickets.DataSource = null;
        listBoxTickets.DataSource = Tickets;
        listBoxTickets.SelectedItem = null;
        listBoxTickets.SelectedIndex = -1;
    }

    private void buttonApplyFilters_Click(object sender, EventArgs e)
    {
        List<Flight> filteredFlights;

        string selectedOrigin = comboBoxFilterOrigin.SelectedItem?.ToString();
        string selectedDestiny = comboBoxFilterDestiny.SelectedItem?.ToString();
        string selectedAirplane = comboBoxFilterAirplane.SelectedItem?.ToString();
        DateTime? selectedDepartureDate = comboBoxFilterDeparture.SelectedItem as DateTime?;
        DateTime? selectedArrivalDate = comboBoxFilterArrival.SelectedItem as DateTime?;

        // Filter flights based on selected criteria
        filteredFlights = Flights.Where(f => (selectedOrigin == null || f.Origin.Country == selectedOrigin) && (selectedDestiny == null || f.Destiny.Country == selectedDestiny) && (selectedAirplane == null || f.Airplane.Model == selectedAirplane) && (!selectedDepartureDate.HasValue || f.DepartureTime.Date == selectedDepartureDate.Value) && (!selectedArrivalDate.HasValue || f.ArrivalTime.Date == selectedArrivalDate.Value)).ToList();

        listBoxAvailableFlights.DataSource = null;
        listBoxAvailableFlights.DataSource = filteredFlights;
        listBoxAvailableFlights.SelectedIndex = -1;
    }

    private void buttonClearFilters_Click(object sender, EventArgs e)
    {
        Init();

        comboBoxFilterOrigin.Text = "Origin";
        comboBoxFilterDestiny.Text = "Destiny";
        comboBoxFilterAirplane.Text = "Airplane";
        comboBoxFilterDeparture.Text = "Departure";
        comboBoxFilterArrival.Text = "Arrival";
    }

    private void listBoxAvailableFlights_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedFlight = (Flight)listBoxAvailableFlights.SelectedItem;
        if (selectedFlight != null)
        {
            _selectedAirplane = selectedFlight.Airplane;
            FillSeatComboBoxes(_selectedAirplane);
            // Use the helper class to display seats
            SeatDisplayHelper.DisplaySeats(_selectedAirplane, selectedFlight.TicketsBought, panelSeats);
        }
    }

    private void FillSeatComboBoxes(Airplane airplane)
    {
        var rows = Enumerable.Range(1, airplane.Seats.GetLength(0)).ToList();
        var seats = Enumerable.Range(0, airplane.Seats.GetLength(1)).Select(i => (char)('A' + i)).ToList();

        comboBoxRows.DataSource = null;
        comboBoxRows.DataSource = rows;

        comboBoxSeats.DataSource = null;
        comboBoxSeats.DataSource = seats;
    }

    private int GetNextTicketId()
    {
        return Tickets.Count == 0 ? 1 : Tickets.Max(t => t.Id) + 1;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (listBoxTickets.SelectedItem != null)
        {
            Ticket selectedTicket = (Ticket)listBoxTickets.SelectedItem;

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, ev) =>
            {
                string ticketInfo = $"Ticket ID: {selectedTicket.Id}\nFlight: {selectedTicket.Flight.Number}\nClient: {selectedTicket.Client.Name}\nPassport:{selectedTicket.Client.PassportNumber}\nSeat: {selectedTicket.Seat.Row}{(char)('A' + selectedTicket.Seat.Chair)}\nBuy Date: {selectedTicket.BuyDate}\n";

                Font ticketFont = new Font("Arial", 16, FontStyle.Regular);

                int qrCodeSize = 200;

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(ticketInfo, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(10);
                int centerX = (ev.PageBounds.Width - qrCodeSize) / 2;
                int centerY = (ev.PageBounds.Height - qrCodeSize) / 2;

                ev.Graphics.DrawImage(Resources.logoAirCinel2, new Rectangle(centerX - 120, 0, 500, 200));

                ev.Graphics.DrawString(ticketInfo, ticketFont, Brushes.Black, new PointF(centerX - 20, 210));

                ev.Graphics.DrawImage(qrCodeImage, new Rectangle(centerX, centerY, qrCodeSize, qrCodeSize));
            };

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Size = new Size(800, 600)
            };
            printPreviewDialog.ShowDialog();
        }
        else
        {
            MessageBox.Show("Please select a ticket to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonEditTicket_Click(object sender, EventArgs e)
    {
        var ticketToEdit = (Ticket)listBoxTickets.SelectedItem;
        if (ticketToEdit != null)
        {
            var editedTicket = FindTicketById(ticketToEdit.Id);
            if (editedTicket != null)
            {
                var formEditTicket = new FormEditTicket(this, editedTicket, Flights, Clients, Airplanes);
                formEditTicket.Show();
            }
        }
    }

    private Ticket FindTicketById(int id)
    {
        return Tickets.FirstOrDefault(t => t.Id == id);
    }

    private void buttonSaveTicket_Click(object sender, EventArgs e)
    {
        if (comboBoxRows.SelectedItem != null && comboBoxSeats.SelectedItem != null)
        {
            var selectedClient = (Client)listBoxClients.SelectedItem;
            var selectedFlight = (Flight)listBoxAvailableFlights.SelectedItem;
            if (selectedClient != null && selectedFlight != null)
            {
                var selectedRow = (int)comboBoxRows.SelectedItem;
                var selectedChair = comboBoxSeats.SelectedItem.ToString()[0] - 'A';

                // Check if the seat is already occupied
                bool isOccupied = selectedFlight.TicketsBought.Any(t => t.Seat.Row == selectedRow && t.Seat.Chair == selectedChair);
                if (!isOccupied)
                {
                    var newTicket = new Ticket
                    {
                        Id = GetNextTicketId(),
                        Flight = selectedFlight,
                        Client = selectedClient,
                        Seat = new Seat
                        {
                            Row = selectedRow,
                            Chair = selectedChair,
                            Free = false
                        },
                        BuyDate = DateTime.Now
                    };

                    Tickets.Add(newTicket);
                    selectedFlight.TicketsBought.Add(newTicket);

                    MessageBox.Show("Ticket saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Init();
                }
                else
                {
                    MessageBox.Show("Selected seat is already occupied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a client and a flight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Please select a valid seat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonDeleteTicket_Click(object sender, EventArgs e)
    {
        var ticketToDelete = (Ticket)listBoxTickets.SelectedItem;

        if (ticketToDelete != null)
        {
            var deletedTicket = Tickets.FirstOrDefault(t => t.Id == ticketToDelete.Id);

            if (deletedTicket != null)
            {
                DialogResult answer = MessageBox.Show($"Are you sure you want to delete this ticket?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (answer == DialogResult.OK)
                {
                    // Remove the ticket from the list of tickets
                    Tickets.Remove(deletedTicket);

                    // Update the list of flights and mark the seat as free
                    foreach (var flight in Flights)
                    {
                        var ticketInFlight = flight.TicketsBought.FirstOrDefault(t => t.Id == deletedTicket.Id);
                        if (ticketInFlight != null)
                        {
                            flight.TicketsBought.Remove(ticketInFlight);
                            flight.Airplane.Seats[ticketInFlight.Seat.Row - 1, ticketInFlight.Seat.Chair].Free = true;
                            break;
                        }
                    }

                    MessageBox.Show("Ticket deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Init();
                }
            }
            else
            {
                MessageBox.Show("Ticket not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Please select a ticket to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
