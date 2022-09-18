using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones;
        private readonly AppContext _appContext = new AppContext();
 
        public IEnumerable<Estaciones> GetAll()
        {
            return _appContext.Estaciones;
        }
 
        public Estaciones GetWithId(int id){
            return _appContext.Estaciones.Find(id);
        }
 
        public Estaciones Update(Estaciones newEstacion){
            var estacion = _appContext.Estaciones.Find(newEstacion.id);;
            if(estacion != null){
                estacion.nombre = newEstacion.nombre;
                estacion.direccion = newEstacion.direccion;
                estacion.coord_x = newEstacion.coord_x;
                estacion.coord_y = newEstacion.coord_y;
                estacion.tipo = newEstacion.tipo;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return estacion;
        }
 
        public Estaciones Create(Estaciones newEstacion)
        {
            var addEstacion = _appContext.Estaciones.Add(newEstacion);
            //Guardar en base de datos
            _appContext.SaveChanges();
            return addEstacion.Entity;
        }
 
        public Estaciones Delete(int id)
        {
            var estacion = _appContext.Estaciones.Find(id);
            if (estacion != null){
                _appContext.Estaciones.Remove(estacion);
                //Guardar en base de datos
                _appContext.SaveChanges();
            }
            return null;
        }
 
    }
}