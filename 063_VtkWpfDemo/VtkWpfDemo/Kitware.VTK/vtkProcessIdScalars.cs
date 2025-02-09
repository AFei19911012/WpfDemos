using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProcessIdScalars
/// </summary>
/// <remarks>
///    Sets cell or point scalars to the processor rank.
///
///
/// vtkProcessIdScalars is meant to display which processor owns which cells
/// and points.  It is useful for visualizing the partitioning for
/// streaming or distributed pipelines.
///
/// </remarks>
/// <seealso>
///
/// vtkPolyDataStreamer
/// </seealso>
public class vtkProcessIdScalars : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProcessIdScalars";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProcessIdScalars()
	{
		MRClassNameKey = "class vtkProcessIdScalars";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProcessIdScalars"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProcessIdScalars(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcessIdScalars_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProcessIdScalars New()
	{
		vtkProcessIdScalars result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcessIdScalars_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProcessIdScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProcessIdScalars()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProcessIdScalars_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcessIdScalars_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// By default this filter uses the global controller,
	/// but this method can be used to set another instead.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcessIdScalars_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProcessIdScalars_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProcessIdScalars_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProcessIdScalars_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProcessIdScalars_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcessIdScalars_GetRandomMode_04(HandleRef pThis);

	/// <summary>
	/// This option uses a random mapping between pieces and scalar values.
	/// The scalar values are chosen between 0 and 1.  By default, random
	/// mode is off.
	/// </summary>
	public virtual int GetRandomMode()
	{
		return vtkProcessIdScalars_GetRandomMode_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcessIdScalars_GetScalarMode_05(HandleRef pThis);

	/// <summary>
	/// Option to centerate cell scalars of points scalars.  Default is point
	/// scalars (0).
	/// </summary>
	public int GetScalarMode()
	{
		return vtkProcessIdScalars_GetScalarMode_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcessIdScalars_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProcessIdScalars_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcessIdScalars_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProcessIdScalars_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcessIdScalars_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProcessIdScalars NewInstance()
	{
		vtkProcessIdScalars result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcessIdScalars_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProcessIdScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcessIdScalars_RandomModeOff_10(HandleRef pThis);

	/// <summary>
	/// This option uses a random mapping between pieces and scalar values.
	/// The scalar values are chosen between 0 and 1.  By default, random
	/// mode is off.
	/// </summary>
	public virtual void RandomModeOff()
	{
		vtkProcessIdScalars_RandomModeOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcessIdScalars_RandomModeOn_11(HandleRef pThis);

	/// <summary>
	/// This option uses a random mapping between pieces and scalar values.
	/// The scalar values are chosen between 0 and 1.  By default, random
	/// mode is off.
	/// </summary>
	public virtual void RandomModeOn()
	{
		vtkProcessIdScalars_RandomModeOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcessIdScalars_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProcessIdScalars SafeDownCast(vtkObjectBase o)
	{
		vtkProcessIdScalars vtkProcessIdScalars2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcessIdScalars_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProcessIdScalars2 = (vtkProcessIdScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProcessIdScalars2.Register(null);
			}
		}
		return vtkProcessIdScalars2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcessIdScalars_SetCellScalarsFlag_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Option to centerate cell scalars of points scalars.  Default is point
	/// scalars (0).
	/// </summary>
	public virtual void SetCellScalarsFlag(int _arg)
	{
		vtkProcessIdScalars_SetCellScalarsFlag_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcessIdScalars_SetController_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// By default this filter uses the global controller,
	/// but this method can be used to set another instead.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkProcessIdScalars_SetController_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcessIdScalars_SetRandomMode_15(HandleRef pThis, int _arg);

	/// <summary>
	/// This option uses a random mapping between pieces and scalar values.
	/// The scalar values are chosen between 0 and 1.  By default, random
	/// mode is off.
	/// </summary>
	public virtual void SetRandomMode(int _arg)
	{
		vtkProcessIdScalars_SetRandomMode_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcessIdScalars_SetScalarModeToCellData_16(HandleRef pThis);

	/// <summary>
	/// Option to centerate cell scalars of points scalars.  Default is point
	/// scalars (0).
	/// </summary>
	public void SetScalarModeToCellData()
	{
		vtkProcessIdScalars_SetScalarModeToCellData_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcessIdScalars_SetScalarModeToPointData_17(HandleRef pThis);

	/// <summary>
	/// Option to centerate cell scalars of points scalars.  Default is point
	/// scalars (0).
	/// </summary>
	public void SetScalarModeToPointData()
	{
		vtkProcessIdScalars_SetScalarModeToPointData_17(GetCppThis());
	}
}
