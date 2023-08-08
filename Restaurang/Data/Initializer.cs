using Restaurang.Data;
using Restaurang.Models;
using System.Linq;

public static class Initializer
{
    public static void InitializerDB(RestaurangDbContext context)

    {
        context.Database.EnsureCreated();
        if (!context.Dishes.Any())
        {
            var dishes = new Dish[]
            {
                
     new Dish {
         Name = "Pizza Lidköping",
         Description = "En läcker pizza med tomatsås, mozzarella ost, prosciuto och svamp",
         Price = 120M,
         Image = "Images/Pizza.jpg",
         CategoryId = 1,
         Ingredients = "Tomater, Ost, Svamp, Salami"
     },
     new Dish {
         Name = "Pasta linguine Frutti di Mare",
         Description = "Den klassiska italienska fisk- och skaldjurspastan med vitlök, tomat, vitt vin och persilja. Perfekt att lyxa till sig på helgen och njuta tillsammans med familj och vänner.",
         Price = 240M,
         Image = "Images/Pasta.jpg",
         CategoryId = 2,
         Ingredients = "Vitlök, Tomat, Vitt vin, Persilja"
     },

     new Dish {
         Name = "Carbonara",
         Description = "En traditionell italiensk pasta med grädde, äggula, pancetta och parmesan.",
         Price = 225M,
         Image = "Images/Carbonera.jpg",
         CategoryId = 3,
         Ingredients = "Pasta, Grädde, Äggula, Pancetta, Parmesan"
     },



     new Dish {
         Name = "Pizza Monte Carlo",
         Description = "En läcker pizza med tomatsås, albansk ost, prosciuto och svamp",
         Price = 120M,
         Image = "Images/piga.jpg",
         CategoryId = 4,
         Ingredients = "Tomater, Ost, Svamp, Salami, Pepperoni, vitlök sås"
     },

     new Dish {
         Name = "Pizza Albanese",
         Description = "En traditionell albansk pizza med tomatsås, grekiskt ost, oxfile och svamp",
         Price = 145M,
         Image = "Images/pizzaN.jpg",
         CategoryId = 5,
         Ingredients = "Tomater, Ost, Svamp, Salami, Pepperoni, vitlök sås"
     },

     new Dish {
         Name = "Oxfile pasta",
         Description = "Oxfilépasta en krämig pasta med pasta som penne, lyxig oxfilé, svamp och grädde.",
         Price = 240M,
         Image = "Images/Oxfile.jpg",
         CategoryId = 6,
         Ingredients = "Tomatsallad, grönsallad och/eller färsk spenat blandad med balsamvinäger, riven parmesan samt vinäger"
     },

     new Dish {
         Name = "Entrecote",
         Description = "Entrecóte med ugnsrostad potatis, grönsaker och béarnaise.",
         Price = 280M,
         Image = "Images/Entreqo.jpg",
         CategoryId = 7,
         Ingredients = " zuccini, röd paprika, gul paprika, 1 knippe salladslök"
     },

     new Dish {
         Name = "HÖGREVSBURGARE",
         Description = "En klassisk burgare där de rostade körsbärstomaterna bidrar med premiumkänsla och ljuvlig sötma. Chilimajonnäsen förstärker burgarens smak..",
         Price = 165M,
         Image = "Images/Hamburg.jpg",
         CategoryId = 8,
         Ingredients = " En klassisk burgare där de rostade körsbärstomaterna bidrar med premiumkänsla och ljuvlig sötma. Chilimajonnäsen förstärker burgarens smak."
     },
     new Dish {
         Name = "Kycklingspett",
         Description = "Grillade kycklingspett med grekisk sallad och tzatziki,",
         Price = 220M,
         Image = "Images/Kycklingspett.jpg",
         CategoryId = 9,
         Ingredients = " Grillad kyckling är mångas favorit. Vi gör det enkelt och penslar med Kloka rapsstekolja med smörsmak och kryddar med chili och vitlök. En fräsch grekisk sallad med fetaost, gurka, tomat och oliver samt tzatziki.",

            },
      };

            foreach (Dish dish in dishes)
            {
                context.Dishes.Add(dish);
            }

            context.SaveChanges();
        }

        if (!context.Drinks.Any())
        {
            var drinks = new Drink[]
            {
            new Drink{
                Name="Öl",
                Description="Lokalt bryggd lager",
                Price=59M,
                Image="Images/Beer.png",
                CategoryId=1,
            },

            new Drink{
                Name="Vin",
                Description="Utmärkt rött vin från Frankrike",
                Price=98M,
                Image="Images/Röttvin.jpg",
                CategoryId=2,
            },

            new Drink{
                Name="Vin",
                Description="Husets rödda vin från Italien",
                Price=79M,
                Image="Images/Wine1.jpg",
                CategoryId=3,
            },

            new Drink{
                Name="Coca-Cola",
                Description="Passar bra till alla maträtter",
                Price=30M,
                Image="Images/Cola.png",
                CategoryId=3,
            },

            new Drink{
                Name="Cola Zero",
                Description="Passar bra till alla maträtter,Sockerfri",
                Price=30M,
                Image="Images/ColaZero.jpg",
                CategoryId=4,
            },

            new Drink{
                Name="Kaffe",
                Description="Svensk klassisk kaffe",
                Price=20M,
                Image="Images/cafe.jpg",
                CategoryId=5,
            },
             new Drink{
                Name="Festis",
                Description="Finns med jordgubb eller Äpple smak",
                Price=20M,
                Image="Images/festis.jpg",
                CategoryId=6,
            },
            };

            foreach (Drink drink in drinks)
            {
                context.Drinks.Add(drink);
            }

            context.SaveChanges();
        }
    }

    }
