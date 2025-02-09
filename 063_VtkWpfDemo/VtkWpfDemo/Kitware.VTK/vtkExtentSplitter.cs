using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtentSplitter
/// </summary>
/// <remarks>
///    Split an extent across other extents.
///
/// vtkExtentSplitter splits each input extent into non-overlapping
/// sub-extents that are completely contained within other "source
/// extents".  A source extent corresponds to some resource providing
/// an extent.  Each source extent has an integer identifier, integer
/// priority, and an extent.  The input extents are split into
/// sub-extents according to priority, availability, and amount of
/// overlap of the source extents.  This can be used by parallel data
/// readers to read as few piece files as possible.
/// </remarks>
public class vtkExtentSplitter : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtentSplitter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtentSplitter()
	{
		MRClassNameKey = "class vtkExtentSplitter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtentSplitter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtentSplitter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentSplitter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtentSplitter New()
	{
		vtkExtentSplitter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtentSplitter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtentSplitter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtentSplitter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtentSplitter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentSplitter_AddExtent_01(HandleRef pThis, int x0, int x1, int y0, int y1, int z0, int z1);

	/// <summary>
	/// Add an extent to the queue of extents to be split among the
	/// available sources.
	/// </summary>
	public void AddExtent(int x0, int x1, int y0, int y1, int z0, int z1)
	{
		vtkExtentSplitter_AddExtent_01(GetCppThis(), x0, x1, y0, y1, z0, z1);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentSplitter_AddExtent_02(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Add an extent to the queue of extents to be split among the
	/// available sources.
	/// </summary>
	public void AddExtent(IntPtr extent)
	{
		vtkExtentSplitter_AddExtent_02(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentSplitter_AddExtentSource_03(HandleRef pThis, int id, int priority, int x0, int x1, int y0, int y1, int z0, int z1);

	/// <summary>
	/// Add/Remove a source providing the given extent.  Sources with
	/// higher priority numbers are favored.  Source id numbers and
	/// priorities must be non-negative.
	/// </summary>
	public void AddExtentSource(int id, int priority, int x0, int x1, int y0, int y1, int z0, int z1)
	{
		vtkExtentSplitter_AddExtentSource_03(GetCppThis(), id, priority, x0, x1, y0, y1, z0, z1);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentSplitter_AddExtentSource_04(HandleRef pThis, int id, int priority, IntPtr extent);

	/// <summary>
	/// Add/Remove a source providing the given extent.  Sources with
	/// higher priority numbers are favored.  Source id numbers and
	/// priorities must be non-negative.
	/// </summary>
	public void AddExtentSource(int id, int priority, IntPtr extent)
	{
		vtkExtentSplitter_AddExtentSource_04(GetCppThis(), id, priority, extent);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentSplitter_ComputeSubExtents_05(HandleRef pThis);

	/// <summary>
	/// Split the extents currently in the queue among the available
	/// sources.  The queue is empty when this returns.  Returns 1 if all
	/// extents could be read.  Returns 0 if any portion of any extent
	/// was not available through any source.
	/// </summary>
	public int ComputeSubExtents()
	{
		return vtkExtentSplitter_ComputeSubExtents_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtentSplitter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtentSplitter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtentSplitter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtentSplitter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentSplitter_GetNumberOfSubExtents_08(HandleRef pThis);

	/// <summary>
	/// Get the number of sub-extents into which the original set of
	/// extents have been split across the available sources.  Valid
	/// after a call to ComputeSubExtents.
	/// </summary>
	public int GetNumberOfSubExtents()
	{
		return vtkExtentSplitter_GetNumberOfSubExtents_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentSplitter_GetPointMode_09(HandleRef pThis);

	/// <summary>
	/// Get/Set whether "point mode" is on.  In point mode, sub-extents
	/// are generated to ensure every point in the update request is
	/// read, but not necessarily every cell.  This can be used when
	/// point data are stored in a planar slice per piece with no cell
	/// data.  The default is OFF.
	/// </summary>
	public virtual int GetPointMode()
	{
		return vtkExtentSplitter_GetPointMode_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentSplitter_GetSubExtent_10(HandleRef pThis, int index);

	/// <summary>
	/// Get the sub-extent associated with the given index.  Use
	/// GetSubExtentSource to get the id of the source from which this
	/// sub-extent should be read.  Valid after a call to
	/// ComputeSubExtents.
	/// </summary>
	public int[] GetSubExtent(int index)
	{
		IntPtr intPtr = vtkExtentSplitter_GetSubExtent_10(GetCppThis(), index);
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentSplitter_GetSubExtent_11(HandleRef pThis, int index, IntPtr extent);

	/// <summary>
	/// Get the sub-extent associated with the given index.  Use
	/// GetSubExtentSource to get the id of the source from which this
	/// sub-extent should be read.  Valid after a call to
	/// ComputeSubExtents.
	/// </summary>
	public void GetSubExtent(int index, IntPtr extent)
	{
		vtkExtentSplitter_GetSubExtent_11(GetCppThis(), index, extent);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentSplitter_GetSubExtentSource_12(HandleRef pThis, int index);

	/// <summary>
	/// Get the id of the source from which the sub-extent associated
	/// with the given index should be read.  Returns -1 if no source
	/// provides the sub-extent.
	/// </summary>
	public int GetSubExtentSource(int index)
	{
		return vtkExtentSplitter_GetSubExtentSource_12(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentSplitter_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtentSplitter_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentSplitter_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtentSplitter_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentSplitter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtentSplitter NewInstance()
	{
		vtkExtentSplitter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtentSplitter_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtentSplitter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentSplitter_PointModeOff_17(HandleRef pThis);

	/// <summary>
	/// Get/Set whether "point mode" is on.  In point mode, sub-extents
	/// are generated to ensure every point in the update request is
	/// read, but not necessarily every cell.  This can be used when
	/// point data are stored in a planar slice per piece with no cell
	/// data.  The default is OFF.
	/// </summary>
	public virtual void PointModeOff()
	{
		vtkExtentSplitter_PointModeOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentSplitter_PointModeOn_18(HandleRef pThis);

	/// <summary>
	/// Get/Set whether "point mode" is on.  In point mode, sub-extents
	/// are generated to ensure every point in the update request is
	/// read, but not necessarily every cell.  This can be used when
	/// point data are stored in a planar slice per piece with no cell
	/// data.  The default is OFF.
	/// </summary>
	public virtual void PointModeOn()
	{
		vtkExtentSplitter_PointModeOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentSplitter_RemoveAllExtentSources_19(HandleRef pThis);

	/// <summary>
	/// Add/Remove a source providing the given extent.  Sources with
	/// higher priority numbers are favored.  Source id numbers and
	/// priorities must be non-negative.
	/// </summary>
	public void RemoveAllExtentSources()
	{
		vtkExtentSplitter_RemoveAllExtentSources_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentSplitter_RemoveExtentSource_20(HandleRef pThis, int id);

	/// <summary>
	/// Add/Remove a source providing the given extent.  Sources with
	/// higher priority numbers are favored.  Source id numbers and
	/// priorities must be non-negative.
	/// </summary>
	public void RemoveExtentSource(int id)
	{
		vtkExtentSplitter_RemoveExtentSource_20(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentSplitter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtentSplitter SafeDownCast(vtkObjectBase o)
	{
		vtkExtentSplitter vtkExtentSplitter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtentSplitter_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtentSplitter2 = (vtkExtentSplitter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtentSplitter2.Register(null);
			}
		}
		return vtkExtentSplitter2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentSplitter_SetPointMode_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set whether "point mode" is on.  In point mode, sub-extents
	/// are generated to ensure every point in the update request is
	/// read, but not necessarily every cell.  This can be used when
	/// point data are stored in a planar slice per piece with no cell
	/// data.  The default is OFF.
	/// </summary>
	public virtual void SetPointMode(int _arg)
	{
		vtkExtentSplitter_SetPointMode_22(GetCppThis(), _arg);
	}
}
