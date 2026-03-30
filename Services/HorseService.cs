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
            ImageUrl = "/images/horses/caracas/caracas01.jpg",
            Summary = new HorseSummary
            {
                Starts = "47 starter",
                Earnings = "131 800 kr",
                Placings = "1-0-1",
                Records = "16,6m 14,2ak 16,2am"
            },
            Results =
            [
                new RaceResult
                {
                    Date = "2024-05-12",
                    Track = "Rättvik",
                    Placement = "1",
                    Distance = "1640m",
                    Time = "1.16,4a",
                    Driver = "Evelina Jonsson"
                },
                new RaceResult
                {
                    Date = "2025-04-07",
                    Track = "Mantorp",
                    Placement = "3",
                    Distance = "2140m",
                    Time = "1.16,2a",
                    Driver = "Kim Lagerhem"
                }
            ]
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
            ImageUrl = "/images/horses/helios/helios01.jpg",
            Results =
            [
                new RaceResult
                {
                    Date = "2025-06-19",
                    Track = "Mantorp",
                    Placement = "1p",
                    Distance = "2140m",
                    Time = "1.32,9",
                    Driver = "Evelina Jonsson"
                }
            ]
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