using CursoAPI.Controllers;
using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CursoTest
{
    public class CategoriasControllerTest
    {
        //create mocking objects
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;
     
        public CategoriasControllerTest()
        {
            //inicializes mocking objects
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Context>();
            _categoria = new Categoria { Id = 1, Descricao = "Teste de Categoria"};

            //shows to xunit what findAsync do
            //shows to xunit what .categorias is usign mockset
            _mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object);
            _mockContext.Setup(m => m.Categorias.FindAsync(1))
            .ReturnsAsync(_categoria);

        }

        //tests get methos of categorias
        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object); //pass the context mock to get all methods disponible in CategoriasController

            await service.GetCategoria(1); //do a get categoria passig id 1

            _mockSet.Verify(m => m.FindAsync(1), //uses mockset to verify if findasync was executed one time
                Times.Once);
        }
    }
}
