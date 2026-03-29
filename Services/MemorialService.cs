using StallNysater.Models;

namespace StallNysater.Services;

public class MemorialService
{
    private readonly List<MemorialCategory> _categories =
    [
        new MemorialCategory
        {
            Name = "Shetlandsponny",
            Slug = "shettis",
            ImageUrl = "/images/memorial/shettis.jpg"
        },
        new MemorialCategory
        {
            Name = "Gotlandsruss",
            Slug = "russ",
            ImageUrl = "/images/memorial/russ.jpg"
        },
        new MemorialCategory
        {
            Name = "Varmblod",
            Slug = "varmblod",
            ImageUrl = "/images/memorial/varmblod.jpg"
        }
    ];

    private readonly List<MemorialHorse> _horses =
    [
        new MemorialHorse
        {
            Id = 1,
            Name = "Änglagårds Capones Girl",
            Slug = "capon",
            CategorySlug = "shettis",
            BirthDate = "1996-05-28",
            Description = "- vår allra första shettis som, tillsammans med sin son Zingo, flyttade in hos oss augusti 2005." +
            "\nCapon var verkligen en bra 1:a ponny för Eve. Väldigt trevlig och snäll att köra. " +
            "\nExporterades till Finland i början mars 2009. Fick där ett föl." +
            "\nCapon lever tyvärr inte längre.",
            Resultat = 
            "39 starter" +
            "\n1-1-3" +
            "\n4 125 pp" +
            "\n*3.00,6k 3.16,6ak",
            ImageUrl = "/images/memorial/lilla-mysan.jpg"
        },
         new MemorialHorse
        {
            Id = 2,
            Name = "Zingo",
            Slug = "zingo",
            CategorySlug = "shettis",
            BirthDate = "2003-05-25",
            Description = "- flyttade hit, i augusti 2005, tillsammans med sin mamma Capon." +
             "\nEn bestämd herre, som kunde vara väldigt bekväm när man körde honom." +
             "\nI början av hans karriär körde travskoleledaren Malin Lindström honom med bravur." +
             "\nNär han blev äldre och klokare så fick han fart på benen." +
             "\nFlyttade från oss i juni 2008. Exporterades till Danmark 2011.",
            Resultat = 
             "Starter i Norden: 94 starter" +
             "\n12-10-16" +
             "\n17 000 pp *6875" +
             "\n2.35,3k 2.39,1ak",
            ImageUrl = "/images/memorial/lilla-mysan.jpg"
        },
        new MemorialHorse
        {
            Id = 3,
            Name = "SuperIor Noir",
            Slug = "ior",
            CategorySlug = "shettis",
            BirthDate = "2002-05-08",
            Description = "-Ior flyttade hit ifrån Gotland i april 2007. " +
            "\nHan blev den ponnyn som gav Eve sin 1:a seger (det var dessutom ett LILA täcke i vinst). " +
            "\nVann 3 av sina vinster med Eve i sulkyn. Han flyttade från oss i juli 2012.",
            Resultat =
             "65 starter" +
            "\n5-6-7" +
            "\n5600 pp" +
            "2.51,0k 2.55,1ak",
            ImageUrl = "/images/memorial/lilla-mysan.jpg"
        },
        new MemorialHorse
        {
            Id = 4,
            Name = "Ellens Bacardi",
            Slug = "bacardi",
            CategorySlug = "shettis",
            BirthDate = "2006-05-20",
            Description = "Bacardi flyttade till oss i augusti 2010. Var en ponny med mycket spring i benen, men kunde vara rädd för traktorer. " +
            "\nEtt lopp vi minns är 28/11-10, det var snöstorm men vi trotsade vädret och åkte till Örebro. " +
            "\nMen det visade sig vara en lyckad tur. Bacardi vann överlägset och då ett nytt rekord. " +
            "\nLite kuriosa så var det sista loppet som prispengar delades ut till kat. A, efter det blev det prispoäng. " +
            "\nBacardi flyttade ifrån oss mars 2012, då han exporterades till Norge. Bacardi lever tyvärr inte längre.",
            Resultat =
            "Starter i Sverige: 47" +
            "\n6-8-3" +
            "\n7 050 pp" +
            "\n2.42,8k *2.43,6ak",
            ImageUrl = "/images/memorial/lilla-mysan.jpg"
        },
        new MemorialHorse
        {
            Id = 10,
            Name = "Tip Top",
            Slug = "tip-top",
            CategorySlug = "russ",
            BirthDate = "2010",
            Description = "Tippen var ett tryggt gotlandsruss som betydde mycket för familjen.",
            ImageUrl = "/images/history/tippen/tippen01.jpg"
        },
        new MemorialHorse
        {
            Id = 30,
            Name = "Stjärna",
            Slug = "stjarna",
            CategorySlug = "varmblod",
            BirthDate = "2005",
            Description = "Stjärna var ett varmt och klokt varmblod som alltid kommer att minnas.",
            ImageUrl = "/images/memorial/stjarna.jpg"
        }
    ];

    public List<MemorialCategory> GetCategories()
    {
        return _categories;
    }

    public List<MemorialHorse> GetHorsesByCategory(string categorySlug)
    {
        return _horses
            .Where(h => h.CategorySlug.Equals(categorySlug, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public MemorialHorse? GetHorse(string categorySlug, string horseSlug)
    {
        return _horses.FirstOrDefault(h =>
            h.CategorySlug.Equals(categorySlug, StringComparison.OrdinalIgnoreCase) &&
            h.Slug.Equals(horseSlug, StringComparison.OrdinalIgnoreCase));
    }
}