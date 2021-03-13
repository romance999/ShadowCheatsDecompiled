using System;
using System.IO;
using System.Runtime.InteropServices;
using TROLLICUS__;

namespace ShadowCheats
{
	// Token: 0x02000005 RID: 5
	public class Module
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002608 File Offset: 0x00000808
		public Module()
		{
			if (4 == 0)
			{
			}
			base..ctor();
		}

		// Token: 0x06000008 RID: 8
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandleA(string #=zvFjv_zvZj68t);

		// Token: 0x06000009 RID: 9
		[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
		private static extern bool #=zuN3$xlio06xL(IntPtr #=zd678AXc=, IntPtr #=zSDSU1xHkRJZ3, byte[] #=zsh3CVmXoZKZf, int #=zsyiVwQI=, out IntPtr #=zFyFDHuRWkrVu37oYBw==);

		// Token: 0x0600000A RID: 10
		[DllImport("kernel32.dll", EntryPoint = "VirtualProtectEx")]
		private static extern bool #=zD6Fk58BcmlA0(IntPtr #=zd678AXc=, IntPtr #=z9x2nZK2xZB$M, UIntPtr #=z3DaanhI=, uint #=zPGkLwMJ2Jyv_, out uint #=z8FmSXdTd7Yp6mHGZLQ==);

		// Token: 0x0600000B RID: 11
		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr #=zitB4LhhATRfp(IntPtr #=z1PwsUPY=, string #=zljkj50s=);

		// Token: 0x0600000C RID: 12
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string #=zvFjv_zvZj68t);

		// Token: 0x0600000D RID: 13
		[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
		private static extern uint #=zRzGaFEWwcmaW(IntPtr #=zLaUUe7E=, out int #=zsqDgsoM=);

		// Token: 0x0600000E RID: 14
		[DllImport("user32.dll", EntryPoint = "FindWindowA", SetLastError = true)]
		private static extern IntPtr #=zdNacmaX_hXup(string #=zhwnwZYJjaHKj, string #=zkUOhQGEMT0rM);

		// Token: 0x0600000F RID: 15
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr OpenProcess(Module.ProcessAccessFlags #=zmSbpMPeVxRNK, bool #=zjq6GoD2zCR2K, int #=zUfPC8Ys=);

		// Token: 0x06000010 RID: 16
		[DllImport("kernel32.dll")]
		public static extern bool ReadProcessMemory(int #=zd678AXc=, int #=zSDSU1xHkRJZ3, byte[] #=zsh3CVmXoZKZf, int #=z3DaanhI=, ref int #=zNpTbYqVy84hZbm3GGg==);

		// Token: 0x06000011 RID: 17 RVA: 0x00002628 File Offset: 0x00000828
		private bool #=zkOnd7WNwIC1W()
		{
			object[] array = new object[1];
			object[] array2;
			if (!false)
			{
				array2 = array;
			}
			array2[0] = this;
			return (bool)#=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=zzsfkBUZ7NWmlK7P9$fvD1CYqC2vPbWkOwMhtcubjKrbAW61Tgw==().#=zNZQH3q_b7dLdLmw8nA==(#=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=z7xTuSEwD9O_JJ75OBsZHA71rrDzMLjAu7QuZczFmIyJxI$lcSw==(), "l-.K!A&uj9", array2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002668 File Offset: 0x00000868
		private void #=zcerooCc=()
		{
			object[] array = new object[1];
			object[] array2;
			if (6 != 0)
			{
				array2 = array;
			}
			array2[0] = this;
			#=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY= #=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY= = #=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=zzsfkBUZ7NWmlK7P9$fvD1CYqC2vPbWkOwMhtcubjKrbAW61Tgw==();
			Stream #=zBPb3KhA= = #=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=z7xTuSEwD9O_JJ75OBsZHA71rrDzMLjAu7QuZczFmIyJxI$lcSw==();
			string #=zur7PLhI= = "gW\\!hTubF\"";
			object[] #=zBkMjrJ4= = array2;
			if (7 != 0)
			{
				#=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY=.#=zcX7ttYrkKY1iXJy35dhJznQ=(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000026A8 File Offset: 0x000008A8
		public void ExecuteScript(string #=zBawnbFU=)
		{
			object[] array = new object[2];
			object[] array2;
			if (2 != 0)
			{
				array2 = array;
			}
			array2[0] = this;
			array2[1] = #=zBawnbFU=;
			#=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY= #=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY= = #=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=zzsfkBUZ7NWmlK7P9$fvD1CYqC2vPbWkOwMhtcubjKrbAW61Tgw==();
			Stream #=zBPb3KhA= = #=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=z7xTuSEwD9O_JJ75OBsZHA71rrDzMLjAu7QuZczFmIyJxI$lcSw==();
			string #=zur7PLhI= = "ilo`o7EEZp";
			object[] #=zBkMjrJ4= = array2;
			if (2 != 0)
			{
				#=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY=.#=zcX7ttYrkKY1iXJy35dhJznQ=(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000026EC File Offset: 0x000008EC
		public void Attach()
		{
			object[] array = new object[1];
			object[] array2;
			if (true)
			{
				array2 = array;
			}
			array2[0] = this;
			#=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY= #=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY= = #=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=zzsfkBUZ7NWmlK7P9$fvD1CYqC2vPbWkOwMhtcubjKrbAW61Tgw==();
			Stream #=zBPb3KhA= = #=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=z7xTuSEwD9O_JJ75OBsZHA71rrDzMLjAu7QuZczFmIyJxI$lcSw==();
			string #=zur7PLhI= = "d*0h]$-:<4";
			object[] #=zBkMjrJ4= = array2;
			if (2 != 0)
			{
				#=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY=.#=zcX7ttYrkKY1iXJy35dhJznQ=(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000272C File Offset: 0x0000092C
		public bool ValidateVersion()
		{
			object[] array = new object[1];
			object[] array2;
			if (3 != 0)
			{
				array2 = array;
			}
			array2[0] = this;
			return (bool)#=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=zzsfkBUZ7NWmlK7P9$fvD1CYqC2vPbWkOwMhtcubjKrbAW61Tgw==().#=zNZQH3q_b7dLdLmw8nA==(#=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=z7xTuSEwD9O_JJ75OBsZHA71rrDzMLjAu7QuZczFmIyJxI$lcSw==(), "jNPrq[)gG5", array2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000276C File Offset: 0x0000096C
		public bool ValidateAttachment()
		{
			object[] array = new object[1];
			object[] array2;
			if (4 != 0)
			{
				array2 = array;
			}
			array2[0] = this;
			return (bool)#=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=zzsfkBUZ7NWmlK7P9$fvD1CYqC2vPbWkOwMhtcubjKrbAW61Tgw==().#=zNZQH3q_b7dLdLmw8nA==(#=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=z7xTuSEwD9O_JJ75OBsZHA71rrDzMLjAu7QuZczFmIyJxI$lcSw==(), "k02/slH%/k", array2);
		}

		// Token: 0x06000017 RID: 23
		[DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool #=zF8Jb1AbJPtv0();

		// Token: 0x06000018 RID: 24 RVA: 0x000027AC File Offset: 0x000009AC
		public void CreateConsole()
		{
			object[] array = new object[1];
			object[] array2;
			if (4 != 0)
			{
				array2 = array;
			}
			array2[0] = this;
			#=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY= #=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY= = #=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=zzsfkBUZ7NWmlK7P9$fvD1CYqC2vPbWkOwMhtcubjKrbAW61Tgw==();
			Stream #=zBPb3KhA= = #=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=z7xTuSEwD9O_JJ75OBsZHA71rrDzMLjAu7QuZczFmIyJxI$lcSw==();
			string #=zur7PLhI= = "n'','T?,3u";
			object[] #=zBkMjrJ4= = array2;
			if (-1 != 0)
			{
				#=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY=.#=zcX7ttYrkKY1iXJy35dhJznQ=(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000027EC File Offset: 0x000009EC
		public void CloseRobloxProcesses()
		{
			object[] array = new object[1];
			object[] array2;
			if (8 != 0)
			{
				array2 = array;
			}
			array2[0] = this;
			#=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY= #=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY= = #=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=zzsfkBUZ7NWmlK7P9$fvD1CYqC2vPbWkOwMhtcubjKrbAW61Tgw==();
			Stream #=zBPb3KhA= = #=z7U7jp8pICIw4GATappAAZ_$Yrifbq7ux2PRmkwq5FZYPq1SQmw==.#=z7xTuSEwD9O_JJ75OBsZHA71rrDzMLjAu7QuZczFmIyJxI$lcSw==();
			string #=zur7PLhI= = "n'','J&ogU";
			object[] #=zBkMjrJ4= = array2;
			if (7 != 0)
			{
				#=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY=.#=zcX7ttYrkKY1iXJy35dhJznQ=(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
			}
		}

		// Token: 0x02000006 RID: 6
		[Flags]
		public enum ProcessAccessFlags : uint
		{
			// Token: 0x04000005 RID: 5
			All = 2035711U,
			// Token: 0x04000006 RID: 6
			Terminate = 1U,
			// Token: 0x04000007 RID: 7
			CreateThread = 2U,
			// Token: 0x04000008 RID: 8
			VirtualMemoryOperation = 8U,
			// Token: 0x04000009 RID: 9
			VirtualMemoryRead = 16U,
			// Token: 0x0400000A RID: 10
			VirtualMemoryWrite = 32U,
			// Token: 0x0400000B RID: 11
			DuplicateHandle = 64U,
			// Token: 0x0400000C RID: 12
			CreateProcess = 128U,
			// Token: 0x0400000D RID: 13
			SetQuota = 256U,
			// Token: 0x0400000E RID: 14
			SetInformation = 512U,
			// Token: 0x0400000F RID: 15
			QueryInformation = 1024U,
			// Token: 0x04000010 RID: 16
			QueryLimitedInformation = 4096U,
			// Token: 0x04000011 RID: 17
			Synchronize = 1048576U
		}
	}
}
