using ControleEstoque.Domain.Enums;

namespace ControleEstoque.Domain.Models.DataModel
{
    public class CategoriaViewModel
    {
        public string Name { get; set; }
        public CategoryStatusEnum Status { get; set; }
    }
}
