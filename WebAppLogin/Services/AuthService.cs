using Microsoft.EntityFrameworkCore;
using WebAppLogin.Data;
using WebAppLogin.Models;

namespace WebAppLogin.Services
{
    public class AuthService
    {
        private readonly ApplicationDbContext _context;

        public AuthService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> LoginAsync(string nombreUsuario, string contraseña)
        {
            return await _context.Usuarios
                .FirstOrDefaultAsync(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña);
        }
    }
}
