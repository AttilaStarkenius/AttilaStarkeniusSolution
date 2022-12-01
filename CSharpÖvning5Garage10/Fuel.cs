using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage10
{
    public class Fuel : EnergySource
    {
        public enum eFuelType
        {
            Soler = 1,
            Octan95,
            Octan96,
            Octan98,
        }

        private const int k_MinFuelAmount = 0;
        private eFuelType m_FuelType;
        private float m_CurrentFuelAmount;
        private float m_MaxFuelAmount;

        public static string[] GetFuelTypeOptions()
        {
            return Enum.GetNames(typeof(eFuelType));
        }

        public float CurrentFuelAmount
        {
            get { return m_CurrentFuelAmount; }
        }

        public eFuelType FuelType
        {
            get { return m_FuelType; }
            set { m_FuelType = value; }
        }

        public float MaxFuelAmount
        {
            get { return m_MaxFuelAmount; }
        }

        public void Refuel(float i_FuelAmountToAdd, eFuelType i_FuelType)
        {
            if (m_FuelType != i_FuelType)
            {
                throw new ArgumentException("Fuel Type is not compatible with the vehicle fuel type");
            }

            AddEnergy(i_FuelAmountToAdd);
        }

        public string GetFuelDetails()
        {
            string fuelDetails = string.Format(
@"Fuel type: {0} 
Current fuel amount: {1}",
m_FuelType.ToString(),
m_CurrentFuelAmount.ToString());

            return fuelDetails;
        }

        public override void AddEnergy(float i_EnergyToAdd)
        {
            string message;

            if (m_CurrentFuelAmount + i_EnergyToAdd <= m_MaxFuelAmount)
            {
                m_CurrentFuelAmount += i_EnergyToAdd;
            }
            else
            {
                message = string.Format("The current amount of fuel is {0} and should be between", m_CurrentFuelAmount);
                throw new ValueOutOfRangeException(message, m_MaxFuelAmount, k_MinFuelAmount);
            }
        }

        public override void UpdateMaxEnergyAmount(float i_MaxEnergyAmount)
        {
            m_MaxFuelAmount = i_MaxEnergyAmount;
        }
    }
}

