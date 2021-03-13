using System;
using Microsoft.Win32;

namespace TROLLICUS__
{
	// Token: 0x02000055 RID: 85
	internal static class #=qMyzFBaiLtLsi2j4C2jhS1jtqS2mtGC1QqvguUcpBevw=
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x000023C3 File Offset: 0x000005C3
		public static string #=zVjug67XrB$noNF$TGZ3__oZPXLxGpPB5MQ==()
		{
			return #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976706806);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000B53C File Offset: 0x0000973C
		public static bool #=z0K3f$zBhGByBltzQNKmYprk=()
		{
			bool result;
			try
			{
				OperatingSystem osversion = Environment.OSVersion;
				OperatingSystem operatingSystem;
				if (8 != 0)
				{
					operatingSystem = osversion;
				}
				if (operatingSystem.Platform == PlatformID.Win32NT)
				{
					bool flag = operatingSystem.Version >= new Version(6, 0);
					if (true)
					{
						result = flag;
					}
				}
				else
				{
					bool flag2 = false;
					if (6 != 0)
					{
						result = flag2;
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000B59C File Offset: 0x0000979C
		public static bool #=zcgoILurfWsZgCSnsAioVy0M10M9a2kZOfQ==()
		{
			bool result;
			try
			{
				PlatformID platform = Environment.OSVersion.Platform;
				PlatformID platformID;
				if (true)
				{
					platformID = platform;
				}
				if (platformID <= PlatformID.Win32NT)
				{
					bool flag = true;
					if (3 != 0)
					{
						result = flag;
					}
				}
				else
				{
					bool flag2 = false;
					if (4 != 0)
					{
						result = flag2;
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000023CF File Offset: 0x000005CF
		public static bool #=zHWtFcP$vH1JvDsUYn72fqjVKNpER5PF_qewO8tE=()
		{
			return #=qMyzFBaiLtLsi2j4C2jhS1jtqS2mtGC1QqvguUcpBevw=.#=zb$COEYtZhpFr5nldnUUUZ4ZWNRpO() != null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000B5EC File Offset: 0x000097EC
		private static string #=zb$COEYtZhpFr5nldnUUUZ4ZWNRpO()
		{
			string result;
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(#=qMyzFBaiLtLsi2j4C2jhS1jtqS2mtGC1QqvguUcpBevw=.#=z73heQ34eLBTBNyDaXzq21Bc3CNK7YFJwdzsjg68=());
				RegistryKey registryKey2;
				if (-1 != 0)
				{
					registryKey2 = registryKey;
				}
				if (registryKey2 == null)
				{
					RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey(#=qMyzFBaiLtLsi2j4C2jhS1jtqS2mtGC1QqvguUcpBevw=.#=znYjO_v5NTcgbwOJ5rQ==());
					if (true)
					{
						registryKey2 = registryKey3;
					}
				}
				if (registryKey2 == null)
				{
					string text = null;
					if (4 != 0)
					{
						result = text;
					}
				}
				else
				{
					string text2 = (string)registryKey2.GetValue(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976706792), null);
					registryKey2.Close();
					result = text2;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000023D9 File Offset: 0x000005D9
		private static string #=z73heQ34eLBTBNyDaXzq21Bc3CNK7YFJwdzsjg68=()
		{
			return #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976706777) + #=qMyzFBaiLtLsi2j4C2jhS1jtqS2mtGC1QqvguUcpBevw=.#=zVjug67XrB$noNF$TGZ3__oZPXLxGpPB5MQ==();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000023EF File Offset: 0x000005EF
		private static string #=znYjO_v5NTcgbwOJ5rQ==()
		{
			return #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976706741) + #=qMyzFBaiLtLsi2j4C2jhS1jtqS2mtGC1QqvguUcpBevw=.#=zVjug67XrB$noNF$TGZ3__oZPXLxGpPB5MQ==();
		}
	}
}
