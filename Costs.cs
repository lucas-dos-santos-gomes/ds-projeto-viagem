namespace TripProject {
  public class Costs {
    private double kmTraveled;
    private double fuelValue;
    private double tollValue;
    private double fullRoute;
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

    public double GetFullRoute() {
      return fullRoute;
    }

    public void SetFullRoute(double fullRoute) {
      this.fullRoute = fullRoute;
    }
    public string calculateTrip(Route p) {
      SetKmTraveled(p.GetKmTraveled());
      SetFuelValue(p.GetFuelValue());
      SetTollValue(p.GetTollValue());
      SetFullRoute((GetKmTraveled() * GetFuelValue()) + GetTollValue());
      return $"{p.ListRoute()}\nPercurso total: {GetFullRoute()}";
    }
  }
}