using System;
using System.Threading.Tasks;
using AutoMapper;
using EmailSystem.Application.Models.Emails.Commands.CreateEmail;
using Microsoft.AspNetCore.Mvc;
using EmailSystem.WebApi.Models.EmailModel;
using Microsoft.AspNetCore.Http;

namespace EmailSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : BaseController
    {
        private readonly IMapper _mapper;

        public EmailController(IMapper mapper) => _mapper = mapper;

        /// <summary>
        /// Создать письмо
        /// </summary>
        /// <param name="request"> Тело запроса </param>
        /// <returns> Id созданного письма </returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<Guid>> CreateOrder([FromBody] CreateEmailRequest request)
        {
            var command = _mapper.Map<CreateEmailCommand>(request);
            var emailId = await Mediator.Send(command);
            return Ok(emailId);
        }
    }
}
