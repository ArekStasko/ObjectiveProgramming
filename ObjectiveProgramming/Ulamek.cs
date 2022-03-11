
namespace ObjectiveProgramming
{
    public class Ulamek : IEquatable<Ulamek>, IComparable<Ulamek>
    {
        private int _licznik;
        public int licznik
        {
            get => _licznik;
            set => _licznik = value;
        }
        private int _mianownik;
        public int mianownik
        {
            get => _mianownik;
            set => _mianownik = value;
        }

        public int GetRoundedUpp()
        {
            double val = this.licznik / this.mianownik;
            return (int)Math.Round(val);
        }

        public int GetRoundedDown()
        {
            double val = this.licznik / this.mianownik;
            return (int)Math.Floor(val);
        }

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

        public int CompareTo(Ulamek other)
        {
            if (other == null) return -1;
            if (this == other) return 0;

            var diff = this - other;

            if(diff.licznik < 0 && diff.mianownik < 0) return -1;
            if(diff.licznik > 0 && diff.mianownik > 0) return +1;

            return 0;
        }

        public bool Equals(Ulamek other)
        {
            if (other == null) return false;
            if (this == other) return true;

            return Object.Equals(this.licznik, other.licznik) && Object.Equals(this.mianownik, other.mianownik);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
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
