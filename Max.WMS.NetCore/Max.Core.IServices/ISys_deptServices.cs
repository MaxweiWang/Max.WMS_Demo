using Max.Core.Entity;
using Max.Core.Utils.Table;

namespace IServices
{
    public interface ISys_deptServices : IBaseServices<Sys_dept>
    {
        string PageList(Bootstrap.BootstrapParams bootstrap);
    }
}