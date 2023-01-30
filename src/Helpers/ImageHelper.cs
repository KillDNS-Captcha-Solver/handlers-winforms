namespace KillDNS.CaptchaSolver.Handlers.WinForms.Helpers;

public static class ImageHelper
{
    public static Image ByteToImage(byte[] blob)
    {
        if (blob == null)
            throw new ArgumentNullException(nameof(blob));
        
        
        using MemoryStream mStream = new(blob);
        return Image.FromStream(mStream);
    }
}