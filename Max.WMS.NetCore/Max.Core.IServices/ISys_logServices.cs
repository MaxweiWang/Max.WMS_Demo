using Max.Core.Entity;
using Max.Core.Utils.Table;

namespace Max.Core.IServices
{
    public interface ISys_logServices : IBaseServices<Sys_log>
    {
        string PageList(Bootstrap.BootstrapParams bootstrap);

        string EChart(Bootstrap.BootstrapParams bootstrap);
    }
}