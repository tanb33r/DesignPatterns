namespace DesignPatterns.Facade;

public class VideoUploadSystem
{
    public VideoUploadSystem()
    {
        UploadVideo uploadVideoFacade = new UploadVideo();
        uploadVideoFacade.UploadComplete();
        Console.WriteLine();
    }
}
