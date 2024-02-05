using Microsoft.AspNetCore.Mvc;
using SwifLanches.Repositories.Interfaces;
using SwifLanches.ViewModels;

namespace SwifLanches.Controllers
{
    public class LancheController : Controller
    {
        public readonly ILanchesRepository _lancheRepository;

        public LancheController(ILanchesRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            var lanchesListViewModel = new LancheListViewModel();

            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lanchesListViewModel);
        }
    }
}
