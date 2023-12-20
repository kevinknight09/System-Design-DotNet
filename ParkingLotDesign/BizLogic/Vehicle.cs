namespace ParkingLotDesign.BizLogic
{
    public class Vehicle
	{
		private string LicensePlate;
		private VehicleType Type;

		public string GetLicensePlate()
		{
			return LicensePlate;
		}

		public Vehicle(string licensePlate, VehicleType type)
		{
			LicensePlate = licensePlate;
			Type = type;
		}
	}
}

