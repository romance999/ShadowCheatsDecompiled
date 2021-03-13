using System;
using System.IO;

namespace TROLLICUS__
{
	// Token: 0x020000B7 RID: 183
	internal sealed class #=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE= : #=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI=, IDisposable
	{
		// Token: 0x0600055A RID: 1370 RVA: 0x00021AC0 File Offset: 0x0001FCC0
		public #=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE=()
		{
			if (6 == 0)
			{
			}
			this..ctor(0);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00021AE0 File Offset: 0x0001FCE0
		public #=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE=(int #=zBPb3KhA=)
		{
			if (#=zBPb3KhA= < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[#=zBPb3KhA=];
			if (2 != 0)
			{
				this.#=zBPb3KhA= = array;
			}
			if (7 != 0)
			{
				this.#=zfbJ$RjA= = #=zBPb3KhA=;
			}
			bool flag = true;
			if (6 != 0)
			{
				this.#=zAWZgy3A= = flag;
			}
			this.#=zkzlpT_c= = true;
			this.#=zur7PLhI= = 0;
			this.#=zWVcvLK0= = true;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00021B44 File Offset: 0x0001FD44
		public #=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE=(byte[] #=zBPb3KhA=)
		{
			if (8 == 0)
			{
			}
			if (2 == 0)
			{
			}
			this..ctor(#=zBPb3KhA=, true);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00021B6C File Offset: 0x0001FD6C
		public #=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE=(byte[] #=zBPb3KhA=, bool #=zur7PLhI=)
		{
			if (#=zBPb3KhA= == null)
			{
				throw new ArgumentNullException();
			}
			if (7 != 0)
			{
				this.#=zBPb3KhA= = #=zBPb3KhA=;
			}
			int num = #=zBPb3KhA=.Length;
			int num2;
			if (!false)
			{
				num2 = num;
			}
			if (-1 != 0)
			{
				this.#=zfbJ$RjA= = num;
			}
			this.#=zt$cqECc= = num2;
			this.#=zkzlpT_c= = #=zur7PLhI=;
			this.#=zur7PLhI= = 0;
			this.#=zWVcvLK0= = true;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00021BCC File Offset: 0x0001FDCC
		public #=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE=(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			if (4 == 0)
			{
			}
			if (2 == 0)
			{
			}
			if (2 == 0)
			{
			}
			this..ctor(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=, true);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00021C00 File Offset: 0x0001FE00
		public #=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE=(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=, bool #=zt$cqECc=)
		{
			if (#=zBPb3KhA= == null)
			{
				throw new ArgumentNullException();
			}
			if (#=zur7PLhI= < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (#=zBkMjrJ4= < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (#=zBPb3KhA=.Length - #=zur7PLhI= < #=zBkMjrJ4=)
			{
				throw new ArgumentException();
			}
			if (7 != 0)
			{
				this.#=zBPb3KhA= = #=zBPb3KhA=;
			}
			int num;
			if (4 != 0)
			{
				num = #=zur7PLhI=;
			}
			if (!false)
			{
				this.#=zBkMjrJ4= = #=zur7PLhI=;
			}
			this.#=zur7PLhI= = num;
			num = (this.#=zfbJ$RjA= = #=zur7PLhI= + #=zBkMjrJ4=);
			this.#=zt$cqECc= = num;
			this.#=zkzlpT_c= = #=zt$cqECc=;
			this.#=zAWZgy3A= = false;
			this.#=zWVcvLK0= = true;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00021C94 File Offset: 0x0001FE94
		public override bool #=z1q9E0OZmu549QYDxFUzzcHU1qboDoRMEIH5jxmCfgrpSbNDB2DNneRzxj$ySIog4bV8oHnSRBnbz1Jn_zEL1Hqs=()
		{
			if (2 == 0)
			{
			}
			return this.#=zWVcvLK0=;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00021CB4 File Offset: 0x0001FEB4
		public override bool #=zHGvytZRZrtSu1RUt$Bj5JcDluvdfcNeb$NgkYNEkSLKqgETpDjy9ICdnhsz6B4tZSTro1y_Qx51r()
		{
			if (false)
			{
			}
			return this.#=zWVcvLK0=;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00021CD4 File Offset: 0x0001FED4
		public override bool #=zkiVpZp6gp67J2FSl8aWv6rBFsNFBukTed2l7J3G9Of5TzXgHgcfhMiMK85bV2_ICGdpAETtpav_wLdkZN9u5v34=()
		{
			if (6 == 0)
			{
			}
			return this.#=zkzlpT_c=;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00021CF4 File Offset: 0x0001FEF4
		protected override void #=zxaHUvTliATinvRd04yU5T1YHTebVg$P1bT25yz9dTbKe5r_BVjjFuq3zG$vVpKZ8RvpYQqnMNPAZidFzATqh_fQ=(bool #=zBPb3KhA=)
		{
			if (!this.#=zuANKhdE=)
			{
				if (#=zBPb3KhA=)
				{
					bool flag = false;
					if (8 != 0)
					{
						this.#=zWVcvLK0= = flag;
					}
					bool flag2 = false;
					if (2 != 0)
					{
						this.#=zkzlpT_c= = flag2;
					}
					bool flag3 = false;
					if (5 != 0)
					{
						this.#=zAWZgy3A= = flag3;
					}
				}
				this.#=zuANKhdE= = true;
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00021D40 File Offset: 0x0001FF40
		private bool #=zDbtZv1ai1ZYW5lgOdCBezaSDxbIBh_R4$gnmlvPQyC2H(int #=zBPb3KhA=)
		{
			if (#=zBPb3KhA= < 0)
			{
				throw new IOException();
			}
			if (#=zBPb3KhA= > this.#=zfbJ$RjA=)
			{
				int num;
				if (6 != 0)
				{
					num = #=zBPb3KhA=;
				}
				if (num < 256)
				{
					int num2 = 256;
					if (2 != 0)
					{
						num = num2;
					}
				}
				if (num < this.#=zfbJ$RjA= * 2)
				{
					int num3 = this.#=zfbJ$RjA= * 2;
					if (8 != 0)
					{
						num = num3;
					}
				}
				this.#=z94wiCpIGX2GFJtSZpXk8cp7x18YxTGsGTg==(num);
				return true;
			}
			return false;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000023AD File Offset: 0x000005AD
		public override void #=zXP$uCFLDmTdV1eJoPxXWSbOZqAgEQplzqWQ1Y6v812cs4ajU0HmnU3ldLgK0yuiQVcLKHK8=()
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00021DA8 File Offset: 0x0001FFA8
		internal byte[] #=zX_C$p37tQan8nN8XaTedl8o=()
		{
			if (7 == 0)
			{
			}
			return this.#=zBPb3KhA=;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00021DC8 File Offset: 0x0001FFC8
		internal void #=z8UTrFxbRLFmDcq7QRwoI6iz8tUQda2S8dg==(out int #=zBPb3KhA=, out int #=zur7PLhI=)
		{
			if (5 == 0)
			{
			}
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (7 == 0)
			{
			}
			if (7 == 0)
			{
			}
			#=zBPb3KhA= = this.#=zur7PLhI=;
			#=zur7PLhI= = this.#=zt$cqECc=;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00021E10 File Offset: 0x00020010
		internal int #=zb6EWjx$9sAGvWR$A5uKb6vo=()
		{
			if (false)
			{
			}
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (8 == 0)
			{
			}
			return this.#=zBkMjrJ4=;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00021E48 File Offset: 0x00020048
		public int #=zMKzS24bj6GDxHwYQlIvc4$1zhSopyMBFmw==(int #=zBPb3KhA=)
		{
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			int num = this.#=zt$cqECc= - this.#=zBkMjrJ4=;
			int num2;
			if (true)
			{
				num2 = num;
			}
			if (num2 > #=zBPb3KhA=)
			{
				if (3 != 0)
				{
					num2 = #=zBPb3KhA=;
				}
			}
			if (num2 < 0)
			{
				int num3 = 0;
				if (5 != 0)
				{
					num2 = num3;
				}
			}
			this.#=zBkMjrJ4= += num2;
			return num2;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00021EA4 File Offset: 0x000200A4
		public int #=zQz$vBFT16WRi6DJQ3SrkcIx2NS64qep5mzXoLbCL7uEC()
		{
			if (2 == 0)
			{
			}
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (6 == 0)
			{
			}
			int num = this.#=zfbJ$RjA=;
			if (!true)
			{
			}
			return num - this.#=zur7PLhI=;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00021EE8 File Offset: 0x000200E8
		public void #=z94wiCpIGX2GFJtSZpXk8cp7x18YxTGsGTg==(int #=zBPb3KhA=)
		{
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (#=zBPb3KhA= != this.#=zfbJ$RjA=)
			{
				if (!this.#=zAWZgy3A=)
				{
					throw new Exception();
				}
				if (#=zBPb3KhA= < this.#=zt$cqECc=)
				{
					throw new ArgumentOutOfRangeException();
				}
				if (#=zBPb3KhA= > 0)
				{
					byte[] array = new byte[#=zBPb3KhA=];
					byte[] array2;
					if (true)
					{
						array2 = array;
					}
					if (this.#=zt$cqECc= > 0)
					{
						Array src = this.#=zBPb3KhA=;
						int srcOffset = 0;
						Array dst = array2;
						int dstOffset = 0;
						int count = this.#=zt$cqECc=;
						if (8 != 0)
						{
							Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
						}
					}
					byte[] array3 = array2;
					if (2 != 0)
					{
						this.#=zBPb3KhA= = array3;
					}
				}
				else
				{
					this.#=zBPb3KhA= = null;
				}
				this.#=zfbJ$RjA= = #=zBPb3KhA=;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00021F88 File Offset: 0x00020188
		public override long #=zCcKEPci$UlrbxbOId2IsxbmBnrrm5WdNYsqdC07pm4BahNXE4f6N$1s0gRFs8mILaU5ln$YB1RObFiWhIFMPk0s=()
		{
			if (4 == 0)
			{
			}
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (5 == 0)
			{
			}
			int num = this.#=zt$cqECc=;
			if (7 == 0)
			{
			}
			return (long)(num - this.#=zur7PLhI=);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00021FD0 File Offset: 0x000201D0
		public override long #=zMysjAtVaLLTr6mzPBtOKzArTBs63jiP92PK1tUICNZWQaJ6zSHl4DgBVtSzZ_D0NIxwSmPp8OLtZ()
		{
			if (false)
			{
			}
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (3 == 0)
			{
			}
			int num = this.#=zBkMjrJ4=;
			if (5 == 0)
			{
			}
			return (long)(num - this.#=zur7PLhI=);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00022018 File Offset: 0x00020218
		public override void #=zUueHPMSSKBvx8SWMKllj9lrVJE2a_THQWKfzTg5ZZSNnCGlQ5Fu7zwZMfd7AQptTNBDcjkg=(long #=zBPb3KhA=)
		{
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (#=zBPb3KhA= < 0L)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (#=zBPb3KhA= > 2147483647L)
			{
				throw new ArgumentOutOfRangeException();
			}
			int num = this.#=zur7PLhI= + (int)#=zBPb3KhA=;
			if (true)
			{
				this.#=zBkMjrJ4= = num;
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00022068 File Offset: 0x00020268
		public override int #=zJEMk1xYVLJ233KFf6ByNB0yl4jE1Z0jS$gMDXnRJeziYez6tri3oA4WgUQRAy6D1RvfuPJ4=(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (#=zBPb3KhA= == null)
			{
				throw new ArgumentNullException();
			}
			if (#=zur7PLhI= < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (#=zBkMjrJ4= < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (#=zBPb3KhA=.Length - #=zur7PLhI= < #=zBkMjrJ4=)
			{
				throw new ArgumentException();
			}
			int num = this.#=zt$cqECc= - this.#=zBkMjrJ4=;
			int num2;
			if (4 != 0)
			{
				num2 = num;
			}
			if (num2 > #=zBkMjrJ4=)
			{
				if (8 != 0)
				{
					num2 = #=zBkMjrJ4=;
				}
			}
			if (num2 <= 0)
			{
				return 0;
			}
			if (num2 <= 8)
			{
				int num3 = num2;
				int num4;
				if (true)
				{
					num4 = num3;
				}
				while (--num4 >= 0)
				{
					#=zBPb3KhA=[#=zur7PLhI= + num4] = this.#=zBPb3KhA=[this.#=zBkMjrJ4= + num4];
				}
			}
			else
			{
				Buffer.BlockCopy(this.#=zBPb3KhA=, this.#=zBkMjrJ4=, #=zBPb3KhA=, #=zur7PLhI=, num2);
			}
			this.#=zBkMjrJ4= += num2;
			return num2;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00022128 File Offset: 0x00020328
		public override int #=z41E7exaW2fAUSQRWmttMlF$ZquUmdyHZj2pAKewqdHL3CE564buz6bnN7h2RPf_1Pab2Oi4ag0SNrd8p_Q==()
		{
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (this.#=zBkMjrJ4= >= this.#=zt$cqECc=)
			{
				return -1;
			}
			byte[] array = this.#=zBPb3KhA=;
			int num = this.#=zBkMjrJ4=;
			int num2;
			if (7 != 0)
			{
				num2 = num;
			}
			int num3 = num2 + 1;
			if (!false)
			{
				this.#=zBkMjrJ4= = num3;
			}
			return array[num2];
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0002217C File Offset: 0x0002037C
		public override long #=z0u9rel2nIXWusRou8IFJnV65OvYa1a6x77R6rmAGswFsYxLRzL_TKbk$kEOLgQchTL1UzLApALirxYXNco1UbqLod0le(long #=zBPb3KhA=, int #=zur7PLhI=)
		{
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (#=zBPb3KhA= > 2147483647L)
			{
				throw new ArgumentOutOfRangeException();
			}
			switch (#=zur7PLhI=)
			{
			case 0:
			{
				if (#=zBPb3KhA= < 0L)
				{
					throw new IOException();
				}
				int num = this.#=zur7PLhI= + (int)#=zBPb3KhA=;
				if (5 != 0)
				{
					this.#=zBkMjrJ4= = num;
				}
				break;
			}
			case 1:
			{
				if (#=zBPb3KhA= + (long)this.#=zBkMjrJ4= < (long)this.#=zur7PLhI=)
				{
					throw new IOException();
				}
				int num2 = this.#=zBkMjrJ4= + (int)#=zBPb3KhA=;
				if (8 != 0)
				{
					this.#=zBkMjrJ4= = num2;
				}
				break;
			}
			case 2:
			{
				if ((long)this.#=zt$cqECc= + #=zBPb3KhA= < (long)this.#=zur7PLhI=)
				{
					throw new IOException();
				}
				int num3 = this.#=zt$cqECc= + (int)#=zBPb3KhA=;
				if (!false)
				{
					this.#=zBkMjrJ4= = num3;
				}
				break;
			}
			default:
				throw new ArgumentException();
			}
			return (long)this.#=zBkMjrJ4=;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00022250 File Offset: 0x00020450
		public override void #=zeSpwyh4pt$NKI0SxwGImH6DVolQE$XuUsc2k1VmWfQztc5YkBU4sNd8SwmphvmYbFtdeu7hHj$JC$CXCdQ==(long #=zBPb3KhA=)
		{
			if (!this.#=zkzlpT_c=)
			{
				throw new Exception();
			}
			if (#=zBPb3KhA= > 2147483647L)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (#=zBPb3KhA= < 0L || #=zBPb3KhA= > (long)(2147483647 - this.#=zur7PLhI=))
			{
				throw new ArgumentOutOfRangeException();
			}
			int num = this.#=zur7PLhI= + (int)#=zBPb3KhA=;
			int num2;
			if (true)
			{
				num2 = num;
			}
			if (!this.#=zDbtZv1ai1ZYW5lgOdCBezaSDxbIBh_R4$gnmlvPQyC2H(num2) && num2 > this.#=zt$cqECc=)
			{
				Array array = this.#=zBPb3KhA=;
				int index = this.#=zt$cqECc=;
				int length = num2 - this.#=zt$cqECc=;
				if (-1 != 0)
				{
					Array.Clear(array, index, length);
				}
			}
			int num3 = num2;
			if (!false)
			{
				this.#=zt$cqECc= = num3;
			}
			if (this.#=zBkMjrJ4= > num2)
			{
				this.#=zBkMjrJ4= = num2;
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000222FC File Offset: 0x000204FC
		public byte[] #=zshviYv_YIZcEn_NS_XDL6HHkFfN9vc5VEg==()
		{
			byte[] array = new byte[this.#=zt$cqECc= - this.#=zur7PLhI=];
			byte[] array2;
			if (8 != 0)
			{
				array2 = array;
			}
			Array src = this.#=zBPb3KhA=;
			int srcOffset = this.#=zur7PLhI=;
			Array dst = array2;
			int dstOffset = 0;
			int count = this.#=zt$cqECc= - this.#=zur7PLhI=;
			if (!false)
			{
				Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
			}
			return array2;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00022350 File Offset: 0x00020550
		public override void #=za95lGOBeGnyeIkSrVMDXgAcaZbAQK$RGNUFQB8Td0iNrI5oysxMVpb0EAM7NvnvnhJodB1tFkO3xu$n9rw==(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (!this.#=zkzlpT_c=)
			{
				throw new Exception();
			}
			if (#=zBPb3KhA= == null)
			{
				throw new ArgumentNullException();
			}
			if (#=zur7PLhI= < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (#=zBkMjrJ4= < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (#=zBPb3KhA=.Length - #=zur7PLhI= < #=zBkMjrJ4=)
			{
				throw new ArgumentException();
			}
			int num = this.#=zBkMjrJ4= + #=zBkMjrJ4=;
			int num2;
			if (-1 != 0)
			{
				num2 = num;
			}
			if (num2 < 0)
			{
				throw new IOException();
			}
			if (num2 > this.#=zt$cqECc=)
			{
				bool flag = this.#=zBkMjrJ4= > this.#=zt$cqECc=;
				bool flag2;
				if (!false)
				{
					flag2 = flag;
				}
				if (num2 > this.#=zfbJ$RjA= && this.#=zDbtZv1ai1ZYW5lgOdCBezaSDxbIBh_R4$gnmlvPQyC2H(num2))
				{
					bool flag3 = false;
					if (2 != 0)
					{
						flag2 = flag3;
					}
				}
				if (flag2)
				{
					Array.Clear(this.#=zBPb3KhA=, this.#=zt$cqECc=, num2 - this.#=zt$cqECc=);
				}
				this.#=zt$cqECc= = num2;
			}
			if (#=zBkMjrJ4= <= 8)
			{
				int num3 = #=zBkMjrJ4=;
				while (--num3 >= 0)
				{
					this.#=zBPb3KhA=[this.#=zBkMjrJ4= + num3] = #=zBPb3KhA=[#=zur7PLhI= + num3];
				}
			}
			else
			{
				Buffer.BlockCopy(#=zBPb3KhA=, #=zur7PLhI=, this.#=zBPb3KhA=, this.#=zBkMjrJ4=, #=zBkMjrJ4=);
			}
			this.#=zBkMjrJ4= = num2;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00022460 File Offset: 0x00020660
		public override void #=zTGdh360OcFaKnoc50jGoLRYH3vK_fQGnDg5xORrenekew6YyXAWaL5GiWxpkeQIH7txS$4M=(byte #=zBPb3KhA=)
		{
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (!this.#=zkzlpT_c=)
			{
				throw new Exception();
			}
			if (this.#=zBkMjrJ4= >= this.#=zt$cqECc=)
			{
				int num = this.#=zBkMjrJ4= + 1;
				int num2;
				if (3 != 0)
				{
					num2 = num;
				}
				bool flag = this.#=zBkMjrJ4= > this.#=zt$cqECc=;
				bool flag2;
				if (2 != 0)
				{
					flag2 = flag;
				}
				if (num2 >= this.#=zfbJ$RjA= && this.#=zDbtZv1ai1ZYW5lgOdCBezaSDxbIBh_R4$gnmlvPQyC2H(num2))
				{
					bool flag3 = false;
					if (true)
					{
						flag2 = flag3;
					}
				}
				if (flag2)
				{
					Array.Clear(this.#=zBPb3KhA=, this.#=zt$cqECc=, this.#=zBkMjrJ4= - this.#=zt$cqECc=);
				}
				this.#=zt$cqECc= = num2;
			}
			byte[] array = this.#=zBPb3KhA=;
			int num3 = this.#=zBkMjrJ4=;
			this.#=zBkMjrJ4= = num3 + 1;
			array[num3] = #=zBPb3KhA=;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00022520 File Offset: 0x00020720
		public void #=zQCrN_2$6fAlcN_n0ERRhMMARBobw(Stream #=zBPb3KhA=)
		{
			if (false)
			{
			}
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			if (7 == 0)
			{
			}
			if (#=zBPb3KhA= == null)
			{
				throw new ArgumentNullException();
			}
			if (8 == 0)
			{
			}
			#=zBPb3KhA=.Write(this.#=zBPb3KhA=, this.#=zur7PLhI=, this.#=zt$cqECc= - this.#=zur7PLhI=);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00022584 File Offset: 0x00020784
		internal int #=zYGZSp3KrCFoW8vZ4yCaScDAAu7WW()
		{
			if (!this.#=zWVcvLK0=)
			{
				throw new Exception();
			}
			int num = this.#=zBkMjrJ4= + 4;
			int num2;
			if (2 != 0)
			{
				num2 = num;
			}
			if (2 != 0)
			{
				this.#=zBkMjrJ4= = num;
			}
			int num3 = num2;
			int num4;
			if (-1 != 0)
			{
				num4 = num3;
			}
			if (num4 > this.#=zt$cqECc=)
			{
				this.#=zBkMjrJ4= = this.#=zt$cqECc=;
				throw new Exception();
			}
			return (int)this.#=zBPb3KhA=[num4 - 1] << 8 | (int)this.#=zBPb3KhA=[num4 - 3] << 16 | (int)this.#=zBPb3KhA=[num4 - 2] | (int)this.#=zBPb3KhA=[num4 - 4] << 24;
		}

		// Token: 0x0400026D RID: 621
		private byte[] #=zBPb3KhA=;

		// Token: 0x0400026E RID: 622
		private int #=zur7PLhI=;

		// Token: 0x0400026F RID: 623
		private int #=zBkMjrJ4=;

		// Token: 0x04000270 RID: 624
		private int #=zt$cqECc=;

		// Token: 0x04000271 RID: 625
		private int #=zfbJ$RjA=;

		// Token: 0x04000272 RID: 626
		private bool #=zAWZgy3A=;

		// Token: 0x04000273 RID: 627
		private bool #=zkzlpT_c=;

		// Token: 0x04000274 RID: 628
		private bool #=zWVcvLK0=;

		// Token: 0x04000275 RID: 629
		private bool #=zuANKhdE=;
	}
}
