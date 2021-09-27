using ResetApiModeloDDD.Application.Dtos;
using ResetApiModeloDDD.Application.Interfaces;
using ResetApiModeloDDD.Application.Interfaces.Mapper;
using ResetApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace ResetApiModeloDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServicesProduto servicesProduto;
        private readonly IMapperProduto mapperProduto;

        public ApplicationServiceProduto(IServicesProduto servicesProduto, IMapperProduto mapperProduto)
        {
            this.servicesProduto = servicesProduto;
            this.mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            servicesProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = servicesProduto.GetAll();
            return mapperProduto.MapperListProdutosDto(produtos);
        }

        public ProdutoDto GetById(int id)
        {
            var produto = servicesProduto.GetById(id);
            return mapperProduto.MapperEntityToDto(produto);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            servicesProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            servicesProduto.Update(produto);
        }
    }
}