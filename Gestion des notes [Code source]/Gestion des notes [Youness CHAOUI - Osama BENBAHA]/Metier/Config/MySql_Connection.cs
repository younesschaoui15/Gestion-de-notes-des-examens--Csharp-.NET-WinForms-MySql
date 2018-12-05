using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Config
{
    class MySql_Connection
    {
        public MySqlConnection mySqlConn{ get; set;}
       
        /** Paramétres de la base de données **/
        const string server = "localhost";
        const string dataBase = "bd_gestion_notes";
        const string user = "root";
        const string connexionString = "Data Source="+server+";Initial Catalog="+dataBase+";User Id="+user+";";

        
        /** Constructeurs & méthodes **/

        public MySql_Connection()
        {
            try
            {
                mySqlConn = new MySqlConnection(connexionString);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problème de connexion."
                                   , "Connexion"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
            }
        }

        public bool openConnection()
        {
            try
            {
                mySqlConn.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Connexion interrompu."
                                   , "Connexion"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
                return false;
            }
            
        }

        public bool closeConnection()
        {
            try
            {
                mySqlConn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Connexion ne peut être fermée."
                                   , "Connexion"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
                return false;
            }

        }

        public MySqlDataReader selectCommande(String sql)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand(sql, mySqlConn);
                MySqlDataReader dataReader = commande.ExecuteReader();
                return dataReader;
            }
            catch(Exception e)
            {
                MessageBox.Show("Commande n'est pas passé."
                                   , "Commande"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
                return null;
            }            
        }

        public int executeCommande(String sql)
        {
            int count = 0;
            try
            {
                MySqlCommand commande = new MySqlCommand(sql, mySqlConn);
                count = commande.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Commande n'est pas passé.\n"+e.StackTrace+"\n\nMessage: "+e.Message
                                   , "Commande"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
            }

            return count;
        }

    }

}
