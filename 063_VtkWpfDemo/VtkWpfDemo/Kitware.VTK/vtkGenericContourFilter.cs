using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericContourFilter
/// </summary>
/// <remarks>
///    generate isocontours from input dataset
///
/// vtkGenericContourFilter is a filter that takes as input any (generic)
/// dataset and generates on output isosurfaces and/or isolines. The exact
/// form of the output depends upon the dimensionality of the input data.
/// Data consisting of 3D cells will generate isosurfaces, data consisting of
/// 2D cells will generate isolines, and data with 1D or 0D cells will
/// generate isopoints. Combinations of output type are possible if the input
/// dimension is mixed.
///
/// To use this filter you must specify one or more contour values.
/// You can either use the method SetValue() to specify each contour
/// value, or use GenerateValues() to generate a series of evenly
/// spaced contours. You can use ComputeNormalsOn to compute the normals
/// without the need of a vtkPolyDataNormals
///
/// This filter has been implemented to operate on generic datasets, rather
/// than the typical vtkDataSet (and subclasses). vtkGenericDataSet is a more
/// complex cousin of vtkDataSet, typically consisting of nonlinear,
/// higher-order cells. To process this type of data, generic cells are
/// automatically tessellated into linear cells prior to isocontouring.
///
/// </remarks>
/// <seealso>
///
/// vtkContourFilter vtkGenericDataSet
/// </seealso>
public class vtkGenericContourFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericContourFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericContourFilter()
	{
		MRClassNameKey = "class vtkGenericContourFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericContourFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with initial range (0,1) and single contour value
	/// of 0.0.
	/// </summary>
	public new static vtkGenericContourFilter New()
	{
		vtkGenericContourFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericContourFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with initial range (0,1) and single contour value
	/// of 0.0.
	/// </summary>
	public vtkGenericContourFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericContourFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_ComputeGradientsOff_01(HandleRef pThis);

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
		vtkGenericContourFilter_ComputeGradientsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_ComputeGradientsOn_02(HandleRef pThis);

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
		vtkGenericContourFilter_ComputeGradientsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_ComputeNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkGenericContourFilter_ComputeNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_ComputeNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkGenericContourFilter_ComputeNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_ComputeScalarsOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkGenericContourFilter_ComputeScalarsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_ComputeScalarsOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkGenericContourFilter_ComputeScalarsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_CreateDefaultLocator_07(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is
	/// specified. The locator is used to merge coincident points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkGenericContourFilter_CreateDefaultLocator_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkGenericContourFilter_GenerateValues_08(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkGenericContourFilter_GenerateValues_09(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericContourFilter_GetComputeGradients_10(HandleRef pThis);

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
		return vtkGenericContourFilter_GetComputeGradients_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericContourFilter_GetComputeNormals_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkGenericContourFilter_GetComputeNormals_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericContourFilter_GetComputeScalars_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkGenericContourFilter_GetComputeScalars_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericContourFilter_GetInputScalarsSelection_13(HandleRef pThis);

	/// <summary>
	/// If you want to contour by an arbitrary scalar attribute, then set its
	/// name here.
	/// By default this in nullptr and the filter will use the active scalar array.
	/// </summary>
	public virtual string GetInputScalarsSelection()
	{
		return Marshal.PtrToStringAnsi(vtkGenericContourFilter_GetInputScalarsSelection_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericContourFilter_GetLocator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericContourFilter_GetLocator_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGenericContourFilter_GetMTime_15(HandleRef pThis);

	/// <summary>
	/// Modified GetMTime Because we delegate to vtkContourValues
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGenericContourFilter_GetMTime_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericContourFilter_GetNumberOfContours_16(HandleRef pThis);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkGenericContourFilter_GetNumberOfContours_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericContourFilter_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericContourFilter_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericContourFilter_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericContourFilter_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericContourFilter_GetValue_19(HandleRef pThis, int i);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkGenericContourFilter_GetValue_19(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericContourFilter_GetValues_20(HandleRef pThis);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkGenericContourFilter_GetValues_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_GetValues_21(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkGenericContourFilter_GetValues_21(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericContourFilter_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericContourFilter_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericContourFilter_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericContourFilter_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericContourFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericContourFilter NewInstance()
	{
		vtkGenericContourFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericContourFilter_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericContourFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericContourFilter SafeDownCast(vtkObjectBase o)
	{
		vtkGenericContourFilter vtkGenericContourFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericContourFilter_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericContourFilter2 = (vtkGenericContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericContourFilter2.Register(null);
			}
		}
		return vtkGenericContourFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_SelectInputScalars_27(HandleRef pThis, string fieldName);

	/// <summary>
	/// If you want to contour by an arbitrary scalar attribute, then set its
	/// name here.
	/// By default this in nullptr and the filter will use the active scalar array.
	/// </summary>
	public virtual void SelectInputScalars(string fieldName)
	{
		vtkGenericContourFilter_SelectInputScalars_27(GetCppThis(), fieldName);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_SetComputeGradients_28(HandleRef pThis, int _arg);

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
		vtkGenericContourFilter_SetComputeGradients_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_SetComputeNormals_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkGenericContourFilter_SetComputeNormals_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_SetComputeScalars_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkGenericContourFilter_SetComputeScalars_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_SetLocator_31(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkGenericContourFilter_SetLocator_31(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_SetNumberOfContours_32(HandleRef pThis, int number);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkGenericContourFilter_SetNumberOfContours_32(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericContourFilter_SetValue_33(HandleRef pThis, int i, float value);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void SetValue(int i, float value)
	{
		vtkGenericContourFilter_SetValue_33(GetCppThis(), i, value);
	}
}
