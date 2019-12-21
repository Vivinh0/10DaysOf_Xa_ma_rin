using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tuto10DaysXamarin.Modelos
{
    class EntradaDiario
    {
        [PrimaryKey, AutoIncrement] //Añadir using SQLite;
        public int id { get; set; }
        [MaxLength(50)]
        public string titulo { get; set; }
        public string contenido { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
