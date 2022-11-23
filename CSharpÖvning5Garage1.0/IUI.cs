using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage1._0
{
    public interface IUI
    {
        private const int k_FirstOptionNumber = 1;
        private const int k_MenuSize = 8;
        private const char k_PrintAll = '1';
        private const char k_PrintByStatus = '2';
        private const char k_Yes = 'Y';
        private const char k_No = 'N';
        private const char k_Space = ' ';

        public GarageManagment.eUserOptions Menu(string[] i_MenuDisplay);

        public string getStringInput(string i_Message);

        public string GetLicenseNumber();

        public void GetOwnerDetails(out string o_OwnerName, out string o_OwnerPhone);

        public void PrintOptions(string[] i_OptionsArray);
        public T printOptionsAndGetChoice<T>(string[] i_OptionsArray, string i_Message);
        private T getChoiceValue<T>(string i_Choice);
        public VehicleFactory.eVehicleType GetVehicleTypeChoice(string[] i_VehicleTypes);
    }
}
