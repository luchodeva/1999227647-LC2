
using CajeroAutomatico1.Entidades.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistencia.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {

        private readonly CajeroAutomaticoDBContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();


        public ICuentaRepository Cuenta { get; private set; }
        public IRetiroRepository Retiro { get; private set; }


        private UnityOfWork(){

            _Context = new CajeroAutomaticoDBContext();

            Cuenta = new CuentaRepository(_Context);
            Retiro = new RetiroRepository(_Context);

        }


        public static UnityOfWork Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }

                return _Instance;
            }
        }



        public void Dispose()
        {

            _Context.Dispose();
            

        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }
    }
}
