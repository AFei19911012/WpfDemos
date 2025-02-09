using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMarchingCubes
/// </summary>
/// <remarks>
///    generate isosurface(s) from volume
///
/// vtkMarchingCubes is a filter that takes as input a volume (e.g., 3D
/// structured point set) and generates on output one or more isosurfaces.
/// One or more contour values must be specified to generate the isosurfaces.
/// Alternatively, you can specify a min/max scalar range and the number of
/// contours to generate a series of evenly spaced contour values.
///
/// @warning
/// This filter is specialized to volumes. If you are interested in
/// contouring other types of data, use the general vtkContourFilter. If you
/// want to contour an image (i.e., a volume slice), use vtkMarchingSquares.
///
/// </remarks>
/// <seealso>
///
/// Much faster implementations for isocontouring are available. In
/// particular, vtkFlyingEdges3D and vtkFlyingEdges2D are much faster
/// and if built with the right options, multithreaded, and scale well
/// with additional processors.
///
///
/// If you are interested in extracting surfaces from label maps,
/// consider using vtkDiscreteFlyingEdges3D, vtkDiscreteFlyingEdges2D, or
/// vtkDiscreteMarchingCubes.
///
///
/// vtkFlyingEdges3D vtkFlyingEdges2D vtkSynchronizedTemplates3D
/// vtkSynchronizedTemplates2D vtkContourFilter vtkSliceCubes
/// vtkMarchingSquares vtkDividingCubes vtkDiscreteMarchingCubes
/// </seealso>
public class vtkMarchingCubes : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMarchingCubes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMarchingCubes()
	{
		MRClassNameKey = "class vtkMarchingCubes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMarchingCubes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMarchingCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarchingCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMarchingCubes New()
	{
		vtkMarchingCubes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMarchingCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMarchingCubes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMarchingCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_ComputeGradientsOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is
	/// fairly expensive in both time and storage. Note that if
	/// ComputeNormals is on, gradients will have to be calculated, but
	/// will not be stored in the output dataset.  If the output data
	/// will be processed by filters that modify topology or geometry, it
	/// may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeGradientsOff()
	{
		vtkMarchingCubes_ComputeGradientsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_ComputeGradientsOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is
	/// fairly expensive in both time and storage. Note that if
	/// ComputeNormals is on, gradients will have to be calculated, but
	/// will not be stored in the output dataset.  If the output data
	/// will be processed by filters that modify topology or geometry, it
	/// may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeGradientsOn()
	{
		vtkMarchingCubes_ComputeGradientsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_ComputeNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkMarchingCubes_ComputeNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_ComputeNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkMarchingCubes_ComputeNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_ComputeScalarsOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkMarchingCubes_ComputeScalarsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_ComputeScalarsOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkMarchingCubes_ComputeScalarsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_CreateDefaultLocator_07(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is
	/// specified. The locator is used to merge coincident points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkMarchingCubes_CreateDefaultLocator_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkMarchingCubes_GenerateValues_08(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkMarchingCubes_GenerateValues_09(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMarchingCubes_GetComputeGradients_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is
	/// fairly expensive in both time and storage. Note that if
	/// ComputeNormals is on, gradients will have to be calculated, but
	/// will not be stored in the output dataset.  If the output data
	/// will be processed by filters that modify topology or geometry, it
	/// may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeGradients()
	{
		return vtkMarchingCubes_GetComputeGradients_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMarchingCubes_GetComputeNormals_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkMarchingCubes_GetComputeNormals_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMarchingCubes_GetComputeScalars_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkMarchingCubes_GetComputeScalars_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarchingCubes_GetLocator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// override the default locator.  Useful for changing the number of
	/// bins for performance or specifying a more aggressive locator.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMarchingCubes_GetLocator_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalPointLocator2 = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalPointLocator2.Register(null);
			}
		}
		return vtkIncrementalPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkMarchingCubes_GetMTime_14(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkMarchingCubes_GetMTime_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMarchingCubes_GetNumberOfContours_15(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkMarchingCubes_GetNumberOfContours_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMarchingCubes_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMarchingCubes_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMarchingCubes_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMarchingCubes_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMarchingCubes_GetValue_18(HandleRef pThis, int i);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetValue(int i)
	{
		return vtkMarchingCubes_GetValue_18(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarchingCubes_GetValues_19(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkMarchingCubes_GetValues_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_GetValues_20(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkMarchingCubes_GetValues_20(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMarchingCubes_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMarchingCubes_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMarchingCubes_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMarchingCubes_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarchingCubes_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMarchingCubes NewInstance()
	{
		vtkMarchingCubes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMarchingCubes_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarchingCubes_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMarchingCubes SafeDownCast(vtkObjectBase o)
	{
		vtkMarchingCubes vtkMarchingCubes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMarchingCubes_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMarchingCubes2 = (vtkMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMarchingCubes2.Register(null);
			}
		}
		return vtkMarchingCubes2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_SetComputeGradients_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is
	/// fairly expensive in both time and storage. Note that if
	/// ComputeNormals is on, gradients will have to be calculated, but
	/// will not be stored in the output dataset.  If the output data
	/// will be processed by filters that modify topology or geometry, it
	/// may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeGradients(int _arg)
	{
		vtkMarchingCubes_SetComputeGradients_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_SetComputeNormals_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkMarchingCubes_SetComputeNormals_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_SetComputeScalars_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkMarchingCubes_SetComputeScalars_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_SetLocator_29(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// override the default locator.  Useful for changing the number of
	/// bins for performance or specifying a more aggressive locator.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkMarchingCubes_SetLocator_29(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_SetNumberOfContours_30(HandleRef pThis, int number);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkMarchingCubes_SetNumberOfContours_30(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingCubes_SetValue_31(HandleRef pThis, int i, double value);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkMarchingCubes_SetValue_31(GetCppThis(), i, value);
	}
}
