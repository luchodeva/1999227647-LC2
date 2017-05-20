using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico1.Entidades.IRepositories
{
    public interface ICuentaRepository
    {


        List<Cuenta> GetMovimientos(int idCuenta);



        decimal ObtenerSaldoDisponible(int numeroCuenta);

        decimal ObtenerSaldoTotal(int numeroCuenta);

        void Debitar(int numeroCuenta, decimal monto);


        void Acreditar(int numeroCuenta, decimal monto);



    }
}
