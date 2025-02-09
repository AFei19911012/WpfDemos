using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHardwarePicker
/// </summary>
/// <remarks>
///    pick a point or snap to point of an actor/prop using graphics hardware
///
/// vtkHardwarePicker is used to pick point or snap to point of an actor/prop given a selection
/// point (in display coordinates) and a renderer. This class uses graphics hardware/rendering
/// system to pick rapidly (as compared to using ray casting as does vtkCellPicker and
/// vtkPointPicker). This class determines the actor/prop pick position, and pick normal in world
/// coordinates; pointId is determined if snapping is enabled, otherwise the cellId is determined.
/// if no actor/prop is picked, pick position = camera focal point, and pick normal = camera plane
/// normal.
///
/// @warning This class supports only picking in a screen, and not in VR.
///
/// </remarks>
/// <seealso>
///
/// vtkPropPicker vtkPicker vtkWorldPointPicker vtkCellPicker vtkPointPicker
/// </seealso>
public class vtkHardwarePicker : vtkAbstractPropPicker
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHardwarePicker";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHardwarePicker()
	{
		MRClassNameKey = "class vtkHardwarePicker";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHardwarePicker"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHardwarePicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwarePicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHardwarePicker New()
	{
		vtkHardwarePicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwarePicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHardwarePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkHardwarePicker()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHardwarePicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkHardwarePicker_GetCellId_01(HandleRef pThis);

	/// <summary>
	/// Get the id of the picked cell.
	///
	/// If a prop is picked:
	///
	/// 1) If SnapOnMeshPoint is on, CellId = -1.
	/// 2) If SnapOnMeshPoint is off, the cellId of the prop's dataset will be returned
	///
	/// if a prop is not picked, CellId = -1.
	/// </summary>
	public virtual long GetCellId()
	{
		return vtkHardwarePicker_GetCellId_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwarePicker_GetCompositeDataSet_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to the composite dataset that was picked (if any). If nothing
	/// was picked or a non-composite data object was picked then nullptr is returned.
	///
	/// Note: Use vtkWeakPointer. This is because the CompositeDataSet may be deleted.
	/// </summary>
	public virtual vtkCompositeDataSet GetCompositeDataSet()
	{
		vtkCompositeDataSet vtkCompositeDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwarePicker_GetCompositeDataSet_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHardwarePicker_GetDataSet_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to the dataset that was picked (if any). If nothing
	/// was picked then nullptr is returned.
	///
	/// Note: Use vtkWeakPointer. This is because the DataSet may be deleted.
	/// </summary>
	public virtual vtkDataSet GetDataSet()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwarePicker_GetDataSet_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkHardwarePicker_GetFlatBlockIndex_04(HandleRef pThis);

	/// <summary>
	/// Get the flat block index of the vtkDataSet in the composite dataset
	/// that was picked (if any). If nothing was picked or a non-composite
	/// data object was picked then -1 is returned.
	/// </summary>
	public virtual long GetFlatBlockIndex()
	{
		return vtkHardwarePicker_GetFlatBlockIndex_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwarePicker_GetMapper_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return mapper that was picked (if any).
	///
	/// Note: Use vtkWeakPointer. This is because the Mapper may be deleted.
	/// </summary>
	public virtual vtkAbstractMapper3D GetMapper()
	{
		vtkAbstractMapper3D vtkAbstractMapper3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwarePicker_GetMapper_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkHardwarePicker_GetNormalFlipped_06(HandleRef pThis);

	/// <summary>
	/// Get if normal is flipped.
	///
	/// The normal will be flipped if point normals don't exist and the angle between the PickedNormal
	/// and the camera plane normal is more than pi / 2.
	/// </summary>
	public virtual bool GetNormalFlipped()
	{
		return (vtkHardwarePicker_GetNormalFlipped_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHardwarePicker_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHardwarePicker_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHardwarePicker_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHardwarePicker_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwarePicker_GetPCoords_09(HandleRef pThis);

	/// <summary>
	/// Get the parametric coordinates of the picked cell. PCoords can be used to compute the
	/// weights that are needed to interpolate data values within the cell.
	///
	/// If a prop is picked:
	///
	/// 1) If SnapOnMeshPoint is on, PCoords will be a vector of
	/// std::numeric_limits&lt;double&gt;::quiet_NaN().
	/// 2) If SnapOnMeshPoint is off, PCoords will be extracted and the intersection point of the cell.
	///
	/// if a prop is not picked, PCoords will be a vector of std::numeric_limits&lt;double&gt;::quiet_NaN().
	/// </summary>
	public virtual double[] GetPCoords()
	{
		IntPtr intPtr = vtkHardwarePicker_GetPCoords_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwarePicker_GetPCoords_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the parametric coordinates of the picked cell. PCoords can be used to compute the
	/// weights that are needed to interpolate data values within the cell.
	///
	/// If a prop is picked:
	///
	/// 1) If SnapOnMeshPoint is on, PCoords will be a vector of
	/// std::numeric_limits&lt;double&gt;::quiet_NaN().
	/// 2) If SnapOnMeshPoint is off, PCoords will be extracted and the intersection point of the cell.
	///
	/// if a prop is not picked, PCoords will be a vector of std::numeric_limits&lt;double&gt;::quiet_NaN().
	/// </summary>
	public virtual void GetPCoords(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkHardwarePicker_GetPCoords_10(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwarePicker_GetPCoords_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the parametric coordinates of the picked cell. PCoords can be used to compute the
	/// weights that are needed to interpolate data values within the cell.
	///
	/// If a prop is picked:
	///
	/// 1) If SnapOnMeshPoint is on, PCoords will be a vector of
	/// std::numeric_limits&lt;double&gt;::quiet_NaN().
	/// 2) If SnapOnMeshPoint is off, PCoords will be extracted and the intersection point of the cell.
	///
	/// if a prop is not picked, PCoords will be a vector of std::numeric_limits&lt;double&gt;::quiet_NaN().
	/// </summary>
	public virtual void GetPCoords(IntPtr _arg)
	{
		vtkHardwarePicker_GetPCoords_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwarePicker_GetPickNormal_12(HandleRef pThis);

	/// <summary>
	/// Get the normal of the point at the PickPosition.
	///
	/// If a prop is picked:
	///
	/// 1) If SnapOnMeshPoint is on, the picked normal will be extracted from the PointData normals, if
	/// they exist, otherwise a vector of std::numeric_limits&lt;double&gt;::quiet_NaN() will be returned.
	/// 2) If SnapOnMeshPoint is off, the picked normal on the intersected cell will be extracted using
	/// ray intersection, if the ray intersections was successful, otherwise a vector of
	/// std::numeric_limits&lt;double&gt;::quiet_NaN() will be returned.
	///
	/// if a prop is not picked, the camera plane normal will be returned will be returned.
	/// </summary>
	public virtual double[] GetPickNormal()
	{
		IntPtr intPtr = vtkHardwarePicker_GetPickNormal_12(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwarePicker_GetPickNormal_13(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Get the normal of the point at the PickPosition.
	///
	/// If a prop is picked:
	///
	/// 1) If SnapOnMeshPoint is on, the picked normal will be extracted from the PointData normals, if
	/// they exist, otherwise a vector of std::numeric_limits&lt;double&gt;::quiet_NaN() will be returned.
	/// 2) If SnapOnMeshPoint is off, the picked normal on the intersected cell will be extracted using
	/// ray intersection, if the ray intersections was successful, otherwise a vector of
	/// std::numeric_limits&lt;double&gt;::quiet_NaN() will be returned.
	///
	/// if a prop is not picked, the camera plane normal will be returned will be returned.
	/// </summary>
	public virtual void GetPickNormal(IntPtr data)
	{
		vtkHardwarePicker_GetPickNormal_13(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHardwarePicker_GetPixelTolerance_14(HandleRef pThis);

	/// <summary>
	/// When SnapToMeshPoint is on, this is the pixel tolerance to use when snapping.
	/// Default is 5.
	/// </summary>
	public virtual int GetPixelTolerance()
	{
		return vtkHardwarePicker_GetPixelTolerance_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHardwarePicker_GetPointId_15(HandleRef pThis);

	/// <summary>
	/// Get the id of the picked point.
	///
	/// If a prop is picked:
	///
	/// 1) if SnapOnMeshPoint is on, the pointId of the prop's dataset will be returned
	/// 2) If SnapOnMeshPoint is off, PointId = -1;
	///
	/// If a prop is not picked, PointId = -1;
	/// </summary>
	public virtual long GetPointId()
	{
		return vtkHardwarePicker_GetPointId_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHardwarePicker_GetSnapToMeshPoint_16(HandleRef pThis);

	/// <summary>
	/// Set/Get if the picker will snap to the closest mesh point or get the actual intersected point.
	/// Default is off.
	/// </summary>
	public virtual bool GetSnapToMeshPoint()
	{
		return (vtkHardwarePicker_GetSnapToMeshPoint_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHardwarePicker_GetSubId_17(HandleRef pThis);

	/// <summary>
	/// Get the subId of the picked cell. This is useful, for example, if
	/// the data is made of triangle strips.
	///
	/// If a prop is picked:
	///
	/// 1) If SnapOnMeshPoint is on, SubId = -1.
	/// 2) If SnapOnMeshPoint is off and the picked cell is a triangle strip, the subId of the
	/// intersected triangle will be returned, otherwise SubId = -1.
	///
	/// If a prop is not picked, SubId = -1.
	/// </summary>
	public virtual int GetSubId()
	{
		return vtkHardwarePicker_GetSubId_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHardwarePicker_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHardwarePicker_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHardwarePicker_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHardwarePicker_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwarePicker_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHardwarePicker NewInstance()
	{
		vtkHardwarePicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwarePicker_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHardwarePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHardwarePicker_Pick_22(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

	/// <summary>
	/// Perform the pick operation set the PickedProp.
	///
	/// If something is picked, 1 is returned, and PickPosition, PickNormal, and the rest of the
	/// results variables) are extracted from intersection with the PickedProp.
	///
	/// If something is not picked, 0 is returned, and PickPosition and PickNormal are extracted from
	/// the camera's focal plane.
	/// </summary>
	public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
	{
		return vtkHardwarePicker_Pick_22(GetCppThis(), selectionX, selectionY, selectionZ, renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwarePicker_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHardwarePicker SafeDownCast(vtkObjectBase o)
	{
		vtkHardwarePicker vtkHardwarePicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwarePicker_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHardwarePicker2 = (vtkHardwarePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHardwarePicker2.Register(null);
			}
		}
		return vtkHardwarePicker2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwarePicker_SetPixelTolerance_24(HandleRef pThis, int _arg);

	/// <summary>
	/// When SnapToMeshPoint is on, this is the pixel tolerance to use when snapping.
	/// Default is 5.
	/// </summary>
	public virtual void SetPixelTolerance(int _arg)
	{
		vtkHardwarePicker_SetPixelTolerance_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwarePicker_SetSnapToMeshPoint_25(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if the picker will snap to the closest mesh point or get the actual intersected point.
	/// Default is off.
	/// </summary>
	public virtual void SetSnapToMeshPoint(bool _arg)
	{
		vtkHardwarePicker_SetSnapToMeshPoint_25(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwarePicker_SnapToMeshPointOff_26(HandleRef pThis);

	/// <summary>
	/// Set/Get if the picker will snap to the closest mesh point or get the actual intersected point.
	/// Default is off.
	/// </summary>
	public virtual void SnapToMeshPointOff()
	{
		vtkHardwarePicker_SnapToMeshPointOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwarePicker_SnapToMeshPointOn_27(HandleRef pThis);

	/// <summary>
	/// Set/Get if the picker will snap to the closest mesh point or get the actual intersected point.
	/// Default is off.
	/// </summary>
	public virtual void SnapToMeshPointOn()
	{
		vtkHardwarePicker_SnapToMeshPointOn_27(GetCppThis());
	}
}
