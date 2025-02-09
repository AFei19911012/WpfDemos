using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPicker
/// </summary>
/// <remarks>
///    superclass for 3D geometric pickers (uses ray cast)
///
/// vtkPicker is used to select instances of vtkProp3D by shooting a ray
/// into a graphics window and intersecting with the actor's bounding box.
/// The ray is defined from a point defined in window (or pixel) coordinates,
/// and a point located from the camera's position.
///
/// vtkPicker may return more than one vtkProp3D, since more than one bounding
/// box may be intersected. vtkPicker returns an unsorted list of props that
/// were hit, and a list of the corresponding world points of the hits.
/// For the vtkProp3D that is closest to the camera, vtkPicker returns the
/// pick coordinates in world and untransformed mapper space, the prop itself,
/// the data set, and the mapper.  For vtkPicker the closest prop is the one
/// whose center point (i.e., center of bounding box) projected on the view
/// ray is closest to the camera.  Subclasses of vtkPicker use other methods
/// for computing the pick point.
///
/// </remarks>
/// <seealso>
///
/// vtkPicker is used for quick geometric picking. If you desire more precise
/// picking of points or cells based on the geometry of any vtkProp3D, use the
/// subclasses vtkPointPicker or vtkCellPicker.  For hardware-accelerated
/// picking of any type of vtkProp, use vtkPropPicker or vtkWorldPointPicker.
/// </seealso>
public class vtkPicker : vtkAbstractPropPicker
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPicker";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPicker()
	{
		MRClassNameKey = "class vtkPicker";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPicker"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPicker New()
	{
		vtkPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPicker()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPicker_GetActors_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a collection of all the actors that were intersected.
	/// This collection is not sorted. (This is a convenience method
	/// to maintain backward compatibility.)
	/// </summary>
	public vtkActorCollection GetActors()
	{
		vtkActorCollection vtkActorCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPicker_GetActors_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActorCollection2 = (vtkActorCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActorCollection2.Register(null);
			}
		}
		return vtkActorCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPicker_GetCompositeDataSet_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to the composite dataset that was picked (if any). If nothing
	/// was picked or a non-composite data object was picked then NULL is returned.
	/// </summary>
	public virtual vtkCompositeDataSet GetCompositeDataSet()
	{
		vtkCompositeDataSet vtkCompositeDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPicker_GetCompositeDataSet_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataSet2 = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataSet2.Register(null);
			}
		}
		return vtkCompositeDataSet2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPicker_GetDataSet_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkPicker_GetDataSet_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPicker_GetFlatBlockIndex_04(HandleRef pThis);

	/// <summary>
	/// Get the flat block index of the vtkDataSet in the composite dataset
	/// that was picked (if any). If nothing
	/// was picked or a non-composite data object was picked then -1 is returned.
	/// </summary>
	public virtual long GetFlatBlockIndex()
	{
		return vtkPicker_GetFlatBlockIndex_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPicker_GetMapper_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return mapper that was picked (if any).
	/// </summary>
	public virtual vtkAbstractMapper3D GetMapper()
	{
		vtkAbstractMapper3D vtkAbstractMapper3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPicker_GetMapper_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPicker_GetMapperPosition_06(HandleRef pThis);

	/// <summary>
	/// Return position in mapper (i.e., non-transformed) coordinates of
	/// pick point.
	/// </summary>
	public virtual double[] GetMapperPosition()
	{
		IntPtr intPtr = vtkPicker_GetMapperPosition_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPicker_GetMapperPosition_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Return position in mapper (i.e., non-transformed) coordinates of
	/// pick point.
	/// </summary>
	public virtual void GetMapperPosition(IntPtr data)
	{
		vtkPicker_GetMapperPosition_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPicker_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPicker_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPicker_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPicker_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPicker_GetPickedPositions_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a list of the points the actors returned by GetProp3Ds
	/// were intersected at. The order of this list will match the order of
	/// GetProp3Ds.
	/// </summary>
	public vtkPoints GetPickedPositions()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPicker_GetPickedPositions_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPicker_GetProp3Ds_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkPicker_GetProp3Ds_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkPicker_GetTolerance_12(HandleRef pThis);

	/// <summary>
	/// Specify tolerance for performing pick operation. Tolerance is specified
	/// as fraction of rendering window size. (Rendering window size is measured
	/// across diagonal.)
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkPicker_GetTolerance_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPicker_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPicker_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPicker_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPicker_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPicker_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPicker NewInstance()
	{
		vtkPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPicker_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPicker_Pick_17(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

	/// <summary>
	/// Perform pick operation with selection point provided. Normally the
	/// first two values for the selection point are x-y pixel coordinate, and
	/// the third value is =0. Return non-zero if something was successfully
	/// picked.
	/// </summary>
	public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
	{
		return vtkPicker_Pick_17(GetCppThis(), selectionX, selectionY, selectionZ, renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPicker_Pick_18(HandleRef pThis, IntPtr selectionPt, HandleRef ren);

	/// <summary>
	/// Perform pick operation with selection point provided. Normally the first
	/// two values for the selection point are x-y pixel coordinate, and the
	/// third value is =0. Return non-zero if something was successfully picked.
	/// </summary>
	public new int Pick(IntPtr selectionPt, vtkRenderer ren)
	{
		return vtkPicker_Pick_18(GetCppThis(), selectionPt, ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPicker_Pick3DPoint_19(HandleRef pThis, IntPtr selectionPt, HandleRef ren);

	/// <summary>
	/// Perform pick operation with selection point provided. The
	/// selectionPt is in world coordinates.
	/// Return non-zero if something was successfully picked.
	/// </summary>
	public override int Pick3DPoint(IntPtr selectionPt, vtkRenderer ren)
	{
		return vtkPicker_Pick3DPoint_19(GetCppThis(), selectionPt, ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPicker_Pick3DPoint_20(HandleRef pThis, IntPtr p1World, IntPtr p2World, HandleRef ren);

	/// <summary>
	/// Perform pick operation with selection point provided. The
	/// selectionPt is in world coordinates.
	/// Return non-zero if something was successfully picked.
	/// </summary>
	public virtual int Pick3DPoint(IntPtr p1World, IntPtr p2World, vtkRenderer ren)
	{
		return vtkPicker_Pick3DPoint_20(GetCppThis(), p1World, p2World, ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPicker_Pick3DRay_21(HandleRef pThis, IntPtr selectionPt, IntPtr orient, HandleRef ren);

	/// <summary>
	/// Perform pick operation with selection point and orientation provided.
	/// The selectionPt is in world coordinates.
	/// Return non-zero if something was successfully picked.
	/// </summary>
	public override int Pick3DRay(IntPtr selectionPt, IntPtr orient, vtkRenderer ren)
	{
		return vtkPicker_Pick3DRay_21(GetCppThis(), selectionPt, orient, ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPicker_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPicker SafeDownCast(vtkObjectBase o)
	{
		vtkPicker vtkPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPicker_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPicker2 = (vtkPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPicker2.Register(null);
			}
		}
		return vtkPicker2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPicker_SetTolerance_23(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify tolerance for performing pick operation. Tolerance is specified
	/// as fraction of rendering window size. (Rendering window size is measured
	/// across diagonal.)
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkPicker_SetTolerance_23(GetCppThis(), _arg);
	}
}
