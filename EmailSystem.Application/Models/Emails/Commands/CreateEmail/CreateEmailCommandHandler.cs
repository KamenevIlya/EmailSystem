using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using EmailSystem.Application.Interfaces;
using EmailSystem.Domain;

namespace EmailSystem.Application.Models.Emails.Commands.CreateEmail
{
    public class CreateEmailCommandHandler : IRequestHandler<CreateEmailCommand, Guid>
    {
        private readonly IEmailSystemDbContext _dbContext;
        public CreateEmailCommandHandler(IEmailSystemDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task<Guid> Handle(CreateEmailCommand request, CancellationToken cancellationToken)
        {

            var email = new Email
            {
                Id = Guid.NewGuid(),
                SentOn = DateTime.UtcNow,
                SenderId = request.SenderId,
                RecipientId = request.RecipientId,
                Name = request.Name,
                Content = request.Content
            };

            await _dbContext.Emails.AddAsync(email, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return email.Id;
        }
    }
}
