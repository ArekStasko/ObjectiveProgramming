
namespace ObjectiveProgramming
{
    public class Ulamek : IEquatable<Ulamek>, IComparable<Ulamek>
    {
        private int licznik;
        private int mianownik;

        public Ulamek() { }
        public Ulamek(int number1, int number2)
        {
            licznik = number1;
            mianownik = number2;
        }

        public Ulamek(Ulamek prev)
        {
            licznik = prev.licznik;
            mianownik = prev.mianownik;
        }

        public override string ToString()
        {
            return $"{licznik}/{mianownik}";
        }

        public static Ulamek operator +(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik + b.licznik, a.mianownik);
        }

        public static Ulamek operator -(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik - b.licznik, a.mianownik);
        }

        public static Ulamek operator *(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.licznik, a.mianownik * b.mianownik);
        }
         
        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.mianownik, a.mianownik * b.licznik);
        }

    }
}
