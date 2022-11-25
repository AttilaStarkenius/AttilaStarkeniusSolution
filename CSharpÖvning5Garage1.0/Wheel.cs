using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage1._0
{
    public class Wheel
    {
        internal const int k_MinAirPressure = 0;
        private readonly float r_MaxAirPressure;
        private string m_ManufacturerName;
        private float m_CurrentAirPressure;

        public Wheel(float i_MaxAirPressure)
        {
            r_MaxAirPressure = i_MaxAirPressure;
        }

        public string Manufacturer
        {
            get { return m_ManufacturerName; }
            set { m_ManufacturerName = value; }
        }

        public float CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
        }

        public void InflatingWheel(float i_AirPressureToAdd)
        {
            string message;

            if (m_CurrentAirPressure + i_AirPressureToAdd <= r_MaxAirPressure)
            {
                m_CurrentAirPressure += i_AirPressureToAdd;
            }
            else
            {
                message = string.Format("The current amount of air pressure is {0} should be between", m_CurrentAirPressure);
                throw new ValueOutOfRangeException(message, r_MaxAirPressure, k_MinAirPressure);
            }
        }

        public float MissingAirPressureToMax()
        {
            return r_MaxAirPressure - m_CurrentAirPressure;
        }
    }
}

