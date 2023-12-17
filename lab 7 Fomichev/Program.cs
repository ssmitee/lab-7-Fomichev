struct Car
{
    public string Brand;
    public string Manufacturer;
    public double CarryingCapacity;
    public int Year;
    public DateTime RegistrationDate;
}

class Program
{
    static void Main()
    {
        Car[] cars = new Car[3];

        cars[0].Brand = "BMW";
        cars[0].Manufacturer = "Bayerische Motoren Werke AG";
        cars[0].CarryingCapacity = 3.5;
        cars[0].Year = 2018;
        cars[0].RegistrationDate = new DateTime(2019, 5, 13);

        cars[1].Brand = "Mercedes-Benz";
        cars[1].Manufacturer = "Mercedes-Benz AG";
        cars[1].CarryingCapacity = 2.8;
        cars[1].Year = 2019;
        cars[1].RegistrationDate = new DateTime(2020, 3, 22);

        cars[2].Brand = "Volvo";
        cars[2].Manufacturer = "Volvo Group";
        cars[2].CarryingCapacity = 4.0;
        cars[2].Year = 2017;
        cars[2].RegistrationDate = new DateTime(2018, 8, 7);
        Console.WriteLine("Машины, зарегистрированные более года назад и имеющие грузоподъемность более 3-х тонн:");
        for (int i = 0; i < cars.Length; i++)
        {
            if ((DateTime.Now - cars[i].RegistrationDate).TotalDays > 365 && cars[i].CarryingCapacity > 3.0)
            {
                Console.WriteLine($"Марка: {cars[i].Brand}, Производитель: {cars[i].Manufacturer}, Грузоподъемность: {cars[i].CarryingCapacity} тонн, Год выпуска: {cars[i].Year}, Дата регистрации: {cars[i].RegistrationDate}");
            }
        }
    }
}