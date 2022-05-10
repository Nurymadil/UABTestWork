// See https://aka.ms/new-console-template for more information
public class GoodRemain
{
    //public int Id { get; set; }
    public Store Store { get; set; }
    public Good Good { get; set; }
    public double Balance { get; set; }//кол-во остатков
    public MeasureUnit MeasureUnit { get; set; }//Ед измерения

    public double GetBalanceInKg()
    {
        //проверка на null
        if(MeasureUnit == MeasureUnit.Tonn)return Balance*1000;
        else return Balance;
    }
    public double GetBalanceInTonn()
    {
        if (MeasureUnit == MeasureUnit.Kg) return Balance / 1000;
        else return Balance;
    }
    public override string ToString()
    {
        if (MeasureUnit == MeasureUnit.Tonn) { return $"Склад: {this.Store.Name}, Товар: {this.Good.Name} Единица измерения: Тонны, Остаток: {this.Balance}"; }
        else if (MeasureUnit == MeasureUnit.Kg) { return $"Склад: {this.Store.Name}, Товар: {this.Good.Name} Единица измерения: Килограмм, Остаток: {this.Balance}"; }
        else { return "Неправильно инницализирован"; }
    }
}
public enum MeasureUnit
{
    Tonn, Kg
}