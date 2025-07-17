using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDBagOfHolding.AppHost.Api
{
    [Route("api/containerTypes")]
    [ApiController]
    public class cContainerTypesController : ControllerBase
    {

        [HttpGet()]
        public async Task<HttpResponse> GetAll()
        {

        }

        [HttpGet("{id}")]
        public async Task<HttpResponse> GetById(long id)
        {

        }
    }
}
