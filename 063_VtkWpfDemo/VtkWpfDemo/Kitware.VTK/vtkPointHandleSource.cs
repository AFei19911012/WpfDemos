using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointHandleSource
/// </summary>
/// <remarks>
///    handle source used to represent points.
///
/// vtkPointHandleSource is deriving vtkHandleSource interface.
/// This handle represents a point with its shape being a sphere.
/// Its center and radius can be modified.
/// If the point is also parametered by any direction, it is then
/// represented as a cone pointing in this direction.
/// </remarks>
public class vtkPointHandleSource : vtkHandleSource
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointHandleSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointHandleSource()
	{
		MRClassNameKey = "class vtkPointHandleSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointHandleSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointHandleSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointHandleSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPointHandleSource New()
	{
		vtkPointHandleSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointHandleSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointHandleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPointHandleSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointHandleSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointHandleSource_GetDirection_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the direction of the handle.
	/// The direction is used in case the handle is
	/// represented as a cone (when this-&gt;Directional = true).
	/// The default direction is (1,0,0).
	/// </summary>
	public override IntPtr GetDirection()
	{
		return vtkPointHandleSource_GetDirection_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointHandleSource_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointHandleSource_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointHandleSource_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointHandleSource_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointHandleSource_GetPosition_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the handle.
	/// The default position is (0,0,0).
	/// </summary>
	public override IntPtr GetPosition()
	{
		return vtkPointHandleSource_GetPosition_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleSource_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointHandleSource_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleSource_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointHandleSource_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointHandleSource_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPointHandleSource NewInstance()
	{
		vtkPointHandleSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointHandleSource_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointHandleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointHandleSource_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPointHandleSource SafeDownCast(vtkObjectBase o)
	{
		vtkPointHandleSource vtkPointHandleSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointHandleSource_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointHandleSource2 = (vtkPointHandleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointHandleSource2.Register(null);
			}
		}
		return vtkPointHandleSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleSource_SetDirection_10(HandleRef pThis, double xDir, double yDir, double zDir);

	/// <summary>
	/// Set/Get the direction of the handle.
	/// The direction is used in case the handle is
	/// represented as a cone (when this-&gt;Directional = true).
	/// The default direction is (1,0,0).
	/// </summary>
	public override void SetDirection(double xDir, double yDir, double zDir)
	{
		vtkPointHandleSource_SetDirection_10(GetCppThis(), xDir, yDir, zDir);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleSource_SetPosition_11(HandleRef pThis, double xPos, double yPos, double zPos);

	/// <summary>
	/// Set/Get the position of the handle.
	/// The default position is (0,0,0).
	/// </summary>
	public override void SetPosition(double xPos, double yPos, double zPos)
	{
		vtkPointHandleSource_SetPosition_11(GetCppThis(), xPos, yPos, zPos);
	}
}
