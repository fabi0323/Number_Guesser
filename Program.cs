namespace numberguesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int x = rd.Next(1, 101);

            Console.WriteLine("enter a number from 1-100");
            int nutzer_input = Convert.ToInt32(Console.ReadLine());
            int y = nutzer_input;
            int counter = 0;
            bool number_guessed = false;

            //if (y = (int) y)
            //{
            //y = Convert.ToInt32(y ;
            //}
            // else

            while (number_guessed == false)
            {

                if (y < 1)
                {
                    Console.WriteLine("only numbers bigger than 0, 1 guess penalty");
                    Console.WriteLine("enter a new Number");
                    nutzer_input = Convert.ToInt32(Console.ReadLine());
                    y = nutzer_input;
                    counter = counter +2;
                }
                if (y > 100)
                {
                    Console.WriteLine("only numbers smaller than 101, 1 guess penalty");
                    Console.WriteLine("enter a new Number");
                    nutzer_input = Convert.ToInt32(Console.ReadLine());
                    y = nutzer_input;
                    counter = counter + 2;
                }
                if (y < x) 
                {
                    Console.WriteLine("too small");
                    Console.WriteLine("enter a new Number");
                    nutzer_input = Convert.ToInt32(Console.ReadLine());
                    y = nutzer_input;
                    counter++;
                }
                if (y > x) 
                {
                    Console.WriteLine("too big");
                    Console.WriteLine("enter a new Number");
                    nutzer_input = Convert.ToInt32(Console.ReadLine());
                    y = nutzer_input;
                    counter++;
                }
                if (y == x) 
                {
                    number_guessed = true;
                    Console.WriteLine("nummer gefunden");
                    counter++;
                    Console.WriteLine("guess count " + counter);
                }
            }

            //Console.WriteLine("play again");
            

           

        }


    }
}




