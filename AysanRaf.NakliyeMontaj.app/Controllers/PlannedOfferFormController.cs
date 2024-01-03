using AutoMapper;
using AysanRaf.NakliyeMontaj.Business.Services;
using AysanRaf.NakliyeMontaj.Entites.DTOs;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace AysanRaf.NakliyeMontaj.app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // /api/PlannedOfferForm/PlannedForms/List
    public class PlannedOfferFormController : ControllerBase
    {
        private readonly Business.Services.IBaseService<Models.PlannedOfferForm> _service;
        private readonly IMapper _mapper;
       
        public PlannedOfferFormController(Business.Services.IBaseService<PlannedOfferForm> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
            
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {// İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            // ExcelExportService sınıfını kullanarak Excel dosyasını oluşturun
            var product = await _service.GetByIdAsync(id);
            // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            return Ok(_mapper.Map<PlannedOfferFormForDetailDto>(product));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
          // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            // ExcelExportService sınıfını kullanarak Excel dosyasını oluşturun
            var products = await _service.GetAllAsync();
            return Ok(_mapper.Map<List<PlannedOfferFormForDetailDto>>(products));
        }
        
       
        [HttpGet("PlannedForms/List")]
        public async Task<IActionResult> GetAllList()
        {// İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            // ExcelExportService sınıfını kullanarak Excel dosyasını oluşturun
            var products = await _service.GetAllAsync();
            return Ok(_mapper.Map<List<PlannedOfferFormForListDto>>(products));
        }

        [HttpPost]
        public async Task<IActionResult> Add(PlannedOfferFormForPostDto plannedOfferFormForPostDto)
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
          // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            // ExcelExportService sınıfını kullanarak Excel dosyasını oluşturun
            var ppd = _mapper.Map<PlannedOfferForm>(plannedOfferFormForPostDto);
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
        public async Task<IActionResult> Update(Guid id, PlannedOfferFormForUpdateDto PlannedOfferFormForUpdateDto)
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            var product = await _service.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            var pud = _mapper.Map(PlannedOfferFormForUpdateDto, product);
            await _service.UpdateAsync(pud);
            return Ok(pud);
        }

     
    }
}

