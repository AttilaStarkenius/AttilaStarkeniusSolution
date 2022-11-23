using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage1._0
{
    public class UI : IUI
    {
        private const int k_FirstOptionNumber = 1;
        private const int k_MenuSize = 8;
        private const char k_PrintAll = '1';
        private const char k_PrintByStatus = '2';
        private const char k_Yes = 'Y';
        private const char k_No = 'N';
        private const char k_Space = ' ';

        public GarageManagment.eUserOptions Menu(string[] i_MenuDisplay)
        {
            GarageManagment.eUserOptions choice;
            string menuTitle;

            menuTitle = string.Format(@"
  __  __ ______ _   _ _    _ 
 |  \/  |  ____| \ | | |  | |
 | \  / | |__  |  \| | |  | |
 | |\/| |  __| | . ` | |  | |
 | |  | | |____| |\  | |__| |
 |_|  |_|______|_| \_|\____/ 
");

            choice = printOptionsAndGetChoice<GarageManagment.eUserOptions>(i_MenuDisplay, menuTitle);
            Console.Clear();

            return choice;
        }

        private string getStringInput(string i_Message)
        {
            string input;

            Console.WriteLine(i_Message);
            input = Console.ReadLine();
            while (input == string.Empty)
            {
                Console.WriteLine("Invalid input, you must fill value");
                input = Console.ReadLine();
            }

            return input;
        }

        public string GetLicenseNumber()
        {
            string licenseNumerMessage = "Please enter a license number:";

            return getStringInput(licenseNumerMessage);
        }

        public void GetOwnerDetails(out string o_OwnerName, out string o_OwnerPhone)
        {
            int phoneNumber;
            string ownerNameMessage = "Please enter the owner's name:";

            o_OwnerName = getStringInput(ownerNameMessage);
            Console.WriteLine("Please enter the owner's phone (only numbers):");
            o_OwnerPhone = Console.ReadLine();
            while (!int.TryParse(o_OwnerPhone, out phoneNumber))
            {
                Console.WriteLine("Invalid phone number, Please try again");
                o_OwnerPhone = Console.ReadLine();
            }
        }

        public void PrintOptions(string[] i_OptionsArray)
        {
            int optionNumber = k_FirstOptionNumber;

            foreach (string str in i_OptionsArray)
            {
                Console.WriteLine("{0}. {1}", optionNumber++, fixEnumString(str));
            }
        }

        private T printOptionsAndGetChoice<T>(string[] i_OptionsArray, string i_Message)
        {
            T choiceTValue = default(T);
            bool isValidInput = false;
            string choice;

            Console.WriteLine(i_Message);
            PrintOptions(i_OptionsArray);
            choice = Console.ReadLine();
            while (!isValidInput)
            {
                try
                {
                    choiceTValue = getChoiceValue<T>(choice);
                    isValidInput = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    choice = Console.ReadLine();
                }
            }

            return choiceTValue;
        }

        // A function that convert the given number in the string into a correct T valuve
        private T getChoiceValue<T>(string i_Choice)
        {
            T choiceValue;
            int choice;

            if (int.TryParse(i_Choice, out choice) && Enum.IsDefined(typeof(T), choice))
            {
                choiceValue = (T)Enum.Parse(typeof(T), i_Choice);
            }
            else
            {
                throw new FormatException("Invalid choice, please choose from the options");
            }

            return choiceValue;
        }

        public VehicleFactory.eVehicleType GetVehicleTypeChoice(string[] i_VehicleTypes)
        {
            string messageVehicleType = "Please choose a vehicle type:";

            return printOptionsAndGetChoice<VehicleFactory.eVehicleType>(i_VehicleTypes, messageVehicleType);
        }

        public string GetVehicleModel()
        {
            string modelMessage = "Please enter the vehicle model:";

            return getStringInput(modelMessage);
        }

        public float GetCurrentEnergy()
        {
            string energyAmountStr;
            float energyAmount;

            Console.WriteLine("Please enter the current energy amount:");
            energyAmountStr = Console.ReadLine();
            while (!float.TryParse(energyAmountStr, out energyAmount))
            {
                Console.WriteLine("Invalid energy amount, Try again");
                energyAmountStr = Console.ReadLine();
            }

            return energyAmount;
        }

        public void GetWheelsInfo(out string o_ManufacturerName, out float o_CurrentAirPressure)
        {
            string airPressureStr, manufacturerName = "Plaese enter the wheel manufacturer:";
            float airPressure;

            o_ManufacturerName = getStringInput(manufacturerName);
            Console.WriteLine("Plaese enter the wheel's air pressure:");
            airPressureStr = Console.ReadLine();
            while (!float.TryParse(airPressureStr, out airPressure))
            {
                Console.WriteLine("Invalid wheel's air pressure, Try again");
                airPressureStr = Console.ReadLine();
            }

            o_CurrentAirPressure = airPressure;
        }

        public void GetMotorcyacleInfo(SpecificDetailsForm i_DetailsForm, string[] i_LicenseTypes)
        {
            string engineCapacityStr, licenseTypeMessage;
            int engineCapacity;

            Console.WriteLine("Please enter the engine capacity:");
            engineCapacityStr = Console.ReadLine();
            while (!int.TryParse(engineCapacityStr, out engineCapacity))
            {
                Console.WriteLine("Invalid engine capacity, Try again");
                engineCapacityStr = Console.ReadLine();
            }

            i_DetailsForm.EngineCapacity = engineCapacity;
            licenseTypeMessage = "Please choose a license type:";
            i_DetailsForm.LicenseType = printOptionsAndGetChoice<Motorcycle.eLicenseType>(i_LicenseTypes, licenseTypeMessage);
        }

        public void GetCarInfo(SpecificDetailsForm i_DetailsForm, string[] i_NumberOfDoors, string[] i_CarColors)
        {
            string numberOfDoorsMessage = "Please choose a number of doors:";
            string carColorMessage = "Please choose a car color:";

            i_DetailsForm.CarColor = printOptionsAndGetChoice<Car.eCarColor>(i_CarColors, carColorMessage);
            i_DetailsForm.NumberOfDoors = printOptionsAndGetChoice<Car.eNumberOfDoors>(i_NumberOfDoors, numberOfDoorsMessage);
        }

        public void GetTruckInfo(SpecificDetailsForm i_DetailsForm)
        {
            string isCooledBaggageStr, baggageCapacityStr;
            float baggageCapacity;

            Console.WriteLine("Please enter the baggage capacity:");
            baggageCapacityStr = Console.ReadLine();
            while (!float.TryParse(baggageCapacityStr, out baggageCapacity))
            {
                Console.WriteLine("Invalid baggage capacity, Try again");
                baggageCapacityStr = Console.ReadLine();
            }

            Console.WriteLine("Is the truck's baggage cooled? Y/N");
            isCooledBaggageStr = Console.ReadLine();
            while (!(isCooledBaggageStr[0] == k_Yes || isCooledBaggageStr[0] == k_No) || !(isCooledBaggageStr.Length == 1))
            {
                Console.WriteLine("Invalid, Is the truck's baggage cooled? Y/N");
                isCooledBaggageStr = Console.ReadLine();
            }

            i_DetailsForm.BaggageCapacity = baggageCapacity;
            i_DetailsForm.IsCooledBaggage = isCooledBaggageStr[0] == k_Yes ? true : false;
        }

        public OwnerDetails.eVehicleStatus GetStatus(string[] i_StatusOptions)
        {
            string vehicleStatusMessage = "Please choose status:";

            return printOptionsAndGetChoice<OwnerDetails.eVehicleStatus>(i_StatusOptions, vehicleStatusMessage);
        }

        public Fuel.eFuelType GetFuelType(string[] i_FuelTypeOptions)
        {
            string fuelTypeMessage = "Please choose fuelType:";

            return printOptionsAndGetChoice<Fuel.eFuelType>(i_FuelTypeOptions, fuelTypeMessage);
        }

        public float GetEnergyToAdd(string i_EnergyToAdd)
        {
            string energyToAddStr;
            float energyToAdd;

            Console.WriteLine("Please enter {0} to add", i_EnergyToAdd);
            energyToAddStr = Console.ReadLine();
            while (!float.TryParse(energyToAddStr, out energyToAdd))
            {
                Console.WriteLine("Invalid amount, Try again");
                energyToAddStr = Console.ReadLine();
            }

            return energyToAdd;
        }

        public bool NeedPrintAllLicense()
        {
            string message, inputChoice;

            message = string.Format(@"Please choose one of the options:
1. Print all license
2. Print by specific status");
            Console.WriteLine(message);
            inputChoice = Console.ReadLine();
            while (!(inputChoice[0] == k_PrintAll || inputChoice[0] == k_PrintByStatus) || !(inputChoice.Length == 1))
            {
                Console.WriteLine("Invalid, {0}", message);
                inputChoice = Console.ReadLine();
            }

            return inputChoice[0] == k_PrintAll;
        }

        public void PrintInProcces()
        {
            Console.WriteLine("The vehicle already exist -> the status changed- the vehicle now is in proccess");
        }

        public void PrintLicenseList(List<string> i_LicensesList, OwnerDetails.eVehicleStatus i_Status, bool i_NeedPrintAll)
        {
            string statusMessage = string.Format("The vehicles with the status {0}", fixEnumString(i_Status.ToString()));
            string message = i_NeedPrintAll ? "The vehicles:" : statusMessage;

            if (i_LicensesList.Count > 0)
            {
                Console.WriteLine(message);
                foreach (string licenseNumber in i_LicensesList)
                {
                    Console.WriteLine(licenseNumber);
                }
            }
            else
            {
                Console.WriteLine("There are no vehicles as requested");
            }
        }

        public void PrintMessage(string i_Message)
        {
            Console.WriteLine(Environment.NewLine + i_Message);
        }

        private string fixEnumString(string i_EnumString)
        {
            StringBuilder fixedString = new StringBuilder(i_EnumString.Length);

            for (int i = 0; i < i_EnumString.Length; i++)
            {
                if (char.IsUpper(i_EnumString[i]))
                {
                    fixedString.Append(k_Space);
                }

                fixedString.Append(i_EnumString[i]);
            }

            return fixedString.ToString();
        }

        public void PrintRangeMsgError(ValueOutOfRangeException i_Ex)
        {
            string message = string.Format("{0} [{1}-{2}]", i_Ex.Message, i_Ex.MinValue.ToString(), i_Ex.MaxValue.ToString());

            PrintMessage(message);
        }
    }
}

