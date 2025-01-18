using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Pokemon
    {
        private Elemento tipo = new Elemento();
        private Elemento debilidad = new Elemento();
        
        public int Id { get; set; }
        //Voy a usar anotesion jaja no se como se escribe
        [DisplayName("Número")]
        public int Numero {  get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [DisplayName("Url de la Imagen")]
        public string UrlImagen { get; set; }
        public Elemento Tipo {
            get {  return tipo; }
            set { tipo = value; }
        }
        public Elemento Debilidad { 
            get { return debilidad; } 
            set { debilidad = value; } 
        }
    }
}
