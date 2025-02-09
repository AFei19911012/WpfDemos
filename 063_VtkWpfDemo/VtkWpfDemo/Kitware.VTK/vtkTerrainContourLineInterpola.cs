using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTerrainContourLineInterpolator
/// </summary>
/// <remarks>
///    Contour interpolator for DEM data.
///
///
/// vtkTerrainContourLineInterpolator interpolates nodes on height field data.
/// The class is meant to be used in conjunciton with a vtkContourWidget,
/// enabling you to draw paths on terrain data. The class internally uses a
/// vtkProjectedTerrainPath. Users can set kind of interpolation
/// desired between two node points by setting the modes of the this filter.
/// For instance:
///
/// <code>
/// contourRepresentation-&gt;SetLineInterpolator(interpolator);
/// interpolator-&gt;SetImageData( demDataFile );
/// interpolator-&gt;GetProjector()-&gt;SetProjectionModeToHug();
/// interpolator-&gt;SetHeightOffset(25.0);
/// </code>
///
/// You are required to set the ImageData to this class as the height-field
/// image.
///
/// </remarks>
/// <seealso>
///
/// vtkTerrainDataPointPlacer vtkProjectedTerrainPath
/// </seealso>
public class vtkTerrainContourLineInterpolator : vtkContourLineInterpolator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTerrainContourLineInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTerrainContourLineInterpolator()
	{
		MRClassNameKey = "class vtkTerrainContourLineInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTerrainContourLineInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTerrainContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTerrainContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkTerrainContourLineInterpolator New()
	{
		vtkTerrainContourLineInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTerrainContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTerrainContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkTerrainContourLineInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTerrainContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTerrainContourLineInterpolator_GetImageData_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the height field data. The height field data is a 2D image. The
	/// scalars in the image represent the height field. This must be set.
	/// </summary>
	public virtual vtkImageData GetImageData()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTerrainContourLineInterpolator_GetImageData_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkTerrainContourLineInterpolator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTerrainContourLineInterpolator_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTerrainContourLineInterpolator_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTerrainContourLineInterpolator_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTerrainContourLineInterpolator_GetProjector_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkProjectedTerrainPath operator used to project the terrain
	/// onto the data. This operator has several modes, See the documentation
	/// of vtkProjectedTerrainPath. The default mode is to hug the terrain
	/// data at 0 height offset.
	/// </summary>
	public virtual vtkProjectedTerrainPath GetProjector()
	{
		vtkProjectedTerrainPath vtkProjectedTerrainPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTerrainContourLineInterpolator_GetProjector_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProjectedTerrainPath2 = (vtkProjectedTerrainPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProjectedTerrainPath2.Register(null);
			}
		}
		return vtkProjectedTerrainPath2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTerrainContourLineInterpolator_InterpolateLine_05(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

	/// <summary>
	/// Interpolate to create lines between contour nodes idx1 and idx2.
	/// Depending on the projection mode, the interpolated line may either
	/// hug the terrain, just connect the two points with a straight line or
	/// a non-occluded interpolation.
	/// Used internally by vtkContourRepresentation.
	/// </summary>
	public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
	{
		return vtkTerrainContourLineInterpolator_InterpolateLine_05(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), rep?.GetCppThis() ?? default(HandleRef), idx1, idx2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTerrainContourLineInterpolator_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTerrainContourLineInterpolator_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTerrainContourLineInterpolator_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTerrainContourLineInterpolator_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTerrainContourLineInterpolator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkTerrainContourLineInterpolator NewInstance()
	{
		vtkTerrainContourLineInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTerrainContourLineInterpolator_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTerrainContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTerrainContourLineInterpolator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkTerrainContourLineInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkTerrainContourLineInterpolator vtkTerrainContourLineInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTerrainContourLineInterpolator_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTerrainContourLineInterpolator2 = (vtkTerrainContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTerrainContourLineInterpolator2.Register(null);
			}
		}
		return vtkTerrainContourLineInterpolator2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTerrainContourLineInterpolator_SetImageData_11(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the height field data. The height field data is a 2D image. The
	/// scalars in the image represent the height field. This must be set.
	/// </summary>
	public virtual void SetImageData(vtkImageData arg0)
	{
		vtkTerrainContourLineInterpolator_SetImageData_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTerrainContourLineInterpolator_UpdateNode_12(HandleRef pThis, HandleRef arg0, HandleRef arg1, IntPtr arg2, int arg3);

	/// <summary>
	/// The interpolator is given a chance to update the node.
	/// Used internally by vtkContourRepresentation
	/// Returns 0 if the node (world position) is unchanged.
	/// </summary>
	public override int UpdateNode(vtkRenderer arg0, vtkContourRepresentation arg1, IntPtr arg2, int arg3)
	{
		return vtkTerrainContourLineInterpolator_UpdateNode_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2, arg3);
	}
}
