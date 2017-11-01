using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinq
{
    /// <summary>
    /// Autor: Orlando Morales
    /// </summary>
    public class ArrayQuery
    {
        /*
         * Con un array de números enteros int[] array = { 1, 2, 3, 6, 7, 8,9,10,11,12 }   
         * realice una consulta usando Linq que traiga los valores mayores a 2 y escriba los resultados en consola usando lenguaje C#. 
        */

        private static int[] _numbers = {1, 2, 3, 6, 7, 8, 9, 10, 11, 12 };

        public List<int> GreaterValues(int greaterThan)
        {
            return _numbers.Where(n => n > greaterThan).Select(s=> s).ToList(); 
        }

    }
}