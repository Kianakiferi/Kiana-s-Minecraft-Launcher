using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Launcher
{

	public class Launcher
	{
        /*

		List<Game> games = new List<Game>();

		public Launcher()
		{

		}

        public void Start()
		{
            Launch(games.FirstOrDefault());
		}

		public Process Launch(Game game)
		{
			var process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = game.JavaPath,
					Arguments = GetArgument(version),
					WorkingDirectory = mc.File.Root.FullName,
					UseShellExecute = false,
					RedirectStandardInput = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				}
			};

			process.Start();
			return process;
		}
        

        public string GetArgument(Game game)
        {
            var mc = Locator.GetMinecraft(version, isolation);
            var args = new StringBuilder();

            #region Jvm args

            args.Append($"{game.JVMArguments} ");
            args.Append("-XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump ");
            args.Append("-XX:+UnlockExperimentalVMOptions ");
            args.Append("-XX:+UseG1GC ");
            args.Append("-XX:G1NewSizePercent=20 ");
            args.Append("-XX:G1ReservePercent=20 ");
            args.Append("-XX:MaxGCPauseMillis=50 ");
            args.Append("-XX:G1HeapRegionSize=32M ");
            args.Append($"-Djava.library.path=\"{mc.File.Natives}\" ");
            args.Append($"-Xmx{game.MaxMemory}G ");
            args.Append(game.MinMemory != null ? $"-Xmn{game.MaxMemory}G " : string.Empty);
            args.Append($"-classpath \"{string.Join(';', Locator.GetLibraries(version))};");
            args.Append(!mc.File.Jar.Exists ? $"{mc.Inherit.File.Jar}\" " : $"{mc.File.Jar}\" ");

            #endregion

            #region Main class

            args.Append($"{mc.Json.MainClass} ");

            #endregion

            #region Minecraft args

            args.Append($"--username \"{Auth.Name}\" ");
            args.Append($"--uuid \"{Auth.Uuid}\" ");
            args.Append($"--accessToken \"{Auth.AccessToken}\" ");
            args.Append($"--assetsDir \"{mc.File.Assets}\" ");
            args.Append($"--assetIndex \"{mc.RootVersion}\" ");
            args.Append($"--gameDir \"{mc.File.Root}\" ");
            args.Append($"--versionType \"{LauncherName}\" ");
            args.Append($"--version \"{LauncherName}\" ");
            args.Append(WindowWidth != null ? $"--width {WindowWidth} " : string.Empty);
            args.Append(WindowHeight != null ? $"--height {WindowHeight} " : string.Empty);
            args.Append(Fullscreen != null ? $"--fullscreen " : string.Empty);
            args.Append("--userProperties {} ");

            #endregion

            #region Attachment

            if (mc.Type.IsLoader())
            {
                var all = string.Empty;
                if (mc.Type == Minecraft.MinecraftJson.MinecraftType.NewLoader)
                {
                    mc.Json.Arguments["game"].ToObject<JArray>().ForEach(x =>
                    {
                        if (x is JValue)
                        {
                            all += $"{x} ";
                        }
                    });
                }
                else
                {
                    all = mc.Json.MinecraftArguments;
                }

                if (!string.IsNullOrEmpty(all))
                    args.Append($"{all.Substring(all.LastIndexOf("} ") + 2)}");
            }
            args.Append(mc.Type.IsLoader() ? $"" : string.Empty);

            #endregion

            return args.ToString().Trim();
        }
        */

    }



}
