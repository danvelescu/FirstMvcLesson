using FirstMvcLesson.Model;

namespace FirstMvcLesson.Repos
{
    public class PhoneRepository
    {
        public static List<Phone> Phones { get; set; } = new List<Phone>();
        public static List<Phone> PhoneRepositoryGetPhones()
        {
            int id = 0;

            Phones.Add(new Phone("IPhone", "X", "R", 16000, 64, 8));
            Phones.Add(new Phone("IPhone", "X", "R", 16000, 64, 8));
            Phones.Add(new Phone("IPhone", "X", "R", 16000, 64, 8));
            Phones.Add(new Phone("IPhone", "X", "R", 16000, 64, 8));
            Phones.Add(new Phone("IPhone", "X", "R", 16000, 64, 8));

            foreach (var phone in Phones)
            {
                phone.Id = id++;
            }

            return Phones;
        }
    }
}
