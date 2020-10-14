using System;
using System.Collections.Generic;
using System.Text;


namespace ExamCsharp.Model
{
     interface IDepartement
    {
        public Departement CreeDepartement();

        public Departement DemandeDepartement();
        int VerifDepart(int dep);
    }
}
