using System.Collections.Generic;
using System.IO;

namespace CreateMltVolumeFiles
{
	public static class Library
	{
		public static string CreateVolumeFiles(DirectoryInfo directory)
		{
			var filePath = Path.Combine(directory.FullName, "_mlt.volume");
			File.Create(filePath).Dispose();

			return filePath;
		}

		public static IEnumerable<string> CreateVolumesSecondLevel(DirectoryInfo rootPath)
		{
			foreach (var directory in rootPath.EnumerateDirectories())
			{
				yield return CreateVolumeFiles(directory);
			}
		}
	}
}
