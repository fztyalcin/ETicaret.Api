using ETicaret.Model;
using ETicaret.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private RolRepository repository;
        public RolController(RolRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("TümRoller")]
        public dynamic TumRoller()
        {
            List<Rol> items = repository.FindAll().ToList<Rol>();
            return new
            {
                succes = true,
                data = items
            };
        }
    }
}