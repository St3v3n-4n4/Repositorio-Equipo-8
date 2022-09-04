using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class DetailsEstacionModel : PageModel
    {
       private readonly RepositorioEstaciones repositorioEstaciones;
        public Estaciones Estacion {get;set;}
 
        public DetailsEstacionModel(RepositorioEstaciones repositorioEstaciones)
       {
            this.repositorioEstaciones=repositorioEstaciones;
       }
 
        public IActionResult OnGet(int estacionId)
        {
            Estacion=repositorioEstaciones.GetWithId(estacionId);
            return Page();
 
        }
    }
}