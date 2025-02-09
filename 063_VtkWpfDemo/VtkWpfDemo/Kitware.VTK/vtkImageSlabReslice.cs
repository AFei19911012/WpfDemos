using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageSlabReslice
/// </summary>
/// <remarks>
///    Thick slab reformat through data.
///
/// This class derives from vtkImageResliceBase. Much like vtkImageReslice, it
/// reslices the data. It is multi-threaded. It takes a three dimensional image
/// as input and produces a two dimensional thick MPR along some direction.
/// &lt;p&gt; The class reslices the thick slab using a blending function. Supported
/// blending functions are Minimum Intensity blend through the slab, maximum
/// intensity blend and a Mean (average) intensity of values across the slab.
/// &lt;p&gt; The user can adjust the thickness of the slab by using the method
/// SetSlabThickness. The distance between sample points used for blending
/// across the thickness of the slab is controlled by the method
/// SetSlabResolution. These two methods determine the number of slices used
/// across the slab for blending, which is computed as
/// {(2 x (int)(0.5 x SlabThickness/SlabResolution)) + 1}. This value may
/// be queried via GetNumBlendSamplePoints() and is always &gt;= 1.
/// &lt;p&gt; Much like vtkImageReslice, the reslice axes direction cosines may be
/// set via the methods SetResliceAxes or SetResliceAxesDirectionCosines. The
/// output spacing is controlled by SetOutputSpacing and the output origin is
/// controlled by SetOutputOrigin. The default value to be set on pixels that
/// lie outside the volume when reformatting is controlled by
/// SetBackgroundColor or SetBackgroundLevel. The SetResliceAxesOrigin()
/// method can also be used to provide an (x,y,z) point that the slice will
/// pass through.
/// </remarks>
/// <seealso>
///
/// vtkImageReslice
/// </seealso>
public class vtkImageSlabReslice : vtkImageReslice
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageSlabReslice";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageSlabReslice()
	{
		MRClassNameKey = "class vtkImageSlabReslice";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSlabReslice"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageSlabReslice(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlabReslice_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSlabReslice New()
	{
		vtkImageSlabReslice result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSlabReslice_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSlabReslice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageSlabReslice()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageSlabReslice_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlabReslice_GetBlendMode_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the blend mode. Default is MIP (ie Max)
	/// </summary>
	public virtual int GetBlendMode()
	{
		return vtkImageSlabReslice_GetBlendMode_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlabReslice_GetNumBlendSamplePoints_02(HandleRef pThis);

	/// <summary>
	/// Number of sample points used across the slab cross-section. If equal to
	/// 1, this ends up being a thin reslice through the data a.k.a.
	/// vtkImageReslice
	/// </summary>
	public virtual int GetNumBlendSamplePoints()
	{
		return vtkImageSlabReslice_GetNumBlendSamplePoints_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSlabReslice_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageSlabReslice_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSlabReslice_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageSlabReslice_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageSlabReslice_GetSlabResolution_05(HandleRef pThis);

	/// <summary>
	/// Spacing between slabs in world units. (Number of Slices, ie samples to
	/// blend is computed from SlabThickness and SlabResolution).
	/// </summary>
	public virtual double GetSlabResolution()
	{
		return vtkImageSlabReslice_GetSlabResolution_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageSlabReslice_GetSlabThickness_06(HandleRef pThis);

	/// <summary>
	/// SlabThickness of slab in world coords. SlabThickness must be non-zero and
	/// positive.
	/// </summary>
	public virtual double GetSlabThickness()
	{
		return vtkImageSlabReslice_GetSlabThickness_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlabReslice_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageSlabReslice_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlabReslice_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageSlabReslice_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlabReslice_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageSlabReslice NewInstance()
	{
		vtkImageSlabReslice result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSlabReslice_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSlabReslice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlabReslice_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSlabReslice SafeDownCast(vtkObjectBase o)
	{
		vtkImageSlabReslice vtkImageSlabReslice2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSlabReslice_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageSlabReslice2 = (vtkImageSlabReslice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageSlabReslice2.Register(null);
			}
		}
		return vtkImageSlabReslice2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlabReslice_SetBlendMode_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the blend mode. Default is MIP (ie Max)
	/// </summary>
	public virtual void SetBlendMode(int _arg)
	{
		vtkImageSlabReslice_SetBlendMode_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlabReslice_SetBlendModeToMax_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the blend mode. Default is MIP (ie Max)
	/// </summary>
	public void SetBlendModeToMax()
	{
		vtkImageSlabReslice_SetBlendModeToMax_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlabReslice_SetBlendModeToMean_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the blend mode. Default is MIP (ie Max)
	/// </summary>
	public void SetBlendModeToMean()
	{
		vtkImageSlabReslice_SetBlendModeToMean_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlabReslice_SetBlendModeToMin_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the blend mode. Default is MIP (ie Max)
	/// </summary>
	public void SetBlendModeToMin()
	{
		vtkImageSlabReslice_SetBlendModeToMin_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlabReslice_SetSlabResolution_16(HandleRef pThis, double _arg);

	/// <summary>
	/// Spacing between slabs in world units. (Number of Slices, ie samples to
	/// blend is computed from SlabThickness and SlabResolution).
	/// </summary>
	public virtual void SetSlabResolution(double _arg)
	{
		vtkImageSlabReslice_SetSlabResolution_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlabReslice_SetSlabThickness_17(HandleRef pThis, double _arg);

	/// <summary>
	/// SlabThickness of slab in world coords. SlabThickness must be non-zero and
	/// positive.
	/// </summary>
	public virtual void SetSlabThickness(double _arg)
	{
		vtkImageSlabReslice_SetSlabThickness_17(GetCppThis(), _arg);
	}
}
