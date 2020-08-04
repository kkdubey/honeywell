using System.Collections.Generic;
using System.Threading.Tasks;
using IOTWebServer.Features.Devices.Models;
using Microsoft.AspNetCore.Mvc;

namespace IOTWebServer.Features.Devices
{

    public class DeviceController : ApiController
    {
        private readonly IDeviceService devices;

        public DeviceController(
            IDeviceService devices)
        {
            this.devices = devices;
        }


        [HttpGet("getAll/{deviceId:int?}")]
        public IEnumerable<int> GetAll(int deviceId)
        {
            return devices.GetAll(deviceId);
        }

        [HttpGet("filterData/{deviceId:int}/{condition}")]
        public IEnumerable<int> FilterData(int deviceId, string condition)
        {
            return devices.FilterData(deviceId, condition);
        }


        [HttpPost("postData")]
        public ActionResult PostData([FromBody] DeviceDataPostModel model)
        {
            if (model.DeviceId > 0)
            {
                devices.PostData(model.Data, model.DeviceId);
            } else
            {
                devices.PostData(model.Data, 1);
            }

            return Created(nameof(PostData), model.DeviceId);
        }


    }
}
