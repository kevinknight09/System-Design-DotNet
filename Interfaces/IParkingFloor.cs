using ParkingLotDesign.BizLogic;

namespace ParkingLotDesign.Interfaces
{
    public interface IParkingFloor
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        bool ParkVehicle(Vehicle vehicle);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="licenseNumber"></param>
        /// <returns></returns>
        bool RemoveVehicle(string licenseNumber);


        /// <summary>
        /// 
        /// </summary>
        void DisplayParkingFloorStatus();
    }
}

