using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniLojaVirtual.Commom.Model
{
    public class Vendedor
    {
        [Key]
        public string? Id { get; set; }
        public string? Nome { get; set; }

    }
}
