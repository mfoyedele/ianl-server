using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using WebApi.Dtos;
using WebApi.Data;
using Microsoft.AspNetCore.JsonPatch;
using WebApi.Models.Admin;
using WebApi.Services;

namespace WebApi.Controllers
{
    // [ServiceFilter(typeof(TestAsyncActionFilter))]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminService _adminService;
        private readonly IAdminRepo _repo;
        private readonly IMapper _mapper;

        public AdminController(IAdminRepo repo, IMapper mapper, IAdminService adminService)
        {
            _repo = repo;
            _mapper = mapper;
            _adminService = adminService;

        }

        [HttpGet]
        public async Task<ActionResult<AdminReadDto>> GetAdminAll([FromHeader] bool flipSwitch)
        {
            var admins = await _adminService.GetAdminAll();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"--> The flip switch is: {flipSwitch}");
            Console.ResetColor();

            return Ok(_mapper.Map<AdminReadDto>(admins));
        }

        [HttpGet("{id}", Name = "GetAdminById")]
        public async Task<ActionResult<AdminReadDto>> GetAdminById(int id)
        {
            var adminModel = await _adminService.GetAdminById(id);
            if (adminModel != null)
            {
                return Ok(_mapper.Map<AdminReadDto>(adminModel));
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<AdminReadDto>> CreateAdmin(AdminCreateDto admCreateDto)
        {
            var adminModel = _mapper.Map<AdminModel>(admCreateDto);
            await _repo.CreateAdmin(adminModel);
            await _repo.SaveChanges();

            var admReadDto = _mapper.Map<AdminReadDto>(adminModel);
            
            Console.WriteLine($"Model State is: {ModelState.IsValid}");

            return CreatedAtRoute(nameof(GetAdminById), new { Id = admReadDto.Id}, admReadDto);
        }

        //PATCH api/v1/admins/{id}
        [HttpPatch("{id}")]
        public async Task<ActionResult> PartialCommandUpdate(int id, JsonPatchDocument<AdminUpdateDto> patchDoc)
        {
            var adminModelFromRepo = await _adminService.GetAdminById(id);
            if(adminModelFromRepo == null)
            {
                return NotFound();
            }

            var adminToPatch = _mapper.Map<AdminUpdateDto>(adminModelFromRepo);
            patchDoc.ApplyTo(adminToPatch, ModelState);

            if(!TryValidateModel(adminToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(adminToPatch, adminModelFromRepo);

            //await _repo.UpdateAdmin(adminModelFromRepo);

            await _repo.SaveChanges();

            return NoContent();
        }

        //PUT api/admins/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAdmin(int id, AdminUpdateDto adminUpdateDto)
        {
            var adminModelFromRepo = await _adminService.GetAdminById(id);
            if(adminModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(adminUpdateDto, adminModelFromRepo);

            await _repo.SaveChanges();

            return NoContent();
        }

         //DELETE api/commands/{id}
        [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _adminService.Delete(id);
        return Ok(new { message = "User deleted" });
    }
    }
}