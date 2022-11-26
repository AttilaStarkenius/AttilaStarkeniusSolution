using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage1._0
{
    /*23.11.2022. I create a sub class "Car" to super class "Vehicle"*/
    public class Car : Vehicle
    {
        public enum eCarColor
        {
            Grey = 1,
            Blue,
            White,
            Black,
        }

        public enum eNumberOfDoors
        {
            Two = 1,
            Three,
            Four,
            Five,
        }

        private const int k_NumberOfWheels = 4;
        private const float k_MinimumRange = 0;
        private const float k_MaxAirPressure = 32f;
        private const float k_MaxBatteryTime = 3.2f;
        private const float k_MaxFuelAmount = 45f;
        private eCarColor m_CarColor;
        private eNumberOfDoors m_NumberOfDoors;

        public static string[] GetColors()
        {
            return Enum.GetNames(typeof(eCarColor));
        }

        public static string[] GetNumbersOfDoors()
        {
            return Enum.GetNames(typeof(eNumberOfDoors));
        }

        public Car(string i_LicenseNumber) : base(i_LicenseNumber, k_NumberOfWheels)
        {
        }

        public void CreateEngineAndWheels(EnergySource.eEnergyType i_EnergySource)
        {
            AllocateEngine(i_EnergySource);
            InitializeWheels(k_MaxAirPressure);
            if (Engine is Electric)
            {
                Engine.UpdateMaxEnergyAmount(k_MaxBatteryTime);
            }
            else
            {
                Engine.UpdateMaxEnergyAmount(k_MaxFuelAmount);
                ((Fuel)Engine).FuelType = Fuel.eFuelType.Octan98;
            }
        }

        public void FillDetails(SpecificDetailsForm i_DetailsForm)
        {
            m_CarColor = i_DetailsForm.CarColor;
            m_NumberOfDoors = i_DetailsForm.NumberOfDoors;
            UpdateEnergyPercent();
        }

        // $G$ DSN-999 (-3) You should have implemented this by overriding ToString 
        public string GetSpecificDetails()
        {
            return string.Format("The car's color: {0}, The number of doors: {1}", m_CarColor.ToString(), m_NumberOfDoors.ToString());
        }

        public void UpdateEnergyPercent()
        {
            UpdateCurrentEnergyPercent(k_MaxFuelAmount, k_MaxBatteryTime);
        }
    }
}

