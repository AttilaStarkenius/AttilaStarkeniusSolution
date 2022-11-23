using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage1._0
{
    public interface IVehicle
    {
        public string r_LicenseNumber { get; set; }
        public List<Wheel> r_WheelsList { get; set; }
        public string m_ModelName { get; set; }
        public float m_CurrentEnergyPercent { get; set; }
        public EnergySource m_Engine { get; set; }
        //int Year { get; set; }

        //string Make { get; set; }
        //string Model { get; set; }

        //FuelType FuelType { get; set; }

        //EngineState EngineState { get; set; }

        //RadioState RadioState { get; set; }

        //List<String> MessageLog { get; set; }

        //void StartVehicle(IVehicle vehicle);

        //void StopVehicle(IVehicle vehicle);
    }
}

