using Max.Core.Entity;
using Max.Core.Dto;

namespace Max.Core.IServices
{
    public interface ISys_dictServices : IBaseServices<Sys_dict>
    {
        string PageList(PubParams.DictBootstrapParams bootstrap);
    }
}