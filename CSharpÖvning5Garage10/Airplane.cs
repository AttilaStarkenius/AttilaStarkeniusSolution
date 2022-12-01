using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpÖvning5Garage10.Car;

namespace CSharpÖvning5Garage10
{
    public class Airplane : Vehicle
    {
        public Airplane(string i_LicenseNumber, int i_NumberOfWheels) : base(i_LicenseNumber, i_NumberOfWheels)
        {
        }

        public enum eAirplaneColor
        {
            Grey = 1,
            Blue,
            White,
            Black,
        }

        public enum eAirplaneNumberOfSeats
        {
            Ten = 1,
            Fifty,
            Hundred,
            Twohundred,
        }

        private const int k_NumberOfWheels = 4;
        private const float k_MinimumRange = 0;
        private const float k_MaxAirPressure = 32f;
        private const float k_MaxBatteryTime = 3.2f;
        private const float k_MaxFuelAmount = 45f;
        private eAirplaneColor m_eAirplaneColor;
        private eNumberOfDoors m_NumberOfDoors;

        public static string[] GetColors()
        {
            return Enum.GetNames(typeof(eAirplaneColor));
        }

        public static string[] GetNumbersOfSeats()
        {
            return Enum.GetNames(typeof(eAirplaneNumberOfSeats));
        }
        public void CreateEngineAndWheels(EnergySource.eEnergyType i_EnergySource)
        {
            //throw new NotImplementedException();
        }

        public void FillDetails(SpecificDetailsForm i_DetailsForm)
        {
            //throw new NotImplementedException();
        }

        public string GetSpecificDetails()
        {
            return string.Format("The car's color: {0}, The number of doors: {1}", m_eAirplaneColor.ToString(), m_NumberOfDoors.ToString());
        }

        public void UpdateEnergyPercent()
        {
            UpdateCurrentEnergyPercent(k_MaxFuelAmount, k_MaxBatteryTime);
        }
    }
}
