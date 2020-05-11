﻿using System;
using System.Collections.Generic;

namespace Aula12.Models
{
    public partial class TipoCli
    {
        public TipoCli()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int CodTipoCli { get; set; }
        public string NomeTipoCli { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
