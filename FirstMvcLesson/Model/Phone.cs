namespace FirstMvcLesson.Model
{
    public class Phone
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Code { get; set; }
        public string Series { get; set; }
        public double Price { get; set; }

        public int Memmory { get; set; }
        public int RamMemmory { get; set; }

        public Phone(string model,
                     string code,
                     string series,
                     double price,
                     int memmory,
                     int ram_memmory)
        {
            Model = model;
            Code = code;
            Series = series;
            Price = price;
            Memmory = memmory;
            RamMemmory = ram_memmory;
        }
    }
}
