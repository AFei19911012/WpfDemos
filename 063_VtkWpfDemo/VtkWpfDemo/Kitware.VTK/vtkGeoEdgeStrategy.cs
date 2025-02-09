using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGeoEdgeStrategy
/// </summary>
/// <remarks>
///    Layout graph edges on a globe as arcs.
///
///
/// vtkGeoEdgeStrategy produces arcs for each edge in the input graph.
/// This is useful for viewing lines on a sphere (e.g. the earth).
/// The arcs may "jump" above the sphere's surface using ExplodeFactor.
/// </remarks>
public class vtkGeoEdgeStrategy : vtkEdgeLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGeoEdgeStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGeoEdgeStrategy()
	{
		MRClassNameKey = "class vtkGeoEdgeStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoEdgeStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGeoEdgeStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoEdgeStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGeoEdgeStrategy New()
	{
		vtkGeoEdgeStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeoEdgeStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeoEdgeStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGeoEdgeStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGeoEdgeStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkGeoEdgeStrategy_GetExplodeFactor_01(HandleRef pThis);

	/// <summary>
	/// Factor on which to "explode" the arcs away from the surface.
	/// A value of 0.0 keeps the values on the surface.
	/// Values larger than 0.0 push the arcs away from the surface by a distance
	/// proportional to the distance between the points.
	/// The default is 0.2.
	/// </summary>
	public virtual double GetExplodeFactor()
	{
		return vtkGeoEdgeStrategy_GetExplodeFactor_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGeoEdgeStrategy_GetGlobeRadius_02(HandleRef pThis);

	/// <summary>
	/// The base radius used to determine the earth's surface.
	/// Default is the earth's radius in meters.
	/// TODO: Change this to take in a vtkGeoTerrain to get altitude.
	/// </summary>
	public virtual double GetGlobeRadius()
	{
		return vtkGeoEdgeStrategy_GetGlobeRadius_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeoEdgeStrategy_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGeoEdgeStrategy_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeoEdgeStrategy_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGeoEdgeStrategy_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeoEdgeStrategy_GetNumberOfSubdivisions_05(HandleRef pThis);

	/// <summary>
	/// The number of subdivisions in the arc.
	/// The default is 20.
	/// </summary>
	public virtual int GetNumberOfSubdivisions()
	{
		return vtkGeoEdgeStrategy_GetNumberOfSubdivisions_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeoEdgeStrategy_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGeoEdgeStrategy_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeoEdgeStrategy_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGeoEdgeStrategy_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoEdgeStrategy_Layout_08(HandleRef pThis);

	/// <summary>
	/// Perform the layout.
	/// </summary>
	public override void Layout()
	{
		vtkGeoEdgeStrategy_Layout_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoEdgeStrategy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGeoEdgeStrategy NewInstance()
	{
		vtkGeoEdgeStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeoEdgeStrategy_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeoEdgeStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoEdgeStrategy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGeoEdgeStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkGeoEdgeStrategy vtkGeoEdgeStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeoEdgeStrategy_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGeoEdgeStrategy2 = (vtkGeoEdgeStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGeoEdgeStrategy2.Register(null);
			}
		}
		return vtkGeoEdgeStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoEdgeStrategy_SetExplodeFactor_12(HandleRef pThis, double _arg);

	/// <summary>
	/// Factor on which to "explode" the arcs away from the surface.
	/// A value of 0.0 keeps the values on the surface.
	/// Values larger than 0.0 push the arcs away from the surface by a distance
	/// proportional to the distance between the points.
	/// The default is 0.2.
	/// </summary>
	public virtual void SetExplodeFactor(double _arg)
	{
		vtkGeoEdgeStrategy_SetExplodeFactor_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoEdgeStrategy_SetGlobeRadius_13(HandleRef pThis, double _arg);

	/// <summary>
	/// The base radius used to determine the earth's surface.
	/// Default is the earth's radius in meters.
	/// TODO: Change this to take in a vtkGeoTerrain to get altitude.
	/// </summary>
	public virtual void SetGlobeRadius(double _arg)
	{
		vtkGeoEdgeStrategy_SetGlobeRadius_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoEdgeStrategy_SetNumberOfSubdivisions_14(HandleRef pThis, int _arg);

	/// <summary>
	/// The number of subdivisions in the arc.
	/// The default is 20.
	/// </summary>
	public virtual void SetNumberOfSubdivisions(int _arg)
	{
		vtkGeoEdgeStrategy_SetNumberOfSubdivisions_14(GetCppThis(), _arg);
	}
}
