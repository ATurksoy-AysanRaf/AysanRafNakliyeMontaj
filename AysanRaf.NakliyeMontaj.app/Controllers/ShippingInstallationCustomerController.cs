using AutoMapper;
using AysanRaf.NakliyeMontaj.app.Models;
using AysanRaf.NakliyeMontaj.Business.Services;
using AysanRaf.NakliyeMontaj.Entites.DTOs;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AysanRaf.NakliyeMontaj.app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingInstallationCustomerController : ControllerBase
    {
        private readonly Business.Services.IBaseService<ShippingInstallationCustomer> _service;
        private readonly IMapper _mapper;


        public ShippingInstallationCustomerController(Business.Services.IBaseService<ShippingInstallationCustomer> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(String id)
        {
            var product = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<ShippingInstallationCustomerForDetailDto>(product));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _service.GetAllAsync();
            return Ok(_mapper.Map<List<ShippingInstallationCustomerForDetailDto>>(products));
        }

        [HttpPost]
        public async Task<IActionResult> Add(ShippingInstallationCustomerForPostDto shippingInstallationCustomerForPostDto)
        {
            var ppd = _mapper.Map<ShippingInstallationCustomer>(shippingInstallationCustomerForPostDto);
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
        public async Task<IActionResult> Update(String id, ShippingInstallationCustomerForUpdateDto ShippingInstallationCustomerForUpdateDto)
        {
            var product = await _service.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            var pud = _mapper.Map(ShippingInstallationCustomerForUpdateDto, product);
            await _service.UpdateAsync(pud);
            return Ok(pud);
        }
    }
}
