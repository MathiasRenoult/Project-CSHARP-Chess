using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess;

namespace ChessUI
{
    public class Register
    {
         public static bool CreateUser(string mail, string pseudo, string password)
        {
            bool state = false;
            try
            {
                //init of the connection
                ConnectToDB connDB = new ConnectToDB();
                connDB.OpenConnection();

                //insert a player
                state =  connDB.AddPlayer(pseudo, mail, password, 0, 0);

                //close connection
                connDB.CloseConnection();

                return state;
            }
            catch (Exception exc)
            {
                //we display the error message.
                Console.WriteLine(exc.Message);
                return state;
            }
            finally
            {

            }
        }

    }
}

