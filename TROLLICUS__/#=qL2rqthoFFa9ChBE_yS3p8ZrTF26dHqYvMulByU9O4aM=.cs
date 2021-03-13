using System;
using System.Collections.Generic;
using System.Reflection;

namespace TROLLICUS__
{
	// Token: 0x0200004C RID: 76
	internal static class #=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=
	{
		// Token: 0x06000189 RID: 393 RVA: 0x0000A024 File Offset: 0x00008224
		// Note: this type is marked as 'beforefieldinit'.
		static #=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=()
		{
			Type typeFromHandle = typeof(object);
			if (3 != 0)
			{
				#=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=.#=zBPb3KhA= = typeFromHandle;
			}
			Type typeFromHandle2 = typeof(ValueType);
			if (6 != 0)
			{
				#=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=.#=zur7PLhI= = typeFromHandle2;
			}
			Type typeFromHandle3 = typeof(Enum);
			if (3 != 0)
			{
				#=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=.#=zBkMjrJ4= = typeFromHandle3;
			}
			#=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=.#=zt$cqECc= = typeof(Nullable<>);
			#=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=.#=zfbJ$RjA= = typeof(void);
			#=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=.#=zAWZgy3A= = typeof(#=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=).Assembly;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000A0A4 File Offset: 0x000082A4
		public static bool #=zspGfiphFCcfwMLzSbF38x5U=(Type #=zBPb3KhA=)
		{
			if (7 == 0)
			{
			}
			if (#=zBPb3KhA=.IsGenericType)
			{
				if (5 == 0)
				{
				}
				if (!#=zBPb3KhA=.IsGenericTypeDefinition)
				{
					if (4 == 0)
					{
					}
					return #=zBPb3KhA=.GetGenericTypeDefinition() == #=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=.#=zt$cqECc=;
				}
			}
			return false;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000A0F0 File Offset: 0x000082F0
		public static Type #=zz95_ESrqQKmW6zDWw2dRjMmxQbzmKH3dVg==(Type #=zBPb3KhA=)
		{
			while (#=zBPb3KhA=.HasElementType)
			{
				Type elementType = #=zBPb3KhA=.GetElementType();
				if (!false)
				{
					#=zBPb3KhA= = elementType;
				}
			}
			return #=zBPb3KhA=;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000A11C File Offset: 0x0000831C
		public static Type #=z2TNmO$GCJVcUC_mMX8KbwwvfJ2RM$$ghsSklhNk=(Type #=zBPb3KhA=)
		{
			if (#=zBPb3KhA=.HasElementType && !#=zBPb3KhA=.IsArray)
			{
				Type elementType = #=zBPb3KhA=.GetElementType();
				if (3 != 0)
				{
					#=zBPb3KhA= = elementType;
				}
			}
			return #=zBPb3KhA=;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000A14C File Offset: 0x0000834C
		public static Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> #=zF4ZZZ$7ZLjF0HDVGXzhR1Y1cq0rt7HArVVRh3e0=(Type #=zBPb3KhA=)
		{
			Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> stack = new Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=>();
			Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> stack2;
			if (2 != 0)
			{
				stack2 = stack;
			}
			Type type;
			if (2 != 0)
			{
				type = #=zBPb3KhA=;
			}
			for (;;)
			{
				if (type.IsArray)
				{
					Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> stack3 = stack2;
					#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM= item = default(#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=);
					int num = 2;
					if (true)
					{
						item.#=zBPb3KhA= = num;
					}
					item.#=zur7PLhI= = type.GetArrayRank();
					stack3.Push(item);
				}
				else if (type.IsByRef)
				{
					Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> stack4 = stack2;
					#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM= item = new #=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=
					{
						#=zBPb3KhA= = 0
					};
					stack4.Push(item);
				}
				else
				{
					if (!type.IsPointer)
					{
						break;
					}
					Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> stack5 = stack2;
					#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM= item = new #=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=
					{
						#=zBPb3KhA= = 1
					};
					stack5.Push(item);
				}
				type = type.GetElementType();
			}
			return stack2;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000A1F4 File Offset: 0x000083F4
		public static Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> #=z1BsxnY8px1eTfEvvk0EG3A382R9B(string #=zBPb3KhA=)
		{
			string text;
			if (2 != 0)
			{
				text = #=zBPb3KhA=;
			}
			Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> stack = new Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=>();
			Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> stack2;
			if (4 != 0)
			{
				stack2 = stack;
			}
			for (;;)
			{
				if (text.EndsWith(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976707387), StringComparison.Ordinal))
				{
					Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> stack3 = stack2;
					#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM= item = default(#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=);
					int num = 0;
					if (3 != 0)
					{
						item.#=zBPb3KhA= = num;
					}
					stack3.Push(item);
					string text2 = text.Substring(0, text.Length - 1);
					if (5 != 0)
					{
						text = text2;
					}
				}
				else if (text.EndsWith(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976707363), StringComparison.Ordinal))
				{
					Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> stack4 = stack2;
					#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM= item = new #=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=
					{
						#=zBPb3KhA= = 1
					};
					stack4.Push(item);
					text = text.Substring(0, text.Length - 1);
				}
				else if (text.EndsWith(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976707371), StringComparison.Ordinal))
				{
					Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> stack5 = stack2;
					#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM= item = new #=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=
					{
						#=zBPb3KhA= = 2,
						#=zur7PLhI= = 1
					};
					stack5.Push(item);
					text = text.Substring(0, text.Length - 2);
				}
				else
				{
					if (!text.EndsWith(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976707344), StringComparison.Ordinal))
					{
						return stack2;
					}
					int num2 = 1;
					int num3 = -1;
					for (int i = text.Length - 2; i >= 0; i--)
					{
						char c = text[i];
						if (c != ',')
						{
							if (c != '[')
							{
								goto Block_7;
							}
							num3 = i;
							i = -1;
						}
						else
						{
							num2++;
						}
					}
					if (num3 < 0)
					{
						goto Block_9;
					}
					text = text.Substring(0, num3);
					Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> stack6 = stack2;
					#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM= item = new #=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=
					{
						#=zBPb3KhA= = 2,
						#=zur7PLhI= = num2
					};
					stack6.Push(item);
				}
			}
			Block_7:
			throw new InvalidOperationException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976707353));
			Block_9:
			throw new InvalidOperationException(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976707339));
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000A390 File Offset: 0x00008590
		public static Type #=zESdg_77Dp2fEZFnB2Bzx_X6Ntqq_FM5g2or6mEs=(Type #=zBPb3KhA=, Stack<#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=> #=zur7PLhI=)
		{
			Type type;
			if (6 != 0)
			{
				type = #=zBPb3KhA=;
			}
			while (#=zur7PLhI=.Count > 0)
			{
				#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM= #=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM= = #=zur7PLhI=.Pop();
				#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM= #=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=2;
				if (2 != 0)
				{
					#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=2 = #=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=;
				}
				int num = #=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=2.#=zBPb3KhA=;
				int num2;
				if (3 != 0)
				{
					num2 = num;
				}
				switch (num2)
				{
				case 0:
					type = type.MakeByRefType();
					break;
				case 1:
					type = type.MakePointerType();
					break;
				case 2:
					if (#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=2.#=zur7PLhI= == 1)
					{
						type = type.MakeArrayType();
					}
					else
					{
						type = type.MakeArrayType(#=qLQ1Tr8sC3DsxefDYO2wzMVZMi5sS604Ky2s3WXsUDlM=2.#=zur7PLhI=);
					}
					break;
				}
			}
			return type;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000A418 File Offset: 0x00008618
		public static int #=zMLzlNj07QtdRcx_104U1cxwC_RIw(Type #=zBPb3KhA=)
		{
			Dictionary<Type, int> dictionary = #=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=.#=zBPb3KhA=.#=zBPb3KhA=;
			if (3 == 0)
			{
			}
			int num;
			if (dictionary.TryGetValue(#=zBPb3KhA=, out num))
			{
				int result = num;
				if (8 == 0)
				{
				}
				return result;
			}
			if (3 == 0)
			{
			}
			if (#=zBPb3KhA=.IsArray)
			{
				return 25;
			}
			if (!#=zBPb3KhA=.IsValueType)
			{
				return 8;
			}
			if (#=zBPb3KhA=.IsSubclassOf(#=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=.#=zBkMjrJ4=))
			{
				return 23;
			}
			if (#=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=.#=zspGfiphFCcfwMLzSbF38x5U=(#=zBPb3KhA=))
			{
				return 13;
			}
			return 6;
		}

		// Token: 0x040000B6 RID: 182
		public static readonly Type #=zBPb3KhA=;

		// Token: 0x040000B7 RID: 183
		public static readonly Type #=zur7PLhI=;

		// Token: 0x040000B8 RID: 184
		public static readonly Type #=zBkMjrJ4=;

		// Token: 0x040000B9 RID: 185
		public static readonly Type #=zt$cqECc=;

		// Token: 0x040000BA RID: 186
		public static readonly Type #=zfbJ$RjA=;

		// Token: 0x040000BB RID: 187
		public static readonly Assembly #=zAWZgy3A=;

		// Token: 0x0200004D RID: 77
		private static class #=zBPb3KhA=
		{
			// Token: 0x06000191 RID: 401 RVA: 0x0000A488 File Offset: 0x00008688
			// Note: this type is marked as 'beforefieldinit'.
			static #=zBPb3KhA=()
			{
				Dictionary<Type, int> dictionary = new Dictionary<Type, int>();
				dictionary.Add(typeof(object), 14);
				dictionary.Add(typeof(byte), 10);
				dictionary.Add(typeof(sbyte), 1);
				dictionary.Add(typeof(short), 20);
				dictionary.Add(typeof(int), 21);
				dictionary.Add(typeof(long), 7);
				dictionary.Add(typeof(ushort), 0);
				dictionary.Add(typeof(uint), 19);
				dictionary.Add(typeof(ulong), 16);
				dictionary.Add(typeof(IntPtr), 12);
				dictionary.Add(typeof(UIntPtr), 11);
				dictionary.Add(typeof(float), 26);
				dictionary.Add(typeof(double), 18);
				dictionary.Add(typeof(bool), 5);
				dictionary.Add(typeof(char), 9);
				dictionary.Add(typeof(string), 3);
				if (!false)
				{
					#=qL2rqthoFFa9ChBE_yS3p8ZrTF26dHqYvMulByU9O4aM=.#=zBPb3KhA=.#=zBPb3KhA= = dictionary;
				}
			}

			// Token: 0x040000BC RID: 188
			public static readonly Dictionary<Type, int> #=zBPb3KhA=;
		}
	}
}
