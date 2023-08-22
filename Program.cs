using System;

namespace TripProject;

class Program {
  static void Main(string[] args) {
    Route newRoute = new();
    Costs allCosts = new();
    int option;

    Console.Clear();

    do {
      Console.WriteLine("=== Projeto Viagem ===");
      Console.WriteLine("1 – Novo percurso");
      Console.WriteLine("2 – Listar percurso");
      Console.WriteLine("3 – Calcular custos");
      Console.WriteLine("0 – Sair");

      option = int.Parse(Console.ReadLine()!);
      Console.Clear();

      if(option == 1) {
        Console.WriteLine("Informe a quilometragem percorrida na viagem:");
        double kmTraveleded = Repeat(double.Parse(Console.ReadLine()!), "km");
        
        Console.WriteLine("\nAgora, informe o valor do combustível por litro:");
        double fuelValue = Repeat(double.Parse(Console.ReadLine()!), "combustível");

        Console.WriteLine("\nPor fim, informe o valor do pedágio que foi gasto:");
        double tollValue = Repeat(double.Parse(Console.ReadLine()!), "pedágio");

        newRoute = new Route(kmTraveleded, fuelValue, tollValue);
        Console.Clear();
      } else if (option == 2) {
        if(newRoute.GetKmTraveled() == 0) {
          Console.WriteLine("Você precisa informar os detalhes da viagem\n");
        } else {
          Console.WriteLine($"{newRoute.ListRoute()}\n");
        }
      } else if (option == 3) {
        if(newRoute.GetKmTraveled() == 0) {
          Console.WriteLine("Você precisa informar os detalhes da viagem\n");
        } else {
          Console.WriteLine(allCosts.calculateTrip(newRoute) + "\n");
        }
      } else if (option != 0) {
        Console.WriteLine("Você inseriu um número inválido!\n");
      }
    } while(option != 0);
    Console.Clear();
    Console.WriteLine("Operação finalizada!");
  }

  static double Repeat(double value, string type) {
    while(value == 0) {
      Console.Clear();
      Console.WriteLine($"Insira o valor do {type} diferente de 0:");
      value = double.Parse(Console.ReadLine()!);
    }
    return value;
  }
}
