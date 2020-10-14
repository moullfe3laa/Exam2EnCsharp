using ExamCsharp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCsharp.Service
{
    class ServiceCommune:Icommune
    {
        private List<Commune> Communes = new List<Commune>();
         private  List<Departement> departement = new List<Departement>();
        private DemandeUtilisateur _demandeUtilisateur;
        private ServiceDepartement _serviceDepartement;

        public ServiceCommune(DemandeUtilisateur demandeUtilisateur, ServiceDepartement serviceDepartement)
        {
            this._demandeUtilisateur = demandeUtilisateur;
            this._serviceDepartement = serviceDepartement;

        }
        public Commune CreeCommune()
        {
            Commune result = new Commune();

            result.Nom = _demandeUtilisateur.saisieNom("Nom de la commune :");
            result.CodePost = _demandeUtilisateur.saisieEntier(" Code postal :");
            result.NbHab = _demandeUtilisateur.saisieEntier("nombre d'habitants :");
            result.numdepart = _demandeUtilisateur.saisieEntier("Num de departement");
            result.numdepart = _serviceDepartement.VerifDepart(result.numdepart);
            Communes.Add(result);
            return result;
        }

        public void AfficheCommune()
        {

            foreach (Commune c in Communes)
            {
                Console.WriteLine("Nom commune");
                Console.WriteLine(c.Nom);
                Console.WriteLine("code postale");
                Console.WriteLine(c.CodePost);
                Console.WriteLine("nbr habitant");
                Console.WriteLine(c.NbHab);
                foreach (Departement d in departement)
                {
                    if (c.numdepart==d.numD)
                    {
                        Console.WriteLine("Nom Depart");
                        Console.WriteLine(d.nom);
                        Console.WriteLine("num depart");
                        Console.WriteLine(d.numD);
                    }
                }
                Console.WriteLine("**************");
            }

        }
     
    }
}

