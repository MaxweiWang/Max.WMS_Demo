using Max.Core.Entity;
using Max.Core.Utils.Table;

namespace Max.Core.IServices
{
    public interface IWms_materialServices : IBaseServices<Wms_material>
    {
        string PageList(Bootstrap.BootstrapParams bootstrap);

        byte[] ExportList(Bootstrap.BootstrapParams bootstrap);
    }
}