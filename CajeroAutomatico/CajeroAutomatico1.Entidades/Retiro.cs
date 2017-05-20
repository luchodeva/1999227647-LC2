using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico1.Entidades
{
    public class Retiro
    {

        [Key]
        public int retiroId { get; set; }


        public DateTime fechaRetiro    { get; set; }

        public DateTime montoRetiro { get; set; }
        





    }
}
