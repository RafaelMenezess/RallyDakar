﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RallyDakar.API.Modelo
{
    public class PilotoModelo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int EquipeId { get; set; }

        public string NomeCompleto
        {
            get { return $"{Nome} {SobreNome}"; }
        }

    }
}