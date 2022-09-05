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
    public class DetailsRutasModel : PageModel
    {
       private readonly RepositorioRutas repositorioRutas;
        public Rutas Rutas {get;set;}
 
        public DetailsRutasModel(RepositorioRutas repositorioRutas)
       {
            this.repositorioRutas=repositorioRutas;
       }
 
        public IActionResult OnGet(int rutasId)
        {
            Rutas=repositorioRutas.GetWithId(rutasId);
            return Page();
 
        }
    }
}