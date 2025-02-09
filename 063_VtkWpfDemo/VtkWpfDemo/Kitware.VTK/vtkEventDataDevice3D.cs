using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <remarks>
///    platform-independent event data structures
/// </remarks>
public class vtkEventDataDevice3D : vtkEventDataForDevice
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEventDataDevice3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEventDataDevice3D()
	{
		MRClassNameKey = "class vtkEventDataDevice3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEventDataDevice3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEventDataDevice3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEventDataDevice3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEventDataDevice3D New()
	{
		vtkEventDataDevice3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEventDataDevice3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEventDataDevice3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkEventDataDevice3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEventDataDevice3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEventDataDevice3D_GetAsEventDataDevice3D_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override vtkEventDataDevice3D GetAsEventDataDevice3D()
	{
		vtkEventDataDevice3D vtkEventDataDevice3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEventDataDevice3D_GetAsEventDataDevice3D_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEventDataDevice3D2 = (vtkEventDataDevice3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEventDataDevice3D2.Register(null);
			}
		}
		return vtkEventDataDevice3D2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEventDataDevice3D_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEventDataDevice3D_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEventDataDevice3D_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEventDataDevice3D_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEventDataDevice3D_GetTrackPadPosition_04(HandleRef pThis, IntPtr v);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void GetTrackPadPosition(IntPtr v)
	{
		vtkEventDataDevice3D_GetTrackPadPosition_04(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEventDataDevice3D_GetTrackPadPosition_05(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public IntPtr GetTrackPadPosition()
	{
		return vtkEventDataDevice3D_GetTrackPadPosition_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEventDataDevice3D_GetWorldDirection_06(HandleRef pThis, IntPtr v);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void GetWorldDirection(IntPtr v)
	{
		vtkEventDataDevice3D_GetWorldDirection_06(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEventDataDevice3D_GetWorldDirection_07(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public IntPtr GetWorldDirection()
	{
		return vtkEventDataDevice3D_GetWorldDirection_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEventDataDevice3D_GetWorldOrientation_08(HandleRef pThis, IntPtr v);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void GetWorldOrientation(IntPtr v)
	{
		vtkEventDataDevice3D_GetWorldOrientation_08(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEventDataDevice3D_GetWorldOrientation_09(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public IntPtr GetWorldOrientation()
	{
		return vtkEventDataDevice3D_GetWorldOrientation_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEventDataDevice3D_GetWorldPosition_10(HandleRef pThis, IntPtr v);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void GetWorldPosition(IntPtr v)
	{
		vtkEventDataDevice3D_GetWorldPosition_10(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEventDataDevice3D_GetWorldPosition_11(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public IntPtr GetWorldPosition()
	{
		return vtkEventDataDevice3D_GetWorldPosition_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEventDataDevice3D_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEventDataDevice3D_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEventDataDevice3D_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEventDataDevice3D_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEventDataDevice3D_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEventDataDevice3D NewInstance()
	{
		vtkEventDataDevice3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEventDataDevice3D_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEventDataDevice3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEventDataDevice3D_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEventDataDevice3D SafeDownCast(vtkObjectBase o)
	{
		vtkEventDataDevice3D vtkEventDataDevice3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEventDataDevice3D_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEventDataDevice3D2 = (vtkEventDataDevice3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEventDataDevice3D2.Register(null);
			}
		}
		return vtkEventDataDevice3D2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEventDataDevice3D_SetTrackPadPosition_17(HandleRef pThis, IntPtr p);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetTrackPadPosition(IntPtr p)
	{
		vtkEventDataDevice3D_SetTrackPadPosition_17(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEventDataDevice3D_SetTrackPadPosition_18(HandleRef pThis, double x, double y);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetTrackPadPosition(double x, double y)
	{
		vtkEventDataDevice3D_SetTrackPadPosition_18(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEventDataDevice3D_SetWorldDirection_19(HandleRef pThis, IntPtr p);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetWorldDirection(IntPtr p)
	{
		vtkEventDataDevice3D_SetWorldDirection_19(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEventDataDevice3D_SetWorldOrientation_20(HandleRef pThis, IntPtr p);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetWorldOrientation(IntPtr p)
	{
		vtkEventDataDevice3D_SetWorldOrientation_20(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEventDataDevice3D_SetWorldPosition_21(HandleRef pThis, IntPtr p);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetWorldPosition(IntPtr p)
	{
		vtkEventDataDevice3D_SetWorldPosition_21(GetCppThis(), p);
	}
}
