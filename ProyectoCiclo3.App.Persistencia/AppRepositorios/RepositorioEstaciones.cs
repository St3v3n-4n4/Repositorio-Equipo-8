using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones;
 
    public RepositorioEstaciones()
        {
            estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1,nombre="Centro",direccion= "cra 90",coord_x= "14.4545",coord_y= "4.1254545",tipo= "Principal"},
                new Estaciones{id=2,nombre="Estadio",direccion= "calle 70",coord_x= "9.05454",coord_y= "16.14587",tipo= "Segundaria"},
                new Estaciones{id=3,nombre="Terminal",direccion= "Carrera 54",coord_x= "15.457878",coord_y= "24.457878",tipo= "Principal"}
            };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;
        }
 
        public Estaciones GetWithId(int id){
            return estaciones.SingleOrDefault(e => e.id == id);
        }

        public Estaciones Update(Estaciones newEstacion){
            var estacion= estaciones.SingleOrDefault(b => b.id == newEstacion.id);
            if(estacion != null){
                estacion.nombre = newEstacion.nombre;
                estacion.direccion = newEstacion.direccion;
                estacion.coord_x = newEstacion.coord_x;
                estacion.coord_y = newEstacion.coord_y;
                estacion.tipo = newEstacion.tipo;
            }
        return estacion;

        }
        
        public Estaciones Create(Estaciones newEstacion)
        {
           if(estaciones.Count > 0){
                newEstacion.id = estaciones.Max(e => e.id) +1; 
            }else{
               newEstacion.id = 1; 
            }
           estaciones.Add(newEstacion);
           return newEstacion;
        }

        public Estaciones Delete(int id)
        {
            var estacion= estaciones.SingleOrDefault(e => e.id == id);
            estaciones.Remove(estacion);
            return estacion;
        }
    }
}