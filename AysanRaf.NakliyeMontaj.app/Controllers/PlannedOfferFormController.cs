using AutoMapper;

using AysanRaf.NakliyeMontaj.Entites.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AysanRaf.NakliyeMontaj.app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        {
            var product = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<PlannedOfferFormForDetailDto>(product));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _service.GetAllAsync();
            return Ok(_mapper.Map<List<PlannedOfferFormForDetailDto>>(products));
        }

        [HttpGet("PlannedForms/List")]
        public async Task<IActionResult> GetAllList()
        {
            var products = await _service.GetAllAsync();
            return Ok(_mapper.Map<List<PlannedOfferFormForListDto>>(products));
        }

        [HttpPost]
        public async Task<IActionResult> Add(PlannedOfferFormForPostDto plannedOfferFormForPostDto)
        {
            var ppd = _mapper.Map<PlannedOfferForm>(plannedOfferFormForPostDto);
            await _service.AddAsync(ppd);
            return Ok();
        }

        //  [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var product = await _service.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return await _service.DeleteAsync(id) ? NoContent() : throw new Exception();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, PlannedOfferFormForUpdateDto PlannedOfferFormForUpdateDto)
        {
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

