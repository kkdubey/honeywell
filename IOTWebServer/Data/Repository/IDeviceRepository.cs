using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOTWebServer.Data.Repository
{
    public interface IDeviceRepository
    {
        int[] GetAllData(int? deviceId);
        bool PostData(int[] data, int deviceId);
        int[] FilterData(int deviceId, string condition);
    }
}
