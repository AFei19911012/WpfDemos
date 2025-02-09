using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVisibilitySort
/// </summary>
/// <remarks>
///    Abstract class that can sort cell data along a viewpoint.
///
///
/// vtkVisibilitySort encapsulates a method for depth sorting the cells of a
/// vtkDataSet for a given viewpoint.  It should be noted that subclasses
/// are not required to give an absolutely correct sorting.  Many types of
/// unstructured grids may have sorting cycles, meaning that there is no
/// possible correct sorting.  Some subclasses also only give an approximate
/// sorting in the interest of speed.
///
/// @attention
/// The Input field of this class tends to causes reference cycles.  To help
/// break these cycles, garbage collection is enabled on this object and the
/// input parameter is traced.  For this to work, though, an object in the
/// loop holding the visibility sort should also report that to the garbage
/// collector.
///
/// </remarks>
public abstract class vtkVisibilitySort : vtkObject
{
	/// <summary>
	/// Set/Get the sorting direction.  Be default, the direction is set
	/// to back to front.
	/// </summary>
	public enum BACK_TO_FRONT_WrapperEnum
	{
		/// <summary>enum member</summary>
		BACK_TO_FRONT,
		/// <summary>enum member</summary>
		FRONT_TO_BACK
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVisibilitySort";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVisibilitySort()
	{
		MRClassNameKey = "class vtkVisibilitySort";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVisibilitySort"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVisibilitySort(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVisibilitySort_GetCamera_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the camera that specifies the viewing parameters.
	/// </summary>
	public virtual vtkCamera GetCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVisibilitySort_GetCamera_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCamera2 = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCamera2.Register(null);
			}
		}
		return vtkCamera2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVisibilitySort_GetDirection_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the sorting direction.  Be default, the direction is set
	/// to back to front.
	/// </summary>
	public virtual int GetDirection()
	{
		return vtkVisibilitySort_GetDirection_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVisibilitySort_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the data set containing the cells to sort.
	/// </summary>
	public virtual vtkDataSet GetInput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVisibilitySort_GetInput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVisibilitySort_GetInverseModelTransform_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the matrix that transforms from object space to world space.
	/// Generally, you get this matrix from a call to GetMatrix of a vtkProp3D
	/// (vtkActor).
	/// </summary>
	public virtual vtkMatrix4x4 GetInverseModelTransform()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVisibilitySort_GetInverseModelTransform_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVisibilitySort_GetMaxCellsReturned_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of cells that GetNextCells will return
	/// in one invocation.
	/// </summary>
	public virtual int GetMaxCellsReturned()
	{
		return vtkVisibilitySort_GetMaxCellsReturned_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVisibilitySort_GetMaxCellsReturnedMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of cells that GetNextCells will return
	/// in one invocation.
	/// </summary>
	public virtual int GetMaxCellsReturnedMaxValue()
	{
		return vtkVisibilitySort_GetMaxCellsReturnedMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVisibilitySort_GetMaxCellsReturnedMinValue_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of cells that GetNextCells will return
	/// in one invocation.
	/// </summary>
	public virtual int GetMaxCellsReturnedMinValue()
	{
		return vtkVisibilitySort_GetMaxCellsReturnedMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVisibilitySort_GetModelTransform_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the matrix that transforms from object space to world space.
	/// Generally, you get this matrix from a call to GetMatrix of a vtkProp3D
	/// (vtkActor).
	/// </summary>
	public virtual vtkMatrix4x4 GetModelTransform()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVisibilitySort_GetModelTransform_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVisibilitySort_GetNextCells_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// To facilitate incremental sorting algorithms, the cells are retrieved
	/// in an iteration process.  That is, call InitTraversal to start the
	/// iteration and call GetNextCells to get the cell IDs in order.
	/// However, for efficiencies sake, GetNextCells returns an ordered list
	/// of several id's in once call (but not necessarily all).  GetNextCells
	/// will return NULL once the entire sorted list is output.  The
	/// vtkIdTypeArray returned from GetNextCells is a cached array, so do not
	/// delete it.  At the same note, do not expect the array to be valid
	/// after subsequent calls to GetNextCells.
	/// </summary>
	public virtual vtkIdTypeArray GetNextCells()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVisibilitySort_GetNextCells_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVisibilitySort_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVisibilitySort_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVisibilitySort_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVisibilitySort_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVisibilitySort_InitTraversal_12(HandleRef pThis);

	/// <summary>
	/// To facilitate incremental sorting algorithms, the cells are retrieved
	/// in an iteration process.  That is, call InitTraversal to start the
	/// iteration and call GetNextCells to get the cell IDs in order.
	/// However, for efficiencies sake, GetNextCells returns an ordered list
	/// of several id's in once call (but not necessarily all).  GetNextCells
	/// will return NULL once the entire sorted list is output.  The
	/// vtkIdTypeArray returned from GetNextCells is a cached array, so do not
	/// delete it.  At the same note, do not expect the array to be valid
	/// after subsequent calls to GetNextCells.
	/// </summary>
	public virtual void InitTraversal()
	{
		vtkVisibilitySort_InitTraversal_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVisibilitySort_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVisibilitySort_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVisibilitySort_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVisibilitySort_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVisibilitySort_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVisibilitySort NewInstance()
	{
		vtkVisibilitySort result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVisibilitySort_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVisibilitySort)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVisibilitySort_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVisibilitySort SafeDownCast(vtkObjectBase o)
	{
		vtkVisibilitySort vtkVisibilitySort2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVisibilitySort_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVisibilitySort2 = (vtkVisibilitySort)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVisibilitySort2.Register(null);
			}
		}
		return vtkVisibilitySort2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVisibilitySort_SetCamera_17(HandleRef pThis, HandleRef camera);

	/// <summary>
	/// Set/Get the camera that specifies the viewing parameters.
	/// </summary>
	public virtual void SetCamera(vtkCamera camera)
	{
		vtkVisibilitySort_SetCamera_17(GetCppThis(), camera?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVisibilitySort_SetDirection_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the sorting direction.  Be default, the direction is set
	/// to back to front.
	/// </summary>
	public virtual void SetDirection(int _arg)
	{
		vtkVisibilitySort_SetDirection_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVisibilitySort_SetDirectionToBackToFront_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the sorting direction.  Be default, the direction is set
	/// to back to front.
	/// </summary>
	public void SetDirectionToBackToFront()
	{
		vtkVisibilitySort_SetDirectionToBackToFront_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVisibilitySort_SetDirectionToFrontToBack_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the sorting direction.  Be default, the direction is set
	/// to back to front.
	/// </summary>
	public void SetDirectionToFrontToBack()
	{
		vtkVisibilitySort_SetDirectionToFrontToBack_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVisibilitySort_SetInput_21(HandleRef pThis, HandleRef data);

	/// <summary>
	/// Set/Get the data set containing the cells to sort.
	/// </summary>
	public virtual void SetInput(vtkDataSet data)
	{
		vtkVisibilitySort_SetInput_21(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVisibilitySort_SetMaxCellsReturned_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum number of cells that GetNextCells will return
	/// in one invocation.
	/// </summary>
	public virtual void SetMaxCellsReturned(int _arg)
	{
		vtkVisibilitySort_SetMaxCellsReturned_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVisibilitySort_SetModelTransform_23(HandleRef pThis, HandleRef mat);

	/// <summary>
	/// Set/Get the matrix that transforms from object space to world space.
	/// Generally, you get this matrix from a call to GetMatrix of a vtkProp3D
	/// (vtkActor).
	/// </summary>
	public virtual void SetModelTransform(vtkMatrix4x4 mat)
	{
		vtkVisibilitySort_SetModelTransform_23(GetCppThis(), mat?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVisibilitySort_UsesGarbageCollector_24(HandleRef pThis);

	/// <summary>
	/// Overwritten to enable garbage collection.
	/// </summary>
	public override bool UsesGarbageCollector()
	{
		return (vtkVisibilitySort_UsesGarbageCollector_24(GetCppThis()) != 0) ? true : false;
	}
}
