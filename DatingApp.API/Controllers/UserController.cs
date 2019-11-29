

using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IDatingRepository _repon;
        private readonly IMapper _mapper;
        public UserController(IDatingRepository repon, IMapper mapper)
        {
            _mapper = mapper;
            _repon = repon;
        }


        [HttpGet]
        public async Task<IActionResult> GetUsers([FromQuery]UserParmas userParmas)
        {
            var users = await _repon.GetUsers(userParmas);
            var userToReturn = _mapper.Map<IEnumerable<UserForListDto>>(users);
            Response.AddPagination(users.CurrentPage, users.PageSize, users.TotalCount, users.TotalPages);

            return Ok(userToReturn);
        }


        [HttpGet("{id}", Name = "GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repon.GetUser(id);
            var userToReturn = _mapper.Map<UserForDetailedDto>(user);
            return Ok(userToReturn);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserForUpdateDto userForUpdate)
        {
            var userFormRepo = await _repon.GetUser(id);

            _mapper.Map(userForUpdate, userFormRepo);

            if (await _repon.SaveAll())
                return NoContent();

            throw new Exception($"Update user {id} faild  on save");
        }

        [HttpPut("delete/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var userDelete = await _repon.GetUser(id);
            _repon.Delete(userDelete);
            if (await _repon.SaveAll())
                return NoContent();
            throw new Exception($"Update user  faild  on save");
        }
    }
}