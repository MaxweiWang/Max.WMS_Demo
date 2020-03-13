using Max.Core.Entity;
using Max.Core.Dto;

namespace Max.Core.IServices
{
    public interface IWms_deviceServices : IBaseServices<Wms_device>
    {
        string PageList(PubParams.DeviceBootstrapParams bootstrap);
    }
}