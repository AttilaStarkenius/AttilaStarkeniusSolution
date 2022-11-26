using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CSharpÖvning5Garage1;
using static CSharpÖvning5Garage1._0.VehicleFactory;

namespace CSharpÖvning5Garage1._0Test
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
