using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using CreateMltVolumeFiles;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
	[TestClass]
	public class TestVolume
	{
		[TestMethod]
		public void CreateVolumeFilesShouldReturnPath()
		{
			var path = "E:\\test1";
			var dirInfo = new DirectoryInfo(path);

			var result = Library.CreateVolumeFiles(dirInfo);

			Assert.AreEqual("E:\\test1\\_mlt.volume", result);
		}

		[TestMethod]
		[ExpectedException(typeof(DirectoryNotFoundException))]
		public void CreateVolumeFilesShouldThrowException()
		{
			var path = "randomstring";
			var dirInfo = new DirectoryInfo(path);
			Library.CreateVolumeFiles(dirInfo);
		}

		[TestMethod]
		public void CreateVolumesSecondLevelShouldReturnIEnumerableStrings()
		{
			var path = "E:\\test1";
			var dirInfo = new DirectoryInfo(path);
			var result = Library.CreateVolumesSecondLevel(dirInfo);

			IEnumerable<string> expectedResult = new List<string>
			{
				"E:\\test1\\test2\\_mlt.volume",
				"E:\\test1\\test3\\_mlt.volume"
			};

			Assert.IsTrue(result.Where(x => expectedResult
				.Any(y => x == y))
				.Count() == expectedResult.Count()
			);
		}

		[TestMethod]
		public void CreateVolumesSecondLevelShouldReturnIEnumerableEmpty()
		{
			var path = "E:\\test1\\test2";
			var dirInfo = new DirectoryInfo(path);
			var result = Library.CreateVolumesSecondLevel(dirInfo);

			Assert.IsTrue(result.Count() == 0);
		}
	}
}
