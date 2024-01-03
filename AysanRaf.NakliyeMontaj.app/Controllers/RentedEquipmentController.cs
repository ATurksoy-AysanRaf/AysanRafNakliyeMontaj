using AutoMapper;

using AysanRaf.NakliyeMontaj.Entites.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AysanRaf.NakliyeMontaj.app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentedEquipmentController : ControllerBase
    {
        private readonly Business.Services.IBaseService<RentedEquipment> _service;
        private readonly IMapper _mapper;


        public RentedEquipmentController(Business.Services.IBaseService<RentedEquipment> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            var product = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<RentedEquipmentForDetailDto>(product));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            var products = await _service.GetAllAsync();
            return Ok(_mapper.Map<List<RentedEquipmentForDetailDto>>(products));
        }

        [HttpPost]
        public async Task<IActionResult> Add(RentedEquipmentForPostDto rentedEquipmentForPostDto)
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            var ppd = _mapper.Map<RentedEquipment>(rentedEquipmentForPostDto);
            await _service.AddAsync(ppd);
            return Ok();
        }

        //  [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            var product = await _service.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return await _service.DeleteAsync(id) ? NoContent() : throw new Exception();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, RentedEquipmentForUpdateDto RentedEquipmentForUpdateDto)
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            var product = await _service.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            var pud = _mapper.Map(RentedEquipmentForUpdateDto, product);
            await _service.UpdateAsync(pud);
            return Ok(pud);
        }
    }
}

