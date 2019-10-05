using Classes_CSharp_.Math;

namespace Classes_CSharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person vince = new Person();
            Calculator cal = new Calculator();
            vince.firstName = "Vince";
            vince.lastName = "Vanya";
            vince.Introduce(cal.Subtract(2019, 1994));
            Person.StringJoinArray();
        }
    }
}
