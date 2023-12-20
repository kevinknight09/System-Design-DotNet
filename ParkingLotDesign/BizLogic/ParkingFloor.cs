using ParkingLotDesign.Interfaces;

namespace ParkingLotDesign.BizLogic
{
    public class ParkingFloor : IParkingFloor 
	{
		private IEnumerable<ParkingSpot> ParkingSpots;
		private int Capacity;

		public ParkingFloor(int capacity)
		{
			Capacity = capacity;
			ParkingSpots = InitializeParkingSpots(Capacity);
		}

		private List<ParkingSpot> InitializeParkingSpots(int capacity)
		{
			var spots = new List<ParkingSpot>();

			for(int i=0;i<capacity;i++)
			{
				spots.Add(new ParkingSpot(i+1));
			}
			return spots;
		}

		public bool ParkVehicle(Vehicle vehicle)
		{
			foreach(var spot in ParkingSpots)
			{
				if(!spot.IsOccupied())
				{
					spot.SetOccupied(true);
					spot.SetParkedVehicle(vehicle);
					Console.WriteLine($"Vehicle is parked at {spot.GetSpotNumber()}");
					return true;
				}
			}

            Console.WriteLine("No Spots available");
            return false;
        }

		public bool RemoveVehicle(string licenseNumber)
		{
			foreach(var spot in ParkingSpots)
			{
				if(!spot.IsOccupied() && spot.GetParkedVehicle().GetLicensePlate()== licenseNumber)
				{
					spot.SetOccupied(false);
					spot.SetParkedVehicle(null);
					Console.WriteLine("Vehicle removed from spot");
					return true;
				}
			}

			Console.WriteLine("Vehicle not found in the parking Floor");
			return false;
		}

		public void DisplayParkingFloorStatus()
		{
			Console.WriteLine("The status of the Parking Floor");
			foreach(var spot in ParkingSpots)
			{
				Console.WriteLine($"The spot with {spot.GetSpotNumber()} is {(spot.IsOccupied() ? "Blocked" : "Empty")}");
			}
		}
	}
}

