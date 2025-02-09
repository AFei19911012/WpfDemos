using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWarpVector
/// </summary>
/// <remarks>
///    deform geometry with vector data
///
/// vtkWarpVector is a filter that modifies point coordinates by moving
/// points along vector times the scale factor. Useful for showing flow
/// profiles or mechanical deformation.
///
/// The filter passes both its point data and cell data to its output.
/// </remarks>
public class vtkWarpVector : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWarpVector";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWarpVector()
	{
		MRClassNameKey = "class vtkWarpVector";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpVector"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWarpVector(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpVector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public new static vtkWarpVector New()
	{
		vtkWarpVector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpVector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWarpVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public vtkWarpVector()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWarpVector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkWarpVector_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Set/get the desired precision for the output points type. By default
	/// (DEFAULT_PRECISION) the output type is the same as the input points
	/// type. Otherwise, specify the precision as SINGLE_PRECISION or
	/// DOUBLE_PRECISION.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkWarpVector_FillInputPortInformation_01(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWarpVector_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWarpVector_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWarpVector_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWarpVector_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpVector_GetOutputPointsPrecision_04(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points type. By default
	/// (DEFAULT_PRECISION) the output type is the same as the input points
	/// type. Otherwise, specify the precision as SINGLE_PRECISION or
	/// DOUBLE_PRECISION.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkWarpVector_GetOutputPointsPrecision_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWarpVector_GetScaleFactor_05(HandleRef pThis);

	/// <summary>
	/// Specify value to scale displacement.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkWarpVector_GetScaleFactor_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpVector_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWarpVector_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpVector_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWarpVector_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpVector_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public new vtkWarpVector NewInstance()
	{
		vtkWarpVector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpVector_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWarpVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpVector_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public new static vtkWarpVector SafeDownCast(vtkObjectBase o)
	{
		vtkWarpVector vtkWarpVector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpVector_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWarpVector2 = (vtkWarpVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWarpVector2.Register(null);
			}
		}
		return vtkWarpVector2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpVector_SetOutputPointsPrecision_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points type. By default
	/// (DEFAULT_PRECISION) the output type is the same as the input points
	/// type. Otherwise, specify the precision as SINGLE_PRECISION or
	/// DOUBLE_PRECISION.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkWarpVector_SetOutputPointsPrecision_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpVector_SetScaleFactor_12(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify value to scale displacement.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkWarpVector_SetScaleFactor_12(GetCppThis(), _arg);
	}
}
