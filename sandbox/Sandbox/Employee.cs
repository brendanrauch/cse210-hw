
abstract class Employee
{
    private string _name;
    private double _hourWorked;
    private double _hourlywage;

    public Employee(string name, double hourworked, double houewage)
    {
        _name = name;
        _hourlywage = houewage;
        _hourWorked = hourworked;
    }

    public virtual double GetPay()
    {
        return _hourWorked * _hourlywage;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract double InsuranceCost();

}