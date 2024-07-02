
class Fireman : Person
{
    private string _certification;

    public Fireman(string certification, string f, string l, int a, int w)
        : base(f, l, a, w)
    {
        _certification = certification;
    }

    public string FiremanInformation()
    {
        return $"{_certification}, {PersonInforamtion()}";
    }
}