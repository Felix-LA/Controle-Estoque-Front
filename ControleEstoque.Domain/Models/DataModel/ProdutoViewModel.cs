
namespace ControleEstoque.Domain.Models.DataModel
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public CategoriaViewModel Categoria { get; set; }
        public string? Description { get; set; }

    }
}
