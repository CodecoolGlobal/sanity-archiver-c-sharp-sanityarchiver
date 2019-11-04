using System.Collections.Generic;
using System.IO;
using System.IO.Compression;



namespace SanityArchiver.Application.Models
{
    public static class ZipFileCreator
    {
        /// <summary>
        /// Create a ZIP file of the files provided.
        /// </summary>
        /// <param name="fileName">The full path and name to store the ZIP file at.</param>
        /// <param name="files">The list of files to be added.</param>
        public static void CreateZipFile(string fileName, IEnumerable<string> files, string archiveName)
        {
            // Create and open a new ZIP file
            var zip = ZipFile.Open(fileName + "/" + archiveName + ".rar", ZipArchiveMode.Create);
            foreach (var file in files)
            {
                // Add the entry for each file
                zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);
            }
            // Dispose of the object when we are done
            zip.Dispose();
        }
        public static void DecompressFile(string fileName, string directoryPath)
        {
            System.IO.Compression.ZipFile.ExtractToDirectory(fileName, directoryPath);



        }

    }
}
