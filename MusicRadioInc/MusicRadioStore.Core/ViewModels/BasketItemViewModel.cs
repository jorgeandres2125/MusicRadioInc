﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.ViewModels
{
    public class BasketItemViewModel
    {
        public string Id { get; set; }
        public int Quanity { get; set; }
        public string AlbumName { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
