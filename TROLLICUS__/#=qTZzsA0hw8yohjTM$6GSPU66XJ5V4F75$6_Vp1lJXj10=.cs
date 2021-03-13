using System;
using System.IO;

namespace TROLLICUS__
{
	// Token: 0x02000085 RID: 133
	internal sealed class #=qTZzsA0hw8yohjTM$6GSPU66XJ5V4F75$6_Vp1lJXj10= : Stream
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x0001A474 File Offset: 0x00018674
		public #=qTZzsA0hw8yohjTM$6GSPU66XJ5V4F75$6_Vp1lJXj10=(Stream #=zBPb3KhA=, #=qXFlTUA3H$tLznDC7aWzu2zleUjFdjB9xfWZS2Uln5uk= #=zur7PLhI= = null, #=qZAVyVCTYdj4ubhafEk1O02cxtrnJ71AsR_Q1vIXN8RE= #=zBkMjrJ4= = null, bool #=zt$cqECc= = false)
		{
			if (true)
			{
				this.#=zur7PLhI= = #=zBPb3KhA=;
			}
			if (true)
			{
				this.#=zBPb3KhA= = #=zt$cqECc=;
			}
			if (6 != 0)
			{
				this.#=zfbJ$RjA= = #=zBkMjrJ4=;
			}
			this.#=zt$cqECc= = #=zur7PLhI=;
			if (this.#=zt$cqECc= == null)
			{
				this.#=zt$cqECc= = #=qXFlTUA3H$tLznDC7aWzu2zleUjFdjB9xfWZS2Uln5uk=.#=z_Nr1Rkpzd_PUHeAvbi9fKTY=();
			}
			if (this.#=zt$cqECc=.#=zN8mZZXIhms5cMY_qjlTgJjfZf7W_V1tOIflq6jg=() == 0)
			{
				throw new ArgumentException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705513));
			}
			if (this.#=zt$cqECc=.#=zQVwEGLGC4NCmCdbo4ZhpakzmeFDid9KAXB1pppOBJmsm() == 0)
			{
				throw new ArgumentException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705513));
			}
			if (!this.#=zur7PLhI=.CanRead)
			{
				throw new ArgumentException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705502));
			}
			if (!this.#=zur7PLhI=.CanSeek)
			{
				throw new ArgumentException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705502));
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0001A544 File Offset: 0x00018744
		private void #=zbEPxpp0GEV9Ph3tF6yJPXkZsjKshQYZQZUfQFgA=()
		{
			if (!this.#=zkzlpT_c=)
			{
				#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=[] array = new #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=[this.#=zt$cqECc=.#=zN8mZZXIhms5cMY_qjlTgJjfZf7W_V1tOIflq6jg=()];
				if (6 != 0)
				{
					this.#=zBkMjrJ4= = array;
				}
				int num = 0;
				int i;
				if (3 != 0)
				{
					i = num;
				}
				while (i < this.#=zt$cqECc=.#=zN8mZZXIhms5cMY_qjlTgJjfZf7W_V1tOIflq6jg=())
				{
					this.#=zBkMjrJ4=[i] = new #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=();
					int num2 = i + 1;
					if (true)
					{
						i = num2;
					}
				}
				if (this.#=zfbJ$RjA= != null)
				{
					this.#=zAWZgy3A= = this.#=zfbJ$RjA=.#=zQIJlSGY5zLbgQIELMJsjydAzWSx0(this.#=zt$cqECc=);
				}
				this.#=zkzlpT_c= = true;
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0001A5D4 File Offset: 0x000187D4
		protected override void Dispose(bool #=zBPb3KhA=)
		{
			try
			{
				if (#=zBPb3KhA= && !this.#=zBPb3KhA=)
				{
					this.#=zur7PLhI=.Close();
				}
			}
			finally
			{
				if (3 != 0)
				{
					base.Dispose(#=zBPb3KhA=);
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x000023B2 File Offset: 0x000005B2
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x000023B2 File Offset: 0x000005B2
		public override bool CanSeek
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00002440 File Offset: 0x00000640
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0001A618 File Offset: 0x00018818
		public override long Length
		{
			get
			{
				if (7 == 0)
				{
				}
				return this.#=zur7PLhI=.Length;
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000232E File Offset: 0x0000052E
		public override void SetLength(long #=zBPb3KhA=)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000232E File Offset: 0x0000052E
		public override void Write(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000023AD File Offset: 0x000005AD
		public override void Flush()
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0001A63C File Offset: 0x0001883C
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x0001A680 File Offset: 0x00018880
		public override long Position
		{
			get
			{
				if (4 == 0)
				{
				}
				long position = this.#=zur7PLhI=.Position;
				if (3 == 0)
				{
				}
				int num = this.#=zuANKhdE=;
				if (7 == 0)
				{
				}
				return position + (long)(num - this.#=zV_dyzaM=);
			}
			set
			{
				if (!true)
				{
				}
				if (7 == 0)
				{
				}
				this.Seek(value, SeekOrigin.Begin);
				if (!true)
				{
				}
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0001A6B0 File Offset: 0x000188B0
		private int #=zO1UNKNrZkfGqAhrFbuNc3SXF2D1GDSMWYaxAeDw=(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			int num = this.#=zV_dyzaM= - this.#=zuANKhdE=;
			int num2;
			if (5 != 0)
			{
				num2 = num;
			}
			if (num2 <= 0)
			{
				return 0;
			}
			if (num2 > #=zBkMjrJ4=)
			{
				if (true)
				{
					num2 = #=zBkMjrJ4=;
				}
			}
			Array src = this.#=zWVcvLK0=;
			int srcOffset = this.#=zuANKhdE=;
			int count = num2;
			if (!false)
			{
				Buffer.BlockCopy(src, srcOffset, #=zBPb3KhA=, #=zur7PLhI=, count);
			}
			this.#=zuANKhdE= += num2;
			return num2;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0001A718 File Offset: 0x00018918
		private void #=zdQExLdjRmW_arjgoolKnB$mwPWbpeq6GIQ==(int #=zBPb3KhA=)
		{
			int num = (int)this.#=zur7PLhI=.Position;
			int num2;
			if (3 != 0)
			{
				num2 = num;
			}
			if ((long)num2 >= this.#=zur7PLhI=.Length)
			{
				return;
			}
			int num3 = num2 + #=zBPb3KhA=;
			int num4;
			if (!false)
			{
				num4 = num3;
			}
			#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=[] array = this.#=zBkMjrJ4=;
			#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=[] array2;
			if (2 != 0)
			{
				array2 = array;
			}
			int num5 = 0;
			int i;
			if (true)
			{
				i = num5;
			}
			while (i < array2.Length)
			{
				#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= = array2[i];
				#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=2;
				if (6 != 0)
				{
					#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=2 = #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=;
				}
				if (#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=2.#=zur7PLhI= <= num2 && #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=2.#=zBkMjrJ4= >= num4)
				{
					byte[] array3 = #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=2.#=zBPb3KhA=;
					if (5 != 0)
					{
						this.#=zWVcvLK0= = array3;
					}
					this.#=zV_dyzaM= = #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=2.#=zBkMjrJ4= - #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=2.#=zur7PLhI=;
					this.#=zuANKhdE= = num2 - #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=2.#=zur7PLhI=;
					this.#=zur7PLhI=.Position = (long)#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=2.#=zBkMjrJ4=;
					#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=2.#=zt$cqECc= = DateTime.UtcNow;
					return;
				}
				i++;
			}
			int num6 = 0;
			DateTime t = this.#=zBkMjrJ4=[0].#=zt$cqECc=;
			for (int j = 1; j < this.#=zBkMjrJ4=.Length; j++)
			{
				if (this.#=zBkMjrJ4=[j].#=zt$cqECc= < t)
				{
					num6 = j;
				}
			}
			#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3 = this.#=zBkMjrJ4=[num6];
			if (#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3.#=zBPb3KhA= == null)
			{
				#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3.#=zBPb3KhA= = new byte[this.#=zt$cqECc=.#=zhqdqNBNk92XTd72ozxSnJjGDufHe123lmqQm2ho=()];
			}
			int num7 = num2;
			num2 = this.#=zQ1HySjXUPkKcTMnK0qQ5sJ39Ntvtm2N6OA==(num2);
			if (num2 < 0)
			{
				num2 = 0;
			}
			num4 = num2 + this.#=zt$cqECc=.#=zhqdqNBNk92XTd72ozxSnJjGDufHe123lmqQm2ho=();
			if (this.#=zAWZgy3A= == null || !this.#=zAWZgy3A=.#=zeNKpemQjXFz4e_YnzqPDy7P6bfTxmiYfqhDoiCgKOlxZ(num2, ref #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3))
			{
				#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3.#=zur7PLhI= = num2;
				#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3.#=zt$cqECc= = DateTime.UtcNow;
				this.#=zWVcvLK0= = #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3.#=zBPb3KhA=;
				this.#=zur7PLhI=.Position = (long)num2;
				this.#=zV_dyzaM= = this.#=zur7PLhI=.Read(this.#=zWVcvLK0=, 0, num4 - num2);
				this.#=zuANKhdE= = num7 - num2;
				#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3.#=zBkMjrJ4= = num2 + this.#=zV_dyzaM=;
				if (this.#=zAWZgy3A= != null)
				{
					this.#=zAWZgy3A=.#=z4Uz4oUFzFaRDj8qIzqRoo71cZzmOPu8LzA==(#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3);
					return;
				}
			}
			else
			{
				this.#=zWVcvLK0= = #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3.#=zBPb3KhA=;
				this.#=zV_dyzaM= = #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3.#=zBkMjrJ4= - num2;
				this.#=zur7PLhI=.Position = (long)#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3.#=zBkMjrJ4=;
				this.#=zuANKhdE= = num7 - num2;
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001A950 File Offset: 0x00018B50
		private int #=zQ1HySjXUPkKcTMnK0qQ5sJ39Ntvtm2N6OA==(int #=zBPb3KhA=)
		{
			if (3 == 0)
			{
			}
			if (3 == 0)
			{
			}
			if (6 == 0)
			{
			}
			return #=zBPb3KhA= - #=zBPb3KhA= % this.#=zt$cqECc=.#=zhqdqNBNk92XTd72ozxSnJjGDufHe123lmqQm2ho=();
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0001A988 File Offset: 0x00018B88
		public override int Read(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=)
		{
			if (#=zBPb3KhA= == null)
			{
				throw new ArgumentNullException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705483));
			}
			if (#=zur7PLhI= < 0)
			{
				throw new ArgumentOutOfRangeException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705462));
			}
			if (#=zBkMjrJ4= < 0)
			{
				throw new ArgumentOutOfRangeException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976705469));
			}
			if (#=zBPb3KhA=.Length - #=zur7PLhI= < #=zBkMjrJ4=)
			{
				throw new ArgumentException();
			}
			int num = #=zur7PLhI=;
			int num2;
			if (6 != 0)
			{
				num2 = num;
			}
			int num3 = this.#=zO1UNKNrZkfGqAhrFbuNc3SXF2D1GDSMWYaxAeDw=(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
			int num4;
			if (4 != 0)
			{
				num4 = num3;
			}
			if (num4 == #=zBkMjrJ4=)
			{
				return num4;
			}
			int num5 = num4;
			int num6;
			if (-1 != 0)
			{
				num6 = num5;
			}
			if (num4 > 0)
			{
				int num7 = #=zBkMjrJ4= - num4;
				if (7 != 0)
				{
					#=zBkMjrJ4= = num7;
				}
				#=zur7PLhI= += num4;
			}
			this.#=zuANKhdE= = (this.#=zV_dyzaM= = 0);
			this.#=zbEPxpp0GEV9Ph3tF6yJPXkZsjKshQYZQZUfQFgA=();
			if (#=zBkMjrJ4= < this.#=zt$cqECc=.#=zhqdqNBNk92XTd72ozxSnJjGDufHe123lmqQm2ho=())
			{
				this.#=zdQExLdjRmW_arjgoolKnB$mwPWbpeq6GIQ==(#=zBkMjrJ4=);
				num4 = this.#=zO1UNKNrZkfGqAhrFbuNc3SXF2D1GDSMWYaxAeDw=(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
				return num4 + num6;
			}
			if (this.#=zAWZgy3A= == null)
			{
				return this.#=zur7PLhI=.Read(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=) + num6;
			}
			int num8 = (int)this.#=zur7PLhI=.Position - num6;
			int num9;
			if (this.#=zAWZgy3A=.#=zT6riz4KHQv9K3LE8SahQEmUSSWcvlaN6ZWBTqos=(num8, #=zBPb3KhA=, num2, #=zBkMjrJ4= + num6, out num9))
			{
				this.#=zur7PLhI=.Seek((long)(num9 - num6), SeekOrigin.Current);
				return num9;
			}
			num9 = this.#=zur7PLhI=.Read(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=);
			if (num9 != 0)
			{
				this.#=zAWZgy3A=.#=zCOb2k9LbyLhCns9PBQ42hl6BXVqB(num8, #=zBPb3KhA=, num2, num9 + num6, num9 < #=zBkMjrJ4=);
			}
			return num9 + num6;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0001AAE0 File Offset: 0x00018CE0
		public override long Seek(long #=zBPb3KhA=, SeekOrigin #=zur7PLhI=)
		{
			if (this.#=zV_dyzaM= - this.#=zuANKhdE= > 0 && #=zur7PLhI= == SeekOrigin.Current)
			{
				long num = #=zBPb3KhA= - (long)(this.#=zV_dyzaM= - this.#=zuANKhdE=);
				if (5 != 0)
				{
					#=zBPb3KhA= = num;
				}
			}
			long position = this.Position;
			long num2;
			if (!false)
			{
				num2 = position;
			}
			long num3 = this.#=zur7PLhI=.Seek(#=zBPb3KhA=, #=zur7PLhI=);
			long num4;
			if (true)
			{
				num4 = num3;
			}
			this.#=zuANKhdE= = (int)(num4 - (num2 - (long)this.#=zuANKhdE=));
			if (0 <= this.#=zuANKhdE= && this.#=zuANKhdE= < this.#=zV_dyzaM=)
			{
				this.#=zur7PLhI=.Seek((long)(this.#=zV_dyzaM= - this.#=zuANKhdE=), SeekOrigin.Current);
			}
			else
			{
				this.#=zuANKhdE= = (this.#=zV_dyzaM= = 0);
			}
			return num4;
		}

		// Token: 0x04000120 RID: 288
		private bool #=zBPb3KhA=;

		// Token: 0x04000121 RID: 289
		private Stream #=zur7PLhI=;

		// Token: 0x04000122 RID: 290
		private #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=[] #=zBkMjrJ4=;

		// Token: 0x04000123 RID: 291
		private #=qXFlTUA3H$tLznDC7aWzu2zleUjFdjB9xfWZS2Uln5uk= #=zt$cqECc=;

		// Token: 0x04000124 RID: 292
		private #=qZAVyVCTYdj4ubhafEk1O02cxtrnJ71AsR_Q1vIXN8RE= #=zfbJ$RjA=;

		// Token: 0x04000125 RID: 293
		private #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY= #=zAWZgy3A=;

		// Token: 0x04000126 RID: 294
		private bool #=zkzlpT_c=;

		// Token: 0x04000127 RID: 295
		private byte[] #=zWVcvLK0=;

		// Token: 0x04000128 RID: 296
		private int #=zuANKhdE=;

		// Token: 0x04000129 RID: 297
		private int #=zV_dyzaM=;
	}
}
