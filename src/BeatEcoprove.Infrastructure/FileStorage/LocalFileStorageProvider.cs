using BeatEcoprove.Application.Shared.Interfaces.Providers;
using Microsoft.Extensions.Options;

namespace BeatEcoprove.Infrastructure.FileStorage;

public class LocalFileStorageProvider : IFileStorageProvider
{
    private readonly LocalFileStorageSettings _settings;

    public LocalFileStorageProvider(IOptions<LocalFileStorageSettings> settings)
    {
        _settings = settings.Value;
    }

    public async Task<string> UploadFileAsync(string bucketName, string fileName, Stream stream, CancellationToken cancellationToken = default)
    {
        var pointerName = Path.Combine(bucketName, fileName + ".png");
        var bucketPath = Path.Combine(_settings.FolderPath, bucketName);
        
        if (!Directory.Exists(bucketPath))
        {
            Directory.CreateDirectory(bucketPath);
        }
        
        var path = Path.Combine(_settings.FolderPath, pointerName);

        await using var fileStream = new FileStream(path, stream.CanSeek ? FileMode.Create : FileMode.CreateNew);
        await stream.CopyToAsync(fileStream, cancellationToken);
        
        return new UriBuilder(_settings.BaseUrl)
        {
            Path = Path.Combine(_settings.PublicFolder, pointerName)
        }.ToString();
    }
}