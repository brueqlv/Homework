

namespace TrešāsLekcijasMājasdarbs
{
    public class Mašīna
    {
        public string CarBrand { get; set; }
        public string CarNumberPlate { get; set; }
        public double CarSpeed { get; set; }

        public void StartDriving()
        {

            Console.WriteLine($"Sākam braukšanu ar ātrumu: {CarSpeed}km/h!");
        }

        public double SpeedUp()
        {
            CarSpeed += 5;
            Console.WriteLine($"Paātrinam braukšanas ātrumu par 5km/h. Braukšanas ātrumus: {CarSpeed}km/h");
            return CarSpeed;
        }

        public double StopDriving()
        {
            CarSpeed = 0;
            Console.WriteLine($"Automašīna ir apstājusies! Braukšanas ātrums: {CarSpeed}km/h");
            return CarSpeed;
        }

        public void Honk()
        {
            Console.WriteLine("Beep Beep");
        }



    }

}

