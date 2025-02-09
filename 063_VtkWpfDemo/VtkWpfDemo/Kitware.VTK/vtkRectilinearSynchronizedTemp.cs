using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRectilinearSynchronizedTemplates
/// </summary>
/// <remarks>
///    generate isosurface from rectilinear grid
///
///
/// vtkRectilinearSynchronizedTemplates is a 3D implementation (for rectilinear
/// grids) of the synchronized template algorithm. Note that vtkContourFilter
/// will automatically use this class when appropriate.
///
/// @warning
/// This filter is specialized to rectilinear grids.
///
/// </remarks>
/// <seealso>
///
/// vtkContourFilter vtkSynchronizedTemplates2D vtkSynchronizedTemplates3D
/// </seealso>
public class vtkRectilinearSynchronizedTemplates : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearSynchronizedTemplates";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRectilinearSynchronizedTemplates()
	{
		MRClassNameKey = "class vtkRectilinearSynchronizedTemplates";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearSynchronizedTemplates"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRectilinearSynchronizedTemplates(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearSynchronizedTemplates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearSynchronizedTemplates New()
	{
		vtkRectilinearSynchronizedTemplates result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearSynchronizedTemplates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearSynchronizedTemplates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRectilinearSynchronizedTemplates()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRectilinearSynchronizedTemplates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRectilinearSynchronizedTemplates_ComputeGradientsOff_01(HandleRef pThis);

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
		vtkRectilinearSynchronizedTemplates_ComputeGradientsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_ComputeGradientsOn_02(HandleRef pThis);

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
		vtkRectilinearSynchronizedTemplates_ComputeGradientsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_ComputeNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkRectilinearSynchronizedTemplates_ComputeNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_ComputeNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkRectilinearSynchronizedTemplates_ComputeNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_ComputeScalarsOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkRectilinearSynchronizedTemplates_ComputeScalarsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_ComputeScalarsOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkRectilinearSynchronizedTemplates_ComputeScalarsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_ComputeSpacing_07(HandleRef pThis, HandleRef data, int i, int j, int k, IntPtr extent, IntPtr spacing);

	/// <summary>
	/// Compute the spacing between this point and its 6 neighbors.  This method
	/// needs to be public so it can be accessed from a templated function.
	/// </summary>
	public void ComputeSpacing(vtkRectilinearGrid data, int i, int j, int k, IntPtr extent, IntPtr spacing)
	{
		vtkRectilinearSynchronizedTemplates_ComputeSpacing_07(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), i, j, k, extent, spacing);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_GenerateTrianglesOff_08(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// </summary>
	public virtual void GenerateTrianglesOff()
	{
		vtkRectilinearSynchronizedTemplates_GenerateTrianglesOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_GenerateTrianglesOn_09(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// </summary>
	public virtual void GenerateTrianglesOn()
	{
		vtkRectilinearSynchronizedTemplates_GenerateTrianglesOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_GenerateValues_10(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkRectilinearSynchronizedTemplates_GenerateValues_10(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_GenerateValues_11(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkRectilinearSynchronizedTemplates_GenerateValues_11(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearSynchronizedTemplates_GetArrayComponent_12(HandleRef pThis);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual int GetArrayComponent()
	{
		return vtkRectilinearSynchronizedTemplates_GetArrayComponent_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearSynchronizedTemplates_GetComputeGradients_13(HandleRef pThis);

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
		return vtkRectilinearSynchronizedTemplates_GetComputeGradients_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearSynchronizedTemplates_GetComputeNormals_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkRectilinearSynchronizedTemplates_GetComputeNormals_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearSynchronizedTemplates_GetComputeScalars_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkRectilinearSynchronizedTemplates_GetComputeScalars_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearSynchronizedTemplates_GetGenerateTriangles_16(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// </summary>
	public virtual int GetGenerateTriangles()
	{
		return vtkRectilinearSynchronizedTemplates_GetGenerateTriangles_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkRectilinearSynchronizedTemplates_GetMTime_17(HandleRef pThis);

	/// <summary>
	/// Because we delegate to vtkContourValues
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkRectilinearSynchronizedTemplates_GetMTime_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearSynchronizedTemplates_GetNumberOfContours_18(HandleRef pThis);

	/// <summary>
	/// Get the number of contours in the list of contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkRectilinearSynchronizedTemplates_GetNumberOfContours_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearSynchronizedTemplates_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRectilinearSynchronizedTemplates_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearSynchronizedTemplates_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRectilinearSynchronizedTemplates_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectilinearSynchronizedTemplates_GetValue_21(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith contour value.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkRectilinearSynchronizedTemplates_GetValue_21(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearSynchronizedTemplates_GetValues_22(HandleRef pThis);

	/// <summary>
	/// Get a pointer to an array of contour values. There will be
	/// GetNumberOfContours() values in the list.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkRectilinearSynchronizedTemplates_GetValues_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_GetValues_23(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Fill a supplied list with contour values. There will be
	/// GetNumberOfContours() values in the list. Make sure you allocate
	/// enough memory to hold the list.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkRectilinearSynchronizedTemplates_GetValues_23(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearSynchronizedTemplates_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRectilinearSynchronizedTemplates_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearSynchronizedTemplates_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRectilinearSynchronizedTemplates_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearSynchronizedTemplates_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRectilinearSynchronizedTemplates NewInstance()
	{
		vtkRectilinearSynchronizedTemplates result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearSynchronizedTemplates_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearSynchronizedTemplates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearSynchronizedTemplates_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearSynchronizedTemplates SafeDownCast(vtkObjectBase o)
	{
		vtkRectilinearSynchronizedTemplates vtkRectilinearSynchronizedTemplates2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearSynchronizedTemplates_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearSynchronizedTemplates2 = (vtkRectilinearSynchronizedTemplates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearSynchronizedTemplates2.Register(null);
			}
		}
		return vtkRectilinearSynchronizedTemplates2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_SetArrayComponent_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual void SetArrayComponent(int _arg)
	{
		vtkRectilinearSynchronizedTemplates_SetArrayComponent_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_SetComputeGradients_30(HandleRef pThis, int _arg);

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
		vtkRectilinearSynchronizedTemplates_SetComputeGradients_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_SetComputeNormals_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkRectilinearSynchronizedTemplates_SetComputeNormals_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_SetComputeScalars_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkRectilinearSynchronizedTemplates_SetComputeScalars_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_SetGenerateTriangles_33(HandleRef pThis, int _arg);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// </summary>
	public virtual void SetGenerateTriangles(int _arg)
	{
		vtkRectilinearSynchronizedTemplates_SetGenerateTriangles_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_SetNumberOfContours_34(HandleRef pThis, int number);

	/// <summary>
	/// Set the number of contours to place into the list. You only really
	/// need to use this method to reduce list size. The method SetValue()
	/// will automatically increase list size as needed.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkRectilinearSynchronizedTemplates_SetNumberOfContours_34(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearSynchronizedTemplates_SetValue_35(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set a particular contour value at contour number i. The index i ranges
	/// between 0&lt;=i&lt;NumberOfContours.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkRectilinearSynchronizedTemplates_SetValue_35(GetCppThis(), i, value);
	}
}
