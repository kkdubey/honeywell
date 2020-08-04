namespace IOTWebServer.Features.Devices.Models
{
    public class DeviceDataPostModel
    {
        public int DeviceId { get; set; }
        public int[] Data { get; set; }
    }
}
