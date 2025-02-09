using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractVOI
/// </summary>
/// <remarks>
///    select piece (e.g., volume of interest) and/or subsample structured points dataset
///
///
/// vtkExtractVOI is a filter that selects a portion of an input structured
/// points dataset, or subsamples an input dataset. (The selected portion of
/// interested is referred to as the Volume Of Interest, or VOI.) The output of
/// this filter is a structured points dataset. The filter treats input data
/// of any topological dimension (i.e., point, line, image, or volume) and can
/// generate output data of any topological dimension.
///
/// To use this filter set the VOI ivar which are i-j-k min/max indices that
/// specify a rectangular region in the data. (Note that these are 0-offset.)
/// You can also specify a sampling rate to subsample the data.
///
/// Typical applications of this filter are to extract a slice from a volume
/// for image processing, subsampling large volumes to reduce data size, or
/// extracting regions of a volume with interesting data.
///
/// </remarks>
/// <seealso>
///
/// vtkGeometryFilter vtkExtractGeometry vtkExtractGrid
/// </seealso>
public class vtkExtractVOI : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractVOI";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractVOI()
	{
		MRClassNameKey = "class vtkExtractVOI";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractVOI"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractVOI(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractVOI_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object to extract all of the input data.
	/// </summary>
	public new static vtkExtractVOI New()
	{
		vtkExtractVOI result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractVOI_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractVOI)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object to extract all of the input data.
	/// </summary>
	public vtkExtractVOI()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractVOI_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkExtractVOI_GetIncludeBoundary_01(HandleRef pThis);

	/// <summary>
	/// Control whether to enforce that the "boundary" of the grid is output in
	/// the subsampling process. (This ivar only has effect when the SampleRate
	/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
	/// on, the subsampling will always include the boundary of the grid even
	/// though the sample rate is not an even multiple of the grid
	/// dimensions. (By default IncludeBoundary is off.)
	/// </summary>
	public virtual int GetIncludeBoundary()
	{
		return vtkExtractVOI_GetIncludeBoundary_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractVOI_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractVOI_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractVOI_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractVOI_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractVOI_GetSampleRate_04(HandleRef pThis);

	/// <summary>
	/// Set the sampling rate in the i, j, and k directions. If the rate is &gt;
	/// 1, then the resulting VOI will be subsampled representation of the
	/// input.  For example, if the SampleRate=(2,2,2), every other point will
	/// be selected, resulting in a volume 1/8th the original size.
	/// </summary>
	public virtual int[] GetSampleRate()
	{
		IntPtr intPtr = vtkExtractVOI_GetSampleRate_04(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVOI_GetSampleRate_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the sampling rate in the i, j, and k directions. If the rate is &gt;
	/// 1, then the resulting VOI will be subsampled representation of the
	/// input.  For example, if the SampleRate=(2,2,2), every other point will
	/// be selected, resulting in a volume 1/8th the original size.
	/// </summary>
	public virtual void GetSampleRate(IntPtr data)
	{
		vtkExtractVOI_GetSampleRate_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractVOI_GetVOI_06(HandleRef pThis);

	/// <summary>
	/// Specify i-j-k (min,max) pairs to extract. The resulting structured points
	/// dataset can be of any topological dimension (i.e., point, line, image,
	/// or volume).
	/// </summary>
	public virtual int[] GetVOI()
	{
		IntPtr intPtr = vtkExtractVOI_GetVOI_06(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVOI_GetVOI_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify i-j-k (min,max) pairs to extract. The resulting structured points
	/// dataset can be of any topological dimension (i.e., point, line, image,
	/// or volume).
	/// </summary>
	public virtual void GetVOI(IntPtr data)
	{
		vtkExtractVOI_GetVOI_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVOI_IncludeBoundaryOff_08(HandleRef pThis);

	/// <summary>
	/// Control whether to enforce that the "boundary" of the grid is output in
	/// the subsampling process. (This ivar only has effect when the SampleRate
	/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
	/// on, the subsampling will always include the boundary of the grid even
	/// though the sample rate is not an even multiple of the grid
	/// dimensions. (By default IncludeBoundary is off.)
	/// </summary>
	public virtual void IncludeBoundaryOff()
	{
		vtkExtractVOI_IncludeBoundaryOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVOI_IncludeBoundaryOn_09(HandleRef pThis);

	/// <summary>
	/// Control whether to enforce that the "boundary" of the grid is output in
	/// the subsampling process. (This ivar only has effect when the SampleRate
	/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
	/// on, the subsampling will always include the boundary of the grid even
	/// though the sample rate is not an even multiple of the grid
	/// dimensions. (By default IncludeBoundary is off.)
	/// </summary>
	public virtual void IncludeBoundaryOn()
	{
		vtkExtractVOI_IncludeBoundaryOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractVOI_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractVOI_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractVOI_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractVOI_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractVOI_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractVOI NewInstance()
	{
		vtkExtractVOI result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractVOI_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractVOI)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractVOI_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractVOI SafeDownCast(vtkObjectBase o)
	{
		vtkExtractVOI vtkExtractVOI2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractVOI_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractVOI2 = (vtkExtractVOI)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractVOI2.Register(null);
			}
		}
		return vtkExtractVOI2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVOI_SetIncludeBoundary_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether to enforce that the "boundary" of the grid is output in
	/// the subsampling process. (This ivar only has effect when the SampleRate
	/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
	/// on, the subsampling will always include the boundary of the grid even
	/// though the sample rate is not an even multiple of the grid
	/// dimensions. (By default IncludeBoundary is off.)
	/// </summary>
	public virtual void SetIncludeBoundary(int _arg)
	{
		vtkExtractVOI_SetIncludeBoundary_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVOI_SetSampleRate_16(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set the sampling rate in the i, j, and k directions. If the rate is &gt;
	/// 1, then the resulting VOI will be subsampled representation of the
	/// input.  For example, if the SampleRate=(2,2,2), every other point will
	/// be selected, resulting in a volume 1/8th the original size.
	/// </summary>
	public virtual void SetSampleRate(int _arg1, int _arg2, int _arg3)
	{
		vtkExtractVOI_SetSampleRate_16(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVOI_SetSampleRate_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the sampling rate in the i, j, and k directions. If the rate is &gt;
	/// 1, then the resulting VOI will be subsampled representation of the
	/// input.  For example, if the SampleRate=(2,2,2), every other point will
	/// be selected, resulting in a volume 1/8th the original size.
	/// </summary>
	public virtual void SetSampleRate(IntPtr _arg)
	{
		vtkExtractVOI_SetSampleRate_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVOI_SetVOI_18(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Specify i-j-k (min,max) pairs to extract. The resulting structured points
	/// dataset can be of any topological dimension (i.e., point, line, image,
	/// or volume).
	/// </summary>
	public virtual void SetVOI(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkExtractVOI_SetVOI_18(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVOI_SetVOI_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify i-j-k (min,max) pairs to extract. The resulting structured points
	/// dataset can be of any topological dimension (i.e., point, line, image,
	/// or volume).
	/// </summary>
	public virtual void SetVOI(IntPtr _arg)
	{
		vtkExtractVOI_SetVOI_19(GetCppThis(), _arg);
	}
}
