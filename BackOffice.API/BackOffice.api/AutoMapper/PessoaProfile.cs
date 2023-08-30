using AutoMapper;
using BackOffice.Doamin.Entities;
using BackOffice.Domain.DTO;

namespace BackOffice.API.AutoMapper
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<Pessoa, PessoaDTO>().ReverseMap();
        }
    }
}
