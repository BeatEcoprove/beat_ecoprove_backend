namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IFileStorageProvider
{
    Task<string> UploadFileAsync(string bucketName, string fileName, Stream stream,
        CancellationToken cancellationToken = default);
}