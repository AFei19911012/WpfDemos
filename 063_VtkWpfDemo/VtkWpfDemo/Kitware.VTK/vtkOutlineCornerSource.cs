using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOutlineCornerSource
/// </summary>
/// <remarks>
///    create wireframe outline corners around bounding box
///
/// vtkOutlineCornerSource creates wireframe outline corners around a user-specified
/// bounding box.
/// </remarks>
public class vtkOutlineCornerSource : vtkOutlineSource
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOutlineCornerSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOutlineCornerSource()
	{
		MRClassNameKey = "class vtkOutlineCornerSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutlineCornerSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOutlineCornerSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutlineCornerSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct outline corner source with default corner factor = 0.2
	/// </summary>
	public new static vtkOutlineCornerSource New()
	{
		vtkOutlineCornerSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutlineCornerSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOutlineCornerSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct outline corner source with default corner factor = 0.2
	/// </summary>
	public vtkOutlineCornerSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOutlineCornerSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkOutlineCornerSource_GetCornerFactor_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the relative size of the corners
	/// to the length of the corresponding bounds
	/// </summary>
	public virtual double GetCornerFactor()
	{
		return vtkOutlineCornerSource_GetCornerFactor_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkOutlineCornerSource_GetCornerFactorMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the relative size of the corners
	/// to the length of the corresponding bounds
	/// </summary>
	public virtual double GetCornerFactorMaxValue()
	{
		return vtkOutlineCornerSource_GetCornerFactorMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkOutlineCornerSource_GetCornerFactorMinValue_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the relative size of the corners
	/// to the length of the corresponding bounds
	/// </summary>
	public virtual double GetCornerFactorMinValue()
	{
		return vtkOutlineCornerSource_GetCornerFactorMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOutlineCornerSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOutlineCornerSource_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOutlineCornerSource_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOutlineCornerSource_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutlineCornerSource_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOutlineCornerSource_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutlineCornerSource_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOutlineCornerSource_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutlineCornerSource_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOutlineCornerSource NewInstance()
	{
		vtkOutlineCornerSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutlineCornerSource_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOutlineCornerSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutlineCornerSource_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOutlineCornerSource SafeDownCast(vtkObjectBase o)
	{
		vtkOutlineCornerSource vtkOutlineCornerSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutlineCornerSource_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOutlineCornerSource2 = (vtkOutlineCornerSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOutlineCornerSource2.Register(null);
			}
		}
		return vtkOutlineCornerSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineCornerSource_SetCornerFactor_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the factor that controls the relative size of the corners
	/// to the length of the corresponding bounds
	/// </summary>
	public virtual void SetCornerFactor(double _arg)
	{
		vtkOutlineCornerSource_SetCornerFactor_11(GetCppThis(), _arg);
	}
}
