using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage1._0
{
    public class Truck : Vehicle
    {
        internal const float k_MaxFuelAmount = 115f;
        internal const float k_MaxAirPressure = 28f;
        internal const int k_NumberOfWheels = 12;
        internal const float k_NoneBattery = 0;
        private bool m_IsCooledBaggage;
        private float m_BaggageCapacity;

        public Truck(string i_LicenseNumber) : base(i_LicenseNumber, k_NumberOfWheels)
        {
        }

        public void CreateEngineAndWheels(EnergySource.eEnergyType i_EnergySource)
        {
            AllocateEngine(i_EnergySource);
            InitializeWheels(k_MaxAirPressure);
            Engine.UpdateMaxEnergyAmount(k_MaxFuelAmount);
            ((Fuel)Engine).FuelType = Fuel.eFuelType.Soler;
        }

        public void FillDetails(SpecificDetailsForm i_DetailsForm)
        {
            m_IsCooledBaggage = i_DetailsForm.IsCooledBaggage;
            m_BaggageCapacity = i_DetailsForm.BaggageCapacity;
            UpdateEnergyPercent();
        }

        public string GetSpecificDetails()
        {
            string isCoolBaggage = m_IsCooledBaggage == true ? string.Empty : "NOT ";
            string message = string.Format(
@"The Baggage capacity is: {0}
The baggage is {1}cooled",
m_BaggageCapacity.ToString(),
isCoolBaggage);

            return message;
        }

        public void UpdateEnergyPercent()
        {
            UpdateCurrentEnergyPercent(k_MaxFuelAmount, k_NoneBattery);
        }
    }
}

