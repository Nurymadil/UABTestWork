var stores = new List<Store> { //Склады
    new Store { Name = "Нью-Йоркский" },
    new Store { Name = "Лондонский" },
    new Store { Name = "Токийский" }
    };

var goods = new List<Good> {//Товары
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

Console.WriteLine("Все элементы");
foreach (var item in goodRemains)
{
    Console.WriteLine(item);
}
Console.WriteLine();

var selectedGoodsRemains=goodRemains.Where(x=>x.Good.Name.StartsWith("А")&&x.GetBalanceInKg()>500).ToList();

Console.WriteLine("Филтрация объектов: Good.Name начинаеться с А(Кириллица) и остаток больше 500кг");
foreach (var item in selectedGoodsRemains)
{
    Console.WriteLine(item);
}