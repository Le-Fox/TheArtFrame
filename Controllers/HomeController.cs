using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ArtFrame.Models;
using ArtFrame.Repository;

namespace ArtFrame.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IObjectRepository _objectRepository;

    public HomeController(ILogger<HomeController> logger, IObjectRepository objectRepository)
    {
        _logger = logger;
        _objectRepository = objectRepository;
    }

    public  async Task<IActionResult> Index()
    {

           var objects = await _objectRepository.getObjects();
           var validObjects = await _objectRepository.getValidObject(objects);
             //I need to find a way to load, git aff validate and update the list at the same time
            var listOfObjects = await _objectRepository.getObjectList(validObjects);
            var validObject = await _objectRepository.getObject(500);
        
        return View(validObject);
        //return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
