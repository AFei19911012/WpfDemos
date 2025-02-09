using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAreaContourSpectrumFilter
/// </summary>
/// <remarks>
///    compute an approximation of the area
/// contour signature (evolution of the area of the input surface along an arc of
/// the Reeb graph).
///
/// The filter takes a vtkPolyData as an input (port 0), along with a
/// vtkReebGraph (port 1).
/// The Reeb graph arc to consider can be specified with SetArcId() (default: 0).
/// The number of (evenly distributed) samples of the signature can be defined
/// with SetNumberOfSamples() (default value: 100).
/// The filter will first try to pull as a scalar field the vtkDataArray with Id
/// 'FieldId' of the vtkPolyData, see SetFieldId (default: 0). The filter will
/// abort if this field does not exist.
///
/// The filter outputs a vtkTable with the area contour signature
/// approximation, each sample being evenly distributed in the function span of
/// the arc.
///
/// This filter is a typical example for designing your own contour signature
/// filter (with customized metrics). It also shows typical vtkReebGraph
/// traversals.
///
/// Reference:
/// C. Bajaj, V. Pascucci, D. Schikore,
/// "The contour spectrum",
/// IEEE Visualization, 167-174, 1997.
/// </remarks>
public class vtkAreaContourSpectrumFilter : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAreaContourSpectrumFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAreaContourSpectrumFilter()
	{
		MRClassNameKey = "class vtkAreaContourSpectrumFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAreaContourSpectrumFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAreaContourSpectrumFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaContourSpectrumFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAreaContourSpectrumFilter New()
	{
		vtkAreaContourSpectrumFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaContourSpectrumFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAreaContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAreaContourSpectrumFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAreaContourSpectrumFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkAreaContourSpectrumFilter_GetArcId_01(HandleRef pThis);

	/// <summary>
	/// Set the arc Id for which the contour signature has to be computed.
	/// Default value: 0
	/// </summary>
	public virtual long GetArcId()
	{
		return vtkAreaContourSpectrumFilter_GetArcId_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAreaContourSpectrumFilter_GetFieldId_02(HandleRef pThis);

	/// <summary>
	/// Set the scalar field Id
	/// Default value: 0
	/// </summary>
	public virtual long GetFieldId()
	{
		return vtkAreaContourSpectrumFilter_GetFieldId_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAreaContourSpectrumFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAreaContourSpectrumFilter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAreaContourSpectrumFilter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAreaContourSpectrumFilter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAreaContourSpectrumFilter_GetNumberOfSamples_05(HandleRef pThis);

	/// <summary>
	/// Set the number of samples in the output signature
	/// Default value: 100
	/// </summary>
	public virtual int GetNumberOfSamples()
	{
		return vtkAreaContourSpectrumFilter_GetNumberOfSamples_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaContourSpectrumFilter_GetOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the scalar field Id
	/// Default value: 0
	/// </summary>
	public new vtkTable GetOutput()
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaContourSpectrumFilter_GetOutput_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAreaContourSpectrumFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAreaContourSpectrumFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAreaContourSpectrumFilter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAreaContourSpectrumFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaContourSpectrumFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAreaContourSpectrumFilter NewInstance()
	{
		vtkAreaContourSpectrumFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaContourSpectrumFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAreaContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaContourSpectrumFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAreaContourSpectrumFilter SafeDownCast(vtkObjectBase o)
	{
		vtkAreaContourSpectrumFilter vtkAreaContourSpectrumFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaContourSpectrumFilter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAreaContourSpectrumFilter2 = (vtkAreaContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAreaContourSpectrumFilter2.Register(null);
			}
		}
		return vtkAreaContourSpectrumFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaContourSpectrumFilter_SetArcId_12(HandleRef pThis, long _arg);

	/// <summary>
	/// Set the arc Id for which the contour signature has to be computed.
	/// Default value: 0
	/// </summary>
	public virtual void SetArcId(long _arg)
	{
		vtkAreaContourSpectrumFilter_SetArcId_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaContourSpectrumFilter_SetFieldId_13(HandleRef pThis, long _arg);

	/// <summary>
	/// Set the scalar field Id
	/// Default value: 0
	/// </summary>
	public virtual void SetFieldId(long _arg)
	{
		vtkAreaContourSpectrumFilter_SetFieldId_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaContourSpectrumFilter_SetNumberOfSamples_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of samples in the output signature
	/// Default value: 100
	/// </summary>
	public virtual void SetNumberOfSamples(int _arg)
	{
		vtkAreaContourSpectrumFilter_SetNumberOfSamples_14(GetCppThis(), _arg);
	}
}
