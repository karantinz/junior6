int gold;
int crystalCount = 0;
int crystalPrice = 10;

Console.WriteLine("Сколько у вас золота");
gold = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Цена за криствллы в золотых: 1 к {crystalPrice}");
Console.WriteLine("Сколько хотите купить");

int crystalBuy = Convert.ToInt32(Console.ReadLine());

gold -= crystalPrice * crystalBuy;
crystalCount += crystalBuy;

Console.WriteLine("Остаток золота: " + gold);
Console.WriteLine("Кристаллы: " + crystalCount);