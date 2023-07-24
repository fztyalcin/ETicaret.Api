using ETicaret.Model;
using ETicaret.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        private KategoriRepository repository;
        public KategoriController(KategoriRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("TümKategoriler")]
        public dynamic TumKategoriler()
        {
            List<Kategori> items = repository.FindAll().ToList<Kategori>();
            return new
            {
                succes = true,
            data = items
            };
        }

        [HttpGet("{id}")]
        public dynamic Get(int id)
        {
            Kategori item = repository.FindByCondition(a => a.Id == id).SingleOrDefault<Kategori>();
            return new
            {
                succes = true,
                data = item
            };
        }

        [HttpGet("UstKategoriler")]
        public dynamic UstKategoriler()
        {
            List <Kategori> items = repository.FindByCondition(a => a.UstKategoriId == null).ToList<Kategori>();
            return new
            {
                succes = true,
                data = items
            };
        }

        [HttpGet("AltKAtegoriler/{id}")]
        public dynamic AltKAtegoriler(int id)
        {
            List<Kategori> items = repository.FindByCondition(a => a.UstKategoriId == id).ToList<Kategori>();
            return new
            {
                succes = true,
                data = items
            };
        }
    }
}
