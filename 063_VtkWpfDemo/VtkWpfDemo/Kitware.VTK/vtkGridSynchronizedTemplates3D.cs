using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGridSynchronizedTemplates3D
/// </summary>
/// <remarks>
///    generate isosurface from structured grids
///
///
/// vtkGridSynchronizedTemplates3D is a 3D implementation of the synchronized
/// template algorithm.
///
/// @warning
/// This filter is specialized to 3D grids.
///
/// </remarks>
/// <seealso>
///
/// vtkContourFilter vtkSynchronizedTemplates3D
/// </seealso>
public class vtkGridSynchronizedTemplates3D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGridSynchronizedTemplates3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGridSynchronizedTemplates3D()
	{
		MRClassNameKey = "class vtkGridSynchronizedTemplates3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGridSynchronizedTemplates3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGridSynchronizedTemplates3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGridSynchronizedTemplates3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGridSynchronizedTemplates3D New()
	{
		vtkGridSynchronizedTemplates3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGridSynchronizedTemplates3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGridSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGridSynchronizedTemplates3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGridSynchronizedTemplates3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGridSynchronizedTemplates3D_ComputeGradientsOff_01(HandleRef pThis);

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
		vtkGridSynchronizedTemplates3D_ComputeGradientsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_ComputeGradientsOn_02(HandleRef pThis);

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
		vtkGridSynchronizedTemplates3D_ComputeGradientsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_ComputeNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkGridSynchronizedTemplates3D_ComputeNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_ComputeNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkGridSynchronizedTemplates3D_ComputeNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_ComputeScalarsOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkGridSynchronizedTemplates3D_ComputeScalarsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_ComputeScalarsOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkGridSynchronizedTemplates3D_ComputeScalarsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_GenerateTrianglesOff_07(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// </summary>
	public virtual void GenerateTrianglesOff()
	{
		vtkGridSynchronizedTemplates3D_GenerateTrianglesOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_GenerateTrianglesOn_08(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// </summary>
	public virtual void GenerateTrianglesOn()
	{
		vtkGridSynchronizedTemplates3D_GenerateTrianglesOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_GenerateValues_09(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkGridSynchronizedTemplates3D_GenerateValues_09(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_GenerateValues_10(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkGridSynchronizedTemplates3D_GenerateValues_10(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGridSynchronizedTemplates3D_GetComputeGradients_11(HandleRef pThis);

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
		return vtkGridSynchronizedTemplates3D_GetComputeGradients_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGridSynchronizedTemplates3D_GetComputeNormals_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkGridSynchronizedTemplates3D_GetComputeNormals_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGridSynchronizedTemplates3D_GetComputeScalars_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkGridSynchronizedTemplates3D_GetComputeScalars_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGridSynchronizedTemplates3D_GetGenerateTriangles_14(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// </summary>
	public virtual int GetGenerateTriangles()
	{
		return vtkGridSynchronizedTemplates3D_GetGenerateTriangles_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGridSynchronizedTemplates3D_GetMTime_15(HandleRef pThis);

	/// <summary>
	/// Because we delegate to vtkContourValues
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGridSynchronizedTemplates3D_GetMTime_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGridSynchronizedTemplates3D_GetNumberOfContours_16(HandleRef pThis);

	/// <summary>
	/// Get the number of contours in the list of contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkGridSynchronizedTemplates3D_GetNumberOfContours_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGridSynchronizedTemplates3D_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGridSynchronizedTemplates3D_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGridSynchronizedTemplates3D_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGridSynchronizedTemplates3D_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGridSynchronizedTemplates3D_GetOutputPointsPrecision_19(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkGridSynchronizedTemplates3D_GetOutputPointsPrecision_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGridSynchronizedTemplates3D_GetOutputPointsPrecisionMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMaxValue()
	{
		return vtkGridSynchronizedTemplates3D_GetOutputPointsPrecisionMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGridSynchronizedTemplates3D_GetOutputPointsPrecisionMinValue_21(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMinValue()
	{
		return vtkGridSynchronizedTemplates3D_GetOutputPointsPrecisionMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGridSynchronizedTemplates3D_GetValue_22(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith contour value.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkGridSynchronizedTemplates3D_GetValue_22(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGridSynchronizedTemplates3D_GetValues_23(HandleRef pThis);

	/// <summary>
	/// Get a pointer to an array of contour values. There will be
	/// GetNumberOfContours() values in the list.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkGridSynchronizedTemplates3D_GetValues_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_GetValues_24(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Fill a supplied list with contour values. There will be
	/// GetNumberOfContours() values in the list. Make sure you allocate
	/// enough memory to hold the list.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkGridSynchronizedTemplates3D_GetValues_24(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGridSynchronizedTemplates3D_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGridSynchronizedTemplates3D_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGridSynchronizedTemplates3D_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGridSynchronizedTemplates3D_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGridSynchronizedTemplates3D_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGridSynchronizedTemplates3D NewInstance()
	{
		vtkGridSynchronizedTemplates3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGridSynchronizedTemplates3D_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGridSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGridSynchronizedTemplates3D_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGridSynchronizedTemplates3D SafeDownCast(vtkObjectBase o)
	{
		vtkGridSynchronizedTemplates3D vtkGridSynchronizedTemplates3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGridSynchronizedTemplates3D_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGridSynchronizedTemplates3D2 = (vtkGridSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGridSynchronizedTemplates3D2.Register(null);
			}
		}
		return vtkGridSynchronizedTemplates3D2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_SetComputeGradients_30(HandleRef pThis, int _arg);

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
		vtkGridSynchronizedTemplates3D_SetComputeGradients_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_SetComputeNormals_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkGridSynchronizedTemplates3D_SetComputeNormals_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_SetComputeScalars_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkGridSynchronizedTemplates3D_SetComputeScalars_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_SetGenerateTriangles_33(HandleRef pThis, int _arg);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// </summary>
	public virtual void SetGenerateTriangles(int _arg)
	{
		vtkGridSynchronizedTemplates3D_SetGenerateTriangles_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_SetInputMemoryLimit_34(HandleRef pThis, int limit);

	/// <summary>
	/// This filter will initiate streaming so that no piece requested
	/// from the input will be larger than this value (KiloBytes).
	/// </summary>
	public void SetInputMemoryLimit(int limit)
	{
		vtkGridSynchronizedTemplates3D_SetInputMemoryLimit_34(GetCppThis(), limit);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_SetNumberOfContours_35(HandleRef pThis, int number);

	/// <summary>
	/// Set the number of contours to place into the list. You only really
	/// need to use this method to reduce list size. The method SetValue()
	/// will automatically increase list size as needed.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkGridSynchronizedTemplates3D_SetNumberOfContours_35(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_SetOutputPointsPrecision_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkGridSynchronizedTemplates3D_SetOutputPointsPrecision_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridSynchronizedTemplates3D_SetValue_37(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set a particular contour value at contour number i. The index i ranges
	/// between 0&lt;=i&lt;NumberOfContours.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkGridSynchronizedTemplates3D_SetValue_37(GetCppThis(), i, value);
	}
}
