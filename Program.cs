namespace Assignment_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pointOne = new Point(4.5, 6.3);
            Point pointTwo = new Point(2, 5);

            if (pointOne.Equals(pointTwo))
            {
                Console.WriteLine("They are equal and on the same vertical");
            }
            else if (pointOne.x > pointTwo.x)
            {
                Console.WriteLine("y is to the left of x");
            }
            else
            {
                Console.WriteLine("y is to the right of x");
            }

        }
    }
}


        
    