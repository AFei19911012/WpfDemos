using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProjectedTetrahedraMapper
/// </summary>
/// <remarks>
///    Unstructured grid volume renderer.
///
///
/// vtkProjectedTetrahedraMapper is an implementation of the classic
/// Projected Tetrahedra algorithm presented by Shirley and Tuchman in "A
/// Polygonal Approximation to Direct Scalar Volume Rendering" in Computer
/// Graphics, December 1990.
///
/// @bug
/// This mapper relies highly on the implementation of the OpenGL pipeline.
/// A typical hardware driver has lots of options and some settings can
/// cause this mapper to produce artifacts.
///
/// </remarks>
public abstract class vtkProjectedTetrahedraMapper : vtkUnstructuredGridVolumeMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProjectedTetrahedraMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProjectedTetrahedraMapper()
	{
		MRClassNameKey = "class vtkProjectedTetrahedraMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectedTetrahedraMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProjectedTetrahedraMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTetrahedraMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProjectedTetrahedraMapper New()
	{
		vtkProjectedTetrahedraMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectedTetrahedraMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProjectedTetrahedraMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProjectedTetrahedraMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkProjectedTetrahedraMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProjectedTetrahedraMapper_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProjectedTetrahedraMapper_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProjectedTetrahedraMapper_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTetrahedraMapper_GetVisibilitySort_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkVisibilitySort GetVisibilitySort()
	{
		vtkVisibilitySort vtkVisibilitySort2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectedTetrahedraMapper_GetVisibilitySort_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVisibilitySort2 = (vtkVisibilitySort)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVisibilitySort2.Register(null);
			}
		}
		return vtkVisibilitySort2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectedTetrahedraMapper_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProjectedTetrahedraMapper_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProjectedTetrahedraMapper_IsSupported_05(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Return true if the rendering context provides
	/// the nececessary functionality to use this class.
	/// </summary>
	public virtual bool IsSupported(vtkRenderWindow arg0)
	{
		return (vtkProjectedTetrahedraMapper_IsSupported_05(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectedTetrahedraMapper_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProjectedTetrahedraMapper_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTetrahedraMapper_MapScalarsToColors_07(HandleRef colors, HandleRef property, HandleRef scalars);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static void MapScalarsToColors(vtkDataArray colors, vtkVolumeProperty property, vtkDataArray scalars)
	{
		vtkProjectedTetrahedraMapper_MapScalarsToColors_07(colors?.GetCppThis() ?? default(HandleRef), property?.GetCppThis() ?? default(HandleRef), scalars?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTetrahedraMapper_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProjectedTetrahedraMapper NewInstance()
	{
		vtkProjectedTetrahedraMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectedTetrahedraMapper_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTetrahedraMapper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProjectedTetrahedraMapper SafeDownCast(vtkObjectBase o)
	{
		vtkProjectedTetrahedraMapper vtkProjectedTetrahedraMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectedTetrahedraMapper_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProjectedTetrahedraMapper2 = (vtkProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProjectedTetrahedraMapper2.Register(null);
			}
		}
		return vtkProjectedTetrahedraMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTetrahedraMapper_SetVisibilitySort_11(HandleRef pThis, HandleRef sort);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetVisibilitySort(vtkVisibilitySort sort)
	{
		vtkProjectedTetrahedraMapper_SetVisibilitySort_11(GetCppThis(), sort?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTetrahedraMapper_TransformPoints_12(HandleRef inPoints, IntPtr projection_mat, IntPtr modelview_mat, HandleRef outPoints);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static void TransformPoints(vtkPoints inPoints, IntPtr projection_mat, IntPtr modelview_mat, vtkFloatArray outPoints)
	{
		vtkProjectedTetrahedraMapper_TransformPoints_12(inPoints?.GetCppThis() ?? default(HandleRef), projection_mat, modelview_mat, outPoints?.GetCppThis() ?? default(HandleRef));
	}
}
