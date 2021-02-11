using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestApp1.Authentication
{

	public class AuthenticationManager
	{

	}

	class Authenticator
	{


	}

	//Login

	class OfflineAuthenticator
	{
		public readonly string Name;

		public string Type => "Offline";

		public OfflineAuthenticator(string name)
		{
			Name = name;
		}

		public User Do()
		{
			if (String.IsNullOrWhiteSpace(Name))
			{
				return new User
				{
					Error = "DisplayName不符合规范，不能使用空用户名"
				};
			}
			if (Name.Count(char.IsWhiteSpace) > 0)
			{
				return new User
				{
					Error = "DisplayName不符合规范，名称中有非法字符"
				};
			}
			return new User
			{
				AccessToken = Guid.NewGuid().ToString(),
				Name = Name,
				UUID = GetPlayerUuid(Name),
				Properties = "{}",
				UserType = "mojang"
			};
		}

		private static Guid GetPlayerUuid(string name)
		{
			MD5CryptoServiceProvider md5csp = new MD5CryptoServiceProvider();
			byte[] uuidBytes = md5csp.ComputeHash(System.Text.Encoding.UTF8.GetBytes("OfflinePlayer:" + name));
			uuidBytes[6] &= 0x0f;
			uuidBytes[6] |= 0x30;
			uuidBytes[8] &= 0x3f;
			uuidBytes[8] |= 0x80;
			Guid uuid = new Guid(toUuidString(uuidBytes));
			return uuid;
		}

		private static string toUuidString(byte[] data)
		{
			long msb = 0;
			long lsb = 0;
			for (int i = 0; i < 8; i++)
				msb = (msb << 8) | (data[i] & 0xff);
			for (int i = 8; i < 16; i++)
				lsb = (lsb << 8) | (data[i] & 0xff);
			return (digits(msb >> 32, 8) + "-" +
				digits(msb >> 16, 4) + "-" +
				digits(msb, 4) + "-" +
				digits(lsb >> 48, 4) + "-" +
				digits(lsb, 12));
		}
		private static string digits(long val, int digits)
		{
			long hi = 1L << (digits * 4);
			return (hi | (val & (hi - 1))).ToString("X").Substring(1);
		}

		public Task<User> DoAsync(CancellationToken token)
		{
			return Task.Factory.StartNew(Do, token);
		}
	}
}
