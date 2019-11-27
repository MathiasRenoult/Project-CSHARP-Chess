using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Register
    {
        public static void CreateUser(string mail, string pseudo, string password)
        {
            try
            {
                //init of the connection
                ConnectToDB connDB = new ConnectToDB();
                connDB.OpenConnection();

                //insert a player
                connDB.AddPlayer(pseudo, mail, password, 0, 0);

                //close connection
                connDB.CloseConnection();
            }
            catch (Exception exc)
            {
                //we display the error message.
                Console.WriteLine(exc.Message);
            }
            finally
            {

            }
        }

    }
}

