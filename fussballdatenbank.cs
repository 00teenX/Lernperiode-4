using System.Data;
using System.Data.SqlClient;

namespace Fussballdatenbank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=Fussballdatenbank;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public class DatabaseHelper
        {
            private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\valen\OneDrive\Bilder\Dokumente\Fussballdatenbank.mdf;Integrated Security=True;Connect Timeout=30";

            public object ExecuteQuery(string query)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    return dataTable;
                } 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Bitte wählen Sie einen Spieler aus.");
                return;
            }

            string selectedPlayer = comboBox1.SelectedItem.ToString();

            string query = $"SELECT Tore FROM Spieler WHERE Name = '{selectedPlayer}'";

            DatabaseHelper dbHelper = new DatabaseHelper();

            DataTable data = (DataTable)dbHelper.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                string message = $"{selectedPlayer} hat {data.Rows[0]["Tore"]} Tore erzielt.";
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Keine Daten gefunden für den gewählten Spieler.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
