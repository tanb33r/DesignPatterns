namespace DesignPatterns.Command;

public class DeleteCommand : ICommand
{
  private readonly Button button;

  public DeleteCommand(Button button)
  {
    this.button = button;
  }

  public void Execute()
  {
    button.Delete();
  }
}
