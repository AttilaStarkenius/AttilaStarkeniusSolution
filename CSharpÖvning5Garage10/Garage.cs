using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpÖvning5Garage10.VehicleFactory;

namespace CSharpÖvning5Garage10
{
    public class Garage<T> : IEnumerable where T : Vehicle
    {
        /*23.11.2022. Dictionary field
         to store information about vehicle
        type and owner details of all vehicles in garage: 
                private readonly Dictionary<Vehicle, OwnerDetails> r_VehiclesInGarage;
*/
        private Array vehicleArray = new Array[0];
        public static string i_LicenseNumber;
        private readonly Dictionary<Vehicle, OwnerDetails> r_VehiclesInGarage;

        public Garage(int freeParkingslots = 200)
        {
            r_VehiclesInGarage = new Dictionary<Vehicle, OwnerDetails>();
            //vehicleArray = vehicleArray;
        }

        /*23.11.2022. Search vehicle 
         by license number: public Vehicle this[string i_LicenseNumber]
        {
            get
            {
                Vehicle resVehicle = null;

                foreach (Vehicle vehiclePtr in r_VehiclesInGarage.Keys)
                {
                    if (vehiclePtr.LicenseNumber == i_LicenseNumber)
                    {
                        resVehicle = vehiclePtr;
                    }
                }

                if (resVehicle == null)
                {
                    throw new ArgumentException("The license number doesn't exist");
                }

                return resVehicle;
            }
        }

        */
        public Vehicle this[string i_LicenseNumber, string numberOfWheels, 
            string vehicleColors, string vehicleType]
        {
            get
            {
                Vehicle resVehicle = null;
                Vehicle numberOfTheWheels = null;
                Vehicle vehiclesColors = null;
                Vehicle vehicleTypes = null;


                foreach (Vehicle vehiclePtr in r_VehiclesInGarage.Keys)
                {
                    if (Enum.GetNames(typeof(eVehicleType)).ToString() == vehicleType)/*Garage<T>.i_LicenseNumber.Compare(vehiclePtr.LicenseNumber, i_LicenseNumber, true))*/
                    {
                        vehicleTypes = vehiclePtr/*.ToString()*/;
                    }
                }

                foreach (Vehicle vehiclePtr in r_VehiclesInGarage.Keys)
                {
                    if (vehiclePtr.VehicleColor.ToString() == vehicleColors)/*Garage<T>.i_LicenseNumber.Compare(vehiclePtr.LicenseNumber, i_LicenseNumber, true))*/
                    {
                        vehiclesColors = vehiclePtr/*.VehicleColor.ToString()*/;
                    }
                }

                foreach (Vehicle vehiclePtr in r_VehiclesInGarage.Keys)
                {
                    if (vehiclePtr.WheelsList.ToString() == numberOfWheels)/*Garage<T>.i_LicenseNumber.Compare(vehiclePtr.LicenseNumber, i_LicenseNumber, true))*/
                    {
                        numberOfTheWheels = vehiclePtr;
                    }
                }

                foreach (Vehicle vehiclePtr in r_VehiclesInGarage.Keys)
                {
                    if (vehiclePtr.LicenseNumber == i_LicenseNumber)/*Garage<T>.i_LicenseNumber.Compare(vehiclePtr.LicenseNumber, i_LicenseNumber, true))*/
                    {
                        resVehicle = vehiclePtr;
                    }
                }

                if (resVehicle == null)
                {
                    throw new ArgumentException("The license number doesn't exist");
                }

                return resVehicle;
            }
        }

        public void InsertNewVehicle(Vehicle i_Vehicle, string i_OwnerName, string i_OwnerPhone)
        {
            OwnerDetails ownerDetails = new OwnerDetails(i_OwnerName, i_OwnerPhone);

            r_VehiclesInGarage.Add(i_Vehicle, ownerDetails);
        }

        public bool IsInGarage(string i_LicenseNumber, string numberOfWheels,
            string vehicleColors, string vehicleType)
        {
            bool isInGarage = true;
            Vehicle vehicle;

            try
            {
                vehicle = this[i_LicenseNumber, numberOfWheels, vehicleColors, vehicleType];
            }
            catch
            {
                isInGarage = false;
            }

            return isInGarage;
        }

