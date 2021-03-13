using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TROLLICUS__
{
	// Token: 0x02000053 RID: 83
	internal static class #=qMkg9Kv56DhUlVRx6R16V_tqPhDcplxea1tlpJddAPuc=
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x0000B310 File Offset: 0x00009510
		static #=qMkg9Kv56DhUlVRx6R16V_tqPhDcplxea1tlpJddAPuc=()
		{
			OperatingSystem osversion = Environment.OSVersion;
			OperatingSystem operatingSystem;
			if (2 != 0)
			{
				operatingSystem = osversion;
			}
			bool flag = operatingSystem.Platform == PlatformID.Win32NT && operatingSystem.Version >= new Version(6, 0);
			if (3 != 0)
			{
				#=qMkg9Kv56DhUlVRx6R16V_tqPhDcplxea1tlpJddAPuc=.#=zBPb3KhA= = flag;
			}
			if (#=qMkg9Kv56DhUlVRx6R16V_tqPhDcplxea1tlpJddAPuc=.#=zwSp0tENKW5GyL02HGk_ter8=())
			{
				try
				{
					bool flag2 = #=qMkg9Kv56DhUlVRx6R16V_tqPhDcplxea1tlpJddAPuc=.#=zTV5elSm3U8jYetNWBP3VEGc=(operatingSystem);
					if (6 != 0)
					{
						#=qMkg9Kv56DhUlVRx6R16V_tqPhDcplxea1tlpJddAPuc=.#=zur7PLhI= = flag2;
					}
				}
				catch
				{
					#=qMkg9Kv56DhUlVRx6R16V_tqPhDcplxea1tlpJddAPuc=.#=zur7PLhI= = false;
				}
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000023B5 File Offset: 0x000005B5
		public static bool #=zwSp0tENKW5GyL02HGk_ter8=()
		{
			return #=qMkg9Kv56DhUlVRx6R16V_tqPhDcplxea1tlpJddAPuc=.#=zBPb3KhA=;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000023BC File Offset: 0x000005BC
		public static bool #=zprKbm1cxOytLTQkfRS6Xhpw=()
		{
			return #=qMkg9Kv56DhUlVRx6R16V_tqPhDcplxea1tlpJddAPuc=.#=zur7PLhI=;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000B38C File Offset: 0x0000958C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool #=zTV5elSm3U8jYetNWBP3VEGc=(OperatingSystem #=zBPb3KhA=)
		{
			if (5 == 0)
			{
			}
			if (#=zBPb3KhA=.Platform == PlatformID.Win32NT)
			{
				if (7 == 0)
				{
				}
				if (#=zBPb3KhA=.Version < new Version(6, 2, 9200) && Process.GetCurrentProcess().SessionId == 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040000CC RID: 204
		private static readonly bool #=zBPb3KhA=;

		// Token: 0x040000CD RID: 205
		private static readonly bool #=zur7PLhI=;
	}
}
