using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace TROLLICUS__
{
	// Token: 0x02000081 RID: 129
	internal sealed class #=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4= : SymmetricAlgorithm
	{
		// Token: 0x060003F6 RID: 1014 RVA: 0x00019D78 File Offset: 0x00017F78
		public #=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=()
		{
			KeySizes[] legalBlockSizesValue = new KeySizes[]
			{
				new KeySizes(32, 32, 0)
			};
			if (-1 != 0)
			{
				this.LegalBlockSizesValue = legalBlockSizesValue;
			}
			KeySizes[] legalKeySizesValue = new KeySizes[]
			{
				new KeySizes(80, 80, 0)
			};
			if (-1 != 0)
			{
				this.LegalKeySizesValue = legalKeySizesValue;
			}
			int blockSizeValue = 32;
			if (8 != 0)
			{
				this.BlockSizeValue = blockSizeValue;
			}
			this.KeySizeValue = 80;
			this.ModeValue = CipherMode.ECB;
			this.PaddingValue = PaddingMode.None;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00019DF4 File Offset: 0x00017FF4
		public #=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=(byte[] #=zBPb3KhA=)
		{
			if (7 == 0)
			{
			}
			this..ctor();
			if (8 == 0)
			{
			}
			if (false)
			{
			}
			if (#=zBPb3KhA= == null)
			{
				throw new ArgumentNullException();
			}
			this.Key = #=zBPb3KhA=;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00019E34 File Offset: 0x00018034
		// Note: this type is marked as 'beforefieldinit'.
		static #=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=()
		{
			byte[] array = new byte[256];
			RuntimeFieldHandle fldHandle = fieldof(#=qtkdPYZcWrOMgix1FkJfTpu_Qxd5pTVK0rzQvmCYYIxo=.#=zur7PLhI=).FieldHandle;
			if (!false)
			{
				RuntimeHelpers.InitializeArray(array, fldHandle);
			}
			if (2 != 0)
			{
				#=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=.#=zBPb3KhA= = array;
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00019E6C File Offset: 0x0001806C
		public override ICryptoTransform CreateDecryptor(byte[] #=zBPb3KhA=, byte[] #=zur7PLhI=)
		{
			if (!true)
			{
			}
			return new #=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=.#=zBPb3KhA=(#=zBPb3KhA=, false);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00019E8C File Offset: 0x0001808C
		public override ICryptoTransform CreateEncryptor(byte[] #=zBPb3KhA=, byte[] #=zur7PLhI=)
		{
			if (-1 == 0)
			{
			}
			return new #=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=.#=zBPb3KhA=(#=zBPb3KhA=, true);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000240C File Offset: 0x0000060C
		public override void GenerateIV()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000240C File Offset: 0x0000060C
		public override void GenerateKey()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00019EAC File Offset: 0x000180AC
		private static ushort #=zF$7uB6WW2nxid0UOb3zN1$U=(byte[] #=zBPb3KhA=, int #=zur7PLhI=, ushort #=zBkMjrJ4=)
		{
			byte b = (byte)(#=zBkMjrJ4= >> 8);
			byte b2;
			if (true)
			{
				b2 = b;
			}
			byte b3 = (byte)#=zBkMjrJ4=;
			byte b4;
			if (4 != 0)
			{
				b4 = b3;
			}
			byte b5 = #=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=.#=zBPb3KhA=[(int)(b4 ^ #=zBPb3KhA=[4 * #=zur7PLhI= % 10])] ^ b2;
			byte b6;
			if (8 != 0)
			{
				b6 = b5;
			}
			byte b7 = #=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=.#=zBPb3KhA=[(int)(b6 ^ #=zBPb3KhA=[(4 * #=zur7PLhI= + 1) % 10])] ^ b4;
			byte b8 = #=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=.#=zBPb3KhA=[(int)(b7 ^ #=zBPb3KhA=[(4 * #=zur7PLhI= + 2) % 10])] ^ b6;
			byte b9 = #=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=.#=zBPb3KhA=[(int)(b8 ^ #=zBPb3KhA=[(4 * #=zur7PLhI= + 3) % 10])] ^ b7;
			return (ushort)(((int)b8 << 8) + (int)b9);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00019F38 File Offset: 0x00018138
		private static void #=zn8jwIba9NHlXofcSrCDIQsE=(byte[] #=zBPb3KhA=, byte[] #=zur7PLhI=, int #=zBkMjrJ4=, byte[] #=zt$cqECc=, int #=zfbJ$RjA=, bool #=zAWZgy3A=)
		{
			int num2;
			int num4;
			if (#=zAWZgy3A=)
			{
				int num = 1;
				if (5 != 0)
				{
					num2 = num;
				}
				int num3 = 0;
				if (8 != 0)
				{
					num4 = num3;
				}
			}
			else
			{
				int num5 = -1;
				if (!false)
				{
					num2 = num5;
				}
				num4 = 23;
			}
			ushort num6 = (ushort)(((int)#=zur7PLhI=[#=zBkMjrJ4=] << 8) + (int)#=zur7PLhI=[#=zBkMjrJ4= + 1]);
			ushort num7 = (ushort)(((int)#=zur7PLhI=[#=zBkMjrJ4= + 2] << 8) + (int)#=zur7PLhI=[#=zBkMjrJ4= + 3]);
			for (int i = 0; i < 12; i++)
			{
				num7 ^= (ushort)((int)#=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=.#=zF$7uB6WW2nxid0UOb3zN1$U=(#=zBPb3KhA=, num4, num6) ^ num4);
				num4 += num2;
				num6 ^= (ushort)((int)#=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=.#=zF$7uB6WW2nxid0UOb3zN1$U=(#=zBPb3KhA=, num4, num7) ^ num4);
				num4 += num2;
			}
			#=zt$cqECc=[#=zfbJ$RjA=] = (byte)(num7 >> 8);
			#=zt$cqECc=[#=zfbJ$RjA= + 1] = (byte)num7;
			#=zt$cqECc=[#=zfbJ$RjA= + 2] = (byte)(num6 >> 8);
			#=zt$cqECc=[#=zfbJ$RjA= + 3] = (byte)num6;
		}

		// Token: 0x0400011C RID: 284
		private static byte[] #=zBPb3KhA=;

		// Token: 0x02000082 RID: 130
		private sealed class #=zBPb3KhA= : IDisposable, ICryptoTransform
		{
			// Token: 0x060003FF RID: 1023 RVA: 0x00019FE0 File Offset: 0x000181E0
			public #=zBPb3KhA=(byte[] #=zBPb3KhA=, bool #=zur7PLhI=)
			{
				if (6 != 0)
				{
					this.#=zBPb3KhA= = #=zBPb3KhA=;
				}
				if (3 != 0)
				{
					this.#=zur7PLhI= = #=zur7PLhI=;
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000400 RID: 1024 RVA: 0x000024B7 File Offset: 0x000006B7
			public int InputBlockSize
			{
				get
				{
					return 4;
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000401 RID: 1025 RVA: 0x000024B7 File Offset: 0x000006B7
			public int OutputBlockSize
			{
				get
				{
					return 4;
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000402 RID: 1026 RVA: 0x000023B2 File Offset: 0x000005B2
			public bool CanTransformMultipleBlocks
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000403 RID: 1027 RVA: 0x000023B2 File Offset: 0x000005B2
			public bool CanReuseTransform
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x000023AD File Offset: 0x000005AD
			public void Dispose()
			{
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x0001A014 File Offset: 0x00018214
			public int TransformBlock(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=, byte[] #=zt$cqECc=, int #=zfbJ$RjA=)
			{
				if (#=zBkMjrJ4= % 4 != 0)
				{
					throw new ArgumentOutOfRangeException();
				}
				int num = 0;
				int i;
				if (7 != 0)
				{
					i = num;
				}
				while (i < #=zBkMjrJ4=)
				{
					byte[] array = this.#=zBPb3KhA=;
					int #=zBkMjrJ4=2 = #=zur7PLhI= + i;
					int #=zfbJ$RjA=2 = #=zfbJ$RjA= + i;
					bool #=zAWZgy3A= = this.#=zur7PLhI=;
					if (!false)
					{
						#=qTAY2hsSefxYQBF$KQVo2znQoOdPCtwnkbbHCaAD5UN4=.#=zn8jwIba9NHlXofcSrCDIQsE=(array, #=zBPb3KhA=, #=zBkMjrJ4=2, #=zt$cqECc=, #=zfbJ$RjA=2, #=zAWZgy3A=);
					}
					int num2 = i + 4;
					if (3 != 0)
					{
						i = num2;
					}
				}
				return #=zBkMjrJ4=;
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x0001A070 File Offset: 0x00018270
			public byte[] TransformFinalBlock(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
			{
				byte[] array = new byte[#=zBkMjrJ4=];
				byte[] array2;
				if (true)
				{
					array2 = array;
				}
				this.TransformBlock(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=, array2, 0);
				return array2;
			}

			// Token: 0x0400011D RID: 285
			private byte[] #=zBPb3KhA=;

			// Token: 0x0400011E RID: 286
			private bool #=zur7PLhI=;
		}
	}
}
