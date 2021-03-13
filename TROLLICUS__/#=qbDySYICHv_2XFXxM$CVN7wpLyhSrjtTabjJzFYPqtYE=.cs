using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace TROLLICUS__
{
	// Token: 0x02000092 RID: 146
	internal static class #=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=
	{
		// Token: 0x06000491 RID: 1169 RVA: 0x0001D460 File Offset: 0x0001B660
		static #=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=()
		{
			Assembly assembly = typeof(#=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=).Assembly;
			if (4 != 0)
			{
				#=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zonAH8e2OwvoYWstWIap38aQftoFy = assembly;
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000024C8 File Offset: 0x000006C8
		internal static void #=zC$cvsu0=()
		{
			AppDomain.CurrentDomain.ResourceResolve += #=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=z9LrDvjiWS0zj41tJBBXHRcIn$4vQ;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0001D48C File Offset: 0x0001B68C
		private static Assembly #=z9LrDvjiWS0zj41tJBBXHRcIn$4vQ(object #=zN6DQMd18z7YMPy4BYxdOJfUweHbZ, ResolveEventArgs #=z3fgCI5a7DSNn_3fPKMLoHXk=)
		{
			if (#=z3fgCI5a7DSNn_3fPKMLoHXk=.RequestingAssembly != #=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zonAH8e2OwvoYWstWIap38aQftoFy)
			{
				return null;
			}
			if (4 != 0)
			{
				#=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zpnP1STPkoo2huYLerSQFhp5NSS_p();
			}
			#=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zPOKbr_uYP5Te1zHJYY__YuMWWH5J #=zPOKbr_uYP5Te1zHJYY__YuMWWH5J;
			if (!#=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zcSEB1FmuyB4x1ZV2ocygD5GRJguj.TryGetValue(#=z3fgCI5a7DSNn_3fPKMLoHXk=.Name, out #=zPOKbr_uYP5Te1zHJYY__YuMWWH5J))
			{
				return null;
			}
			return #=zPOKbr_uYP5Te1zHJYY__YuMWWH5J.#=zg96sMr$SvbqQslUSuEn6m5gnIAox();
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0001D4D4 File Offset: 0x0001B6D4
		private static void #=zpnP1STPkoo2huYLerSQFhp5NSS_p()
		{
			if (#=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zcSEB1FmuyB4x1ZV2ocygD5GRJguj == null)
			{
				Assembly assembly = #=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zonAH8e2OwvoYWstWIap38aQftoFy;
				Assembly assembly2;
				if (7 != 0)
				{
					assembly2 = assembly;
				}
				object obj = assembly2;
				if (2 != 0)
				{
					Monitor.Enter(obj);
				}
				try
				{
					if (#=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zcSEB1FmuyB4x1ZV2ocygD5GRJguj == null)
					{
						string text = #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976712757);
						string text2;
						if (2 != 0)
						{
							text2 = text;
						}
						string[] array = text2.Split(new char[]
						{
							':'
						});
						int num = array.Length;
						Dictionary<string, #=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zPOKbr_uYP5Te1zHJYY__YuMWWH5J> dictionary = new Dictionary<string, #=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zPOKbr_uYP5Te1zHJYY__YuMWWH5J>(1, StringComparer.Ordinal);
						for (int num2 = 0; num2 != num; num2++)
						{
							string text3 = array[num2];
							string[] array2 = text3.Split(new char[]
							{
								'|'
							});
							#=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zPOKbr_uYP5Te1zHJYY__YuMWWH5J value = new #=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zPOKbr_uYP5Te1zHJYY__YuMWWH5J(array2[0]);
							int num3 = array2.Length;
							for (int num4 = 1; num4 != num3; num4++)
							{
								string key = array2[num4];
								dictionary.Add(key, value);
							}
						}
						#=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zcSEB1FmuyB4x1ZV2ocygD5GRJguj = dictionary;
					}
				}
				finally
				{
					Monitor.Exit(assembly2);
				}
			}
		}

		// Token: 0x04000143 RID: 323
		private static readonly Assembly #=zonAH8e2OwvoYWstWIap38aQftoFy;

		// Token: 0x04000144 RID: 324
		private static volatile Dictionary<string, #=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zPOKbr_uYP5Te1zHJYY__YuMWWH5J> #=zcSEB1FmuyB4x1ZV2ocygD5GRJguj;

		// Token: 0x02000093 RID: 147
		private sealed class #=zPOKbr_uYP5Te1zHJYY__YuMWWH5J
		{
			// Token: 0x06000495 RID: 1173 RVA: 0x0001D5C0 File Offset: 0x0001B7C0
			internal #=zPOKbr_uYP5Te1zHJYY__YuMWWH5J(string #=zg7Ef73DMygOxWGjzBlt$OFouH8ZH)
			{
				if (8 != 0)
				{
					this.#=zuN3lrb2PnvFFn00EFF8zd1cAnk13 = #=zg7Ef73DMygOxWGjzBlt$OFouH8ZH;
				}
			}

			// Token: 0x06000496 RID: 1174 RVA: 0x0001D5E4 File Offset: 0x0001B7E4
			internal Assembly #=zg96sMr$SvbqQslUSuEn6m5gnIAox()
			{
				if (this.#=zonAH8e2OwvoYWstWIap38aQftoFy == null)
				{
					if (2 == 0)
					{
					}
					object obj = this;
					if (2 != 0)
					{
						Monitor.Enter(obj);
					}
					try
					{
						if (this.#=zonAH8e2OwvoYWstWIap38aQftoFy == null)
						{
							this.#=zonAH8e2OwvoYWstWIap38aQftoFy = #=qbDySYICHv_2XFXxM$CVN7wpLyhSrjtTabjJzFYPqtYE=.#=zPOKbr_uYP5Te1zHJYY__YuMWWH5J.#=z7fWnxnS5y2dY7wnp51pyl9DTWoN9(this.#=zuN3lrb2PnvFFn00EFF8zd1cAnk13);
						}
					}
					finally
					{
						if (4 != 0)
						{
							Monitor.Exit(this);
						}
					}
				}
				return this.#=zonAH8e2OwvoYWstWIap38aQftoFy;
			}

			// Token: 0x06000497 RID: 1175 RVA: 0x0001D658 File Offset: 0x0001B858
			private static Assembly #=z7fWnxnS5y2dY7wnp51pyl9DTWoN9(string #=znEfePdbrgXL9tkn9pSBqpwHPFLuv)
			{
				if (3 == 0)
				{
				}
				Assembly result;
				if ((result = #=qBvpXrtWoqxtthiYSAEVi8xZLetusHm9ONc3eCfNDzNM=.#=zBPb3KhA=(#=znEfePdbrgXL9tkn9pSBqpwHPFLuv)) == null)
				{
					if (-1 == 0)
					{
					}
					if (7 == 0)
					{
					}
					result = Assembly.Load(#=znEfePdbrgXL9tkn9pSBqpwHPFLuv);
				}
				return result;
			}

			// Token: 0x04000145 RID: 325
			private readonly string #=zuN3lrb2PnvFFn00EFF8zd1cAnk13;

			// Token: 0x04000146 RID: 326
			private volatile Assembly #=zonAH8e2OwvoYWstWIap38aQftoFy;
		}
	}
}
