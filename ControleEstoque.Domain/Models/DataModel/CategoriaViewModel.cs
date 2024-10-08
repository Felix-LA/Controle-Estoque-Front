﻿using ControleEstoque.Domain.Enums;

namespace ControleEstoque.Domain.Models.DataModel
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StatusEnum Status { get; set; }
    }
}
