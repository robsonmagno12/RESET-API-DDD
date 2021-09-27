using ResetApiModeloDDD.Application.Dtos;
using ResetApiModeloDDD.Application.Interfaces.Mapper;
using ResetApiModeloDDD.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace ResetApiModeloDDD.Application.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        //fazendo Mapper manualmente
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };

            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(p => new ProdutoDto
            {
                Id = p.Id,
                Nome = p.Nome,
                Valor = p.Valor
            });
            return dto;
        }
    }
}