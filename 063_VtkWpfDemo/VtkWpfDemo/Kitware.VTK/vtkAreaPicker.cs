using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAreaPicker
/// </summary>
/// <remarks>
///    Picks props behind a selection rectangle on a viewport.
///
///
/// The vtkAreaPicker picks all vtkProp3Ds that lie behind the screen space
/// rectangle from x0,y0 and x1,y1. The selection is based upon the bounding
/// box of the prop and is thus not exact.
///
/// Like vtkPicker, a pick results in a list of Prop3Ds because many props may
/// lie within the pick frustum. You can also get an AssemblyPath, which in this
/// case is defined to be the path to the one particular prop in the Prop3D list
/// that lies nearest to the near plane.
///
/// This picker also returns the selection frustum, defined as either a
/// vtkPlanes, or a set of eight corner vertices in world space. The vtkPlanes
/// version is an ImplicitFunction, which is suitable for use with the
/// vtkExtractGeometry. The six frustum planes are in order: left, right,
/// bottom, top, near, far
///
/// Because this picker picks everything within a volume, the world pick point
/// result is ill-defined. Therefore if you ask this class for the world pick
/// position, you will get the centroid of the pick frustum. This may be outside
/// of all props in the prop list.
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorStyleRubberBandPick, vtkExtractSelectedFrustum.
/// </seealso>
public class vtkAreaPicker : vtkAbstractPropPicker
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAreaPicker";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAreaPicker()
	{
		MRClassNameKey = "class vtkAreaPicker";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAreaPicker"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAreaPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAreaPicker New()
	{
		vtkAreaPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAreaPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAreaPicker()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAreaPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAreaPicker_AreaPick_01(HandleRef pThis, double x0, double y0, double x1, double y1, HandleRef renderer);

	/// <summary>
	/// Perform pick operation in volume behind the given screen coordinates.
	/// Props intersecting the selection frustum will be accessible via GetProp3D.
	/// GetPlanes returns a vtkImplicitFunction suitable for vtkExtractGeometry.
	/// </summary>
	public virtual int AreaPick(double x0, double y0, double x1, double y1, vtkRenderer renderer)
	{
		return vtkAreaPicker_AreaPick_01(GetCppThis(), x0, y0, x1, y1, renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaPicker_GetClipPoints_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return eight points that define the selection frustum.
	/// </summary>
	public virtual vtkPoints GetClipPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaPicker_GetClipPoints_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaPicker_GetDataSet_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to the dataset that was picked (if any). If nothing
	/// was picked then NULL is returned.
	/// </summary>
	public virtual vtkDataSet GetDataSet()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaPicker_GetDataSet_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaPicker_GetFrustum_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the six planes that define the selection frustum. The implicit
	/// function defined by the planes evaluates to negative inside and positive
	/// outside.
	/// </summary>
	public virtual vtkPlanes GetFrustum()
	{
		vtkPlanes vtkPlanes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaPicker_GetFrustum_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlanes2 = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlanes2.Register(null);
			}
		}
		return vtkPlanes2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaPicker_GetMapper_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return mapper that was picked (if any).
	/// </summary>
	public virtual vtkAbstractMapper3D GetMapper()
	{
		vtkAbstractMapper3D vtkAbstractMapper3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaPicker_GetMapper_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractMapper3D2 = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractMapper3D2.Register(null);
			}
		}
		return vtkAbstractMapper3D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAreaPicker_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAreaPicker_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAreaPicker_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAreaPicker_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaPicker_GetProp3Ds_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a collection of all the prop 3D's that were intersected
	/// by the pick ray. This collection is not sorted.
	/// </summary>
	public vtkProp3DCollection GetProp3Ds()
	{
		vtkProp3DCollection vtkProp3DCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaPicker_GetProp3Ds_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp3DCollection2 = (vtkProp3DCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp3DCollection2.Register(null);
			}
		}
		return vtkProp3DCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAreaPicker_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAreaPicker_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAreaPicker_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAreaPicker_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaPicker_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAreaPicker NewInstance()
	{
		vtkAreaPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaPicker_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAreaPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAreaPicker_Pick_13(HandleRef pThis);

	/// <summary>
	/// Perform an AreaPick within the default screen rectangle and renderer.
	/// </summary>
	public virtual int Pick()
	{
		return vtkAreaPicker_Pick_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAreaPicker_Pick_14(HandleRef pThis, double x0, double y0, double arg2, HandleRef renderer);

	/// <summary>
	/// Perform pick operation in volume behind the given screen coordinate.
	/// This makes a thin frustum around the selected pixel.
	/// Note: this ignores Z in order to pick everying in a volume from z=0 to z=1.
	/// </summary>
	public override int Pick(double x0, double y0, double arg2, vtkRenderer renderer)
	{
		return vtkAreaPicker_Pick_14(GetCppThis(), x0, y0, arg2, renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaPicker_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAreaPicker SafeDownCast(vtkObjectBase o)
	{
		vtkAreaPicker vtkAreaPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaPicker_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAreaPicker2 = (vtkAreaPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAreaPicker2.Register(null);
			}
		}
		return vtkAreaPicker2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaPicker_SetPickCoords_16(HandleRef pThis, double x0, double y0, double x1, double y1);

	/// <summary>
	/// Set the default screen rectangle to pick in.
	/// </summary>
	public void SetPickCoords(double x0, double y0, double x1, double y1)
	{
		vtkAreaPicker_SetPickCoords_16(GetCppThis(), x0, y0, x1, y1);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaPicker_SetRenderer_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the default renderer to pick on.
	/// </summary>
	public void SetRenderer(vtkRenderer arg0)
	{
		vtkAreaPicker_SetRenderer_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
