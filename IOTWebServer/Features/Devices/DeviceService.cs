using System.Collections.Generic;
using System.Threading.Tasks;
using IOTWebServer.Data.Repository;
using IOTWebServer.Features.Devices;

namespace IOTWebServer.Features.Devices
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository devices;

        public DeviceService(IDeviceRepository devices)
        {
            this.devices = devices;
        }

        public IEnumerable<int> FilterData(int deviceId, string condition)
        {
            return devices.FilterData(deviceId, condition);
        }


        public IEnumerable<int> GetAll(int id)
        {
            return devices.GetAllData(id);
        }

        public bool PostData(int[] data, int deviceId)
        {
            return devices.PostData(data, deviceId);
        }
    }
}
