﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCsharp.Model
{
    class Departement
    {
        public string nom;
        public int numD;
        public List<Departement> departements { get; set; }
        public List<Commune> Communes { get; set; }
    }
}
