namespace chore_score.Models;
public class Penguin
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Color { get; set; }
  public bool IsBuff { get; set; }
  public int Rating { get; set; }

  public Penguin(int id, string name, string color, bool isBuff, int rating)
  {
    Id = id;
    Name = name;
    Color = color;
    IsBuff = isBuff;
    Rating = rating;
  }
}
