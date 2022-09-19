using System;
using System.Collections.Generic;  // prueba //
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class FormBusesModel : PageModel
    {
        private readonly RepositorioBuses repositorioBuses;
        [BindProperty]
        public Buses Buse {get;set;}
 
        public FormBusesModel(RepositorioBuses repositorioBuses)
        {
            this.repositorioBuses=repositorioBuses;
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
            repositorioBuses.Create(Buse);
            return RedirectToPage("./List");
        }
    }
}