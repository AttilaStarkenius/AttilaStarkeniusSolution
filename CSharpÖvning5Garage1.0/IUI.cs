using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage1._0
{
    public interface IUI
    {
        public const int k_FirstOptionNumber = 1;
        public const int k_MenuSize = 8;
        public const char k_PrintAll = '1';
        public const char k_PrintByStatus = '2';
        public const char k_Yes = 'Y';
        public const char k_No = 'N';
        public const char k_Space = ' ';

        public GarageManagment.eUserOptions Menu(string[] i_MenuDisplay);

        public string getStringInput(string i_Message);

        public string GetLicenseNumber();

        public void GetOwnerDetails(out string o_OwnerName, out string o_OwnerPhone);

        public void PrintOptions(string[] i_OptionsArray);
        public T printOptionsAndGetChoice<T>(string[] i_OptionsArray, string i_Message);
        public T getChoiceValue<T>(string i_Choice);
        public VehicleFactory.eVehicleType GetVehicleTypeChoice(string[] i_VehicleTypes);
        public string GetVehicleModel();
        public float GetCurrentEnergy();
        public void GetWheelsInfo(out string o_ManufacturerName, out float o_CurrentAirPressure);
        public void GetMotorcyacleInfo(SpecificDetailsForm i_DetailsForm, string[] i_LicenseTypes);
        public void GetCarInfo(SpecificDetailsForm i_DetailsForm, string[] i_NumberOfDoors, string[] i_CarColors);
        public void GetTruckInfo(SpecificDetailsForm i_DetailsForm);
        public OwnerDetails.eVehicleStatus GetStatus(string[] i_StatusOptions);
        public Fuel.eFuelType GetFuelType(string[] i_FuelTypeOptions);
        public float GetEnergyToAdd(string i_EnergyToAdd);
        public bool NeedPrintAllLicense();
        public void PrintInProcces();
        public void PrintLicenseList(List<string> i_LicensesList, OwnerDetails.eVehicleStatus i_Status, bool i_NeedPrintAll);
        public void PrintMessage(string i_Message);
        public string fixEnumString(string i_EnumString);
        public void PrintRangeMsgError(ValueOutOfRangeException i_Ex);

    }
}
