using System;
using System.Reflection;
using System.Security;

namespace TROLLICUS__
{
	// Token: 0x02000017 RID: 23
	internal static class #=q7KLabDIz8RNv98ckeHzHAM_c0R5$nFujA6sJWy0uXSU=
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00005570 File Offset: 0x00003770
		static #=q7KLabDIz8RNv98ckeHzHAM_c0R5$nFujA6sJWy0uXSU=()
		{
			bool flag = #=q7KLabDIz8RNv98ckeHzHAM_c0R5$nFujA6sJWy0uXSU=.#=zfxLR2HLug4itYdyTYqTiX__b6zWr();
			if (8 != 0)
			{
				#=q7KLabDIz8RNv98ckeHzHAM_c0R5$nFujA6sJWy0uXSU=.#=zBPb3KhA= = flag;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005590 File Offset: 0x00003790
		private static bool #=zfxLR2HLug4itYdyTYqTiX__b6zWr()
		{
			bool result;
			try
			{
				if (Environment.Version.Major < 4)
				{
					bool flag = false;
					if (true)
					{
						result = flag;
					}
				}
				else
				{
					Assembly assembly = typeof(#=qPmyVsV7oVp9snqbugcFD0Cbojj2ChmGSFRy802rCwOY=).Assembly;
					Assembly assembly2 = typeof(SecurityCriticalAttribute).Assembly;
					Assembly assembly3;
					if (4 != 0)
					{
						assembly3 = assembly2;
					}
					bool flag2 = false;
					bool flag3;
					if (!false)
					{
						flag3 = flag2;
					}
					foreach (object obj in assembly.GetCustomAttributes(false))
					{
						if (obj is AllowPartiallyTrustedCallersAttribute)
						{
							flag3 = true;
						}
						else
						{
							Type type = obj.GetType();
							if (type.Assembly == assembly3 && #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976708818).Equals(type.FullName, StringComparison.Ordinal) && (byte)type.GetProperty(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976708799)).GetValue(obj, null) != 2)
							{
								return false;
							}
						}
					}
					result = flag3;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002335 File Offset: 0x00000535
		public static bool #=zGKLH07fVnyKqK$Em2ieTZs8R3pSSc_Q2nz$XfjE=()
		{
			return #=q7KLabDIz8RNv98ckeHzHAM_c0R5$nFujA6sJWy0uXSU=.#=zBPb3KhA=;
		}

		// Token: 0x04000041 RID: 65
		private static readonly bool #=zBPb3KhA=;
	}
}
