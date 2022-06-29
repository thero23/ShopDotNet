using AutoMapper;
using InternetShop.Api.ViewModels.User;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InternetShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        protected readonly IMapper _mapper;

        public UserController(IUserService genericService, IMapper mapper)
        {
            _userService = genericService;
            _mapper = mapper;
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public async Task<IEnumerable<UserViewModel>> GetAll(CancellationToken ct)
        {
            var users = await _userService.GetAll(ct);
            return _mapper.Map<IEnumerable<UserViewModel>>(users);
        }

        [Authorize]
        [HttpGet("user/{id}")]
        public async Task<UserViewModel> GetById(string id, CancellationToken ct)
        {
            var result = await _userService.GetById(id, ct);
            return _mapper.Map<UserViewModel>(result);
        }

        [HttpPost]
        public async Task<UserViewModel> Post([FromBody] UserViewModel userViewModel, CancellationToken ct)
        {
            var user = await _userService.Add(_mapper.Map<User>(userViewModel), ct);
            return _mapper.Map<UserViewModel>(user);
        }

        [HttpPut("{id}")]
        public async Task<UserViewModel> Put(string id, [FromBody] UserViewModel userViewModel, CancellationToken ct)
        {
            var mappedObject = _mapper.Map<User>(userViewModel);
            mappedObject.Id = id;

            var result = await _userService.Update(mappedObject, ct);
            return _mapper.Map<UserViewModel>(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
