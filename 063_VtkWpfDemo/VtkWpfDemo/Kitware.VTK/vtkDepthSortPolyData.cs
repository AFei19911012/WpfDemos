using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDepthSortPolyData
/// </summary>
/// <remarks>
///    sort poly data along camera view direction
///
/// vtkDepthSortPolyData rearranges the order of cells so that certain
/// rendering operations (e.g., transparency or Painter's algorithms)
/// generate correct results. To use this filter you must specify the
/// direction vector along which to sort the cells. You can do this by
/// specifying a camera and/or prop to define a view direction; or
/// explicitly set a view direction.
///
/// @warning
/// The sort operation will not work well for long, thin primitives, or cells
/// that intersect, overlap, or interpenetrate each other.
/// </remarks>
public class vtkDepthSortPolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Instantiate object.
	/// </summary>
	public enum Directions
	{
		/// <summary>enum member</summary>
		VTK_DIRECTION_BACK_TO_FRONT,
		/// <summary>enum member</summary>
		VTK_DIRECTION_FRONT_TO_BACK,
		/// <summary>enum member</summary>
		VTK_DIRECTION_SPECIFIED_VECTOR
	}

	/// <summary>
	/// Specify the sort method for the polygonal primitives. By default, the
	/// poly data is sorted from back to front.
	/// </summary>
	public enum SortMode
	{
		/// <summary>enum member</summary>
		VTK_SORT_BOUNDS_CENTER = 1,
		/// <summary>enum member</summary>
		VTK_SORT_FIRST_POINT = 0,
		/// <summary>enum member</summary>
		VTK_SORT_PARAMETRIC_CENTER = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDepthSortPolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDepthSortPolyData()
	{
		MRClassNameKey = "class vtkDepthSortPolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDepthSortPolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDepthSortPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthSortPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new static vtkDepthSortPolyData New()
	{
		vtkDepthSortPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthSortPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDepthSortPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public vtkDepthSortPolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDepthSortPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthSortPolyData_GetCamera_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a camera that is used to define a view direction along which
	/// the cells are sorted. This ivar only has effect if the direction is set
	/// to front-to-back or back-to-front, and a camera is specified.
	/// </summary>
	public virtual vtkCamera GetCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthSortPolyData_GetCamera_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCamera2 = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCamera2.Register(null);
			}
		}
		return vtkCamera2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDepthSortPolyData_GetDepthSortMode_02(HandleRef pThis);

	/// <summary>
	/// Specify the point to use when sorting. The fastest is to just
	/// take the first cell point. Other options are to take the bounding
	/// box center or the parametric center of the cell. By default, the
	/// first cell point is used.
	/// </summary>
	public virtual int GetDepthSortMode()
	{
		return vtkDepthSortPolyData_GetDepthSortMode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDepthSortPolyData_GetDirection_03(HandleRef pThis);

	/// <summary>
	/// Specify the sort method for the polygonal primitives. By default, the
	/// poly data is sorted from back to front.
	/// </summary>
	public virtual int GetDirection()
	{
		return vtkDepthSortPolyData_GetDirection_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDepthSortPolyData_GetMTime_04(HandleRef pThis);

	/// <summary>
	/// Return MTime also considering the dependent objects: the camera
	/// and/or the prop3D.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkDepthSortPolyData_GetMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDepthSortPolyData_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDepthSortPolyData_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDepthSortPolyData_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDepthSortPolyData_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthSortPolyData_GetOrigin_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the sort origin. This ivar only has effect if the sort
	/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
	/// in the direction of the vector, with this point specifying the
	/// origin.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkDepthSortPolyData_GetOrigin_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_GetOrigin_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the sort origin. This ivar only has effect if the sort
	/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
	/// in the direction of the vector, with this point specifying the
	/// origin.
	/// </summary>
	public virtual void GetOrigin(IntPtr data)
	{
		vtkDepthSortPolyData_GetOrigin_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthSortPolyData_GetProp3D_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a transformation matrix (via the vtkProp3D::GetMatrix() method)
	/// that is used to include the effects of transformation. This ivar only
	/// has effect if the direction is set to front-to-back or back-to-front,
	/// and a camera is specified. Specifying the vtkProp3D is optional.
	/// </summary>
	public vtkProp3D GetProp3D()
	{
		vtkProp3D vtkProp3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthSortPolyData_GetProp3D_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp3D2 = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp3D2.Register(null);
			}
		}
		return vtkProp3D2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDepthSortPolyData_GetSortScalars_10(HandleRef pThis);

	/// <summary>
	/// Set/Get a flag that controls the generation of scalar values
	/// corresponding to the sort order. If enabled, the output of this
	/// filter will include scalar values that range from 0 to (ncells-1),
	/// where 0 is closest to the sort direction.
	/// </summary>
	public virtual int GetSortScalars()
	{
		return vtkDepthSortPolyData_GetSortScalars_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthSortPolyData_GetVector_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the sort direction. This ivar only has effect if the sort
	/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
	/// in the direction of the vector.
	/// </summary>
	public virtual double[] GetVector()
	{
		IntPtr intPtr = vtkDepthSortPolyData_GetVector_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_GetVector_12(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the sort direction. This ivar only has effect if the sort
	/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
	/// in the direction of the vector.
	/// </summary>
	public virtual void GetVector(IntPtr data)
	{
		vtkDepthSortPolyData_GetVector_12(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDepthSortPolyData_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDepthSortPolyData_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDepthSortPolyData_IsTypeOf_14(string type);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDepthSortPolyData_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthSortPolyData_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new vtkDepthSortPolyData NewInstance()
	{
		vtkDepthSortPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthSortPolyData_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDepthSortPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthSortPolyData_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new static vtkDepthSortPolyData SafeDownCast(vtkObjectBase o)
	{
		vtkDepthSortPolyData vtkDepthSortPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthSortPolyData_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDepthSortPolyData2 = (vtkDepthSortPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDepthSortPolyData2.Register(null);
			}
		}
		return vtkDepthSortPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetCamera_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify a camera that is used to define a view direction along which
	/// the cells are sorted. This ivar only has effect if the direction is set
	/// to front-to-back or back-to-front, and a camera is specified.
	/// </summary>
	public virtual void SetCamera(vtkCamera arg0)
	{
		vtkDepthSortPolyData_SetCamera_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetDepthSortMode_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the point to use when sorting. The fastest is to just
	/// take the first cell point. Other options are to take the bounding
	/// box center or the parametric center of the cell. By default, the
	/// first cell point is used.
	/// </summary>
	public virtual void SetDepthSortMode(int _arg)
	{
		vtkDepthSortPolyData_SetDepthSortMode_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetDepthSortModeToBoundsCenter_20(HandleRef pThis);

	/// <summary>
	/// Specify the point to use when sorting. The fastest is to just
	/// take the first cell point. Other options are to take the bounding
	/// box center or the parametric center of the cell. By default, the
	/// first cell point is used.
	/// </summary>
	public void SetDepthSortModeToBoundsCenter()
	{
		vtkDepthSortPolyData_SetDepthSortModeToBoundsCenter_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetDepthSortModeToFirstPoint_21(HandleRef pThis);

	/// <summary>
	/// Specify the point to use when sorting. The fastest is to just
	/// take the first cell point. Other options are to take the bounding
	/// box center or the parametric center of the cell. By default, the
	/// first cell point is used.
	/// </summary>
	public void SetDepthSortModeToFirstPoint()
	{
		vtkDepthSortPolyData_SetDepthSortModeToFirstPoint_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetDepthSortModeToParametricCenter_22(HandleRef pThis);

	/// <summary>
	/// Specify the point to use when sorting. The fastest is to just
	/// take the first cell point. Other options are to take the bounding
	/// box center or the parametric center of the cell. By default, the
	/// first cell point is used.
	/// </summary>
	public void SetDepthSortModeToParametricCenter()
	{
		vtkDepthSortPolyData_SetDepthSortModeToParametricCenter_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetDirection_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the sort method for the polygonal primitives. By default, the
	/// poly data is sorted from back to front.
	/// </summary>
	public virtual void SetDirection(int _arg)
	{
		vtkDepthSortPolyData_SetDirection_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetDirectionToBackToFront_24(HandleRef pThis);

	/// <summary>
	/// Specify the sort method for the polygonal primitives. By default, the
	/// poly data is sorted from back to front.
	/// </summary>
	public void SetDirectionToBackToFront()
	{
		vtkDepthSortPolyData_SetDirectionToBackToFront_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetDirectionToFrontToBack_25(HandleRef pThis);

	/// <summary>
	/// Specify the sort method for the polygonal primitives. By default, the
	/// poly data is sorted from back to front.
	/// </summary>
	public void SetDirectionToFrontToBack()
	{
		vtkDepthSortPolyData_SetDirectionToFrontToBack_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetDirectionToSpecifiedVector_26(HandleRef pThis);

	/// <summary>
	/// Specify the sort method for the polygonal primitives. By default, the
	/// poly data is sorted from back to front.
	/// </summary>
	public void SetDirectionToSpecifiedVector()
	{
		vtkDepthSortPolyData_SetDirectionToSpecifiedVector_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetOrigin_27(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the sort origin. This ivar only has effect if the sort
	/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
	/// in the direction of the vector, with this point specifying the
	/// origin.
	/// </summary>
	public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkDepthSortPolyData_SetOrigin_27(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetOrigin_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the sort origin. This ivar only has effect if the sort
	/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
	/// in the direction of the vector, with this point specifying the
	/// origin.
	/// </summary>
	public virtual void SetOrigin(IntPtr _arg)
	{
		vtkDepthSortPolyData_SetOrigin_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetProp3D_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify a transformation matrix (via the vtkProp3D::GetMatrix() method)
	/// that is used to include the effects of transformation. This ivar only
	/// has effect if the direction is set to front-to-back or back-to-front,
	/// and a camera is specified. Specifying the vtkProp3D is optional.
	/// </summary>
	public void SetProp3D(vtkProp3D arg0)
	{
		vtkDepthSortPolyData_SetProp3D_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetSortScalars_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get a flag that controls the generation of scalar values
	/// corresponding to the sort order. If enabled, the output of this
	/// filter will include scalar values that range from 0 to (ncells-1),
	/// where 0 is closest to the sort direction.
	/// </summary>
	public virtual void SetSortScalars(int _arg)
	{
		vtkDepthSortPolyData_SetSortScalars_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetVector_31(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the sort direction. This ivar only has effect if the sort
	/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
	/// in the direction of the vector.
	/// </summary>
	public virtual void SetVector(double _arg1, double _arg2, double _arg3)
	{
		vtkDepthSortPolyData_SetVector_31(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SetVector_32(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the sort direction. This ivar only has effect if the sort
	/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
	/// in the direction of the vector.
	/// </summary>
	public virtual void SetVector(IntPtr _arg)
	{
		vtkDepthSortPolyData_SetVector_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SortScalarsOff_33(HandleRef pThis);

	/// <summary>
	/// Set/Get a flag that controls the generation of scalar values
	/// corresponding to the sort order. If enabled, the output of this
	/// filter will include scalar values that range from 0 to (ncells-1),
	/// where 0 is closest to the sort direction.
	/// </summary>
	public virtual void SortScalarsOff()
	{
		vtkDepthSortPolyData_SortScalarsOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthSortPolyData_SortScalarsOn_34(HandleRef pThis);

	/// <summary>
	/// Set/Get a flag that controls the generation of scalar values
	/// corresponding to the sort order. If enabled, the output of this
	/// filter will include scalar values that range from 0 to (ncells-1),
	/// where 0 is closest to the sort direction.
	/// </summary>
	public virtual void SortScalarsOn()
	{
		vtkDepthSortPolyData_SortScalarsOn_34(GetCppThis());
	}
}
