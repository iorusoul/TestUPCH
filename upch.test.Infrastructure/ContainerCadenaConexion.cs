using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upch.test.Infrastructure
{
    public interface IContainerCadenaConexion
    {
        string ConnString { get;}
    }

    public class ContainerCadenaConexion : IContainerCadenaConexion
    {
        public string ConnString { get; }
        public ContainerCadenaConexion(string cadena)
        {
            ConnString = cadena;
        }
    }
}
