using CajeroAutomatico1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CajeroAutomatico.Persistencia
{
    public class CajeroAutomaticoDBContext:DbContext
    {

        public DbSet< Cuenta > Cuentas { get; set; }
        public DbSet<Retiro> Retiros { get; set; }

    }
}
