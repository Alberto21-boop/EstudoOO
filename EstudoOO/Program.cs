using EstudoOO;


Carro carro = new Carro{Motorista = 3 };
Carro carro2 = new Carro{Motorista = 21 };

Console.WriteLine("motorista1 " + carro.Motorista);
Console.WriteLine("motorista2 " + carro2.Motorista);

Console.WriteLine();

Console.WriteLine("motorista1 " + carro2.Motorista);
Console.WriteLine("Motorista2 " + carro.Motorista);