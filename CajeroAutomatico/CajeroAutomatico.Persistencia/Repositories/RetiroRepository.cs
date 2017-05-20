using CajeroAutomatico1.Entidades.IRepositories;
using CajeroAutomatico1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistencia.Repositories
{
    class RetiroRepository : Repository<Retiro>, IRetiroRepository
    {

        private readonly CajeroAutomaticoDBContext _Context;

        private RetiroRepository()
        {


        }

        public RetiroRepository(CajeroAutomaticoDBContext context)
        {

            _Context = context;
        }

        public IEnumerable<Cuenta> GetDinero(int idCuenta)
        {
            throw new NotImplementedException();
        }
    }
}
