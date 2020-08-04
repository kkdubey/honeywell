using System.Collections.Generic;
using System.Threading.Tasks;

namespace IOTWebServer.Features.Devices
{

    public interface IDeviceService
    {
        bool PostData(int[] data, int deviceId);


        IEnumerable<int> GetAll(int id);

        IEnumerable<int> FilterData(int deviceId, string condition);

    }
}
