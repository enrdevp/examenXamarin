﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace examen
{
    class Cliente
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Foto { get; set; }
    }
}
