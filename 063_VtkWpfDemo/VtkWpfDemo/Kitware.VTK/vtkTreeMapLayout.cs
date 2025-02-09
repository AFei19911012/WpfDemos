using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTreeMapLayout
/// </summary>
/// <remarks>
///    layout a vtkTree into a tree map
///
///
/// vtkTreeMapLayout assigns rectangular regions to each vertex in the tree,
/// creating a tree map.  The data is added as a data array with four
/// components per tuple representing the location and size of the
/// rectangle using the format (Xmin, Xmax, Ymin, Ymax).
///
/// This algorithm relies on a helper class to perform the actual layout.
/// This helper class is a subclass of vtkTreeMapLayoutStrategy.
///
/// @par Thanks:
/// Thanks to Brian Wylie and Ken Moreland from Sandia National Laboratories
/// for help developing this class.
///
/// @par Thanks:
/// Tree map concept comes from:
/// Shneiderman, B. 1992. Tree visualization with tree-maps: 2-d space-filling approach.
/// ACM Trans. Graph. 11, 1 (Jan. 1992), 92-99.
/// </remarks>
public class vtkTreeMapLayout : vtkTreeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTreeMapLayout";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTreeMapLayout()
	{
		MRClassNameKey = "class vtkTreeMapLayout";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeMapLayout"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTreeMapLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeMapLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeMapLayout New()
	{
		vtkTreeMapLayout result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeMapLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeMapLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTreeMapLayout()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTreeMapLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkTreeMapLayout_FindVertex_01(HandleRef pThis, IntPtr pnt, IntPtr binfo);

	/// <summary>
	/// Returns the vertex id that contains pnt (or -1 if no one contains it)
	/// </summary>
	public long FindVertex(IntPtr pnt, IntPtr binfo)
	{
		return vtkTreeMapLayout_FindVertex_01(GetCppThis(), pnt, binfo);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapLayout_GetBoundingBox_02(HandleRef pThis, long id, IntPtr binfo);

	/// <summary>
	/// Return the min and max 2D points of the
	/// vertex's bounding box
	/// </summary>
	public void GetBoundingBox(long id, IntPtr binfo)
	{
		vtkTreeMapLayout_GetBoundingBox_02(GetCppThis(), id, binfo);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeMapLayout_GetLayoutStrategy_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The strategy to use when laying out the tree map.
	/// </summary>
	public virtual vtkTreeMapLayoutStrategy GetLayoutStrategy()
	{
		vtkTreeMapLayoutStrategy vtkTreeMapLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeMapLayout_GetLayoutStrategy_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeMapLayoutStrategy2 = (vtkTreeMapLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeMapLayoutStrategy2.Register(null);
			}
		}
		return vtkTreeMapLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTreeMapLayout_GetMTime_04(HandleRef pThis);

	/// <summary>
	/// Get the modification time of the layout algorithm.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkTreeMapLayout_GetMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeMapLayout_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTreeMapLayout_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeMapLayout_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTreeMapLayout_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeMapLayout_GetRectanglesFieldName_07(HandleRef pThis);

	/// <summary>
	/// The field name to use for storing the rectangles for each vertex.
	/// The rectangles are stored in a quadruple float array
	/// (minX, maxX, minY, maxY).
	/// </summary>
	public virtual string GetRectanglesFieldName()
	{
		return Marshal.PtrToStringAnsi(vtkTreeMapLayout_GetRectanglesFieldName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeMapLayout_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTreeMapLayout_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeMapLayout_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTreeMapLayout_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeMapLayout_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTreeMapLayout NewInstance()
	{
		vtkTreeMapLayout result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeMapLayout_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeMapLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeMapLayout_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeMapLayout SafeDownCast(vtkObjectBase o)
	{
		vtkTreeMapLayout vtkTreeMapLayout2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeMapLayout_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeMapLayout2 = (vtkTreeMapLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeMapLayout2.Register(null);
			}
		}
		return vtkTreeMapLayout2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapLayout_SetLayoutStrategy_13(HandleRef pThis, HandleRef strategy);

	/// <summary>
	/// The strategy to use when laying out the tree map.
	/// </summary>
	public void SetLayoutStrategy(vtkTreeMapLayoutStrategy strategy)
	{
		vtkTreeMapLayout_SetLayoutStrategy_13(GetCppThis(), strategy?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapLayout_SetRectanglesFieldName_14(HandleRef pThis, string _arg);

	/// <summary>
	/// The field name to use for storing the rectangles for each vertex.
	/// The rectangles are stored in a quadruple float array
	/// (minX, maxX, minY, maxY).
	/// </summary>
	public virtual void SetRectanglesFieldName(string _arg)
	{
		vtkTreeMapLayout_SetRectanglesFieldName_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapLayout_SetSizeArrayName_15(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for the size of each vertex.
	/// </summary>
	public virtual void SetSizeArrayName(string name)
	{
		vtkTreeMapLayout_SetSizeArrayName_15(GetCppThis(), name);
	}
}
