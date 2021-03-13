using System;
using System.Collections.Generic;
using System.Threading;

namespace TROLLICUS__
{
	// Token: 0x02000019 RID: 25
	internal sealed class #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=
	{
		// Token: 0x0600009F RID: 159 RVA: 0x000057F4 File Offset: 0x000039F4
		public #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=(#=qXFlTUA3H$tLznDC7aWzu2zleUjFdjB9xfWZS2Uln5uk= #=zBPb3KhA=)
		{
			object obj = new object();
			if (2 != 0)
			{
				this.#=zBPb3KhA= = obj;
			}
			base..ctor();
			if (8 != 0)
			{
				this.#=zfbJ$RjA= = #=zBPb3KhA=;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000582C File Offset: 0x00003A2C
		private void #=zTpYDT9x8uyMyRt2o9brBXHI=()
		{
			if (this.#=zt$cqECc=)
			{
				return;
			}
			object obj = this.#=zBPb3KhA=;
			object obj2;
			if (8 != 0)
			{
				obj2 = obj;
			}
			object obj3 = obj2;
			if (6 != 0)
			{
				Monitor.Enter(obj3);
			}
			try
			{
				if (!this.#=zt$cqECc=)
				{
					#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=[] array = new #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=[this.#=zfbJ$RjA=.#=zQVwEGLGC4NCmCdbo4ZhpakzmeFDid9KAXB1pppOBJmsm()];
					if (-1 != 0)
					{
						this.#=zur7PLhI= = array;
					}
					for (int i = 0; i < this.#=zfbJ$RjA=.#=zQVwEGLGC4NCmCdbo4ZhpakzmeFDid9KAXB1pppOBJmsm(); i++)
					{
						this.#=zur7PLhI=[i] = new #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=();
					}
					this.#=zBkMjrJ4= = new Dictionary<int, #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=>();
					this.#=zAWZgy3A= = new Dictionary<int, WeakReference>();
					this.#=zkzlpT_c= = new object();
					this.#=zWVcvLK0= = this.#=zfbJ$RjA=.#=zz1PiZLYm_WJesgEDXGi3501gCBUIVfSaCQ==();
					this.#=zuANKhdE= = new object[this.#=zfbJ$RjA=.#=zkmFY5BQ5Po5p243fOfKcScx2y2iz()];
					this.#=zt$cqECc= = true;
				}
			}
			finally
			{
				Monitor.Exit(obj2);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000591C File Offset: 0x00003B1C
		public void #=z4Uz4oUFzFaRDj8qIzqRoo71cZzmOPu8LzA==(#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= #=zBPb3KhA=)
		{
			if (!false)
			{
				this.#=zTpYDT9x8uyMyRt2o9brBXHI=();
			}
			object obj = this.#=zBPb3KhA=;
			object obj2;
			if (2 != 0)
			{
				obj2 = obj;
			}
			object obj3 = obj2;
			if (5 != 0)
			{
				Monitor.Enter(obj3);
			}
			try
			{
				#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=;
				if (this.#=zBkMjrJ4=.TryGetValue(#=zBPb3KhA=.#=zur7PLhI=, out #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=) && #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= != null)
				{
					#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=.#=zt$cqECc= = #=zBPb3KhA=.#=zt$cqECc=;
				}
				else
				{
					int num = 0;
					DateTime t = this.#=zur7PLhI=[0].#=zt$cqECc=;
					for (int i = 1; i < this.#=zfbJ$RjA=.#=zQVwEGLGC4NCmCdbo4ZhpakzmeFDid9KAXB1pppOBJmsm(); i++)
					{
						if (this.#=zur7PLhI=[i].#=zt$cqECc= < t)
						{
							num = i;
						}
					}
					#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= = this.#=zur7PLhI=[num];
					if (#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=.#=zBPb3KhA= == null)
					{
						#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=.#=zBPb3KhA= = new byte[this.#=zfbJ$RjA=.#=zhqdqNBNk92XTd72ozxSnJjGDufHe123lmqQm2ho=()];
					}
					else
					{
						this.#=zBkMjrJ4=[#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=.#=zur7PLhI=] = null;
					}
					this.#=zYHX4fsE18NA75e2ypLKmSJx7GklarH5mrGfet5s=(#=zBPb3KhA=, #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=);
					this.#=zBkMjrJ4=[#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=.#=zur7PLhI=] = #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=;
					if (this.#=zBkMjrJ4=.Count > this.#=zfbJ$RjA=.#=zQVwEGLGC4NCmCdbo4ZhpakzmeFDid9KAXB1pppOBJmsm() * 2)
					{
						this.#=zrltDREi00Zrfq6SY_rUzdMa0L6XjqC78QbDfzvU=();
					}
				}
			}
			finally
			{
				Monitor.Exit(obj2);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005A54 File Offset: 0x00003C54
		private void #=zrltDREi00Zrfq6SY_rUzdMa0L6XjqC78QbDfzvU=()
		{
			Dictionary<int, #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=> dictionary = this.#=zBkMjrJ4=;
			Dictionary<int, #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=> dictionary2;
			if (2 != 0)
			{
				dictionary2 = dictionary;
			}
			List<int> list = new List<int>();
			List<int> list2;
			if (5 != 0)
			{
				list2 = list;
			}
			Dictionary<int, #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=>.Enumerator enumerator = dictionary2.GetEnumerator();
			Dictionary<int, #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=>.Enumerator enumerator2;
			if (7 != 0)
			{
				enumerator2 = enumerator;
			}
			try
			{
				while (enumerator2.MoveNext())
				{
					KeyValuePair<int, #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=> keyValuePair = enumerator2.Current;
					if (keyValuePair.Value == null)
					{
						list2.Add(keyValuePair.Key);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator2).Dispose();
			}
			foreach (int key in list2)
			{
				dictionary2.Remove(key);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005B14 File Offset: 0x00003D14
		public bool #=zeNKpemQjXFz4e_YnzqPDy7P6bfTxmiYfqhDoiCgKOlxZ(int #=zBPb3KhA=, ref #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= #=zur7PLhI=)
		{
			if (!this.#=zt$cqECc=)
			{
				return false;
			}
			object obj = this.#=zBPb3KhA=;
			object obj2;
			if (5 != 0)
			{
				obj2 = obj;
			}
			object obj3 = obj2;
			if (true)
			{
				Monitor.Enter(obj3);
			}
			try
			{
				#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=;
				if (this.#=zBkMjrJ4=.TryGetValue(#=zBPb3KhA=, out #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=) && #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= != null)
				{
					#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=2 = #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=;
					#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3 = #=zur7PLhI=;
					if (6 != 0)
					{
						this.#=zYHX4fsE18NA75e2ypLKmSJx7GklarH5mrGfet5s=(#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=2, #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=3);
					}
					return true;
				}
			}
			finally
			{
				Monitor.Exit(obj2);
			}
			return false;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00005B8C File Offset: 0x00003D8C
		private void #=zYHX4fsE18NA75e2ypLKmSJx7GklarH5mrGfet5s=(#=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= #=zBPb3KhA=, #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE= #=zur7PLhI=)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (7 != 0)
			{
				#=zBPb3KhA=.#=zt$cqECc= = utcNow;
			}
			int num = #=zBPb3KhA=.#=zur7PLhI=;
			if (true)
			{
				#=zur7PLhI=.#=zur7PLhI= = num;
			}
			int num2 = #=zBPb3KhA=.#=zBkMjrJ4=;
			if (6 != 0)
			{
				#=zur7PLhI=.#=zBkMjrJ4= = num2;
			}
			#=zur7PLhI=.#=zt$cqECc= = #=zBPb3KhA=.#=zt$cqECc=;
			Buffer.BlockCopy(#=zBPb3KhA=.#=zBPb3KhA=, 0, #=zur7PLhI=.#=zBPb3KhA=, 0, this.#=zfbJ$RjA=.#=zhqdqNBNk92XTd72ozxSnJjGDufHe123lmqQm2ho=());
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00005C00 File Offset: 0x00003E00
		private void #=z_XMgX2YK3XUDY_AW31JZcGbu9Ow66EcYZw2xsQrJ9SR3(object #=zBPb3KhA=)
		{
			int num = 0;
			int i;
			if (5 != 0)
			{
				i = num;
			}
			while (i < this.#=zuANKhdE=.Length)
			{
				if (this.#=zuANKhdE=[i] == #=zBPb3KhA=)
				{
					return;
				}
				int num2 = i + 1;
				if (4 != 0)
				{
					i = num2;
				}
			}
			this.#=zuANKhdE=[this.#=zV_dyzaM=] = #=zBPb3KhA=;
			int num3 = this.#=zV_dyzaM= + 1;
			if (8 != 0)
			{
				this.#=zV_dyzaM= = num3;
			}
			if (this.#=zV_dyzaM= == this.#=zuANKhdE=.Length)
			{
				this.#=zV_dyzaM= = 0;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00005C78 File Offset: 0x00003E78
		private void #=zBg_3ZtgRaCos5ubOgyt_gp8FyhzH93UJEg==()
		{
			if (this.#=zAWZgy3A=.Count >= this.#=zWVcvLK0=)
			{
				Dictionary<int, WeakReference> dictionary = new Dictionary<int, WeakReference>();
				Dictionary<int, WeakReference> dictionary2;
				if (8 != 0)
				{
					dictionary2 = dictionary;
				}
				Dictionary<int, WeakReference>.Enumerator enumerator = this.#=zAWZgy3A=.GetEnumerator();
				Dictionary<int, WeakReference>.Enumerator enumerator2;
				if (true)
				{
					enumerator2 = enumerator;
				}
				try
				{
					while (enumerator2.MoveNext())
					{
						KeyValuePair<int, WeakReference> keyValuePair = enumerator2.Current;
						KeyValuePair<int, WeakReference> keyValuePair2;
						if (8 != 0)
						{
							keyValuePair2 = keyValuePair;
						}
						if (keyValuePair2.Value.IsAlive)
						{
							dictionary2.Add(keyValuePair2.Key, keyValuePair2.Value);
						}
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
				this.#=zAWZgy3A= = dictionary2;
				this.#=zWVcvLK0= = Math.Max(dictionary2.Count * 2, 10);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005D34 File Offset: 0x00003F34
		public void #=zCOb2k9LbyLhCns9PBQ42hl6BXVqB(int #=zBPb3KhA=, byte[] #=zur7PLhI=, int #=zBkMjrJ4=, int #=zt$cqECc=, bool #=zfbJ$RjA=)
		{
			if (6 != 0)
			{
				this.#=zTpYDT9x8uyMyRt2o9brBXHI=();
			}
			object obj = this.#=zkzlpT_c=;
			object obj2;
			if (8 != 0)
			{
				obj2 = obj;
			}
			object obj3 = obj2;
			if (-1 != 0)
			{
				Monitor.Enter(obj3);
			}
			try
			{
				WeakReference weakReference;
				#=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=.#=zBPb3KhA= #=zBPb3KhA=2;
				if (this.#=zAWZgy3A=.TryGetValue(#=zBPb3KhA=, out weakReference))
				{
					#=zBPb3KhA=2 = (weakReference.Target as #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=.#=zBPb3KhA=);
					if (#=zBPb3KhA=2 != null)
					{
						if (#=zBPb3KhA=2.#=zBPb3KhA=.Length < #=zt$cqECc=)
						{
							#=zBPb3KhA=2.#=zP3O61u1VU6VQPcbeWBwuEWPkufp5(#=zur7PLhI=, #=zBkMjrJ4=, #=zt$cqECc=, #=zfbJ$RjA=);
							goto IL_84;
						}
						goto IL_84;
					}
				}
				this.#=zBg_3ZtgRaCos5ubOgyt_gp8FyhzH93UJEg==();
				#=zBPb3KhA=2 = new #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=.#=zBPb3KhA=(#=zur7PLhI=, #=zBkMjrJ4=, #=zt$cqECc=, #=zfbJ$RjA=);
				this.#=zAWZgy3A=[#=zBPb3KhA=] = new WeakReference(#=zBPb3KhA=2);
				IL_84:
				this.#=z_XMgX2YK3XUDY_AW31JZcGbu9Ow66EcYZw2xsQrJ9SR3(#=zBPb3KhA=2);
			}
			finally
			{
				Monitor.Exit(obj2);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00005DE8 File Offset: 0x00003FE8
		public bool #=zT6riz4KHQv9K3LE8SahQEmUSSWcvlaN6ZWBTqos=(int #=zBPb3KhA=, byte[] #=zur7PLhI=, int #=zBkMjrJ4=, int #=zt$cqECc=, out int #=zfbJ$RjA=)
		{
			#=zfbJ$RjA= = 0;
			if (!this.#=zt$cqECc=)
			{
				return false;
			}
			object obj = this.#=zkzlpT_c=;
			object obj2;
			if (8 != 0)
			{
				obj2 = obj;
			}
			object obj3 = obj2;
			if (3 != 0)
			{
				Monitor.Enter(obj3);
			}
			bool result;
			try
			{
				WeakReference weakReference;
				if (!this.#=zAWZgy3A=.TryGetValue(#=zBPb3KhA=, out weakReference))
				{
					bool flag = false;
					if (7 != 0)
					{
						result = flag;
					}
				}
				else
				{
					#=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=.#=zBPb3KhA= #=zBPb3KhA=2 = weakReference.Target as #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=.#=zBPb3KhA=;
					if (#=zBPb3KhA=2 == null)
					{
						result = false;
					}
					else
					{
						int num = #=zBPb3KhA=2.#=zBPb3KhA=.Length;
						#=zfbJ$RjA= = #=zt$cqECc=;
						if (num < #=zt$cqECc=)
						{
							if (!#=zBPb3KhA=2.#=zur7PLhI=)
							{
								return false;
							}
							#=zfbJ$RjA= = num;
						}
						Buffer.BlockCopy(#=zBPb3KhA=2.#=zBPb3KhA=, 0, #=zur7PLhI=, #=zBkMjrJ4=, #=zfbJ$RjA=);
						this.#=z_XMgX2YK3XUDY_AW31JZcGbu9Ow66EcYZw2xsQrJ9SR3(#=zBPb3KhA=2);
						result = true;
					}
				}
			}
			finally
			{
				Monitor.Exit(obj2);
			}
			return result;
		}

		// Token: 0x04000044 RID: 68
		private readonly object #=zBPb3KhA=;

		// Token: 0x04000045 RID: 69
		private #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=[] #=zur7PLhI=;

		// Token: 0x04000046 RID: 70
		private Dictionary<int, #=qC4mBOabdGiiovP8Wmy_x$Ilf8UHOPT5c8pLBrbyQXiE=> #=zBkMjrJ4=;

		// Token: 0x04000047 RID: 71
		private bool #=zt$cqECc=;

		// Token: 0x04000048 RID: 72
		private #=qXFlTUA3H$tLznDC7aWzu2zleUjFdjB9xfWZS2Uln5uk= #=zfbJ$RjA=;

		// Token: 0x04000049 RID: 73
		private Dictionary<int, WeakReference> #=zAWZgy3A=;

		// Token: 0x0400004A RID: 74
		private object #=zkzlpT_c=;

		// Token: 0x0400004B RID: 75
		private int #=zWVcvLK0=;

		// Token: 0x0400004C RID: 76
		private object[] #=zuANKhdE=;

		// Token: 0x0400004D RID: 77
		private int #=zV_dyzaM=;

		// Token: 0x0200001A RID: 26
		private sealed class #=zBPb3KhA=
		{
			// Token: 0x060000A9 RID: 169 RVA: 0x00005EA8 File Offset: 0x000040A8
			public #=zBPb3KhA=()
			{
				if (false)
				{
				}
				base..ctor();
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00005EC8 File Offset: 0x000040C8
			public #=zBPb3KhA=(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=, bool #=zt$cqECc=)
			{
				if (7 != 0)
				{
					this.#=zP3O61u1VU6VQPcbeWBwuEWPkufp5(#=zBPb3KhA=, #=zur7PLhI=, #=zBkMjrJ4=, #=zt$cqECc=);
				}
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00005EF4 File Offset: 0x000040F4
			public void #=zP3O61u1VU6VQPcbeWBwuEWPkufp5(byte[] #=zBPb3KhA=, int #=zur7PLhI=, int #=zBkMjrJ4=, bool #=zt$cqECc=)
			{
				byte[] array = new byte[#=zBkMjrJ4=];
				if (!false)
				{
					this.#=zBPb3KhA= = array;
				}
				Array dst = this.#=zBPb3KhA=;
				int dstOffset = 0;
				if (2 != 0)
				{
					Buffer.BlockCopy(#=zBPb3KhA=, #=zur7PLhI=, dst, dstOffset, #=zBkMjrJ4=);
				}
				if (3 != 0)
				{
					this.#=zur7PLhI= = #=zt$cqECc=;
				}
			}

			// Token: 0x0400004E RID: 78
			public byte[] #=zBPb3KhA=;

			// Token: 0x0400004F RID: 79
			public bool #=zur7PLhI=;
		}
	}
}
