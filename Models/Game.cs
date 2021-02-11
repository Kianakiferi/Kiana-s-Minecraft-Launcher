using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Models
{
	public class Game
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Version { get; set; }

		public string JavaPath { get; set; }
		public string JavaVersion { get; set; }
		public string JavaArguments { get; set; }
		public string JVMArguments { get; set; }

		public string GamePath { get; set; }
		public string GameArguments { get; set; }

		public byte MinMemory { get; set; }
		public byte MaxMemory { get; set; }

		public int Width { get; set; }
		public int Height { get; set; }
		public bool Fullscreen { get; set; }
	}
}
