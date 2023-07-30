using OnlineShop.Models;

namespace OnlineShop
{
    public class InMemoryCartsRepository : ICartsRepository
    {
        private List<Cart> carts = new List<Cart>();


        public Cart TruGetByUserId(string userId)
        {
            return carts.FirstOrDefault(x => x.UserId == userId);
        }
        public void Add(Product product, string userId)
        {
            var existingCart = TruGetByUserId(userId);
            if (existingCart == null)
            {
                var newCart = new Cart
                {
                    UserId = userId,
                };
                newCart.Items = new List<CartItem>
                {
                    new CartItem
                    {
                        Amount=1,
                        Product=product,
                    }
                };
                carts.Add(newCart);
            }
            else
            {
                var existingCartItem = existingCart.Items.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingCartItem != null)
                {
                    existingCartItem.Amount += 1;
                }
                else
                {
                    existingCart.Items.Add(new CartItem
                    {
                        Amount = 1,
                        Product = product,
                    });
                }
            }
        }

        public void DecreaseAmount(int productId, string userId)
        {
            var existingCart = TruGetByUserId(userId); //получаем карзину по Id
            var existingCartItem = existingCart?.Items?.FirstOrDefault(x => x.Product.Id == productId);
            if (existingCartItem == null)
            {
                return;
            }
            existingCartItem.Amount -= 1;
            if (existingCartItem.Amount == 0)
            {
                existingCart.Items.Remove(existingCartItem);
            }

        }
    }
}