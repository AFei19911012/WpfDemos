using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkROIStencilSource
/// </summary>
/// <remarks>
///    create simple mask shapes
///
/// vtkROIStencilSource will create an image stencil with a
/// simple shape like a box, a sphere, or a cylinder.  Its output can
/// be used with vtkImageStecil or other vtk classes that apply
/// a stencil to an image.
/// </remarks>
/// <seealso>
///
/// vtkImplicitFunctionToImageStencil vtkLassoStencilSource
/// @par Thanks:
/// Thanks to David Gobbi for contributing this class to VTK.
/// </seealso>
public class vtkROIStencilSource : vtkImageStencilSource
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum BOX_WrapperEnum
	{
		/// <summary>enum member</summary>
		BOX = 0,
		/// <summary>enum member</summary>
		CYLINDERX = 2,
		/// <summary>enum member</summary>
		CYLINDERY = 3,
		/// <summary>enum member</summary>
		CYLINDERZ = 4,
		/// <summary>enum member</summary>
		ELLIPSOID = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkROIStencilSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkROIStencilSource()
	{
		MRClassNameKey = "class vtkROIStencilSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkROIStencilSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkROIStencilSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkROIStencilSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkROIStencilSource New()
	{
		vtkROIStencilSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkROIStencilSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkROIStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkROIStencilSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkROIStencilSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkROIStencilSource_GetBounds_01(HandleRef pThis);

	/// <summary>
	/// Set the bounds of the region of interest.  The bounds take
	/// the spacing and origin into account.
	/// </summary>
	public virtual double[] GetBounds()
	{
		IntPtr intPtr = vtkROIStencilSource_GetBounds_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkROIStencilSource_GetBounds_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Set the bounds of the region of interest.  The bounds take
	/// the spacing and origin into account.
	/// </summary>
	public virtual void GetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkROIStencilSource_GetBounds_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkROIStencilSource_GetBounds_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the bounds of the region of interest.  The bounds take
	/// the spacing and origin into account.
	/// </summary>
	public virtual void GetBounds(IntPtr _arg)
	{
		vtkROIStencilSource_GetBounds_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkROIStencilSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkROIStencilSource_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkROIStencilSource_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkROIStencilSource_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkROIStencilSource_GetShape_06(HandleRef pThis);

	/// <summary>
	/// The shape of the region of interest.  Cylinders can be oriented
	/// along the X, Y, or Z axes.  The default shape is "Box".
	/// </summary>
	public virtual int GetShape()
	{
		return vtkROIStencilSource_GetShape_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkROIStencilSource_GetShapeAsString_07(HandleRef pThis);

	/// <summary>
	/// The shape of the region of interest.  Cylinders can be oriented
	/// along the X, Y, or Z axes.  The default shape is "Box".
	/// </summary>
	public virtual string GetShapeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkROIStencilSource_GetShapeAsString_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkROIStencilSource_GetShapeMaxValue_08(HandleRef pThis);

	/// <summary>
	/// The shape of the region of interest.  Cylinders can be oriented
	/// along the X, Y, or Z axes.  The default shape is "Box".
	/// </summary>
	public virtual int GetShapeMaxValue()
	{
		return vtkROIStencilSource_GetShapeMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkROIStencilSource_GetShapeMinValue_09(HandleRef pThis);

	/// <summary>
	/// The shape of the region of interest.  Cylinders can be oriented
	/// along the X, Y, or Z axes.  The default shape is "Box".
	/// </summary>
	public virtual int GetShapeMinValue()
	{
		return vtkROIStencilSource_GetShapeMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkROIStencilSource_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkROIStencilSource_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkROIStencilSource_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkROIStencilSource_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkROIStencilSource_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkROIStencilSource NewInstance()
	{
		vtkROIStencilSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkROIStencilSource_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkROIStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkROIStencilSource_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkROIStencilSource SafeDownCast(vtkObjectBase o)
	{
		vtkROIStencilSource vtkROIStencilSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkROIStencilSource_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkROIStencilSource2 = (vtkROIStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkROIStencilSource2.Register(null);
			}
		}
		return vtkROIStencilSource2;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkROIStencilSource_SetBounds_15(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set the bounds of the region of interest.  The bounds take
	/// the spacing and origin into account.
	/// </summary>
	public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkROIStencilSource_SetBounds_15(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkROIStencilSource_SetBounds_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the bounds of the region of interest.  The bounds take
	/// the spacing and origin into account.
	/// </summary>
	public virtual void SetBounds(IntPtr _arg)
	{
		vtkROIStencilSource_SetBounds_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkROIStencilSource_SetShape_17(HandleRef pThis, int _arg);

	/// <summary>
	/// The shape of the region of interest.  Cylinders can be oriented
	/// along the X, Y, or Z axes.  The default shape is "Box".
	/// </summary>
	public virtual void SetShape(int _arg)
	{
		vtkROIStencilSource_SetShape_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkROIStencilSource_SetShapeToBox_18(HandleRef pThis);

	/// <summary>
	/// The shape of the region of interest.  Cylinders can be oriented
	/// along the X, Y, or Z axes.  The default shape is "Box".
	/// </summary>
	public void SetShapeToBox()
	{
		vtkROIStencilSource_SetShapeToBox_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkROIStencilSource_SetShapeToCylinderX_19(HandleRef pThis);

	/// <summary>
	/// The shape of the region of interest.  Cylinders can be oriented
	/// along the X, Y, or Z axes.  The default shape is "Box".
	/// </summary>
	public void SetShapeToCylinderX()
	{
		vtkROIStencilSource_SetShapeToCylinderX_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkROIStencilSource_SetShapeToCylinderY_20(HandleRef pThis);

	/// <summary>
	/// The shape of the region of interest.  Cylinders can be oriented
	/// along the X, Y, or Z axes.  The default shape is "Box".
	/// </summary>
	public void SetShapeToCylinderY()
	{
		vtkROIStencilSource_SetShapeToCylinderY_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkROIStencilSource_SetShapeToCylinderZ_21(HandleRef pThis);

	/// <summary>
	/// The shape of the region of interest.  Cylinders can be oriented
	/// along the X, Y, or Z axes.  The default shape is "Box".
	/// </summary>
	public void SetShapeToCylinderZ()
	{
		vtkROIStencilSource_SetShapeToCylinderZ_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkROIStencilSource_SetShapeToEllipsoid_22(HandleRef pThis);

	/// <summary>
	/// The shape of the region of interest.  Cylinders can be oriented
	/// along the X, Y, or Z axes.  The default shape is "Box".
	/// </summary>
	public void SetShapeToEllipsoid()
	{
		vtkROIStencilSource_SetShapeToEllipsoid_22(GetCppThis());
	}
}
