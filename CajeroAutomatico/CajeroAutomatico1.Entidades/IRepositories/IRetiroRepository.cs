using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico1.Entidades.IRepositories
{
    public interface IRetiroRepository
    {





        IEnumerable<Cuenta> GetDinero(int idCuenta);









    }
}
