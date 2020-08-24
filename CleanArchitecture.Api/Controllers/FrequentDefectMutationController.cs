using System.Threading.Tasks;
using CleanArchitecture.Application.FrequentDefect.Commands.CreateFrequentDefect;
using CleanArchitecture.Application.FrequentDefect.Commands.DeleteFrequentDefect;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.Api.Controllers
{
    public class FrequentDefectMutationController : ApiController
    {

        private readonly IMediator mediator;

        public FrequentDefectMutationController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<int>> CreateFrequentDefectsAsync(CreateFrequentDefectCommand createFrequentDefectCommand)
        {
            return await mediator.Send(createFrequentDefectCommand);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
             await Mediator.Send(new DeleteFrequentDefectCommand { Id = id });
            return Ok();
        }
    }
}
