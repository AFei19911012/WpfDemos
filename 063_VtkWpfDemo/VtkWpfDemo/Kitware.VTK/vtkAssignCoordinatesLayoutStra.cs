using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAssignCoordinatesLayoutStrategy
/// </summary>
/// <remarks>
///    uses array values to set vertex locations
///
///
/// Uses vtkAssignCoordinates to use values from arrays as the x, y, and z coordinates.
/// </remarks>
public class vtkAssignCoordinatesLayoutStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAssignCoordinatesLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAssignCoordinatesLayoutStrategy()
	{
		MRClassNameKey = "class vtkAssignCoordinatesLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssignCoordinatesLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAssignCoordinatesLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAssignCoordinatesLayoutStrategy New()
	{
		vtkAssignCoordinatesLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssignCoordinatesLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAssignCoordinatesLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAssignCoordinatesLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAssignCoordinatesLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkAssignCoordinatesLayoutStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAssignCoordinatesLayoutStrategy_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAssignCoordinatesLayoutStrategy_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAssignCoordinatesLayoutStrategy_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_GetXCoordArrayName_03(HandleRef pThis);

	/// <summary>
	/// The array to use for the x coordinate values.
	/// </summary>
	public virtual string GetXCoordArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAssignCoordinatesLayoutStrategy_GetXCoordArrayName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_GetYCoordArrayName_04(HandleRef pThis);

	/// <summary>
	/// The array to use for the y coordinate values.
	/// </summary>
	public virtual string GetYCoordArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAssignCoordinatesLayoutStrategy_GetYCoordArrayName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_GetZCoordArrayName_05(HandleRef pThis);

	/// <summary>
	/// The array to use for the z coordinate values.
	/// </summary>
	public virtual string GetZCoordArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAssignCoordinatesLayoutStrategy_GetZCoordArrayName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssignCoordinatesLayoutStrategy_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAssignCoordinatesLayoutStrategy_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssignCoordinatesLayoutStrategy_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAssignCoordinatesLayoutStrategy_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssignCoordinatesLayoutStrategy_Layout_08(HandleRef pThis);

	/// <summary>
	/// Perform the random layout.
	/// </summary>
	public override void Layout()
	{
		vtkAssignCoordinatesLayoutStrategy_Layout_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAssignCoordinatesLayoutStrategy NewInstance()
	{
		vtkAssignCoordinatesLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssignCoordinatesLayoutStrategy_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAssignCoordinatesLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAssignCoordinatesLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkAssignCoordinatesLayoutStrategy vtkAssignCoordinatesLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssignCoordinatesLayoutStrategy_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssignCoordinatesLayoutStrategy2 = (vtkAssignCoordinatesLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssignCoordinatesLayoutStrategy2.Register(null);
			}
		}
		return vtkAssignCoordinatesLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssignCoordinatesLayoutStrategy_SetXCoordArrayName_12(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for the x coordinate values.
	/// </summary>
	public virtual void SetXCoordArrayName(string name)
	{
		vtkAssignCoordinatesLayoutStrategy_SetXCoordArrayName_12(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssignCoordinatesLayoutStrategy_SetYCoordArrayName_13(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for the y coordinate values.
	/// </summary>
	public virtual void SetYCoordArrayName(string name)
	{
		vtkAssignCoordinatesLayoutStrategy_SetYCoordArrayName_13(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssignCoordinatesLayoutStrategy_SetZCoordArrayName_14(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for the z coordinate values.
	/// </summary>
	public virtual void SetZCoordArrayName(string name)
	{
		vtkAssignCoordinatesLayoutStrategy_SetZCoordArrayName_14(GetCppThis(), name);
	}
}
