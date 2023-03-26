namespace Araye_Ekhtelaf
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Student Nomre = new Student();
            int nomreUSER;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Nomre Daneshjoo shomare " +(i+1)+ " Ro vared kon ");
                 nomreUSER=int.Parse(Console.ReadLine());
                Nomre.insert(nomreUSER);
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Enter a number to search in Array :");
            int SearchNumber = int.Parse(Console.ReadLine());
            var nearest = Nomre.ArayeNomre.MinBy(x => Math.Abs((long)x - SearchNumber));
Console.WriteLine("Result Is " +  Math.Abs(SearchNumber-nearest));
            Console.ReadKey();
        }
    }
    class Student
    {
        public int[] ArayeNomre = new int[10];
        int i = 0;
        public void insert(int nomre)
        {
            ArayeNomre[i] = nomre;
            i++;
        }
    } 
}