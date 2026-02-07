using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_U2_CSHARPINTERMEDIO_IDLRH
{
    public delegate T OperacionMatematica<T>(T a, T b);

    public class ListNumGenerico<T> where T : struct, IComparable, IConvertible
    {
        private readonly List<T> _numberos = new List<T>();

        public void Add(T number)
        {
            _numberos.Add(number);
        }

        public T Operar(OperacionMatematica<T> operacion)
        {
            if (_numberos.Count < 2)
                throw new InvalidOperationException("Se requieren al menos dos números.");

            T result = _numberos[0];
            for (int i = 1; i < _numberos.Count; i++)
            {
                result = operacion(result, _numberos[i]);
            }
            return result;
        }

        public int Count => _numberos.Count;
    }
}