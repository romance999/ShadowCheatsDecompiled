using System;
using System.IO;

namespace TROLLICUS__
{
	// Token: 0x020000A9 RID: 169
	internal sealed class #=qqwPkgIMD534pZvFiLDWzkNTqsz42I5ROj6gkNNHVHhw= : Stream
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x0001F2EC File Offset: 0x0001D4EC
		public #=qqwPkgIMD534pZvFiLDWzkNTqsz42I5ROj6gkNNHVHhw=(Stream #=zBPb3KhA=, #=q3YmA9J4Ih4mJgGYtKkbFOzVFAoN8UpdtQeVB7j2rDho= #=zur7PLhI=)
		{
			if (#=zBPb3KhA= == null)
			{
				throw new ArgumentNullException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705502));
			}
			if (#=zur7PLhI= == null)
			{
				throw new ArgumentNullException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976708739));
			}
			if (7 != 0)
			{
				this.#=zt$cqECc= = #=zBPb3KhA=;
			}
			if (4 != 0)
			{
				this.#=zfbJ$RjA= = #=zur7PLhI=;
			}
			if (this.#=zt$cqECc=.Length < 4L)
			{
				throw new InvalidOperationException();
			}
			if (!false)
			{
				this.#=zn$panx7FLbHwgsmNw7LdUqrdiGqpT2Da4GZX9gc=();
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0001F368 File Offset: 0x0001D568
		private void #=zn$panx7FLbHwgsmNw7LdUqrdiGqpT2Da4GZX9gc=()
		{
			int num = this.#=zfbJ$RjA=.#=zsznnbCAMZsOWha33wzwbWyL84A4TQ7FYR7kc$qaHxDI98YBUngtaHHFTGsRApSiz$g==();
			if (2 != 0)
			{
				this.#=zkC0PuRE= = num;
			}
			byte[] array = new byte[this.#=zkC0PuRE=];
			if (2 != 0)
			{
				this.#=zV_dyzaM= = array;
			}
			int num2 = this.#=zfbJ$RjA=.#=znUvi35onmMzvLI$h5K$guDIISR9Bvl6jQXpKaycb_eNlQbRJycd7xLc7oF8jmW7q8POVtLDCbb8d3Yzv3PPdmOI=();
			if (3 != 0)
			{
				this.#=zI9SDSjk= = num2;
			}
			this.#=zx_mghN4= = new byte[this.#=zI9SDSjk=];
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x000023B2 File Offset: 0x000005B2
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x000023B2 File Offset: 0x000005B2
		public override bool CanSeek
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00002440 File Offset: 0x00000640
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0001F3D0 File Offset: 0x0001D5D0
		public override long Length
		{
			get
			{
				if (-1 != 0)
				{
					this.#=zTG51LMi2MAJghKMUirSor5w=();
				}
				return (long)this.#=zBPb3KhA=;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0001F3F4 File Offset: 0x0001D5F4
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x0001F430 File Offset: 0x0001D630
		public override long Position
		{
			get
			{
				if (4 == 0)
				{
				}
				int num = this.#=zAWZgy3A=;
				if (4 == 0)
				{
				}
				int num2 = num * this.#=zI9SDSjk=;
				if (false)
				{
				}
				return (long)(num2 + this.#=zalgQLww=);
			}
			set
			{
				int num = (int)value / this.#=zI9SDSjk=;
				int num2;
				if (2 != 0)
				{
					num2 = num;
				}
				int num3 = (int)value % this.#=zI9SDSjk=;
				if (-1 != 0)
				{
					this.#=zalgQLww= = num3;
				}
				if (this.#=zAWZgy3A= != num2)
				{
					int num4 = num2;
					if (true)
					{
						this.#=zAWZgy3A= = num4;
					}
					this.#=zuANKhdE= = true;
					this.#=zkzlpT_c= = false;
				}
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0001F48C File Offset: 0x0001D68C
		public override long Seek(long #=zBPb3KhA=, SeekOrigin #=zur7PLhI=)
		{
			if (-1 == 0)
			{
			}
			switch (#=zur7PLhI=)
			{
			case SeekOrigin.Begin:
				if (8 == 0)
				{
				}
				if (-1 == 0)
				{
				}
				this.Position = #=zBPb3KhA=;
				break;
			case SeekOrigin.Current:
				this.Position += #=zBPb3KhA=;
				break;
			case SeekOrigin.End:
				this.Position = this.Length + #=zBPb3KhA=;
				break;
			}
			return this.Position;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0000232E File Offset: 0x0000052E
		public override void SetLength(long #=zBPb3KhA=)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001F4F4 File Offset: 0x0001D6F4
		public override int Read(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			if (#=zur7PLhI= < 0)
			{
				throw new ArgumentOutOfRangeException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976708723));
			}
			if (#=zBkMjrJ4= < 0)
			{
				throw new ArgumentOutOfRangeException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976708734));
			}
			if (#=zBPb3KhA=.Length - #=zur7PLhI= < #=zBkMjrJ4=)
			{
				throw new ArgumentException();
			}
			if (#=zBkMjrJ4= == 0)
			{
				return 0;
			}
			int i;
			if (6 != 0)
			{
				i = #=zBkMjrJ4=;
			}
			int num;
			if (2 != 0)
			{
				num = #=zur7PLhI=;
			}
			if (this.#=zalgQLww= < this.#=zI9SDSjk=)
			{
				if (5 != 0)
				{
					this.#=zqSUxVwhILEodARWbwyq0bAab56sO();
				}
				int num2 = this.#=z3DFIHTE= - this.#=zalgQLww=;
				int num3;
				if (4 != 0)
				{
					num3 = num2;
				}
				if (num3 > #=zBkMjrJ4=)
				{
					Buffer.BlockCopy(this.#=zx_mghN4=, this.#=zalgQLww=, #=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
					this.#=zalgQLww= += #=zBkMjrJ4=;
					return #=zBkMjrJ4=;
				}
				Buffer.BlockCopy(this.#=zx_mghN4=, this.#=zalgQLww=, #=zBPb3KhA=, #=zur7PLhI=, num3);
				this.#=zalgQLww= = this.#=z3DFIHTE=;
				if (this.#=zWVcvLK0=)
				{
					return num3;
				}
				i -= num3;
				num += num3;
			}
			if (this.#=zWVcvLK0=)
			{
				return #=zBkMjrJ4= - i;
			}
			while (i > 0)
			{
				this.#=zh74VM8rwlCPD49WyWtdThqSJjtCGyLTpQ0ZP$CrktV6V();
				if (this.#=zWVcvLK0=)
				{
					return #=zBkMjrJ4= - i;
				}
				int num4 = this.#=z3DFIHTE=;
				if (i < num4)
				{
					Buffer.BlockCopy(this.#=zx_mghN4=, 0, #=zBPb3KhA=, num, i);
					this.#=zalgQLww= = i;
					return #=zBkMjrJ4=;
				}
				Buffer.BlockCopy(this.#=zx_mghN4=, 0, #=zBPb3KhA=, num, num4);
				num += num4;
				i -= num4;
				this.#=zalgQLww= = num4;
			}
			return #=zBkMjrJ4=;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001F644 File Offset: 0x0001D844
		private void #=zqSUxVwhILEodARWbwyq0bAab56sO()
		{
			if (-1 != 0)
			{
				this.#=zTG51LMi2MAJghKMUirSor5w=();
			}
			if (!this.#=zkzlpT_c=)
			{
				bool flag = true;
				if (!false)
				{
					this.#=zkzlpT_c= = flag;
				}
				bool flag2 = false;
				if (4 != 0)
				{
					this.#=zWVcvLK0= = flag2;
				}
				int num = this.#=zAWZgy3A=;
				if (this.#=zuANKhdE=)
				{
					this.#=zt$cqECc=.Position = (long)(4 + num * this.#=zkC0PuRE=);
					this.#=zuANKhdE= = false;
				}
				this.#=zZa6ICxFshy9SyXWVzimHimuq9X7OAPc5bQ==(num);
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001F6BC File Offset: 0x0001D8BC
		private void #=zh74VM8rwlCPD49WyWtdThqSJjtCGyLTpQ0ZP$CrktV6V()
		{
			int num = this.#=zAWZgy3A= + 1;
			int num2;
			if (7 != 0)
			{
				num2 = num;
			}
			if (this.#=zZa6ICxFshy9SyXWVzimHimuq9X7OAPc5bQ==(num2))
			{
				int num3 = num2;
				if (6 != 0)
				{
					this.#=zAWZgy3A= = num3;
				}
				int num4 = 0;
				if (4 != 0)
				{
					this.#=zalgQLww= = num4;
				}
			}
			this.#=zkzlpT_c= = true;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001F708 File Offset: 0x0001D908
		private bool #=zZa6ICxFshy9SyXWVzimHimuq9X7OAPc5bQ==(int #=zBPb3KhA=)
		{
			int num = 0;
			int i;
			if (5 != 0)
			{
				i = num;
			}
			while (i < this.#=zkC0PuRE=)
			{
				int num2 = this.#=zt$cqECc=.Read(this.#=zV_dyzaM=, i, this.#=zkC0PuRE= - i);
				int num3;
				if (7 != 0)
				{
					num3 = num2;
				}
				if (num3 == 0)
				{
					if (i != 0)
					{
						throw new InvalidOperationException();
					}
					bool flag = true;
					if (7 != 0)
					{
						this.#=zWVcvLK0= = flag;
					}
					return false;
				}
				else
				{
					i += num3;
				}
			}
			this.#=z3DFIHTE= = this.#=zfbJ$RjA=.#=z1GnCoAqe$8LgFZylE6P18vKZ7oruAaWYFFKb_cyEIgfbDhZXh$5LL2TkE5IrkCw$Jj3fLCkJkXdTTfoUPg==(this.#=zV_dyzaM=, 0, this.#=zkC0PuRE=, this.#=zx_mghN4=, 0);
			if (#=zBPb3KhA= == this.#=zur7PLhI=)
			{
				this.#=z3DFIHTE= = this.#=zBkMjrJ4=;
			}
			return true;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001F7A8 File Offset: 0x0001D9A8
		private void #=zTG51LMi2MAJghKMUirSor5w=()
		{
			if (!this.#=zvbM_yZc=)
			{
				if (this.#=zt$cqECc=.Position != 0L)
				{
					this.#=zt$cqECc=.Position = 0L;
					bool flag = true;
					if (4 != 0)
					{
						this.#=zuANKhdE= = flag;
					}
				}
				#=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q= #=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q= = #=qqwPkgIMD534pZvFiLDWzkNTqsz42I5ROj6gkNNHVHhw=.#=z56zpif95dS3A1Xsn7Q==(this.#=zt$cqECc=);
				#=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q= #=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q=2;
				if (5 != 0)
				{
					#=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q=2 = #=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q=;
				}
				int num = #=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q=2.#=z1158WlVfR$AdC_pyPfd7_3gm61r6Dw7DPnFrR2c=();
				if (4 != 0)
				{
					this.#=zBPb3KhA= = num;
				}
				this.#=zur7PLhI= = this.#=zBPb3KhA= / this.#=zI9SDSjk=;
				this.#=zBkMjrJ4= = this.#=zBPb3KhA= % this.#=zI9SDSjk=;
				this.#=zvbM_yZc= = true;
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001F840 File Offset: 0x0001DA40
		private static #=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q= #=z56zpif95dS3A1Xsn7Q==(Stream #=zBPb3KhA=)
		{
			#=q5C2iau46deY425lF_fWe8A8L62paMr7tTyO$dDcCTjE= #=q5C2iau46deY425lF_fWe8A8L62paMr7tTyO$dDcCTjE= = new #=q5C2iau46deY425lF_fWe8A8L62paMr7tTyO$dDcCTjE=(#=zBPb3KhA=, 0);
			#=q5C2iau46deY425lF_fWe8A8L62paMr7tTyO$dDcCTjE= #=q5C2iau46deY425lF_fWe8A8L62paMr7tTyO$dDcCTjE=2;
			if (6 != 0)
			{
				#=q5C2iau46deY425lF_fWe8A8L62paMr7tTyO$dDcCTjE=2 = #=q5C2iau46deY425lF_fWe8A8L62paMr7tTyO$dDcCTjE=;
			}
			#=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q= result;
			try
			{
				#=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU= #=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU= = new #=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU=(#=q5C2iau46deY425lF_fWe8A8L62paMr7tTyO$dDcCTjE=2);
				#=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU= #=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU=2;
				if (6 != 0)
				{
					#=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU=2 = #=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU=;
				}
				try
				{
					int num = #=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU=2.#=z32YI2hcbZtgFvF3JDfQk6fjfXYx5();
					int num2;
					if (8 != 0)
					{
						num2 = num;
					}
					#=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q= #=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q= = new #=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q=();
					#=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q=.#=zjrFlb1ISUTrY1rWRBTrk9nDe$t4fQBmuyaZjfglIeTW7(num2);
					result = #=qRRaWE5qPjnI9pZ9N991ftA5PGInDbZ3wl3QHkAuCv9Q=;
				}
				finally
				{
					((IDisposable)#=qL4GVeMf3RteTRWeQLvkw7Ij3$KxjAKUeDAAp6$VD_bU=2).Dispose();
				}
			}
			finally
			{
				((IDisposable)#=q5C2iau46deY425lF_fWe8A8L62paMr7tTyO$dDcCTjE=2).Dispose();
			}
			return result;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000023AD File Offset: 0x000005AD
		public override void Flush()
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000232E File Offset: 0x0000052E
		public override void Write(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000169 RID: 361
		private int #=zBPb3KhA=;

		// Token: 0x0400016A RID: 362
		private int #=zur7PLhI=;

		// Token: 0x0400016B RID: 363
		private int #=zBkMjrJ4=;

		// Token: 0x0400016C RID: 364
		private Stream #=zt$cqECc=;

		// Token: 0x0400016D RID: 365
		private #=q3YmA9J4Ih4mJgGYtKkbFOzVFAoN8UpdtQeVB7j2rDho= #=zfbJ$RjA=;

		// Token: 0x0400016E RID: 366
		private int #=zAWZgy3A=;

		// Token: 0x0400016F RID: 367
		private bool #=zkzlpT_c=;

		// Token: 0x04000170 RID: 368
		private bool #=zWVcvLK0=;

		// Token: 0x04000171 RID: 369
		private bool #=zuANKhdE=;

		// Token: 0x04000172 RID: 370
		private byte[] #=zV_dyzaM=;

		// Token: 0x04000173 RID: 371
		private int #=zkC0PuRE=;

		// Token: 0x04000174 RID: 372
		private byte[] #=zx_mghN4=;

		// Token: 0x04000175 RID: 373
		private int #=z3DFIHTE=;

		// Token: 0x04000176 RID: 374
		private int #=zalgQLww=;

		// Token: 0x04000177 RID: 375
		private int #=zI9SDSjk=;

		// Token: 0x04000178 RID: 376
		private bool #=zvbM_yZc=;
	}
}
