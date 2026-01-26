namespace AuthServiceIN6BM.Application.Interfaces;

public interface ICloundinaryService
{
    Task<string> UploadIMageAsync(IFileData imageFile, string filename);
    Task<bool> DeleteImageAsync(string publicId);
    string GetDefaultAvatarUrl();
    string GetFullImageUrl(string imagePath);
}