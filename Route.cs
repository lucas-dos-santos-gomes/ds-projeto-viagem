namespace TripProject {
  public class Route {
    private double kmTraveled;
    private double fuelValue; // Combustível
    private string tollValue; // Pedágio

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

    public string GetTollValue() {
      return tollValue;
    }

    public void SetTollValue(string tollValue) {
      this.tollValue = tollValue;
    }


    public Route(double km, double fuel, string toll) {
      kmTraveled = km;
    }
  }
}