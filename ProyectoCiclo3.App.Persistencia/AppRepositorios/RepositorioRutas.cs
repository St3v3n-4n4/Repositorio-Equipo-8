using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        private readonly AppContext _appContext = new AppContext();   
        public Rutas Ruta {get;set;}
        public Estaciones Estacion {get;set;}


        public IEnumerable<Rutas> GetAll()
        {
        return _appContext.Rutas.Include(e => e.origen)
                                .Include(e => e.destino);

        }

        public Rutas GetWithId(int id){
            return _appContext.Rutas.Find(id);
        }

        public Rutas Create(int origen, int destino, int tiempo_estimado)
        {
            var newRuta = new Rutas();
            newRuta.origen = _appContext.Estaciones.Find(origen);;
            newRuta.destino = _appContext.Estaciones.Find(destino);           
            newRuta.tiempo_estimado = tiempo_estimado;

            var addRuta = _appContext.Rutas.Add(newRuta);
            _appContext.SaveChanges();
            return addRuta.Entity;
        }

        public void Delete(int id)
        {
        var ruta = _appContext.Rutas.Find(id);
            if (ruta != null){
                _appContext.Rutas.Remove(ruta);
                _appContext.SaveChanges();            
            }
        }

        public Rutas Update(int id, int origen, int destino, int tiempo_estimado)
        {            
            var ruta = _appContext.Rutas.Find(id);;
            if(ruta != null){
                ruta.origen = _appContext.Estaciones.Find(origen);
                ruta.destino = _appContext.Estaciones.Find(destino);
                ruta.tiempo_estimado = tiempo_estimado;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return ruta;
        }
    }
}