



namespace chore_score.Repositories;

public class PenguinsRepository
{
  private List<Penguin> _penguins;

  public PenguinsRepository()
  {
    _penguins = [
      new Penguin(1, "Roald", "Blue", true, 10),
      new Penguin(2, "Hopper", "Black", false, 3),
      new Penguin(3, "Boomer", "Green", false, 4)
    ];
  }

  internal Penguin CreatePenguin(Penguin penguinData)
  {
    Penguin lastPenguin = _penguins[_penguins.Count - 1];
    if (lastPenguin == null)
    {
      penguinData.Id = 1;
    }
    else
    {
      penguinData.Id = lastPenguin.Id + 1;
    }
    _penguins.Add(penguinData);
    return penguinData;
  }

  internal void DeletePenguin(Penguin penguin)
  {
    _penguins.Remove(penguin);
  }

  internal Penguin GetPenguinById(int penguinId)
  {
    Penguin foundPenguin = _penguins.Find(penguin => penguin.Id == penguinId);
    return foundPenguin;
  }

  internal List<Penguin> GetPenguins()
  {
    return _penguins;
  }
}
