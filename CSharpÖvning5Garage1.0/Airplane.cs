using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpÖvning5Garage1._0.Car;

namespace CSharpÖvning5Garage1._0
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

        public static string[] GetColors()
        {
            return Enum.GetNames(typeof(eAirplaneColor));
        }

        public static string[] GetNumbersOfSeats()
        {
            return Enum.GetNames(typeof(eAirplaneNumberOfSeats));
        }
        public override void CreateEngineAndWheels(EnergySource.eEnergyType i_EnergySource)
        {
            throw new NotImplementedException();
        }

        public override void FillDetails(SpecificDetailsForm i_DetailsForm)
        {
            throw new NotImplementedException();
        }

        public override string GetSpecificDetails()
        {
            throw new NotImplementedException();
        }

        public override void UpdateEnergyPercent()
        {
            throw new NotImplementedException();
        }
    }
}
