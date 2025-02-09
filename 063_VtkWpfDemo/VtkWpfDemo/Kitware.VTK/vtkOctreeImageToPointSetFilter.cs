using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOctreeImageToPointSetFilter
/// </summary>
/// <remarks>
///    Convert an octree image to point set
///
/// vtkOctreeImageToPointSetFilter is a filter that converts an image with an octree unsigned char
/// cell array to a pointset. Each bit of the unsigned char indicates if the cell had a point close
/// to one of its 8 corners.
///
/// It can optionally also output a point data array based on an input cell data scalar array by
/// setting SetInputArrayToProcess. This array will have one of the components of the input array.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///  vtkPointSetToOctreeImageFilter
/// </seealso>
public class vtkOctreeImageToPointSetFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOctreeImageToPointSetFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOctreeImageToPointSetFilter()
	{
		MRClassNameKey = "class vtkOctreeImageToPointSetFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOctreeImageToPointSetFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOctreeImageToPointSetFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreeImageToPointSetFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOctreeImageToPointSetFilter New()
	{
		vtkOctreeImageToPointSetFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOctreeImageToPointSetFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOctreeImageToPointSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOctreeImageToPointSetFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOctreeImageToPointSetFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreeImageToPointSetFilter_CreateVerticesCellArrayOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get if a cell array of vertices will be created.
	///
	/// The default is on.
	/// </summary>
	public virtual void CreateVerticesCellArrayOff()
	{
		vtkOctreeImageToPointSetFilter_CreateVerticesCellArrayOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreeImageToPointSetFilter_CreateVerticesCellArrayOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get if a cell array of vertices will be created.
	///
	/// The default is on.
	/// </summary>
	public virtual void CreateVerticesCellArrayOn()
	{
		vtkOctreeImageToPointSetFilter_CreateVerticesCellArrayOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreeImageToPointSetFilter_GetCellArrayComponent_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the component of the input cell data array to process.
	///
	/// The default is 0.
	/// </summary>
	public virtual int GetCellArrayComponent()
	{
		return vtkOctreeImageToPointSetFilter_GetCellArrayComponent_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreeImageToPointSetFilter_GetCellArrayComponentMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the component of the input cell data array to process.
	///
	/// The default is 0.
	/// </summary>
	public virtual int GetCellArrayComponentMaxValue()
	{
		return vtkOctreeImageToPointSetFilter_GetCellArrayComponentMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreeImageToPointSetFilter_GetCellArrayComponentMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the component of the input cell data array to process.
	///
	/// The default is 0.
	/// </summary>
	public virtual int GetCellArrayComponentMinValue()
	{
		return vtkOctreeImageToPointSetFilter_GetCellArrayComponentMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOctreeImageToPointSetFilter_GetCreateVerticesCellArray_06(HandleRef pThis);

	/// <summary>
	/// Set/Get if a cell array of vertices will be created.
	///
	/// The default is on.
	/// </summary>
	public virtual bool GetCreateVerticesCellArray()
	{
		return (vtkOctreeImageToPointSetFilter_GetCreateVerticesCellArray_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOctreeImageToPointSetFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOctreeImageToPointSetFilter_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOctreeImageToPointSetFilter_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOctreeImageToPointSetFilter_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOctreeImageToPointSetFilter_GetProcessInputCellArray_09(HandleRef pThis);

	/// <summary>
	/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a cell data array, will
	/// be processed.
	///
	/// The default is off.
	/// </summary>
	public virtual bool GetProcessInputCellArray()
	{
		return (vtkOctreeImageToPointSetFilter_GetProcessInputCellArray_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreeImageToPointSetFilter_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOctreeImageToPointSetFilter_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreeImageToPointSetFilter_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOctreeImageToPointSetFilter_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreeImageToPointSetFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOctreeImageToPointSetFilter NewInstance()
	{
		vtkOctreeImageToPointSetFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOctreeImageToPointSetFilter_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOctreeImageToPointSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreeImageToPointSetFilter_ProcessInputCellArrayOff_14(HandleRef pThis);

	/// <summary>
	/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a cell data array, will
	/// be processed.
	///
	/// The default is off.
	/// </summary>
	public virtual void ProcessInputCellArrayOff()
	{
		vtkOctreeImageToPointSetFilter_ProcessInputCellArrayOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreeImageToPointSetFilter_ProcessInputCellArrayOn_15(HandleRef pThis);

	/// <summary>
	/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a cell data array, will
	/// be processed.
	///
	/// The default is off.
	/// </summary>
	public virtual void ProcessInputCellArrayOn()
	{
		vtkOctreeImageToPointSetFilter_ProcessInputCellArrayOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreeImageToPointSetFilter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOctreeImageToPointSetFilter SafeDownCast(vtkObjectBase o)
	{
		vtkOctreeImageToPointSetFilter vtkOctreeImageToPointSetFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOctreeImageToPointSetFilter_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOctreeImageToPointSetFilter2 = (vtkOctreeImageToPointSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOctreeImageToPointSetFilter2.Register(null);
			}
		}
		return vtkOctreeImageToPointSetFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreeImageToPointSetFilter_SetCellArrayComponent_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the component of the input cell data array to process.
	///
	/// The default is 0.
	/// </summary>
	public virtual void SetCellArrayComponent(int _arg)
	{
		vtkOctreeImageToPointSetFilter_SetCellArrayComponent_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreeImageToPointSetFilter_SetCreateVerticesCellArray_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if a cell array of vertices will be created.
	///
	/// The default is on.
	/// </summary>
	public virtual void SetCreateVerticesCellArray(bool _arg)
	{
		vtkOctreeImageToPointSetFilter_SetCreateVerticesCellArray_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreeImageToPointSetFilter_SetProcessInputCellArray_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a cell data array, will
	/// be processed.
	///
	/// The default is off.
	/// </summary>
	public virtual void SetProcessInputCellArray(bool _arg)
	{
		vtkOctreeImageToPointSetFilter_SetProcessInputCellArray_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
