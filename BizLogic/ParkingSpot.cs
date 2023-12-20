namespace ParkingLotDesign.BizLogic
{
    public class ParkingSpot
	{
		private int mySpotNumber;
		private bool myIsOccupied;
		private Vehicle? myParkedVehicle;

		public int GetSpotNumber()
		{
			return mySpotNumber;
		}

		public bool IsOccupied()
		{
			return myIsOccupied;
		}

		public void SetOccupied(bool state)
		{
			myIsOccupied = state;
		}

		public Vehicle GetParkedVehicle()
		{
			return myParkedVehicle;
		}

		public void SetParkedVehicle(Vehicle vehicle)
		{
			myParkedVehicle = vehicle;
		}

		public ParkingSpot(int spotNumber)
		{
			mySpotNumber = spotNumber;
			myIsOccupied = false;
			myParkedVehicle = null;
		}
	}
}

