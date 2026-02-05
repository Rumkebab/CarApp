namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Få input fra bruger omkring bilmærke, model, årgang og geartype. 
            //Årgang "year" konverterer user input fra string til int.
            //gear variabel kigger på ReadLine inputs første tegn(0) - for at undgå fejlfortolkning.
            //Output herefter al info om bilen i én linje.
            Console.WriteLine("Indtast bilmærke:");
            string brand = Console.ReadLine();
            Console.WriteLine("Indtast bilmodel:");
            string model = Console.ReadLine();
            Console.WriteLine("Indtast årgang:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast geartype. A for Automatisk, M for Manuel:");
            char gear = Console.ReadLine()[0];  
            Console.WriteLine($"\n{brand} {model} fra {year} har gear {gear}.");
        }
    }
}
