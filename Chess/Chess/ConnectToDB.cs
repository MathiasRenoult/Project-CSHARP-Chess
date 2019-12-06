using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Chess
{
    public class ConnectToDB
    {
        private MySqlConnection connection;

        public ConnectToDB()
        {
            InitConnection();
        }

        /// <summary>
        /// Initialize the connection to the database
        /// </summary>
        private void InitConnection()
        {
            // Creation of the connection string : where, who
            // Avoid user id and pwd hardcoded
            string path = @"./configDB.json";
            string connectionString = " ";
            if (File.Exists(path))
            {
                using (StreamReader file = File.OpenText(@"./configDB.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    DatabaseConfig newPoint = (DatabaseConfig)serializer.Deserialize(file, typeof(DatabaseConfig));
                    connectionString = "SERVER="+newPoint.Server+"; DATABASE="+newPoint.Db+"; UID="+newPoint.Uid+"; PASSWORD="+newPoint.Password+"";
                }
            }
            else
            {
                connectionString = "SERVER=127.0.0.1; DATABASE=chesscsharp; UID=root; PASSWORD=Pa$$w0rd";
            } 
           
             connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Open connection to the database
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Wesh apprend a rentrer des identifiants corrects GLADYS");
            }
            
        }

        /// <summary>
        /// add a player in the table "players"
        /// </summary>
        /// <param name="pseudo"></param>
        public bool AddPlayer(string pseudo, string mail, string password, int victory, int loss)
        {
            password = CryptoPassword.Hash(password);

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT mail, pseudo FROM joueur WHERE mail = '" + mail +"' OR pseudo = '"+ pseudo +"';";

            // use of the pseudo string, parameter of the method AddPlayer
            cmd.Parameters.AddWithValue("@pseudo", pseudo);
            cmd.Parameters.AddWithValue("@mail", mail);

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Already existing player ! Change your email or/and your pseudo.");
                return false;
            }
            reader.Close();

            // Create a SQL command
            cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = "INSERT INTO Joueur (`pseudo`,`mail`,`password`,`nb_victoire`,`nb_defaite`)VALUES(@pseudo, @mail, @password, @nbVictory, @nbLoss);";

            // use of the pseudo string, parameter of the method AddPlayer
            cmd.Parameters.AddWithValue("@pseudo",pseudo);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@nbVictory", victory);
            cmd.Parameters.AddWithValue("@nbLoss", loss);


            // Execute the SQL command
            cmd.ExecuteNonQuery();

            return true;
        }

        /// <summary>
        /// add a player in the table "players"
        /// </summary>
        /// <param name="pseudo"></param>
        public bool LoginPlayer(string mail, string password)
        {
            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT mail FROM joueur WHERE mail LIKE '" + mail + "'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine("User " + mail + " exists.");
                reader.Close();

                cmd.CommandText = "SELECT password FROM joueur;";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    if (CryptoPassword.Verify(password, reader.GetString(0)))
                    {
                        Console.WriteLine("Passwords matches.");
                        Console.WriteLine("Login complete !");
                        reader.Close();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Password doesn't match.");
                        Console.WriteLine("Login failed !");
                    }
                }
                MessageBox.Show("Wrong password !");
                reader.Close();
                return false;
            }
            else
            {
                MessageBox.Show("User " + mail + " doesn't exists.");
                reader.Close();
                return false;
            }

            

           
        }

        /// <summary>
        /// get the name of the player according to his id
        /// </summary>
        /// <param name="id">id of the player</param>
        /// <returns></returns>
        public string GetPlayerName(int id)
        {
            string name = "";

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select pseudo from players where id = " + id;

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    //if a field can be null, we check if the result is not null before getting the value
                    //if (!reader.IsDBNull(2))
                    //{
                    //    telContact = reader.GetString(2);
                    //}

                }
                reader.Close();
                return name;
            }

            return name;
        }


        /// <summary>
        /// Close connection to the database
        /// </summary>
        public void CloseConnection()
        {
            connection.Dispose();
        }

    }
}
