namespace TripProject {
  public class Route {
    private double kmTraveled;
    private double fuelValue; // Combustível
    private double tollValue; // Pedágio

    public double GetKmTraveled() {
      return kmTraveled;
    }

    public void SetKmTraveled(double kmTraveled) {
      this.kmTraveled = kmTraveled;
    }

    public double GetFuelValue() {
      return fuelValue;
    }

    public void SetFuelValue(double fuelValue) {
      this.fuelValue = fuelValue;
    }

    public double GetTollValue() {
      return tollValue;
    }

    public void SetTollValue(double tollValue) {
      this.tollValue = tollValue;
    }

    public Route() {}

    public Route(double km, double fuel, double toll) {
      kmTraveled = km;
      fuelValue = fuel;
      tollValue = toll;
    }

    public string ListRoute() {
      return $"Quilômetros viajados: {GetKmTraveled()}km \nValor do combustível: R${GetFuelValue()} \nValor do pedágio: R${GetTollValue()}";
    }
  }
}