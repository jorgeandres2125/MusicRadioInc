using MusicRadioStore.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MusicRadioStore.Core.Contracts.Services
{
    public interface IBasketService
    {
        void AddToBasket(HttpContextBase httpContext, int albumId);
        void RemoveFromBasket(HttpContextBase httpContext, int albumId);
        List<BasketItemViewModel> GetBasketItems(HttpContextBase httpContext);
        BasketSummaryViewModel GetBasketSummary(HttpContextBase httpContext);
        void ClearBasket(HttpContextBase httpContext);
    }
}
