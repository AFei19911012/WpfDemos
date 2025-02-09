using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlatonicSolidSource
/// </summary>
/// <remarks>
///    produce polygonal Platonic solids
///
/// vtkPlatonicSolidSource can generate each of the five Platonic solids:
/// tetrahedron, cube, octahedron, icosahedron, and dodecahedron. Each of the
/// solids is placed inside a sphere centered at the origin with radius 1.0.
/// To use this class, simply specify the solid to create. Note that this
/// source object creates cell scalars that are (integral value) face numbers.
/// </remarks>
public class vtkPlatonicSolidSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlatonicSolidSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlatonicSolidSource()
	{
		MRClassNameKey = "class vtkPlatonicSolidSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlatonicSolidSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlatonicSolidSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlatonicSolidSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlatonicSolidSource New()
	{
		vtkPlatonicSolidSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlatonicSolidSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlatonicSolidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPlatonicSolidSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlatonicSolidSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPlatonicSolidSource_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlatonicSolidSource_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlatonicSolidSource_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlatonicSolidSource_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlatonicSolidSource_GetOutputPointsPrecision_03(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkPlatonicSolidSource_GetOutputPointsPrecision_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlatonicSolidSource_GetSolidType_04(HandleRef pThis);

	/// <summary>
	/// Specify the type of PlatonicSolid solid to create.
	/// </summary>
	public virtual int GetSolidType()
	{
		return vtkPlatonicSolidSource_GetSolidType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlatonicSolidSource_GetSolidTypeMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Specify the type of PlatonicSolid solid to create.
	/// </summary>
	public virtual int GetSolidTypeMaxValue()
	{
		return vtkPlatonicSolidSource_GetSolidTypeMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlatonicSolidSource_GetSolidTypeMinValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the type of PlatonicSolid solid to create.
	/// </summary>
	public virtual int GetSolidTypeMinValue()
	{
		return vtkPlatonicSolidSource_GetSolidTypeMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlatonicSolidSource_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlatonicSolidSource_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlatonicSolidSource_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlatonicSolidSource_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlatonicSolidSource_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlatonicSolidSource NewInstance()
	{
		vtkPlatonicSolidSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlatonicSolidSource_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlatonicSolidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlatonicSolidSource_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlatonicSolidSource SafeDownCast(vtkObjectBase o)
	{
		vtkPlatonicSolidSource vtkPlatonicSolidSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlatonicSolidSource_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlatonicSolidSource2 = (vtkPlatonicSolidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlatonicSolidSource2.Register(null);
			}
		}
		return vtkPlatonicSolidSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlatonicSolidSource_SetOutputPointsPrecision_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkPlatonicSolidSource_SetOutputPointsPrecision_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlatonicSolidSource_SetSolidType_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the type of PlatonicSolid solid to create.
	/// </summary>
	public virtual void SetSolidType(int _arg)
	{
		vtkPlatonicSolidSource_SetSolidType_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlatonicSolidSource_SetSolidTypeToCube_14(HandleRef pThis);

	/// <summary>
	/// Specify the type of PlatonicSolid solid to create.
	/// </summary>
	public void SetSolidTypeToCube()
	{
		vtkPlatonicSolidSource_SetSolidTypeToCube_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlatonicSolidSource_SetSolidTypeToDodecahedron_15(HandleRef pThis);

	/// <summary>
	/// Specify the type of PlatonicSolid solid to create.
	/// </summary>
	public void SetSolidTypeToDodecahedron()
	{
		vtkPlatonicSolidSource_SetSolidTypeToDodecahedron_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlatonicSolidSource_SetSolidTypeToIcosahedron_16(HandleRef pThis);

	/// <summary>
	/// Specify the type of PlatonicSolid solid to create.
	/// </summary>
	public void SetSolidTypeToIcosahedron()
	{
		vtkPlatonicSolidSource_SetSolidTypeToIcosahedron_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlatonicSolidSource_SetSolidTypeToOctahedron_17(HandleRef pThis);

	/// <summary>
	/// Specify the type of PlatonicSolid solid to create.
	/// </summary>
	public void SetSolidTypeToOctahedron()
	{
		vtkPlatonicSolidSource_SetSolidTypeToOctahedron_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlatonicSolidSource_SetSolidTypeToTetrahedron_18(HandleRef pThis);

	/// <summary>
	/// Specify the type of PlatonicSolid solid to create.
	/// </summary>
	public void SetSolidTypeToTetrahedron()
	{
		vtkPlatonicSolidSource_SetSolidTypeToTetrahedron_18(GetCppThis());
	}
}
