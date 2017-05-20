using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico1.Entidades
{
    public class Cuenta
    {
        [Key]
        public int cuentaId  { get; set; }

        public int numeroCuenta { get; set; }

        public int pin { get; set; }

        public decimal saldoDisponible { get; set; }

        public Cuenta() {

            cuentaId = 198753215;

            numeroCuenta = 195292863;

            pin = 1234;

            saldoDisponible = 10000;

        }
       



    }
}
