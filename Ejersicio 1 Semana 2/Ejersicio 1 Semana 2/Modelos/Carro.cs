using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejersicio_1_Semana_2.Modelos
{
    internal class Carro
    {
        public string placa { get; set; }
        public string color { get; set; }

        public string marca { get; set; }
        public int anioProduccion { get; set; }
        public int kms  { get; set; }

        public string toString()
        {

            return $"Placa:  {placa} -  Color: {color} - Marca {marca} - Año de produccion: {anioProduccion} - Kms recorridos {kms}";

        }

        public int hacerViaje(int kms)
        {
            this.kms += kms;

            return kms;
        }
    }
}
