using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SQLiteABM
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            DBController dbController = new DBController();
            dbController.InitializeDataBase();
        }

        private void LoadData(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(DBController.connectionString))
            {
                connection.Open();
                string statementSelect = "SELECT * FROM contacts";
                using (var adapter = new SQLiteDataAdapter(statementSelect, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView.DataSource = table;
                }
            }

            dataGridView.Columns[1].HeaderText = "Nombre";
            dataGridView.Columns[2].HeaderText = "Empleo";
            dataGridView.Columns[3].HeaderText = "Email";
            dataGridView.Columns[0].Visible = false;

        }

        private void ClearTextBoxes()
        {
            txtName.Text = "";
            txtJob.Text = "";
            txtEmail.Text = "";
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string job = txtJob.Text;
            string email = txtEmail.Text;
            if (!IsFormValid()) return;
            using (var connection = new SQLiteConnection(DBController.connectionString))
            {
                connection.Open();
                string statement = $"INSERT INTO contacts (name, job, email) VALUES ('{name}', '{job}', '{email}')";
                SQLiteCommand command = new SQLiteCommand(statement, connection);
                command.ExecuteNonQuery();
            }
            LoadData(sender, e);
            ClearTextBoxes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected()) return;
            int id = Convert.ToInt32(dataGridView[0, dataGridView.SelectedRows[0].Index].Value);
            using (var connection = new SQLiteConnection(DBController.connectionString))
            {
                connection.Open();
                string statement = $"DELETE FROM contacts WHERE id = {id};";
                SQLiteCommand command = new SQLiteCommand(statement, connection);
                command.ExecuteNonQuery();
            }
            LoadData(sender, e);
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string job = txtJob.Text;
            string email = txtEmail.Text;
            if (!IsFormValid()) return;
            if (!IsRowSelected()) return;
            int id = Convert.ToInt32(dataGridView[0, dataGridView.SelectedRows[0].Index].Value);
            using (var connection = new SQLiteConnection(DBController.connectionString))
            {
                connection.Open();
                string statement = $"UPDATE contacts SET name = '{name}', job = '{job}', email = '{email}' WHERE id = {id}";
                SQLiteCommand command = new SQLiteCommand(statement, connection);
                command.ExecuteNonQuery();
            }
            LoadData(sender, e);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            txtName.Text = dataGridView[1, dataGridView.SelectedRows[0].Index].Value.ToString();
            txtJob.Text = dataGridView[2, dataGridView.SelectedRows[0].Index].Value.ToString();
            txtEmail.Text = dataGridView[3, dataGridView.SelectedRows[0].Index].Value.ToString();
        }

        private bool IsFormValid()
        {
            string name = txtName.Text;
            string job = txtJob.Text;
            string email = txtEmail.Text;

            if (name == "" || email == "" || job == "")
            {
                MessageBox.Show("Debe completar los campos obligatorios.");
                return false;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show("El email debe contener un @.");
                return false;
            }
            return true;
        }

        private bool IsRowSelected()
        {
            int id = 0;
            try
            {
                int selectedRow = dataGridView.SelectedRows[0].Index;
                id = Convert.ToInt32(dataGridView[0, dataGridView.SelectedRows[0].Index].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un contacto para modificar.");
                return false;
            }
            return true;
        }
    }
}
