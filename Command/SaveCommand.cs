namespace DesignPatterns.Command;

public class SaveCommand : ICommand
{
  private readonly Button button;

  public SaveCommand(Button button)
  {
    this.button = button;
  }

  public void Execute()
  {
    button.Save();
  }
}
