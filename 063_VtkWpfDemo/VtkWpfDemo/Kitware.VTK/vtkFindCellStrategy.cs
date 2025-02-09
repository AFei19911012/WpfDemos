using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFindCellStrategy
/// </summary>
/// <remarks>
///    helper class to manage the vtkPointSet::FindCell() METHOD
///
/// vtkFindCellStrategy is a helper class to manage the use of locators for
/// locating cells containing a query point x[3], the so-called FindCell()
/// method. The use of vtkDataSet::FindCell() is a common operation in
/// applications such as streamline generation and probing. However, in some
/// dataset types FindCell() can be implemented very simply (e.g.,
/// vtkImageData) while in other datasets it is a complex operation requiring
/// supplemental objects like locators to perform efficiently. In particular,
/// vtkPointSet and its subclasses (like vtkUnstructuredGrid) require complex
/// strategies to efficiently implement the FindCell() operation. Subclasses
/// of the abstract vtkFindCellStrategy implement several of these strategies.
///
/// The are two key methods to this class and subclasses. The Initialize()
/// method negotiates with an input dataset to define the locator to use:
/// either a locator associated with the input dataset, or possibly an
/// alternative locator defined by the strategy (subclasses of
/// vtkFindCellStrategy do this). The second important method, FindCell()
/// mimics vtkDataSet::FindCell() and can be used in place of it.
///
/// Note that vtkFindCellStrategy is in general not thread-safe as the
/// strategies contain state used to accelerate the search process. Hence
/// if multiple threads are attempting to invoke FindCell(), each thread
/// needs to have its own instance of the vtkFindCellStrategy.
///
/// </remarks>
/// <seealso>
///
/// vtkPointSet vtkPolyData vtkStructuredGrid vtkUnstructuredGrid
/// vtkAbstractInterpolatedVelocityField vtkClosetPointStrategy
/// vtkCellLocatorStrategy vtkClosestNPointsStrategy
/// </seealso>
public abstract class vtkFindCellStrategy : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFindCellStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFindCellStrategy()
	{
		MRClassNameKey = "class vtkFindCellStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFindCellStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFindCellStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFindCellStrategy_CopyParameters_01(HandleRef pThis, HandleRef from);

	/// <summary>
	/// Copy essential parameters between instances of this class. This
	/// generally is used to copy from instance prototype to another, or to copy
	/// strategies between thread instances.  Sub-classes can contribute to
	/// the parameter copying process via chaining.
	///
	/// Note: CopyParameters should ALWAYS be called BEFORE Initialize.
	/// </summary>
	public virtual void CopyParameters(vtkFindCellStrategy from)
	{
		vtkFindCellStrategy_CopyParameters_01(GetCppThis(), from?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFindCellStrategy_FindCell_02(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Virtual method for finding a cell. Subclasses must satisfy this API.
	/// This method is of the same signature as vtkDataSet::FindCell(). This
	/// method is not thread safe: separate instances of vtkFindCellStrategy
	/// should be created for each thread invoking FindCell(). This is done for
	/// performance reasons to reduce the number of objects created/destroyed on
	/// each FindCell() invocation.
	/// </summary>
	public virtual long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkFindCellStrategy_FindCell_02(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), gencell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFindCellStrategy_FindClosestPointWithinRadius_03(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

	/// <summary>
	/// Return the closest point within a specified radius and the cell which is
	/// closest to the point x. The closest point is somewhere on a cell, it
	/// need not be one of the vertices of the cell. This method returns 1 if a
	/// point is found within the specified radius. If there are no cells within
	/// the specified radius, the method returns 0 and the values of
	/// closestPoint, cellId, subId, and dist2 are undefined. This version takes
	/// in a vtkGenericCell to avoid allocating and deallocating the cell.  This
	/// is much faster than the version which does not take a *cell, especially
	/// when this function is called many times in a row such as by a for loop,
	/// where the allocation and dealloction can be done only once outside the
	/// for loop.  If a closest point is found, "cell" contains the points and
	/// ptIds for the cell "cellId" upon exit.  If a closest point is found,
	/// inside returns the return value of the EvaluatePosition call to the
	/// closest cell; inside(=1) or outside(=0).
	/// </summary>
	public virtual long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
	{
		return vtkFindCellStrategy_FindClosestPointWithinRadius_03(GetCppThis(), x, radius, closestPoint, cell?.GetCppThis() ?? default(HandleRef), ref cellId, ref subId, ref dist2, ref inside);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFindCellStrategy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFindCellStrategy_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFindCellStrategy_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFindCellStrategy_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFindCellStrategy_Initialize_06(HandleRef pThis, HandleRef ps);

	/// <summary>
	/// All subclasses of this class must provide an initialize method.  This
	/// method performs handshaking and setup between the vtkPointSet dataset
	/// and associated locator(s). A return value==0 means the initialization
	/// process failed. The initialization is set up in such a way as to prevent
	/// multiple locators from being built.
	/// </summary>
	public virtual int Initialize(vtkPointSet ps)
	{
		return vtkFindCellStrategy_Initialize_06(GetCppThis(), ps?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFindCellStrategy_InsideCellBounds_07(HandleRef pThis, IntPtr x, long cellId);

	/// <summary>
	/// Quickly test if a point is inside the bounds of a particular cell.
	/// </summary>
	public virtual bool InsideCellBounds(IntPtr x, long cellId)
	{
		return (vtkFindCellStrategy_InsideCellBounds_07(GetCppThis(), x, cellId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFindCellStrategy_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFindCellStrategy_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFindCellStrategy_IsTypeOf_09(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFindCellStrategy_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFindCellStrategy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkFindCellStrategy NewInstance()
	{
		vtkFindCellStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFindCellStrategy_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFindCellStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFindCellStrategy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkFindCellStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkFindCellStrategy vtkFindCellStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFindCellStrategy_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFindCellStrategy2 = (vtkFindCellStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFindCellStrategy2.Register(null);
			}
		}
		return vtkFindCellStrategy2;
	}
}
