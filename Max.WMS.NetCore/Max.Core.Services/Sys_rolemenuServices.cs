using IRepository;
using Max.Core.IServices;

using Max.Core.Entity;

namespace Max.Core.Services
{
    public class Sys_rolemenuServices : BaseServices<Sys_rolemenu>, ISys_rolemenuServices
    {
        private readonly ISys_rolemenuRepository _repository;

        public Sys_rolemenuServices(ISys_rolemenuRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}