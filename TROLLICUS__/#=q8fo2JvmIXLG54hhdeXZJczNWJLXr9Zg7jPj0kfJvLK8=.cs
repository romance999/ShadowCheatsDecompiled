using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace TROLLICUS__
{
	// Token: 0x0200001E RID: 30
	internal static class #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x00005FB0 File Offset: 0x000041B0
		// Note: this type is marked as 'beforefieldinit'.
		static #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=()
		{
			#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zNf5GMpJKGjFOQdevL$4Ind5wJF4H #=zNf5GMpJKGjFOQdevL$4Ind5wJF4H = new #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zNf5GMpJKGjFOQdevL$4Ind5wJF4H();
			if (7 != 0)
			{
				#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zu7PmkjEFUT8JPyEIY59EBeTKXwqs = #=zNf5GMpJKGjFOQdevL$4Ind5wJF4H;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005FD0 File Offset: 0x000041D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long #=zC$cvsu0=()
		{
			if (Assembly.GetCallingAssembly() != typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=).Assembly || !#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zW$HRmzE2LGJz4MVrUXnZ6f8NXE7e())
			{
				return 0L;
			}
			#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zNf5GMpJKGjFOQdevL$4Ind5wJF4H #=zNf5GMpJKGjFOQdevL$4Ind5wJF4H = #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zu7PmkjEFUT8JPyEIY59EBeTKXwqs;
			#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zNf5GMpJKGjFOQdevL$4Ind5wJF4H obj;
			if (-1 != 0)
			{
				obj = #=zNf5GMpJKGjFOQdevL$4Ind5wJF4H;
			}
			if (!false)
			{
				Monitor.Enter(#=zNf5GMpJKGjFOQdevL$4Ind5wJF4H);
			}
			long result;
			try
			{
				long num = #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zu7PmkjEFUT8JPyEIY59EBeTKXwqs.#=zbk8ZcQuJutypYdwa2$L$XL3fU5yt();
				long num2;
				if (5 != 0)
				{
					num2 = num;
				}
				if (num2 == 0L)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					Assembly assembly;
					if (2 != 0)
					{
						assembly = executingAssembly;
					}
					List<byte> list = new List<byte>();
					List<byte> list2;
					if (4 != 0)
					{
						list2 = list;
					}
					AssemblyName assemblyName;
					try
					{
						assemblyName = assembly.GetName();
					}
					catch
					{
						assemblyName = new AssemblyName(assembly.FullName);
					}
					byte[] array = assemblyName.GetPublicKeyToken();
					if (array != null && array.Length == 0)
					{
						array = null;
					}
					if (array != null)
					{
						list2.AddRange(array);
					}
					list2.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
					int num3 = #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=));
					int num4 = #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z0EHxGg4=.#=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L();
					list2.Add((byte)(num3 >> 24));
					list2.Add((byte)(num4 >> 16));
					list2.Add((byte)(num3 >> 8));
					list2.Add((byte)num4);
					list2.Add((byte)(num3 >> 16));
					list2.Add((byte)(num4 >> 8));
					list2.Add((byte)num3);
					list2.Add((byte)(num4 >> 24));
					int count = list2.Count;
					ulong num5 = 0UL;
					for (int num6 = 0; num6 != count; num6++)
					{
						num5 += (ulong)list2[num6];
						num5 += num5 << 20;
						num5 ^= num5 >> 12;
						list2[num6] = 0;
					}
					num5 += num5 << 6;
					num5 ^= num5 >> 22;
					num5 += num5 << 30;
					num2 = (long)num5;
					num2 ^= 6576862420065348147L;
					#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zu7PmkjEFUT8JPyEIY59EBeTKXwqs.#=zzrte_GTb8ruty559CQae_4UPeMyp(num2);
				}
				result = num2;
			}
			finally
			{
				Monitor.Exit(obj);
			}
			return result;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000061BC File Offset: 0x000043BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void #=zC$cvsu0=(byte[] #=zk7oZD9yg9_M86qiFif0Ywsjb0gVC)
		{
			if (Assembly.GetCallingAssembly() != typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=).Assembly || !#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zW$HRmzE2LGJz4MVrUXnZ6f8NXE7e())
			{
				return;
			}
			long num = #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zC$cvsu0=();
			long num2;
			if (true)
			{
				num2 = num;
			}
			byte[] array = new byte[8];
			byte[] array2;
			if (-1 != 0)
			{
				array2 = array;
			}
			array2[0] = (byte)num2;
			array2[1] = (byte)(num2 >> 40);
			array2[2] = (byte)(num2 >> 56);
			array2[3] = (byte)(num2 >> 48);
			array2[4] = (byte)(num2 >> 32);
			array2[5] = (byte)(num2 >> 24);
			array2[6] = (byte)(num2 >> 16);
			array2[7] = (byte)(num2 >> 8);
			int num3 = #=zk7oZD9yg9_M86qiFif0Ywsjb0gVC.Length;
			int num4;
			if (3 != 0)
			{
				num4 = num3;
			}
			for (int num5 = 0; num5 != num4; num5++)
			{
				int num6 = num5;
				#=zk7oZD9yg9_M86qiFif0Ywsjb0gVC[num6] ^= (byte)((int)array2[num5 & 7] + num5);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000233C File Offset: 0x0000053C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool #=zW$HRmzE2LGJz4MVrUXnZ6f8NXE7e()
		{
			return #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zbNagAP8yHr63jGupHVpb9KS0$59H();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00006270 File Offset: 0x00004470
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool #=zbNagAP8yHr63jGupHVpb9KS0$59H()
		{
			StackTrace stackTrace = new StackTrace();
			StackTrace stackTrace2;
			if (4 != 0)
			{
				stackTrace2 = stackTrace;
			}
			StackFrame frame = stackTrace2.GetFrame(3);
			StackFrame stackFrame;
			if (true)
			{
				stackFrame = frame;
			}
			MethodBase methodBase = (stackFrame == null) ? null : stackFrame.GetMethod();
			MethodBase methodBase2;
			if (true)
			{
				methodBase2 = methodBase;
			}
			Type type = (methodBase2 == null) ? null : methodBase2.DeclaringType;
			return type != typeof(RuntimeMethodHandle) && type != null && type.Assembly == typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=).Assembly;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000062EC File Offset: 0x000044EC
		private static int #=z4fN390V1mKGSKXeBok35$JsjxQnp(Type #=zkB9hFkpY1tbbZWZSH67xydNFEhfS)
		{
			if (-1 == 0)
			{
			}
			return #=zkB9hFkpY1tbbZWZSH67xydNFEhfS.MetadataToken;
		}

		// Token: 0x04000051 RID: 81
		private static #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zNf5GMpJKGjFOQdevL$4Ind5wJF4H #=zu7PmkjEFUT8JPyEIY59EBeTKXwqs;

		// Token: 0x0200001F RID: 31
		private sealed class #=z0EHxGg4=
		{
			// Token: 0x060000B8 RID: 184 RVA: 0x0000630C File Offset: 0x0000450C
			public #=z0EHxGg4=()
			{
				if (2 == 0)
				{
				}
				base..ctor();
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x0000632C File Offset: 0x0000452C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static int #=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L()
			{
				return #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zc10FgAsKAfFQbZWhv3ND6n3EEGKL(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=ziiZdLuBYQ_Z_POTcp1R8SdnbAVr1(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zcNrGF1k=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zc10FgAsKAfFQbZWhv3ND6n3EEGKL(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z0EHxGg4=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zS_qGIMs=)))), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zCQwzQtE=.#=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L());
			}
		}

		// Token: 0x02000020 RID: 32
		private sealed class #=zAovzzBc=
		{
			// Token: 0x060000BA RID: 186 RVA: 0x0000637C File Offset: 0x0000457C
			public #=zAovzzBc=()
			{
				if (!true)
				{
				}
				base..ctor();
			}

			// Token: 0x060000BB RID: 187 RVA: 0x0000639C File Offset: 0x0000459C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static int #=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L()
			{
				return #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zc10FgAsKAfFQbZWhv3ND6n3EEGKL(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zAovzzBc=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zkiVbEgKegxiYCEhUx7fIF4HSjN0S(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z0EHxGg4=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=ziiZdLuBYQ_Z_POTcp1R8SdnbAVr1(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zcNrGF1k=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zc10FgAsKAfFQbZWhv3ND6n3EEGKL(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zxy6GTQk=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zkiVbEgKegxiYCEhUx7fIF4HSjN0S(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zS_qGIMs=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zCQwzQtE=)))))));
			}
		}

		// Token: 0x02000021 RID: 33
		private sealed class #=zCQwzQtE=
		{
			// Token: 0x060000BC RID: 188 RVA: 0x0000641C File Offset: 0x0000461C
			public #=zCQwzQtE=()
			{
				if (!true)
				{
				}
				base..ctor();
			}

			// Token: 0x060000BD RID: 189 RVA: 0x0000643C File Offset: 0x0000463C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static int #=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L()
			{
				return #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zkiVbEgKegxiYCEhUx7fIF4HSjN0S(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zCQwzQtE=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zc10FgAsKAfFQbZWhv3ND6n3EEGKL(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=ziiZdLuBYQ_Z_POTcp1R8SdnbAVr1(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zS_qGIMs=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z0EHxGg4=))), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zc10FgAsKAfFQbZWhv3ND6n3EEGKL(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zxy6GTQk=)) ^ -(~(-(~(-(~(~(-(~-1668185147)))))))), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zS_qGIMs=.#=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L())));
			}
		}

		// Token: 0x02000022 RID: 34
		private sealed class #=zNf5GMpJKGjFOQdevL$4Ind5wJF4H
		{
			// Token: 0x060000BE RID: 190 RVA: 0x000064B0 File Offset: 0x000046B0
			internal #=zNf5GMpJKGjFOQdevL$4Ind5wJF4H()
			{
				long #=zohHD_N3IRLonvEoDqQcGo9E= = 0L;
				if (!false)
				{
					this.#=zzrte_GTb8ruty559CQae_4UPeMyp(#=zohHD_N3IRLonvEoDqQcGo9E=);
				}
			}

			// Token: 0x060000BF RID: 191 RVA: 0x000064D4 File Offset: 0x000046D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal long #=zbk8ZcQuJutypYdwa2$L$XL3fU5yt()
			{
				if (Assembly.GetCallingAssembly() != typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zNf5GMpJKGjFOQdevL$4Ind5wJF4H).Assembly)
				{
					return 2918384L;
				}
				if (!#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zW$HRmzE2LGJz4MVrUXnZ6f8NXE7e())
				{
					return 2918384L;
				}
				int[] array = new int[4];
				int[] array2;
				if (8 != 0)
				{
					array2 = array;
				}
				array2[3] = -(~(-(~(~(-(-(~(~1026046633))))))));
				array2[1] = ~(-(~(-(~(-(-(~(~(-(~-1104851588))))))))));
				array2[2] = -(~(~(-(-(~(~(-(~(-(~-339877174))))))))));
				array2[0] = ~(-(~(-(-(~(~(-(~1427824947))))))));
				int num = this.#=ziisYERNcyMWXKZBT4w3LZ2k=;
				int num2;
				if (5 != 0)
				{
					num2 = num;
				}
				int num3 = this.#=zyz5baksNm4O7ViPYkR7QPsr0A4DD;
				int num4;
				if (5 != 0)
				{
					num4 = num3;
				}
				int num5 = ~(-(~(-(-(~(~(-(~1640531524))))))));
				int num6;
				if (7 != 0)
				{
					num6 = num5;
				}
				int num7 = -(~(~(-(-(~(-(~(~(-(~957401312))))))))));
				int num8;
				if (true)
				{
					num8 = num7;
				}
				for (int num9 = 0; num9 != 32; num9++)
				{
					num4 -= ((num2 << 4 ^ num2 >> 5) + num2 ^ num8 + array2[num8 >> 11 & 3]);
					num8 -= num6;
					num2 -= ((num4 << 4 ^ num4 >> 5) + num4 ^ num8 + array2[num8 & 3]);
				}
				for (int num10 = 0; num10 != 4; num10++)
				{
					array2[num10] = 0;
				}
				ulong num11 = (ulong)((ulong)((long)num4) << 32);
				return (long)(num11 | (ulong)num2);
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00006614 File Offset: 0x00004814
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void #=zzrte_GTb8ruty559CQae_4UPeMyp(long #=zohHD_N3IRLonvEoDqQcGo9E=)
			{
				if (Assembly.GetCallingAssembly() != typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zNf5GMpJKGjFOQdevL$4Ind5wJF4H).Assembly)
				{
					return;
				}
				if (!#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zW$HRmzE2LGJz4MVrUXnZ6f8NXE7e())
				{
					return;
				}
				int[] array = new int[4];
				int[] array2;
				if (2 != 0)
				{
					array2 = array;
				}
				array2[1] = -(~(-(~(-(~(-(~(~(-(~-1104851582))))))))));
				array2[0] = -(~(~(-(-(~(-(~(-(~(~1427824952))))))))));
				array2[2] = -(~(-(~(~(-(~(-(~(-(~-339877174))))))))));
				array2[3] = ~(-(-(~(~(-(~(-(~1026046629))))))));
				int num = ~(-(-(~(~(-(~(-(~1640531524))))))));
				int num2;
				if (7 != 0)
				{
					num2 = num;
				}
				int num3 = (int)#=zohHD_N3IRLonvEoDqQcGo9E=;
				int num4;
				if (4 != 0)
				{
					num4 = num3;
				}
				int num5 = (int)(#=zohHD_N3IRLonvEoDqQcGo9E= >> 32);
				int num6;
				if (3 != 0)
				{
					num6 = num5;
				}
				int num7 = 0;
				int num8;
				if (!false)
				{
					num8 = num7;
				}
				for (int num9 = 0; num9 != 32; num9++)
				{
					num4 += ((num6 << 4 ^ num6 >> 5) + num6 ^ num8 + array2[num8 & 3]);
					num8 += num2;
					num6 += ((num4 << 4 ^ num4 >> 5) + num4 ^ num8 + array2[num8 >> 11 & 3]);
				}
				for (int num10 = 0; num10 != 4; num10++)
				{
					array2[num10] = 0;
				}
				this.#=ziisYERNcyMWXKZBT4w3LZ2k= = num4;
				this.#=zyz5baksNm4O7ViPYkR7QPsr0A4DD = num6;
			}

			// Token: 0x04000052 RID: 82
			private int #=ziisYERNcyMWXKZBT4w3LZ2k=;

			// Token: 0x04000053 RID: 83
			private int #=zyz5baksNm4O7ViPYkR7QPsr0A4DD;
		}

		// Token: 0x02000023 RID: 35
		private sealed class #=zS_qGIMs=
		{
			// Token: 0x060000C1 RID: 193 RVA: 0x00006734 File Offset: 0x00004934
			public #=zS_qGIMs=()
			{
				if (6 == 0)
				{
				}
				base..ctor();
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00002348 File Offset: 0x00000548
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static int #=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L()
			{
				return #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=ziiZdLuBYQ_Z_POTcp1R8SdnbAVr1(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=ziiZdLuBYQ_Z_POTcp1R8SdnbAVr1(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zxy6GTQk=.#=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L(), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zkiVbEgKegxiYCEhUx7fIF4HSjN0S(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zS_qGIMs=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zcNrGF1k=.#=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L())), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zCQwzQtE=)));
			}
		}

		// Token: 0x02000024 RID: 36
		private static class #=zTZMvXZA1Z59YZz27nnY92g_58qM2
		{
			// Token: 0x060000C3 RID: 195 RVA: 0x00006754 File Offset: 0x00004954
			internal static int #=zkiVbEgKegxiYCEhUx7fIF4HSjN0S(int #=zIA3I_Wa3TPeTnMIqPOd6ApAHKa4x, int #=zvnIwebjhh88BjOAk20u1ADkLMc6H)
			{
				if (3 == 0)
				{
				}
				if (3 == 0)
				{
				}
				return #=zIA3I_Wa3TPeTnMIqPOd6ApAHKa4x ^ #=zvnIwebjhh88BjOAk20u1ADkLMc6H - -(~(~(-(-(~(-(~(~2016430934))))))));
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x00006788 File Offset: 0x00004988
			internal static int #=ziiZdLuBYQ_Z_POTcp1R8SdnbAVr1(int #=zIA3I_Wa3TPeTnMIqPOd6ApAHKa4x, int #=zvnIwebjhh88BjOAk20u1ADkLMc6H)
			{
				if (!true)
				{
				}
				int num = #=zIA3I_Wa3TPeTnMIqPOd6ApAHKa4x - -(~(-(~(-(~(~(-(~461833700))))))));
				if (!true)
				{
				}
				return num ^ #=zvnIwebjhh88BjOAk20u1ADkLMc6H + ~(-(-(~(~(-(-(~(-(~(~437191220))))))))));
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x000067CC File Offset: 0x000049CC
			internal static int #=zc10FgAsKAfFQbZWhv3ND6n3EEGKL(int #=zIA3I_Wa3TPeTnMIqPOd6ApAHKa4x, int #=zvnIwebjhh88BjOAk20u1ADkLMc6H)
			{
				if (-1 == 0)
				{
				}
				if (8 == 0)
				{
				}
				int num = #=zvnIwebjhh88BjOAk20u1ADkLMc6H - ~(-(-(~(~(-(~(-(~-2084312769))))))));
				if (!true)
				{
				}
				return #=zIA3I_Wa3TPeTnMIqPOd6ApAHKa4x ^ (num ^ #=zIA3I_Wa3TPeTnMIqPOd6ApAHKa4x - #=zvnIwebjhh88BjOAk20u1ADkLMc6H);
			}
		}

		// Token: 0x02000025 RID: 37
		private sealed class #=zcNrGF1k=
		{
			// Token: 0x060000C6 RID: 198 RVA: 0x0000680C File Offset: 0x00004A0C
			public #=zcNrGF1k=()
			{
				if (8 == 0)
				{
				}
				base..ctor();
			}

			// Token: 0x060000C7 RID: 199 RVA: 0x0000682C File Offset: 0x00004A2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static int #=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L()
			{
				return #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zkiVbEgKegxiYCEhUx7fIF4HSjN0S(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zxy6GTQk=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zAovzzBc=)) ^ #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=ziiZdLuBYQ_Z_POTcp1R8SdnbAVr1(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zcNrGF1k=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zc10FgAsKAfFQbZWhv3ND6n3EEGKL(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zCQwzQtE=)), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zAovzzBc=.#=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L())));
			}
		}

		// Token: 0x02000026 RID: 38
		private sealed class #=zxy6GTQk=
		{
			// Token: 0x060000C8 RID: 200 RVA: 0x0000688C File Offset: 0x00004A8C
			public #=zxy6GTQk=()
			{
				if (false)
				{
				}
				base..ctor();
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x000068AC File Offset: 0x00004AAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static int #=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L()
			{
				return #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zc10FgAsKAfFQbZWhv3ND6n3EEGKL(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=zkiVbEgKegxiYCEhUx7fIF4HSjN0S(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zcNrGF1k=.#=zUTZ8afOjYs4qwDnrJ6MuTP08hi2L() ^ -(~(~(-(~(-(~(-(~-527758449)))))))), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zAovzzBc=))), #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zTZMvXZA1Z59YZz27nnY92g_58qM2.#=ziiZdLuBYQ_Z_POTcp1R8SdnbAVr1(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z0EHxGg4=)) ^ #=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=z4fN390V1mKGSKXeBok35$JsjxQnp(typeof(#=q8fo2JvmIXLG54hhdeXZJczNWJLXr9Zg7jPj0kfJvLK8=.#=zCQwzQtE=)), -(~(~(-(~(-(-(~(-(~(~-878015651))))))))))));
			}
		}
	}
}
