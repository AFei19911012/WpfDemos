using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPropItem
/// </summary>
/// <remarks>
///    Embed a vtkProp in a vtkContextScene.
///
///
/// This class allows vtkProp objects to be drawn inside a vtkContextScene.
/// This is especially useful for constructing layered scenes that need to ignore
/// depth testing.
/// </remarks>
public class vtkPropItem : vtkAbstractContextItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPropItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPropItem()
	{
		MRClassNameKey = "class vtkPropItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPropItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPropItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPropItem New()
	{
		vtkPropItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPropItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPropItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPropItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPropItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPropItem_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPropItem_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPropItem_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPropItem_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropItem_GetPropObject_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The actor to render.
	/// </summary>
	public virtual vtkProp GetPropObject()
	{
		vtkProp vtkProp2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPropItem_GetPropObject_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp2 = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp2.Register(null);
			}
		}
		return vtkProp2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropItem_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPropItem_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropItem_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPropItem_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropItem_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPropItem NewInstance()
	{
		vtkPropItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPropItem_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPropItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPropItem_Paint_08(HandleRef pThis, HandleRef painter);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkPropItem_Paint_08(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPropItem_ReleaseGraphicsResources_09(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void ReleaseGraphicsResources()
	{
		vtkPropItem_ReleaseGraphicsResources_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropItem_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPropItem SafeDownCast(vtkObjectBase o)
	{
		vtkPropItem vtkPropItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPropItem_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPropItem2 = (vtkPropItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPropItem2.Register(null);
			}
		}
		return vtkPropItem2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPropItem_SetPropObject_11(HandleRef pThis, HandleRef PropObject);

	/// <summary>
	/// The actor to render.
	/// </summary>
	public virtual void SetPropObject(vtkProp PropObject)
	{
		vtkPropItem_SetPropObject_11(GetCppThis(), PropObject?.GetCppThis() ?? default(HandleRef));
	}
}
