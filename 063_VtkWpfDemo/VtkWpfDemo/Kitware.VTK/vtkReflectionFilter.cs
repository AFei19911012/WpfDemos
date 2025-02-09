using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkReflectionFilter
/// </summary>
/// <remarks>
///    reflects a data set across a plane
///
/// The vtkReflectionFilter reflects a data set across one of the
/// planes formed by the data set's bounding box.
/// Since it converts data sets into unstructured grids, it is not efficient
/// for structured data sets.
/// </remarks>
public class vtkReflectionFilter : vtkDataObjectAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum ReflectionPlane
	{
		/// <summary>enum member</summary>
		USE_X = 6,
		/// <summary>enum member</summary>
		USE_X_MAX = 3,
		/// <summary>enum member</summary>
		USE_X_MIN = 0,
		/// <summary>enum member</summary>
		USE_Y = 7,
		/// <summary>enum member</summary>
		USE_Y_MAX = 4,
		/// <summary>enum member</summary>
		USE_Y_MIN = 1,
		/// <summary>enum member</summary>
		USE_Z = 8,
		/// <summary>enum member</summary>
		USE_Z_MAX = 5,
		/// <summary>enum member</summary>
		USE_Z_MIN = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkReflectionFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkReflectionFilter()
	{
		MRClassNameKey = "class vtkReflectionFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkReflectionFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkReflectionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReflectionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkReflectionFilter New()
	{
		vtkReflectionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReflectionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkReflectionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkReflectionFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkReflectionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkReflectionFilter_CopyInputOff_01(HandleRef pThis);

	/// <summary>
	/// If on (the default), copy the input geometry to the output. If off,
	/// the output will only contain the reflection.
	/// </summary>
	public virtual void CopyInputOff()
	{
		vtkReflectionFilter_CopyInputOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_CopyInputOn_02(HandleRef pThis);

	/// <summary>
	/// If on (the default), copy the input geometry to the output. If off,
	/// the output will only contain the reflection.
	/// </summary>
	public virtual void CopyInputOn()
	{
		vtkReflectionFilter_CopyInputOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_FlipAllInputArraysOff_03(HandleRef pThis);

	/// <summary>
	/// If off (the default), only Vectors, Normals and Tensors will be flipped.
	/// If on, all 3-component data arrays ( considered as 3D vectors),
	/// 6-component data arrays (considered as symmetric tensors),
	/// 9-component data arrays (considered as tensors ) of signed type will be flipped.
	/// All other won't be flipped and will only be copied.
	/// </summary>
	public virtual void FlipAllInputArraysOff()
	{
		vtkReflectionFilter_FlipAllInputArraysOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_FlipAllInputArraysOn_04(HandleRef pThis);

	/// <summary>
	/// If off (the default), only Vectors, Normals and Tensors will be flipped.
	/// If on, all 3-component data arrays ( considered as 3D vectors),
	/// 6-component data arrays (considered as symmetric tensors),
	/// 9-component data arrays (considered as tensors ) of signed type will be flipped.
	/// All other won't be flipped and will only be copied.
	/// </summary>
	public virtual void FlipAllInputArraysOn()
	{
		vtkReflectionFilter_FlipAllInputArraysOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkReflectionFilter_GetCenter_05(HandleRef pThis);

	/// <summary>
	/// If the reflection plane is set to X, Y or Z, this variable
	/// is use to set the position of the plane.
	/// </summary>
	public virtual double GetCenter()
	{
		return vtkReflectionFilter_GetCenter_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReflectionFilter_GetCopyInput_06(HandleRef pThis);

	/// <summary>
	/// If on (the default), copy the input geometry to the output. If off,
	/// the output will only contain the reflection.
	/// </summary>
	public virtual int GetCopyInput()
	{
		return vtkReflectionFilter_GetCopyInput_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkReflectionFilter_GetFlipAllInputArrays_07(HandleRef pThis);

	/// <summary>
	/// If off (the default), only Vectors, Normals and Tensors will be flipped.
	/// If on, all 3-component data arrays ( considered as 3D vectors),
	/// 6-component data arrays (considered as symmetric tensors),
	/// 9-component data arrays (considered as tensors ) of signed type will be flipped.
	/// All other won't be flipped and will only be copied.
	/// </summary>
	public virtual bool GetFlipAllInputArrays()
	{
		return (vtkReflectionFilter_GetFlipAllInputArrays_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkReflectionFilter_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkReflectionFilter_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkReflectionFilter_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkReflectionFilter_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReflectionFilter_GetPlane_10(HandleRef pThis);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public virtual int GetPlane()
	{
		return vtkReflectionFilter_GetPlane_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReflectionFilter_GetPlaneMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public virtual int GetPlaneMaxValue()
	{
		return vtkReflectionFilter_GetPlaneMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReflectionFilter_GetPlaneMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public virtual int GetPlaneMinValue()
	{
		return vtkReflectionFilter_GetPlaneMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReflectionFilter_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkReflectionFilter_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReflectionFilter_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkReflectionFilter_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReflectionFilter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkReflectionFilter NewInstance()
	{
		vtkReflectionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReflectionFilter_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkReflectionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReflectionFilter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkReflectionFilter SafeDownCast(vtkObjectBase o)
	{
		vtkReflectionFilter vtkReflectionFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReflectionFilter_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkReflectionFilter2 = (vtkReflectionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkReflectionFilter2.Register(null);
			}
		}
		return vtkReflectionFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetCenter_18(HandleRef pThis, double _arg);

	/// <summary>
	/// If the reflection plane is set to X, Y or Z, this variable
	/// is use to set the position of the plane.
	/// </summary>
	public virtual void SetCenter(double _arg)
	{
		vtkReflectionFilter_SetCenter_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetCopyInput_19(HandleRef pThis, int _arg);

	/// <summary>
	/// If on (the default), copy the input geometry to the output. If off,
	/// the output will only contain the reflection.
	/// </summary>
	public virtual void SetCopyInput(int _arg)
	{
		vtkReflectionFilter_SetCopyInput_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetFlipAllInputArrays_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// If off (the default), only Vectors, Normals and Tensors will be flipped.
	/// If on, all 3-component data arrays ( considered as 3D vectors),
	/// 6-component data arrays (considered as symmetric tensors),
	/// 9-component data arrays (considered as tensors ) of signed type will be flipped.
	/// All other won't be flipped and will only be copied.
	/// </summary>
	public virtual void SetFlipAllInputArrays(bool _arg)
	{
		vtkReflectionFilter_SetFlipAllInputArrays_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetPlane_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public virtual void SetPlane(int _arg)
	{
		vtkReflectionFilter_SetPlane_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetPlaneToX_22(HandleRef pThis);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public void SetPlaneToX()
	{
		vtkReflectionFilter_SetPlaneToX_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetPlaneToXMax_23(HandleRef pThis);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public void SetPlaneToXMax()
	{
		vtkReflectionFilter_SetPlaneToXMax_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetPlaneToXMin_24(HandleRef pThis);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public void SetPlaneToXMin()
	{
		vtkReflectionFilter_SetPlaneToXMin_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetPlaneToY_25(HandleRef pThis);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public void SetPlaneToY()
	{
		vtkReflectionFilter_SetPlaneToY_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetPlaneToYMax_26(HandleRef pThis);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public void SetPlaneToYMax()
	{
		vtkReflectionFilter_SetPlaneToYMax_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetPlaneToYMin_27(HandleRef pThis);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public void SetPlaneToYMin()
	{
		vtkReflectionFilter_SetPlaneToYMin_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetPlaneToZ_28(HandleRef pThis);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public void SetPlaneToZ()
	{
		vtkReflectionFilter_SetPlaneToZ_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetPlaneToZMax_29(HandleRef pThis);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public void SetPlaneToZMax()
	{
		vtkReflectionFilter_SetPlaneToZMax_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReflectionFilter_SetPlaneToZMin_30(HandleRef pThis);

	/// <summary>
	/// Set the normal of the plane to use as mirror.
	/// </summary>
	public void SetPlaneToZMin()
	{
		vtkReflectionFilter_SetPlaneToZMin_30(GetCppThis());
	}
}
