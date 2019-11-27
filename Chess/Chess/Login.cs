using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Login
    {
        public static void LoginUser(string mail, string password)
        {
            try
            {
                //init of the connection
                ConnectToDB connDB = new ConnectToDB();
                connDB.OpenConnection();

                //insert a player
                connDB.LoginPlayer(mail,password);

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

