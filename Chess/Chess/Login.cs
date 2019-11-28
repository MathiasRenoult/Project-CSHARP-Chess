using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Login
    {
        public static bool LoginUser(string mail, string password)
        {
            bool state;
            try
            {
                //init of the connection
                ConnectToDB connDB = new ConnectToDB();
                connDB.OpenConnection();

                //insert a player
                state = connDB.LoginPlayer(mail,password);

                //close connection
                connDB.CloseConnection();

                return state;
            }
            catch (Exception exc)
            {
                //we display the error message.
                Console.WriteLine(exc.Message);
                return false;
            }
            finally
            {
            }
        }

    }
}

