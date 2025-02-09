using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAssignCoordinates
/// </summary>
/// <remarks>
///    Given two(or three) arrays take the values
/// in those arrays and simply assign them to the coordinates of the vertices.
///
///
/// Given two(or three) arrays take the values in those arrays and simply assign
/// them to the coordinates of the vertices. Yes you could do this with the array
/// calculator, but your mom wears army boots so we're not going to.
/// </remarks>
public class vtkAssignCoordinates : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAssignCoordinates";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAssignCoordinates()
	{
		MRClassNameKey = "class vtkAssignCoordinates";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssignCoordinates"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAssignCoordinates(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignCoordinates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAssignCoordinates New()
	{
		vtkAssignCoordinates result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssignCoordinates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAssignCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAssignCoordinates()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAssignCoordinates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAssignCoordinates_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAssignCoordinates_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAssignCoordinates_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAssignCoordinates_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignCoordinates_GetXCoordArrayName_03(HandleRef pThis);

	/// <summary>
	/// Set the x coordinate array name.
	/// </summary>
	public virtual string GetXCoordArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAssignCoordinates_GetXCoordArrayName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignCoordinates_GetYCoordArrayName_04(HandleRef pThis);

	/// <summary>
	/// Set the y coordinate array name.
	/// </summary>
	public virtual string GetYCoordArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAssignCoordinates_GetYCoordArrayName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignCoordinates_GetZCoordArrayName_05(HandleRef pThis);

	/// <summary>
	/// Set the z coordinate array name.
	/// </summary>
	public virtual string GetZCoordArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAssignCoordinates_GetZCoordArrayName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssignCoordinates_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAssignCoordinates_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssignCoordinates_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAssignCoordinates_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignCoordinates_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAssignCoordinates NewInstance()
	{
		vtkAssignCoordinates result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssignCoordinates_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAssignCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignCoordinates_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAssignCoordinates SafeDownCast(vtkObjectBase o)
	{
		vtkAssignCoordinates vtkAssignCoordinates2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssignCoordinates_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssignCoordinates2 = (vtkAssignCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssignCoordinates2.Register(null);
			}
		}
		return vtkAssignCoordinates2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssignCoordinates_SetJitter_11(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set if you want a random jitter
	/// </summary>
	public virtual void SetJitter(bool _arg)
	{
		vtkAssignCoordinates_SetJitter_11(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssignCoordinates_SetXCoordArrayName_12(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the x coordinate array name.
	/// </summary>
	public virtual void SetXCoordArrayName(string _arg)
	{
		vtkAssignCoordinates_SetXCoordArrayName_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssignCoordinates_SetYCoordArrayName_13(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the y coordinate array name.
	/// </summary>
	public virtual void SetYCoordArrayName(string _arg)
	{
		vtkAssignCoordinates_SetYCoordArrayName_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssignCoordinates_SetZCoordArrayName_14(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the z coordinate array name.
	/// </summary>
	public virtual void SetZCoordArrayName(string _arg)
	{
		vtkAssignCoordinates_SetZCoordArrayName_14(GetCppThis(), _arg);
	}
}
