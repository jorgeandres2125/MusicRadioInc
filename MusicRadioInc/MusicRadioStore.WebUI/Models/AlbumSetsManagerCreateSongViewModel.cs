using MusicRadioStore.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicRadioStore.WebUI.Models
{
    public class AlbumSetsManagerCreateSongViewModel
    {
        public List<AlbumSetViewModel> AlbumSets { get; set; }
        public SongSetViewModel SongSet { get; set; }
    }
}