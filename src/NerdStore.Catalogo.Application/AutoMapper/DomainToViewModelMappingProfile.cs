using AutoMapper;
using NerdStore.Catalogo.Application.ViewModels;
using NerdStore.Catalogo.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Application.AutoMapper
{
    //perfil de mapeamento de domínio para view model do automapper
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            //mapeie categoria para categoria view model (copia de campos de um lado para o outro)
            CreateMap<Categoria, CategoriaViewModel>();

            //mapeamento de classe aninhada
            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(d => d.Largura, o => o.MapFrom(s => s.Dimensoes.Largura))
                .ForMember(d => d.Altura, o => o.MapFrom(s => s.Dimensoes.Altura))
                .ForMember(d => d.Profundidade, o => o.MapFrom(s => s.Dimensoes.Profundidade));
        }
    }
}
