using FinalProjectOOP;
using FinalProjectOOP.Classes;
using FinalProjectPOO.Helpers;

namespace FinalProjectPOO.Forms;

public partial class FormEditTicket : Form
{
    private FormCRUDTickets _mainForm;
    private Ticket _ticketToEdit;
    private List<Flight> _flights;
    private List<Client> _clients;
    private List<Airplane> _airplanes;

    public FormEditTicket(FormCRUDTickets form, Ticket ticket, List<Flight> flights, List<Client> clients, List<Airplane> airplanes)
    {
        _mainForm = form;
        _ticketToEdit = ticket;
        this._flights = flights;
        this._clients = clients;
        this._airplanes = airplanes;
        InitializeComponent();
        Init();
    }

    public void Init()
    {
        listBoxFlights.DataSource = null;
        listBoxFlights.DataSource = _flights;
        listBoxFlights.SelectedItem = _flights.FirstOrDefault(f => f.Number == _ticketToEdit.Flight.Number);

        listBoxClients.DataSource = null;
        listBoxClients.DataSource = _clients;
        listBoxClients.DisplayMember = "Name";
        listBoxClients.SelectedItem = _clients.FirstOrDefault(c => c.Id == _ticketToEdit.Client.Id);

        FillSeatComboBoxes(_ticketToEdit.Flight.Airplane);
        comboBoxRows.SelectedItem = _ticketToEdit.Seat.Row;
        comboBoxSeats.SelectedItem = (char)('A' + _ticketToEdit.Seat.Chair);

        // Use the helper class to display seats
        SeatDisplayHelper.DisplaySeats(_ticketToEdit.Flight.Airplane, _ticketToEdit.Flight.TicketsBought, panelSeats);

        // Initialize the filter combo boxes
        comboBoxFilterOrigin.DataSource = null;
        comboBoxFilterOrigin.DataSource = _flights.Select(f => f.Origin.Country).Distinct().ToList();
        comboBoxFilterOrigin.SelectedIndex = -1;

        comboBoxFilterDestiny.DataSource = null;
        comboBoxFilterDestiny.DataSource = _flights.Select(f => f.Destiny.Country).Distinct().ToList();
        comboBoxFilterDestiny.SelectedIndex = -1;

        comboBoxFilterAirplane.DataSource = null;
        comboBoxFilterAirplane.DataSource = _airplanes.Select(a => a.Model).Distinct().ToList();
        comboBoxFilterAirplane.SelectedIndex = -1;

        comboBoxFilterDeparture.DataSource = null;
        comboBoxFilterDeparture.DataSource = _flights.Select(f => f.DepartureTime.Date).Distinct().ToList();
        comboBoxFilterDeparture.SelectedIndex = -1;

        comboBoxFilterArrival.DataSource = null;
        comboBoxFilterArrival.DataSource = _flights.Select(f => f.ArrivalTime.Date).Distinct().ToList();
        comboBoxFilterArrival.SelectedIndex = -1;
    }

    private void buttonCancel_Click_1(object sender, EventArgs e)
    {
        this.Close();
    }

    private void buttonSaveTicket_Click(object sender, EventArgs e)
    {
        var selectedFlight = (Flight)listBoxFlights.SelectedItem;
        var selectedClient = (Client)listBoxClients.SelectedItem;

        if (selectedFlight != null && selectedClient != null && comboBoxRows.SelectedItem != null && comboBoxSeats.SelectedItem != null)
        {
            var selectedRow = (int)comboBoxRows.SelectedItem;
            var selectedChair = comboBoxSeats.SelectedItem.ToString()[0] - 'A';

            // Check if the seat is already occupied in the new flight
            bool isOccupied = selectedFlight.TicketsBought.Any(t => t.Seat.Row == selectedRow && t.Seat.Chair == selectedChair);
            if (!isOccupied)
            {
                // Release the previous seat in the old flight
                var previousFlight = _ticketToEdit.Flight;
                var oldSeat = _ticketToEdit.Seat;

                // Update the old seat in the old flight using LINQ
                var oldFlight = _flights.FirstOrDefault(f => f.Number == previousFlight.Number);
                if (oldFlight != null)
                {
                    var oldTicket = oldFlight.TicketsBought.FirstOrDefault(t => t.Id == _ticketToEdit.Id);
                    if (oldTicket != null)
                    {
                        oldFlight.Airplane.Seats[oldTicket.Seat.Row - 1, oldTicket.Seat.Chair].Free = true;
                        oldFlight.TicketsBought.Remove(oldTicket);
                    }
                }

                // Update the ticket with the new data
                _ticketToEdit.Flight = selectedFlight;
                _ticketToEdit.Client = selectedClient;
                _ticketToEdit.Seat = new Seat
                {
                    Row = selectedRow,
                    Chair = selectedChair,
                    Free = false
                };

                // Mark the new seat as occupied in the new flight
                selectedFlight.Airplane.Seats[selectedRow - 1, selectedChair].Free = false;

                // Add the ticket to the list of bought tickets in the new flight
                selectedFlight.TicketsBought.Add(_ticketToEdit);

                MessageBox.Show("Ticket updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _mainForm.Init();
                Close();
            }
            else
            {
                MessageBox.Show("Selected seat is already occupied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Please fill all the fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void listBoxAvailableFlights_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedFlight = (Flight)listBoxFlights.SelectedItem;
        if (selectedFlight != null)
        {
            FillSeatComboBoxes(selectedFlight.Airplane);
            // Use the helper class to display seats
            SeatDisplayHelper.DisplaySeats(selectedFlight.Airplane, selectedFlight.TicketsBought, panelSeats);
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

    private void buttonApplyFilters_Click_1(object sender, EventArgs e)
    {
        List<Flight> filteredFlights;

        string selectedOrigin = comboBoxFilterOrigin.SelectedItem?.ToString();
        string selectedDestiny = comboBoxFilterDestiny.SelectedItem?.ToString();
        string selectedAirplane = comboBoxFilterAirplane.SelectedItem?.ToString();
        DateTime? selectedDepartureDate = comboBoxFilterDeparture.SelectedItem as DateTime?;
        DateTime? selectedArrivalDate = comboBoxFilterArrival.SelectedItem as DateTime?;

        // Filter flights based on selected criteria
        filteredFlights = _flights.Where(f =>
            (selectedOrigin == null || f.Origin.Country == selectedOrigin) &&
            (selectedDestiny == null || f.Destiny.Country == selectedDestiny) &&
            (selectedAirplane == null || f.Airplane.Model == selectedAirplane) &&
            (!selectedDepartureDate.HasValue || f.DepartureTime.Date == selectedDepartureDate.Value) &&
            (!selectedArrivalDate.HasValue || f.ArrivalTime.Date == selectedArrivalDate.Value)).ToList();

        listBoxFlights.DataSource = null;
        listBoxFlights.DataSource = filteredFlights;
        listBoxFlights.SelectedIndex = -1;
    }

    private void buttonClearFilters_Click_1(object sender, EventArgs e)
    {
        Init();

        comboBoxFilterOrigin.Text = "Origin";
        comboBoxFilterDestiny.Text = "Destiny";
        comboBoxFilterAirplane.Text = "Airplane";
        comboBoxFilterDeparture.Text = "Departure";
        comboBoxFilterArrival.Text = "Arrival";
    }
}
