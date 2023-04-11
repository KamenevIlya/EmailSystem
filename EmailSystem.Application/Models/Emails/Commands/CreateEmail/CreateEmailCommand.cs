using System;
using MediatR;

namespace EmailSystem.Application.Models.Emails.Commands.CreateEmail
{
    public class CreateEmailCommand : IRequest<Guid>
    {
        public string Name { get; set; }

        public Guid RecipientId { get; set; }

        public Guid SenderId { get; set; }

        public string Content { get; set; }
    }
}