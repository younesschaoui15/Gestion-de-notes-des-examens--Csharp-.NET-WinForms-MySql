using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Config;
using System.Globalization;
using System.IO;
using System.Drawing;
using System.Data;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.DAO
{
    public class DAOImpl : IDAO
    {
        static MySql_Connection mySqlConn;

        
        /** Les fonctions **/

        public Enseignant isExiste(Login log)
        {
            Enseignant enseignant = null;
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();
            string sql = "SELECT COUNT(*) FROM login WHERE login='" + log.login.Replace("'", "''") + "' AND password='" + log.password.Replace("'", "''") + "'";
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            
            try
            {
                if (dataReader.Read())
                {
                    int count = dataReader.GetInt32(0);
                    if (count == 1)
                        enseignant = findEnseignantByUsername(log.login);
                }

                return enseignant;
            }
            finally
            {
                mySqlConn.closeConnection();
            }            
        }
        public Enseignant findEnseignantByUsername(string username)
        {
            Enseignant enseignant = null;
            mySqlConn = new MySql_Connection();
            string sql = "SELECT * FROM enseignant WHERE login='" + username.Replace("'", "''") + "';";
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader.Read())
                {
                    enseignant = new Enseignant();

                    enseignant.num_Ens = dataReader.GetInt32(0);
                    enseignant.nom = dataReader[1].ToString().ToUpper();
                    enseignant.prenom = char.ToUpper(dataReader[2].ToString().First()) + dataReader[2].ToString().Substring(1).ToLower();
                    enseignant.email = dataReader[3].ToString();
                    enseignant.ville = dataReader[4].ToString();
                    enseignant.adresse = dataReader[5].ToString();
                    enseignant.telephone = dataReader[6].ToString();
                    enseignant.CIN = dataReader[7].ToString();
                    enseignant.login = dataReader[8].ToString();
                    enseignant.genre = dataReader.GetBoolean(9);
                    if (dataReader[10] != System.DBNull.Value)
                    {
                        Byte[] bytes = (Byte[])dataReader[10];
                        if (bytes != null && bytes.Length > 0)
                            enseignant.image = Image.FromStream(new MemoryStream(bytes));
                        else
                            enseignant.image = null;
                    }
                    else
                        enseignant.image = null;
                }
                return enseignant;
            }
            finally
            {
                mySqlConn.closeConnection();
            }  
        }
        public List<Enseignant> getListAllEnseignant()
        {
            List<Enseignant> liste = null;
            mySqlConn = new MySql_Connection();
            string sql = "SELECT * FROM enseignant;";
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader != null)
                    liste = new List<Enseignant>();
                while (dataReader.Read())
                {
                    Enseignant enseignant = new Enseignant();

                    enseignant.num_Ens = dataReader.GetInt32(0);
                    enseignant.nom = dataReader[1].ToString().ToUpper();
                    enseignant.prenom = char.ToUpper(dataReader[2].ToString().First()) + dataReader[2].ToString().Substring(1).ToLower();
                    enseignant.email = dataReader[3].ToString();
                    enseignant.ville = dataReader[4].ToString();
                    enseignant.adresse = dataReader[5].ToString();
                    enseignant.telephone = dataReader[6].ToString();
                    enseignant.CIN = dataReader[7].ToString();
                    enseignant.login = dataReader[8].ToString();
                    enseignant.genre = dataReader.GetBoolean(9);
                    if (dataReader[10] != System.DBNull.Value)
                    {
                        Byte[] bytes = (Byte[])dataReader[10];
                        if (bytes != null && bytes.Length > 0)
                            enseignant.image = Image.FromStream(new MemoryStream(bytes));
                        else
                            enseignant.image = null;
                    }
                    else
                        enseignant.image = null;

                    liste.Add(enseignant);
                }
                
            }
            finally
            {
                mySqlConn.closeConnection();
            }

            return liste;
        }

        public string getPasswordByLogin(string login)
        {
            string password = null;
            mySqlConn = new MySql_Connection();
            string sql = "SELECT password FROM Login WHERE login='" + login.Replace("'", "''") + "';";
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader.Read())
                {
                    password = dataReader[0].ToString();
                }
                return password;
            }
            finally
            {
                mySqlConn.closeConnection();
            } 
        }
        public bool changePassword(string login, string newPassword)
        {
            mySqlConn = new MySql_Connection();
            string sql = "UPDATE Login SET password = '"+newPassword+"' WHERE login='" + login + "';";
            mySqlConn.openConnection();
            int count = mySqlConn.executeCommande(sql);
            mySqlConn.closeConnection();
            if (count > 0)
                return true;
            else
                return false;
        }

        public List<Filiere> getListFilieresByEnseignant(Enseignant enseignant)
        {
            List<Filiere> listeFilieres = null;
            mySqlConn = new MySql_Connection();
            string sql = "SELECT distinct filiere.* FROM filiere,filiere_matiere,matiere,enseignant,login " +
                          "WHERE filiere.numF=filiere_matiere.numF "+
                          "AND filiere_matiere.numM=matiere.numM "+
                          "AND matiere.num_Ens=enseignant.num_Ens "+
                          "AND enseignant.login=login.login "+
                          "AND login.login='"+enseignant.login+"' "+
                          "AND login.password='"+getPasswordByLogin(enseignant.login)+"';";
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader != null)
                    listeFilieres = new List<Filiere>();
                while (dataReader.Read())
                {
                    Filiere  f = new Filiere();

                    f.numF = dataReader.GetInt32(0);
                    f.nomF = dataReader.GetString(1);
                    f.nbrMatiere = dataReader.GetInt32(2);
                    f.numC = dataReader.GetInt32(3);

                    listeFilieres.Add(f);
                }
                return listeFilieres;
            }
            finally
            {
                mySqlConn.closeConnection();
            } 
        }
        public Filiere getFiliereByName(string nomFiliere)
        {
            Filiere filiere = null;
            mySqlConn = new MySql_Connection();
            string sql = "SELECT * FROM Filiere WHERE nomF='" + nomFiliere.Replace("'", "''") + "';";
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {   
                if (dataReader.Read())
                {
                    filiere = new Filiere();
                    filiere.numF = dataReader.GetInt32(0);
                    filiere.nomF = dataReader.GetString(1);
                    filiere.nbrMatiere = dataReader.GetInt32(2);
                    filiere.numC = dataReader.GetInt32(3);
                }
                return filiere;
            }
            finally
            {
                mySqlConn.closeConnection();
            }
        }
        public Filiere getFiliereByEtudiant(Etudiant etudiant)
        {
            Filiere filiere = null;
            mySqlConn = new MySql_Connection();
            string sql = "SELECT distinct f.* FROM Filiere f,Etudiant e WHERE f.numC=" + etudiant.numC + " AND e.numC=" + etudiant.numC + ";";
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader.Read())
                {
                    filiere = new Filiere();
                    filiere.numF = dataReader.GetInt32(0);
                    filiere.nomF = dataReader.GetString(1);
                    filiere.nbrMatiere = dataReader.GetInt32(2);
                    filiere.numC = dataReader.GetInt32(3);
                }
                return filiere;
            }
            finally
            {
                mySqlConn.closeConnection();
            }
        }

        public List<Etudiant> getListEtudiantsByClass(int classe)
        {
            List<Etudiant> listeEtudiants = null;
            mySqlConn = new MySql_Connection();
            string sql = "SELECT e.* FROM etudiant as e WHERE e.numC = "+classe+";";
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader != null)
                    listeEtudiants = new List<Etudiant>();
                while (dataReader.Read())
                {
                    Etudiant e = new Etudiant();

                    e.num_Etud = dataReader.GetInt32(0);
                    e.nom = dataReader[1].ToString().ToUpper();
                    e.prenom = char.ToUpper(dataReader[2].ToString().First()) + dataReader[2].ToString().Substring(1).ToLower();
                    e.ville = dataReader[3].ToString();
                    e.adresse = dataReader[4].ToString();
                    e.telephone = dataReader[5].ToString();
                    e.date_naissance = dataReader[6].ToString().Substring(0, 10);
                    e.CIN = dataReader[7].ToString();
                    e.CNE = dataReader.GetInt32(8);

                    Byte[] bytes = (Byte[])dataReader[9];
                    if (bytes != null && bytes.Length > 0)
                        e.image = Image.FromStream(new MemoryStream(bytes));
                    else
                        e.image = null;

                    e.numC = dataReader.GetInt32(10);
                    e.genre = dataReader.GetBoolean(11);

                    listeEtudiants.Add(e);
                }
                return listeEtudiants;
            }
            finally
            {
                mySqlConn.closeConnection();
            } 
        }
        public Etudiant findEtudiantByNum(int num)
        {
            Etudiant e = null;
            mySqlConn = new MySql_Connection();
            string sql = "SELECT * FROM etudiant WHERE num_etud = " + num + ";";
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader.Read())
                {
                    e = new Etudiant();

                    e.num_Etud = dataReader.GetInt32(0);
                    e.nom = dataReader[1].ToString().ToUpper();
                    e.prenom = char.ToUpper(dataReader[2].ToString().First()) + dataReader[2].ToString().Substring(1).ToLower();
                    e.ville = dataReader[3].ToString();
                    e.adresse = dataReader[4].ToString();
                    e.telephone = dataReader[5].ToString();
                    e.date_naissance = dataReader[6].ToString().Substring(0, 10);
                    e.CIN = dataReader[7].ToString();
                    e.CNE = dataReader.GetInt32(8);

                    Byte[] bytes = (Byte[])dataReader[9];
                    if (bytes != null && bytes.Length > 0)
                        e.image = Image.FromStream(new MemoryStream(bytes));
                    else
                        e.image = null;

                    e.numC = dataReader.GetInt32(10);
                    e.genre = dataReader.GetBoolean(11);
                }
                return e;
            }
            finally
            {
                mySqlConn.closeConnection();
            }
        }

        public List<Matiere> getListMatieresByEnseignantFiliere(Enseignant ens, Filiere f)
        {
            List<Matiere> listeMatieres = null;
            mySqlConn = new MySql_Connection();
            string sql = "SELECT distinct m.* FROM filiere_matiere fm, filiere f, enseignant e, matiere m "+
                         "WHERE m.num_ens=e.num_ens and m.numM=fm.numM and e.num_ens="+ens.num_Ens+" and fm.numF="+f.numF+" ;";
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader != null)
                    listeMatieres = new List<Matiere>();
                while (dataReader.Read())
                {
                    Matiere m = new Matiere();

                    m.numM = dataReader.GetInt32(0);
                    m.nomM = dataReader.GetString(1);
                    m.nbrheures = dataReader.GetInt32(2);
                    try { m.num_Ens = dataReader.GetInt32(3); }
                    catch (Exception ex) { }
                    if (dataReader[4] != System.DBNull.Value)
                    {
                        Byte[] bytes = (Byte[])dataReader[4];
                        if (bytes != null && bytes.Length > 0)
                            m.image = Image.FromStream(new MemoryStream(bytes));
                        else
                            m.image = null;
                    }
                    else
                        m.image = null;

                    listeMatieres.Add(m);
                }
                return listeMatieres;
            }
            finally
            {
                mySqlConn.closeConnection();
            }
        }

        public Double getNoteByEtudiantMatiere(Etudiant ee, Matiere m)
        {
            
            double note = -1;
            mySqlConn = new MySql_Connection();
            string sql = "SELECT note FROM note WHERE num_Etud ="+ee.num_Etud+" and numM="+m.numM+";";
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader.Read())
                {
                    note = dataReader.GetDouble(0);
                }
                return note;
            }
            finally
            {
                mySqlConn.closeConnection();
            } 
        }

        public Classe getClasseByNum(int num)
        {
            Classe classe = null;
            mySqlConn = new MySql_Connection();
            string sql = "SELECT * FROM classe WHERE numC=" + num + ";";
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader.Read())
                {
                    classe = new Classe();

                    classe.numC = dataReader.GetInt32(0);
                    classe.nomC = dataReader.GetString(1);
                    classe.nbrEtudianrs = dataReader.GetInt32(2);
                    classe.numSalle = dataReader.GetString(3);
                    classe.numF = dataReader.GetInt32(4);
                }
                return classe;
            }
            finally
            {
                mySqlConn.closeConnection();
            }
        }

        public Matiere findMatiereByName(string nom)
        {
            Matiere matiere = null;
            mySqlConn = new MySql_Connection();
            string sql = "SELECT * FROM matiere WHERE nomM ='" + nom.Replace("'", "''") + "';";
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader.Read())
                {
                    matiere = new Matiere();

                    matiere.numM = dataReader.GetInt32(0);
                    matiere.nomM = dataReader.GetString(1);
                    matiere.nbrheures = dataReader.GetInt32(2);
                    try { matiere.num_Ens = dataReader.GetInt32(3); }
                    catch (Exception ex) { }
                    if (dataReader[4] != System.DBNull.Value)
                    {
                        Byte[] bytes = (Byte[])dataReader[4];
                        if (bytes != null && bytes.Length > 0)
                            matiere.image = Image.FromStream(new MemoryStream(bytes));
                        else
                            matiere.image = null;
                    }
                    else
                        matiere.image = null;
                }
                return matiere;
            }
            finally
            {
                mySqlConn.closeConnection();
            }
        }

        public bool editNoteByEtudiantMatiere(Etudiant etudiant, Matiere matiere, double? newNote)
        {
            int count = 0;
            string note = newNote.ToString().Replace(',', '.');
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();

            try
            {
                string sql = "SELECT note FROM note WHERE numM =" + matiere.numM + " AND num_Etud=" + etudiant.num_Etud + " ;";
                MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
                if (dataReader.Read())
                {
                    dataReader.Close();
                    if(newNote==null)
                        sql = "DELETE FROM note WHERE num_Etud=" + etudiant.num_Etud + " AND numM=" + matiere.numM + ";";
                    else
                        sql = "UPDATE note SET note= " + note + " WHERE num_Etud=" + etudiant.num_Etud + " AND numM=" + matiere.numM + ";";
                    
                    count = mySqlConn.executeCommande(sql);
                }
                else
                {
                    dataReader.Close();
                    sql = "INSERT INTO note VALUES (" + matiere.numM + ", " + note + ", " + etudiant.num_Etud + ");";
                    count = mySqlConn.executeCommande(sql);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Commande n'est pas passé.\n"
                                   , "Commande"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConn.closeConnection();
            }

            if (count > 0)
                return true;
            else
                return false;
        }
    
        
        /* Admin */
        public bool addEnseignant(Enseignant e)
        {
            mySqlConn = new MySql_Connection();
            int count = 0;

            string sql = "INSERT INTO enseignant VALUES (NULL, '" + e.nom + "', '" + e.prenom + "', '" + e.email + "', '"
                          + e.ville + "', '" + e.adresse + "', '" + e.telephone + "', '" + e.CIN + "', '" + e.login + "'," + e.genre + " , @image);";
            
            mySqlConn.openConnection();
            try
            {
                MySqlCommand commande = new MySqlCommand(sql, mySqlConn.mySqlConn);

                if (e.image != null)
                    commande.Parameters.AddWithValue("@image", File.ReadAllBytes(e.image.Tag.ToString()));
                else
                    commande.Parameters.AddWithValue("@image", null);

                count = commande.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Commande n'est pas passé.\n\nMessage: " + ex.Message
                                   , "Commande"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
            }

            mySqlConn.closeConnection();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool addLogin(Login log)
        {
            int count = 0;
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();

            string sql = "SELECT * FROM Login WHERE login ='" + log.login + "';";
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            if (!dataReader.Read())
            {
                dataReader.Close();
                sql = "INSERT INTO Login VALUES ('" + log.login + "', '" + log.password + "');";
                count = mySqlConn.executeCommande(sql);
            }

            mySqlConn.closeConnection();
            
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool addMatiere(Matiere matiere)
        {
            int count = 0;
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();

            string sql = "SELECT numM FROM matiere WHERE nomM ='" + matiere.nomM + "';";
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            if (!dataReader.Read())
            {
                dataReader.Close();
                if(matiere.num_Ens>0)
                    sql = "INSERT INTO matiere VALUES (NULL, '" + matiere.nomM + "', " + matiere.nbrheures + ", " + matiere.num_Ens + ", @image);";
                else
                    sql = "INSERT INTO matiere VALUES (NULL, '" + matiere.nomM + "', " + matiere.nbrheures + ", NULL, @image);";
                try
                {   
                    MySqlCommand commande = new MySqlCommand(sql, mySqlConn.mySqlConn);
                    
                    if (matiere.image!=null)
                        commande.Parameters.AddWithValue("@image", File.ReadAllBytes(matiere.image.Tag.ToString()));
                    else
                        commande.Parameters.AddWithValue("@image", null);

                    count = commande.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Création de la matière n'est pas passé.\n\nMessage d'erreur: " + ex.Message
                                       , "Erreur"
                                       , MessageBoxButtons.OK
                                       , MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Création de la matière n'est pas passé.\n\n"+
                                "Cette matière existe dèjà !\n\n"
                                       , "ATTENTION"
                                       , MessageBoxButtons.OK
                                       , MessageBoxIcon.Hand);
            }

            mySqlConn.closeConnection();

            if (count > 0)
                return true;
            else
                return false;
        }
        public List<Matiere> getListAllMatieres()
        {
            List<Matiere> listMat = null;
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();
            string req = "Select * from matiere;";
            MySqlDataReader reader = mySqlConn.selectCommande(req);
            if (reader != null)
                listMat = new List<Matiere>();
            while (reader.Read())
            {
                Matiere mat = new Matiere();
                mat.numM = reader.GetInt32(0);
                mat.nomM = reader[1].ToString();
                mat.nbrheures = reader.GetInt32(2);
                try { mat.num_Ens = reader.GetInt32(3); }
                catch (Exception ex) { }
                if (reader[4] != System.DBNull.Value)
                {
                    Byte[] bytes = (Byte[])reader[4];
                    if (bytes != null && bytes.Length > 0)
                        mat.image = Image.FromStream(new MemoryStream(bytes));
                    else
                        mat.image = null;
                }
                else
                    mat.image = null;

                listMat.Add(mat);
            }
            mySqlConn.closeConnection();

            return listMat;
        }
        public List<Filiere> getListAllFilieresByMatiere(int numM)
        {
            List<Filiere> listFil = null;
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();
            string req = "Select distinct f.* from filiere f, filiere_matiere fm, matiere m where f.numF=fm.numF and m.numM=fm.numM and m.numM = "+numM+";";
            MySqlDataReader reader = mySqlConn.selectCommande(req);
            if (reader != null)
                listFil = new List<Filiere>();
            while (reader.Read())
            {
                Filiere fil = new Filiere();
                fil.numF = reader.GetInt32(0);
                fil.nomF = reader.GetString(1);
                fil.nbrMatiere = reader.GetInt32(2);
                fil.numC = reader.GetInt32(3);

                listFil.Add(fil);
            }
            mySqlConn.closeConnection();

            return listFil;
        }
        public List<Filiere> getListAllFilieresByNonMatiere(int numM)
        {
            List<Filiere> listFil = null;
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();
            string req = "SELECT DISTINCT * FROM filiere WHERE numF NOT IN (SELECT DISTINCT f.numF " +
                        "FROM filiere f, filiere_matiere fm, matiere m WHERE f.numF = fm.numF AND m.numM = fm.numM " +
                        "AND m.numM ="+numM+");";
            MySqlDataReader reader = mySqlConn.selectCommande(req);
            if (reader != null)
                listFil = new List<Filiere>();
            while (reader.Read())
            {
                Filiere fil = new Filiere();
                fil.numF = reader.GetInt32(0);
                fil.nomF = reader.GetString(1);
                fil.nbrMatiere = reader.GetInt32(2);
                fil.numC = reader.GetInt32(3);

                listFil.Add(fil);
            }
            mySqlConn.closeConnection();

            return listFil;
        }

        public bool affecterMatiereToFiliere(int numM, int numF)
        {
            int count = 0;
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();

            string sql = "INSERT INTO filiere_matiere VALUES (NULL, " + numM + ", " + numF + ");";
            count = mySqlConn.executeCommande(sql);

            mySqlConn.closeConnection();

            if (count > 0)
                return true;
            else
                return false;
        }
        public bool retirerMatiereFromFiliere(int numM, int numF)
        {
            int count = 0;
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();

            string sql = "DELETE FROM filiere_matiere WHERE numM= " + numM + " AND numF= " + numF + ";";
            count = mySqlConn.executeCommande(sql);

            mySqlConn.closeConnection();

            if (count > 0)
                return true;
            else
                return false;
        }

        public Enseignant getEnseignantByMatiere(int selectedMatiere)
        {
            Enseignant enseignant = null;
            mySqlConn = new MySql_Connection();
            string sql = "select num_ens from matiere where numM =" + selectedMatiere + ";";
            
            mySqlConn.openConnection();
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader.Read())
                {
                    try
                    {
                        int num = dataReader.GetInt32(0);
                        dataReader.Close();

                        sql = "SELECT * FROM enseignant WHERE num_ens=" + num + ";";
                        dataReader = mySqlConn.selectCommande(sql);

                        if (dataReader.Read())
                        {
                            enseignant = new Enseignant();

                            enseignant.num_Ens = dataReader.GetInt32(0);
                            enseignant.nom = dataReader[1].ToString().ToUpper();
                            enseignant.prenom = char.ToUpper(dataReader[2].ToString().First()) + dataReader[2].ToString().Substring(1).ToLower();
                            enseignant.email = dataReader[3].ToString();
                            enseignant.ville = dataReader[4].ToString();
                            enseignant.adresse = dataReader[5].ToString();
                            enseignant.telephone = dataReader[6].ToString();
                            enseignant.CIN = dataReader[7].ToString();
                            enseignant.login = dataReader[8].ToString();
                            enseignant.genre = dataReader.GetBoolean(9);
                            Byte[] bytes = (Byte[])dataReader[10];
                            if (bytes != null && bytes.Length > 0)
                                enseignant.image = Image.FromStream(new MemoryStream(bytes));
                            else
                                enseignant.image = null;
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            finally
            {
                mySqlConn.closeConnection();
            }

            return enseignant;
        }

        public bool retirerMatiereFromEnseignant(int numM)
        {
            int count = 0;
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();

            string sql = "Update matiere set num_ens=NULL WHERE numM= " + numM + ";";
            count = mySqlConn.executeCommande(sql);

            mySqlConn.closeConnection();

            if (count > 0)
                return true;
            else
                return false;
        }
        public bool affecterMatiereToEnseignant(int numM, int numEns)
        {
            int count = 0;
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();

            string sql = "Update matiere set num_ens="+numEns+" WHERE numM= " + numM + ";";
            count = mySqlConn.executeCommande(sql);

            mySqlConn.closeConnection();

            if (count > 0)
                return true;
            else
                return false;
        }
    }

}
