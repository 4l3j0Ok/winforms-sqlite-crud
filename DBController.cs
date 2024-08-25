using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteABM
{
    internal class DBController
    {
        public static string connectionString = "Data Source=contacts.db;Version=3;";

        public void InitializeDataBase()
        {
            bool dbExists = File.Exists("contacts.db");
            if (!dbExists)
            {
                SQLiteConnection.CreateFile("contacts.db");
                CreateTable();
            }
            InsertDefaultValues(dbExists);
        }

        private void CreateTable()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                const string statementCreate = @"
                CREATE TABLE IF NOT EXISTS contacts (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL,
                    job TEXT,
                    email TEXT NOT NULL
                )";
                SQLiteCommand command = new SQLiteCommand(statementCreate, connection);
                command.ExecuteNonQuery();
            }
        }

        public void InsertDefaultValues(bool dbExists)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string statementSelect = "SELECT * FROM contacts";

                using (var selectCommand = new SQLiteCommand(statementSelect, connection))
                {
                    if (selectCommand.ExecuteScalar() == null && !dbExists)
                    {
                        string statementInsert = @"
                        INSERT INTO contacts (name, job, email) VALUES
                        ('Alejo', 'DevOps', 'contacto@alejoide.com'),
                        ('Eliana', 'Desarrolladora', 'eliana@alejoide.com')
                        ";
                        SQLiteCommand insertcommand = new SQLiteCommand(statementInsert, connection);
                        insertcommand.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
