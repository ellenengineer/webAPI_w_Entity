﻿using System;
using System.Collections.Generic;

namespace Aula12.Models
{
    public partial class TipoEnd
    {
        public TipoEnd()
        {
            Endereco = new HashSet<Endereco>();
        }

        public int CodTipoEnd { get; set; }
        public string NomeTipoEnd { get; set; }

        public virtual ICollection<Endereco> Endereco { get; set; }
    }
}
