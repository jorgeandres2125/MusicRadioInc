using MusicRadioStore.Core.Contracts.Services;
using MusicRadioStore.Core.ViewModels;
using MusicRadioStore.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicRadioStore.WebUI.Models;

namespace MusicRadioStore.WebUI.Controllers
{
    [Authorize(Roles = "DirectorInventario")]
    public class AlbumSetsManagerController : Controller
    {
        private readonly IAlbumSetService albumSetService;
        private readonly ISongSetService songSetService;

        public AlbumSetsManagerController(IAlbumSetService _albumSetService, ISongSetService _songSetService)
        {
            albumSetService = _albumSetService;
            songSetService = _songSetService;
        }

        // GET: AlbumSetsManager
        public ActionResult Index()
        {

            AlbumSetsManagerIndexViewModel viewModel = new AlbumSetsManagerIndexViewModel()
            {
                AlbumSets = albumSetService.ListViewModel()
            };
            return View(viewModel);
        }
        #region CRUD Album
        public ActionResult CreateAlbum()
        {
            var modelView = new AlbumSetViewModel();
            return View(modelView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAlbum(AlbumSetViewModel albumSetViewModel, HttpPostedFileBase file) 
        {
            if (!ModelState.IsValid)
            {
                return View(albumSetViewModel);
            }
            else
            {
                if (file != null)
                {
                    var nameFile = long.Parse(DateTime.UtcNow.ToString("yyyyMMddHHmmssfff")).ToString();
                    albumSetViewModel.Image = nameFile + Path.GetExtension(file.FileName);
                    file.SaveAs(Server.MapPath("//Content//AlbumImages//") + albumSetViewModel.Image);
                    AlbumSet albumSet = new AlbumSet()
                    {
                        Name = albumSetViewModel.Name,
                        Image = albumSetViewModel.Image,
                        Price = decimal.Parse(albumSetViewModel.Price)
                    };
                    albumSetService.Insert(albumSet);
                    return RedirectToAction("Index");
                }
                else 
                {
                    ModelState.AddModelError("Image", "El Albúm debe tener una imagen");
                    return View(albumSetViewModel);
                }
            }
        }

        public ActionResult EditAlbum(int Id)
        {
            AlbumSet albumSet = albumSetService.Find(Id);
            if (albumSet == null)
            {
                return HttpNotFound();
            }
            else
            {
                var modelView = new AlbumSetViewModel()
                {
                    Id = albumSet.Id,
                    Name = albumSet.Name,
                    Image = albumSet.Image,
                    Price = albumSet.Price.ToString()
                };
                return View(modelView);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditAlbum(AlbumSetViewModel albumSetViewModel, HttpPostedFileBase file)
        {
            AlbumSet albumSetToEdit = albumSetService.Find(albumSetViewModel.Id);
            if (albumSetToEdit == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(albumSetViewModel);
                }
                else
                {
                    if (file != null)
                    {
                        var nameFile = long.Parse(DateTime.UtcNow.ToString("yyyyMMddHHmmssfff")).ToString();
                        albumSetViewModel.Image = nameFile + Path.GetExtension(file.FileName);
                        file.SaveAs(Server.MapPath("//Content//AlbumImages//") + albumSetViewModel.Image);
                        albumSetToEdit.Image = albumSetViewModel.Image;
                    }
                    albumSetToEdit.Name = albumSetViewModel.Name;
                    albumSetToEdit.Price = decimal.Parse(albumSetViewModel.Price);
                    albumSetService.Update(albumSetToEdit);
                    return RedirectToAction("Index");
                }
            }
        }
        #endregion

        #region CRUD Song
        public ActionResult CreateSong()
        {
            var modelView = new AlbumSetsManagerCreateSongViewModel()
            {
                SongSet = new SongSetViewModel(),
                AlbumSets = albumSetService.ListViewModel()
            };
            return View(modelView);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSong(AlbumSetsManagerCreateSongViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            else 
            {
                SongSetViewModel songSetViewModel = viewModel.SongSet;
                SongSet songSet = new SongSet()
                {
                    Name = songSetViewModel.Name,
                    AlbumSetId = songSetViewModel.AlbumSetId,
                    AlbumSet = songSetViewModel.AlbumSet
                };
                songSetService.Insert(songSet);
                return RedirectToAction("Index");
            }
        }
        #endregion
    }
}