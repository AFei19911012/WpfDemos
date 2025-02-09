using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCirclePackLayout
/// </summary>
/// <remarks>
///    layout a vtkTree as a circle packing.
///
///
/// vtkCirclePackLayout assigns circle shaped regions to each vertex
/// in the tree, creating a circle packing layout.  The data is added
/// as a data array with three components per tuple representing the
/// center and radius of the circle using the format (Xcenter, Ycenter, Radius).
///
/// This algorithm relies on a helper class to perform the actual layout.
/// This helper class is a subclass of vtkCirclePackLayoutStrategy.
///
/// An array by default called "size" can be attached to the input tree
/// that specifies the size of each leaf node in the tree.  The filter will
/// calculate the sizes of all interior nodes in the tree based on the sum
/// of the leaf node sizes.  If no "size" array is given in the input vtkTree,
/// a size of 1 is used for all leaf nodes to find the size of the interior nodes.
///
/// @par Thanks:
/// Thanks to Thomas Otahal from Sandia National Laboratories
/// for help developing this class.
///
/// </remarks>
public class vtkCirclePackLayout : vtkTreeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCirclePackLayout";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCirclePackLayout()
	{
		MRClassNameKey = "class vtkCirclePackLayout";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCirclePackLayout"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCirclePackLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCirclePackLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCirclePackLayout New()
	{
		vtkCirclePackLayout result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCirclePackLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCirclePackLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCirclePackLayout()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCirclePackLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCirclePackLayout_FindVertex_01(HandleRef pThis, IntPtr pnt, IntPtr cinfo);

	/// <summary>
	/// Returns the vertex id that contains pnt (or -1 if no one contains it)
	/// pnt[0] is x, and pnt[1] is y.
	/// If cinfo[3] is provided, then (Xcenter, Ycenter, Radius) of the circle
	/// containing pnt[2] will be returned.
	/// </summary>
	public long FindVertex(IntPtr pnt, IntPtr cinfo)
	{
		return vtkCirclePackLayout_FindVertex_01(GetCppThis(), pnt, cinfo);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCirclePackLayout_GetBoundingCircle_02(HandleRef pThis, long id, IntPtr cinfo);

	/// <summary>
	/// Return the Xcenter, Ycenter, and Radius of the
	/// vertex's bounding circle
	/// </summary>
	public void GetBoundingCircle(long id, IntPtr cinfo)
	{
		vtkCirclePackLayout_GetBoundingCircle_02(GetCppThis(), id, cinfo);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCirclePackLayout_GetCirclesFieldName_03(HandleRef pThis);

	/// <summary>
	/// The field name to use for storing the circles for each vertex.
	/// The rectangles are stored in a triple float array
	/// (Xcenter, Ycenter, Radius).
	/// Default name is "circles"
	/// </summary>
	public virtual string GetCirclesFieldName()
	{
		return Marshal.PtrToStringAnsi(vtkCirclePackLayout_GetCirclesFieldName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCirclePackLayout_GetLayoutStrategy_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The strategy to use when laying out the tree map.
	/// </summary>
	public virtual vtkCirclePackLayoutStrategy GetLayoutStrategy()
	{
		vtkCirclePackLayoutStrategy vtkCirclePackLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCirclePackLayout_GetLayoutStrategy_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCirclePackLayoutStrategy2 = (vtkCirclePackLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCirclePackLayoutStrategy2.Register(null);
			}
		}
		return vtkCirclePackLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkCirclePackLayout_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// Get the modification time of the layout algorithm.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkCirclePackLayout_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCirclePackLayout_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCirclePackLayout_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCirclePackLayout_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCirclePackLayout_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCirclePackLayout_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCirclePackLayout_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCirclePackLayout_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCirclePackLayout_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCirclePackLayout_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCirclePackLayout NewInstance()
	{
		vtkCirclePackLayout result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCirclePackLayout_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCirclePackLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCirclePackLayout_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCirclePackLayout SafeDownCast(vtkObjectBase o)
	{
		vtkCirclePackLayout vtkCirclePackLayout2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCirclePackLayout_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCirclePackLayout2 = (vtkCirclePackLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCirclePackLayout2.Register(null);
			}
		}
		return vtkCirclePackLayout2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCirclePackLayout_SetCirclesFieldName_13(HandleRef pThis, string _arg);

	/// <summary>
	/// The field name to use for storing the circles for each vertex.
	/// The rectangles are stored in a triple float array
	/// (Xcenter, Ycenter, Radius).
	/// Default name is "circles"
	/// </summary>
	public virtual void SetCirclesFieldName(string _arg)
	{
		vtkCirclePackLayout_SetCirclesFieldName_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCirclePackLayout_SetLayoutStrategy_14(HandleRef pThis, HandleRef strategy);

	/// <summary>
	/// The strategy to use when laying out the tree map.
	/// </summary>
	public void SetLayoutStrategy(vtkCirclePackLayoutStrategy strategy)
	{
		vtkCirclePackLayout_SetLayoutStrategy_14(GetCppThis(), strategy?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCirclePackLayout_SetSizeArrayName_15(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for the size of each vertex.
	/// Default name is "size".
	/// </summary>
	public virtual void SetSizeArrayName(string name)
	{
		vtkCirclePackLayout_SetSizeArrayName_15(GetCppThis(), name);
	}
}
