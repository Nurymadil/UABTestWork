// See https://aka.ms/new-console-template for more information
/*1. Решите, пожалуйста, задачу на C#.
Существует список остатков товара на складе. Остаток каждого товара может измеряться в тоннах или в килограммах.
Например:
Склад: Нью-Йоркский, Товар: Апельсины, Единица измерения: Тонны, Остаток: 2,321
Склад: Лондонский, Товар: Груши, Единица измерения: Килограммы, Остаток: 980
Склад: Нью-Йоркский, Товар: Груши, Единица измерения: Килограммы, Остаток: 1100
И так далее

Задача:
Для каждого склада выберите товары, название которых начинается на А и остаток на этом складе меньше 500 кг.
*/
using System.Linq;

var stores = new List<Store> {
    new Store { Name = "Нью-Йоркский" },
    new Store { Name = "Лондонский" },
    new Store { Name = "Токийский" }
    };


var goods = new List<Good> {
    new Good { Name = "Груша" },
    new Good { Name = "Апельсин" },
    new Good { Name = "Авокадо" },
    new Good { Name = "Манго" } };


var goodRemains = new List<GoodRemain> {
    new GoodRemain { Store=stores[0],Good=goods[1],Balance=2.321,MeasureUnit=MeasureUnit.Tonn},
    new GoodRemain { Store=stores[2],Good=goods[3],Balance=3.573,MeasureUnit=MeasureUnit.Tonn},
    new GoodRemain{ Store=stores[1],Good=goods[0],Balance=580,MeasureUnit=MeasureUnit.Kg},
    new GoodRemain{ Store=stores[1],Good=goods[2],Balance=980,MeasureUnit=MeasureUnit.Kg},
    new GoodRemain{ Store=stores[1],Good=goods[1],Balance=0.2,MeasureUnit=MeasureUnit.Tonn},
    new GoodRemain{ Store=stores[0],Good=goods[0],Balance=1100,MeasureUnit=MeasureUnit.Kg} };

foreach (var item in goodRemains)
{
    Console.WriteLine(item.GetBalanceInTonn());
}
Console.WriteLine();

var selectedGoodsRemains=goodRemains.Where(x=>x.Good.Name.StartsWith("А")&&x.GetBalanceInKg()>500).ToList();

foreach (var item in selectedGoodsRemains)
{
    Console.WriteLine(item);
}