using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace ADO.NET
{
    class Program
    {
        static DataSet dataSet = new DataSet();
        static SqlDataAdapter internsAdapter;
        static SqlDataAdapter internsPNAdapter;
        static DataTable dataTable1 = new DataTable();
        static DataTable dataTable2 = new DataTable();
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["connectToInternsDB"].ConnectionString;

        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                CreateTableInterns(connection);
                CreateTableInternsPhoneNumbers(connection);

                internsAdapter = CreateSqlDataAdapterInterns(connection);
                internsPNAdapter = CreateSqlDataAdapterInternsPN(connection);
                FillDataSetAndTables();
                Console.ReadKey();

                InsertRow();
                Console.ReadKey();

                UpdateRow();
                Console.ReadKey();

                DeleteRow();
                Console.ReadKey();

                SelectAllFromInterns(connection);
                SelectAllFromInternsPN(connection);
            }
            Console.ReadKey();
        }

        public static SqlDataAdapter CreateSqlDataAdapterInterns(SqlConnection connection)
        {
            SqlDataAdapter internsAdapter = new SqlDataAdapter();
            internsAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // Create the commands for Interns.
            internsAdapter.SelectCommand = new SqlCommand("SELECT * FROM Interns", connection);
            internsAdapter.InsertCommand = new SqlCommand("INSERT INTO Interns (FullName) " +
                "VALUES (@FullName)", connection);
            internsAdapter.UpdateCommand = new SqlCommand("UPDATE Interns SET FullName = @FullName " +
                "WHERE ID = @ID", connection);
            internsAdapter.DeleteCommand = new SqlCommand("DELETE FROM Interns WHERE ID = @ID", connection);

            // Create the parameters for Interns.
            internsAdapter.InsertCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 40, "FullName");
            internsAdapter.UpdateCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 40, "FullName");
            internsAdapter.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 4, "ID").SourceVersion =
                DataRowVersion.Original;
            internsAdapter.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int, 4, "ID").SourceVersion =
                DataRowVersion.Original;

            return internsAdapter;
        }

        public static SqlDataAdapter CreateSqlDataAdapterInternsPN(SqlConnection connection)
        {
            SqlDataAdapter internsPNAdapter = new SqlDataAdapter();
            internsPNAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // Create the commands for InternsPhoneNumbers.
            internsPNAdapter.SelectCommand = new SqlCommand("SELECT * FROM InternsPhoneNumbers", connection);
            internsPNAdapter.InsertCommand = new SqlCommand("INSERT INTO InternsPhoneNumbers (InternID, PhoneNumber) " +
                "VALUES (@InternID , @PhoneNumber)", connection);
            internsPNAdapter.UpdateCommand = new SqlCommand("UPDATE InternsPhoneNumbers SET PhoneNumber = @PhoneNumber " +
                "WHERE InternID = @InternID", connection);
            internsPNAdapter.DeleteCommand = new SqlCommand("DELETE FROM InternsPhoneNumbers WHERE InternID = @InternID", connection);

            // Create the parameters for InternsPhoneNumbers.
            internsPNAdapter.InsertCommand.Parameters.Add("@InternID", SqlDbType.Int, 4, "InternID");
            internsPNAdapter.InsertCommand.Parameters.Add("@PhoneNumber", SqlDbType.BigInt, 15, "PhoneNumber");
            internsPNAdapter.UpdateCommand.Parameters.Add("@PhoneNumber", SqlDbType.BigInt, 15, "PhoneNumber");
            internsPNAdapter.UpdateCommand.Parameters.Add("@InternID", SqlDbType.Int, 4, "InternID").SourceVersion =
                DataRowVersion.Original;
            internsPNAdapter.DeleteCommand.Parameters.Add("@InternID", SqlDbType.Int, 4, "InternID").SourceVersion =
                DataRowVersion.Original;

            return internsPNAdapter;
        }

        static void FillDataSetAndTables()
        {
            internsAdapter.Fill(dataSet, "Interns");
            internsPNAdapter.Fill(dataSet, "InternsPhoneNumbers");

            //DataColumn id = dataTable1.Columns.Add("ID", typeof(Int32));
            //id.AutoIncrement = true;
            //id.AutoIncrementSeed = 2;
            //id.AutoIncrementStep = 3;
            dataTable1 = dataSet.Tables["Interns"];
            Console.WriteLine("\n'Interns' added to DataSet");

            dataTable2 = dataSet.Tables["InternsPhoneNumbers"];
            Console.WriteLine("'InternsPhoneNumbers' added to DataSet");
        }

        static void InsertRow()
        {
            Console.WriteLine("\nInserting rows in the tables...");
            try
            {
                //insert in table1 - Intern data
                DataRow internsRow1 = dataTable1.NewRow();
                internsRow1["FullName"] = "Wannabe First";
                dataTable1.Rows.Add(internsRow1);
                DataRow internsRow2 = dataTable1.NewRow();
                internsRow2["FullName"] = "Wannabe First...";
                dataTable1.Rows.Add(internsRow2);

                dataTable1 = dataSet.Tables["Interns"];
                Console.WriteLine("\nDataTable Interns looks like:\n");
                foreach (DataRow row in dataTable1.Rows)
                {
                    Console.WriteLine(row["ID"].ToString() + "    " + row["FullName"].ToString());
                }
                //Update the DB with changes in table1 above
                internsAdapter.Update(dataSet, "Interns");

                //insert in table2 - Phone data
                DataRow phoneRow1 = dataTable2.NewRow();
                phoneRow1["InternID"] = 2;
                phoneRow1["PhoneNumber"] = "11111111";
                dataTable2.Rows.Add(phoneRow1);
                DataRow phoneRow2 = dataTable2.NewRow();
                phoneRow2["InternID"] = 3;
                phoneRow2["PhoneNumber"] = "22222222";
                dataTable2.Rows.Add(phoneRow2);
                Console.WriteLine("\nDataTable InternsPhoneNumbers looks like:\n");
                foreach (DataRow row in dataTable2.Rows)
                {
                    Console.WriteLine(row["InternID"].ToString() + "    " + row["PhoneNumber"].ToString());
                }
                //Update the DB with changes in table2 above
                internsPNAdapter.Update(dataSet, "InternsPhoneNumbers");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        static void UpdateRow()
        {
            Console.WriteLine("\nUpdating a row in the tables...");
            try
            {
                //update in table1 - Intern data
                //dataTable1.Rows[1]["FullName"] = "Wannabe Second";
                foreach (DataRow row in dataTable1.Rows)
                {
                    if ((int)row["ID"] == 3) row["FullName"] = "Wannabe Second";
                }
                Console.WriteLine("\nUpdated DataTable Interns looks like:\n");
                foreach (DataRow row in dataTable1.Rows)
                {
                    Console.WriteLine(row["ID"].ToString() + "    " + row["FullName"].ToString());
                }
                //Update the DB with changes in table1 above
                internsAdapter.Update(dataSet, "Interns");

                //update in table2 - Phone data
                dataTable2.Rows[2]["PhoneNumber"] = "33333333";

                Console.WriteLine("\nUpdated DataTable InternsPhoneNumbers looks like:\n");
                foreach (DataRow row in dataTable2.Rows)
                {
                    Console.WriteLine(row["InternID"].ToString() + "    " + row["PhoneNumber"].ToString());
                }
                //Update the DB with changes in table2 above
                internsPNAdapter.Update(dataSet, "InternsPhoneNumbers");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        static void DeleteRow()
        {
            Console.WriteLine("\nDeleting a row from the tables...");
            try
            {
                //Detelete a row from table1 - Intern data
                for (int i = dataTable1.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = dataTable1.Rows[i];
                    if ((int)dr["ID"] == 1)
                        dr.Delete();
                }
                dataTable1.AcceptChanges();

                Console.WriteLine("\nDataTable Interns looks like:\n");
                foreach (DataRow row in dataTable1.Rows)
                {
                    Console.WriteLine(row["ID"].ToString() + "    " + row["FullName"].ToString());
                }
                //Update the DB with changes in table1 above
                internsAdapter.Update(dataSet, "Interns");

                ////Detelete a row from table2 - Phone data
                for (int i = dataTable2.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = dataTable2.Rows[i];
                    if ((int)dr["InternID"] == 1)
                        dr.Delete();
                }
                dataTable2.AcceptChanges();
                Console.WriteLine("\nDataTable InternsPhoneNumbers looks like:\n");
                foreach (DataRow row in dataTable2.Rows)
                {
                    Console.WriteLine(row["InternID"].ToString() + "    " + row["PhoneNumber"].ToString());
                }
                //Update the DB with changes in table2 above
                internsPNAdapter.Update(dataSet, "InternsPhoneNumbers");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        static void SelectAllFromInterns(SqlConnection connection)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM Interns";

                Console.WriteLine("\n\nServer 'Interns': \n\nID        FullName");

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string id = dr["ID"].ToString();
                    string fullName = dr["FullName"].ToString();
                    Console.WriteLine(id + "\t  " + fullName);
                }
                dr.Close();
            }
        }

        static void SelectAllFromInternsPN(SqlConnection connection)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM InternsPhoneNumbers";

                Console.WriteLine("\n\nServer 'InternsPHoneNumber': \n\nInternID  PhoneNumber");

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string id = dr["InternID"].ToString();
                    string phoneNumber = dr["PhoneNumber"].ToString();
                    Console.WriteLine(id + "\t  " + phoneNumber);
                }
                dr.Close();
            }
        }

        static void CreateTableInterns(SqlConnection connection)
        {
            var sqlCommandText = "CREATE TABLE Interns(ID int not null   identity(1,1) primary key, FullName NVARCHAR(55));"+
                                 "INSERT INTO Interns(FullName) VALUES ('First Name');";
            using (var sqlCommand = new SqlCommand(sqlCommandText, connection))
            {
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Table 'Interns' was created successfully! Columns: ID, FullName");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        static void CreateTableInternsPhoneNumbers(SqlConnection connection)
        {
            var sqlCommandText = "CREATE TABLE InternsPhoneNumbers(InternID int FOREIGN KEY REFERENCES Interns(ID) primary key, PhoneNumber bigint unique);" +
                                 "INSERT INTO InternsPhoneNumbers(InternID, PhoneNumber) VALUES (1, 61626364);";
            using (var sqlCommand = new SqlCommand(sqlCommandText, connection))
            {
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Table 'InternsPhoneNumbers' was created successfully! Columns: InternID, PhoneNumber");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
