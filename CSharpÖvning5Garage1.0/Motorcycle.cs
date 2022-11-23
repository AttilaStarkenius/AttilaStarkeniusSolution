using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage1._0
{
    public class Motorcycle : Vehicle
    {
        public enum eLicenseType
        {
            A = 1,
            A1,
            B1,
            B2,
        }

        private const int k_NumberOfWheels = 2;
        private const float k_MaxAirPressure = 30f;
        private const float k_MaxBatteryTime = 1.8f;
        private const float k_MaxFuelAmount = 6f;
        private eLicenseType m_LicenseType;
        private int m_EngineCapacity;

        public static string[] GetLicenseType()
        {
            return Enum.GetNames(typeof(eLicenseType));
        }

        public Motorcycle(string i_LicenseNumber) : base(i_LicenseNumber, k_NumberOfWheels)
        {
        }

        public override void CreateEngineAndWheels(EnergySource.eEnergyType i_EnergySource)
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
                ((Fuel)Engine).FuelType = Fuel.eFuelType.Octan96;
            }
        }

        public override void FillDetails(SpecificDetailsForm i_DetailsForm)
        {
            m_LicenseType = i_DetailsForm.LicenseType;
            m_EngineCapacity = i_DetailsForm.EngineCapacity;
            UpdateEnergyPercent();
        }

        public override string GetSpecificDetails()
        {
            return string.Format("The license type: {0}, The engine capacity: {1}", m_LicenseType.ToString(), m_EngineCapacity);
        }

        public override void UpdateEnergyPercent()
        {
            UpdateCurrentEnergyPercent(k_MaxFuelAmount, k_MaxBatteryTime);
        }
    }
}