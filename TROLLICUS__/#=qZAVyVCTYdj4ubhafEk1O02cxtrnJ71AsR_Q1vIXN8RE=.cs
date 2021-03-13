using System;
using System.Collections.Generic;
using System.Threading;

namespace TROLLICUS__
{
	// Token: 0x0200008E RID: 142
	internal sealed class #=qZAVyVCTYdj4ubhafEk1O02cxtrnJ71AsR_Q1vIXN8RE=
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x0001D11C File Offset: 0x0001B31C
		public #=qZAVyVCTYdj4ubhafEk1O02cxtrnJ71AsR_Q1vIXN8RE=()
		{
			object obj = new object();
			if (7 != 0)
			{
				this.#=zBPb3KhA= = obj;
			}
			base..ctor();
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0001D144 File Offset: 0x0001B344
		internal #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY= #=zQIJlSGY5zLbgQIELMJsjydAzWSx0(#=qXFlTUA3H$tLznDC7aWzu2zleUjFdjB9xfWZS2Uln5uk= #=zBPb3KhA=)
		{
			if (#=zBPb3KhA= == null)
			{
				throw new ArgumentNullException();
			}
			object obj = this.#=zBPb3KhA=;
			object obj2;
			if (4 != 0)
			{
				obj2 = obj;
			}
			object obj3 = obj2;
			if (2 != 0)
			{
				Monitor.Enter(obj3);
			}
			#=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY= result;
			try
			{
				if (this.#=zur7PLhI= == null)
				{
					Dictionary<#=qXFlTUA3H$tLznDC7aWzu2zleUjFdjB9xfWZS2Uln5uk=, #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=> dictionary = new Dictionary<#=qXFlTUA3H$tLznDC7aWzu2zleUjFdjB9xfWZS2Uln5uk=, #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=>();
					if (7 != 0)
					{
						this.#=zur7PLhI= = dictionary;
					}
				}
				#=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY= #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=;
				if (!this.#=zur7PLhI=.TryGetValue(#=zBPb3KhA=, out #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=))
				{
					#=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY= = new #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=(#=zBPb3KhA=);
					this.#=zur7PLhI=[#=zBPb3KhA=] = #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=;
				}
				result = #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=;
			}
			finally
			{
				Monitor.Exit(obj2);
			}
			return result;
		}

		// Token: 0x04000140 RID: 320
		private object #=zBPb3KhA=;

		// Token: 0x04000141 RID: 321
		private Dictionary<#=qXFlTUA3H$tLznDC7aWzu2zleUjFdjB9xfWZS2Uln5uk=, #=q7wAoj4Sa0JZMIpFCR0BzQj93e0auGhobfd8I14SPhiY=> #=zur7PLhI=;
	}
}
