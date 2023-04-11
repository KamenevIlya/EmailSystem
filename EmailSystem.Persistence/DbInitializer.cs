using EmailSystem.Domain;

namespace EmailSystem.Persistence
{
    public static class DbInitializer
    {
        public static void Initialize(EmailSystemDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            FillDatabaseForTest(context);
        }

        private static void FillDatabaseForTest(EmailSystemDbContext context)
        {
            var employee1 = new Employee
            {
                Id = new("23488425-58c6-4e33-a373-650e21103a0a"), FirstName = "QQQ", SecondName = "WWW",
                GivenName = "EEE", ExperienceMonth = 20, Position = "No"
            };
            context.Employees.Add(employee1);

            var employee2 = new Employee
            {
                Id = new("64b55038-737f-4739-9926-67741c7e96ac"),
                FirstName = "ZZZ",
                SecondName = "XXX",
                GivenName = "CCC",
                ExperienceMonth = 7,
                Position = "Ghoul"
            };
            context.Employees.Add(employee2);
            context.SaveChanges();
        }
    }
}