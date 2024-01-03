using AutoMapper;

using AysanRaf.NakliyeMontaj.Entites.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AysanRaf.NakliyeMontaj.app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealizedOfferFormController : ControllerBase
    {
        private readonly Business.Services.IBaseService<RealizedOfferForm> _service;
        private readonly IMapper _mapper;


        public RealizedOfferFormController(Business.Services.IBaseService<RealizedOfferForm> service, IMapper mapper)
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
            return Ok(_mapper.Map<RealizedOfferFormForDetailDto>(product));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            var products = await _service.GetAllAsync();
            return Ok(_mapper.Map<List<RealizedOfferFormForDetailDto>>(products));
        }

        [HttpGet("/api/RealizedForms/List")]
        public async Task<IActionResult> GetAllList()
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            var products = await _service.GetAllAsync();
            return Ok(_mapper.Map<List<RealizedOfferFormForListDto>>(products));
        }

        [HttpPost]
        public async Task<IActionResult> Add(RealizedOfferFormForPostDto realizedOfferFormForPostDto)
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            var ppd = _mapper.Map<RealizedOfferForm>(realizedOfferFormForPostDto);
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
        public async Task<IActionResult> Update(Guid id, RealizedOfferFormForUpdateDto RealizedOfferFormForUpdateDto)
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            var product = await _service.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            var pud = _mapper.Map(RealizedOfferFormForUpdateDto, product);
            await _service.UpdateAsync(pud);
            return Ok(pud);
        }
    }
}
