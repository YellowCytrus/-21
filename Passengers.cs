using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИТ_Практ._2._1
{
    public partial class Passengers : Form
    {

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;

        public Passengers()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            connection = new SqlConnection("Server=CYTRUS\\SQLEXPRESS;Database=aero;Trusted_Connection=True;");
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            dataGridView1.DataSource = table;
        }

        private void Passengers_Load(object sender, EventArgs e)
        {
            this.passengerTableAdapter.Fill(this.aeroDataSet1.Passenger);
        }

        private void ShowTable(string text)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;

            command.CommandText = text;
            table.Clear();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void passenger_Click(object sender, EventArgs e)
        {
            ShowTable("SELECT name FROM Passenger");
        }

        private void add_Click(object sender, EventArgs e)
        {
            connection.Open();
            command.CommandText = $"INSERT INTO dbo.Passenger VALUES ('{name.Text}');";
            command.ExecuteReader();
            connection.Close();
            ShowTable("SELECT name FROM Passenger");
        }

        private void remove_Click(object sender, EventArgs e)
        {
            connection.Open();
            command.CommandText = "DELETE FROM Passenger WHERE ID_psg >= 35";
            command.ExecuteReader();
            connection.Close();
            ShowTable("SELECT name FROM Passenger");
        }
    }
}
