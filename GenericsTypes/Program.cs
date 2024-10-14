namespace GenericsTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repository = new Repository<IEntity<int>, int>();
            repository.Add(new Product { Id = 20, Name = "Procuct#1"});
            repository.Add(new Product { Id = 20, Name = "Procuct#2" });
            repository.Add(new Drink { Id = 20, Name = "Procuct#3" });

            Console.WriteLine(repository.Get<Drink>(20)?.Id.ToString() ?? "null drink");
            Console.WriteLine(repository.Get<Drink>(1)?.Id.ToString() ?? "null drink");
            Console.WriteLine(repository.Get<Product>(20)?.Id.ToString() ?? "null product");
        }
    }
}
