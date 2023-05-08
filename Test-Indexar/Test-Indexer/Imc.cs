using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Indexer
{
    public class Datos
    {
        private int peso;
        private double altura;
        private string? clasificacion;
        private double? imc;

        public int Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public string Clasificacion { get => clasificacion; set => clasificacion = value; }
        public double? Imc { get => imc; set => imc = value; }

        public void CalculoImc(int _Peso, double _Altura, string _Clasificacion ,
            double _Imc)
        {
            Peso = _Peso;
            Altura = _Altura;
            clasificacion = _Clasificacion;
            imc = _Imc;
           
            imc = Peso / (Altura*Altura);
            
            if (imc < 18)
            {

                Clasificacion = "Peso bajo. Necesario valorar signos de desnutrición.";
            }
            else if (imc > 18 && imc <= 24.9)
            {
                Clasificacion = "Normal";

            }
            else if (imc >= 27 && imc <= 29.9)
            {
                Clasificacion = "Obesidad grado I. Riesgo relativo ALTO para desarrolar enfermedades cardiovasculares.";
            }
            else if (imc >= 30 && imc <= 39.9)
            {
                Clasificacion = "Obesidad grado II. Riesgo relativo MUY ALTO para el desarrollo de enfermedades cardiovasculares.";

            }
            else if (imc >= 40)
            {
                Clasificacion = "Obesidad grado III. EXTREMA O MORBIDA. Riesgo relativo EXAGERADAMENTE ALTO para el desarrollo de enfermedades cardiovasculares";
            }


        }
    }

}
