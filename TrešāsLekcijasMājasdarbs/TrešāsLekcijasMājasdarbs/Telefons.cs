
namespace TrešāsLekcijasMājasdarbs
{
    public class Telefons
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Width { get; set; }

        public double Lenght { get; set; }

        public double Height { get; set; }

        /* public void PhoneInfo()
         {
             Console.WriteLine($"Tava telefona marka : {Brand}.");
             Console.WriteLine($"Tava telefona modelis : {Model}.");
             Console.WriteLine($"Tava telefona platums : {Width}.");
             Console.WriteLine($"Tava telefona garums : {Lenght}.");
             Console.WriteLine($"Tava telefona augstums : {Height}.");


         }
        */


        public void Calling()
        {
            Console.WriteLine($"Calling from: {Brand} {Model}");
        }

        public void Messaging()
        {
            Console.WriteLine($"Message sent from: {Brand} {Model}");
        }

    }
}
