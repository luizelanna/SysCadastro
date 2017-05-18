using AutoMapper;
using Gestao.Application.ViewModels;
using Gestao.Domain.Entities;

namespace Gestao.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected void Configure()
        {
            CreateMap<Cidade, CidadesViewModel>();
            CreateMap<TipoPessoa, TipoPessoasViewModel>();
            CreateMap<Pessoa, PessoasViewModel>();

        }
    }
}

