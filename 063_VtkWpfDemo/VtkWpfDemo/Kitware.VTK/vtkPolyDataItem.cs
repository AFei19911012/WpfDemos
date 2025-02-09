using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataItem
/// </summary>
/// <remarks>
///    Filter that translate a vtkPolyData 2D mesh into vtkContextItems.
///
/// @warning
/// The input vtkPolyData should be a 2D mesh.
///
/// </remarks>
public class vtkPolyDataItem : vtkContextItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataItem()
	{
		MRClassNameKey = "class vtkPolyDataItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyDataItem New()
	{
		vtkPolyDataItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPolyDataItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyDataItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataItem_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataItem_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataItem_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataItem_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataItem_GetPolyData_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the image of the item.
	/// </summary>
	public virtual vtkPolyData GetPolyData()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataItem_GetPolyData_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataItem_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataItem_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataItem_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataItem_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataItem_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPolyDataItem NewInstance()
	{
		vtkPolyDataItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataItem_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataItem_Paint_08(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the item.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkPolyDataItem_Paint_08(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataItem_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyDataItem SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataItem vtkPolyDataItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataItem_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataItem2 = (vtkPolyDataItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataItem2.Register(null);
			}
		}
		return vtkPolyDataItem2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataItem_SetMappedColors_10(HandleRef pThis, HandleRef colors);

	/// <summary>
	/// Set mapped colors. User-selected scalars are mapped to a color lookup
	/// table externally.
	/// </summary>
	public void SetMappedColors(vtkUnsignedCharArray colors)
	{
		vtkPolyDataItem_SetMappedColors_10(GetCppThis(), colors?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataItem_SetPolyData_11(HandleRef pThis, HandleRef polyData);

	/// <summary>
	/// Set the PolyData of the item.
	/// </summary>
	public void SetPolyData(vtkPolyData polyData)
	{
		vtkPolyDataItem_SetPolyData_11(GetCppThis(), polyData?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataItem_SetPosition_12(HandleRef pThis, float _arg1, float _arg2);

	/// <summary>
	/// Set the position of the bottom corner of the image.
	/// </summary>
	public virtual void SetPosition(float _arg1, float _arg2)
	{
		vtkPolyDataItem_SetPosition_12(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataItem_SetPosition_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the position of the bottom corner of the image.
	/// </summary>
	public void SetPosition(IntPtr _arg)
	{
		vtkPolyDataItem_SetPosition_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataItem_SetScalarMode_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the data scalar mode.
	/// </summary>
	public virtual void SetScalarMode(int _arg)
	{
		vtkPolyDataItem_SetScalarMode_14(GetCppThis(), _arg);
	}
}
