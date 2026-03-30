namespace StallNysater.Models;

public class Horse
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Slug { get; set; } = "";
    public string BirthDate { get; set; } = "";
    public string Pedigree { get; set; } = "";
    public string Breeder { get; set; } = "";
    public string OwnerTrainer { get; set; } = "";
    public string Description { get; set; } = "";
    public string ImageUrl { get; set; } = "";

    public List<RaceResult> Results { get; set; } = [];
    public HorseSummary? Summary { get; set; }
}