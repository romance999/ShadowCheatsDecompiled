using System;

namespace TROLLICUS__
{
	// Token: 0x020000AE RID: 174
	internal static class #=qtC4zeDWYHoMV9iOs8x9cluUnVu8v8fmPRzpHB3FA5Os=
	{
		// Token: 0x06000542 RID: 1346 RVA: 0x000202AC File Offset: 0x0001E4AC
		public static bool #=z0Ra7Y_aO3RPnhiRacLhWifhJSN5g9CmAteVet9k=(int[] #=zBPb3KhA=, int[] #=zur7PLhI=)
		{
			if (#=zBPb3KhA= == #=zur7PLhI=)
			{
				return true;
			}
			if (#=zBPb3KhA= == null || #=zur7PLhI= == null)
			{
				return false;
			}
			if (#=zBPb3KhA=.Length != #=zur7PLhI=.Length)
			{
				return false;
			}
			int num = 0;
			int i;
			if (4 != 0)
			{
				i = num;
			}
			while (i < #=zBPb3KhA=.Length)
			{
				if (#=zBPb3KhA=[i] != #=zur7PLhI=[i])
				{
					return false;
				}
				int num2 = i + 1;
				if (5 != 0)
				{
					i = num2;
				}
			}
			return true;
		}
	}
}
