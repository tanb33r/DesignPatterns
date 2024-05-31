namespace DesignPatterns.Command;

public class DeleteCommand : ICommand
{
  private readonly Button light;

  public DeleteCommand(Button light)
  {
    this.light = light;
  }

  public void Execute()
  {
    light.Delete();
  }
}
