using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TROLLICUS__
{
	// Token: 0x02000098 RID: 152
	internal sealed class #=qhdWeVPGbN_NikEVw1EV$CYBlc2dr5uHJwrE9B4e8Uk0= : #=q1UdDXeJwdEhg452pUm$BX0mWPFm6w8rUuHrnF3Fuslw=, IDisposable
	{
		// Token: 0x060004BF RID: 1215 RVA: 0x0001DE98 File Offset: 0x0001C098
		public #=qhdWeVPGbN_NikEVw1EV$CYBlc2dr5uHJwrE9B4e8Uk0=()
		{
			SecureString secureString = new SecureString();
			if (-1 != 0)
			{
				this.#=zBPb3KhA= = secureString;
			}
			base..ctor();
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001DEC0 File Offset: 0x0001C0C0
		public int #=zwZKBjF5dYMZYKJMy5t4hLx0KNlQ$ssRquWJNu_W0kla4_2TbEDQl0XwvP74TUIXXnPolrOYfmSMQ()
		{
			if (8 == 0)
			{
			}
			return this.#=zBPb3KhA=.Length;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000024E0 File Offset: 0x000006E0
		public #=q1UdDXeJwdEhg452pUm$BX0mWPFm6w8rUuHrnF3Fuslw= #=z9UZz7PYDC_CyrUWiLqwNRoONEvqU9oNMiqACW$u1VqnALgvRQ14eyfUzAekE3swI3RSu5rUExZbH()
		{
			return new #=qhdWeVPGbN_NikEVw1EV$CYBlc2dr5uHJwrE9B4e8Uk0=();
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0001DEE4 File Offset: 0x0001C0E4
		public void #=zCuRiKmJqrPp4eIjDtHwlBA_htoort0CGNIRjX11zAdWVM00g9QMoR5L9bFYsvZ5$Cg0LL97GlP6Xuu1h56ze7Ck=(int #=zBPb3KhA=, out byte #=zur7PLhI=)
		{
			if (#=zBPb3KhA= < 0 || #=zBPb3KhA= >= this.#=zwZKBjF5dYMZYKJMy5t4hLx0KNlQ$ssRquWJNu_W0kla4_2TbEDQl0XwvP74TUIXXnPolrOYfmSMQ())
			{
				throw new ArgumentOutOfRangeException();
			}
			IntPtr zero = IntPtr.Zero;
			IntPtr intPtr;
			if (5 != 0)
			{
				intPtr = zero;
			}
			char c = '\0';
			char c2;
			if (7 != 0)
			{
				c2 = c;
			}
			try
			{
				IntPtr intPtr2 = Marshal.SecureStringToGlobalAllocUnicode(this.#=zBPb3KhA=);
				if (5 != 0)
				{
					intPtr = intPtr2;
				}
				c2 = (char)Marshal.ReadInt16(intPtr, #=zBPb3KhA= * 2);
				#=zur7PLhI= = #=qhdWeVPGbN_NikEVw1EV$CYBlc2dr5uHJwrE9B4e8Uk0=.#=zHuLImHNybNdJ_oeOZuUu7Zx7QcYbIBhaXg==(c2, #=zBPb3KhA=);
			}
			finally
			{
				#=qy19ntCTjkEw0Q6h2Gs$NpHZ1zettU_JEbIe153lb9TA=.#=zqgNPfvlHgtQorltYSxeJ_WDWStXd37$2ApZWzBF_ztd1(ref c2);
				if (intPtr != IntPtr.Zero)
				{
					Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
				}
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0001DF70 File Offset: 0x0001C170
		public void #=zoYA7hN5CM52D47mxiM6EkWOYfy66Oao_iHKrDqJfwIkbz6hyWV_gHsrRA9lC2ftd2l_1Djv2yTzO3bIOGDbPU5Y=(int #=zBPb3KhA=, ref byte #=zur7PLhI=)
		{
			int length = this.#=zBPb3KhA=.Length;
			int i;
			if (6 != 0)
			{
				i = length;
			}
			while (i <= #=zBPb3KhA=)
			{
				if (i == #=zBPb3KhA=)
				{
					this.#=zBPb3KhA=.AppendChar(#=qhdWeVPGbN_NikEVw1EV$CYBlc2dr5uHJwrE9B4e8Uk0=.#=zkG_vzmE85XjxsZbzIqb2MLRX3DNeGNuSFwNa75M=(#=zur7PLhI=, i));
					return;
				}
				this.#=zBPb3KhA=.AppendChar(#=qhdWeVPGbN_NikEVw1EV$CYBlc2dr5uHJwrE9B4e8Uk0=.#=zkG_vzmE85XjxsZbzIqb2MLRX3DNeGNuSFwNa75M=(0, i));
				int num = i + 1;
				if (3 != 0)
				{
					i = num;
				}
			}
			this.#=zBPb3KhA=.SetAt(#=zBPb3KhA=, #=qhdWeVPGbN_NikEVw1EV$CYBlc2dr5uHJwrE9B4e8Uk0=.#=zkG_vzmE85XjxsZbzIqb2MLRX3DNeGNuSFwNa75M=(#=zur7PLhI=, #=zBPb3KhA=));
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0001DFE0 File Offset: 0x0001C1E0
		private static char #=zkG_vzmE85XjxsZbzIqb2MLRX3DNeGNuSFwNa75M=(byte #=zBPb3KhA=, int #=zur7PLhI=)
		{
			if (6 == 0)
			{
			}
			return (char)(#=zBPb3KhA= + 1);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0001DFFC File Offset: 0x0001C1FC
		private static byte #=zHuLImHNybNdJ_oeOZuUu7Zx7QcYbIBhaXg==(char #=zBPb3KhA=, int #=zur7PLhI=)
		{
			if (8 == 0)
			{
			}
			return (byte)(#=zBPb3KhA= - '\u0001');
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0001E018 File Offset: 0x0001C218
		public void #=zf7dT4mwpe_VQMRSYW4gxY3wRlQ6OvFOm0DU6wiSz8eY7NCLTpAQ$oPuK3nAL4n3fEHPLbZfEiUCQhZ7uf5T8ZjvoMjFU()
		{
			if (3 == 0)
			{
			}
			this.#=zBPb3KhA=.Clear();
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0001E03C File Offset: 0x0001C23C
		public void Dispose()
		{
			this.#=zBPb3KhA=.Dispose();
			SecureString secureString = null;
			if (5 != 0)
			{
				this.#=zBPb3KhA= = secureString;
			}
		}

		// Token: 0x04000153 RID: 339
		private SecureString #=zBPb3KhA=;
	}
}
