
using ParkingLotDesign.Interfaces;

namespace ParkingLotDesign.BizLogic
{
	public class ParkingLot : IParkingLot
	{
		private IEnumerable<IParkingFloor> myParkingFloors;
		private int myTotalParkingFloors;
		private int mySpotsPerFloor;

		public IEnumerable<IParkingFloor> GetParkingFloors()
		{
			return myParkingFloors;
		}

		public int GetNumberOfParkingFloors()
		{
			return myTotalParkingFloors;
		}

		public int GetSpotsPerFloor()
		{
			return mySpotsPerFloor;
		}

		public ParkingLot(int numberOfParkingFLoors, int spotsPerFloor)
		{
			myTotalParkingFloors = numberOfParkingFLoors;
			mySpotsPerFloor = spotsPerFloor;
			myParkingFloors = InitializeParkingFloors();
		}

		private List<ParkingFloor> InitializeParkingFloors()
		{
			var floors = new List<ParkingFloor>();
			for(int i=0;i<myTotalParkingFloors;i++)
			{
				floors.Add(new ParkingFloor(mySpotsPerFloor));
			}

			return floors;
		}

		public bool ParkVehicle(Vehicle vehicle)
		{
			foreach(var floor in myParkingFloors)
			{
				if(floor.ParkVehicle(vehicle))
				{
					return true;
				}
			}

			Console.WriteLine("No Spot is available in all the floors");
			return false;
		}

		public bool RemoveVehicle(string licensePlateNumber)
		{
			foreach(var floor in myParkingFloors)
			{
				if(floor.RemoveVehicle(licensePlateNumber))
				{
					Console.WriteLine($"Vehicle with {licensePlateNumber} is safely removed");
					return true;
				}
			}

			Console.WriteLine($"No spots available in the parking lot");
			return false;
		}

		public void DisplayParkingLotStatus()
		{
			Console.WriteLine("Status of parking spots available in the parking Lot");

			foreach(var floor in myParkingFloors)
			{
				floor.DisplayParkingFloorStatus();
			}
		}
	}
}

