using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGraphGeodesicPath
/// </summary>
/// <remarks>
///    Abstract base for classes that generate a geodesic path on a graph (mesh).
///
/// Serves as a base class for algorithms that trace a geodesic on a
/// polygonal dataset treating it as a graph. ie points connecting the
/// vertices of the graph
/// </remarks>
public class vtkGraphGeodesicPath : vtkGeodesicPath
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGraphGeodesicPath";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGraphGeodesicPath()
	{
		MRClassNameKey = "class vtkGraphGeodesicPath";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphGeodesicPath"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGraphGeodesicPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphGeodesicPath_GetEndVertex_01(HandleRef pThis);

	/// <summary>
	/// The vertex at the end of the shortest path
	/// </summary>
	public virtual long GetEndVertex()
	{
		return vtkGraphGeodesicPath_GetEndVertex_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphGeodesicPath_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGraphGeodesicPath_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphGeodesicPath_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGraphGeodesicPath_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphGeodesicPath_GetStartVertex_04(HandleRef pThis);

	/// <summary>
	/// The vertex at the start of the shortest path
	/// </summary>
	public virtual long GetStartVertex()
	{
		return vtkGraphGeodesicPath_GetStartVertex_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphGeodesicPath_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGraphGeodesicPath_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphGeodesicPath_IsTypeOf_06(string type);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGraphGeodesicPath_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphGeodesicPath_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public new vtkGraphGeodesicPath NewInstance()
	{
		vtkGraphGeodesicPath result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphGeodesicPath_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphGeodesicPath_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public new static vtkGraphGeodesicPath SafeDownCast(vtkObjectBase o)
	{
		vtkGraphGeodesicPath vtkGraphGeodesicPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphGeodesicPath_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphGeodesicPath2 = (vtkGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphGeodesicPath2.Register(null);
			}
		}
		return vtkGraphGeodesicPath2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphGeodesicPath_SetEndVertex_09(HandleRef pThis, long _arg);

	/// <summary>
	/// The vertex at the end of the shortest path
	/// </summary>
	public virtual void SetEndVertex(long _arg)
	{
		vtkGraphGeodesicPath_SetEndVertex_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphGeodesicPath_SetStartVertex_10(HandleRef pThis, long _arg);

	/// <summary>
	/// The vertex at the start of the shortest path
	/// </summary>
	public virtual void SetStartVertex(long _arg)
	{
		vtkGraphGeodesicPath_SetStartVertex_10(GetCppThis(), _arg);
	}
}
