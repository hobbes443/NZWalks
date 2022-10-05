using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper) {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllRegions() {

            //var regions = new List<Region>() {
            //    new Region {
            //        Id = Guid.NewGuid(),
            //        Name = "Wellington",
            //        Code = "WLG",
            //        Area = 223255,
            //        Lat = -1.3,
            //        Long = 299.3,
            //        Population = 100000
            //    },
            //    new Region {
            //        Id = Guid.NewGuid(),
            //        Name = "Auckland",
            //        Code = "AUCK",
            //        Area = 223255,
            //        Lat = -1.3,
            //        Long = 299.3,
            //        Population = 100000
            //    }
            //};


            var regions2 = await regionRepository.GetAllAsync();

            //// return DTO regions
            //var regionsDTO = new List<Models.DTO.Region>();

            //regions2.ToList().ForEach(region => {
            //    var regionDTO = new Models.DTO.Region() { 
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population
            //    };

            //    regionsDTO.Add(regionDTO);
            //});
            
            var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions2);

            return Ok(regionsDTO);
        }


    }
}
