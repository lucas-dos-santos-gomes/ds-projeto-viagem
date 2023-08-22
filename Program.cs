using System;
using System.Globalization;

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
        double kmTraveleded = double.Parse(Console.ReadLine()!);
        
        Console.WriteLine("\nAgora, informe o valor do combustível gasto:");
        double fuelValue = double.Parse(Console.ReadLine()!);

        Console.WriteLine("\nPor fim, informe o valor do pedágio que foi gasto:");
        double tollValue = double.Parse(Console.ReadLine()!);

        newRoute = new Route(kmTraveleded, fuelValue, tollValue);
        Console.Clear();
      } else if (option == 2) {
        Console.WriteLine(newRoute.GetKmTraveled() + "\n");
      } else if (option == 3) {
        Console.WriteLine(allCosts.calculateTrip(newRoute) + "\n");
      } else if (option != 0) {
        Console.WriteLine("Você inseriu um número inválido!\n");
      }
    } while(option != 0);
    Console.Clear();
    Console.WriteLine("Operação finalizada!");
  }
}
