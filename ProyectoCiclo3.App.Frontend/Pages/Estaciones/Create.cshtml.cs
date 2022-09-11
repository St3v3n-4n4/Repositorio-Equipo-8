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
    public class FormEstacionesModel : PageModel
    {   
        private readonly RepositorioEstaciones repositorioEstaciones;
        [BindProperty]
        public Estaciones Estacion {get;set;}
 
        public FormEstacionesModel(RepositorioEstaciones repositorioEstaciones)
        {
            this.repositorioEstaciones=repositorioEstaciones;
        }
 
        public void OnGet()
        {   
        }
 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            repositorioEstaciones.Create(Estacion);
            return RedirectToPage("./List");
        }
    }
}