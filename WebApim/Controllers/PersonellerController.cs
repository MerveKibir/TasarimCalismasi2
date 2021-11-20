
using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonellerController : ControllerBase
    {
        IPersonelService _personelService;

        public PersonellerController(IPersonelService personelService)
        {
            _personelService = personelService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger
            //Dependency chain --

            Thread.Sleep(1000);

            var result = _personelService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _personelService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbykimlik")]
        public IActionResult GetByKimlik(string kimlik)
        {
            var result = _personelService.GetByKimlikNo(kimlik);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getpersoneldetails")]
        public IActionResult GetPersonelDetails()
        {
            var result = _personelService.GetPersonelDetails();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Personel personel)
        {
            var result = _personelService.Add(personel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
