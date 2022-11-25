using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage1._0
{
    /*24.11.2022. I create class "VehicleFactory"
     to create a vehicle and to get vehicle options*/
    public static class VehicleFactory
    {
        public enum eVehicleType
        {
            Truck = 1,
            Airplane,
            Motorcycle,
            Car,
            Bus,
            Boat,
            FuelCar,
            FuelMotorcycle,
            ElectricCar,
            ElectricMotorcycle,
        }

        public static Vehicle CreateVehicle(string i_LicenseNumber, eVehicleType i_VehicleType)
        {
            Vehicle newVehicle = null;

            if (i_VehicleType == eVehicleType.ElectricMotorcycle || i_VehicleType == eVehicleType.FuelMotorcycle)
            {
                newVehicle = new Motorcycle(i_LicenseNumber);
            }
            else if (i_VehicleType == eVehicleType.FuelCar || i_VehicleType == eVehicleType.ElectricCar)
            {
                newVehicle = new Car(i_LicenseNumber);
            }
            else if (i_VehicleType == eVehicleType.Truck)
            {
                newVehicle = new Truck(i_LicenseNumber);
            }

            return newVehicle;
        }

        public static string[] GetVehicleOptions()
        {
            return Enum.GetNames(typeof(eVehicleType));
        }
    }
}

