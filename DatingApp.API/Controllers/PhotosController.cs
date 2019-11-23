using System.Threading.Tasks;
using AutoMapper;
using CloudinaryDotNet;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DatingApp.API.Controllers
{
    public class PhotosController : ControllerBase
    {
        private readonly IDatingRepository _repon;
        private readonly IMapper _mapper;
        private Cloudinary _cloudinary;

        private readonly IOptions<CloudinarySettings> _cloundinaryConfig;
        public PhotosController(IDatingRepository repon, IMapper mapper, IOptions<CloudinarySettings> cloundinaryConfig)
        {
            _mapper = mapper;
            _repon = repon;
            _cloundinaryConfig = cloundinaryConfig;

            Account acc = new Account(_cloundinaryConfig.Value.CloudName,
                _cloundinaryConfig.Value.ApiKey,
                _cloundinaryConfig.Value.ApiSecret);

            _cloudinary = new Cloudinary(acc);
        }

        [HttpPost]
        public async Task<IActionResult> AddPhotoForUser(int userId, PhotoForCrationDto photoForCration)
        {
            var userFromRepo = await _repon.GetUser(userId);
            var file = PhotoForCrationDto.File;
        }
    }
}