using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Config;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.DAO
{
    public interface IDAO
    {
        Enseignant isExiste(Login log);
        Enseignant findEnseignantByUsername(string username);
        List<Enseignant> getListAllEnseignant();

        string getPasswordByLogin(string login);
        bool changePassword(string login, string newPassword);

        List<Filiere> getListFilieresByEnseignant(Enseignant enseignant);
        Filiere getFiliereByName(string nomFiliere);
        Filiere getFiliereByEtudiant(Etudiant etudiant);

        List<Etudiant> getListEtudiantsByClass(int classe);
        Etudiant findEtudiantByNum(int num);

        List<Matiere> getListMatieresByEnseignantFiliere(Enseignant ens, Filiere f);

        Double getNoteByEtudiantMatiere(Etudiant ee, Matiere m);

        Classe getClasseByNum(int num);

        Matiere findMatiereByName(string nom);

        bool editNoteByEtudiantMatiere(Etudiant etudiant, Matiere matiere, double? newNote);

        /* Admin */
        bool addEnseignant(Enseignant e);
        bool addLogin(Login log);

        bool addMatiere(Matiere matiere);
        List<Matiere> getListAllMatieres();
        List<Filiere> getListAllFilieresByMatiere(int numM);
        List<Filiere> getListAllFilieresByNonMatiere(int numM);
        bool affecterMatiereToFiliere(int numM, int numF);
        bool retirerMatiereFromFiliere(int numM, int numF);
        bool retirerMatiereFromEnseignant(int numM);
        bool affecterMatiereToEnseignant(int numM, int numEns);

        Enseignant getEnseignantByMatiere(int selectedMatiere);
    }
}
