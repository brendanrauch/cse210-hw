
class ConstructionWorker : Employee
{
    public ConstructionWorker(string name, double hour, double wage): base(name,hour,wage)
    {

    }

    public override double GetPay()
    {
        return base.GetPay() + 1000;
    }
}