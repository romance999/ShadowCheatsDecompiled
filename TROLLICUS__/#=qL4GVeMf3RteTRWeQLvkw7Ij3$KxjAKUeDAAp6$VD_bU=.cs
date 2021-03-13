using System;
using System.IO;
using System.Text;

namespace TROLLICUS__
{
	// Token: 0x0200004E RID: 78
	internal sealed class #=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU= : IDisposable
	{
		// Token: 0x06000192 RID: 402 RVA: 0x0000A5C4 File Offset: 0x000087C4
		public #=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU=(#=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI= #=zBPb3KhA=)
		{
			if (3 == 0)
			{
			}
			if (7 == 0)
			{
			}
			this..ctor(#=zBPb3KhA=, new UTF8Encoding());
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000A5F0 File Offset: 0x000087F0
		private #=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU=(#=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI= #=zBPb3KhA=, Encoding #=zur7PLhI=)
		{
			if (#=zBPb3KhA= == null)
			{
				throw new ArgumentNullException();
			}
			if (#=zur7PLhI= == null)
			{
				throw new ArgumentNullException();
			}
			if (!#=zBPb3KhA=.#=z1q9E0OZmu549QYDxFUzzcHU1qboDoRMEIH5jxmCfgrpSbNDB2DNneRzxj$ySIog4bV8oHnSRBnbz1Jn_zEL1Hqs=())
			{
				throw new ArgumentException();
			}
			if (3 != 0)
			{
				this.#=zBPb3KhA= = #=zBPb3KhA=;
			}
			Decoder decoder = #=zur7PLhI=.GetDecoder();
			if (2 != 0)
			{
				this.#=zBkMjrJ4= = decoder;
			}
			int maxCharCount = #=zur7PLhI=.GetMaxCharCount(128);
			if (7 != 0)
			{
				this.#=zkzlpT_c= = maxCharCount;
			}
			int num = #=zur7PLhI=.GetMaxByteCount(1);
			if (num < 16)
			{
				num = 16;
			}
			this.#=zur7PLhI= = new byte[num];
			this.#=zAWZgy3A= = null;
			this.#=zt$cqECc= = null;
			this.#=zWVcvLK0= = (#=zur7PLhI= is UnicodeEncoding);
			this.#=zuANKhdE= = (this.#=zBPb3KhA= is #=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE=);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000A6AC File Offset: 0x000088AC
		public #=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI= #=zqxeELJU2$Y40zCrEjrNyCyk=()
		{
			if (2 == 0)
			{
			}
			return this.#=zBPb3KhA=;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000A6CC File Offset: 0x000088CC
		public void #=zK37gApvWoxg87G8YC1J6UMou5RrakiVkd04uX7E=()
		{
			bool flag = true;
			if (6 != 0)
			{
				this.#=zAFO36WVKW_qZ_pV4Drrr_RYa8DHsKDDZH6$Tk18=(flag);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000A6EC File Offset: 0x000088EC
		private void #=zAFO36WVKW_qZ_pV4Drrr_RYa8DHsKDDZH6$Tk18=(bool #=zBPb3KhA=)
		{
			if (#=zBPb3KhA=)
			{
				#=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI= #=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI= = this.#=zBPb3KhA=;
				#=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI= #=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI=2;
				if (3 != 0)
				{
					#=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI=2 = #=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI=;
				}
				#=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI= #=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI=3 = null;
				if (2 != 0)
				{
					this.#=zBPb3KhA= = #=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI=3;
				}
				if (#=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI=2 != null)
				{
					#=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI=2.#=zMysjAtVaLLTr6mzPBtOKzArTBs63jiP92PK1tUICNZVZRRlQyq4LoDoPqowBO$F0UxHsm_vfuByaD0Mz8CmcCZ6ATw70();
				}
			}
			#=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI= #=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI=4 = null;
			if (true)
			{
				this.#=zBPb3KhA= = #=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI=4;
			}
			this.#=zur7PLhI= = null;
			this.#=zBkMjrJ4= = null;
			this.#=zt$cqECc= = null;
			this.#=zfbJ$RjA= = null;
			this.#=zAWZgy3A= = null;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000A758 File Offset: 0x00008958
		void IDisposable.#=zJOUSe3sk1Q8yXlCeHPyvS4t1harY6kQWlP3OpyXBF$FSLXoxoXia36WNzwe3EBku0Q==()
		{
			bool flag = true;
			if (5 != 0)
			{
				this.#=zAFO36WVKW_qZ_pV4Drrr_RYa8DHsKDDZH6$Tk18=(flag);
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000A778 File Offset: 0x00008978
		public int #=zNqlq3yAm1c02RHKz_kQ8PjxOPjav3Es6A7yXPQP5xNHQ()
		{
			if (2 != 0)
			{
				this.#=zQkL13bHzuXckYaQLLg7mDkw0dXyjD1HErw==();
			}
			if (!this.#=zBPb3KhA=.#=zHGvytZRZrtSu1RUt$Bj5JcDluvdfcNeb$NgkYNEkSLKqgETpDjy9ICdnhsz6B4tZSTro1y_Qx51r())
			{
				return -1;
			}
			long num = this.#=zBPb3KhA=.#=zMysjAtVaLLTr6mzPBtOKzArTBs63jiP92PK1tUICNZWQaJ6zSHl4DgBVtSzZ_D0NIxwSmPp8OLtZ();
			long num2;
			if (7 != 0)
			{
				num2 = num;
			}
			int result = this.#=zlLb7EsiBrJxm4Z3sjE$XmtXHfmjGTVA6vLtdfYo=();
			this.#=zBPb3KhA=.#=zUueHPMSSKBvx8SWMKllj9lrVJE2a_THQWKfzTg5ZZSNnCGlQ5Fu7zwZMfd7AQptTNBDcjkg=(num2);
			return result;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000A7C8 File Offset: 0x000089C8
		public int #=zlLb7EsiBrJxm4Z3sjE$XmtXHfmjGTVA6vLtdfYo=()
		{
			if (4 != 0)
			{
				this.#=zQkL13bHzuXckYaQLLg7mDkw0dXyjD1HErw==();
			}
			return this.#=zzBXarQ3hHemOYpFA9A==();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000A7EC File Offset: 0x000089EC
		public bool #=zsCTfNhcIXDBWypvOnaLhNnc=()
		{
			int num = 1;
			if (!false)
			{
				this.#=zt1U___DV5njCKeUb0zIXS4s=(num);
			}
			return this.#=zur7PLhI=[0] > 0;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000A814 File Offset: 0x00008A14
		public byte #=zgZ1nbOY3e_GPuTJGnvxGPds=()
		{
			if (8 != 0)
			{
				this.#=zQkL13bHzuXckYaQLLg7mDkw0dXyjD1HErw==();
			}
			int num = this.#=zBPb3KhA=.#=z41E7exaW2fAUSQRWmttMlF$ZquUmdyHZj2pAKewqdHL3CE564buz6bnN7h2RPf_1Pab2Oi4ag0SNrd8p_Q==();
			if (num == -1)
			{
				throw new Exception();
			}
			return (byte)num;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000A848 File Offset: 0x00008A48
		public sbyte #=zCtv3_AYluGRpZ3KcAXovGAkZKW6rHnNW9wscGnuk0Kha()
		{
			int num = 1;
			if (4 != 0)
			{
				this.#=zt1U___DV5njCKeUb0zIXS4s=(num);
			}
			return (sbyte)this.#=zur7PLhI=[0];
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000A870 File Offset: 0x00008A70
		public char #=zxKqfpYv3o9k$GqhDwA==()
		{
			if (4 == 0)
			{
			}
			int num = this.#=zlLb7EsiBrJxm4Z3sjE$XmtXHfmjGTVA6vLtdfYo=();
			if (num == -1)
			{
				throw new Exception();
			}
			return (char)num;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000A898 File Offset: 0x00008A98
		private static decimal #=zx8H23rS4Xc39WRQWaDdR08qJmYWt(int #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=, int #=zt$cqECc=)
		{
			bool flag = (#=zt$cqECc= & int.MinValue) != 0;
			bool isNegative;
			if (-1 != 0)
			{
				isNegative = flag;
			}
			byte b = (byte)(#=zt$cqECc= >> 16);
			byte scale;
			if (6 != 0)
			{
				scale = b;
			}
			return new decimal(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=, isNegative, scale);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000A8D0 File Offset: 0x00008AD0
		internal static decimal #=z7VSgo8hVAaKr9eu57Ly8vJjNS6sDNcHAeuRXUYD6Ym5w(byte[] #=zBPb3KhA=)
		{
			int num = (int)#=zBPb3KhA=[0] | (int)#=zBPb3KhA=[1] << 8 | (int)#=zBPb3KhA=[2] << 16 | (int)#=zBPb3KhA=[3] << 24;
			int num2 = (int)#=zBPb3KhA=[4] | (int)#=zBPb3KhA=[5] << 8 | (int)#=zBPb3KhA=[6] << 16 | (int)#=zBPb3KhA=[7] << 24;
			int num3;
			if (7 != 0)
			{
				num3 = num2;
			}
			int num4 = (int)#=zBPb3KhA=[8] | (int)#=zBPb3KhA=[9] << 8 | (int)#=zBPb3KhA=[10] << 16 | (int)#=zBPb3KhA=[11] << 24;
			int num5;
			if (3 != 0)
			{
				num5 = num4;
			}
			int num6 = (int)#=zBPb3KhA=[12] | (int)#=zBPb3KhA=[13] << 8 | (int)#=zBPb3KhA=[14] << 16 | (int)#=zBPb3KhA=[15] << 24;
			int num7;
			if (3 != 0)
			{
				num7 = num6;
			}
			return #=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU=.#=zx8H23rS4Xc39WRQWaDdR08qJmYWt(num, num3, num5, num7);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000A960 File Offset: 0x00008B60
		public string #=z_DqBlW2yCsosxCbCpg==()
		{
			int num = 0;
			int num2;
			if (6 != 0)
			{
				num2 = num;
			}
			if (true)
			{
				this.#=zQkL13bHzuXckYaQLLg7mDkw0dXyjD1HErw==();
			}
			int num3 = this.#=zxS10dBM2In1IkBwgO9j6iCE=();
			int num4;
			if (true)
			{
				num4 = num3;
			}
			if (num4 < 0)
			{
				throw new IOException();
			}
			if (num4 == 0)
			{
				return string.Empty;
			}
			if (this.#=zt$cqECc= == null)
			{
				this.#=zt$cqECc= = new byte[128];
			}
			if (this.#=zAWZgy3A= == null)
			{
				this.#=zAWZgy3A= = new char[this.#=zkzlpT_c=];
			}
			StringBuilder stringBuilder = null;
			int chars;
			for (;;)
			{
				int num5 = (num4 - num2 > 128) ? 128 : (num4 - num2);
				int num6 = this.#=zBPb3KhA=.#=zJEMk1xYVLJ233KFf6ByNB0yl4jE1Z0jS$gMDXnRJeziYez6tri3oA4WgUQRAy6D1RvfuPJ4=(this.#=zt$cqECc=, 0, num5);
				if (num6 == 0)
				{
					break;
				}
				chars = this.#=zBkMjrJ4=.GetChars(this.#=zt$cqECc=, 0, num6, this.#=zAWZgy3A=, 0);
				if (num2 == 0 && num6 == num4)
				{
					goto Block_8;
				}
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(num4);
				}
				stringBuilder.Append(this.#=zAWZgy3A=, 0, chars);
				num2 += num6;
				if (num2 >= num4)
				{
					goto Block_10;
				}
			}
			throw new Exception();
			Block_8:
			return new string(this.#=zAWZgy3A=, 0, chars);
			Block_10:
			return stringBuilder.ToString();
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000AA68 File Offset: 0x00008C68
		public int #=zr7VzyYA0dY1pgJToCALtIYzewDOWiHRLSA==(char[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			if (#=zBPb3KhA= == null)
			{
				throw new ArgumentNullException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705028), #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705523));
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
			if (!false)
			{
				this.#=zQkL13bHzuXckYaQLLg7mDkw0dXyjD1HErw==();
			}
			return this.#=z3lcuu2DQourcGuH6UMmnCZKItWLV(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000AACC File Offset: 0x00008CCC
		private int #=z3lcuu2DQourcGuH6UMmnCZKItWLV(char[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			if (-1 == 0)
			{
			}
			if (false)
			{
			}
			int i;
			if (true)
			{
				i = #=zBkMjrJ4=;
			}
			if (this.#=zt$cqECc= == null)
			{
				this.#=zt$cqECc= = new byte[128];
			}
			while (i > 0)
			{
				int num = i;
				if (this.#=zWVcvLK0=)
				{
					num <<= 1;
				}
				if (num > 128)
				{
					num = 128;
				}
				int chars;
				if (this.#=zuANKhdE=)
				{
					#=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE= #=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE= = (#=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE=)this.#=zBPb3KhA=;
					int byteIndex = #=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE=.#=zb6EWjx$9sAGvWR$A5uKb6vo=();
					num = #=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE=.#=zMKzS24bj6GDxHwYQlIvc4$1zhSopyMBFmw==(num);
					if (num == 0)
					{
						return #=zBkMjrJ4= - i;
					}
					chars = this.#=zBkMjrJ4=.GetChars(#=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE=.#=zX_C$p37tQan8nN8XaTedl8o=(), byteIndex, num, #=zBPb3KhA=, #=zur7PLhI=);
				}
				else
				{
					num = this.#=zBPb3KhA=.#=zJEMk1xYVLJ233KFf6ByNB0yl4jE1Z0jS$gMDXnRJeziYez6tri3oA4WgUQRAy6D1RvfuPJ4=(this.#=zt$cqECc=, 0, num);
					if (num == 0)
					{
						return #=zBkMjrJ4= - i;
					}
					chars = this.#=zBkMjrJ4=.GetChars(this.#=zt$cqECc=, 0, num, #=zBPb3KhA=, #=zur7PLhI=);
				}
				i -= chars;
				#=zur7PLhI= += chars;
			}
			return #=zBkMjrJ4=;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000ABB8 File Offset: 0x00008DB8
		private int #=zzBXarQ3hHemOYpFA9A==()
		{
			int num = 0;
			int num2;
			if (true)
			{
				num2 = num;
			}
			if (2 == 0)
			{
			}
			long num3 = 0L;
			long num4;
			if (!false)
			{
				num4 = num3;
			}
			num4 = num3;
			if (this.#=zBPb3KhA=.#=zHGvytZRZrtSu1RUt$Bj5JcDluvdfcNeb$NgkYNEkSLKqgETpDjy9ICdnhsz6B4tZSTro1y_Qx51r())
			{
				num4 = this.#=zBPb3KhA=.#=zMysjAtVaLLTr6mzPBtOKzArTBs63jiP92PK1tUICNZWQaJ6zSHl4DgBVtSzZ_D0NIxwSmPp8OLtZ();
			}
			if (this.#=zt$cqECc= == null)
			{
				this.#=zt$cqECc= = new byte[128];
			}
			if (this.#=zfbJ$RjA= == null)
			{
				this.#=zfbJ$RjA= = new char[1];
			}
			while (num2 == 0)
			{
				int num5 = this.#=zWVcvLK0= ? 2 : 1;
				int num6 = this.#=zBPb3KhA=.#=z41E7exaW2fAUSQRWmttMlF$ZquUmdyHZj2pAKewqdHL3CE564buz6bnN7h2RPf_1Pab2Oi4ag0SNrd8p_Q==();
				this.#=zt$cqECc=[0] = (byte)num6;
				if (num6 == -1)
				{
					num5 = 0;
				}
				if (num5 == 2)
				{
					num6 = this.#=zBPb3KhA=.#=z41E7exaW2fAUSQRWmttMlF$ZquUmdyHZj2pAKewqdHL3CE564buz6bnN7h2RPf_1Pab2Oi4ag0SNrd8p_Q==();
					this.#=zt$cqECc=[1] = (byte)num6;
					if (num6 == -1)
					{
						num5 = 1;
					}
				}
				if (num5 == 0)
				{
					return -1;
				}
				try
				{
					num2 = this.#=zBkMjrJ4=.GetChars(this.#=zt$cqECc=, 0, num5, this.#=zfbJ$RjA=, 0);
				}
				catch
				{
					if (this.#=zBPb3KhA=.#=zHGvytZRZrtSu1RUt$Bj5JcDluvdfcNeb$NgkYNEkSLKqgETpDjy9ICdnhsz6B4tZSTro1y_Qx51r())
					{
						this.#=zBPb3KhA=.#=z0u9rel2nIXWusRou8IFJnV65OvYa1a6x77R6rmAGswFsYxLRzL_TKbk$kEOLgQchTL1UzLApALirxYXNco1UbqLod0le(num4 - this.#=zBPb3KhA=.#=zMysjAtVaLLTr6mzPBtOKzArTBs63jiP92PK1tUICNZWQaJ6zSHl4DgBVtSzZ_D0NIxwSmPp8OLtZ(), 1);
					}
					throw;
				}
			}
			if (num2 == 0)
			{
				return -1;
			}
			return (int)this.#=zfbJ$RjA=[0];
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000ACE8 File Offset: 0x00008EE8
		public char[] #=zkdlFFfa5ETpPLsqypxFT0EMZHEo62wqs5FyFDwc=(int #=zBPb3KhA=)
		{
			if (3 != 0)
			{
				this.#=zQkL13bHzuXckYaQLLg7mDkw0dXyjD1HErw==();
			}
			if (#=zBPb3KhA= < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			char[] array = new char[#=zBPb3KhA=];
			char[] array2;
			if (5 != 0)
			{
				array2 = array;
			}
			int num = this.#=z3lcuu2DQourcGuH6UMmnCZKItWLV(array2, 0, #=zBPb3KhA=);
			int num2;
			if (5 != 0)
			{
				num2 = num;
			}
			if (num2 != #=zBPb3KhA=)
			{
				char[] array3 = new char[num2];
				Buffer.BlockCopy(array2, 0, array3, 0, 2 * num2);
				array2 = array3;
			}
			return array2;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000AD48 File Offset: 0x00008F48
		public int #=zlNslr6fZ04I0f0crGNNrlpk=(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
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
			if (!false)
			{
				this.#=zQkL13bHzuXckYaQLLg7mDkw0dXyjD1HErw==();
			}
			return this.#=zBPb3KhA=.#=zJEMk1xYVLJ233KFf6ByNB0yl4jE1Z0jS$gMDXnRJeziYez6tri3oA4WgUQRAy6D1RvfuPJ4=(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000AD9C File Offset: 0x00008F9C
		private void #=zQkL13bHzuXckYaQLLg7mDkw0dXyjD1HErw==()
		{
			if (8 == 0)
			{
			}
			if (this.#=zBPb3KhA= == null)
			{
				throw new Exception();
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000ADC4 File Offset: 0x00008FC4
		public byte[] #=zGdPgVZYAMiflyX4$ww==(int #=zBPb3KhA=)
		{
			if (#=zBPb3KhA= < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (4 != 0)
			{
				this.#=zQkL13bHzuXckYaQLLg7mDkw0dXyjD1HErw==();
			}
			byte[] array = new byte[#=zBPb3KhA=];
			byte[] array2;
			if (!false)
			{
				array2 = array;
			}
			int num = 0;
			int num2;
			if (!false)
			{
				num2 = num;
			}
			do
			{
				int num3 = this.#=zBPb3KhA=.#=zJEMk1xYVLJ233KFf6ByNB0yl4jE1Z0jS$gMDXnRJeziYez6tri3oA4WgUQRAy6D1RvfuPJ4=(array2, num2, #=zBPb3KhA=);
				if (num3 == 0)
				{
					break;
				}
				num2 += num3;
				#=zBPb3KhA= -= num3;
			}
			while (#=zBPb3KhA= > 0);
			if (num2 != array2.Length)
			{
				byte[] array3 = new byte[num2];
				Buffer.BlockCopy(array2, 0, array3, 0, num2);
				array2 = array3;
			}
			return array2;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000AE3C File Offset: 0x0000903C
		private void #=zt1U___DV5njCKeUb0zIXS4s=(int #=zBPb3KhA=)
		{
			if (!false)
			{
				this.#=zQkL13bHzuXckYaQLLg7mDkw0dXyjD1HErw==();
			}
			int num = 0;
			int num2;
			if (5 != 0)
			{
				num2 = num;
			}
			if (false)
			{
			}
			int num3;
			if (#=zBPb3KhA= != 1)
			{
				for (;;)
				{
					num3 = this.#=zBPb3KhA=.#=zJEMk1xYVLJ233KFf6ByNB0yl4jE1Z0jS$gMDXnRJeziYez6tri3oA4WgUQRAy6D1RvfuPJ4=(this.#=zur7PLhI=, num2, #=zBPb3KhA= - num2);
					if (num3 == 0)
					{
						break;
					}
					num2 += num3;
					if (num2 >= #=zBPb3KhA=)
					{
						return;
					}
				}
				throw new Exception();
			}
			num3 = this.#=zBPb3KhA=.#=z41E7exaW2fAUSQRWmttMlF$ZquUmdyHZj2pAKewqdHL3CE564buz6bnN7h2RPf_1Pab2Oi4ag0SNrd8p_Q==();
			if (num3 == -1)
			{
				throw new Exception();
			}
			this.#=zur7PLhI=[0] = (byte)num3;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000AEB4 File Offset: 0x000090B4
		internal int #=zxS10dBM2In1IkBwgO9j6iCE=()
		{
			int num = 0;
			int num2;
			if (8 != 0)
			{
				num2 = num;
			}
			int num3 = 0;
			int num4;
			if (-1 != 0)
			{
				num4 = num3;
			}
			while (num4 != 35)
			{
				byte b = this.#=zgZ1nbOY3e_GPuTJGnvxGPds=();
				byte b2;
				if (true)
				{
					b2 = b;
				}
				num2 |= (int)(b2 & 127) << num4;
				num4 += 7;
				if ((b2 & 128) == 0)
				{
					return num2;
				}
			}
			throw new FormatException();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000AF08 File Offset: 0x00009108
		public int #=z32YI2hcbZtgFvF3JDfQk6fjfXYx5()
		{
			if (this.#=zuANKhdE=)
			{
				return ((#=qy19ntCTjkEw0Q6h2Gs$NpE2UiVNGTEflZCHpRlOSvgE=)this.#=zBPb3KhA=).#=zYGZSp3KrCFoW8vZ4yCaScDAAu7WW();
			}
			int num = 4;
			if (2 != 0)
			{
				this.#=zt1U___DV5njCKeUb0zIXS4s=(num);
			}
			return (int)this.#=zur7PLhI=[0] << 24 | (int)this.#=zur7PLhI=[2] | (int)this.#=zur7PLhI=[3] << 8 | (int)this.#=zur7PLhI=[1] << 16;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000AF6C File Offset: 0x0000916C
		public uint #=zA4kPkCtNvc4Y2KKDzNh9BXI=()
		{
			int num = 4;
			if (7 != 0)
			{
				this.#=zt1U___DV5njCKeUb0zIXS4s=(num);
			}
			return (uint)((int)this.#=zur7PLhI=[3] << 16 | (int)this.#=zur7PLhI=[2] << 8 | (int)this.#=zur7PLhI=[0] << 24 | (int)this.#=zur7PLhI=[1]);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000AFB4 File Offset: 0x000091B4
		public long #=zVPbZF14TAjzjv$UhyTJYZl8=()
		{
			int num = 8;
			if (4 != 0)
			{
				this.#=zt1U___DV5njCKeUb0zIXS4s=(num);
			}
			byte[] array = this.#=zur7PLhI=;
			byte[] array2;
			if (6 != 0)
			{
				array2 = array;
			}
			return (long)((ulong)((int)array2[6] << 24 | (int)array2[5] << 16 | (int)array2[0] << 8 | (int)array2[4]) | (ulong)((ulong)((long)((int)array2[1] << 8 | (int)array2[3] << 16 | (int)array2[2] << 24 | (int)array2[7])) << 32));
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000B014 File Offset: 0x00009214
		public ulong #=z19U0qlbyFQHD_Ys$TDh8KKoDrvPQVKLw0A==()
		{
			int num = 8;
			if (3 != 0)
			{
				this.#=zt1U___DV5njCKeUb0zIXS4s=(num);
			}
			byte[] array = this.#=zur7PLhI=;
			byte[] array2;
			if (8 != 0)
			{
				array2 = array;
			}
			return (ulong)((int)array2[5] << 8 | (int)array2[4] << 16 | (int)array2[0] << 24 | (int)array2[3]) | (ulong)((ulong)((long)((int)array2[6] << 16 | (int)array2[1] | (int)array2[7] << 8 | (int)array2[2] << 24)) << 32);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000B074 File Offset: 0x00009274
		public short #=zayLdRzOkluS0ye6BARKkHoD$xWTGFiZmGKTQZgvgrHvL()
		{
			int num = 2;
			if (true)
			{
				this.#=zt1U___DV5njCKeUb0zIXS4s=(num);
			}
			byte[] array = this.#=zur7PLhI=;
			byte[] array2;
			if (true)
			{
				array2 = array;
			}
			return (short)((int)array2[0] | (int)array2[1] << 8);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000B0A8 File Offset: 0x000092A8
		public ushort #=zoppRXeUD4A5pSGtmrp9PTlMuphIS()
		{
			int num = 2;
			if (7 != 0)
			{
				this.#=zt1U___DV5njCKeUb0zIXS4s=(num);
			}
			byte[] array = this.#=zur7PLhI=;
			byte[] array2;
			if (8 != 0)
			{
				array2 = array;
			}
			return (ushort)((int)array2[1] << 8 | (int)array2[0]);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000B0DC File Offset: 0x000092DC
		private byte[] #=zmeGFLWjVgpXgFr4_Yqorm09xkoB8xWHvbQ==()
		{
			byte[] array = this.#=zV_dyzaM=;
			byte[] array2;
			if (!false)
			{
				array2 = array;
			}
			if (array2 == null)
			{
				byte[] array3 = new byte[16];
				if (true)
				{
					array2 = array3;
				}
				if (4 != 0)
				{
					this.#=zV_dyzaM= = array3;
				}
			}
			return array2;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000B11C File Offset: 0x0000931C
		public float #=zzpcdgP1Qh$Z2S68dqxr6rMCk2j2W2jSyPNZ0$lY=()
		{
			int num = 4;
			if (true)
			{
				this.#=zt1U___DV5njCKeUb0zIXS4s=(num);
			}
			byte[] array = this.#=zur7PLhI=;
			byte[] array2;
			if (2 != 0)
			{
				array2 = array;
			}
			byte[] array3 = this.#=zmeGFLWjVgpXgFr4_Yqorm09xkoB8xWHvbQ==();
			byte[] array4;
			if (6 != 0)
			{
				array4 = array3;
			}
			array4[3] = array2[3];
			array4[1] = array2[2];
			array4[0] = array2[0];
			array4[2] = array2[1];
			return this.#=zzz8Uag6uxUWgtN$VsgOpIfGYBAg5RZdG8M44ENIB4FIA(array4).ReadSingle();
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000B178 File Offset: 0x00009378
		public double #=zKnBdFPBXM7EIEMKflUx8xvU=()
		{
			int num = 8;
			if (3 != 0)
			{
				this.#=zt1U___DV5njCKeUb0zIXS4s=(num);
			}
			byte[] array = this.#=zur7PLhI=;
			byte[] array2;
			if (true)
			{
				array2 = array;
			}
			byte[] array3 = this.#=zmeGFLWjVgpXgFr4_Yqorm09xkoB8xWHvbQ==();
			byte[] array4;
			if (2 != 0)
			{
				array4 = array3;
			}
			array4[5] = array2[1];
			array4[6] = array2[7];
			array4[7] = array2[3];
			array4[0] = array2[2];
			array4[1] = array2[0];
			array4[3] = array2[5];
			array4[2] = array2[6];
			array4[4] = array2[4];
			return this.#=zzz8Uag6uxUWgtN$VsgOpIfGYBAg5RZdG8M44ENIB4FIA(array4).ReadDouble();
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000B1EC File Offset: 0x000093EC
		public decimal #=z20oe30X$CN56fkWyUJcP_aVtNYa1golhikHU8ps=()
		{
			int num = 16;
			if (7 != 0)
			{
				this.#=zt1U___DV5njCKeUb0zIXS4s=(num);
			}
			byte[] array = this.#=zur7PLhI=;
			byte[] array2;
			if (!false)
			{
				array2 = array;
			}
			byte[] array3 = this.#=zmeGFLWjVgpXgFr4_Yqorm09xkoB8xWHvbQ==();
			array3[10] = array2[11];
			array3[12] = array2[2];
			array3[3] = array2[12];
			array3[13] = array2[14];
			array3[14] = array2[3];
			array3[9] = array2[4];
			array3[11] = array2[10];
			array3[5] = array2[9];
			array3[1] = array2[0];
			array3[6] = array2[7];
			array3[7] = array2[8];
			array3[4] = array2[13];
			array3[0] = array2[5];
			array3[2] = array2[1];
			array3[8] = array2[6];
			array3[15] = array2[15];
			return #=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU=.#=z7VSgo8hVAaKr9eu57Ly8vJjNS6sDNcHAeuRXUYD6Ym5w(array3);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000B29C File Offset: 0x0000949C
		private BinaryReader #=zzz8Uag6uxUWgtN$VsgOpIfGYBAg5RZdG8M44ENIB4FIA(byte[] #=zBPb3KhA=)
		{
			MemoryStream memoryStream = this.#=zkC0PuRE=;
			MemoryStream memoryStream2;
			if (!false)
			{
				memoryStream2 = memoryStream;
			}
			BinaryReader binaryReader = this.#=zx_mghN4=;
			BinaryReader binaryReader2;
			if (8 != 0)
			{
				binaryReader2 = binaryReader;
			}
			if (memoryStream2 == null)
			{
				MemoryStream memoryStream3 = new MemoryStream(8);
				if (!false)
				{
					memoryStream2 = memoryStream3;
				}
				this.#=zkC0PuRE= = memoryStream3;
				binaryReader2 = (this.#=zx_mghN4= = new BinaryReader(memoryStream2));
			}
			else
			{
				binaryReader2.BaseStream.Position = 0L;
			}
			memoryStream2.Write(#=zBPb3KhA=, 0, #=zBPb3KhA=.Length);
			memoryStream2.Position = 0L;
			return binaryReader2;
		}

		// Token: 0x040000BD RID: 189
		private #=qPVSW$660RLVa3Ie1H1BYQZ1ucSE8sl1zlTyXv8G0vSI= #=zBPb3KhA=;

		// Token: 0x040000BE RID: 190
		private byte[] #=zur7PLhI=;

		// Token: 0x040000BF RID: 191
		private Decoder #=zBkMjrJ4=;

		// Token: 0x040000C0 RID: 192
		private byte[] #=zt$cqECc=;

		// Token: 0x040000C1 RID: 193
		private char[] #=zfbJ$RjA=;

		// Token: 0x040000C2 RID: 194
		private char[] #=zAWZgy3A=;

		// Token: 0x040000C3 RID: 195
		private int #=zkzlpT_c=;

		// Token: 0x040000C4 RID: 196
		private bool #=zWVcvLK0=;

		// Token: 0x040000C5 RID: 197
		private bool #=zuANKhdE=;

		// Token: 0x040000C6 RID: 198
		private byte[] #=zV_dyzaM=;

		// Token: 0x040000C7 RID: 199
		private MemoryStream #=zkC0PuRE=;

		// Token: 0x040000C8 RID: 200
		private BinaryReader #=zx_mghN4=;
	}
}
