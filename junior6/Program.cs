int gold;
int crystal = 0;
int crystalPrice = 10;

Console.WriteLine("Сколько у вас золота");
gold = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Наши кристалы стоят 1 к 10 золотых");
Console.WriteLine("Сколько хотите купить");

int crystalBuy = Convert.ToInt32(Console.ReadLine());

gold = gold - crystalPrice * crystalBuy;

crystal += crystalBuy;

Console.WriteLine("Остаток золота: " + gold);
Console.WriteLine("Кристаллы: " + crystal);