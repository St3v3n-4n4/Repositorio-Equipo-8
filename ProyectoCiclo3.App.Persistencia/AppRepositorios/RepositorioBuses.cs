using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioBuses
    {
        List<Buses> buses;
 
    public RepositorioBuses()
        {
            buses= new List<Buses>()
            {
                new Buses{id=1,marca="Bolivariano",modelo= 2000,kilometraje= 15000,numero_de_asientos= 30,placa= "56z8Pt"},
                new Buses{id=2,marca="Expreso Brasilia",modelo= 2005,kilometraje= 10000,numero_de_asientos= 55,placa= "gP3P53"},
                new Buses{id=3,marca="Berlinas del Fonce",modelo= 2004,kilometraje= 50000,numero_de_asientos= 90,placa= "401hVd"}
            };
        }
 
        public IEnumerable<Buses> GetAll()
        {
            return buses;
        }
 
        public Buses GetWithId(int id){
            return buses.SingleOrDefault(e => e.id == id);
        }
    }
}