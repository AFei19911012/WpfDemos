using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDijkstraImageContourLineInterpolator
/// </summary>
/// <remarks>
///    Contour interpolator for placing points on an image.
///
///
/// vtkDijkstraImageContourLineInterpolator interpolates and places
/// contour points on images. The class interpolates nodes by
/// computing a graph laying on the image data. By graph, we mean
/// that the line interpolating the two end points traverses along
/// pixels so as to form a shortest path. A Dijkstra algorithm is
/// used to compute the path.
///
/// The class is meant to be used in conjunction with
/// vtkImageActorPointPlacer. One reason for this coupling is a
/// performance issue: both classes need to perform a cell pick, and
/// coupling avoids multiple cell picks (cell picks are slow).  Another
/// issue is that the interpolator may need to set the image input to
/// its vtkDijkstraImageGeodesicPath ivar.
///
/// </remarks>
/// <seealso>
///
/// vtkContourWidget vtkContourLineInterpolator vtkDijkstraImageGeodesicPath
/// </seealso>
public class vtkDijkstraImageContourLineInterpolator : vtkContourLineInterpolator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDijkstraImageContourLineInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDijkstraImageContourLineInterpolator()
	{
		MRClassNameKey = "class vtkDijkstraImageContourLineInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDijkstraImageContourLineInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDijkstraImageContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkDijkstraImageContourLineInterpolator New()
	{
		vtkDijkstraImageContourLineInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDijkstraImageContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDijkstraImageContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public vtkDijkstraImageContourLineInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDijkstraImageContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_GetCostImage_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the image data for the vtkDijkstraImageGeodesicPath.
	/// If not set, the interpolator uses the image data input to the image actor.
	/// The image actor is obtained from the expected vtkImageActorPointPlacer.
	/// </summary>
	public virtual vtkImageData GetCostImage()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDijkstraImageContourLineInterpolator_GetCostImage_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_GetDijkstraImageGeodesicPath_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// access to the internal dijkstra path
	/// </summary>
	public virtual vtkDijkstraImageGeodesicPath GetDijkstraImageGeodesicPath()
	{
		vtkDijkstraImageGeodesicPath vtkDijkstraImageGeodesicPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDijkstraImageContourLineInterpolator_GetDijkstraImageGeodesicPath_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDijkstraImageGeodesicPath2 = (vtkDijkstraImageGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDijkstraImageGeodesicPath2.Register(null);
			}
		}
		return vtkDijkstraImageGeodesicPath2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDijkstraImageContourLineInterpolator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDijkstraImageContourLineInterpolator_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDijkstraImageContourLineInterpolator_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDijkstraImageContourLineInterpolator_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDijkstraImageContourLineInterpolator_InterpolateLine_05(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

	/// <summary>
	/// Subclasses that wish to interpolate a line segment must implement this.
	/// For instance vtkBezierContourLineInterpolator adds nodes between idx1
	/// and idx2, that allow the contour to adhere to a bezier curve.
	/// </summary>
	public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
	{
		return vtkDijkstraImageContourLineInterpolator_InterpolateLine_05(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), rep?.GetCppThis() ?? default(HandleRef), idx1, idx2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDijkstraImageContourLineInterpolator_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDijkstraImageContourLineInterpolator_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDijkstraImageContourLineInterpolator_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDijkstraImageContourLineInterpolator_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkDijkstraImageContourLineInterpolator NewInstance()
	{
		vtkDijkstraImageContourLineInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDijkstraImageContourLineInterpolator_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDijkstraImageContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkDijkstraImageContourLineInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkDijkstraImageContourLineInterpolator vtkDijkstraImageContourLineInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDijkstraImageContourLineInterpolator_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDijkstraImageContourLineInterpolator2 = (vtkDijkstraImageContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDijkstraImageContourLineInterpolator2.Register(null);
			}
		}
		return vtkDijkstraImageContourLineInterpolator2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDijkstraImageContourLineInterpolator_SetCostImage_11(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the image data for the vtkDijkstraImageGeodesicPath.
	/// If not set, the interpolator uses the image data input to the image actor.
	/// The image actor is obtained from the expected vtkImageActorPointPlacer.
	/// </summary>
	public virtual void SetCostImage(vtkImageData arg0)
	{
		vtkDijkstraImageContourLineInterpolator_SetCostImage_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
