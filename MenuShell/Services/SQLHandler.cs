using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MenuShell.Entities;

namespace MenuShell.Services
{
    class SQLHandler : ISQLHandler
    {
        private string connectionString = "Data Source = (local); Initial Catalog = MenuShell;Integrated Security = true";  //MenuShell = databasen 

        public void AddUserSQL(User user)
        {

            //Create the SQL Query for inserting a user 
            string queryString = ($"Insert into [User] (FirstName, LastName, [Username], [Password], [Role]) Values('{user.FirstName}', '{user.LastName}', '{user.UserName}', '{user.Password}', '{user.Role}' )");

            //Create and open a connection to SQL Server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Create a Command object
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    int rows = command.ExecuteNonQuery(); //kan returnera antalet påverkade rader
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

        }

        public List<User> LoadUsers()
        {

            List<User> users = new List<User>();


            string queryString = "SELECT * FROM [User]";

            using (var connection = new SqlConnection(connectionString))
            {

                var command = new SqlCommand(queryString, connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read()) //läser en rad i taget och läser så länge det finns ngt att läsa
                {
                    var user = new User(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                    users.Add(user);
                }
                reader.Close();
            }
            return users;
        }

        public void ListUserSQL()
        {


            string queryString = "SELECT * FROM User"; //det kommandot vi vill köra

            using (var connection = new SqlConnection(connectionString)) //skapar upp en connection

            {
                var sqlCommand = new SqlCommand(queryString, connection); //komando som kopplas ihop med vår SqlConnection

                try
                {
                    connection.Open();
                    var reader = sqlCommand.ExecuteReader(); //får ut en reader, så vi kan läsa data

                    while (reader.Read())
                    {

                        for (int i = 0; i < reader.FieldCount; i++) // här räknar den kolumnerna
                        {
                            Console.Write(reader[i] + "\t");
                        }
                        Console.WriteLine("\n");

                    } //läser de raderna som vi har inkl kolumnerna 

                    reader.Close();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }


                Console.ReadLine();
            }


        }

        public int DeleteUserSQL(string userName) //inparameter
        {

            string queryString = ($"DELETE FROM [User] WHERE [UserName] = '{userName}' "); //det kommandot vi vill köra
            int rows = 0;
            //Create and open a connection to SQL Server 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Create a Command object
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    rows = command.ExecuteNonQuery(); //kan returnera antalet påverkade rader

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
            }
            return rows;

        }


        public List<User> SearchUserSQL(string userName)
        {
            var users = new List<User>();

            string queryString = ($"SELECT [UserName] FROM [User] WHERE [UserName] LIKE '%{userName}%' "); //det kommandot vi vill köra

            //Create and open a connection to SQL Server 
            using (var connection = new SqlConnection(connectionString))
            {

                var command = new SqlCommand(queryString, connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read()) //läser en rad i taget och läser så länge det finns ngt att läsa
                {
                    User user = new User();
                    user.UserName = (reader[0].ToString()); //väljer ut enbart username, därför index 0

                    users.Add(user); //lägger till på resultatlistan
                }
                reader.Close();
            }
            return users;
        }

        //private void sqlCall(string query) //hade först som egen metod då kodraderna är ganska så identiska för flera av 
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        //Create a Command object
        //        SqlCommand command = new SqlCommand(query, connection);
        //        try
        //        {
        //            connection.Open();
        //            int rows = command.ExecuteNonQuery(); //kan returnera antalet påverkade rader
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //            throw;
        //        }
        //    }
        //}
    }

}