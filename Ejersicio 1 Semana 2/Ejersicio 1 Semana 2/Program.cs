
using Ejersicio_1_Semana_2.Modelos;

List<Carro> Carros = new List<Carro>();

Carro C1 = new Carro()
{

    placa = "HAG603",
    color = "Rojo",
    marca = "BMW",
    anioProduccion = 1991,
    kms = 0

};

Carros.Add(C1);

foreach (Carro x in Carros)
{
    Console.WriteLine(x.toString());
}

