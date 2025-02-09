using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCirclePackLayoutStrategy
/// </summary>
/// <remarks>
///    abstract superclass for all circle packing
/// layout strategies.
///
///
/// All subclasses of this class perform a circle packing layout on a vtkTree.
/// This involves assigning a circle to each vertex in the tree,
/// and placing that information in a data array with three components per
/// tuple representing (Xcenter, Ycenter, Radius).
///
/// Instances of subclasses of this class may be assigned as the layout
/// strategy to vtkCirclePackLayout
///
/// @par Thanks:
/// Thanks to Thomas Otahal from Sandia National Laboratories
/// for help developing this class.
/// </remarks>
public abstract class vtkCirclePackLayoutStrategy : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCirclePackLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCirclePackLayoutStrategy()
	{
		MRClassNameKey = "class vtkCirclePackLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCirclePackLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCirclePackLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern long vtkCirclePackLayoutStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCirclePackLayoutStrategy_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCirclePackLayoutStrategy_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCirclePackLayoutStrategy_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCirclePackLayoutStrategy_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCirclePackLayoutStrategy_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCirclePackLayoutStrategy_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCirclePackLayoutStrategy_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCirclePackLayoutStrategy_Layout_05(HandleRef pThis, HandleRef inputTree, HandleRef areaArray, HandleRef sizeArray);

	/// <summary>
	/// Perform the layout of the input tree, and store the circle
	/// bounds of each vertex as a tuple in a data array.
	/// (Xcenter, Ycenter, Radius).
	///
	/// The sizeArray may be nullptr, or may contain the desired
	/// size of each vertex in the tree.
	/// </summary>
	public virtual void Layout(vtkTree inputTree, vtkDataArray areaArray, vtkDataArray sizeArray)
	{
		vtkCirclePackLayoutStrategy_Layout_05(GetCppThis(), inputTree?.GetCppThis() ?? default(HandleRef), areaArray?.GetCppThis() ?? default(HandleRef), sizeArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCirclePackLayoutStrategy_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCirclePackLayoutStrategy NewInstance()
	{
		vtkCirclePackLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCirclePackLayoutStrategy_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCirclePackLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCirclePackLayoutStrategy_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCirclePackLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkCirclePackLayoutStrategy vtkCirclePackLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCirclePackLayoutStrategy_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
}
