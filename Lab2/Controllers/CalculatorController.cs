using Lab2.Models;
using Microsoft.AspNetCore.Mvc;


/*
1. użytkownik klika na link w menu aplikacji prowadzący do formularza, który kieruje do metody akcji Form w klasie CalculatorCopntroller.
2. Metoda Form zwraca widok formularza.
3. Po wypełnieniu formularza użytkownik go zatwierdza przyciskiem Oblicz, który generuje żądanie zawierające dane z formularza.
4. Żądanie trafia do metody akcji Result kontrolera CalculatorController
5. metoda Result wykonuje obliczenia na podstawie danych i zwraca widok z wynikami obliczeń
 */

namespace Lab2.Controllers
{
    public class CalculatorController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Result([FromForm] Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
    }
}
