using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEarthSource
/// </summary>
/// <remarks>
///    create the continents of the Earth as a sphere
///
/// vtkEarthSource creates a spherical rendering of the geographical shapes
/// of the major continents of the earth. The OnRatio determines
/// how much of the data is actually used. The radius defines the radius
/// of the sphere at which the continents are placed. Obtains data from
/// an embedded array of coordinates.
/// </remarks>
public class vtkEarthSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEarthSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEarthSource()
	{
		MRClassNameKey = "class vtkEarthSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEarthSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEarthSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEarthSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEarthSource New()
	{
		vtkEarthSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEarthSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEarthSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkEarthSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEarthSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEarthSource_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEarthSource_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEarthSource_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEarthSource_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEarthSource_GetOnRatio_03(HandleRef pThis);

	/// <summary>
	/// Turn on every nth entity. This controls how much detail the model
	/// will have. The maximum ratio is sixteen. (The smaller OnRatio, the more
	/// detail there is.)
	/// </summary>
	public virtual int GetOnRatio()
	{
		return vtkEarthSource_GetOnRatio_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEarthSource_GetOnRatioMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Turn on every nth entity. This controls how much detail the model
	/// will have. The maximum ratio is sixteen. (The smaller OnRatio, the more
	/// detail there is.)
	/// </summary>
	public virtual int GetOnRatioMaxValue()
	{
		return vtkEarthSource_GetOnRatioMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEarthSource_GetOnRatioMinValue_05(HandleRef pThis);

	/// <summary>
	/// Turn on every nth entity. This controls how much detail the model
	/// will have. The maximum ratio is sixteen. (The smaller OnRatio, the more
	/// detail there is.)
	/// </summary>
	public virtual int GetOnRatioMinValue()
	{
		return vtkEarthSource_GetOnRatioMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEarthSource_GetOutline_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off drawing continents as filled polygons or as wireframe outlines.
	/// Warning: some graphics systems will have trouble with the very large, concave
	/// filled polygons. Recommend you use OutlienOn (i.e., disable filled polygons)
	/// for now.
	/// </summary>
	public virtual int GetOutline()
	{
		return vtkEarthSource_GetOutline_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEarthSource_GetRadius_07(HandleRef pThis);

	/// <summary>
	/// Set radius of earth.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkEarthSource_GetRadius_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEarthSource_GetRadiusMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set radius of earth.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkEarthSource_GetRadiusMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEarthSource_GetRadiusMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set radius of earth.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkEarthSource_GetRadiusMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEarthSource_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEarthSource_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEarthSource_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEarthSource_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEarthSource_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEarthSource NewInstance()
	{
		vtkEarthSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEarthSource_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEarthSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEarthSource_OutlineOff_14(HandleRef pThis);

	/// <summary>
	/// Turn on/off drawing continents as filled polygons or as wireframe outlines.
	/// Warning: some graphics systems will have trouble with the very large, concave
	/// filled polygons. Recommend you use OutlienOn (i.e., disable filled polygons)
	/// for now.
	/// </summary>
	public virtual void OutlineOff()
	{
		vtkEarthSource_OutlineOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEarthSource_OutlineOn_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off drawing continents as filled polygons or as wireframe outlines.
	/// Warning: some graphics systems will have trouble with the very large, concave
	/// filled polygons. Recommend you use OutlienOn (i.e., disable filled polygons)
	/// for now.
	/// </summary>
	public virtual void OutlineOn()
	{
		vtkEarthSource_OutlineOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEarthSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEarthSource SafeDownCast(vtkObjectBase o)
	{
		vtkEarthSource vtkEarthSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEarthSource_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEarthSource2 = (vtkEarthSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEarthSource2.Register(null);
			}
		}
		return vtkEarthSource2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEarthSource_SetOnRatio_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on every nth entity. This controls how much detail the model
	/// will have. The maximum ratio is sixteen. (The smaller OnRatio, the more
	/// detail there is.)
	/// </summary>
	public virtual void SetOnRatio(int _arg)
	{
		vtkEarthSource_SetOnRatio_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEarthSource_SetOutline_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off drawing continents as filled polygons or as wireframe outlines.
	/// Warning: some graphics systems will have trouble with the very large, concave
	/// filled polygons. Recommend you use OutlienOn (i.e., disable filled polygons)
	/// for now.
	/// </summary>
	public virtual void SetOutline(int _arg)
	{
		vtkEarthSource_SetOutline_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEarthSource_SetRadius_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Set radius of earth.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkEarthSource_SetRadius_19(GetCppThis(), _arg);
	}
}
