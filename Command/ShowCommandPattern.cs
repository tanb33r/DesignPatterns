namespace DesignPatterns.Command;

public class ShowCommandPattern
{
  public ShowCommandPattern()
  {
    Button button = new Button();
    SaveCommand saveButton = new SaveCommand(button);
    DeleteCommand deleteButton = new DeleteCommand(button);
    
    // we can define different functionalities inside same structure
    // based on our needs, lessening redundancy

    saveButton.Execute();
    deleteButton.Execute();
  }
}
