
class Docter : Employee
{
    private double _salary;
    public Docter(String name, double salaray): base(name,0,0)
    {
        _salary = salaray;
    }
    public override double GetPay()
    {
        return _salary / 52;
    }
    public override double InsuranceCost()
    {
        return _salary * .03;
    }
}