// Jeremy Gallen's sample program to demonstrate polymorphism

// Polymorphism namespace
namespace Polymorphism
{
    // Hero class
    public class Hero
    {
        // Attack method
        public virtual void attack()
        {
            Console.WriteLine("Attacking with equipped weapon...");
        }
    }

    // Derived Druid class
    public class Druid : Hero
    {
        // Override attack method
        public override void attack()
        {
            Console.WriteLine("Druid summons animal to attack...");
        }
    }

    // Main program class
    internal class Program
    {
        // Main function
        static void Main(string[] args)
        {
            // Declare hero object
            Hero Jeremy = new Druid();

            // Have hero attack
            Jeremy.attack();
        }
    }
}