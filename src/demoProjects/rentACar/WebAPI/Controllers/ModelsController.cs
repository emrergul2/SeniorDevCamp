using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Models.Models;
using Application.Features.Models.Queries.GetListModel;
using Application.Features.Models.Queries.GetListModelDynamic;
using Core.Application.Requests;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller][action]")]
    public class ModelsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListModelQuery getListModelQuery = new GetListModelQuery { PageRequest = pageRequest };
            ModelListModel result = await Mediator.Send(getListModelQuery);
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] Dynamic dynamic)
        {
            GetListModelByDynamicQuery getListModelByDynamicQuery = new GetListModelByDynamicQuery { PageRequest = pageRequest, Dynamic = dynamic };
            ModelListModel result = await Mediator.Send(getListModelByDynamicQuery);
            return Ok(result);
        }
    }
}