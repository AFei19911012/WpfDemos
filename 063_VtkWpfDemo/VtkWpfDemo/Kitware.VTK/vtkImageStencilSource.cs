using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageStencilSource
/// </summary>
/// <remarks>
///    generate an image stencil
///
/// vtkImageStencilSource is a superclass for filters that generate image
/// stencils.  Given a clipping object such as a vtkImplicitFunction, it
/// will set up a list of clipping extents for each x-row through the
/// image data.  The extents for each x-row can be retrieved via the
/// GetNextExtent() method after the extent lists have been built
/// with the BuildExtents() method.  For large images, using clipping
/// extents is much more memory efficient (and slightly more time-efficient)
/// than building a mask.  This class can be subclassed to allow clipping
/// with objects other than vtkImplicitFunction.
/// </remarks>
/// <seealso>
///
/// vtkImplicitFunction vtkImageStencil vtkPolyDataToImageStencil
/// </seealso>
public class vtkImageStencilSource : vtkImageStencilAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencilSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageStencilSource()
	{
		MRClassNameKey = "class vtkImageStencilSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencilSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageStencilSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageStencilSource New()
	{
		vtkImageStencilSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencilSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageStencilSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageStencilSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilSource_GetInformationInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set a vtkImageData that has the Spacing, Origin, and
	/// WholeExtent that will be used for the stencil.  This
	/// input should be set to the image that you wish to
	/// apply the stencil to.  If you use this method, then
	/// any values set with the SetOutputSpacing, SetOutputOrigin,
	/// and SetOutputWholeExtent methods will be ignored.
	/// </summary>
	public virtual vtkImageData GetInformationInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencilSource_GetInformationInput_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageStencilSource_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageStencilSource_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageStencilSource_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageStencilSource_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilSource_GetOutputOrigin_04(HandleRef pThis);

	/// <summary>
	/// Set the Origin to be used for the stencil.  It should be
	/// set to the Origin of the image you intend to apply the
	/// stencil to. The default value is (0,0,0).
	/// </summary>
	public virtual double[] GetOutputOrigin()
	{
		IntPtr intPtr = vtkImageStencilSource_GetOutputOrigin_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_GetOutputOrigin_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the Origin to be used for the stencil.  It should be
	/// set to the Origin of the image you intend to apply the
	/// stencil to. The default value is (0,0,0).
	/// </summary>
	public virtual void GetOutputOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageStencilSource_GetOutputOrigin_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_GetOutputOrigin_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the Origin to be used for the stencil.  It should be
	/// set to the Origin of the image you intend to apply the
	/// stencil to. The default value is (0,0,0).
	/// </summary>
	public virtual void GetOutputOrigin(IntPtr _arg)
	{
		vtkImageStencilSource_GetOutputOrigin_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilSource_GetOutputSpacing_07(HandleRef pThis);

	/// <summary>
	/// Set the Spacing to be used for the stencil. It should be
	/// set to the Spacing of the image you intend to apply the
	/// stencil to. The default value is (1,1,1)
	/// </summary>
	public virtual double[] GetOutputSpacing()
	{
		IntPtr intPtr = vtkImageStencilSource_GetOutputSpacing_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_GetOutputSpacing_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the Spacing to be used for the stencil. It should be
	/// set to the Spacing of the image you intend to apply the
	/// stencil to. The default value is (1,1,1)
	/// </summary>
	public virtual void GetOutputSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageStencilSource_GetOutputSpacing_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_GetOutputSpacing_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the Spacing to be used for the stencil. It should be
	/// set to the Spacing of the image you intend to apply the
	/// stencil to. The default value is (1,1,1)
	/// </summary>
	public virtual void GetOutputSpacing(IntPtr _arg)
	{
		vtkImageStencilSource_GetOutputSpacing_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilSource_GetOutputWholeExtent_10(HandleRef pThis);

	/// <summary>
	/// Set the whole extent for the stencil (anything outside
	/// this extent will be considered to be "outside" the stencil).
	/// </summary>
	public virtual int[] GetOutputWholeExtent()
	{
		IntPtr intPtr = vtkImageStencilSource_GetOutputWholeExtent_10(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_GetOutputWholeExtent_11(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set the whole extent for the stencil (anything outside
	/// this extent will be considered to be "outside" the stencil).
	/// </summary>
	public virtual void GetOutputWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkImageStencilSource_GetOutputWholeExtent_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_GetOutputWholeExtent_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the whole extent for the stencil (anything outside
	/// this extent will be considered to be "outside" the stencil).
	/// </summary>
	public virtual void GetOutputWholeExtent(IntPtr _arg)
	{
		vtkImageStencilSource_GetOutputWholeExtent_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencilSource_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageStencilSource_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencilSource_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageStencilSource_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilSource_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageStencilSource NewInstance()
	{
		vtkImageStencilSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencilSource_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_ReportReferences_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Report object referenced by instances of this class.
	/// </summary>
	public virtual void ReportReferences(vtkGarbageCollector arg0)
	{
		vtkImageStencilSource_ReportReferences_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilSource_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageStencilSource SafeDownCast(vtkObjectBase o)
	{
		vtkImageStencilSource vtkImageStencilSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencilSource_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencilSource2 = (vtkImageStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencilSource2.Register(null);
			}
		}
		return vtkImageStencilSource2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_SetInformationInput_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set a vtkImageData that has the Spacing, Origin, and
	/// WholeExtent that will be used for the stencil.  This
	/// input should be set to the image that you wish to
	/// apply the stencil to.  If you use this method, then
	/// any values set with the SetOutputSpacing, SetOutputOrigin,
	/// and SetOutputWholeExtent methods will be ignored.
	/// </summary>
	public virtual void SetInformationInput(vtkImageData arg0)
	{
		vtkImageStencilSource_SetInformationInput_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_SetOutputOrigin_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the Origin to be used for the stencil.  It should be
	/// set to the Origin of the image you intend to apply the
	/// stencil to. The default value is (0,0,0).
	/// </summary>
	public virtual void SetOutputOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkImageStencilSource_SetOutputOrigin_20(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_SetOutputOrigin_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the Origin to be used for the stencil.  It should be
	/// set to the Origin of the image you intend to apply the
	/// stencil to. The default value is (0,0,0).
	/// </summary>
	public virtual void SetOutputOrigin(IntPtr _arg)
	{
		vtkImageStencilSource_SetOutputOrigin_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_SetOutputSpacing_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the Spacing to be used for the stencil. It should be
	/// set to the Spacing of the image you intend to apply the
	/// stencil to. The default value is (1,1,1)
	/// </summary>
	public virtual void SetOutputSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkImageStencilSource_SetOutputSpacing_22(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_SetOutputSpacing_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the Spacing to be used for the stencil. It should be
	/// set to the Spacing of the image you intend to apply the
	/// stencil to. The default value is (1,1,1)
	/// </summary>
	public virtual void SetOutputSpacing(IntPtr _arg)
	{
		vtkImageStencilSource_SetOutputSpacing_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_SetOutputWholeExtent_24(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Set the whole extent for the stencil (anything outside
	/// this extent will be considered to be "outside" the stencil).
	/// </summary>
	public virtual void SetOutputWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkImageStencilSource_SetOutputWholeExtent_24(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilSource_SetOutputWholeExtent_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the whole extent for the stencil (anything outside
	/// this extent will be considered to be "outside" the stencil).
	/// </summary>
	public virtual void SetOutputWholeExtent(IntPtr _arg)
	{
		vtkImageStencilSource_SetOutputWholeExtent_25(GetCppThis(), _arg);
	}
}
