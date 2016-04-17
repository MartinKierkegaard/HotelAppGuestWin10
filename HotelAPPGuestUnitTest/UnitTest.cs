﻿using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using HotelAppGuestWin10.Facade;
using HotelAppGuestWin10.Model;

namespace HotelAPPGuestUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var guest = new Guest();
            guest = FacadeGuest.GetSingleGuestAsync(4).Result;
            Assert.AreEqual(4,guest.Guest_No);

        }
    }
}
