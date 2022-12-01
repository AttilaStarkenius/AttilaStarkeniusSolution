using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CSharpÖvning5Garage10;
using static CSharpÖvning5Garage10.VehicleFactory;
using CSharpÖvning5Garage10Test;
using CSharpÖvning5Garage10Test;

namespace CSharpÖvning5Garage10Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertNewVehicle(Vehicle i_Vehicle, string i_OwnerName, string i_OwnerPhone)
        {
            OwnerDetails ownerDetails = new OwnerDetails(i_OwnerName, i_OwnerPhone);

            r_VehiclesInGarage.Add(i_Vehicle, ownerDetails);
        }
    }
}
