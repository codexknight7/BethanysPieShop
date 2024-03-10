using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public IShoppingCart ShoppingCart { get; }
        public decimal ShoppingCartTotal {  get; }

        public ShoppingCartViewModel(IShoppingCart shopingCart, decimal shoppingCartTotal)
        {
            ShoppingCart = shopingCart;
            ShoppingCartTotal = shoppingCartTotal; 
        }

    }
}
