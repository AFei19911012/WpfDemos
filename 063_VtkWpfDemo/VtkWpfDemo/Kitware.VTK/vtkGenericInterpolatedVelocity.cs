using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericInterpolatedVelocityField
/// </summary>
/// <remarks>
///    Interface for obtaining
/// interpolated velocity values
///
/// vtkGenericInterpolatedVelocityField acts as a continuous velocity field
/// by performing cell interpolation on the underlying vtkDataSet.
/// This is a concrete sub-class of vtkFunctionSet with
/// NumberOfIndependentVariables = 4 (x,y,z,t) and
/// NumberOfFunctions = 3 (u,v,w). Normally, every time an evaluation
/// is performed, the cell which contains the point (x,y,z) has to
/// be found by calling FindCell. This is a computationally expansive
/// operation. In certain cases, the cell search can be avoided or shortened
/// by providing a guess for the cell iterator. For example, in streamline
/// integration, the next evaluation is usually in the same or a neighbour
/// cell. For this reason, vtkGenericInterpolatedVelocityField stores the last
/// cell iterator. If caching is turned on, it uses this iterator as the
/// starting point.
///
/// @warning
/// vtkGenericInterpolatedVelocityField is not thread safe. A new instance
/// should be created by each thread.
///
/// </remarks>
/// <seealso>
///
/// vtkFunctionSet vtkGenericStreamTracer
/// </seealso>
public class vtkGenericInterpolatedVelocityField : vtkFunctionSet
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericInterpolatedVelocityField";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericInterpolatedVelocityField()
	{
		MRClassNameKey = "class vtkGenericInterpolatedVelocityField";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericInterpolatedVelocityField"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a vtkGenericInterpolatedVelocityField with no initial data set.
	/// Caching is on. LastCellId is set to -1.
	/// </summary>
	public new static vtkGenericInterpolatedVelocityField New()
	{
		vtkGenericInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a vtkGenericInterpolatedVelocityField with no initial data set.
	/// Caching is on. LastCellId is set to -1.
	/// </summary>
	public vtkGenericInterpolatedVelocityField()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGenericInterpolatedVelocityField_AddDataSet_01(HandleRef pThis, HandleRef dataset);

	/// <summary>
	/// Add a dataset used for the implicit function evaluation.
	/// If more than one dataset is added, the evaluation point is
	/// searched in all until a match is found. THIS FUNCTION
	/// DOES NOT CHANGE THE REFERENCE COUNT OF dataset FOR THREAD
	/// SAFETY REASONS.
	/// </summary>
	public virtual void AddDataSet(vtkGenericDataSet dataset)
	{
		vtkGenericInterpolatedVelocityField_AddDataSet_01(GetCppThis(), dataset?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericInterpolatedVelocityField_CachingOff_02(HandleRef pThis);

	/// <summary>
	/// Turn caching on/off.
	/// </summary>
	public virtual void CachingOff()
	{
		vtkGenericInterpolatedVelocityField_CachingOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericInterpolatedVelocityField_CachingOn_03(HandleRef pThis);

	/// <summary>
	/// Turn caching on/off.
	/// </summary>
	public virtual void CachingOn()
	{
		vtkGenericInterpolatedVelocityField_CachingOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericInterpolatedVelocityField_ClearLastCell_04(HandleRef pThis);

	/// <summary>
	/// Set the last cell id to -1 so that the next search does not
	/// start from the previous cell
	/// </summary>
	public void ClearLastCell()
	{
		vtkGenericInterpolatedVelocityField_ClearLastCell_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericInterpolatedVelocityField_CopyParameters_05(HandleRef pThis, HandleRef from);

	/// <summary>
	/// Copy the user set parameters from source. This copies
	/// the Caching parameters. Sub-classes can add more after
	/// chaining.
	/// </summary>
	public virtual void CopyParameters(vtkGenericInterpolatedVelocityField from)
	{
		vtkGenericInterpolatedVelocityField_CopyParameters_05(GetCppThis(), from?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericInterpolatedVelocityField_FunctionValues_06(HandleRef pThis, IntPtr x, IntPtr f);

	/// <summary>
	/// Evaluate the velocity field, f, at (x, y, z, t).
	/// For now, t is ignored.
	/// </summary>
	public override int FunctionValues(IntPtr x, IntPtr f)
	{
		return vtkGenericInterpolatedVelocityField_FunctionValues_06(GetCppThis(), x, f);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericInterpolatedVelocityField_GetCacheHit_07(HandleRef pThis);

	/// <summary>
	/// Caching statistics.
	/// </summary>
	public virtual int GetCacheHit()
	{
		return vtkGenericInterpolatedVelocityField_GetCacheHit_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericInterpolatedVelocityField_GetCacheMiss_08(HandleRef pThis);

	/// <summary>
	/// Caching statistics.
	/// </summary>
	public virtual int GetCacheMiss()
	{
		return vtkGenericInterpolatedVelocityField_GetCacheMiss_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericInterpolatedVelocityField_GetCaching_09(HandleRef pThis);

	/// <summary>
	/// Turn caching on/off.
	/// </summary>
	public virtual int GetCaching()
	{
		return vtkGenericInterpolatedVelocityField_GetCaching_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericInterpolatedVelocityField_GetLastCell_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the cell cached from last evaluation.
	/// </summary>
	public vtkGenericAdaptorCell GetLastCell()
	{
		vtkGenericAdaptorCell vtkGenericAdaptorCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericInterpolatedVelocityField_GetLastCell_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericAdaptorCell2 = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericAdaptorCell2.Register(null);
			}
		}
		return vtkGenericAdaptorCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericInterpolatedVelocityField_GetLastDataSet_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the last dataset that was visited. Can be used
	/// as a first guess as to where the next point will be as
	/// well as to avoid searching through all datasets to get
	/// more information about the point.
	/// </summary>
	public virtual vtkGenericDataSet GetLastDataSet()
	{
		vtkGenericDataSet vtkGenericDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericInterpolatedVelocityField_GetLastDataSet_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericDataSet2 = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericDataSet2.Register(null);
			}
		}
		return vtkGenericDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericInterpolatedVelocityField_GetLastLocalCoordinates_12(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Returns the interpolation weights cached from last evaluation
	/// if the cached cell is valid (returns 1). Otherwise, it does not
	/// change w and returns 0.
	/// </summary>
	public int GetLastLocalCoordinates(IntPtr pcoords)
	{
		return vtkGenericInterpolatedVelocityField_GetLastLocalCoordinates_12(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericInterpolatedVelocityField_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericInterpolatedVelocityField_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericInterpolatedVelocityField_GetVectorsSelection_15(HandleRef pThis);

	/// <summary>
	/// If you want to work with an arbitrary vector array, then set its name
	/// here. By default this in nullptr and the filter will use the active vector
	/// array.
	/// </summary>
	public virtual string GetVectorsSelection()
	{
		return Marshal.PtrToStringAnsi(vtkGenericInterpolatedVelocityField_GetVectorsSelection_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericInterpolatedVelocityField_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericInterpolatedVelocityField_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericInterpolatedVelocityField_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericInterpolatedVelocityField_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericInterpolatedVelocityField_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericInterpolatedVelocityField NewInstance()
	{
		vtkGenericInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericInterpolatedVelocityField_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericInterpolatedVelocityField_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
	{
		vtkGenericInterpolatedVelocityField vtkGenericInterpolatedVelocityField2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericInterpolatedVelocityField_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericInterpolatedVelocityField2 = (vtkGenericInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericInterpolatedVelocityField2.Register(null);
			}
		}
		return vtkGenericInterpolatedVelocityField2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericInterpolatedVelocityField_SelectVectors_21(HandleRef pThis, string fieldName);

	/// <summary>
	/// If you want to work with an arbitrary vector array, then set its name
	/// here. By default this in nullptr and the filter will use the active vector
	/// array.
	/// </summary>
	public void SelectVectors(string fieldName)
	{
		vtkGenericInterpolatedVelocityField_SelectVectors_21(GetCppThis(), fieldName);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericInterpolatedVelocityField_SetCaching_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn caching on/off.
	/// </summary>
	public virtual void SetCaching(int _arg)
	{
		vtkGenericInterpolatedVelocityField_SetCaching_22(GetCppThis(), _arg);
	}
}
