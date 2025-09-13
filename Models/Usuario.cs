using System;
using System.Collections.Generic;

namespace proyecto_Famular_Lezcano.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public string Rol { get; set; } = null!;

    public int? IdPelicula { get; set; }

    public int? Estado { get; set; }

    public virtual Pelicula? IdPeliculaNavigation { get; set; }
}
