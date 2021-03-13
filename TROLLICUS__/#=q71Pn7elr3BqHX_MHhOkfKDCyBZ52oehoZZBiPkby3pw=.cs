using System;

namespace TROLLICUS__
{
	// Token: 0x02000015 RID: 21
	internal static class #=q71Pn7elr3BqHX_MHhOkfKDCyBZ52oehoZZBiPkby3pw=
	{
		// Token: 0x06000089 RID: 137 RVA: 0x0000508C File Offset: 0x0000328C
		private static uint #=z8qyj6nPVgaTGl1u$Akzs_ioUSLOxDtPXwA==(uint #=zBPb3KhA=, uint #=zur7PLhI=, uint #=zBkMjrJ4=, int #=zt$cqECc=, uint #=zfbJ$RjA=, uint[] #=zAWZgy3A=)
		{
			if (7 == 0)
			{
			}
			uint num = #=zBkMjrJ4= >> 5;
			if (2 == 0)
			{
			}
			uint num2 = num ^ #=zur7PLhI= << 2;
			if (6 == 0)
			{
			}
			return num2 + (#=zur7PLhI= >> 3 ^ #=zBkMjrJ4= << 4) ^ (#=zBPb3KhA= ^ #=zur7PLhI=) + (#=zAWZgy3A=[(int)(checked((IntPtr)(unchecked((long)(#=zt$cqECc= & 3) ^ (long)((ulong)#=zfbJ$RjA=)))))] ^ #=zBkMjrJ4=);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000050D8 File Offset: 0x000032D8
		public static void #=zmw5HhBB5atg2CE$pO_Prub9jThk3J1tKXw==(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=, byte[] #=zt$cqECc=)
		{
			if (#=zBPb3KhA=.Length == 0 || #=zBPb3KhA=.Length == 0)
			{
				return;
			}
			if (#=zur7PLhI= + #=zBkMjrJ4= > #=zBPb3KhA=.Length || #=zBkMjrJ4= % 4 != 0 || #=zBkMjrJ4= < 8)
			{
				throw new ArgumentException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705042));
			}
			if (#=zt$cqECc= == null || #=zt$cqECc=.Length > 16)
			{
				throw new ArgumentNullException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705049));
			}
			uint[] array = new uint[#=zBkMjrJ4= / 4];
			uint[] array2;
			if (5 != 0)
			{
				array2 = array;
			}
			#=q71Pn7elr3BqHX_MHhOkfKDCyBZ52oehoZZBiPkby3pw=.#=zmAV09YbQZk1HBHMEwTryazCCiD$hQaxkDax9a6s=(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=, array2, 0);
			uint[] array3 = new uint[4];
			uint[] array4;
			if (-1 != 0)
			{
				array4 = array3;
			}
			#=q71Pn7elr3BqHX_MHhOkfKDCyBZ52oehoZZBiPkby3pw=.#=zmAV09YbQZk1HBHMEwTryazCCiD$hQaxkDax9a6s=(#=zt$cqECc=, 0, #=zt$cqECc=.Length, array4, 0);
			uint[] #=zBPb3KhA=2 = array2;
			uint[] #=zur7PLhI=2 = array4;
			if (4 != 0)
			{
				#=q71Pn7elr3BqHX_MHhOkfKDCyBZ52oehoZZBiPkby3pw=.#=z_Hr44UbxsLEvpPpJcUNKT5MOYVfVrTi59wTc3NMicIJy(#=zBPb3KhA=2, #=zur7PLhI=2);
			}
			#=q71Pn7elr3BqHX_MHhOkfKDCyBZ52oehoZZBiPkby3pw=.#=zdmxL_Z$Od7z4n$YOirGKf5S7awgFbEGugbNMVrwD323N(array2, 0, array2.Length, #=zBPb3KhA=, #=zur7PLhI=);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000517C File Offset: 0x0000337C
		private static void #=z_Hr44UbxsLEvpPpJcUNKT5MOYVfVrTi59wTc3NMicIJy(uint[] #=zBPb3KhA=, uint[] #=zur7PLhI=)
		{
			int num = #=zBPb3KhA=.Length - 1;
			int num2;
			if (7 != 0)
			{
				num2 = num;
			}
			if (num2 < 1)
			{
				return;
			}
			uint num3 = #=zBPb3KhA=[num2];
			uint #=zBkMjrJ4=;
			if (4 != 0)
			{
				#=zBkMjrJ4= = num3;
			}
			uint num4 = 0U;
			uint num5;
			if (7 != 0)
			{
				num5 = num4;
			}
			int num6 = 6 + 52 / (num2 + 1);
			while (0 < num6--)
			{
				num5 += 2654435769U;
				uint #=zfbJ$RjA= = num5 >> 2 & 3U;
				int i;
				uint #=zur7PLhI=2;
				for (i = 0; i < num2; i++)
				{
					#=zur7PLhI=2 = #=zBPb3KhA=[i + 1];
					#=zBkMjrJ4= = (#=zBPb3KhA=[i] += #=q71Pn7elr3BqHX_MHhOkfKDCyBZ52oehoZZBiPkby3pw=.#=z8qyj6nPVgaTGl1u$Akzs_ioUSLOxDtPXwA==(num5, #=zur7PLhI=2, #=zBkMjrJ4=, i, #=zfbJ$RjA=, #=zur7PLhI=));
				}
				#=zur7PLhI=2 = #=zBPb3KhA=[0];
				#=zBkMjrJ4= = (#=zBPb3KhA=[num2] += #=q71Pn7elr3BqHX_MHhOkfKDCyBZ52oehoZZBiPkby3pw=.#=z8qyj6nPVgaTGl1u$Akzs_ioUSLOxDtPXwA==(num5, #=zur7PLhI=2, #=zBkMjrJ4=, i, #=zfbJ$RjA=, #=zur7PLhI=));
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005228 File Offset: 0x00003428
		private static uint[] #=zmAV09YbQZk1HBHMEwTryazCCiD$hQaxkDax9a6s=(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=, uint[] #=zt$cqECc=, int #=zfbJ$RjA=)
		{
			if (#=zur7PLhI= + #=zBkMjrJ4= > #=zBPb3KhA=.Length)
			{
				throw new ArgumentException();
			}
			int num = #=zBkMjrJ4= / 4;
			int num2;
			if (!false)
			{
				num2 = num;
			}
			if (#=zfbJ$RjA= + num2 > #=zt$cqECc=.Length)
			{
				throw new ArgumentException();
			}
			int num3 = #=zur7PLhI= + #=zBkMjrJ4=;
			int num4;
			if (3 != 0)
			{
				num4 = num3;
			}
			int i;
			if (2 != 0)
			{
				i = #=zur7PLhI=;
			}
			while (i < num4)
			{
				#=zt$cqECc=[#=zfbJ$RjA= + (i - #=zur7PLhI=) / 4] = (uint)((int)#=zBPb3KhA=[i] | (int)#=zBPb3KhA=[i + 1] << 8 | (int)#=zBPb3KhA=[i + 2] << 16 | (int)#=zBPb3KhA=[i + 3] << 24);
				i += 4;
			}
			return #=zt$cqECc=;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000052A4 File Offset: 0x000034A4
		private static void #=zdmxL_Z$Od7z4n$YOirGKf5S7awgFbEGugbNMVrwD323N(uint[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=, byte[] #=zt$cqECc=, int #=zfbJ$RjA=)
		{
			if (#=zur7PLhI= + #=zBkMjrJ4= > #=zBPb3KhA=.Length)
			{
				throw new ArgumentException();
			}
			int num = #=zBkMjrJ4= * 4;
			int num2;
			if (-1 != 0)
			{
				num2 = num;
			}
			if (#=zfbJ$RjA= + num2 > #=zt$cqECc=.Length)
			{
				throw new ArgumentException();
			}
			int num3 = #=zfbJ$RjA= + num2;
			int num4;
			if (5 != 0)
			{
				num4 = num3;
			}
			int i;
			if (4 != 0)
			{
				i = #=zfbJ$RjA=;
			}
			while (i < num4)
			{
				uint num5 = #=zBPb3KhA=[(i - #=zfbJ$RjA=) / 4 + #=zur7PLhI=];
				#=zt$cqECc=[i] = (byte)num5;
				#=zt$cqECc=[i + 1] = (byte)(num5 >> 8);
				#=zt$cqECc=[i + 2] = (byte)(num5 >> 16);
				#=zt$cqECc=[i + 3] = (byte)(num5 >> 24);
				i += 4;
			}
		}
	}
}
