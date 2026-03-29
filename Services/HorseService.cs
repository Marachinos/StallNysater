using StallNysater.Models;

namespace StallNysater.Services;

public class HorseService
{
    private readonly List<Horse> _horses =
    [
        new Horse
        {
            Id = 1,
            Name = "Caracas Stecca (IT)",
            Slug = "caracas-stecca",
            BirthDate = "2018-05-18",
            Pedigree = "e. Napoleon Bar (IT) u. New Ginevra Bar (IT) ue. Viking Kronos (IT)",
            Breeder = "Emiliano Stecca, Italien",
            OwnerTrainer = "Evelina Jonsson, Mantorp",
            Description = "Caracas är en av hästarna på Stall Nysäter.",
            ImageUrl = "/images/horses/caracas/caracas01.jpg"
        },
        new Horse
        {
            Id = 2,
            Name = "Hackels Helios",
            Slug = "hackels-helios",
            BirthDate = "2023-04-26",
            Pedigree = "e. Monark Newmen u. Chaperonrouge W.F. ue. Igor November (IT)",
            Breeder = "Wassberger Martina, Rimforsa",
            OwnerTrainer = "Evelina Jonsson, Mantorp",
            Description = "Helios är en lovande unghäst på Stall Nysäter.",
            ImageUrl = "/images/horses/helios/helios01.jpg"
        },
        new Horse
        {
            Id = 3,
            Name = "Midsummer Express",
            Slug = "midsummer-express",
            BirthDate = "2024-06-21",
            Pedigree = "e. Express Bourbon (FR) u. Sparkle Sober ue. S.J.'S Caviar (US)",
            Breeder = "Sandra & Evelina Jonsson, Mantorp",
            OwnerTrainer = "Evelina Jonsson, Mantorp",
            Description = "Midde föddes på midsommar och har därför fått namnet Midsummer Express.",
            ImageUrl = "/images/horses/midde/midde01.jpg"
        }
    ];

    public List<Horse> GetAll()
    {
        return _horses;
    }

    public Horse? GetBySlug(string slug)
    {
        return _horses.FirstOrDefault(h =>
            h.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
    }
}