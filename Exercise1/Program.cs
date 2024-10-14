using Exercise1;
using Exercise1.Service;

    internal class Program
    {
        static void Main(string[] args)
        {
            Distance distance = Distance.New(100);
            Console.WriteLine($"Distance {distance.DisplayASKilomiters()}");
            Console.WriteLine($"Distance {distance.DisplayASMiles()}");

            try
            {
                License license = new("2024/02/15/1");
                Console.WriteLine($"License: {license}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
         

            UserService userService = new();
            userService.Add(new User { Email = "test@test.com", Name = "Test", Password = "password" });
            userService.Get(1);
            ProductService productService = new();
            productService.Add(new Product { Name = "Product#1", Category = "Category#1", Description = "Description" });
            productService.Get(1);
            CartService cartService = new();
            cartService.Add(new Cart { ProductId = 1, UserId = 1 });
            cartService.Get(1);
        }
    }

