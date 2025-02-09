using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataSilhouette
/// </summary>
/// <remarks>
///    sort polydata along camera view direction
///
///
/// vtkPolyDataSilhouette extracts a subset of a polygonal mesh edges to
/// generate an outline (silhouette) of the corresponding 3D object. In
/// addition, this filter can also extracts sharp edges (aka feature angles).
/// In order to use this filter you must specify the a point of view (origin) or
/// a direction (vector).  given this direction or origin, a silhouette is
/// generated wherever the surface's normal is orthogonal to the view direction.
///
/// @warning
/// when the active camera is used, almost everything is recomputed for each
/// frame, keep this in mind when dealing with extremely large surface data
/// sets.
///
/// @par Thanks:
/// Contribution by Thierry Carrard &lt;br&gt;
/// CEA/DIF - Commissariat a l'Energie Atomique, Centre DAM Ile-De-France &lt;br&gt;
/// BP12, F-91297 Arpajon, France. &lt;br&gt;
/// </remarks>
public class vtkPolyDataSilhouette : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Enables or Disables piece invariance. This is useful when dealing with
	/// multi-block data sets. Note: requires one level of ghost cells
	/// </summary>
	public enum Directions
	{
		/// <summary>enum member</summary>
		VTK_DIRECTION_CAMERA_ORIGIN = 2,
		/// <summary>enum member</summary>
		VTK_DIRECTION_CAMERA_VECTOR = 3,
		/// <summary>enum member</summary>
		VTK_DIRECTION_SPECIFIED_ORIGIN = 1,
		/// <summary>enum member</summary>
		VTK_DIRECTION_SPECIFIED_VECTOR = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataSilhouette";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataSilhouette()
	{
		MRClassNameKey = "class vtkPolyDataSilhouette";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataSilhouette"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataSilhouette(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataSilhouette_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new static vtkPolyDataSilhouette New()
	{
		vtkPolyDataSilhouette result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataSilhouette_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataSilhouette)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public vtkPolyDataSilhouette()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyDataSilhouette_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPolyDataSilhouette_BorderEdgesOff_01(HandleRef pThis);

	/// <summary>
	/// Enables or Disables generation of border edges. Note: borders exist only
	/// in case of non closed surface
	/// </summary>
	public virtual void BorderEdgesOff()
	{
		vtkPolyDataSilhouette_BorderEdgesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_BorderEdgesOn_02(HandleRef pThis);

	/// <summary>
	/// Enables or Disables generation of border edges. Note: borders exist only
	/// in case of non closed surface
	/// </summary>
	public virtual void BorderEdgesOn()
	{
		vtkPolyDataSilhouette_BorderEdgesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataSilhouette_GetBorderEdges_03(HandleRef pThis);

	/// <summary>
	/// Enables or Disables generation of border edges. Note: borders exist only
	/// in case of non closed surface
	/// </summary>
	public virtual int GetBorderEdges()
	{
		return vtkPolyDataSilhouette_GetBorderEdges_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataSilhouette_GetCamera_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a camera that is used to define the view direction.  This ivar
	/// only has effect if the direction is set to VTK_DIRECTION_CAMERA_ORIGIN or
	/// VTK_DIRECTION_CAMERA_VECTOR, and a camera is specified.
	/// </summary>
	public virtual vtkCamera GetCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataSilhouette_GetCamera_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPolyDataSilhouette_GetDirection_05(HandleRef pThis);

	/// <summary>
	/// Specify how view direction is computed. By default, the
	/// camera origin (eye) is used.
	/// </summary>
	public virtual int GetDirection()
	{
		return vtkPolyDataSilhouette_GetDirection_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataSilhouette_GetEnableFeatureAngle_06(HandleRef pThis);

	/// <summary>
	/// Enables or Disables generation of silhouette edges along sharp edges
	/// </summary>
	public virtual int GetEnableFeatureAngle()
	{
		return vtkPolyDataSilhouette_GetEnableFeatureAngle_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataSilhouette_GetFeatureAngle_07(HandleRef pThis);

	/// <summary>
	/// Sets/Gets minimal angle for sharp edges detection. Default is 60
	/// </summary>
	public virtual double GetFeatureAngle()
	{
		return vtkPolyDataSilhouette_GetFeatureAngle_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPolyDataSilhouette_GetMTime_08(HandleRef pThis);

	/// <summary>
	/// Return MTime also considering the dependent objects: the camera
	/// and/or the prop3D.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkPolyDataSilhouette_GetMTime_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataSilhouette_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataSilhouette_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataSilhouette_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataSilhouette_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataSilhouette_GetOrigin_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the sort origin. This ivar only has effect if the sort direction
	/// is set to SetDirectionToSpecifiedOrigin(). The edge detection occurs in
	/// the direction of the origin to each edge's center.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkPolyDataSilhouette_GetOrigin_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_GetOrigin_12(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the sort origin. This ivar only has effect if the sort direction
	/// is set to SetDirectionToSpecifiedOrigin(). The edge detection occurs in
	/// the direction of the origin to each edge's center.
	/// </summary>
	public virtual void GetOrigin(IntPtr data)
	{
		vtkPolyDataSilhouette_GetOrigin_12(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataSilhouette_GetPieceInvariant_13(HandleRef pThis);

	/// <summary>
	/// Enables or Disables piece invariance. This is useful when dealing with
	/// multi-block data sets. Note: requires one level of ghost cells
	/// </summary>
	public virtual int GetPieceInvariant()
	{
		return vtkPolyDataSilhouette_GetPieceInvariant_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataSilhouette_GetProp3D_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a transformation matrix (via the vtkProp3D::GetMatrix() method)
	/// that is used to include the effects of transformation. This ivar only has
	/// effect if the direction is set to VTK_DIRECTION_CAMERA_ORIGIN or
	/// VTK_DIRECTION_CAMERA_VECTOR, and a camera is specified. Specifying the
	/// vtkProp3D is optional.
	/// </summary>
	public vtkProp3D GetProp3D()
	{
		vtkProp3D vtkProp3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataSilhouette_GetProp3D_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPolyDataSilhouette_GetVector_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the sort direction. This ivar only has effect if the sort
	/// direction is set to SetDirectionToSpecifiedVector(). The edge detection
	/// occurs in the direction of the vector.
	/// </summary>
	public virtual double[] GetVector()
	{
		IntPtr intPtr = vtkPolyDataSilhouette_GetVector_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_GetVector_16(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the sort direction. This ivar only has effect if the sort
	/// direction is set to SetDirectionToSpecifiedVector(). The edge detection
	/// occurs in the direction of the vector.
	/// </summary>
	public virtual void GetVector(IntPtr data)
	{
		vtkPolyDataSilhouette_GetVector_16(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataSilhouette_IsA_17(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataSilhouette_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataSilhouette_IsTypeOf_18(string type);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataSilhouette_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataSilhouette_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new vtkPolyDataSilhouette NewInstance()
	{
		vtkPolyDataSilhouette result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataSilhouette_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataSilhouette)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_PieceInvariantOff_21(HandleRef pThis);

	/// <summary>
	/// Enables or Disables piece invariance. This is useful when dealing with
	/// multi-block data sets. Note: requires one level of ghost cells
	/// </summary>
	public virtual void PieceInvariantOff()
	{
		vtkPolyDataSilhouette_PieceInvariantOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_PieceInvariantOn_22(HandleRef pThis);

	/// <summary>
	/// Enables or Disables piece invariance. This is useful when dealing with
	/// multi-block data sets. Note: requires one level of ghost cells
	/// </summary>
	public virtual void PieceInvariantOn()
	{
		vtkPolyDataSilhouette_PieceInvariantOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataSilhouette_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object.
	/// </summary>
	public new static vtkPolyDataSilhouette SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataSilhouette vtkPolyDataSilhouette2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataSilhouette_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataSilhouette2 = (vtkPolyDataSilhouette)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataSilhouette2.Register(null);
			}
		}
		return vtkPolyDataSilhouette2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetBorderEdges_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Enables or Disables generation of border edges. Note: borders exist only
	/// in case of non closed surface
	/// </summary>
	public virtual void SetBorderEdges(int _arg)
	{
		vtkPolyDataSilhouette_SetBorderEdges_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetCamera_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify a camera that is used to define the view direction.  This ivar
	/// only has effect if the direction is set to VTK_DIRECTION_CAMERA_ORIGIN or
	/// VTK_DIRECTION_CAMERA_VECTOR, and a camera is specified.
	/// </summary>
	public virtual void SetCamera(vtkCamera arg0)
	{
		vtkPolyDataSilhouette_SetCamera_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetDirection_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify how view direction is computed. By default, the
	/// camera origin (eye) is used.
	/// </summary>
	public virtual void SetDirection(int _arg)
	{
		vtkPolyDataSilhouette_SetDirection_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetDirectionToCameraOrigin_27(HandleRef pThis);

	/// <summary>
	/// Specify how view direction is computed. By default, the
	/// camera origin (eye) is used.
	/// </summary>
	public void SetDirectionToCameraOrigin()
	{
		vtkPolyDataSilhouette_SetDirectionToCameraOrigin_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetDirectionToCameraVector_28(HandleRef pThis);

	/// <summary>
	/// Specify how view direction is computed. By default, the
	/// camera origin (eye) is used.
	/// </summary>
	public void SetDirectionToCameraVector()
	{
		vtkPolyDataSilhouette_SetDirectionToCameraVector_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetDirectionToSpecifiedOrigin_29(HandleRef pThis);

	/// <summary>
	/// Specify how view direction is computed. By default, the
	/// camera origin (eye) is used.
	/// </summary>
	public void SetDirectionToSpecifiedOrigin()
	{
		vtkPolyDataSilhouette_SetDirectionToSpecifiedOrigin_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetDirectionToSpecifiedVector_30(HandleRef pThis);

	/// <summary>
	/// Specify how view direction is computed. By default, the
	/// camera origin (eye) is used.
	/// </summary>
	public void SetDirectionToSpecifiedVector()
	{
		vtkPolyDataSilhouette_SetDirectionToSpecifiedVector_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetEnableFeatureAngle_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Enables or Disables generation of silhouette edges along sharp edges
	/// </summary>
	public virtual void SetEnableFeatureAngle(int _arg)
	{
		vtkPolyDataSilhouette_SetEnableFeatureAngle_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetFeatureAngle_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Sets/Gets minimal angle for sharp edges detection. Default is 60
	/// </summary>
	public virtual void SetFeatureAngle(double _arg)
	{
		vtkPolyDataSilhouette_SetFeatureAngle_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetOrigin_33(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the sort origin. This ivar only has effect if the sort direction
	/// is set to SetDirectionToSpecifiedOrigin(). The edge detection occurs in
	/// the direction of the origin to each edge's center.
	/// </summary>
	public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkPolyDataSilhouette_SetOrigin_33(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetOrigin_34(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the sort origin. This ivar only has effect if the sort direction
	/// is set to SetDirectionToSpecifiedOrigin(). The edge detection occurs in
	/// the direction of the origin to each edge's center.
	/// </summary>
	public virtual void SetOrigin(IntPtr _arg)
	{
		vtkPolyDataSilhouette_SetOrigin_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetPieceInvariant_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Enables or Disables piece invariance. This is useful when dealing with
	/// multi-block data sets. Note: requires one level of ghost cells
	/// </summary>
	public virtual void SetPieceInvariant(int _arg)
	{
		vtkPolyDataSilhouette_SetPieceInvariant_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetProp3D_36(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify a transformation matrix (via the vtkProp3D::GetMatrix() method)
	/// that is used to include the effects of transformation. This ivar only has
	/// effect if the direction is set to VTK_DIRECTION_CAMERA_ORIGIN or
	/// VTK_DIRECTION_CAMERA_VECTOR, and a camera is specified. Specifying the
	/// vtkProp3D is optional.
	/// </summary>
	public void SetProp3D(vtkProp3D arg0)
	{
		vtkPolyDataSilhouette_SetProp3D_36(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetVector_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the sort direction. This ivar only has effect if the sort
	/// direction is set to SetDirectionToSpecifiedVector(). The edge detection
	/// occurs in the direction of the vector.
	/// </summary>
	public virtual void SetVector(double _arg1, double _arg2, double _arg3)
	{
		vtkPolyDataSilhouette_SetVector_37(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSilhouette_SetVector_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the sort direction. This ivar only has effect if the sort
	/// direction is set to SetDirectionToSpecifiedVector(). The edge detection
	/// occurs in the direction of the vector.
	/// </summary>
	public virtual void SetVector(IntPtr _arg)
	{
		vtkPolyDataSilhouette_SetVector_38(GetCppThis(), _arg);
	}
}
