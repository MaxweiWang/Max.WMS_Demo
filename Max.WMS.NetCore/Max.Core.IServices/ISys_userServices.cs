using System.Collections.Generic;
using Max.Core.Dto;
using Max.Core.Entity;
using Max.Core.Utils.Table;

namespace Max.Core.IServices
{
    public interface ISys_userServices : IBaseServices<Sys_user>
    {
        (bool, string, SysUserDto) CheckLogin(SysUserDto dto);

        string PageList(Bootstrap.BootstrapParams bootstrap);

        void Login(long userId, string ip);
    }
}