using AutoMapper;
using NerdStore.Catalogo.Application.ViewModels;
using NerdStore.Catalogo.Domain;

namespace NerdStore.Catalogo.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        //perfil de mapeamento de  view model para domínio do automapper

        public ViewModelToDomainMappingProfile()
        {
            //para criar o perfil de domínio, o mesmo deve ser mapeado através do construtor
            CreateMap<CategoriaViewModel, Categoria>()
                .ConstructUsing(c => new Categoria(c.Nome, c.Codigo));

            CreateMap<ProdutoViewModel, Produto>()
                .ConstructUsing(p => new Produto(p.Nome, p.Descricao, p.Ativo,
                                        p.Valor, p.CategoriaId, p.DataCadastro,
                                        p.Imagem, new Dimensoes(p.Altura, p.Largura, p.Profundidade)));
        }
    }
}
