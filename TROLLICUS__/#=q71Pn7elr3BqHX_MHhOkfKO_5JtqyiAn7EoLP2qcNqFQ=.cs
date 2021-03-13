using System;
using System.Security.Cryptography;

namespace TROLLICUS__
{
	// Token: 0x02000016 RID: 22
	internal sealed class #=q71Pn7elr3BqHX_MHhOkfKO_5JtqyiAn7EoLP2qcNqFQ= : DeriveBytes
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00005328 File Offset: 0x00003528
		public #=q71Pn7elr3BqHX_MHhOkfKO_5JtqyiAn7EoLP2qcNqFQ=(byte[] #=zBPb3KhA=, byte[] #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			#=quyzfQfqO1ZReiWBgO1KUEPkqO56yiO0$hab8_hs0yxM= #=quyzfQfqO1ZReiWBgO1KUEPkqO56yiO0$hab8_hs0yxM= = new #=quyzfQfqO1ZReiWBgO1KUEPkqO56yiO0$hab8_hs0yxM=();
			if (6 != 0)
			{
				this.#=zt$cqECc= = #=quyzfQfqO1ZReiWBgO1KUEPkqO56yiO0$hab8_hs0yxM=;
			}
			base..ctor();
			if (#=zBPb3KhA= == null)
			{
				throw new ArgumentNullException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705130));
			}
			if (#=zur7PLhI= == null)
			{
				throw new ArgumentNullException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705105));
			}
			if (#=zBkMjrJ4= < 1)
			{
				throw new ArgumentException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705116));
			}
			byte[] array = (byte[])#=zBPb3KhA=.Clone();
			if (5 != 0)
			{
				this.#=zBPb3KhA= = array;
			}
			byte[] array2 = (byte[])#=zur7PLhI=.Clone();
			if (5 != 0)
			{
				this.#=zur7PLhI= = array2;
			}
			this.#=zBkMjrJ4= = #=zBkMjrJ4=;
			this.#=zfbJ$RjA= = new byte[this.#=zt$cqECc=.#=znxfeBA_d43IRYQNCubRxcM6dmZcRTuW95k4ocQI=()];
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000053D8 File Offset: 0x000035D8
		private void #=z8Tbkx78w9qPGX$FyxbDtiJVaYHZkFAytdGhmK$U=(byte[] #=zBPb3KhA=, int #=zur7PLhI=, byte[] #=zBkMjrJ4=, byte[] #=zt$cqECc=, int #=zfbJ$RjA=)
		{
			if (#=zBPb3KhA= != null)
			{
				this.#=zt$cqECc=.#=z56uaxst1$oJCCAVTxXP_CkwIjO$t(#=zBPb3KhA=, 0, #=zBPb3KhA=.Length);
			}
			this.#=zt$cqECc=.#=z56uaxst1$oJCCAVTxXP_CkwIjO$t(#=zBkMjrJ4=, 0, #=zBkMjrJ4=.Length);
			this.#=zt$cqECc=.#=z0njR92384Qs36_0JN2Ut36MpFa6V(this.#=zfbJ$RjA=, 0);
			Array src = this.#=zfbJ$RjA=;
			int srcOffset = 0;
			int count = this.#=zfbJ$RjA=.Length;
			if (8 != 0)
			{
				Buffer.BlockCopy(src, srcOffset, #=zt$cqECc=, #=zfbJ$RjA=, count);
			}
			int num = 1;
			int i;
			if (!false)
			{
				i = num;
			}
			while (i < #=zur7PLhI=)
			{
				this.#=zt$cqECc=.#=z56uaxst1$oJCCAVTxXP_CkwIjO$t(this.#=zfbJ$RjA=, 0, this.#=zfbJ$RjA=.Length);
				this.#=zt$cqECc=.#=z0njR92384Qs36_0JN2Ut36MpFa6V(this.#=zfbJ$RjA=, 0);
				int num2 = 0;
				int j;
				if (4 != 0)
				{
					j = num2;
				}
				while (j < this.#=zfbJ$RjA=.Length)
				{
					int num3 = #=zfbJ$RjA= + j;
					#=zt$cqECc=[num3] ^= this.#=zfbJ$RjA=[j];
					j++;
				}
				i++;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000054B0 File Offset: 0x000036B0
		public override byte[] GetBytes(int #=zBPb3KhA=)
		{
			int num = this.#=zt$cqECc=.#=znxfeBA_d43IRYQNCubRxcM6dmZcRTuW95k4ocQI=();
			int num2;
			if (-1 != 0)
			{
				num2 = num;
			}
			int num3 = (#=zBPb3KhA= + num2 - 1) / num2;
			int num4;
			if (!false)
			{
				num4 = num3;
			}
			byte[] array = new byte[4];
			byte[] array2;
			if (true)
			{
				array2 = array;
			}
			byte[] array3 = new byte[num4 * num2];
			int num5 = 0;
			this.#=zt$cqECc=.#=zRtL0pUvkKM6gQSy58O_JpjmJkj4m(this.#=zBPb3KhA=);
			for (int i = 1; i <= num4; i++)
			{
				int num6 = 3;
				for (;;)
				{
					byte[] array4 = array2;
					int num7 = num6;
					byte b = array4[num7] + 1;
					array4[num7] = b;
					if (b != 0)
					{
						break;
					}
					num6--;
				}
				this.#=z8Tbkx78w9qPGX$FyxbDtiJVaYHZkFAytdGhmK$U=(this.#=zur7PLhI=, this.#=zBkMjrJ4=, array2, array3, num5);
				num5 += num2;
			}
			if (#=zBPb3KhA= < array3.Length)
			{
				byte[] array5 = new byte[#=zBPb3KhA=];
				Buffer.BlockCopy(array3, 0, array5, 0, #=zBPb3KhA=);
				array3 = array5;
			}
			return array3;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000232E File Offset: 0x0000052E
		public override void Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400003C RID: 60
		private byte[] #=zBPb3KhA=;

		// Token: 0x0400003D RID: 61
		private byte[] #=zur7PLhI=;

		// Token: 0x0400003E RID: 62
		private int #=zBkMjrJ4=;

		// Token: 0x0400003F RID: 63
		private readonly #=quyzfQfqO1ZReiWBgO1KUEPkqO56yiO0$hab8_hs0yxM= #=zt$cqECc=;

		// Token: 0x04000040 RID: 64
		private readonly byte[] #=zfbJ$RjA=;
	}
}
