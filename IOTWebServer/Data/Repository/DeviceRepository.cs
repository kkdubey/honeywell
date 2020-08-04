using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOTWebServer.Data.Repository
{
    public class DeviceRepository: IDeviceRepository
    {
        Dictionary<int, List<int>> devicesData = new Dictionary<int, List<int>>();
        public DeviceRepository() { 
        }

        public int[] FilterData(int deviceId, string condition)
        {
            if (devicesData.ContainsKey(deviceId))
            {
                var val = 0;
                if (condition.Contains('>'))
                {
                    val = Convert.ToInt32( condition.Split('>')[1]);
                    return devicesData[deviceId].Where(x => x > val).ToArray();
                } else if(condition.Contains('<'))
                {
                    val = Convert.ToInt32(condition.Split('>')[1]);
                    return devicesData[deviceId].Where(x => x < val).ToArray();
                }
                return new int[] { };
            }
            return new int[] { };
        }

        public int[] GetAllData(int? deviceId)
        {
            int[] result = new int[] { };
            if (deviceId > 0)
            {
                return devicesData[(int)deviceId].ToArray();
            }
            else {
                return result;
            }
        }

        public bool PostData(int[] data, int deviceId)
        {
            if (devicesData.ContainsKey(deviceId))
            {
                devicesData[deviceId].AddRange(data.ToList());
            } else
            {
                devicesData.Add(deviceId, data.ToList());
            }
            return true;
        }
    }
}
