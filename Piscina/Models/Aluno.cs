﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piscina.Models
{
    internal class Aluno
    {
        public int Nif { get; set; }
        public string Name { get; set; }
        public string Imagem { get; set; }

        public Aluno(int nif, string name, string imagem)
        {
            this.Nif = nif;
            this.Name = name;
            Imagem = imagem;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", Nif, Name);
        }
    }
}
