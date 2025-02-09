using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSynchronizedTemplates3D
/// </summary>
/// <remarks>
///    generate isosurface from structured points
///
/// vtkSynchronizedTemplates3D is a 3D implementation of the synchronized
/// template algorithm. Note that vtkContourFilter will automatically
/// use this class when appropriate.
///
/// @warning
/// This filter is specialized to 3D images (aka volumes).
///
/// </remarks>
/// <seealso>
///
/// vtkContourFilter vtkFlyingEdges3D vtkMarchingCubes
/// vtkSynchronizedTemplates2D vtkDiscreteFlyingEdges3D
/// </seealso>
public class vtkSynchronizedTemplates3D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSynchronizedTemplates3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSynchronizedTemplates3D()
	{
		MRClassNameKey = "class vtkSynchronizedTemplates3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSynchronizedTemplates3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSynchronizedTemplates3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSynchronizedTemplates3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSynchronizedTemplates3D New()
	{
		vtkSynchronizedTemplates3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSynchronizedTemplates3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSynchronizedTemplates3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSynchronizedTemplates3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSynchronizedTemplates3D_ComputeGradientsOff_01(HandleRef pThis);

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
		vtkSynchronizedTemplates3D_ComputeGradientsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_ComputeGradientsOn_02(HandleRef pThis);

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
		vtkSynchronizedTemplates3D_ComputeGradientsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_ComputeNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkSynchronizedTemplates3D_ComputeNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_ComputeNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkSynchronizedTemplates3D_ComputeNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_ComputeScalarsOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkSynchronizedTemplates3D_ComputeScalarsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_ComputeScalarsOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkSynchronizedTemplates3D_ComputeScalarsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_GenerateTrianglesOff_07(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// </summary>
	public virtual void GenerateTrianglesOff()
	{
		vtkSynchronizedTemplates3D_GenerateTrianglesOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_GenerateTrianglesOn_08(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// </summary>
	public virtual void GenerateTrianglesOn()
	{
		vtkSynchronizedTemplates3D_GenerateTrianglesOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_GenerateValues_09(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkSynchronizedTemplates3D_GenerateValues_09(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_GenerateValues_10(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkSynchronizedTemplates3D_GenerateValues_10(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSynchronizedTemplates3D_GetArrayComponent_11(HandleRef pThis);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual int GetArrayComponent()
	{
		return vtkSynchronizedTemplates3D_GetArrayComponent_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSynchronizedTemplates3D_GetComputeGradients_12(HandleRef pThis);

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
		return vtkSynchronizedTemplates3D_GetComputeGradients_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSynchronizedTemplates3D_GetComputeNormals_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkSynchronizedTemplates3D_GetComputeNormals_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSynchronizedTemplates3D_GetComputeScalars_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkSynchronizedTemplates3D_GetComputeScalars_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSynchronizedTemplates3D_GetGenerateTriangles_15(HandleRef pThis);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// </summary>
	public virtual int GetGenerateTriangles()
	{
		return vtkSynchronizedTemplates3D_GetGenerateTriangles_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkSynchronizedTemplates3D_GetInputMemoryLimit_16(HandleRef pThis);

	/// <summary>
	/// Determines the chunk size for streaming.  This filter will act like a
	/// collector: ask for many input pieces, but generate one output.  Limit is
	/// in KBytes
	/// </summary>
	public uint GetInputMemoryLimit()
	{
		return vtkSynchronizedTemplates3D_GetInputMemoryLimit_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkSynchronizedTemplates3D_GetMTime_17(HandleRef pThis);

	/// <summary>
	/// Because we delegate to vtkContourValues
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSynchronizedTemplates3D_GetMTime_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSynchronizedTemplates3D_GetNumberOfContours_18(HandleRef pThis);

	/// <summary>
	/// Get the number of contours in the list of contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkSynchronizedTemplates3D_GetNumberOfContours_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSynchronizedTemplates3D_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSynchronizedTemplates3D_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSynchronizedTemplates3D_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSynchronizedTemplates3D_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSynchronizedTemplates3D_GetValue_21(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith contour value.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkSynchronizedTemplates3D_GetValue_21(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSynchronizedTemplates3D_GetValues_22(HandleRef pThis);

	/// <summary>
	/// Get a pointer to an array of contour values. There will be
	/// GetNumberOfContours() values in the list.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkSynchronizedTemplates3D_GetValues_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_GetValues_23(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Fill a supplied list with contour values. There will be
	/// GetNumberOfContours() values in the list. Make sure you allocate
	/// enough memory to hold the list.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkSynchronizedTemplates3D_GetValues_23(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSynchronizedTemplates3D_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSynchronizedTemplates3D_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSynchronizedTemplates3D_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSynchronizedTemplates3D_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSynchronizedTemplates3D_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSynchronizedTemplates3D NewInstance()
	{
		vtkSynchronizedTemplates3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSynchronizedTemplates3D_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSynchronizedTemplates3D_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSynchronizedTemplates3D SafeDownCast(vtkObjectBase o)
	{
		vtkSynchronizedTemplates3D vtkSynchronizedTemplates3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSynchronizedTemplates3D_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSynchronizedTemplates3D2 = (vtkSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSynchronizedTemplates3D2.Register(null);
			}
		}
		return vtkSynchronizedTemplates3D2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_SetArrayComponent_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual void SetArrayComponent(int _arg)
	{
		vtkSynchronizedTemplates3D_SetArrayComponent_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_SetComputeGradients_30(HandleRef pThis, int _arg);

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
		vtkSynchronizedTemplates3D_SetComputeGradients_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_SetComputeNormals_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of normals. Normal computation is fairly
	/// expensive in both time and storage. If the output data will be
	/// processed by filters that modify topology or geometry, it may be
	/// wise to turn Normals and Gradients off.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkSynchronizedTemplates3D_SetComputeNormals_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_SetComputeScalars_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of scalars.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkSynchronizedTemplates3D_SetComputeScalars_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_SetGenerateTriangles_33(HandleRef pThis, int _arg);

	/// <summary>
	/// If this is enabled (by default), the output will be triangles
	/// otherwise, the output will be the intersection polygons
	/// </summary>
	public virtual void SetGenerateTriangles(int _arg)
	{
		vtkSynchronizedTemplates3D_SetGenerateTriangles_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_SetInputMemoryLimit_34(HandleRef pThis, uint limit);

	/// <summary>
	/// Determines the chunk size for streaming.  This filter will act like a
	/// collector: ask for many input pieces, but generate one output.  Limit is
	/// in KBytes
	/// </summary>
	public void SetInputMemoryLimit(uint limit)
	{
		vtkSynchronizedTemplates3D_SetInputMemoryLimit_34(GetCppThis(), limit);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_SetNumberOfContours_35(HandleRef pThis, int number);

	/// <summary>
	/// Set the number of contours to place into the list. You only really
	/// need to use this method to reduce list size. The method SetValue()
	/// will automatically increase list size as needed.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkSynchronizedTemplates3D_SetNumberOfContours_35(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_SetValue_36(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set a particular contour value at contour number i. The index i ranges
	/// between 0&lt;=i&lt;NumberOfContours.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkSynchronizedTemplates3D_SetValue_36(GetCppThis(), i, value);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizedTemplates3D_ThreadedExecute_37(HandleRef pThis, HandleRef data, HandleRef inInfo, HandleRef outInfo, HandleRef inScalars);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void ThreadedExecute(vtkImageData data, vtkInformation inInfo, vtkInformation outInfo, vtkDataArray inScalars)
	{
		vtkSynchronizedTemplates3D_ThreadedExecute_37(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), inInfo?.GetCppThis() ?? default(HandleRef), outInfo?.GetCppThis() ?? default(HandleRef), inScalars?.GetCppThis() ?? default(HandleRef));
	}
}
