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
            Name = "Lilla Mysan",
            Slug = "lilla-mysan",
            CategorySlug = "shettis",
            BirthDate = "2001",
            Description = "Lilla Mysan var en älskad shetlandsponny med ett stort hjärta.",
            ImageUrl = "/images/memorial/lilla-mysan.jpg"
        },
        new MemorialHorse
        {
            Id = 2,
            Name = "Bamse",
            Slug = "bamse",
            CategorySlug = "russ",
            BirthDate = "1998",
            Description = "Bamse var ett tryggt gotlandsruss som betydde mycket för familjen.",
            ImageUrl = "/images/memorial/bamse.jpg"
        },
        new MemorialHorse
        {
            Id = 3,
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