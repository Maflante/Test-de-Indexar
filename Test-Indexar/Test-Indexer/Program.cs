using Test_Indexer;

//MASAS CORPORAL

Console.WriteLine("Ingrese su peso");
int Peso = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese su Altura");
double Altura = Convert.ToDouble(Console.ReadLine());

Datos CalculoImc = new Datos();

CalculoImc.CalculoImc(Peso, Altura,"",0);

Console.WriteLine("Su Imc es: " + CalculoImc.Imc + " " + CalculoImc.Clasificacion);


