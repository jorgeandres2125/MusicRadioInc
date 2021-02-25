using MusicRadioStore.Core.Contracts.Services;
using MusicRadioStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicRadioStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlbumSetService albumSetService;
        
        public HomeController(IAlbumSetService _albumSetService)
        {
            albumSetService = _albumSetService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Cliente")]
        public ActionResult AlbumStore()
        {
            AlbumStoreViewModel viewModel = new AlbumStoreViewModel()
            {
                AlbumSets = albumSetService.ListViewModel()
            };
            return View(viewModel);
        }

    }
}