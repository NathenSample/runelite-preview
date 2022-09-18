using Cake.Common.IO;
using Cake.Frosting;

namespace Build.Tasks
{
	[Dependency(typeof(Build))]
	public sealed class Zip : FrostingTask<Context>
	{
		public override void Run(Context context)
		{
			if (!context.DirectoryExists(Configuration.PublishFolder))
			{
				context.CreateDirectory(Configuration.PublishFolder);
			}

			context.Zip(Configuration.BinFolder, Configuration.PublishFolder + "/Runelite Preview.zip",
				new[] { Configuration.BinFolder + "/Runelite Preview.exe", Configuration.BinFolder + "/readme.pdf" });
		}
	}
}