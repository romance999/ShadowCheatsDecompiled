using System;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace TROLLICUS__
{
	// Token: 0x0200009E RID: 158
	internal static class #=qiuT5mu$Z20u1ECl5wWdTSbUrXvStV_BWBKamWOPRgMw=
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x0001EA24 File Offset: 0x0001CC24
		public static void #=zOtZv1449xdbsVtrMlvUzpkGQSpSLRz3LIA==(uint #=zBPb3KhA=)
		{
			if (#=zBPb3KhA= != 0U)
			{
				uint num;
				if (8 != 0)
				{
					num = #=zBPb3KhA=;
				}
				throw new InvalidOperationException(num.ToString());
			}
		}

		// Token: 0x060004EE RID: 1262
		[DllImport("ncrypt.dll", EntryPoint = "NCryptFreeObject")]
		public static extern uint #=zjpgFwsAVNoJOBCZ0BAIX2$o=(IntPtr #=zBPb3KhA=);

		// Token: 0x060004EF RID: 1263
		[DllImport("ncrypt.dll", EntryPoint = "NCryptEncrypt")]
		public static extern uint #=zdO8sP2XYu_x3r4t6UI2CfhaZYanpUZP9Zh56rNE=(#=qiuT5mu$Z20u1ECl5wWdTSbUrXvStV_BWBKamWOPRgMw=.#=zt$cqECc= #=zBPb3KhA=, [MarshalAs(UnmanagedType.LPArray)] byte[] #=zur7PLhI=, int #=zBkMjrJ4=, IntPtr #=zt$cqECc=, [MarshalAs(UnmanagedType.LPArray)] byte[] #=zfbJ$RjA=, int #=zAWZgy3A=, out int #=zkzlpT_c=, int #=zWVcvLK0=);

		// Token: 0x060004F0 RID: 1264
		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode, EntryPoint = "NCryptImportKey")]
		public static extern uint #=z8TmuY_fxoJjraWjCPgL4jgg=(#=qiuT5mu$Z20u1ECl5wWdTSbUrXvStV_BWBKamWOPRgMw=.#=zfbJ$RjA= #=zBPb3KhA=, IntPtr #=zur7PLhI=, string #=zBkMjrJ4=, IntPtr #=zt$cqECc=, out #=qiuT5mu$Z20u1ECl5wWdTSbUrXvStV_BWBKamWOPRgMw=.#=zt$cqECc= #=zfbJ$RjA=, [MarshalAs(UnmanagedType.LPArray)] byte[] #=zAWZgy3A=, int #=zkzlpT_c=, uint #=zWVcvLK0=);

		// Token: 0x060004F1 RID: 1265
		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode, EntryPoint = "NCryptOpenStorageProvider")]
		public static extern uint #=zGz6DlUkOw7Ink3CD6UWUGLq8Seh6(out #=qiuT5mu$Z20u1ECl5wWdTSbUrXvStV_BWBKamWOPRgMw=.#=zfbJ$RjA= #=zBPb3KhA=, string #=zur7PLhI=, uint #=zBkMjrJ4=);

		// Token: 0x0200009F RID: 159
		public struct #=zBPb3KhA=
		{
			// Token: 0x0400015C RID: 348
			public uint #=zBPb3KhA=;

			// Token: 0x0400015D RID: 349
			public int #=zur7PLhI=;

			// Token: 0x0400015E RID: 350
			public int #=zBkMjrJ4=;

			// Token: 0x0400015F RID: 351
			public int #=zt$cqECc=;

			// Token: 0x04000160 RID: 352
			public int #=zfbJ$RjA=;

			// Token: 0x04000161 RID: 353
			public int #=zAWZgy3A=;
		}

		// Token: 0x020000A0 RID: 160
		[SecurityCritical]
		public sealed class #=zfbJ$RjA= : SafeHandleZeroOrMinusOneIsInvalid
		{
			// Token: 0x060004F2 RID: 1266 RVA: 0x0001EA4C File Offset: 0x0001CC4C
			public #=zfbJ$RjA=()
			{
				if (8 == 0)
				{
				}
				base..ctor(true);
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0001EA6C File Offset: 0x0001CC6C
			public override bool IsInvalid
			{
				get
				{
					if (2 == 0)
					{
					}
					return this.handle == IntPtr.Zero;
				}
			}

			// Token: 0x060004F4 RID: 1268 RVA: 0x0001EA94 File Offset: 0x0001CC94
			protected override bool ReleaseHandle()
			{
				if (6 == 0)
				{
				}
				return #=qiuT5mu$Z20u1ECl5wWdTSbUrXvStV_BWBKamWOPRgMw=.#=zjpgFwsAVNoJOBCZ0BAIX2$o=(this.handle) == 0U;
			}
		}

		// Token: 0x020000A1 RID: 161
		[SecurityCritical]
		public sealed class #=zt$cqECc= : SafeHandleZeroOrMinusOneIsInvalid
		{
			// Token: 0x060004F5 RID: 1269 RVA: 0x0001EABC File Offset: 0x0001CCBC
			public #=zt$cqECc=()
			{
				if (false)
				{
				}
				base..ctor(true);
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0001EADC File Offset: 0x0001CCDC
			public override bool IsInvalid
			{
				get
				{
					if (7 == 0)
					{
					}
					return this.handle == IntPtr.Zero;
				}
			}

			// Token: 0x060004F7 RID: 1271 RVA: 0x0001EB04 File Offset: 0x0001CD04
			protected override bool ReleaseHandle()
			{
				if (!true)
				{
				}
				return #=qiuT5mu$Z20u1ECl5wWdTSbUrXvStV_BWBKamWOPRgMw=.#=zjpgFwsAVNoJOBCZ0BAIX2$o=(this.handle) == 0U;
			}
		}
	}
}
