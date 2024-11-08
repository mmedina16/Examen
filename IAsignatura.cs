using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface IAsignatura
    {
        public double CalcularNotaFinal();

        public double CalcularNotaFinal(double N1, double N2, double N3);

        public string MensajeNotaFinal(double NotaFinal);

        public void Imprimir();

    }

}
