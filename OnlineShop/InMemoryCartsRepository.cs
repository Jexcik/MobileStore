using OnlineShop.Models;

namespace OnlineShop
{
    public class InMemoryCartsRepository : ICartsRepository
    {
        private List<Cart> carts = new List<Cart>();


        public Cart TryGetByUserId(string userId)
        {
            return carts.FirstOrDefault(x => x.UserId == userId);
        }
        public void Add(Product product, string userId)
        {
            var existingCart = TryGetByUserId(userId);
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
            var existingCart = TryGetByUserId(userId);
            var existingCartItem = existingCart.Items.FirstOrDefault(x=>x.Product.Id == productId);
            existingCartItem.Amount--;
            if (existingCartItem.Amount==0)
            {
                existingCart.Items.Remove(existingCartItem);
            }
            if(existingCart.Items.Count == 0) 
            {
                carts.Remove(existingCart);
            }
        }

        public void Clear()
        {
            carts.Clear();
        }
    }
}