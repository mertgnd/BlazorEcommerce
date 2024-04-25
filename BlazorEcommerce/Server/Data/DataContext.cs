namespace BlazorEcommerce.Server.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
					new Product
					{
						Id = 1,
						Title = "Mert's Advantures in Serbia",
						Description = "The Witcher (Polish: Wiedźmin, pronounced [ˈvjɛd͡ʑmin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous 'Witcher', Geralt of Rivia. 'Witchers' are monster hunters given superhuman abilities for the purpose of killing dangerous creatures. The Witcher began with a titular 1986 short story that Sapkowski entered into a competition held by Fantastyka magazine, marking his debut as an author. Due to reader demand, Sapkowski wrote 14 more stories before starting a series of novels in 1994. Known as The Witcher Saga, he wrote one book a year until the fifth and final installment in 1999. A standalone prequel novel, Season of Storms, was published in 2013.",
						ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/33/Wiedzmin_1990.png",
						Price = 9.99m
					},
					new Product
					{
						Id = 2,
						Title = "Mert's Advantures in Turkey",
						Description = "The Witcher (Polish: Wiedźmin, pronounced [ˈvjɛd͡ʑmin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous 'Witcher', Geralt of Rivia. 'Witchers' are monster hunters given superhuman abilities for the purpose of killing dangerous creatures. The Witcher began with a titular 1986 short story that Sapkowski entered into a competition held by Fantastyka magazine, marking his debut as an author. Due to reader demand, Sapkowski wrote 14 more stories before starting a series of novels in 1994. Known as The Witcher Saga, he wrote one book a year until the fifth and final installment in 1999. A standalone prequel novel, Season of Storms, was published in 2013.",
						ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/33/Wiedzmin_1990.png",
						Price = 9.99m
					},
					new Product
					{
						Id = 3,
						Title = "Mert's Advantures in India",
						Description = "The Witcher (Polish: Wiedźmin, pronounced [ˈvjɛd͡ʑmin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous 'Witcher', Geralt of Rivia. 'Witchers' are monster hunters given superhuman abilities for the purpose of killing dangerous creatures. The Witcher began with a titular 1986 short story that Sapkowski entered into a competition held by Fantastyka magazine, marking his debut as an author. Due to reader demand, Sapkowski wrote 14 more stories before starting a series of novels in 1994. Known as The Witcher Saga, he wrote one book a year until the fifth and final installment in 1999. A standalone prequel novel, Season of Storms, was published in 2013.",
						ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/33/Wiedzmin_1990.png",
						Price = 9.99m
					},
					new Product
					{
						Id = 4,
						Title = "Mert's Experience in Bahrein",
						Description = "The Witcher (Polish: Wiedźmin, pronounced [ˈvjɛd͡ʑmin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous 'Witcher', Geralt of Rivia. 'Witchers' are monster hunters given superhuman abilities for the purpose of killing dangerous creatures. The Witcher began with a titular 1986 short story that Sapkowski entered into a competition held by Fantastyka magazine, marking his debut as an author. Due to reader demand, Sapkowski wrote 14 more stories before starting a series of novels in 1994. Known as The Witcher Saga, he wrote one book a year until the fifth and final installment in 1999. A standalone prequel novel, Season of Storms, was published in 2013.",
						ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/33/Wiedzmin_1990.png",
						Price = 9.99m
					}
				);
		}

		public DbSet<Product> Products { get; set; }
    }
}
