

namespace chore_score.Services;

public class PenguinsService
{
  private readonly PenguinsRepository _penguinsRepository;

  public PenguinsService(PenguinsRepository penguinsRepository)
  {
    _penguinsRepository = penguinsRepository;
  }

  internal Penguin CreatePenguin(Penguin penguinData)
  {
    Penguin penguin = _penguinsRepository.CreatePenguin(penguinData);
    return penguin;
  }

  internal string DeletePenguin(int penguinId)
  {
    Penguin penguin = GetPenguinById(penguinId);
    _penguinsRepository.DeletePenguin(penguin);

    return $"Penguin {penguin.Name} has been deleted";
  }

  internal Penguin GetPenguinById(int penguinId)
  {
    Penguin penguin = _penguinsRepository.GetPenguinById(penguinId);
    if (penguin == null)
    {
      throw new Exception($"No penguin with id of {penguinId} exists");
    }
    return penguin;
  }

  internal List<Penguin> GetPenguins()
  {
    List<Penguin> penguins = _penguinsRepository.GetPenguins();
    return penguins;
  }
}
