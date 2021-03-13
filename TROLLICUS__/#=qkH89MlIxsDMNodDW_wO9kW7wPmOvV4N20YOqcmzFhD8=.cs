using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace TROLLICUS__
{
	// Token: 0x020000A2 RID: 162
	internal static class #=qkH89MlIxsDMNodDW_wO9kW7wPmOvV4N20YOqcmzFhD8=
	{
		// Token: 0x060004F8 RID: 1272 RVA: 0x0001EB2C File Offset: 0x0001CD2C
		// Note: this type is marked as 'beforefieldinit'.
		static #=qkH89MlIxsDMNodDW_wO9kW7wPmOvV4N20YOqcmzFhD8=()
		{
			uint[] array = new uint[5];
			RuntimeFieldHandle fldHandle = fieldof(#=qMSRQOpPn48H9NzwUFVnO$P61Xi0g7Go2V8VLb9KFUGw=.#=zBPb3KhA=).FieldHandle;
			if (-1 != 0)
			{
				RuntimeHelpers.InitializeArray(array, fldHandle);
			}
			if (2 != 0)
			{
				#=qkH89MlIxsDMNodDW_wO9kW7wPmOvV4N20YOqcmzFhD8=.#=zBPb3KhA= = array;
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001EB60 File Offset: 0x0001CD60
		public static byte[] #=zDtP_dsuZ1ODgF3LT2dMYqyQ=(string #=zBPb3KhA=)
		{
			if (#=zBPb3KhA= == null)
			{
				throw new Exception();
			}
			MemoryStream memoryStream = new MemoryStream(#=zBPb3KhA=.Length * 4 / 5);
			MemoryStream memoryStream2;
			if (2 != 0)
			{
				memoryStream2 = memoryStream;
			}
			byte[] result;
			try
			{
				int num = 0;
				int num2;
				if (3 != 0)
				{
					num2 = num;
				}
				uint num3 = 0U;
				uint num4;
				if (2 != 0)
				{
					num4 = num3;
				}
				foreach (char c in #=zBPb3KhA=)
				{
					if (c == 'z' && num2 == 0)
					{
						#=qkH89MlIxsDMNodDW_wO9kW7wPmOvV4N20YOqcmzFhD8=.#=zKAyMkIf0t2za9PSIdsYbRHV8ydQp(memoryStream2, num4, 0);
					}
					else
					{
						if (c < '!' || c > 'u')
						{
							throw new Exception();
						}
						checked
						{
							num4 += (uint)(unchecked((ulong)#=qkH89MlIxsDMNodDW_wO9kW7wPmOvV4N20YOqcmzFhD8=.#=zBPb3KhA=[num2]) * (ulong)(unchecked((long)(checked(c - '!')))));
						}
						num2++;
						if (num2 == 5)
						{
							#=qkH89MlIxsDMNodDW_wO9kW7wPmOvV4N20YOqcmzFhD8=.#=zKAyMkIf0t2za9PSIdsYbRHV8ydQp(memoryStream2, num4, 0);
							num2 = 0;
							num4 = 0U;
						}
					}
				}
				if (num2 == 1)
				{
					throw new Exception();
				}
				if (num2 > 1)
				{
					for (int j = num2; j < 5; j++)
					{
						checked
						{
							num4 += 84U * #=qkH89MlIxsDMNodDW_wO9kW7wPmOvV4N20YOqcmzFhD8=.#=zBPb3KhA=[j];
						}
					}
					#=qkH89MlIxsDMNodDW_wO9kW7wPmOvV4N20YOqcmzFhD8=.#=zKAyMkIf0t2za9PSIdsYbRHV8ydQp(memoryStream2, num4, 5 - num2);
				}
				result = memoryStream2.ToArray();
			}
			finally
			{
				((IDisposable)memoryStream2).Dispose();
			}
			return result;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001EC64 File Offset: 0x0001CE64
		private static void #=zKAyMkIf0t2za9PSIdsYbRHV8ydQp(Stream #=zBPb3KhA=, uint #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			if (5 == 0)
			{
			}
			if (7 == 0)
			{
			}
			#=zBPb3KhA=.WriteByte((byte)(#=zur7PLhI= >> 24));
			if (3 == 0)
			{
			}
			if (#=zBkMjrJ4= == 3)
			{
				return;
			}
			#=zBPb3KhA=.WriteByte((byte)(#=zur7PLhI= >> 16));
			if (#=zBkMjrJ4= == 2)
			{
				return;
			}
			#=zBPb3KhA=.WriteByte((byte)(#=zur7PLhI= >> 8));
			if (#=zBkMjrJ4= == 1)
			{
				return;
			}
			#=zBPb3KhA=.WriteByte((byte)#=zur7PLhI=);
		}

		// Token: 0x04000162 RID: 354
		private static readonly uint[] #=zBPb3KhA=;
	}
}
