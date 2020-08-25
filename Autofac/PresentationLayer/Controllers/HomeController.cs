using AutoMapper;
using BL.Interfaces;
using BL.Managers;
using BL.Model;
using PresentationLayer.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private IAnimalsManager _animalManager;
        private readonly Mapper _mapper;
        public HomeController() { }
        public HomeController(IAnimalsManager animalsManager)
        {
            _animalManager = animalsManager;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalModel, AnimalViewModel>();
                cfg.CreateMap<HouseModel, HouseViewModel>();

            });
            _mapper = new Mapper(config);
        }
        public ActionResult Index()
        {

            var result = new GetAllAnimalsViewModel();
            var getAll = _animalManager.GetAllAnimals();
            result.Animals = _mapper.Map<List<AnimalViewModel>>(getAll);

            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}