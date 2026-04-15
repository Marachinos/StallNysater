using StallNysater.Models;

namespace StallNysater.Services;

public class RememberedRaceService
{
    private readonly List<RememberedRace> _races =
    [
        new RememberedRace
        {
            Id = 1,
            HorseName = "Caracas Stecca (IT)",
            Title = "Rättvik 2024-05-12 Lopp 3",
            Description = "Ett minnesvärt lopp där Caracas vann sitt första lopp.",
            YouTubeUrl = "https://youtu.be/shVLeDCj-4c?is=HfuC1p8QlEVJouHm"
        },
         new RememberedRace
        {
            Id = 2,
            HorseName = "Downton Abbe C.G",
            Title = "Axevalla 2018-11-13 Lopp 1",
            Description = "Abbey's Enda lopp hon vann.",
            YouTubeUrl = "https://youtu.be/C4X1WY1pRrE?is=ebccmE2HcNitgyCr"
        },

        new RememberedRace
        {
            Id = 20,
            HorseName = "Gina B.T",
            Title = "Rättvik 2018-06-23 Cool Keepers Lilla Midsommarloppet",
            Description = "Från bricka 1 travade Gina närmsta vägen från start till mål.",
            YouTubeUrl = "https://youtu.be/SL32JMd67NI?is=D7VLO6m1gX_h2DfW"
        },
        new RememberedRace
        {
            Id = 21,
            HorseName = "Gina B.T",
            Title = "Lindesberg 2018-06-10 Lopp 2",
            Description = "Från bricka 15 rundade Gina hela fältet",
            YouTubeUrl = "https://youtu.be/GKF9siQoIq8?is=80hZum483Qp2Amep"
        },

        new RememberedRace
        {
            Id = 22,
            HorseName = "Tip Top",
            Title = "Färjestad 2015-10-06 5-års Mästerkapet kat. B",
            Description = "Tippens absolut sista lopp OCH vinst i Sverige. Det gick undan på mellan 500m och 1000m.",
            YouTubeUrl = "https://youtu.be/Rk5Kpspyo8I?is=0fRnrJ_0nJiyzPxC"
        },

        new RememberedRace
        {
            Id = 23,
            HorseName = "Tip Top",
            Title = "Jägersro 2014-09-07 Svenskt PonnyTravDerby kat. B",
            Description = "Tippens enkla vinst i mästerskapsloppet Svenskt PonnyTravDerby",
            YouTubeUrl = "https://youtu.be/kK5v_9YyZpU?is=4n6zVvecJFB_LWqf"
        },

        new RememberedRace
        {
            Id = 24,
            HorseName = "Tip Top",
            Title = "Axevalla 2014-06-03",
            Description = "Tippens enkla vinst, trots trafikproblem och med ett Hej Då och Tack för sällskapet.",
            YouTubeUrl = "https://youtu.be/LiBSuNteGw8?si=ykZEOUrBkqdpdb7-"
        }
    ];

    public List<RememberedRace> GetAll()
    {
        return _races;
    }
}