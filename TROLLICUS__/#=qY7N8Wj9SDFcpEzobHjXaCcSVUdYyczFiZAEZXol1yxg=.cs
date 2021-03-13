using System;
using System.IO;

namespace TROLLICUS__
{
	// Token: 0x0200008D RID: 141
	internal static class #=qY7N8Wj9SDFcpEzobHjXaCcSVUdYyczFiZAEZXol1yxg=
	{
		// Token: 0x0600047E RID: 1150 RVA: 0x0001CD10 File Offset: 0x0001AF10
		public static byte[] #=zONAwybQ6YIeI7Lqz0Oi4A3FBreR56oQWMYH_RPY=(object #=zBPb3KhA=, ulong #=zur7PLhI=, #=q3YmA9J4Ih4mJgGYtKkbFOzVFAoN8UpdtQeVB7j2rDho= #=zBkMjrJ4=)
		{
			if (3 == 0)
			{
			}
			byte[] #=zBPb3KhA=2 = #=qY7N8Wj9SDFcpEzobHjXaCcSVUdYyczFiZAEZXol1yxg=.#=zQkegnvDE6KSO_BOQOg==(#=zBPb3KhA=);
			if (3 == 0)
			{
			}
			byte[] #=zur7PLhI=2 = #=qY7N8Wj9SDFcpEzobHjXaCcSVUdYyczFiZAEZXol1yxg=.#=z3TufJGCi1wgnbY41g2ka_iwsj$BQW$w4o0RJUrk=(#=zur7PLhI=);
			if (-1 == 0)
			{
			}
			return #=qY7N8Wj9SDFcpEzobHjXaCcSVUdYyczFiZAEZXol1yxg=.#=zmgacv9IMjMnq5xYle418bwrg$pPN(#=zBPb3KhA=2, #=zur7PLhI=2, #=zBkMjrJ4=);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001CD4C File Offset: 0x0001AF4C
		public static byte[] #=zmgacv9IMjMnq5xYle418bwrg$pPN(byte[] #=zBPb3KhA=, byte[] #=zur7PLhI=, #=q3YmA9J4Ih4mJgGYtKkbFOzVFAoN8UpdtQeVB7j2rDho= #=zBkMjrJ4=)
		{
			int num = #=zBPb3KhA=.Length;
			int num2;
			if (6 != 0)
			{
				num2 = num;
			}
			if (num2 == 0)
			{
				throw new ArgumentException();
			}
			int num3 = #=zBkMjrJ4=.#=zsznnbCAMZsOWha33wzwbWyL84A4TQ7FYR7kc$qaHxDI98YBUngtaHHFTGsRApSiz$g==();
			int num4;
			if (5 != 0)
			{
				num4 = num3;
			}
			int num5 = #=zBkMjrJ4=.#=znUvi35onmMzvLI$h5K$guDIISR9Bvl6jQXpKaycb_eNlQbRJycd7xLc7oF8jmW7q8POVtLDCbb8d3Yzv3PPdmOI=();
			int num6;
			if (8 != 0)
			{
				num6 = num5;
			}
			int num7 = num2 % num4;
			int num8 = (num2 + (num4 - 1)) / num4;
			byte[] array;
			if (num7 == 0)
			{
				array = new byte[num2];
				Buffer.BlockCopy(#=zBPb3KhA=, 0, array, 0, num2);
			}
			else
			{
				int #=zBkMjrJ4=2 = #=qY7N8Wj9SDFcpEzobHjXaCcSVUdYyczFiZAEZXol1yxg=.#=zM8Ngg$xoWwvtOg$ARAlZCAvw_quL(num7);
				byte[] bytes = new #=qtApqlIHc4cSySUpc3uGhx0Addkm7X3EyuhvNtussRWY=(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=2).GetBytes(num4);
				if (num8 == 1)
				{
					array = bytes;
				}
				else
				{
					array = new byte[num4 * num8];
					Buffer.BlockCopy(bytes, 0, array, num4 * (num8 - 1), num4);
				}
				Buffer.BlockCopy(#=zBPb3KhA=, 0, array, 0, #=zBPb3KhA=.Length);
			}
			#=q71Pn7elr3BqHX_MHhOkfKDCyBZ52oehoZZBiPkby3pw=.#=zmw5HhBB5atg2CE$pO_Prub9jThk3J1tKXw==(array, 0, array.Length / 4 * 4, #=zur7PLhI=);
			byte[] array2 = new byte[#=zBkMjrJ4=.#=znUvi35onmMzvLI$h5K$guDIISR9Bvl6jQXpKaycb_eNlQbRJycd7xLc7oF8jmW7q8POVtLDCbb8d3Yzv3PPdmOI=() * num8];
			for (int i = 0; i < num8; i++)
			{
				#=zBkMjrJ4=.#=z1GnCoAqe$8LgFZylE6P18vKZ7oruAaWYFFKb_cyEIgfbDhZXh$5LL2TkE5IrkCw$Jj3fLCkJkXdTTfoUPg==(array, num4 * i, num4, array2, num6 * i);
			}
			return array2;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001CE3C File Offset: 0x0001B03C
		private static int #=zM8Ngg$xoWwvtOg$ARAlZCAvw_quL(int #=zBPb3KhA=)
		{
			if (-1 == 0)
			{
			}
			if (#=zBPb3KhA= < 8)
			{
				return 200;
			}
			return 1;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001CE60 File Offset: 0x0001B060
		public static byte[] #=zQkegnvDE6KSO_BOQOg==(object #=zBPb3KhA=)
		{
			if (#=zBPb3KhA= is sbyte)
			{
				sbyte b = (sbyte)#=zBPb3KhA=;
				sbyte b2;
				if (8 != 0)
				{
					b2 = b;
				}
				return new byte[]
				{
					(byte)b2
				};
			}
			if (#=zBPb3KhA= is byte)
			{
				byte b3 = (byte)#=zBPb3KhA=;
				byte b4;
				if (3 != 0)
				{
					b4 = b3;
				}
				return new byte[]
				{
					b4
				};
			}
			if (#=zBPb3KhA= is int)
			{
				int num = (int)#=zBPb3KhA=;
				int #=zBPb3KhA=2;
				if (2 != 0)
				{
					#=zBPb3KhA=2 = num;
				}
				return #=qY7N8Wj9SDFcpEzobHjXaCcSVUdYyczFiZAEZXol1yxg=.#=zM78JKv93OlJZWIeg049caS7DtSmB(#=zBPb3KhA=2);
			}
			if (#=zBPb3KhA= is uint)
			{
				uint #=zBPb3KhA=3 = (uint)#=zBPb3KhA=;
				return #=qY7N8Wj9SDFcpEzobHjXaCcSVUdYyczFiZAEZXol1yxg=.#=z9R5JQ1R_$8jKKbAyWPqIAvldJ5Uyx69qIA==(#=zBPb3KhA=3);
			}
			if (#=zBPb3KhA= is long)
			{
				long #=zBPb3KhA=4 = (long)#=zBPb3KhA=;
				return #=qY7N8Wj9SDFcpEzobHjXaCcSVUdYyczFiZAEZXol1yxg=.#=zPBrs6g94_6lkqp$2kZ4DfOg3ditUlPm2zA==(#=zBPb3KhA=4);
			}
			if (#=zBPb3KhA= is ulong)
			{
				ulong #=zBPb3KhA=5 = (ulong)#=zBPb3KhA=;
				return #=qY7N8Wj9SDFcpEzobHjXaCcSVUdYyczFiZAEZXol1yxg=.#=z3TufJGCi1wgnbY41g2ka_iwsj$BQW$w4o0RJUrk=(#=zBPb3KhA=5);
			}
			byte[] array = #=zBPb3KhA= as byte[];
			if (array != null)
			{
				return array;
			}
			Array array2 = #=zBPb3KhA= as Array;
			if (array2 == null)
			{
				throw new InvalidOperationException();
			}
			MemoryStream memoryStream = new MemoryStream();
			foreach (object #=zBPb3KhA=6 in array2)
			{
				byte[] array3 = #=qY7N8Wj9SDFcpEzobHjXaCcSVUdYyczFiZAEZXol1yxg=.#=zQkegnvDE6KSO_BOQOg==(#=zBPb3KhA=6);
				memoryStream.Write(array3, 0, array3.Length);
			}
			return memoryStream.ToArray();
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001CFAC File Offset: 0x0001B1AC
		private static byte[] #=zM78JKv93OlJZWIeg049caS7DtSmB(int #=zBPb3KhA=)
		{
			byte[] array = new byte[4];
			int num = 3;
			if (3 == 0)
			{
			}
			array[num] = (byte)#=zBPb3KhA=;
			int num2 = 2;
			if (!true)
			{
			}
			array[num2] = (byte)(#=zBPb3KhA= >> 8);
			int num3 = 1;
			if (6 == 0)
			{
			}
			array[num3] = (byte)(#=zBPb3KhA= >> 16);
			array[0] = (byte)(#=zBPb3KhA= >> 24);
			return array;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
		private static byte[] #=z9R5JQ1R_$8jKKbAyWPqIAvldJ5Uyx69qIA==(uint #=zBPb3KhA=)
		{
			byte[] array = new byte[4];
			int num = 3;
			if (6 == 0)
			{
			}
			array[num] = (byte)#=zBPb3KhA=;
			int num2 = 2;
			if (3 == 0)
			{
			}
			array[num2] = (byte)(#=zBPb3KhA= >> 8);
			int num3 = 1;
			if (8 == 0)
			{
			}
			array[num3] = (byte)(#=zBPb3KhA= >> 16);
			array[0] = (byte)(#=zBPb3KhA= >> 24);
			return array;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0001D044 File Offset: 0x0001B244
		private static byte[] #=zPBrs6g94_6lkqp$2kZ4DfOg3ditUlPm2zA==(long #=zBPb3KhA=)
		{
			byte[] array = new byte[8];
			int num = 7;
			if (false)
			{
			}
			array[num] = (byte)#=zBPb3KhA=;
			int num2 = 6;
			if (!true)
			{
			}
			array[num2] = (byte)(#=zBPb3KhA= >> 8);
			int num3 = 5;
			if (8 == 0)
			{
			}
			array[num3] = (byte)(#=zBPb3KhA= >> 16);
			array[4] = (byte)(#=zBPb3KhA= >> 24);
			array[3] = (byte)(#=zBPb3KhA= >> 32);
			array[2] = (byte)(#=zBPb3KhA= >> 40);
			array[1] = (byte)(#=zBPb3KhA= >> 48);
			array[0] = (byte)(#=zBPb3KhA= >> 56);
			return array;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001D0B0 File Offset: 0x0001B2B0
		private static byte[] #=z3TufJGCi1wgnbY41g2ka_iwsj$BQW$w4o0RJUrk=(ulong #=zBPb3KhA=)
		{
			byte[] array = new byte[8];
			int num = 7;
			if (3 == 0)
			{
			}
			array[num] = (byte)#=zBPb3KhA=;
			int num2 = 6;
			if (3 == 0)
			{
			}
			array[num2] = (byte)(#=zBPb3KhA= >> 8);
			int num3 = 5;
			if (3 == 0)
			{
			}
			array[num3] = (byte)(#=zBPb3KhA= >> 16);
			array[4] = (byte)(#=zBPb3KhA= >> 24);
			array[3] = (byte)(#=zBPb3KhA= >> 32);
			array[2] = (byte)(#=zBPb3KhA= >> 40);
			array[1] = (byte)(#=zBPb3KhA= >> 48);
			array[0] = (byte)(#=zBPb3KhA= >> 56);
			return array;
		}
	}
}
