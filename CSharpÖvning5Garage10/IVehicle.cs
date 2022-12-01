using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage10
{
    public interface IVehicle
    {
        //public readonly string r_LicenseNumber;
        //public readonly List<Wheel> r_WheelsList;
        //public string m_ModelName;
        //public float m_CurrentEnergyPercent;
        //public EnergySource m_Engine;
        public string LicenseNumber { get; set; }
        public string Model { get; set; }
        public string CurrentEnergyPercent { get; set; }
        public EnergySource Engine { get; set; }
        public List<Wheel> WheelsList { get; set; }

        public string vehicleColor { get; set; }
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

