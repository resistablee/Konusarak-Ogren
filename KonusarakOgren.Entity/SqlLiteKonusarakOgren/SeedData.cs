﻿using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Article;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entity.SqlLiteKonusarakOgren
{
    public static class SeedData
    {
        public static List<Article> articleList = new List<Article>()
        {
            new Article()
            {
                Id = 1,
                Title = "Review: Cuisinart 4-Slice Belgian Waffle Maker",
                Text = @"IF YOU THINK waffle irons are just for making waffles, I'm here to change your world. They're the best way to make hash browns at home, and they’re also great for omelets, cornbread, birthday cakes, cookies, falafel, and darn near anything else you can think to put in them. I know this because I've spent years living in a vintage RV with a broken oven and relied on a waffle iron for nearly all my “baking.” 
                        If your waffle iron is going to do all that, though, it needs to be up to the task. When I first bought one, it was on a whim, and I got the cheapest I could find. It worked, but it only made two waffles at a time. Here's a recipe for conflict: Have three kids and then get a waffle iron that makes just two waffles at a time. 
                        When that ultra-budget model died, I started looking around for a replacement that could make four waffles at a time and stand up to the greater level of not-technically-waffles abuse I was going to throw at it. Most of all, it needed to be easy to clean. The Cuisinart 4-Slice Belgian Waffle Maker ticks most of these boxes and isn't terribly expensive either. 
                        Waffle Talk 
                        Cuisinart's waffle maker is solidly made, with a sleek stainless lid surrounded by sturdy plastic. It's a pretty good size—roughly 14 inches deep, 10 inches wide, and 5 inches high—meaning it will take up considerable counter space if you leave it out. Fortunately, it's not too heavy (10 pounds), so I shove it in a cabinet under the counter when it's not being used. 
                        This model makes 1-inch thick waffles with reasonably deep holes. The results are not quite what I'd call a Belgian waffle, but the precise meaning of that term is highly debatable—some say it's the batter, some say it's the thickness, others think it's the shape. What matters from an I'm-not-just-making-waffles point of view is that Cuisinart's waffle plates are cast aluminum and well-coated in a nonstick material that really is nonstick. 
                        I've been using it two to three times a week for several months, and there's no sign of wear on the plates, no scratches in the nonstick, and still no sticking—and I never grease it before adding batter. That's after making hash browns, cornbread, two birthday cakes, and plenty of other non-waffle cooking. 
                        The secret to the long life of any nonstick coating is to never use metal tools of any kind on it. Get a good silicone spatula to help gently pry out your waffles. I use one very similar to this Oxo version. The silicone won't scratch the Cuisinart's plates and, because it's heat-proof, you won't melt your spatula. 
                        Waffly Good 
                        This waffle maker has a very simple, five-setting temperature control. A green indicator light lets you know when the iron is ready, then again when your waffles are done. That said, I almost never pay attention to the indicator light. Everyone in my family likes their waffles at different levels of brownness and crispiness, so I'd constantly be fiddling with the temp settings to make everyone happy. Instead, I set it to three and let the kids keep cooking it as long as they want. My pro tip? Never open your waffle iron before the green light turns on, but don't assume your waffle is done just because the green light is on. 
                        This Cuisinart offers a good range of brownness through the one to five settings and errs on the undercooked side, which is to say that setting it to five won't burn your waffles. Once you move beyond simple waffles to things like hash browns, the temperature settings won't do you much good—you'll want to time your cooking just like you would in an oven. 
                        When it first arrived, my one gripe was that the plates don’t pop out, which would make them easier to clean. But this has turned out to be a nonissue. I wipe it down with a damp rag after each use. It's also not that heavy, so you can turn it around to get a good angle on all sides. It still would be nice if those plates came out, because at some point the nonstick will start to fail—I've never owned anything nonstick that didn't eventually become stick. At least I'd be able to take them out and scrub them if needed. Still, I don't consider the nonremovable plates a deal-breaker at all. 
                        Whether you should spend $60 on this waffle maker probably depends mostly on how often you make waffles. If waffles are a special treat you enjoy a couple of times a year, a cheaper waffle iron might suffice. For those of us who are more serious about waffles, this is well worth the investment.",
                URL = "https://www.wired.com/review/cuisinart-4-slice-belgian-waffle-maker/"
            },

            new Article()
            {
                Id=2,
                Title = "Omega and Swatch’s $260 MoonSwatch Looks Out of This World",
                Text = @"OMEGA AND SWATCH have announced a budget version of the iconic Speedster Moonwatch, an astronaut-inspired piece that usually retails for thousands of dollars. The MoonSwatch is the first collaboration between the two brands (both part of the Swatch Group, which also holds Longines, Tissot, and Hamilton). It goes on sale Saturday in Swatch stores only and will cost just $260 (£207).",
                URL= "https://www.wired.com/story/omega-and-swatch-moonswatch/"
            },

            new Article()
            {
                Id = 3,
                Title = "Review: Motorola Edge+ (2022)",
                Text = @"THE MOTOROLA EDGE+ is a flagship Android smartphone. It's got some high-end features, like an uncommon 144-Hz screen refresh rate, plus the same Qualcomm Snapdragon 8 Gen 1 processor that powers other expensive phones, like the Samsung Galaxy S22 series. But if you're vying for the Big Leagues, you need to bring your A game.
                         Unfortunately, there are a few areas where this new Motorola phone falls short of its peers. It's fine, but it would make more sense if it cost $600, rather than $1,000. Heck, even Motorola thinks it's not worth the high price; the company is shaving $100 off for the first few weeks of launch, after which it will go back to MSRP. But even at $900, you've got better options. 
                         
                         Edge of Glory

                         Let's start with the good: This is a snappy phone. It helps to have the high-end chip of the year paired with 8 gigabytes of RAM (upgradable to 12 GB if you so desire). Every app launch and scroll through Twitter feels buttery smooth, and demanding games like Genshin Impact run fairly well. 
                         The 144-Hz screen refresh rate helps a lot with making the phone feel responsive. It means the screen is refreshing 144 times per second to give you the smoothest animations (as opposed to 60 Hz on most midrange and budget phones). Most flagship phones offer 120 Hz, and I'm honestly not sure 144 Hz adds much of a difference here (eagle-eyed gamers, don't @ me).  I set the phone to 144 Hz during my testing, but there is an Auto mode you can use to have the phone decide when to use a high refresh rate and when to lower it, which conserves battery life.
                         That said, I never worried about carrying around a dead phone. The Edge+ has a 4,800-mAh battery capacity that often left me with around 35 percent before bed, sometimes a little more. It's no two-day battery life, but it's reliable. It recharges wirelessly or via USB-C.
                         The 6.7-inch pOLED screen is sharp and colorful, and it gets bright enough to see clearly on sunny days (though nowhere near as bright as similarly priced Samsung or OnePlus phones). Still, there's no squinting required. However, two hands are required to comfortably hold and use this phone; it's nearly as big as the gargantuan Samsung Galaxy S22 Ultra. Even with my large hands, I often had to shimmy the phone down to reach the top of the screen. At least it's easy to access the fingerprint sensor, which is embedded in the power button on the side. 
                         I like the software experience. You get Android 12 in a clean state with very few modifications on Motorola's part—it looks and feels like a Pixel sometimes, minus the software smarts Google provides on its phone. (I tested the Verizon variant of the Edge+, which does come with bloatware, some of which is removable; always go for the unlocked model instead.) Unlike its cheap phones, Motorola also includes NFC, so you can make contactless payments via Google Pay.
                         Motorola has a platform called “Ready for” in this phone (and a few other Moto devices), and it's surprisingly handy. I was able to wirelessly connect the Edge+ to my TCL TV (requires a TV with Miracast support) to run Android in desktop mode, and I even placed a Duo video call on the big screen while using the phone as a webcam. You can also use your phone as a remote control, or even stream games running on your phone. That said, I tried to play Genshin Impact on my TV with this system, but the input lag was unbearable and I needed a Bluetooth controller to play.
                         I wirelessly connected the Edge+ to my Windows PC (no MacOS support, sadly) and was able to run Android apps, respond to texts, and transfer files—akin to Samsung's DeX mode. I can see this being helpful in select situations, but “Ready for” is not a reason to buy this device.
                         
                         Livin' on the Edge

                         Nearly every phone that costs $700 and up these days comes with the holy trinity of camera systems: main camera, ultrawide, and telephoto. The Edge+ skips the latter. Yes, there are three cameras on the back, but one of them is a depth sensor for improving Portrait mode photos. The ultrawide can double as a macro camera for super close-ups, but the only macro photo I want to take is of my dog's nose. That's it. I’d really have liked to see a zoom lens here.
",
                URL = "https://www.wired.com/review/motorola-edge-plus-2022/"
            },

            new Article()
            {
                Id = 4,
                Title = "Leica’s New Camera Puts Skill Back Into Focus",
                Text = @"LEICA'S NEW M11 digital rangefinder camera may as well come from an entirely different era. Don't get me wrong; the technology inside of it makes it feel plenty modern. The M11 has a high-resolution sensor (a 60-megapixel backside-illuminated full-frame CMOS sensor to be precise), sophisticated metering tools, and even some of the usual digital accoutrements of cameras in our age. But in many ways, it works like the film cameras your parents owned. It thumbs its nose at autofocus, it doesn’t capture video, and it’s perfectly happy to accept lenses that are decades old.",
                URL = "https://www.wired.com/story/leica-m11-digital-rangefinder/"
            },

            new Article()
            {
                Id = 5,
                Title = "Everything Everywhere All at Once Perfects Optimistic Nihilism)",
                Text = @"IN 2012, THE legendary Twitter account @horse_ebooks tweeted, “Everything happens so much.“ Despite bordering on nonsense, the message singularly captured the feeling of exhaustion that comes with trying to keep up with the flood of inputs that demand attention every day. It is in this place of chaotic resignation that Everything Everywhere All at Once steps in to offer clarity.",
                URL = "https://www.wired.com/story/everything-everywhere-all-at-once-review/"
            }
        };

        public static List<User> userList = new()
        {
            new User() { Id = 1, FirstName = "Admin", LastName = "admin", Email = "admin@konusarakogren.com.tr", Password = "123", IsActive = true, Type = UserType.Admin },
            new User() { Id = 2, FirstName = "Selman", LastName = "Koyan", Email = "selman@gmail.com", Password = "asd123", IsActive = true, Type = UserType.User },
        };
    }
}
