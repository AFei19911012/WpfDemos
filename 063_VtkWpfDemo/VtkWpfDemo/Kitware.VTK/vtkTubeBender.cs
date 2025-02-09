using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkTubeBender
/// </summary>
/// <remarks>
///  Rounds corners on lines for better tubes
///
/// vtkTubeBender is designed to generate better tube paths for vtkTubeFilter.
///
/// For points with very sharp inflection point angles, the radius used to determine
/// where surface points are placed becomes more parallel, instead of perpendicular,
/// to the tube path. This causes the tube to become more oblong, as the
/// cross-sectional height and width become increasingly disparate.
///
/// This filter inserts new points along the tube path near acute angles to reduce
/// the amount the point normals will change from point to point. This reduces the
/// cross-sectional height and width variations from over 95% to less than 30%.
/// This gives an impression of a constant diameter tube with nice acute angle bends
/// without adding too many new points (and therefore faces).
///
///
/// @warning
/// Any vtkTubeFilters which use the output of this filter should set UseDefaultNormalOff.
///
/// If the path has a relatively large radius and several acute angles in sequence,
/// the default normal generation can cause tube segments to have a torsional rotation,
/// along the tube's length which renders as an hourglass instead of a tube. Using
/// alternate normals correctly renders these hourglass segments as tubes. This problem
/// may only appear as the radius increases for a given path.
///
/// </remarks>
/// <seealso>
///
/// vtkTubeFilter
/// </seealso>
public class vtkTubeBender : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTubeBender";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTubeBender()
	{
		MRClassNameKey = "class vtkTubeBender";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTubeBender"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTubeBender(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTubeBender_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTubeBender New()
	{
		vtkTubeBender result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTubeBender_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTubeBender)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTubeBender()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTubeBender_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkTubeBender_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTubeBender_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTubeBender_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTubeBender_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTubeBender_GetRadius_03(HandleRef pThis);

	/// <summary>
	/// Set the minimum tube radius (minimum because the tube radius may vary).
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkTubeBender_GetRadius_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTubeBender_GetRadiusMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set the minimum tube radius (minimum because the tube radius may vary).
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkTubeBender_GetRadiusMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTubeBender_GetRadiusMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set the minimum tube radius (minimum because the tube radius may vary).
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkTubeBender_GetRadiusMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeBender_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTubeBender_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeBender_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTubeBender_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTubeBender_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTubeBender NewInstance()
	{
		vtkTubeBender result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTubeBender_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTubeBender)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTubeBender_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTubeBender SafeDownCast(vtkObjectBase o)
	{
		vtkTubeBender vtkTubeBender2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTubeBender_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTubeBender2 = (vtkTubeBender)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTubeBender2.Register(null);
			}
		}
		return vtkTubeBender2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeBender_SetRadius_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the minimum tube radius (minimum because the tube radius may vary).
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkTubeBender_SetRadius_11(GetCppThis(), _arg);
	}
}
