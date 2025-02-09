using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractRectilinearGrid
/// </summary>
/// <remarks>
///    Extract a sub grid (VOI) from the structured rectilinear dataset.
///
/// vtkExtractRectilinearGrid rounds out the set of filters that extract
/// a subgrid out of a larger structured data set.  RIght now, this filter
/// only supports extracting a VOI.  In the future, it might support
/// strides like the vtkExtract grid filter.
///
/// </remarks>
/// <seealso>
///
/// vtkExtractGrid vtkImageClip vtkGeometryFilter vtkExtractGeometry vtkExtractVOI
/// vtkStructuredGridGeometryFilter
/// </seealso>
public class vtkExtractRectilinearGrid : vtkRectilinearGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractRectilinearGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractRectilinearGrid()
	{
		MRClassNameKey = "class vtkExtractRectilinearGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractRectilinearGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractRectilinearGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractRectilinearGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractRectilinearGrid New()
	{
		vtkExtractRectilinearGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractRectilinearGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractRectilinearGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractRectilinearGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractRectilinearGrid_GetIncludeBoundary_01(HandleRef pThis);

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
		return vtkExtractRectilinearGrid_GetIncludeBoundary_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractRectilinearGrid_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractRectilinearGrid_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractRectilinearGrid_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractRectilinearGrid_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractRectilinearGrid_GetSampleRate_04(HandleRef pThis);

	/// <summary>
	/// Set the sampling rate in the i, j, and k directions. If the rate is &gt; 1,
	/// then the resulting VOI will be subsampled representation of the input.
	/// For example, if the SampleRate=(2,2,2), every other point will be
	/// selected, resulting in a volume 1/8th the original size.
	/// Initial value is (1,1,1).
	/// </summary>
	public virtual int[] GetSampleRate()
	{
		IntPtr intPtr = vtkExtractRectilinearGrid_GetSampleRate_04(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractRectilinearGrid_GetSampleRate_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the sampling rate in the i, j, and k directions. If the rate is &gt; 1,
	/// then the resulting VOI will be subsampled representation of the input.
	/// For example, if the SampleRate=(2,2,2), every other point will be
	/// selected, resulting in a volume 1/8th the original size.
	/// Initial value is (1,1,1).
	/// </summary>
	public virtual void GetSampleRate(IntPtr data)
	{
		vtkExtractRectilinearGrid_GetSampleRate_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractRectilinearGrid_GetVOI_06(HandleRef pThis);

	/// <summary>
	/// Specify i-j-k (min,max) pairs to extract. The resulting structured grid
	/// dataset can be of any topological dimension (i.e., point, line, plane,
	/// or 3D grid).
	/// </summary>
	public virtual int[] GetVOI()
	{
		IntPtr intPtr = vtkExtractRectilinearGrid_GetVOI_06(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractRectilinearGrid_GetVOI_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify i-j-k (min,max) pairs to extract. The resulting structured grid
	/// dataset can be of any topological dimension (i.e., point, line, plane,
	/// or 3D grid).
	/// </summary>
	public virtual void GetVOI(IntPtr data)
	{
		vtkExtractRectilinearGrid_GetVOI_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractRectilinearGrid_IncludeBoundaryOff_08(HandleRef pThis);

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
		vtkExtractRectilinearGrid_IncludeBoundaryOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractRectilinearGrid_IncludeBoundaryOn_09(HandleRef pThis);

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
		vtkExtractRectilinearGrid_IncludeBoundaryOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractRectilinearGrid_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractRectilinearGrid_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractRectilinearGrid_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractRectilinearGrid_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractRectilinearGrid_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractRectilinearGrid NewInstance()
	{
		vtkExtractRectilinearGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractRectilinearGrid_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractRectilinearGrid_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractRectilinearGrid SafeDownCast(vtkObjectBase o)
	{
		vtkExtractRectilinearGrid vtkExtractRectilinearGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractRectilinearGrid_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractRectilinearGrid2 = (vtkExtractRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractRectilinearGrid2.Register(null);
			}
		}
		return vtkExtractRectilinearGrid2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractRectilinearGrid_SetIncludeBoundary_15(HandleRef pThis, int _arg);

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
		vtkExtractRectilinearGrid_SetIncludeBoundary_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractRectilinearGrid_SetSampleRate_16(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set the sampling rate in the i, j, and k directions. If the rate is &gt; 1,
	/// then the resulting VOI will be subsampled representation of the input.
	/// For example, if the SampleRate=(2,2,2), every other point will be
	/// selected, resulting in a volume 1/8th the original size.
	/// Initial value is (1,1,1).
	/// </summary>
	public virtual void SetSampleRate(int _arg1, int _arg2, int _arg3)
	{
		vtkExtractRectilinearGrid_SetSampleRate_16(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractRectilinearGrid_SetSampleRate_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the sampling rate in the i, j, and k directions. If the rate is &gt; 1,
	/// then the resulting VOI will be subsampled representation of the input.
	/// For example, if the SampleRate=(2,2,2), every other point will be
	/// selected, resulting in a volume 1/8th the original size.
	/// Initial value is (1,1,1).
	/// </summary>
	public virtual void SetSampleRate(IntPtr _arg)
	{
		vtkExtractRectilinearGrid_SetSampleRate_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractRectilinearGrid_SetVOI_18(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Specify i-j-k (min,max) pairs to extract. The resulting structured grid
	/// dataset can be of any topological dimension (i.e., point, line, plane,
	/// or 3D grid).
	/// </summary>
	public virtual void SetVOI(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkExtractRectilinearGrid_SetVOI_18(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractRectilinearGrid_SetVOI_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify i-j-k (min,max) pairs to extract. The resulting structured grid
	/// dataset can be of any topological dimension (i.e., point, line, plane,
	/// or 3D grid).
	/// </summary>
	public virtual void SetVOI(IntPtr _arg)
	{
		vtkExtractRectilinearGrid_SetVOI_19(GetCppThis(), _arg);
	}
}
