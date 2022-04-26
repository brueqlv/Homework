
namespace TrešāsLekcijasMājasdarbs
{
    public class Prece
    {

        public double itemHeight;
        public double itemWidth;
        public double itemLenght;

        public Prece()
        {
            ItemHeight = itemHeight;
            ItemWidth = itemWidth;
            ItemLenght = itemLenght;
        }



        public double ItemHeight { get; }
        public double ItemWidth { get; }
        public double ItemLenght { get; }

        public double ItemWeight { get; set; }

        
        


        public void ShowItem()
        {
            Console.WriteLine($"Preces izmēri ir:");
            Console.WriteLine($"Augstums: {ItemHeight}cm");
            Console.WriteLine($"Platums:{ItemWidth}cm");
            Console.WriteLine($"Garums:{ItemLenght}cm");
            Console.WriteLine($"Svars:{ItemWeight}cm");
        }
    }


}
