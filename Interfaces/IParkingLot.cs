using ParkingLotDesign.BizLogic;

namespace ParkingLotDesign.Interfaces
{
    public interface IParkingLot
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
        /// <param name="licensePlateNumber"></param>
        /// <returns></returns>
        bool RemoveVehicle(string licensePlateNumber);


        /// <summary>
        /// 
        /// </summary>
        void DisplayParkingLotStatus();
    }
}

