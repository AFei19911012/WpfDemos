using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkNonMergingPointLocator
/// </summary>
/// <remarks>
///    direct / check-free point insertion.
///
///
///  As a special sub-class of vtkPointLocator, vtkNonMergingPointLocator is
///  intended for direct / check-free insertion of points into a vtkPoints
///  object. In other words, any given point is always directly inserted.
///  The name emphasizes the difference between this class and its sibling
///  class vtkMergePoints in that the latter class performs check-based zero
///  tolerance point insertion (or to 'merge' exactly duplicate / coincident
///  points) by exploiting the uniform bin mechanism employed by the parent
///  class vtkPointLocator. vtkPointLocator allows for generic (zero and non-
///  zero) tolerance point insertion as well as point location.
///
/// </remarks>
/// <seealso>
///
///  vtkIncrementalPointLocator vtkPointLocator vtkMergePoints
/// </seealso>
public class vtkNonMergingPointLocator : vtkPointLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNonMergingPointLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNonMergingPointLocator()
	{
		MRClassNameKey = "class vtkNonMergingPointLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNonMergingPointLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNonMergingPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNonMergingPointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNonMergingPointLocator New()
	{
		vtkNonMergingPointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNonMergingPointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNonMergingPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkNonMergingPointLocator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNonMergingPointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNonMergingPointLocator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNonMergingPointLocator_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNonMergingPointLocator_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNonMergingPointLocator_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNonMergingPointLocator_InsertUniquePoint_03(HandleRef pThis, IntPtr x, ref long ptId);

	/// <summary>
	/// Determine whether a given point x has been inserted into the points list.
	/// Return 0 if a duplicate has been inserted in the list, or 1 else. Note
	/// this function always returns 1 since any point is always inserted. The
	/// index of the point is returned via ptId.
	/// </summary>
	public override int InsertUniquePoint(IntPtr x, ref long ptId)
	{
		return vtkNonMergingPointLocator_InsertUniquePoint_03(GetCppThis(), x, ref ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNonMergingPointLocator_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNonMergingPointLocator_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNonMergingPointLocator_IsInsertedPoint_05(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Determine whether a given point x has been inserted into the points list.
	/// Return the id of the already inserted point if it is true, or -1 else.
	/// Note this function always returns -1 since any point is always inserted.
	/// </summary>
	public override long IsInsertedPoint(IntPtr arg0)
	{
		return vtkNonMergingPointLocator_IsInsertedPoint_05(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNonMergingPointLocator_IsInsertedPoint_06(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Determine whether a given point x has been inserted into the points list.
	/// Return the id of the already inserted point if it is true, or -1 else.
	/// Note this function always returns -1 since any point is always inserted.
	/// </summary>
	public override long IsInsertedPoint(double arg0, double arg1, double arg2)
	{
		return vtkNonMergingPointLocator_IsInsertedPoint_06(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNonMergingPointLocator_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNonMergingPointLocator_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNonMergingPointLocator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkNonMergingPointLocator NewInstance()
	{
		vtkNonMergingPointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNonMergingPointLocator_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNonMergingPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNonMergingPointLocator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNonMergingPointLocator SafeDownCast(vtkObjectBase o)
	{
		vtkNonMergingPointLocator vtkNonMergingPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNonMergingPointLocator_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNonMergingPointLocator2 = (vtkNonMergingPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNonMergingPointLocator2.Register(null);
			}
		}
		return vtkNonMergingPointLocator2;
	}
}
