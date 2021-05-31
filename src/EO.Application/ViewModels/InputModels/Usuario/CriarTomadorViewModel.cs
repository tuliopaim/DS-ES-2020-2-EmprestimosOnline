﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EO.Application.ViewModels.InputModels.Usuario
{
    public class CriarTomadorViewModel
    {
        [Required(ErrorMessage = "{0} obrigatório(a)")]
        [DisplayName("Renda Mensal")]
        [Range(500, double.MaxValue, ErrorMessage = "Maior ou igual a {1}")]
        public decimal RendaMensal { get; set; }

        public CriarEnderecoViewModel Endereco { get; set; }
    }
}