using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class CreatingUser
    {
        static void NewUser(string[] args)
        {
            try
            {
                //init of the connection
                ConnectToDB connDB = new ConnectToDB();
                connDB.OpenConnection();

                //insert a player
                connDB.AddPlayer("Toto", "toto@blague.ch", "totoAuToilettes", 0, 10);

                //get a specific player
                string name = connDB.GetPlayerName(1);

                Console.WriteLine("nom : " + name);

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

