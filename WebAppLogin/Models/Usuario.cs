﻿namespace WebAppLogin.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
