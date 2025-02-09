using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProjectedTexture
/// </summary>
/// <remarks>
///    assign texture coordinates for a projected texture
///
/// vtkProjectedTexture assigns texture coordinates to a dataset as if
/// the texture was projected from a slide projected located somewhere in the
/// scene.  Methods are provided to position the projector and aim it at a
/// location, to set the width of the projector's frustum, and to set the
/// range of texture coordinates assigned to the dataset.
///
/// Objects in the scene that appear behind the projector are also assigned
/// texture coordinates; the projected image is left-right and top-bottom
/// flipped, much as a lens' focus flips the rays of light that pass through
/// it.  A warning is issued if a point in the dataset falls at the focus
/// of the projector.
/// </remarks>
public class vtkProjectedTexture : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProjectedTexture";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProjectedTexture()
	{
		MRClassNameKey = "class vtkProjectedTexture";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectedTexture"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProjectedTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProjectedTexture New()
	{
		vtkProjectedTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectedTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProjectedTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProjectedTexture()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProjectedTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTexture_GetAspectRatio_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the aspect ratio of a perpendicular cross-section of the
	/// the projector's frustum.  The aspect ratio consists of three
	/// numbers:  (x, y, z), where x is the width of the
	/// frustum, y is the height, and z is the perpendicular
	/// distance from the focus of the projector.
	///
	/// For example, if the source of the image is a pinhole camera with
	/// view angle A, then you could set x=1, y=1, z=1/tan(A).
	/// </summary>
	public virtual double[] GetAspectRatio()
	{
		IntPtr intPtr = vtkProjectedTexture_GetAspectRatio_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_GetAspectRatio_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the aspect ratio of a perpendicular cross-section of the
	/// the projector's frustum.  The aspect ratio consists of three
	/// numbers:  (x, y, z), where x is the width of the
	/// frustum, y is the height, and z is the perpendicular
	/// distance from the focus of the projector.
	///
	/// For example, if the source of the image is a pinhole camera with
	/// view angle A, then you could set x=1, y=1, z=1/tan(A).
	/// </summary>
	public virtual void GetAspectRatio(IntPtr data)
	{
		vtkProjectedTexture_GetAspectRatio_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectedTexture_GetCameraMode_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the camera mode of the projection -- pinhole projection or
	/// two mirror projection.
	/// </summary>
	public virtual int GetCameraMode()
	{
		return vtkProjectedTexture_GetCameraMode_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTexture_GetFocalPoint_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the focal point of the projector (a point that lies along
	/// the center axis of the projector's frustum).
	/// </summary>
	public virtual double[] GetFocalPoint()
	{
		IntPtr intPtr = vtkProjectedTexture_GetFocalPoint_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_GetFocalPoint_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the focal point of the projector (a point that lies along
	/// the center axis of the projector's frustum).
	/// </summary>
	public virtual void GetFocalPoint(IntPtr data)
	{
		vtkProjectedTexture_GetFocalPoint_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProjectedTexture_GetMirrorSeparation_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the mirror separation for the two mirror system.
	/// </summary>
	public virtual double GetMirrorSeparation()
	{
		return vtkProjectedTexture_GetMirrorSeparation_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProjectedTexture_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProjectedTexture_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProjectedTexture_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProjectedTexture_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTexture_GetOrientation_09(HandleRef pThis);

	/// <summary>
	/// Get the normalized orientation vector of the projector.
	/// </summary>
	public virtual double[] GetOrientation()
	{
		IntPtr intPtr = vtkProjectedTexture_GetOrientation_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_GetOrientation_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Get the normalized orientation vector of the projector.
	/// </summary>
	public virtual void GetOrientation(IntPtr data)
	{
		vtkProjectedTexture_GetOrientation_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTexture_GetPosition_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the focus of the projector.
	/// </summary>
	public virtual double[] GetPosition()
	{
		IntPtr intPtr = vtkProjectedTexture_GetPosition_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_GetPosition_12(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the position of the focus of the projector.
	/// </summary>
	public virtual void GetPosition(IntPtr data)
	{
		vtkProjectedTexture_GetPosition_12(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTexture_GetSRange_13(HandleRef pThis);

	/// <summary>
	/// Specify s-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public virtual double[] GetSRange()
	{
		IntPtr intPtr = vtkProjectedTexture_GetSRange_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_GetSRange_14(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify s-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public virtual void GetSRange(IntPtr data)
	{
		vtkProjectedTexture_GetSRange_14(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTexture_GetTRange_15(HandleRef pThis);

	/// <summary>
	/// Specify t-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public virtual double[] GetTRange()
	{
		IntPtr intPtr = vtkProjectedTexture_GetTRange_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_GetTRange_16(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify t-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public virtual void GetTRange(IntPtr data)
	{
		vtkProjectedTexture_GetTRange_16(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTexture_GetUp_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the up vector of the projector.
	/// </summary>
	public virtual double[] GetUp()
	{
		IntPtr intPtr = vtkProjectedTexture_GetUp_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_GetUp_18(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the up vector of the projector.
	/// </summary>
	public virtual void GetUp(IntPtr data)
	{
		vtkProjectedTexture_GetUp_18(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectedTexture_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProjectedTexture_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectedTexture_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProjectedTexture_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTexture_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProjectedTexture NewInstance()
	{
		vtkProjectedTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectedTexture_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProjectedTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectedTexture_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProjectedTexture SafeDownCast(vtkObjectBase o)
	{
		vtkProjectedTexture vtkProjectedTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectedTexture_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProjectedTexture2 = (vtkProjectedTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProjectedTexture2.Register(null);
			}
		}
		return vtkProjectedTexture2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetAspectRatio_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the aspect ratio of a perpendicular cross-section of the
	/// the projector's frustum.  The aspect ratio consists of three
	/// numbers:  (x, y, z), where x is the width of the
	/// frustum, y is the height, and z is the perpendicular
	/// distance from the focus of the projector.
	///
	/// For example, if the source of the image is a pinhole camera with
	/// view angle A, then you could set x=1, y=1, z=1/tan(A).
	/// </summary>
	public virtual void SetAspectRatio(double _arg1, double _arg2, double _arg3)
	{
		vtkProjectedTexture_SetAspectRatio_24(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetAspectRatio_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the aspect ratio of a perpendicular cross-section of the
	/// the projector's frustum.  The aspect ratio consists of three
	/// numbers:  (x, y, z), where x is the width of the
	/// frustum, y is the height, and z is the perpendicular
	/// distance from the focus of the projector.
	///
	/// For example, if the source of the image is a pinhole camera with
	/// view angle A, then you could set x=1, y=1, z=1/tan(A).
	/// </summary>
	public virtual void SetAspectRatio(IntPtr _arg)
	{
		vtkProjectedTexture_SetAspectRatio_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetCameraMode_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the camera mode of the projection -- pinhole projection or
	/// two mirror projection.
	/// </summary>
	public virtual void SetCameraMode(int _arg)
	{
		vtkProjectedTexture_SetCameraMode_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetCameraModeToPinhole_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the camera mode of the projection -- pinhole projection or
	/// two mirror projection.
	/// </summary>
	public void SetCameraModeToPinhole()
	{
		vtkProjectedTexture_SetCameraModeToPinhole_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetCameraModeToTwoMirror_28(HandleRef pThis);

	/// <summary>
	/// Set/Get the camera mode of the projection -- pinhole projection or
	/// two mirror projection.
	/// </summary>
	public void SetCameraModeToTwoMirror()
	{
		vtkProjectedTexture_SetCameraModeToTwoMirror_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetFocalPoint_29(HandleRef pThis, IntPtr focalPoint);

	/// <summary>
	/// Set/Get the focal point of the projector (a point that lies along
	/// the center axis of the projector's frustum).
	/// </summary>
	public void SetFocalPoint(IntPtr focalPoint)
	{
		vtkProjectedTexture_SetFocalPoint_29(GetCppThis(), focalPoint);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetFocalPoint_30(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the focal point of the projector (a point that lies along
	/// the center axis of the projector's frustum).
	/// </summary>
	public void SetFocalPoint(double x, double y, double z)
	{
		vtkProjectedTexture_SetFocalPoint_30(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetMirrorSeparation_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the mirror separation for the two mirror system.
	/// </summary>
	public virtual void SetMirrorSeparation(double _arg)
	{
		vtkProjectedTexture_SetMirrorSeparation_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetPosition_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the position of the focus of the projector.
	/// </summary>
	public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
	{
		vtkProjectedTexture_SetPosition_32(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetPosition_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the position of the focus of the projector.
	/// </summary>
	public virtual void SetPosition(IntPtr _arg)
	{
		vtkProjectedTexture_SetPosition_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetSRange_34(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify s-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public virtual void SetSRange(double _arg1, double _arg2)
	{
		vtkProjectedTexture_SetSRange_34(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetSRange_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify s-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public void SetSRange(IntPtr _arg)
	{
		vtkProjectedTexture_SetSRange_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetTRange_36(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify t-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public virtual void SetTRange(double _arg1, double _arg2)
	{
		vtkProjectedTexture_SetTRange_36(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetTRange_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify t-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public void SetTRange(IntPtr _arg)
	{
		vtkProjectedTexture_SetTRange_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetUp_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the up vector of the projector.
	/// </summary>
	public virtual void SetUp(double _arg1, double _arg2, double _arg3)
	{
		vtkProjectedTexture_SetUp_38(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectedTexture_SetUp_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the up vector of the projector.
	/// </summary>
	public virtual void SetUp(IntPtr _arg)
	{
		vtkProjectedTexture_SetUp_39(GetCppThis(), _arg);
	}
}
