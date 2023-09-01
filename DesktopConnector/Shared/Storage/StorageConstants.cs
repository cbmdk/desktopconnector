using System;
namespace DesktopConnector.Shared.Storage
{
	public static class StorageConstants
	{
		public static class Local
		{
			public static string Preference = "clientPreference";
			public static string AuthToken = "authToken";
			public static string RefreshToken = "refreshToken";
		}

		public static class Server
		{
			public static string Preference = "serverPreference";
		}
	}
}

