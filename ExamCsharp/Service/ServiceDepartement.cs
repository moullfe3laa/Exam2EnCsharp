using ExamCsharp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCsharp.Service
{
    class ServiceDepartement:IDepartement
    {
        public DemandeUtilisateur _demandeUtilisateur;
        List<Departement> departement = new List<Departement>();

        public ServiceDepartement(DemandeUtilisateur demandeUtilisateur)
        {
            this._demandeUtilisateur = demandeUtilisateur;
        }
        public Departement CreeDepartement()
        {
            
                Departement d = new Departement();
                d.nom = _demandeUtilisateur.saisieNom("Nom de departement");
                d.numD = _demandeUtilisateur.saisieEntier("Numdeerp departement");
                departement.Add(d);
                return d;
            
        }

        public Departement DemandeDepartement()
        {

            Departement result = null;
            while (result == null)
            {
                string saisieUtilisateur = _demandeUtilisateur.saisieNom("Nom de  departement ?");
                foreach (Departement d in this.departement)
                {
                    if (d.nom == saisieUtilisateur)
                    {
                        Console.WriteLine("Nom departement");
                        Console.WriteLine(d.nom);
                        Console.WriteLine("num departement");
                        Console.WriteLine(d.numD);

                        result = d;
                    }
                }
            }
            return result;
        }
        public int VerifDepart(int dep)
        {
            bool i = true;
            while (i == true)
            {
                foreach (Departement d in departement)
                {
                    if (dep == d.numD)
                    {
                        dep = d.numD;
                        i = false;
                    }
                    else
                        dep = 0;
                }
                if (dep == 0)
                { 
                Console.WriteLine("depar introuvable un autre svvp");
                dep = _demandeUtilisateur.saisieEntier("num dep");
                    i = false;
                }
                
            }return dep;
        }
    }
}
