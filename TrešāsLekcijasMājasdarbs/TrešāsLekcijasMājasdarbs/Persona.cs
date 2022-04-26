
namespace TrešāsLekcijasMājasdarbs
{
    internal class Persona
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }
        public string Gender { get; set; }

        public int YearsOld { get; set; }
        
       


        public int GetAge()
        {
            int ageNow = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.Month < BirthDate.Month || (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day))
                ageNow--;
            return ageNow;

        }
        

        

        public void Sasveicināšanās()
        {
            Console.WriteLine($"Hello my name is { Name } { Surname} and I am {YearsOld} ");
        }
    }
}
