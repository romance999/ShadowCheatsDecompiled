using System;
using System.Security.Cryptography;

namespace TROLLICUS__
{
	// Token: 0x02000058 RID: 88
	internal sealed class #=qPVSW$660RLVa3Ie1H1BYQaerlANTSFeBErrmQsHSPoc= : SymmetricAlgorithm
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x0000BA10 File Offset: 0x00009C10
		public #=qPVSW$660RLVa3Ie1H1BYQaerlANTSFeBErrmQsHSPoc=(params SymmetricAlgorithm[] #=zBPb3KhA=)
		{
			SymmetricAlgorithm[] array = (SymmetricAlgorithm[])#=zBPb3KhA=.Clone();
			if (-1 != 0)
			{
				#=zBPb3KhA= = array;
			}
			SymmetricAlgorithm[] array2 = #=zBPb3KhA=;
			Comparison<SymmetricAlgorithm> comparison;
			if ((comparison = #=qPVSW$660RLVa3Ie1H1BYQaerlANTSFeBErrmQsHSPoc=.#=zBPb3KhA=.#=zur7PLhI=) == null)
			{
				Comparison<SymmetricAlgorithm> comparison2 = comparison = new Comparison<SymmetricAlgorithm>(#=qPVSW$660RLVa3Ie1H1BYQaerlANTSFeBErrmQsHSPoc=.#=zBPb3KhA=.#=zBPb3KhA=.#=zpVQGdM8OsYNnIRjVDKa50cuBpah6ZfjVpTNyg$m2VIXK);
				if (7 != 0)
				{
					#=qPVSW$660RLVa3Ie1H1BYQaerlANTSFeBErrmQsHSPoc=.#=zBPb3KhA=.#=zur7PLhI= = comparison2;
				}
			}
			if (5 != 0)
			{
				Array.Sort<SymmetricAlgorithm>(array2, comparison);
			}
			this.#=zBPb3KhA= = #=zBPb3KhA=;
			int num = 0;
			foreach (SymmetricAlgorithm symmetricAlgorithm in #=zBPb3KhA=)
			{
				num += symmetricAlgorithm.KeySize;
				symmetricAlgorithm.Mode = CipherMode.ECB;
				symmetricAlgorithm.Padding = PaddingMode.None;
			}
			this.BlockSizeValue = #=zBPb3KhA=[#=zBPb3KhA=.Length - 1].BlockSize;
			this.LegalBlockSizesValue = new KeySizes[]
			{
				new KeySizes(this.BlockSizeValue, this.BlockSizeValue, 0)
			};
			this.KeySizeValue = num;
			this.LegalKeySizesValue = new KeySizes[]
			{
				new KeySizes(num, num, 0)
			};
			this.#=zur7PLhI= = #=zBPb3KhA=[0].BlockSize;
			this.Mode = CipherMode.ECB;
			this.Padding = PaddingMode.None;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000BB1C File Offset: 0x00009D1C
		public int #=zti2x3wSLWZ2P1DGqJ_UMvs582jNDkfX$cA==()
		{
			if (7 == 0)
			{
			}
			return this.#=zur7PLhI=;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000BB3C File Offset: 0x00009D3C
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0000BB5C File Offset: 0x00009D5C
		public override byte[] IV
		{
			get
			{
				if (-1 == 0)
				{
				}
				return base.IV;
			}
			set
			{
				byte[] ivvalue = (byte[])value.Clone();
				if (7 != 0)
				{
					this.IVValue = ivvalue;
				}
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000BB84 File Offset: 0x00009D84
		public override ICryptoTransform CreateDecryptor(byte[] #=zBPb3KhA=, byte[] #=zur7PLhI=)
		{
			if (3 == 0)
			{
			}
			if (7 == 0)
			{
			}
			if (7 == 0)
			{
			}
			return this.#=zP1RQKIIVISrcbCJUnN6iYEinqnOVRLb6EvIdDgzZtm8e(#=zBPb3KhA=, #=zur7PLhI=, false);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000BBB4 File Offset: 0x00009DB4
		public override ICryptoTransform CreateEncryptor(byte[] #=zBPb3KhA=, byte[] #=zur7PLhI=)
		{
			if (2 == 0)
			{
			}
			if (!true)
			{
			}
			if (5 == 0)
			{
			}
			return this.#=zP1RQKIIVISrcbCJUnN6iYEinqnOVRLb6EvIdDgzZtm8e(#=zBPb3KhA=, #=zur7PLhI=, true);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000BBE4 File Offset: 0x00009DE4
		private ICryptoTransform #=zP1RQKIIVISrcbCJUnN6iYEinqnOVRLb6EvIdDgzZtm8e(byte[] #=zBPb3KhA=, byte[] #=zur7PLhI=, bool #=zBkMjrJ4=)
		{
			if (false)
			{
			}
			int num = #=zBPb3KhA=.Length * 8;
			if (4 == 0)
			{
			}
			if (num != this.KeySize)
			{
				throw new ArgumentException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976710901), #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976710893));
			}
			if (2 == 0)
			{
			}
			if (#=zur7PLhI=.Length * 8 != this.#=zti2x3wSLWZ2P1DGqJ_UMvs582jNDkfX$cA==())
			{
				throw new ArgumentException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976710872), #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976710835));
			}
			return new #=qPVSW$660RLVa3Ie1H1BYQaerlANTSFeBErrmQsHSPoc=.#=zur7PLhI=(this.#=zBPb3KhA=, #=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000232E File Offset: 0x0000052E
		public override void GenerateIV()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000232E File Offset: 0x0000052E
		public override void GenerateKey()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040000D0 RID: 208
		private readonly SymmetricAlgorithm[] #=zBPb3KhA=;

		// Token: 0x040000D1 RID: 209
		private readonly int #=zur7PLhI=;

		// Token: 0x02000059 RID: 89
		[Serializable]
		private sealed class #=zBPb3KhA=
		{
			// Token: 0x060001EA RID: 490 RVA: 0x0000BC6C File Offset: 0x00009E6C
			// Note: this type is marked as 'beforefieldinit'.
			static #=zBPb3KhA=()
			{
				#=qPVSW$660RLVa3Ie1H1BYQaerlANTSFeBErrmQsHSPoc=.#=zBPb3KhA= #=zBPb3KhA= = new #=qPVSW$660RLVa3Ie1H1BYQaerlANTSFeBErrmQsHSPoc=.#=zBPb3KhA=();
				if (-1 != 0)
				{
					#=qPVSW$660RLVa3Ie1H1BYQaerlANTSFeBErrmQsHSPoc=.#=zBPb3KhA=.#=zBPb3KhA= = #=zBPb3KhA=;
				}
			}

			// Token: 0x060001EB RID: 491 RVA: 0x0000BC8C File Offset: 0x00009E8C
			public #=zBPb3KhA=()
			{
				if (false)
				{
				}
				base..ctor();
			}

			// Token: 0x060001EC RID: 492 RVA: 0x0000BCAC File Offset: 0x00009EAC
			internal int #=zpVQGdM8OsYNnIRjVDKa50cuBpah6ZfjVpTNyg$m2VIXK(SymmetricAlgorithm #=zBPb3KhA=, SymmetricAlgorithm #=zur7PLhI=)
			{
				int blockSize = #=zur7PLhI=.BlockSize;
				int num;
				if (2 != 0)
				{
					num = blockSize;
				}
				return num.CompareTo(#=zBPb3KhA=.BlockSize);
			}

			// Token: 0x040000D2 RID: 210
			public static readonly #=qPVSW$660RLVa3Ie1H1BYQaerlANTSFeBErrmQsHSPoc=.#=zBPb3KhA= #=zBPb3KhA=;

			// Token: 0x040000D3 RID: 211
			public static Comparison<SymmetricAlgorithm> #=zur7PLhI=;
		}

		// Token: 0x0200005A RID: 90
		private sealed class #=zur7PLhI= : IDisposable, ICryptoTransform
		{
			// Token: 0x060001ED RID: 493 RVA: 0x0000BCD8 File Offset: 0x00009ED8
			public #=zur7PLhI=(SymmetricAlgorithm[] #=zBPb3KhA=, byte[] #=zur7PLhI=, byte[] #=zBkMjrJ4=, bool #=zt$cqECc=)
			{
				if (5 != 0)
				{
					this.#=zBPb3KhA= = #=zur7PLhI=;
				}
				if (4 != 0)
				{
					this.#=zur7PLhI= = #=zBkMjrJ4=;
				}
				if (7 != 0)
				{
					this.#=zBkMjrJ4= = #=zBPb3KhA=;
				}
				this.#=zfbJ$RjA= = #=zt$cqECc=;
				this.#=zAWZgy3A= = #=zBPb3KhA=[#=zBPb3KhA=.Length - 1].BlockSize / 8;
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x060001EE RID: 494 RVA: 0x0000BD38 File Offset: 0x00009F38
			public int InputBlockSize
			{
				get
				{
					if (2 == 0)
					{
					}
					return this.#=zAWZgy3A=;
				}
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x060001EF RID: 495 RVA: 0x0000BD58 File Offset: 0x00009F58
			public int OutputBlockSize
			{
				get
				{
					if (5 == 0)
					{
					}
					return this.#=zAWZgy3A=;
				}
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x060001F0 RID: 496 RVA: 0x000023B2 File Offset: 0x000005B2
			public bool CanTransformMultipleBlocks
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x060001F1 RID: 497 RVA: 0x000023B2 File Offset: 0x000005B2
			public bool CanReuseTransform
			{
				get
				{
					return true;
				}
			}

			// Token: 0x060001F2 RID: 498 RVA: 0x0000BD78 File Offset: 0x00009F78
			public void Dispose()
			{
				if (this.#=zt$cqECc= != null)
				{
					ICryptoTransform[] array = this.#=zt$cqECc=;
					ICryptoTransform[] array2;
					if (5 != 0)
					{
						array2 = array;
					}
					int num = 0;
					int i;
					if (2 != 0)
					{
						i = num;
					}
					while (i < array2.Length)
					{
						ICryptoTransform cryptoTransform = array2[i];
						ICryptoTransform cryptoTransform2;
						if (6 != 0)
						{
							cryptoTransform2 = cryptoTransform;
						}
						if (cryptoTransform2 != null)
						{
							cryptoTransform2.Dispose();
						}
						i++;
					}
					this.#=zt$cqECc= = null;
				}
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x0000BDD0 File Offset: 0x00009FD0
			private void #=z7GedvqWbdc5sgpeq1Jl64l8=()
			{
				SymmetricAlgorithm[] array = this.#=zBkMjrJ4=;
				SymmetricAlgorithm[] array2;
				if (2 != 0)
				{
					array2 = array;
				}
				int num = array2.Length;
				int num2;
				if (2 != 0)
				{
					num2 = num;
				}
				if (this.#=zt$cqECc= == null)
				{
					ICryptoTransform[] array3 = new ICryptoTransform[num2];
					ICryptoTransform[] array4;
					if (6 != 0)
					{
						array4 = array3;
					}
					int num3 = 0;
					for (int i = 0; i < num2; i++)
					{
						SymmetricAlgorithm symmetricAlgorithm = array2[i];
						int num4 = symmetricAlgorithm.KeySize / 8;
						byte[] array5 = new byte[num4];
						Buffer.BlockCopy(this.#=zBPb3KhA=, num3, array5, 0, num4);
						num3 += num4;
						byte[] rgbIV = new byte[symmetricAlgorithm.BlockSize / 8];
						ICryptoTransform cryptoTransform = this.#=zfbJ$RjA= ? symmetricAlgorithm.CreateEncryptor(array5, rgbIV) : symmetricAlgorithm.CreateDecryptor(array5, rgbIV);
						array4[i] = cryptoTransform;
					}
					this.#=zt$cqECc= = array4;
				}
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x0000BE94 File Offset: 0x0000A094
			public byte[] TransformFinalBlock(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
			{
				byte[] array = new byte[#=zBkMjrJ4=];
				byte[] result;
				if (8 != 0)
				{
					result = array;
				}
				this.TransformBlock(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=, result, 0);
				return result;
			}

			// Token: 0x060001F5 RID: 501 RVA: 0x0000BEC0 File Offset: 0x0000A0C0
			public int TransformBlock(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=, byte[] #=zt$cqECc=, int #=zfbJ$RjA=)
			{
				if (-1 != 0)
				{
					Buffer.BlockCopy(#=zBPb3KhA=, #=zur7PLhI=, #=zt$cqECc=, #=zfbJ$RjA=, #=zBkMjrJ4=);
				}
				if (2 != 0)
				{
					this.#=z7GedvqWbdc5sgpeq1Jl64l8=();
				}
				if (this.#=zfbJ$RjA=)
				{
					if (6 != 0)
					{
						this.#=zmtQnUOZLD51kiJDbsM17jVuWJr9n(#=zt$cqECc=, #=zfbJ$RjA=, #=zBkMjrJ4=);
					}
				}
				else
				{
					this.#=zcvS6w_VZsrgs3_UbpmW_Lmq2fNAygVn_TwhFynk=(#=zt$cqECc=, #=zfbJ$RjA=, #=zBkMjrJ4=);
				}
				return #=zBkMjrJ4=;
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x0000BF1C File Offset: 0x0000A11C
			private void #=zmtQnUOZLD51kiJDbsM17jVuWJr9n(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
			{
				byte[] array = new byte[this.#=zur7PLhI=.Length];
				byte[] array2;
				if (-1 != 0)
				{
					array2 = array;
				}
				Array src = this.#=zur7PLhI=;
				int srcOffset = 0;
				Array dst = array2;
				int dstOffset = 0;
				int count = array2.Length;
				if (2 != 0)
				{
					Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
				}
				int num = 0;
				int num2;
				if (!false)
				{
					num2 = num;
				}
				foreach (ICryptoTransform cryptoTransform in this.#=zt$cqECc=)
				{
					int inputBlockSize = cryptoTransform.InputBlockSize;
					int num3 = #=zBkMjrJ4= - num2 & ~(inputBlockSize - 1);
					int num4 = num2 + num3;
					for (int j = num2; j < num4; j += inputBlockSize)
					{
						int num5 = j + #=zur7PLhI=;
						#=qPVSW$660RLVa3Ie1H1BYQaerlANTSFeBErrmQsHSPoc=.#=zur7PLhI=.#=zX91jOaXWBar6mamMFEoXQB3WxMFda2zxAP6bxX5OqG$e(#=zBPb3KhA=, num5, array2, 0, inputBlockSize);
						cryptoTransform.TransformBlock(#=zBPb3KhA=, num5, inputBlockSize, #=zBPb3KhA=, num5);
						Buffer.BlockCopy(#=zBPb3KhA=, num5, array2, 0, inputBlockSize);
					}
					num2 = num4;
					if (num4 == #=zBkMjrJ4=)
					{
						break;
					}
				}
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
			private void #=zcvS6w_VZsrgs3_UbpmW_Lmq2fNAygVn_TwhFynk=(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
			{
				byte[] array = new byte[this.#=zur7PLhI=.Length];
				byte[] array2;
				if (3 != 0)
				{
					array2 = array;
				}
				Array src = this.#=zur7PLhI=;
				int srcOffset = 0;
				Array dst = array2;
				int dstOffset = 0;
				int count = array2.Length;
				if (8 != 0)
				{
					Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
				}
				byte[] array3 = new byte[array2.Length];
				byte[] array4;
				if (!false)
				{
					array4 = array3;
				}
				int num = 0;
				foreach (ICryptoTransform cryptoTransform in this.#=zt$cqECc=)
				{
					int inputBlockSize = cryptoTransform.InputBlockSize;
					int num2 = #=zBkMjrJ4= - num & ~(inputBlockSize - 1);
					int num3 = num + num2;
					for (int j = num; j < num3; j += inputBlockSize)
					{
						int num4 = j + #=zur7PLhI=;
						Buffer.BlockCopy(#=zBPb3KhA=, num4, array4, 0, inputBlockSize);
						cryptoTransform.TransformBlock(#=zBPb3KhA=, num4, inputBlockSize, #=zBPb3KhA=, num4);
						#=qPVSW$660RLVa3Ie1H1BYQaerlANTSFeBErrmQsHSPoc=.#=zur7PLhI=.#=zX91jOaXWBar6mamMFEoXQB3WxMFda2zxAP6bxX5OqG$e(#=zBPb3KhA=, num4, array2, 0, inputBlockSize);
						Buffer.BlockCopy(array4, 0, array2, 0, inputBlockSize);
					}
					num = num3;
					if (num3 == #=zBkMjrJ4=)
					{
						break;
					}
				}
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x0000C0BC File Offset: 0x0000A2BC
			private static void #=zX91jOaXWBar6mamMFEoXQB3WxMFda2zxAP6bxX5OqG$e(byte[] #=zBPb3KhA=, int #=zur7PLhI=, byte[] #=zBkMjrJ4=, int #=zt$cqECc=, int #=zfbJ$RjA=)
			{
				int num = 0;
				int i;
				if (7 != 0)
				{
					i = num;
				}
				while (i < #=zfbJ$RjA=)
				{
					int num2 = #=zur7PLhI= + i;
					#=zBPb3KhA=[num2] ^= #=zBkMjrJ4=[#=zt$cqECc= + i];
					int num3 = i + 1;
					if (true)
					{
						i = num3;
					}
				}
			}

			// Token: 0x040000D4 RID: 212
			private readonly byte[] #=zBPb3KhA=;

			// Token: 0x040000D5 RID: 213
			private readonly byte[] #=zur7PLhI=;

			// Token: 0x040000D6 RID: 214
			private readonly SymmetricAlgorithm[] #=zBkMjrJ4=;

			// Token: 0x040000D7 RID: 215
			private ICryptoTransform[] #=zt$cqECc=;

			// Token: 0x040000D8 RID: 216
			private readonly bool #=zfbJ$RjA=;

			// Token: 0x040000D9 RID: 217
			private readonly int #=zAWZgy3A=;
		}
	}
}
