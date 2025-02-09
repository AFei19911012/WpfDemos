using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkQuantizePolyDataPoints
/// </summary>
/// <remarks>
///    quantizes x,y,z coordinates of points
///
/// vtkQuantizePolyDataPoints is a subclass of vtkCleanPolyData and
/// inherits the functionality of vtkCleanPolyData with the addition that
/// it quantizes the point coordinates before inserting into the point list.
/// The user should set QFactor to a positive value (0.25 by default) and all
/// {x,y,z} coordinates will be quantized to that grain size.
///
/// A tolerance of zero is expected, though positive values may be used, the
/// quantization will take place before the tolerance is applied.
///
/// @warning
/// Merging points can alter topology, including introducing non-manifold
/// forms. Handling of degenerate cells is controlled by switches in
/// vtkCleanPolyData.
///
/// @warning
/// If you wish to operate on a set of coordinates that has no cells, you must
/// add a vtkPolyVertex cell with all of the points to the PolyData
/// (or use a vtkVertexGlyphFilter) before using the vtkCleanPolyData filter.
///
/// </remarks>
/// <seealso>
///
/// vtkCleanPolyData
/// </seealso>
public class vtkQuantizePolyDataPoints : vtkCleanPolyData
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkQuantizePolyDataPoints";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkQuantizePolyDataPoints()
	{
		MRClassNameKey = "class vtkQuantizePolyDataPoints";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuantizePolyDataPoints"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkQuantizePolyDataPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuantizePolyDataPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkQuantizePolyDataPoints New()
	{
		vtkQuantizePolyDataPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuantizePolyDataPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuantizePolyDataPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkQuantizePolyDataPoints()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkQuantizePolyDataPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkQuantizePolyDataPoints_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkQuantizePolyDataPoints_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuantizePolyDataPoints_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkQuantizePolyDataPoints_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuantizePolyDataPoints_GetQFactor_03(HandleRef pThis);

	/// <summary>
	/// Specify quantization grain size. Default is 0.25
	/// </summary>
	public virtual double GetQFactor()
	{
		return vtkQuantizePolyDataPoints_GetQFactor_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuantizePolyDataPoints_GetQFactorMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Specify quantization grain size. Default is 0.25
	/// </summary>
	public virtual double GetQFactorMaxValue()
	{
		return vtkQuantizePolyDataPoints_GetQFactorMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuantizePolyDataPoints_GetQFactorMinValue_05(HandleRef pThis);

	/// <summary>
	/// Specify quantization grain size. Default is 0.25
	/// </summary>
	public virtual double GetQFactorMinValue()
	{
		return vtkQuantizePolyDataPoints_GetQFactorMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuantizePolyDataPoints_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkQuantizePolyDataPoints_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuantizePolyDataPoints_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkQuantizePolyDataPoints_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuantizePolyDataPoints_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkQuantizePolyDataPoints NewInstance()
	{
		vtkQuantizePolyDataPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuantizePolyDataPoints_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuantizePolyDataPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuantizePolyDataPoints_OperateOnBounds_10(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Perform quantization on bounds
	/// </summary>
	public override void OperateOnBounds(IntPtr arg0, IntPtr arg1)
	{
		vtkQuantizePolyDataPoints_OperateOnBounds_10(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuantizePolyDataPoints_OperateOnPoint_11(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Perform quantization on a point
	/// </summary>
	public override void OperateOnPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkQuantizePolyDataPoints_OperateOnPoint_11(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuantizePolyDataPoints_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkQuantizePolyDataPoints SafeDownCast(vtkObjectBase o)
	{
		vtkQuantizePolyDataPoints vtkQuantizePolyDataPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuantizePolyDataPoints_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkQuantizePolyDataPoints2 = (vtkQuantizePolyDataPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkQuantizePolyDataPoints2.Register(null);
			}
		}
		return vtkQuantizePolyDataPoints2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuantizePolyDataPoints_SetQFactor_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify quantization grain size. Default is 0.25
	/// </summary>
	public virtual void SetQFactor(double _arg)
	{
		vtkQuantizePolyDataPoints_SetQFactor_13(GetCppThis(), _arg);
	}
}
