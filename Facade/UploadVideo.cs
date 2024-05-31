namespace DesignPatterns.Facade;

public class UploadVideo
{
    OggCompression oggCompression;
    BitrateReader bitrateReader;
    AudioMixer audioMixer;

    public UploadVideo()
    {
        oggCompression = new OggCompression();
        bitrateReader = new BitrateReader();
        audioMixer = new AudioMixer();
    }

    public void UploadComplete()
    {
        oggCompression.Compress();
        bitrateReader.ReadBitrate();
        audioMixer.MixAudio();
    }
}
