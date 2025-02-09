using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSpatialRepresentationFilter
/// </summary>
/// <remarks>
///    generate polygonal model of spatial search object (i.e., a vtkLocator)
///
/// vtkSpatialRepresentationFilter generates an polygonal representation of a
/// spatial search (vtkLocator) object. The representation varies depending
/// upon the nature of the spatial search object. For example, the
/// representation for vtkOBBTree is a collection of oriented bounding
/// boxes. This input to this filter is a dataset of any type, and the output
/// is polygonal data. You must also specify the spatial search object to
/// use.
///
/// Generally spatial search objects are used for collision detection and
/// other geometric operations, but in this filter one or more levels of
/// spatial searchers can be generated to form a geometric approximation to
/// the input data. This is a form of data simplification, generally used to
/// accelerate the rendering process. Or, this filter can be used as a
/// debugging/ visualization aid for spatial search objects.
///
/// This filter can generate one or more  vtkPolyData blocks corresponding to
/// different levels in the spatial search tree. The block ids range from 0
/// (root level) to MaximumLevel. Note that the block for level "id" is not computed
/// unless a AddLevel(id) method is issued. Thus, if you desire three levels of output
/// (say 2,4,7), you would have to invoke AddLevel(2), AddLevel(4), and
/// AddLevel(7). If GenerateLeaves is set to true (off by default), all leaf nodes
/// of the locator (which may be at different levels) are computed and stored in
/// block with id MaximumLevel + 1.
///
/// </remarks>
/// <seealso>
///
/// vtkLocator vtkPointLocator vtkCellLocator vtkOBBTree
/// </seealso>
public class vtkSpatialRepresentationFilter : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSpatialRepresentationFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSpatialRepresentationFilter()
	{
		MRClassNameKey = "class vtkSpatialRepresentationFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpatialRepresentationFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSpatialRepresentationFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpatialRepresentationFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSpatialRepresentationFilter New()
	{
		vtkSpatialRepresentationFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpatialRepresentationFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpatialRepresentationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSpatialRepresentationFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSpatialRepresentationFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpatialRepresentationFilter_AddLevel_01(HandleRef pThis, int level);

	/// <summary>
	/// Add a level to be computed.
	/// </summary>
	public void AddLevel(int level)
	{
		vtkSpatialRepresentationFilter_AddLevel_01(GetCppThis(), level);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpatialRepresentationFilter_GenerateLeavesOff_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of leaf nodes. Off by default.
	/// </summary>
	public virtual void GenerateLeavesOff()
	{
		vtkSpatialRepresentationFilter_GenerateLeavesOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpatialRepresentationFilter_GenerateLeavesOn_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of leaf nodes. Off by default.
	/// </summary>
	public virtual void GenerateLeavesOn()
	{
		vtkSpatialRepresentationFilter_GenerateLeavesOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSpatialRepresentationFilter_GetGenerateLeaves_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of leaf nodes. Off by default.
	/// </summary>
	public virtual bool GetGenerateLeaves()
	{
		return (vtkSpatialRepresentationFilter_GetGenerateLeaves_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpatialRepresentationFilter_GetMaximumLevel_05(HandleRef pThis);

	/// <summary>
	/// Get the maximum level that is available. Populated during
	/// RequestData().
	/// </summary>
	public virtual int GetMaximumLevel()
	{
		return vtkSpatialRepresentationFilter_GetMaximumLevel_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpatialRepresentationFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSpatialRepresentationFilter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpatialRepresentationFilter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSpatialRepresentationFilter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpatialRepresentationFilter_GetSpatialRepresentation_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the locator that will be used to generate the representation.
	/// </summary>
	public virtual vtkLocator GetSpatialRepresentation()
	{
		vtkLocator vtkLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpatialRepresentationFilter_GetSpatialRepresentation_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLocator2 = (vtkLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLocator2.Register(null);
			}
		}
		return vtkLocator2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpatialRepresentationFilter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSpatialRepresentationFilter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpatialRepresentationFilter_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSpatialRepresentationFilter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpatialRepresentationFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSpatialRepresentationFilter NewInstance()
	{
		vtkSpatialRepresentationFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpatialRepresentationFilter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpatialRepresentationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpatialRepresentationFilter_ResetLevels_13(HandleRef pThis);

	/// <summary>
	/// Remove all levels.
	/// </summary>
	public void ResetLevels()
	{
		vtkSpatialRepresentationFilter_ResetLevels_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpatialRepresentationFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSpatialRepresentationFilter SafeDownCast(vtkObjectBase o)
	{
		vtkSpatialRepresentationFilter vtkSpatialRepresentationFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpatialRepresentationFilter_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSpatialRepresentationFilter2 = (vtkSpatialRepresentationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSpatialRepresentationFilter2.Register(null);
			}
		}
		return vtkSpatialRepresentationFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpatialRepresentationFilter_SetGenerateLeaves_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the generation of leaf nodes. Off by default.
	/// </summary>
	public virtual void SetGenerateLeaves(bool _arg)
	{
		vtkSpatialRepresentationFilter_SetGenerateLeaves_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpatialRepresentationFilter_SetSpatialRepresentation_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the locator that will be used to generate the representation.
	/// </summary>
	public virtual void SetSpatialRepresentation(vtkLocator arg0)
	{
		vtkSpatialRepresentationFilter_SetSpatialRepresentation_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
