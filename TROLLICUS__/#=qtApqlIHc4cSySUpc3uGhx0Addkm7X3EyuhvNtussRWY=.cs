using System;
using System.Security.Cryptography;

namespace TROLLICUS__
{
	// Token: 0x020000AC RID: 172
	internal sealed class #=qtApqlIHc4cSySUpc3uGhx0Addkm7X3EyuhvNtussRWY= : DeriveBytes
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x0001FC74 File Offset: 0x0001DE74
		public #=qtApqlIHc4cSySUpc3uGhx0Addkm7X3EyuhvNtussRWY=(byte[] #=zBPb3KhA=, byte[] #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			if (-1 != 0)
			{
				this.#=zBkMjrJ4= = #=zBPb3KhA=;
			}
			if (2 != 0)
			{
				this.#=zt$cqECc= = #=zur7PLhI=;
			}
			if (6 != 0)
			{
				this.#=zfbJ$RjA= = #=zBkMjrJ4=;
			}
			if (!#=qtApqlIHc4cSySUpc3uGhx0Addkm7X3EyuhvNtussRWY=.#=zBPb3KhA=)
			{
				try
				{
					this.#=zur7PLhI= = new Rfc2898DeriveBytes(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
				}
				catch
				{
					#=qtApqlIHc4cSySUpc3uGhx0Addkm7X3EyuhvNtussRWY=.#=zBPb3KhA= = true;
				}
			}
			if (this.#=zur7PLhI= == null)
			{
				this.#=zur7PLhI= = new #=q71Pn7elr3BqHX_MHhOkfKO_5JtqyiAn7EoLP2qcNqFQ=(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0001FD00 File Offset: 0x0001DF00
		public override byte[] GetBytes(int #=zBPb3KhA=)
		{
			byte[] array = null;
			byte[] array2;
			if (7 != 0)
			{
				array2 = array;
			}
			if (!#=qtApqlIHc4cSySUpc3uGhx0Addkm7X3EyuhvNtussRWY=.#=zBPb3KhA=)
			{
				try
				{
					byte[] bytes = this.#=zur7PLhI=.GetBytes(#=zBPb3KhA=);
					if (2 != 0)
					{
						array2 = bytes;
					}
				}
				catch
				{
					#=qtApqlIHc4cSySUpc3uGhx0Addkm7X3EyuhvNtussRWY=.#=zBPb3KhA= = true;
				}
			}
			if (array2 == null)
			{
				DeriveBytes deriveBytes = new #=q71Pn7elr3BqHX_MHhOkfKO_5JtqyiAn7EoLP2qcNqFQ=(this.#=zBkMjrJ4=, this.#=zt$cqECc=, this.#=zfbJ$RjA=);
				if (2 != 0)
				{
					this.#=zur7PLhI= = deriveBytes;
				}
				array2 = this.#=zur7PLhI=.GetBytes(#=zBPb3KhA=);
			}
			return array2;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0000232E File Offset: 0x0000052E
		public override void Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400017A RID: 378
		private static bool #=zBPb3KhA=;

		// Token: 0x0400017B RID: 379
		private DeriveBytes #=zur7PLhI=;

		// Token: 0x0400017C RID: 380
		private readonly byte[] #=zBkMjrJ4=;

		// Token: 0x0400017D RID: 381
		private readonly byte[] #=zt$cqECc=;

		// Token: 0x0400017E RID: 382
		private readonly int #=zfbJ$RjA=;
	}
}
