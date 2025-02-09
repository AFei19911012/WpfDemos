using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRotationFilter
/// </summary>
/// <remarks>
///    Duplicates a data set by rotation about an axis
///
/// The vtkRotationFilter duplicates a data set by rotation about one of the
/// 3 axis of the dataset's reference.
/// Since it converts data sets into unstructured grids, it is not efficient
/// for structured data sets.
///
/// @par Thanks:
/// Theophane Foggia of The Swiss National Supercomputing Centre (CSCS)
/// for creating and contributing this filter
/// </remarks>
public class vtkRotationFilter : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum RotationAxis
	{
		/// <summary>enum member</summary>
		USE_X,
		/// <summary>enum member</summary>
		USE_Y,
		/// <summary>enum member</summary>
		USE_Z
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRotationFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRotationFilter()
	{
		MRClassNameKey = "class vtkRotationFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRotationFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRotationFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRotationFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRotationFilter New()
	{
		vtkRotationFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRotationFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRotationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRotationFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRotationFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRotationFilter_CopyInputOff_01(HandleRef pThis);

	/// <summary>
	/// If on (the default), copy the input geometry to the output. If off,
	/// the output will only contain the rotation.
	/// </summary>
	public virtual void CopyInputOff()
	{
		vtkRotationFilter_CopyInputOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRotationFilter_CopyInputOn_02(HandleRef pThis);

	/// <summary>
	/// If on (the default), copy the input geometry to the output. If off,
	/// the output will only contain the rotation.
	/// </summary>
	public virtual void CopyInputOn()
	{
		vtkRotationFilter_CopyInputOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRotationFilter_GetAngle_03(HandleRef pThis);

	/// <summary>
	/// Set the rotation angle to use.
	/// </summary>
	public virtual double GetAngle()
	{
		return vtkRotationFilter_GetAngle_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRotationFilter_GetAxis_04(HandleRef pThis);

	/// <summary>
	/// Set the axis of rotation to use. It is set by default to Z.
	/// </summary>
	public virtual int GetAxis()
	{
		return vtkRotationFilter_GetAxis_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRotationFilter_GetAxisMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set the axis of rotation to use. It is set by default to Z.
	/// </summary>
	public virtual int GetAxisMaxValue()
	{
		return vtkRotationFilter_GetAxisMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRotationFilter_GetAxisMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set the axis of rotation to use. It is set by default to Z.
	/// </summary>
	public virtual int GetAxisMinValue()
	{
		return vtkRotationFilter_GetAxisMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRotationFilter_GetCenter_07(HandleRef pThis);

	/// <summary>
	/// Set the rotation center coordinates.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkRotationFilter_GetCenter_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRotationFilter_GetCenter_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the rotation center coordinates.
	/// </summary>
	public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkRotationFilter_GetCenter_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRotationFilter_GetCenter_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the rotation center coordinates.
	/// </summary>
	public virtual void GetCenter(IntPtr _arg)
	{
		vtkRotationFilter_GetCenter_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRotationFilter_GetCopyInput_10(HandleRef pThis);

	/// <summary>
	/// If on (the default), copy the input geometry to the output. If off,
	/// the output will only contain the rotation.
	/// </summary>
	public virtual int GetCopyInput()
	{
		return vtkRotationFilter_GetCopyInput_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRotationFilter_GetNumberOfCopies_11(HandleRef pThis);

	/// <summary>
	/// Set the number of copies to create. The source will be rotated N times
	/// and a new polydata copy of the original created at each angular position
	/// All copies will be appended to form a single output
	/// </summary>
	public virtual int GetNumberOfCopies()
	{
		return vtkRotationFilter_GetNumberOfCopies_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRotationFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRotationFilter_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRotationFilter_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRotationFilter_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRotationFilter_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRotationFilter_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRotationFilter_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRotationFilter_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRotationFilter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRotationFilter NewInstance()
	{
		vtkRotationFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRotationFilter_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRotationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRotationFilter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRotationFilter SafeDownCast(vtkObjectBase o)
	{
		vtkRotationFilter vtkRotationFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRotationFilter_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRotationFilter2 = (vtkRotationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRotationFilter2.Register(null);
			}
		}
		return vtkRotationFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRotationFilter_SetAngle_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the rotation angle to use.
	/// </summary>
	public virtual void SetAngle(double _arg)
	{
		vtkRotationFilter_SetAngle_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRotationFilter_SetAxis_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the axis of rotation to use. It is set by default to Z.
	/// </summary>
	public virtual void SetAxis(int _arg)
	{
		vtkRotationFilter_SetAxis_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRotationFilter_SetAxisToX_21(HandleRef pThis);

	/// <summary>
	/// Set the axis of rotation to use. It is set by default to Z.
	/// </summary>
	public void SetAxisToX()
	{
		vtkRotationFilter_SetAxisToX_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRotationFilter_SetAxisToY_22(HandleRef pThis);

	/// <summary>
	/// Set the axis of rotation to use. It is set by default to Z.
	/// </summary>
	public void SetAxisToY()
	{
		vtkRotationFilter_SetAxisToY_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRotationFilter_SetAxisToZ_23(HandleRef pThis);

	/// <summary>
	/// Set the axis of rotation to use. It is set by default to Z.
	/// </summary>
	public void SetAxisToZ()
	{
		vtkRotationFilter_SetAxisToZ_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRotationFilter_SetCenter_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the rotation center coordinates.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkRotationFilter_SetCenter_24(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRotationFilter_SetCenter_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the rotation center coordinates.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkRotationFilter_SetCenter_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRotationFilter_SetCopyInput_26(HandleRef pThis, int _arg);

	/// <summary>
	/// If on (the default), copy the input geometry to the output. If off,
	/// the output will only contain the rotation.
	/// </summary>
	public virtual void SetCopyInput(int _arg)
	{
		vtkRotationFilter_SetCopyInput_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRotationFilter_SetNumberOfCopies_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of copies to create. The source will be rotated N times
	/// and a new polydata copy of the original created at each angular position
	/// All copies will be appended to form a single output
	/// </summary>
	public virtual void SetNumberOfCopies(int _arg)
	{
		vtkRotationFilter_SetNumberOfCopies_27(GetCppThis(), _arg);
	}
}
