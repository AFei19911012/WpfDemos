using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellSizeFilter
/// </summary>
/// <remarks>
///    Computes cell sizes.
///
/// Computes the cell sizes for all types of cells in VTK. For triangles,
/// quads, tets and hexes the static methods in vtkMeshQuality are used.
/// This is done through Verdict for higher accuracy.
/// Other cell types are individually done analytically where possible
/// and breaking into triangles or tets when not possible. When cells are
/// broken into triangles or tets the accuracy may be diminished. By default
/// all sizes are computed but vertex count, length, area and volumetric cells
/// can each be optionally ignored. Individual arrays are used for each
/// requested size (e.g. if length and volume are requested there will be
/// two arrays outputted from this filter). The 4 arrays can be individually
/// named with defaults of VertexCount, Length, Area and Volme. For dimensions
/// of cells that do not have their size computed, a value of 0 will be given.
/// For cells that should have their size computed but can't, the filter will return -1.
/// The ComputeSum option will sum the cell sizes (excluding ghost cells)
/// and put the value into vtkFieldData arrays named with the corresponding cell
/// data array name. For composite datasets the total sum over all blocks will
/// also be added to the top-level block's field data for the summation.
/// </remarks>
public class vtkCellSizeFilter : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellSizeFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellSizeFilter()
	{
		MRClassNameKey = "class vtkCellSizeFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellSizeFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellSizeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellSizeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellSizeFilter New()
	{
		vtkCellSizeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellSizeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellSizeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCellSizeFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellSizeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_ComputeAreaOff_01(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to compute sizes for 2D cells
	/// cells. The computed value is the area of the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual void ComputeAreaOff()
	{
		vtkCellSizeFilter_ComputeAreaOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_ComputeAreaOn_02(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to compute sizes for 2D cells
	/// cells. The computed value is the area of the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual void ComputeAreaOn()
	{
		vtkCellSizeFilter_ComputeAreaOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_ComputeLengthOff_03(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to compute sizes for 1D cells
	/// cells. The computed value is the length of the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual void ComputeLengthOff()
	{
		vtkCellSizeFilter_ComputeLengthOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_ComputeLengthOn_04(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to compute sizes for 1D cells
	/// cells. The computed value is the length of the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual void ComputeLengthOn()
	{
		vtkCellSizeFilter_ComputeLengthOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_ComputeSumOff_05(HandleRef pThis);

	/// <summary>
	/// Specify whether to sum the computed sizes and put the result in
	/// a field data array. This option is disabled by default.
	/// </summary>
	public virtual void ComputeSumOff()
	{
		vtkCellSizeFilter_ComputeSumOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_ComputeSumOn_06(HandleRef pThis);

	/// <summary>
	/// Specify whether to sum the computed sizes and put the result in
	/// a field data array. This option is disabled by default.
	/// </summary>
	public virtual void ComputeSumOn()
	{
		vtkCellSizeFilter_ComputeSumOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_ComputeVertexCountOff_07(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to compute sizes for vertex and polyvertex
	/// cells. The computed value is the number of points in the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual void ComputeVertexCountOff()
	{
		vtkCellSizeFilter_ComputeVertexCountOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_ComputeVertexCountOn_08(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to compute sizes for vertex and polyvertex
	/// cells. The computed value is the number of points in the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual void ComputeVertexCountOn()
	{
		vtkCellSizeFilter_ComputeVertexCountOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_ComputeVolumeOff_09(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to compute sizes for 3D cells
	/// cells. The computed value is the volume of the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual void ComputeVolumeOff()
	{
		vtkCellSizeFilter_ComputeVolumeOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_ComputeVolumeOn_10(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to compute sizes for 3D cells
	/// cells. The computed value is the volume of the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual void ComputeVolumeOn()
	{
		vtkCellSizeFilter_ComputeVolumeOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellSizeFilter_GetAreaArrayName_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the computed arrays. Default names are VertexCount,
	/// Length, Area and Volume.
	/// </summary>
	public virtual string GetAreaArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkCellSizeFilter_GetAreaArrayName_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellSizeFilter_GetComputeArea_12(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to compute sizes for 2D cells
	/// cells. The computed value is the area of the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual bool GetComputeArea()
	{
		return (vtkCellSizeFilter_GetComputeArea_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellSizeFilter_GetComputeLength_13(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to compute sizes for 1D cells
	/// cells. The computed value is the length of the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual bool GetComputeLength()
	{
		return (vtkCellSizeFilter_GetComputeLength_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellSizeFilter_GetComputeSum_14(HandleRef pThis);

	/// <summary>
	/// Specify whether to sum the computed sizes and put the result in
	/// a field data array. This option is disabled by default.
	/// </summary>
	public virtual bool GetComputeSum()
	{
		return (vtkCellSizeFilter_GetComputeSum_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellSizeFilter_GetComputeVertexCount_15(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to compute sizes for vertex and polyvertex
	/// cells. The computed value is the number of points in the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual bool GetComputeVertexCount()
	{
		return (vtkCellSizeFilter_GetComputeVertexCount_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellSizeFilter_GetComputeVolume_16(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to compute sizes for 3D cells
	/// cells. The computed value is the volume of the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual bool GetComputeVolume()
	{
		return (vtkCellSizeFilter_GetComputeVolume_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellSizeFilter_GetLengthArrayName_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the computed arrays. Default names are VertexCount,
	/// Length, Area and Volume.
	/// </summary>
	public virtual string GetLengthArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkCellSizeFilter_GetLengthArrayName_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellSizeFilter_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellSizeFilter_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellSizeFilter_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellSizeFilter_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellSizeFilter_GetVertexCountArrayName_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the computed arrays. Default names are VertexCount,
	/// Length, Area and Volume.
	/// </summary>
	public virtual string GetVertexCountArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkCellSizeFilter_GetVertexCountArrayName_20(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellSizeFilter_GetVolumeArrayName_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the computed arrays. Default names are VertexCount,
	/// Length, Area and Volume.
	/// </summary>
	public virtual string GetVolumeArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkCellSizeFilter_GetVolumeArrayName_21(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellSizeFilter_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellSizeFilter_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellSizeFilter_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellSizeFilter_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellSizeFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCellSizeFilter NewInstance()
	{
		vtkCellSizeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellSizeFilter_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellSizeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellSizeFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellSizeFilter SafeDownCast(vtkObjectBase o)
	{
		vtkCellSizeFilter vtkCellSizeFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellSizeFilter_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellSizeFilter2 = (vtkCellSizeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellSizeFilter2.Register(null);
			}
		}
		return vtkCellSizeFilter2;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_SetAreaArrayName_27(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the computed arrays. Default names are VertexCount,
	/// Length, Area and Volume.
	/// </summary>
	public virtual void SetAreaArrayName(string _arg)
	{
		vtkCellSizeFilter_SetAreaArrayName_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_SetComputeArea_28(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether or not to compute sizes for 2D cells
	/// cells. The computed value is the area of the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual void SetComputeArea(bool _arg)
	{
		vtkCellSizeFilter_SetComputeArea_28(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_SetComputeLength_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether or not to compute sizes for 1D cells
	/// cells. The computed value is the length of the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual void SetComputeLength(bool _arg)
	{
		vtkCellSizeFilter_SetComputeLength_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_SetComputeSum_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether to sum the computed sizes and put the result in
	/// a field data array. This option is disabled by default.
	/// </summary>
	public virtual void SetComputeSum(bool _arg)
	{
		vtkCellSizeFilter_SetComputeSum_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_SetComputeVertexCount_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether or not to compute sizes for vertex and polyvertex
	/// cells. The computed value is the number of points in the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual void SetComputeVertexCount(bool _arg)
	{
		vtkCellSizeFilter_SetComputeVertexCount_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_SetComputeVolume_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether or not to compute sizes for 3D cells
	/// cells. The computed value is the volume of the cell.
	/// This option is enabled by default.
	/// </summary>
	public virtual void SetComputeVolume(bool _arg)
	{
		vtkCellSizeFilter_SetComputeVolume_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_SetLengthArrayName_33(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the computed arrays. Default names are VertexCount,
	/// Length, Area and Volume.
	/// </summary>
	public virtual void SetLengthArrayName(string _arg)
	{
		vtkCellSizeFilter_SetLengthArrayName_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_SetVertexCountArrayName_34(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the computed arrays. Default names are VertexCount,
	/// Length, Area and Volume.
	/// </summary>
	public virtual void SetVertexCountArrayName(string _arg)
	{
		vtkCellSizeFilter_SetVertexCountArrayName_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellSizeFilter_SetVolumeArrayName_35(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the computed arrays. Default names are VertexCount,
	/// Length, Area and Volume.
	/// </summary>
	public virtual void SetVolumeArrayName(string _arg)
	{
		vtkCellSizeFilter_SetVolumeArrayName_35(GetCppThis(), _arg);
	}
}
