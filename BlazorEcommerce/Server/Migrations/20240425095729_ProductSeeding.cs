using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "The Witcher (Polish: Wiedźmin, pronounced [ˈvjɛd͡ʑmin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous 'Witcher', Geralt of Rivia. 'Witchers' are monster hunters given superhuman abilities for the purpose of killing dangerous creatures. The Witcher began with a titular 1986 short story that Sapkowski entered into a competition held by Fantastyka magazine, marking his debut as an author. Due to reader demand, Sapkowski wrote 14 more stories before starting a series of novels in 1994. Known as The Witcher Saga, he wrote one book a year until the fifth and final installment in 1999. A standalone prequel novel, Season of Storms, was published in 2013.", "https://upload.wikimedia.org/wikipedia/en/3/33/Wiedzmin_1990.png", 9.99m, "Mert's Advantures in Serbia" },
                    { 2, "The Witcher (Polish: Wiedźmin, pronounced [ˈvjɛd͡ʑmin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous 'Witcher', Geralt of Rivia. 'Witchers' are monster hunters given superhuman abilities for the purpose of killing dangerous creatures. The Witcher began with a titular 1986 short story that Sapkowski entered into a competition held by Fantastyka magazine, marking his debut as an author. Due to reader demand, Sapkowski wrote 14 more stories before starting a series of novels in 1994. Known as The Witcher Saga, he wrote one book a year until the fifth and final installment in 1999. A standalone prequel novel, Season of Storms, was published in 2013.", "https://upload.wikimedia.org/wikipedia/en/3/33/Wiedzmin_1990.png", 9.99m, "Mert's Advantures in Turkey" },
                    { 3, "The Witcher (Polish: Wiedźmin, pronounced [ˈvjɛd͡ʑmin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous 'Witcher', Geralt of Rivia. 'Witchers' are monster hunters given superhuman abilities for the purpose of killing dangerous creatures. The Witcher began with a titular 1986 short story that Sapkowski entered into a competition held by Fantastyka magazine, marking his debut as an author. Due to reader demand, Sapkowski wrote 14 more stories before starting a series of novels in 1994. Known as The Witcher Saga, he wrote one book a year until the fifth and final installment in 1999. A standalone prequel novel, Season of Storms, was published in 2013.", "https://upload.wikimedia.org/wikipedia/en/3/33/Wiedzmin_1990.png", 9.99m, "Mert's Advantures in India" },
                    { 4, "The Witcher (Polish: Wiedźmin, pronounced [ˈvjɛd͡ʑmin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous 'Witcher', Geralt of Rivia. 'Witchers' are monster hunters given superhuman abilities for the purpose of killing dangerous creatures. The Witcher began with a titular 1986 short story that Sapkowski entered into a competition held by Fantastyka magazine, marking his debut as an author. Due to reader demand, Sapkowski wrote 14 more stories before starting a series of novels in 1994. Known as The Witcher Saga, he wrote one book a year until the fifth and final installment in 1999. A standalone prequel novel, Season of Storms, was published in 2013.", "https://upload.wikimedia.org/wikipedia/en/3/33/Wiedzmin_1990.png", 9.99m, "Mert's Experience in Bahrein" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
