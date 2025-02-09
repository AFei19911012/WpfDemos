using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageMarchingCubes
/// </summary>
/// <remarks>
///    generate isosurface(s) from volume/images
///
/// vtkImageMarchingCubes is a filter that takes as input images (e.g., 3D
/// image region) and generates on output one or more isosurfaces.
/// One or more contour values must be specified to generate the isosurfaces.
/// Alternatively, you can specify a min/max scalar range and the number of
/// contours to generate a series of evenly spaced contour values.
/// This filter can stream, so that the entire volume need not be loaded at
/// once.  Streaming is controlled using the instance variable
/// InputMemoryLimit, which has units KBytes.
///
/// @warning
/// This filter is specialized to volumes. If you are interested in
/// contouring other types of data, use the general vtkContourFilter. If you
/// want to contour an image (i.e., a volume slice), use vtkMarchingSquares.
/// </remarks>
/// <seealso>
///
/// vtkContourFilter vtkSliceCubes vtkMarchingSquares vtkSynchronizedTemplates3D
/// </seealso>
public class vtkImageMarchingCubes : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageMarchingCubes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageMarchingCubes()
	{
		MRClassNameKey = "class vtkImageMarchingCubes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMarchingCubes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageMarchingCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMarchingCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMarchingCubes New()
	{
		vtkImageMarchingCubes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMarchingCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageMarchingCubes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageMarchingCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_AddLocatorPoint_01(HandleRef pThis, int cellX, int cellY, int edge, long ptId);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is fairly expensive
	/// in both time and storage. Note that if ComputeNormals is on, gradients will
	/// have to be calculated, but will not be stored in the output dataset.
	/// If the output data will be processed by filters that modify topology or
	/// geometry, it may be wise to turn Normals and Gradients off.
	/// </summary>
	public void AddLocatorPoint(int cellX, int cellY, int edge, long ptId)
	{
		vtkImageMarchingCubes_AddLocatorPoint_01(GetCppThis(), cellX, cellY, edge, ptId);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_ComputeGradientsOff_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is fairly expensive
	/// in both time and storage. Note that if ComputeNormals is on, gradients will
	/// have to be calculated, but will not be stored in the output dataset.
	/// If the output data will be processed by filters that modify topology or
	/// geometry, it may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeGradientsOff()
	{
		vtkImageMarchingCubes_ComputeGradientsOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_ComputeGradientsOn_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is fairly expensive
	/// in both time and storage. Note that if ComputeNormals is on, gradients will
	/// have to be calculated, but will not be stored in the output dataset.
	/// If the output data will be processed by filters that modify topology or
	/// geometry, it may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeGradientsOn()
	{
		vtkImageMarchingCubes_ComputeGradientsOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_ComputeNormalsOff_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly expensive
	/// in both time and storage. If the output data will be processed by filters
	/// that modify topology or geometry, it may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkImageMarchingCubes_ComputeNormalsOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_ComputeNormalsOn_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly expensive
	/// in both time and storage. If the output data will be processed by filters
	/// that modify topology or geometry, it may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkImageMarchingCubes_ComputeNormalsOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_ComputeScalarsOff_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkImageMarchingCubes_ComputeScalarsOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_ComputeScalarsOn_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkImageMarchingCubes_ComputeScalarsOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkImageMarchingCubes_GenerateValues_08(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkImageMarchingCubes_GenerateValues_09(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMarchingCubes_GetComputeGradients_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is fairly expensive
	/// in both time and storage. Note that if ComputeNormals is on, gradients will
	/// have to be calculated, but will not be stored in the output dataset.
	/// If the output data will be processed by filters that modify topology or
	/// geometry, it may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeGradients()
	{
		return vtkImageMarchingCubes_GetComputeGradients_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMarchingCubes_GetComputeNormals_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly expensive
	/// in both time and storage. If the output data will be processed by filters
	/// that modify topology or geometry, it may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkImageMarchingCubes_GetComputeNormals_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMarchingCubes_GetComputeScalars_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkImageMarchingCubes_GetComputeScalars_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMarchingCubes_GetInputMemoryLimit_13(HandleRef pThis);

	/// <summary>
	/// The InputMemoryLimit determines the chunk size (the number of slices
	/// requested at each iteration).  The units of this limit is KiloBytes.
	/// For now, only the Z axis is split.
	/// </summary>
	public virtual long GetInputMemoryLimit()
	{
		return vtkImageMarchingCubes_GetInputMemoryLimit_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMarchingCubes_GetLocatorPoint_14(HandleRef pThis, int cellX, int cellY, int edge);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is fairly expensive
	/// in both time and storage. Note that if ComputeNormals is on, gradients will
	/// have to be calculated, but will not be stored in the output dataset.
	/// If the output data will be processed by filters that modify topology or
	/// geometry, it may be wise to turn Normals and Gradients off.
	/// </summary>
	public long GetLocatorPoint(int cellX, int cellY, int edge)
	{
		return vtkImageMarchingCubes_GetLocatorPoint_14(GetCppThis(), cellX, cellY, edge);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageMarchingCubes_GetMTime_15(HandleRef pThis);

	/// <summary>
	/// Because we delegate to vtkContourValues &amp; refer to vtkImplicitFunction
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageMarchingCubes_GetMTime_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMarchingCubes_GetNumberOfContours_16(HandleRef pThis);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkImageMarchingCubes_GetNumberOfContours_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMarchingCubes_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageMarchingCubes_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMarchingCubes_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageMarchingCubes_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageMarchingCubes_GetValue_19(HandleRef pThis, int i);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public double GetValue(int i)
	{
		return vtkImageMarchingCubes_GetValue_19(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMarchingCubes_GetValues_20(HandleRef pThis);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkImageMarchingCubes_GetValues_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_GetValues_21(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkImageMarchingCubes_GetValues_21(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_IncrementLocatorZ_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is fairly expensive
	/// in both time and storage. Note that if ComputeNormals is on, gradients will
	/// have to be calculated, but will not be stored in the output dataset.
	/// If the output data will be processed by filters that modify topology or
	/// geometry, it may be wise to turn Normals and Gradients off.
	/// </summary>
	public void IncrementLocatorZ()
	{
		vtkImageMarchingCubes_IncrementLocatorZ_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMarchingCubes_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageMarchingCubes_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMarchingCubes_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageMarchingCubes_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMarchingCubes_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageMarchingCubes NewInstance()
	{
		vtkImageMarchingCubes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMarchingCubes_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMarchingCubes_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMarchingCubes SafeDownCast(vtkObjectBase o)
	{
		vtkImageMarchingCubes vtkImageMarchingCubes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMarchingCubes_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMarchingCubes2 = (vtkImageMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMarchingCubes2.Register(null);
			}
		}
		return vtkImageMarchingCubes2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_SetComputeGradients_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of gradients. Gradient computation is fairly expensive
	/// in both time and storage. Note that if ComputeNormals is on, gradients will
	/// have to be calculated, but will not be stored in the output dataset.
	/// If the output data will be processed by filters that modify topology or
	/// geometry, it may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeGradients(int _arg)
	{
		vtkImageMarchingCubes_SetComputeGradients_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_SetComputeNormals_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly expensive
	/// in both time and storage. If the output data will be processed by filters
	/// that modify topology or geometry, it may be wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkImageMarchingCubes_SetComputeNormals_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_SetComputeScalars_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkImageMarchingCubes_SetComputeScalars_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_SetInputMemoryLimit_31(HandleRef pThis, long _arg);

	/// <summary>
	/// The InputMemoryLimit determines the chunk size (the number of slices
	/// requested at each iteration).  The units of this limit is KiloBytes.
	/// For now, only the Z axis is split.
	/// </summary>
	public virtual void SetInputMemoryLimit(long _arg)
	{
		vtkImageMarchingCubes_SetInputMemoryLimit_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_SetNumberOfContours_32(HandleRef pThis, int number);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkImageMarchingCubes_SetNumberOfContours_32(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMarchingCubes_SetValue_33(HandleRef pThis, int i, double value);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkImageMarchingCubes_SetValue_33(GetCppThis(), i, value);
	}
}
