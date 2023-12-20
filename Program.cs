// See https://aka.ms/new-console-template for more information
using ParkingLotDesign;
using ParkingLotDesign.BizLogic;

Main();

static void Main()
{
    var parkingLot = new ParkingLot(3,6);

    parkingLot.ParkVehicle(new Vehicle("ABC123", VehicleType.Car));
    parkingLot.ParkVehicle(new Vehicle("cvf987", VehicleType.Motorcycle));

    parkingLot.DisplayParkingLotStatus();

    parkingLot.RemoveVehicle("cvf987");

    parkingLot.DisplayParkingLotStatus();

}
