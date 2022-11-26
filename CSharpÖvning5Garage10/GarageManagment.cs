using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage1._0
{
    /*24.11.2022. The user interface is
     in classes "GarageManagment" and "UI"*/

    public class GarageManagment
    {
        public enum eUserOptions
        {
            AddVehicleToTheGarage = 1,
            PrintTheLisenceNumbersOptionalByStatus,
            ChangeVehicleStatus,
            InflateVehicaleWheelsToMaximum,
            RefuelVehicle,
            ChargeVehicle,
            GetFullVehicleDetails,
            Exit,
        }

        private const string k_Fuel = "fuel";
        private const string k_Minutes = "minutes";
        private readonly Garage r_Garage = new Garage();
        private readonly UI r_UI = new UI();

        public void Run()
        {
            eUserOptions userChoice;

            userChoice = r_UI.Menu(Enum.GetNames(typeof(eUserOptions)));
            while (userChoice != eUserOptions.Exit)
            {
                switch (userChoice)
                {
                    case eUserOptions.AddVehicleToTheGarage:
                        addVehicle();
                        break;

                    case eUserOptions.PrintTheLisenceNumbersOptionalByStatus:
                        printLicenseNumberListByStatus();
                        break;

                    case eUserOptions.ChangeVehicleStatus:
                        changeVehicleStatus();
                        break;

                    case eUserOptions.InflateVehicaleWheelsToMaximum:
                        inflateWheelsToMax();
                        break;

                    case eUserOptions.RefuelVehicle:
                        refuelVehicle();
                        break;

                    case eUserOptions.ChargeVehicle:
                        chargeVehicle();
                        break;

                    case eUserOptions.GetFullVehicleDetails:
                        getFullDetails();
                        break;
                }

                r_UI.PrintMessage(Environment.NewLine);
                userChoice = r_UI.Menu(Enum.GetNames(typeof(eUserOptions)));
            }
        }

        private void addVehicle()
        {
            string licenseNumber, ownersName, ownersPhoneNumber;
            SpecificDetailsForm detailsForm;
            Vehicle newVehicle;

            licenseNumber = r_UI.GetLicenseNumber();
            if (r_Garage.IsInGarage(licenseNumber))
            {
                r_UI.PrintInProcces();
                r_Garage.ChangeStatus(licenseNumber, OwnerDetails.eVehicleStatus.InProcess);
            }
            else
            {
                detailsForm = new SpecificDetailsForm();
                newVehicle = createNewVehicle(licenseNumber);
                fillForm(newVehicle, detailsForm);
                r_UI.GetOwnerDetails(out ownersName, out ownersPhoneNumber);
                newVehicle.FillDetails(detailsForm);
                r_Garage.InsertNewVehicle(newVehicle, ownersName, ownersPhoneNumber);
                r_UI.PrintMessage("The vehicle is now in process in the garage");
            }
        }

        private Vehicle createNewVehicle(string i_LicenseNumber)
        {
            Vehicle newVehicle;
            VehicleFactory.eVehicleType vehicleType;

            vehicleType = r_UI.GetVehicleTypeChoice(VehicleFactory.GetVehicleOptions());
            newVehicle = VehicleFactory.CreateVehicle(i_LicenseNumber, vehicleType);
            newVehicle.CreateEngineAndWheels(r_Garage.GetEnergySourceByVehicleType(vehicleType));

            return newVehicle;
        }

        private void fillForm(Vehicle i_Vehicle, SpecificDetailsForm i_DetailsForm)
        {
            fillBasicInformation(i_Vehicle);
            if (i_Vehicle is Car)
            {
                r_UI.GetCarInfo(i_DetailsForm, Car.GetNumbersOfDoors(), Car.GetColors());
            }
            else if (i_Vehicle is Motorcycle)
            {
                r_UI.GetMotorcyacleInfo(i_DetailsForm, Motorcycle.GetLicenseType());
            }
            else if (i_Vehicle is Truck)
            {
                r_UI.GetTruckInfo(i_DetailsForm);
            }
        }

        private void fillBasicInformation(Vehicle i_Vehicle)
        {
            bool validAirPressure = false, validEnergyAmount = false;
            float currentAirPressure;
            string manufacturerName;

            i_Vehicle.Model = r_UI.GetVehicleModel();
            while (!validEnergyAmount)
            {
                try
                {
                    i_Vehicle.AddEnergy(r_UI.GetCurrentEnergy());
                    validEnergyAmount = true;
                }
                catch (ValueOutOfRangeException ex)
                {
                    r_UI.PrintRangeMsgError(ex);
                }
            }

            while (!validAirPressure)
            {
                try
                {
                    r_UI.GetWheelsInfo(out manufacturerName, out currentAirPressure);
                    i_Vehicle.FillWheelsInfo(manufacturerName, currentAirPressure);
                    validAirPressure = true;
                }
                catch (ValueOutOfRangeException ex)
                {
                    r_UI.PrintRangeMsgError(ex);
                }
            }
        }

        private void printLicenseNumberListByStatus()
        {
            OwnerDetails.eVehicleStatus status = default(OwnerDetails.eVehicleStatus);
            List<string> licenses;
            bool needAllLicenses = r_UI.NeedPrintAllLicense();

            if (!needAllLicenses)
            {
                status = r_UI.GetStatus(OwnerDetails.GetStatusOptions());
            }

            licenses = r_Garage.GetVehicleListByStatus(status, needAllLicenses);
            r_UI.PrintLicenseList(licenses, status, needAllLicenses);
        }

        private void changeVehicleStatus()
        {
            string licenseNumber = r_UI.GetLicenseNumber();
            OwnerDetails.eVehicleStatus status = r_UI.GetStatus(OwnerDetails.GetStatusOptions());

            try
            {
                r_Garage.ChangeStatus(licenseNumber, status);
                r_UI.PrintMessage("The vehicle status changed");
            }
            catch (ArgumentException ex)
            {
                r_UI.PrintMessage(ex.Message);
            }
        }

        private void inflateWheelsToMax()
        {
            string licenseNumber = r_UI.GetLicenseNumber();

            try
            {
                r_Garage.InflatingWheelsToMaxByLicense(licenseNumber);
                r_UI.PrintMessage("The vehicle wheels are now at the maximum air pressure");
            }
            catch (ValueOutOfRangeException ex)
            {
                r_UI.PrintRangeMsgError(ex);
            }
            catch (Exception ex)
            {
                r_UI.PrintMessage(ex.Message);
            }
        }

        private void refuelVehicle()
        {
            string licenseNumber = r_UI.GetLicenseNumber();
            Fuel.eFuelType fuelType = r_UI.GetFuelType(Fuel.GetFuelTypeOptions());
            float fuelToAdd = r_UI.GetEnergyToAdd(k_Fuel);

            try
            {
                r_Garage.RefuelVehicleByLicense(licenseNumber, fuelType, fuelToAdd);
                r_UI.PrintMessage("The refuel succeeded");
            }
            catch (ValueOutOfRangeException ex)
            {
                r_UI.PrintRangeMsgError(ex);
            }
            catch (Exception ex)
            {
                r_UI.PrintMessage(ex.Message);
            }
        }

        private void chargeVehicle()
        {
            string licenseNumber = r_UI.GetLicenseNumber();
            float timeToAdd = r_UI.GetEnergyToAdd(k_Minutes);

            try
            {
                r_Garage.ChargeBatteryByLicense(licenseNumber, timeToAdd);
                r_UI.PrintMessage("The charging succeeded");
            }
            catch (ValueOutOfRangeException ex)
            {
                r_UI.PrintRangeMsgError(ex);
            }
            catch (Exception ex)
            {
                r_UI.PrintMessage(ex.Message);
            }
        }

        private void getFullDetails()
        {
            string licenseNumber = r_UI.GetLicenseNumber();

            try
            {
                r_UI.PrintMessage(r_Garage.GetVehicleDetails(licenseNumber));
            }
            catch (Exception ex)
            {
                r_UI.PrintMessage(ex.Message);
            }
        }
    }
}

