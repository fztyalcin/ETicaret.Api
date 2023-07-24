using ETicaret.Model;
using ETicaret.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private KullaniciRepository repository;
        public KullaniciController(KullaniciRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("TümKullanicilar")]
        public dynamic TumKullanicilar()
        {
            List<Kullanici> items = repository.FindAll().ToList<Kullanici>();
            return new
            {
                succes = true,
                data = items
            };
        }
    }
}