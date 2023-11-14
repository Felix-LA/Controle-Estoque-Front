
using ControleEstoque.Domain.Enums;

namespace ControleEstoque.Domain.Models.DataModel
{
    public class MarcaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StatusEnum Status { get; set; }
        public Byte Logo { get; set; }
    }
}
