using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KonusarakOgren.DataAccess.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    URL = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArticleID = table.Column<int>(type: "INTEGER", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Articles_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuestionID = table.Column<int>(type: "INTEGER", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    IsTrue = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsDeleted", "Text", "Title", "URL", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 1, 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1893), false, "IF YOU THINK waffle irons are just for making waffles, I'm here to change your world. They're the best way to make hash browns at home, and they’re also great for omelets, cornbread, birthday cakes, cookies, falafel, and darn near anything else you can think to put in them. I know this because I've spent years living in a vintage RV with a broken oven and relied on a waffle iron for nearly all my “baking.” \r\n                        If your waffle iron is going to do all that, though, it needs to be up to the task. When I first bought one, it was on a whim, and I got the cheapest I could find. It worked, but it only made two waffles at a time. Here's a recipe for conflict: Have three kids and then get a waffle iron that makes just two waffles at a time. \r\n                        When that ultra-budget model died, I started looking around for a replacement that could make four waffles at a time and stand up to the greater level of not-technically-waffles abuse I was going to throw at it. Most of all, it needed to be easy to clean. The Cuisinart 4-Slice Belgian Waffle Maker ticks most of these boxes and isn't terribly expensive either. \r\n                        Waffle Talk \r\n                        Cuisinart's waffle maker is solidly made, with a sleek stainless lid surrounded by sturdy plastic. It's a pretty good size—roughly 14 inches deep, 10 inches wide, and 5 inches high—meaning it will take up considerable counter space if you leave it out. Fortunately, it's not too heavy (10 pounds), so I shove it in a cabinet under the counter when it's not being used. \r\n                        This model makes 1-inch thick waffles with reasonably deep holes. The results are not quite what I'd call a Belgian waffle, but the precise meaning of that term is highly debatable—some say it's the batter, some say it's the thickness, others think it's the shape. What matters from an I'm-not-just-making-waffles point of view is that Cuisinart's waffle plates are cast aluminum and well-coated in a nonstick material that really is nonstick. \r\n                        I've been using it two to three times a week for several months, and there's no sign of wear on the plates, no scratches in the nonstick, and still no sticking—and I never grease it before adding batter. That's after making hash browns, cornbread, two birthday cakes, and plenty of other non-waffle cooking. \r\n                        The secret to the long life of any nonstick coating is to never use metal tools of any kind on it. Get a good silicone spatula to help gently pry out your waffles. I use one very similar to this Oxo version. The silicone won't scratch the Cuisinart's plates and, because it's heat-proof, you won't melt your spatula. \r\n                        Waffly Good \r\n                        This waffle maker has a very simple, five-setting temperature control. A green indicator light lets you know when the iron is ready, then again when your waffles are done. That said, I almost never pay attention to the indicator light. Everyone in my family likes their waffles at different levels of brownness and crispiness, so I'd constantly be fiddling with the temp settings to make everyone happy. Instead, I set it to three and let the kids keep cooking it as long as they want. My pro tip? Never open your waffle iron before the green light turns on, but don't assume your waffle is done just because the green light is on. \r\n                        This Cuisinart offers a good range of brownness through the one to five settings and errs on the undercooked side, which is to say that setting it to five won't burn your waffles. Once you move beyond simple waffles to things like hash browns, the temperature settings won't do you much good—you'll want to time your cooking just like you would in an oven. \r\n                        When it first arrived, my one gripe was that the plates don’t pop out, which would make them easier to clean. But this has turned out to be a nonissue. I wipe it down with a damp rag after each use. It's also not that heavy, so you can turn it around to get a good angle on all sides. It still would be nice if those plates came out, because at some point the nonstick will start to fail—I've never owned anything nonstick that didn't eventually become stick. At least I'd be able to take them out and scrub them if needed. Still, I don't consider the nonremovable plates a deal-breaker at all. \r\n                        Whether you should spend $60 on this waffle maker probably depends mostly on how often you make waffles. If waffles are a special treat you enjoy a couple of times a year, a cheaper waffle iron might suffice. For those of us who are more serious about waffles, this is well worth the investment.", "Review: Cuisinart 4-Slice Belgian Waffle Maker", "https://www.wired.com/review/cuisinart-4-slice-belgian-waffle-maker/", 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsDeleted", "Text", "Title", "URL", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 2, 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1903), false, "OMEGA AND SWATCH have announced a budget version of the iconic Speedster Moonwatch, an astronaut-inspired piece that usually retails for thousands of dollars. The MoonSwatch is the first collaboration between the two brands (both part of the Swatch Group, which also holds Longines, Tissot, and Hamilton). It goes on sale Saturday in Swatch stores only and will cost just $260 (£207).", "Omega and Swatch’s $260 MoonSwatch Looks Out of This World", "https://www.wired.com/story/omega-and-swatch-moonswatch/", 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsDeleted", "Text", "Title", "URL", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 3, 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1904), false, "THE MOTOROLA EDGE+ is a flagship Android smartphone. It's got some high-end features, like an uncommon 144-Hz screen refresh rate, plus the same Qualcomm Snapdragon 8 Gen 1 processor that powers other expensive phones, like the Samsung Galaxy S22 series. But if you're vying for the Big Leagues, you need to bring your A game.\r\n                         Unfortunately, there are a few areas where this new Motorola phone falls short of its peers. It's fine, but it would make more sense if it cost $600, rather than $1,000. Heck, even Motorola thinks it's not worth the high price; the company is shaving $100 off for the first few weeks of launch, after which it will go back to MSRP. But even at $900, you've got better options. \r\n                         \r\n                         Edge of Glory\r\n\r\n                         Let's start with the good: This is a snappy phone. It helps to have the high-end chip of the year paired with 8 gigabytes of RAM (upgradable to 12 GB if you so desire). Every app launch and scroll through Twitter feels buttery smooth, and demanding games like Genshin Impact run fairly well. \r\n                         The 144-Hz screen refresh rate helps a lot with making the phone feel responsive. It means the screen is refreshing 144 times per second to give you the smoothest animations (as opposed to 60 Hz on most midrange and budget phones). Most flagship phones offer 120 Hz, and I'm honestly not sure 144 Hz adds much of a difference here (eagle-eyed gamers, don't @ me).  I set the phone to 144 Hz during my testing, but there is an Auto mode you can use to have the phone decide when to use a high refresh rate and when to lower it, which conserves battery life.\r\n                         That said, I never worried about carrying around a dead phone. The Edge+ has a 4,800-mAh battery capacity that often left me with around 35 percent before bed, sometimes a little more. It's no two-day battery life, but it's reliable. It recharges wirelessly or via USB-C.\r\n                         The 6.7-inch pOLED screen is sharp and colorful, and it gets bright enough to see clearly on sunny days (though nowhere near as bright as similarly priced Samsung or OnePlus phones). Still, there's no squinting required. However, two hands are required to comfortably hold and use this phone; it's nearly as big as the gargantuan Samsung Galaxy S22 Ultra. Even with my large hands, I often had to shimmy the phone down to reach the top of the screen. At least it's easy to access the fingerprint sensor, which is embedded in the power button on the side. \r\n                         I like the software experience. You get Android 12 in a clean state with very few modifications on Motorola's part—it looks and feels like a Pixel sometimes, minus the software smarts Google provides on its phone. (I tested the Verizon variant of the Edge+, which does come with bloatware, some of which is removable; always go for the unlocked model instead.) Unlike its cheap phones, Motorola also includes NFC, so you can make contactless payments via Google Pay.\r\n                         Motorola has a platform called “Ready for” in this phone (and a few other Moto devices), and it's surprisingly handy. I was able to wirelessly connect the Edge+ to my TCL TV (requires a TV with Miracast support) to run Android in desktop mode, and I even placed a Duo video call on the big screen while using the phone as a webcam. You can also use your phone as a remote control, or even stream games running on your phone. That said, I tried to play Genshin Impact on my TV with this system, but the input lag was unbearable and I needed a Bluetooth controller to play.\r\n                         I wirelessly connected the Edge+ to my Windows PC (no MacOS support, sadly) and was able to run Android apps, respond to texts, and transfer files—akin to Samsung's DeX mode. I can see this being helpful in select situations, but “Ready for” is not a reason to buy this device.\r\n                         \r\n                         Livin' on the Edge\r\n\r\n                         Nearly every phone that costs $700 and up these days comes with the holy trinity of camera systems: main camera, ultrawide, and telephoto. The Edge+ skips the latter. Yes, there are three cameras on the back, but one of them is a depth sensor for improving Portrait mode photos. The ultrawide can double as a macro camera for super close-ups, but the only macro photo I want to take is of my dog's nose. That's it. I’d really have liked to see a zoom lens here.\r\n", "Review: Motorola Edge+ (2022)", "https://www.wired.com/review/motorola-edge-plus-2022/", 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsDeleted", "Text", "Title", "URL", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 4, 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1905), false, "LEICA'S NEW M11 digital rangefinder camera may as well come from an entirely different era. Don't get me wrong; the technology inside of it makes it feel plenty modern. The M11 has a high-resolution sensor (a 60-megapixel backside-illuminated full-frame CMOS sensor to be precise), sophisticated metering tools, and even some of the usual digital accoutrements of cameras in our age. But in many ways, it works like the film cameras your parents owned. It thumbs its nose at autofocus, it doesn’t capture video, and it’s perfectly happy to accept lenses that are decades old.", "Leica’s New Camera Puts Skill Back Into Focus", "https://www.wired.com/story/leica-m11-digital-rangefinder/", 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsDeleted", "Text", "Title", "URL", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 5, 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1906), false, "IN 2012, THE legendary Twitter account @horse_ebooks tweeted, “Everything happens so much.“ Despite bordering on nonsense, the message singularly captured the feeling of exhaustion that comes with trying to keep up with the flood of inputs that demand attention every day. It is in this place of chaotic resignation that Everything Everywhere All at Once steps in to offer clarity.", "Everything Everywhere All at Once Perfects Optimistic Nihilism)", "https://www.wired.com/story/everything-everywhere-all-at-once-review/", 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1907) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Password", "Type", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 1, 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(2522), "admin@konusarakogren.com.tr", "Admin", true, false, "admin", "123", 1, 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(2523) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Password", "Type", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 2, 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(2523), "selman@gmail.com", "Selman", true, false, "Koyan", "asd123", 2, 1, new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(2524) });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionID",
                table: "Answers",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ArticleID",
                table: "Questions",
                column: "ArticleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
