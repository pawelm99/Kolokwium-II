namespace Kolokwium_II_Przgotowanie
{
    public class Person
    {
        public string name;
        public int n=1;
        public int[] ne= new int[]{1,2,3};

        public Person(string a)
        {
            name = a;
        }

        public override string ToString()
        {
            return $"{nameof(name)}: {name}";
        }
    }
}