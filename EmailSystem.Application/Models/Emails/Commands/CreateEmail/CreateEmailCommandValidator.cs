using System;
using FluentValidation;

namespace EmailSystem.Application.Models.Emails.Commands.CreateEmail
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateEmailCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(x => x.SenderId).NotEqual(Guid.Empty);
            RuleFor(x => x.RecipientId).NotNull();
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Content).NotNull().NotEmpty();
        }
    }
}