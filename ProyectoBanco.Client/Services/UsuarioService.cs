using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using ProyectoBanco.Client.Models;

namespace ProyectoBanco.Client.Services
{
    public class UsuarioService
    {
        private readonly HttpClient httpClient;
        public UsuarioService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<Usuario> GetUserDataAsync()
        {
            var userData = await httpClient.GetFromJsonAsync<Usuario>("api/usuario");
            return userData ?? new Usuario();
        }
    }
}