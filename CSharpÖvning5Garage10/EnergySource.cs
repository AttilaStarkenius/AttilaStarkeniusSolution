using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage10
{
    public abstract class EnergySource
    {
        public enum eEnergyType
        {
            Electric = 1,
            Fuel,
        }

        internal const float k_MinEnergyCapacity = 0;

        public abstract void AddEnergy(float i_EnergyToAdd);

        public abstract void UpdateMaxEnergyAmount(float i_MaxEnergyAmount);
    }
}

