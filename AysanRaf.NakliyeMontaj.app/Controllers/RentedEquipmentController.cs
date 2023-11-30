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
        public async Task<IActionResult> GetById(String id)
        {
            var product = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<RentedEquipmentForDetailDto>(product));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _service.GetAllAsync();
            return Ok(_mapper.Map<List<RentedEquipmentForDetailDto>>(products));
        }

        [HttpPost]
        public async Task<IActionResult> Add(RentedEquipmentForPostDto rentedEquipmentForPostDto)
        {
            var ppd = _mapper.Map<RentedEquipment>(rentedEquipmentForPostDto);
            await _service.AddAsync(ppd);
            return Ok();
        }

        //  [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(String id)
        {
            var product = await _service.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return await _service.DeleteAsync(id) ? NoContent() : throw new Exception();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(String id, RentedEquipmentForUpdateDto RentedEquipmentForUpdateDto)
        {
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

