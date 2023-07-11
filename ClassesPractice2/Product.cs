using ClassesPractice2.Enumerations;

namespace ClassesPractice2
{
    internal class Product
    {
        public static int counter = 0;
        public static int breadsInStoc = 20;

        public Product(DateTime productionDate, Category category)
        {
            ProductionDate = productionDate;
            Category = category;
            counter++;

            if (category == Category.Beverages)
            {
                breadsInStoc--;
            }
            Console.WriteLine($"Breads left in stoc: {breadsInStoc}");
        }

        public int Weight { get; set; }
        public string Name { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate => CalculateExpiryDate();
        public string Producer { get; set; }
        public Category Category { get; set; }

        //public  void BuyBread()
        //{

            

        //    Console.WriteLine($"Breads left in stoc: {breadsInStoc}");
        //}

        private DateTime CalculateExpiryDate()
        {
            switch (Category)
            {
                case Category.Fruit:
                    return ProductionDate.AddDays(2);
                case Category.Beverages:
                    return ProductionDate.AddYears(3);
                case Category.Dairy:
                    return ProductionDate.AddDays(7);
                case Category.Bread:
                    return ProductionDate.AddDays(4);
            }

            return DateTime.Now;
        }
    }
}
