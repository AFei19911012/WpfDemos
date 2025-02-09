using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCenterOfMass
/// </summary>
/// <remarks>
///    Find the center of mass of a set of points.
///
/// vtkCenterOfMass finds the "center of mass" of a vtkPointSet (vtkPolyData
/// or vtkUnstructuredGrid). Optionally, the user can specify to use the scalars
/// as weights in the computation. If this option, UseScalarsAsWeights, is off,
/// each point contributes equally in the calculation.
///
/// You must ensure Update() has been called before GetCenter will produce a valid
/// value.
/// </remarks>
public class vtkCenterOfMass : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCenterOfMass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCenterOfMass()
	{
		MRClassNameKey = "class vtkCenterOfMass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCenterOfMass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCenterOfMass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCenterOfMass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCenterOfMass New()
	{
		vtkCenterOfMass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCenterOfMass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCenterOfMass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCenterOfMass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCenterOfMass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCenterOfMass_ComputeCenterOfMass_01(HandleRef input, HandleRef scalars, IntPtr center);

	/// <summary>
	/// This function is called by RequestData. It exists so that
	/// other classes may use this computation without constructing
	/// a vtkCenterOfMass object.  The scalars can be set to nullptr
	/// if all points are to be weighted equally.  If scalars are
	/// used, it is the caller's responsibility to ensure that the
	/// number of scalars matches the number of points, and that
	/// the sum of the scalars is a positive value.
	/// </summary>
	public static void ComputeCenterOfMass(vtkPoints input, vtkDataArray scalars, IntPtr center)
	{
		vtkCenterOfMass_ComputeCenterOfMass_01(input?.GetCppThis() ?? default(HandleRef), scalars?.GetCppThis() ?? default(HandleRef), center);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCenterOfMass_GetCenter_02(HandleRef pThis);

	/// <summary>
	/// Get the output of the center of mass computation.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkCenterOfMass_GetCenter_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCenterOfMass_GetCenter_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the output of the center of mass computation.
	/// </summary>
	public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCenterOfMass_GetCenter_03(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCenterOfMass_GetCenter_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the output of the center of mass computation.
	/// </summary>
	public virtual void GetCenter(IntPtr _arg)
	{
		vtkCenterOfMass_GetCenter_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCenterOfMass_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCenterOfMass_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCenterOfMass_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCenterOfMass_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCenterOfMass_GetUseScalarsAsWeights_07(HandleRef pThis);

	/// <summary>
	/// Set a flag to determine if the points are weighted.
	/// </summary>
	public virtual bool GetUseScalarsAsWeights()
	{
		return (vtkCenterOfMass_GetUseScalarsAsWeights_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCenterOfMass_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCenterOfMass_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCenterOfMass_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCenterOfMass_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCenterOfMass_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCenterOfMass NewInstance()
	{
		vtkCenterOfMass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCenterOfMass_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCenterOfMass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCenterOfMass_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCenterOfMass SafeDownCast(vtkObjectBase o)
	{
		vtkCenterOfMass vtkCenterOfMass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCenterOfMass_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCenterOfMass2 = (vtkCenterOfMass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCenterOfMass2.Register(null);
			}
		}
		return vtkCenterOfMass2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCenterOfMass_SetCenter_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Get the output of the center of mass computation.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkCenterOfMass_SetCenter_13(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCenterOfMass_SetCenter_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the output of the center of mass computation.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkCenterOfMass_SetCenter_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCenterOfMass_SetUseScalarsAsWeights_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set a flag to determine if the points are weighted.
	/// </summary>
	public virtual void SetUseScalarsAsWeights(bool _arg)
	{
		vtkCenterOfMass_SetUseScalarsAsWeights_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
