﻿using Microsoft.EntityFrameworkCore;
using Musiceo.Data.models;
using Musiceo.Data.models.Artistas;

namespace Musiceo.Data {
    public class Museodbcontext : DbContext

    {
        DbSet<Artista> Artistas { get; set; }
        DbSet<Juego> Juegos { get; set; }


    }
}