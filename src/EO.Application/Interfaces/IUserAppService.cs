﻿using System.Threading.Tasks;
using EO.Application.ViewModels.InputModels.Usuario;

namespace EO.Application.Interfaces
{
    public interface IUserAppService
    {
        Task<EditarUsuarioViewModel> ObterUsuarioParaEdicao(int id);

        Task AtualizarUsuario(EditarUsuarioViewModel model);
    }
}