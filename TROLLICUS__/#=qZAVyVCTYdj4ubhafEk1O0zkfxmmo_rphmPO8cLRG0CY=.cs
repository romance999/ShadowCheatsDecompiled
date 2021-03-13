using System;

namespace TROLLICUS__
{
	// Token: 0x0200008F RID: 143
	internal static class #=qZAVyVCTYdj4ubhafEk1O0zkfxmmo_rphmPO8cLRG0CY=
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x0001D1D4 File Offset: 0x0001B3D4
		public static bool #=zoyRfdHuxtPUNvgj0gx7j$37Nkv1eI3kgEg==(Type #=zBPb3KhA=, Type #=zur7PLhI=, out int #=zBkMjrJ4=)
		{
			#=zBkMjrJ4= = 0;
			if (#=zBPb3KhA= == #=zur7PLhI=)
			{
				#=zBkMjrJ4= = 1;
				return true;
			}
			if (#=zBPb3KhA= == null || #=zur7PLhI= == null)
			{
				return false;
			}
			if (#=zBPb3KhA=.IsByRef)
			{
				return #=zur7PLhI=.IsByRef && #=qZAVyVCTYdj4ubhafEk1O0zkfxmmo_rphmPO8cLRG0CY=.#=zoyRfdHuxtPUNvgj0gx7j$37Nkv1eI3kgEg==(#=zBPb3KhA=.GetElementType(), #=zur7PLhI=.GetElementType(), out #=zBkMjrJ4=);
			}
			if (#=zur7PLhI=.IsByRef)
			{
				return false;
			}
			if (#=zBPb3KhA=.IsPointer)
			{
				return #=zur7PLhI=.IsPointer && #=qZAVyVCTYdj4ubhafEk1O0zkfxmmo_rphmPO8cLRG0CY=.#=zoyRfdHuxtPUNvgj0gx7j$37Nkv1eI3kgEg==(#=zBPb3KhA=.GetElementType(), #=zur7PLhI=.GetElementType(), out #=zBkMjrJ4=);
			}
			if (#=zur7PLhI=.IsPointer)
			{
				return false;
			}
			if (#=zBPb3KhA=.IsArray)
			{
				return #=zur7PLhI=.IsArray && #=zBPb3KhA=.GetArrayRank() == #=zur7PLhI=.GetArrayRank() && #=qZAVyVCTYdj4ubhafEk1O0zkfxmmo_rphmPO8cLRG0CY=.#=zoyRfdHuxtPUNvgj0gx7j$37Nkv1eI3kgEg==(#=zBPb3KhA=.GetElementType(), #=zur7PLhI=.GetElementType(), out #=zBkMjrJ4=);
			}
			if (#=zur7PLhI=.IsArray)
			{
				return false;
			}
			if (#=zBPb3KhA=.IsGenericType != #=zur7PLhI=.IsGenericType)
			{
				return false;
			}
			if (#=zBPb3KhA=.IsGenericType)
			{
				Type type = #=zBPb3KhA=.IsGenericTypeDefinition ? #=zBPb3KhA= : #=zBPb3KhA=.GetGenericTypeDefinition();
				Type type2 = #=zur7PLhI=.IsGenericTypeDefinition ? #=zur7PLhI= : #=zur7PLhI=.GetGenericTypeDefinition();
				Type type3;
				if (true)
				{
					type3 = type2;
				}
				if (type != type3)
				{
					return false;
				}
				Type[] genericArguments = #=zBPb3KhA=.GetGenericArguments();
				Type[] array;
				if (2 != 0)
				{
					array = genericArguments;
				}
				Type[] genericArguments2 = #=zur7PLhI=.GetGenericArguments();
				Type[] array2;
				if (2 != 0)
				{
					array2 = genericArguments2;
				}
				if (array.Length != array2.Length)
				{
					return false;
				}
				int num = 0;
				int i;
				if (7 != 0)
				{
					i = num;
				}
				while (i < array.Length)
				{
					int num2;
					if (#=qZAVyVCTYdj4ubhafEk1O0zkfxmmo_rphmPO8cLRG0CY=.#=zoyRfdHuxtPUNvgj0gx7j$37Nkv1eI3kgEg==(array[i], array2[i], out num2))
					{
						#=zBkMjrJ4= += num2;
					}
					int num3 = i + 1;
					if (true)
					{
						i = num3;
					}
				}
			}
			else if (#=zBPb3KhA= != #=zur7PLhI=)
			{
				return false;
			}
			#=zBkMjrJ4=++;
			return true;
		}
	}
}
