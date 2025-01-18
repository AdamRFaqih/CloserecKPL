using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        List<Mahasiswa> mahasiswa = MahasiswaHelper.JsonToMhs();
        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswa.Add(value);
            MahasiswaHelper.MhsToJson(mahasiswa);
            mahasiswa = MahasiswaHelper.JsonToMhs();

        }

        // PUT api/<MahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            mahasiswa[id] = value;
            MahasiswaHelper.MhsToJson(mahasiswa);
            mahasiswa = MahasiswaHelper.JsonToMhs();
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswa.Remove(Get(id));
            MahasiswaHelper.MhsToJson(mahasiswa);
            mahasiswa = MahasiswaHelper.JsonToMhs();
        }
    }
}
