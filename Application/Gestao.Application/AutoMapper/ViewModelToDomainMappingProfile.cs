using AutoMapper;
using Gestao.Application.ViewModels;
using Gestao.Domain.Entities;

namespace Gestao.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected void Configure()
        {
            CreateMap<CidadesViewModel, Cidade>();
            CreateMap<TipoPessoasViewModel, TipoPessoa>();
            CreateMap<PessoasViewModel, Pessoa>();
        }
    }
}