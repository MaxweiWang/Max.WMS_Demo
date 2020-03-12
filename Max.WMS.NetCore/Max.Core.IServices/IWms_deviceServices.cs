using Max.Core.Entity;
using Max.Core.Dto;

namespace IServices
{
    public interface IWms_deviceServices : IBaseServices<Wms_device>
    {
        string PageList(PubParams.DeviceBootstrapParams bootstrap);
    }
}