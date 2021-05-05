using BatteryMeasurement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryMeasurement_Tests
{
    [TestClass]
    public class MeasurementReadingTest
    {
      public static readonly  BatteryCurrentMeasurements BatteryMeasurement = new BatteryCurrentMeasurements();
        public static readonly List<int> ReadingList = new List<int>() { 3, 3, 5, 4, 10, 11, 12 };
        [TestMethod]
        public void GetMinFromList_WhenListIsEmpty_Returnzero()
        {
            List<int> emptyReadingsList =  new List<int>();
            int actualResult = BatteryMeasurement.GetMinFromList(emptyReadingsList);
            Assert.AreEqual(0,actualResult);
        }
        [TestMethod]
        public void GetMaxFromList_WhenListIsEmpty_Returnzero()
        {
            List<int> emptyReadingsList = new List<int>();
            int actualResult = BatteryMeasurement.GetMaxFromList(emptyReadingsList);
            Assert.AreEqual(0, actualResult);
        }
        [TestMethod]
        public void GetMinFromList_WhenListHasValue_ReturnExpected()
        {
            List<int> emptyReadingsList = new List<int> { 3, 4, 1, 2, 66, 22, 12 };
            int actualResult = BatteryMeasurement.GetMinFromList(emptyReadingsList);
            Assert.AreEqual(1, actualResult);
        }
        [TestMethod]
        public void GetMaxFromList_WhenListHasValue_ReturnExpected()
        {
            List<int> emptyReadingsList = new List<int> { 3, 4, 1, 2, 66, 22, 12 };
            int actualResult = BatteryMeasurement.GetMaxFromList(emptyReadingsList);
            Assert.AreEqual(66, actualResult);
        }
        public void CheckReadingListValid_WhenListIsNull_ReturnTrue()
        {
            List<int> emptyReadingsList = null;
            bool actualResult = BatteryMeasurement.IsReadListEmptyorNull(emptyReadingsList);
            Assert.IsTrue(actualResult);
        }
        [TestMethod]
       public void CheckReadingList_WhenListIsEmpty_ReturnTrue()
        {
            List<int> emptyReadingsList = new List<int>();
            bool actualResult = BatteryMeasurement.IsReadListEmptyorNull(emptyReadingsList);
            Assert.IsTrue(actualResult);
        }
      
        public void CheckReadingList_WhenListWithValues_ReturnTrue()
        {
            List<int> readingsListWithValues = new List<int>() { 3, 3, 5, 4, 10, 11, 12 };
            bool actualResult = BatteryMeasurement.IsReadListEmptyorNull(readingsListWithValues);
            Assert.IsFalse(actualResult);
        }
      
        [TestMethod]
        public void GetContinuousRangeFromList_WhenListHasCotinuousValue_ReturnTrue()
        {
            List<int> readingsListWithValues = new List<int>() { 3, 4, 5, 4, 10, 11, 12 };
            bool actualResult = BatteryMeasurement.IsReadListhasInvalidValue(readingsListWithValues);
            Assert.IsTrue(actualResult);
        }
        [TestMethod]
        public void GivenReadingList_WhenListIsEmpty_FalseIsReturned()
        {
            List<int> emptyReadingsList = new List<int>();
            Dictionary<string, int> EvaluatedList = BatteryMeasurement.GetContinuousRangeFromList(emptyReadingsList);
            Assert.IsTrue(EvaluatedList.Count > 0);
        }

    }
}
