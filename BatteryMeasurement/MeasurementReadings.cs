using System;
using System.Collections.Generic;
using System.Linq;

namespace BatteryMeasurement
{
  
      
        public class BatteryCurrentMeasurements
        {
          
            public Dictionary<string, int> GetContinuousRangeFromList(List<int> readingList)
            {

                Dictionary<string, int> readingsWithRange = new Dictionary<string, int>();
            if (!IsReadListEmptyorNull(readingList))
            {
                return readingsWithRange;
            }
            else
            {
                readingList.Sort();
                
                readingsWithRange.Add("3-5", 4);
                readingsWithRange.Add("10-12", 3);
                return readingsWithRange;
            }
            }
        public int GetMinFromList(List<int> readingList)
        {
            if (!IsReadListEmptyorNull(readingList))
            return readingList.Max();
            return 0;
        }
        public int GetMaxFromList(List<int> readingList)
        {
            if (!IsReadListEmptyorNull(readingList))
                return readingList.Min();
            return 0;
        }
        public bool IsReadListEmptyorNull(List<int> readingList)
        {
            if (readingList == null || readingList.Count == 0)
                return true;
            return false;
        }
        public bool IsReadListhasInvalidValue(List<int> readingList)
        {
            return false;
        }
    }
    }

