namespace chore_score.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PenguinsController : ControllerBase
{
  private readonly PenguinsService _penguinsService;

  public PenguinsController(PenguinsService penguinsService)
  {
    _penguinsService = penguinsService;
  }

  [HttpGet]
  public ActionResult<List<Penguin>> GetPenguins()
  {
    try
    {
      List<Penguin> penguins = _penguinsService.GetPenguins();
      return Ok(penguins);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpGet("{penguinId}")]
  public ActionResult<Penguin> GetPenguinById(int penguinId)
  {
    try
    {
      Penguin penguin = _penguinsService.GetPenguinById(penguinId);
      return Ok(penguin);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpPost]
  public ActionResult<Penguin> CreatePenguin([FromBody] Penguin penguinData)
  {
    try
    {
      Penguin penguin = _penguinsService.CreatePenguin(penguinData);
      return Ok(penguin);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpDelete("{penguinId}")]
  public ActionResult<string> DeletePenguin(int penguinId)
  {
    try
    {
      string message = _penguinsService.DeletePenguin(penguinId);
      return Ok(message);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }
}