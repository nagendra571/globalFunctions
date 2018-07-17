using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.WindowsAzure.Storage.Blob;

namespace nagglobalfunctions
{
    public static class ImageAnalysis
    {
        [FunctionName("ImageAnalysis")]
        public static void Run([BlobTrigger("Images/{name}", Connection = "BlobStorageConnectionString")]
        CloudBlockBlob myBlob, string name, TraceWriter log)
        {
            log.Info($"C# Blob trigger function Processed blob\n Name:{myBlob.Name} \n Size: {myBlob.Properties.Length} Bytes");
        }
    }
}
