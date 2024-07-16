using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusControlApp
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Server=DESKTOP-2RUNKS3;Database=BusControlDB;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            LoadDrivers();
            LoadBuses();
            LoadRoutes();
            LoadAssignments();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Drivers (FirstName, LastName, DateOfBirth, Cedula) VALUES (@FirstName, @LastName, @DateOfBirth, @Cedula)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value);
                    command.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                    command.ExecuteNonQuery();
                }
            }
            LoadDrivers();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Buses (Brand, Model, LicensePlate, Color, Year) VALUES (@Brand, @Model, @LicensePlate, @Color, @Year)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Brand", txtBrand.Text);
                    command.Parameters.AddWithValue("@Model", txtModel.Text);
                    command.Parameters.AddWithValue("@LicensePlate", txtLicensePlate.Text);
                    command.Parameters.AddWithValue("@Color", txtColor.Text);
                    command.Parameters.AddWithValue("@Year", txtYear.Text);
                    command.ExecuteNonQuery();
                }
            }
            LoadBuses();
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Routes (Name) VALUES (@RouteName)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RouteName", txtRouteName.Text);
                    command.ExecuteNonQuery();
                }
            }
            LoadRoutes();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Assignments (DriverId, BusId, RouteId) VALUES (@DriverId, @BusId, @RouteId)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverId", (int)cmbDrivers.SelectedValue);
                    command.Parameters.AddWithValue("@BusId", (int)cmbBuses.SelectedValue);
                    command.Parameters.AddWithValue("@RouteId", (int)cmbRoutes.SelectedValue);
                    command.ExecuteNonQuery();
                }
            }
            LoadAssignments();
        }

        private void LoadDrivers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, FirstName FROM Drivers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewDrivers.DataSource = dt;

                cmbDrivers.DataSource = dt;
                cmbDrivers.DisplayMember = "FirstName";
                cmbDrivers.ValueMember = "Id";
            }
        }

        private void LoadBuses()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Model FROM Buses";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewBuses.DataSource = dt;

                cmbBuses.DataSource = dt;
                cmbBuses.DisplayMember = "Model";
                cmbBuses.ValueMember = "Id";
            }
        }

        private void LoadRoutes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Name FROM Routes";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewRoutes.DataSource = dt;

                cmbRoutes.DataSource = dt;
                cmbRoutes.DisplayMember = "Name";
                cmbRoutes.ValueMember = "Id";
            }
        }

        private void LoadAssignments()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT a.Id, d.FirstName AS Driver, b.Model AS Bus, r.Name AS Route
                    FROM Assignments a
                    JOIN Drivers d ON a.DriverId = d.Id
                    JOIN Buses b ON a.BusId = b.Id
                    JOIN Routes r ON a.RouteId = r.Id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewAssignments.DataSource = dt;
            }
        }
    }
}
