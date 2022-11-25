using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage1._0
{
    public class SpecificDetailsForm
    {
        private Motorcycle.eLicenseType m_LicenseType;
        private int m_EngineCapacity;
        private Car.eCarColor m_CarColor;
        private Car.eNumberOfDoors m_NumberOfDoors;
        private bool m_IsCooledBaggage;
        private float m_BaggageCapacity;

        public Motorcycle.eLicenseType LicenseType
        {
            get { return m_LicenseType; }
            set { m_LicenseType = value; }
        }

        public int EngineCapacity
        {
            get { return m_EngineCapacity; }
            set { m_EngineCapacity = value; }
        }

        public Car.eCarColor CarColor
        {
            get { return m_CarColor; }
            set { m_CarColor = value; }
        }

        public Car.eNumberOfDoors NumberOfDoors
        {
            get { return m_NumberOfDoors; }
            set { m_NumberOfDoors = value; }
        }

        public bool IsCooledBaggage
        {
            get { return m_IsCooledBaggage; }
            set { m_IsCooledBaggage = value; }
        }

        public float BaggageCapacity
        {
            get { return m_BaggageCapacity; }
            set { m_BaggageCapacity = value; }
        }
    }
}

