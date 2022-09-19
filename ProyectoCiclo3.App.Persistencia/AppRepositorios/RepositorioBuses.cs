using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioBuses
    {
        List<Buses> buses;
        private readonly AppContext _appContext = new AppContext();
 
        public IEnumerable<Buses> GetAll()
        {
            return _appContext.Buses;
        }
 
        public Buses GetWithId(int id){
            return _appContext.Buses.Find(id);
        }
 
        public Buses Update(Buses newBuses){
            var buse = _appContext.Buses.Find(newBuses.id);;
            if(buse != null){
                buse.marca = newBuses.marca;
                buse.modelo = newBuses.modelo;
                buse.kilometraje = newBuses.kilometraje;
                buse.numero_de_asientos = newBuses.numero_de_asientos;
                buse.placa = newBuses.placa;
                //Guardar en base de datos
                _appContext.SaveChanges();
            }
        return buse;
        }
 
        public Buses Create(Buses newBuses)
        {
            var addbuses = _appContext.Buses.Add(newBuses);
            //Guardar en base de datos
            _appContext.SaveChanges();
            return addbuses.Entity;
        }
 
        public Buses Delete(int id)
        {
            var buses = _appContext.Buses.Find(id);
            if (buses != null){
                _appContext.Buses.Remove(buses);
                //Guardar en base de datos
                _appContext.SaveChanges();
            }
            return null;
        }
    }
}