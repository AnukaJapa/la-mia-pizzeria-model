using La_Mia_Pizzeria_1.Models;
using La_Mia_Pizzeria_1.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace La_Mia_Pizzeria_1.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> listaDellaPizza = PizzaData.GetPizzas();
        ;

            return View("Index", listaDellaPizza);
        }

        public IActionResult Details(int id)
        {
            List<Pizza> listaDellaPizza = PizzaData.GetPizzas();

            foreach (Pizza pizza in listaDellaPizza)
            {
                if (pizza.Id == id)
                {
                    return View(pizza);
                }
            }

            return NotFound("Il post con l'id cercato non esiste!");
        }
    }
}
