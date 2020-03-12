using IRepository;
using IServices;
using Max.Core.Entity;

namespace Services
{
    public class Sys_menuServices : BaseServices<Sys_menu>, ISys_menuServices
    {
        public Sys_menuServices(ISys_menuRepository repository) : base(repository)
        {
        }
    }
}