class Person
{
    protected string _firstName;
    protected string _lastName;
    protected int _age;
    protected int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
    }

    public string PersonInforamtion()
    {
        return $"{_firstName}, {_lastName}, {_age}, {_weight} ";
    }

}
