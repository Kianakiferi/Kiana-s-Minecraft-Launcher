using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Launcher
{
	class Environment
	{
		public enum PlatformEnum
		{
			ARM,
			ARM64,
			x86,
			x64
		}

		public class Java
		{
			public string Path { get; set; }
			public string Version { get; set; }
			public PlatformEnum Bits { get; set; }
		}

		public static class JavaManager
		{
			//TODO: 在C# 9.0中,在 new 表达式中省略已知对象类型的类型。new();
			static Dictionary<string, string>  JavaPathList = new Dictionary<string, string>();

			//TODO: 异步方法。Async();
			public static Dictionary<string, string> GetJavaPaths()
			{
				//TODO: 测试奇怪的Registry Key?
				var localMachineKey = Registry.LocalMachine;

				var softwareKey = localMachineKey.OpenSubKey("SOFTWARE");
				var javaSoftKey = softwareKey?.OpenSubKey("JavaSoft");

				//TODO: 测试不同Key名称之间有无区别
				var jre = javaSoftKey?.OpenSubKey("Java Runtime Environment");
				var jre2 = javaSoftKey?.OpenSubKey("JRE");

				var jdk = javaSoftKey?.OpenSubKey("Java Development Kit");
				var jdk2 = javaSoftKey?.OpenSubKey("JDK");

				try
				{
					GetRegistryKeyJava(jdk);
					GetRegistryKeyJava(jdk2);
					
					GetRegistryKeyJava(jre);
					GetRegistryKeyJava(jre2);

					return JavaPathList;
				}
				catch
				{
					return null;
				}

			}

			private static void GetRegistryKeyJava(RegistryKey jvav)
			{
				if (jvav == null)
				{
					return;
				}

				foreach (var version in jvav.GetSubKeyNames())
				{
					var command = jvav.OpenSubKey(version);
					if (command == null)
					{
						continue;
					}
					string path = command.GetValue("JavaHome").ToString() + @"\bin\javaw.exe";
					//TODO: Log 包含相同版本
					if (File.Exists(path) && !JavaPathList.ContainsKey(version))
					{
						//TODO: Handle TryAdd()失败
						JavaPathList.TryAdd(version, path);
					}
				}
			}
		}

		public class SystemMemory
		{

		}
	}


}
