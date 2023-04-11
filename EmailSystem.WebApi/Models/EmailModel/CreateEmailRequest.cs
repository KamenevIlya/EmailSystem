using System;
using AutoMapper;
using EmailSystem.Application.Common.Mappings;
using EmailSystem.Application.Models.Emails.Commands.CreateEmail;

namespace EmailSystem.WebApi.Models.EmailModel
{
    public class CreateEmailRequest : IMapWith<CreateEmailCommand>
    {
        public string Name { get; set; }

        public Guid RecipientId { get; set; }

        public Guid SenderId { get; set; }

        public string Content { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateEmailRequest, CreateEmailCommand>()
                .ForMember(emailCommand => emailCommand.Name,
                    opt => opt.MapFrom(request => request.Name))
                .ForMember(emailCommand => emailCommand.RecipientId,
                    opt => opt.MapFrom(request => request.RecipientId))
                .ForMember(emailCommand => emailCommand.SenderId,
                    opt => opt.MapFrom(request => request.SenderId))
                .ForMember(emailCommand => emailCommand.Content,
                    opt => opt.MapFrom(request => request.Content));
        }
    }
}