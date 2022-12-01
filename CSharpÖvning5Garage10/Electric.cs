using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage10
{
    public class Electric : EnergySource
    {
        private const int k_MinBatteryTime = 0;
        private float m_CurrentBatteryTime;
        private float m_MaxBatteryTime;

        public float CurrentBatteryTime
        {
            get { return m_CurrentBatteryTime; }
        }

        public float MaxBatteryTime
        {
            get { return m_MaxBatteryTime; }
        }

        public void ChargeBattery(float i_HoursToAdd)
        {
            AddEnergy(i_HoursToAdd);
        }

        public string GetElectricDetails()
        {
            return string.Format("Current battery time: {0}", m_CurrentBatteryTime.ToString());
        }

        public override void AddEnergy(float i_EnergyToAdd)
        {
            string message;

            if (m_CurrentBatteryTime + i_EnergyToAdd <= m_MaxBatteryTime)
            {
                m_CurrentBatteryTime += i_EnergyToAdd;
            }
            else
            {
                message = string.Format("The current amount of battery is {0} and should be between", m_CurrentBatteryTime);
                throw new ValueOutOfRangeException(message, m_MaxBatteryTime, k_MinBatteryTime);
            }
        }

        public override void UpdateMaxEnergyAmount(float i_MaxEnergyAmount)
        {
            m_MaxBatteryTime = i_MaxEnergyAmount;
        }
    }
}

