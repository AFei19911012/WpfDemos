using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridBunykRayCastFunction
/// </summary>
/// <remarks>
///    a superclass for ray casting functions
///
///
/// vtkUnstructuredGridBunykRayCastFunction is a concrete implementation of a
/// ray cast function for unstructured grid data. This class was based on the
/// paper "Simple, Fast, Robust Ray Casting of Irregular Grids" by Paul Bunyk,
/// Arie Kaufmna, and Claudio Silva. This method is quite memory intensive
/// (with extra explicit copies of the data) and therefore should not be used
/// for very large data. This method assumes that the input data is composed
/// entirely of tetras - use vtkDataSetTriangleFilter before setting the input
/// on the mapper.
///
/// The basic idea of this method is as follows:
///
///   1) Enumerate the triangles. At each triangle have space for some
///      information that will be used during rendering. This includes
///      which tetra the triangles belong to, the plane equation and the
///      Barycentric coefficients.
///
///   2) Keep a reference to all four triangles for each tetra.
///
///   3) At the beginning of each render, do the precomputation. This
///      includes creating an array of transformed points (in view
///      coordinates) and computing the view dependent info per triangle
///      (plane equations and barycentric coords in view space)
///
///   4) Find all front facing boundary triangles (a triangle is on the
///      boundary if it belongs to only one tetra). For each triangle,
///      find all pixels in the image that intersect the triangle, and
///      add this to the sorted (by depth) intersection list at each
///      pixel.
///
///   5) For each ray cast, traverse the intersection list. At each
///      intersection, accumulate opacity and color contribution
///      per tetra along the ray until you reach an exiting triangle
///      (on the boundary).
///
///
/// </remarks>
/// <seealso>
///
/// vtkUnstructuredGridVolumeRayCastMapper
/// </seealso>
public class vtkUnstructuredGridBunykRayCastFunction : vtkUnstructuredGridVolumeRayCastFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridBunykRayCastFunction";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridBunykRayCastFunction()
	{
		MRClassNameKey = "class vtkUnstructuredGridBunykRayCastFunction";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridBunykRayCastFunction"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridBunykRayCastFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridBunykRayCastFunction New()
	{
		vtkUnstructuredGridBunykRayCastFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridBunykRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUnstructuredGridBunykRayCastFunction()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUnstructuredGridBunykRayCastFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridBunykRayCastFunction_Finalize_01(HandleRef pThis);

	/// <summary>
	/// Called by the ray cast mapper at the end of rendering
	/// </summary>
	public override void FinalizeWrapper()
	{
		vtkUnstructuredGridBunykRayCastFunction_Finalize_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_GetImageOrigin_02(HandleRef pThis);

	/// <summary>
	/// Access to an internal structure for the templated method.
	/// </summary>
	public virtual int[] GetImageOrigin()
	{
		IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction_GetImageOrigin_02(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridBunykRayCastFunction_GetImageOrigin_03(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Access to an internal structure for the templated method.
	/// </summary>
	public virtual void GetImageOrigin(IntPtr data)
	{
		vtkUnstructuredGridBunykRayCastFunction_GetImageOrigin_03(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_GetImageViewportSize_04(HandleRef pThis);

	/// <summary>
	/// Access to an internal structure for the templated method.
	/// </summary>
	public virtual int[] GetImageViewportSize()
	{
		IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction_GetImageViewportSize_04(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridBunykRayCastFunction_GetImageViewportSize_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Access to an internal structure for the templated method.
	/// </summary>
	public virtual void GetImageViewportSize(IntPtr data)
	{
		vtkUnstructuredGridBunykRayCastFunction_GetImageViewportSize_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridBunykRayCastFunction_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridBunykRayCastFunction_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridBunykRayCastFunction_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridBunykRayCastFunction_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_GetPoints_08(HandleRef pThis);

	/// <summary>
	/// Access to an internal structure for the templated method.
	/// </summary>
	public IntPtr GetPoints()
	{
		return vtkUnstructuredGridBunykRayCastFunction_GetPoints_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_GetViewToWorldMatrix_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access to an internal structure for the templated method.
	/// </summary>
	public virtual vtkMatrix4x4 GetViewToWorldMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction_GetViewToWorldMatrix_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridBunykRayCastFunction_Initialize_10(HandleRef pThis, HandleRef ren, HandleRef vol);

	/// <summary>
	/// Called by the ray cast mapper at the start of rendering
	/// </summary>
	public override void Initialize(vtkRenderer ren, vtkVolume vol)
	{
		vtkUnstructuredGridBunykRayCastFunction_Initialize_10(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridBunykRayCastFunction_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridBunykRayCastFunction_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridBunykRayCastFunction_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridBunykRayCastFunction_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridBunykRayCastFunction NewInstance()
	{
		vtkUnstructuredGridBunykRayCastFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridBunykRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_NewIterator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Called by the ray cast mapper at the end of rendering
	/// </summary>
	public override vtkUnstructuredGridVolumeRayCastIterator NewIterator()
	{
		vtkUnstructuredGridVolumeRayCastIterator vtkUnstructuredGridVolumeRayCastIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction_NewIterator_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridVolumeRayCastIterator2 = (vtkUnstructuredGridVolumeRayCastIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridVolumeRayCastIterator2.Register(null);
			}
		}
		return vtkUnstructuredGridVolumeRayCastIterator2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridBunykRayCastFunction SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridBunykRayCastFunction vtkUnstructuredGridBunykRayCastFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridBunykRayCastFunction2 = (vtkUnstructuredGridBunykRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridBunykRayCastFunction2.Register(null);
			}
		}
		return vtkUnstructuredGridBunykRayCastFunction2;
	}
}
