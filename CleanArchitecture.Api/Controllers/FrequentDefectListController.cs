using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchitecture.Application.FrequentDefect.Queries.GetFrequentDefect;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    public class FrequentDefectListController : ApiController
    {
        private readonly IMediator mediator;

        public FrequentDefectListController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task< ActionResult<List<FrequentDefectDto>>> GetFrequentDefects()
        {
           return await mediator.Send(new GetFrequentDefectQuery());
        }
    }
}
