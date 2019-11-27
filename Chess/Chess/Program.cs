using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    static class Program
    {
        /*
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        */
        static void Main(string[] args)
        {
            try
            {
                //init of the connection
                ConnectToDB connDB = new ConnectToDB();
                connDB.OpenConnection();

                //insert a player
                connDB.AddPlayer("Toto","toto@blague.ch","totoAuToilettes",0,10);

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
