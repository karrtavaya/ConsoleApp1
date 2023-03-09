using ConsoleApp1.DB;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static GoodsContext _ef;
    private static void Main(string[] args)
    {
        _ef = new GoodsContext();
        _ef.Database.Migrate();
        Console.WriteLine($"Can Connect to db: {_ef.Database.CanConnect()}");
        if (!_ef.Database.CanConnect())
            return;


        foreach (var item in _ef.Categories.ToList())
        {
            Console.WriteLine(item.Name);
        }

        var find_category = _ef.Categories.FirstOrDefault(
            x => x.Name == "Снеки");

        if (find_category == null)
            find_category = new Category() { Name = "Снеки" };


        foreach (var item in _ef.Goods.ToList())
        {
            double total_sale = item.Price - item.Sale;
            Console.WriteLine($"{item.Name}" +
                $"Стоимость с учетом скидки:{total_sale} руб");
        }

        Good good = new Good()
        {
            Name = "Чипсы",
            Price = 199.0,
            Sale = 0.50,
            Category = find_category
        };

        _ef.Add(good);
        _ef.SaveChanges();
        Category category = new Category()
        {
            Name = "Снеки"
        };
        _ef.Add(category);
        _ef.SaveChanges();
        foreach (var item in _ef.Categories.ToList())
        {
            Console.WriteLine(item.Name);
        }



    }
}