        public List<string> GetVehicleListByStatus(OwnerDetails.eVehicleStatus i_Status, bool i_AllVehicles)
        {
            List<string> licensesList = new List<string>();

            foreach (Vehicle vehicle in r_VehiclesInGarage.Keys)
            {
                if (i_AllVehicles || r_VehiclesInGarage[vehicle].VehicleStatus == i_Status)
                {
                    licensesList.Add(vehicle.LicenseNumber);
                }
            }

            return licensesList;
        }

        public void ChangeStatus(string i_LicenseNumber, OwnerDetails.eVehicleStatus i_NewStatus, string numberOfWheels,
            string vehicleColors, string vehicleType)
        {
            r_VehiclesInGarage[this[i_LicenseNumber, numberOfWheels, vehicleColors, vehicleType]].VehicleStatus = i_NewStatus;
        }

        public void InflatingWheelsToMaxByLicense(string i_LicenseNumber, string numberOfWheels,
            string vehicleColors, string vehicleType)
        {
            this[i_LicenseNumber, numberOfWheels, vehicleColors, vehicleType].InflatingWheelsToMax();
        }

        public void RefuelVehicleByLicense(string i_LicenseNumber, Fuel.eFuelType i_FuelType, float i_FuelToAdd, string numberOfWheels,
            string vehicleColors, string vehicleType)
        {
            Fuel fuelEngine = this[i_LicenseNumber, numberOfWheels, vehicleColors, vehicleType].Engine as Fuel;

            if (fuelEngine != null)
            {
                fuelEngine.Refuel(i_FuelToAdd, i_FuelType);
                this[i_LicenseNumber, numberOfWheels, vehicleColors, vehicleType].UpdateEnergyPercent();
            }
            else
            {
                throw new ArgumentException("The vehicle engine is not from fuel type");
            }
        }

        public void ChargeBatteryByLicense(string i_LicenseNumber, float i_BatteryTimeToAdd, string numberOfWheels,
            string vehicleColors, string vehicleType)
        {
            Electric electricEngine = this[i_LicenseNumber, numberOfWheels, vehicleColors, vehicleType].Engine as Electric;

            if (electricEngine != null)
            {
                electricEngine.ChargeBattery(i_BatteryTimeToAdd);
                this[i_LicenseNumber, numberOfWheels, vehicleColors, vehicleType].UpdateEnergyPercent();
            }
            else
            {
                throw new ArgumentException("The vehicle engine is not from electric type");
            }
        }

        public string GetVehicleDetails(string i_LicenseNumber, string numberOfWheels,
            string vehicleColors, string vehicleType)
        {
            string vehicleDetails, wheelsDetails, engineDetails, vehicleSpecificDetails;
            Vehicle vehicle = this[i_LicenseNumber, numberOfWheels, vehicleColors, vehicleType];
            OwnerDetails ownerDetails = r_VehiclesInGarage[vehicle];

            wheelsDetails = vehicle.GetWheelsDetails();
            engineDetails = vehicle.GetEngineDetails();
            vehicleSpecificDetails = vehicle.GetSpecificDetails();
            vehicleDetails = string.Format(
@"License Number: {0}
Model: {1}
Owner's name: {2}
Owner's phone number: {3}
Status: {4}
The Current Energy Percent is: {5} %
{6}
{7}
{8}",
vehicle.LicenseNumber,
vehicle.Model,
ownerDetails.OwnerName,
ownerDetails.OwnerPhoneNumber,
ownerDetails.VehicleStatus.ToString(),
vehicle.CurrentEnergyPercent.ToString(),
wheelsDetails,
engineDetails,
vehicleSpecificDetails);

            return vehicleDetails;
        }

        public EnergySource.eEnergyType GetEnergySourceByVehicleType(VehicleFactory.eVehicleType i_VehicleType)
        {
            EnergySource.eEnergyType energyType;

            if (i_VehicleType == VehicleFactory.eVehicleType.ElectricCar || i_VehicleType == VehicleFactory.eVehicleType.ElectricMotorcycle)
            {
                energyType = EnergySource.eEnergyType.Electric;
            }
            else
            {
                energyType = EnergySource.eEnergyType.Fuel;
            }

            return energyType;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
