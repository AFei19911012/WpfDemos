using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTreeOrbitLayoutStrategy
/// </summary>
/// <remarks>
///    hierarchical orbital layout
///
///
/// Assigns points to the nodes of a tree to an orbital layout. Each parent
/// is orbited by its children, recursively.
///
/// @par Thanks:
/// Thanks to the galaxy for inspiring this layout strategy.
/// </remarks>
public class vtkTreeOrbitLayoutStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTreeOrbitLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTreeOrbitLayoutStrategy()
	{
		MRClassNameKey = "class vtkTreeOrbitLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeOrbitLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTreeOrbitLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeOrbitLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeOrbitLayoutStrategy New()
	{
		vtkTreeOrbitLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeOrbitLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeOrbitLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTreeOrbitLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTreeOrbitLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeOrbitLayoutStrategy_GetChildRadiusFactor_01(HandleRef pThis);

	/// <summary>
	/// This is a magic number right now. Controls the radius
	/// of the child layout, all of this should be fixed at
	/// some point with a more logical layout. Defaults to .5 :)
	/// </summary>
	public virtual double GetChildRadiusFactor()
	{
		return vtkTreeOrbitLayoutStrategy_GetChildRadiusFactor_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeOrbitLayoutStrategy_GetLeafSpacing_02(HandleRef pThis);

	/// <summary>
	/// The spacing of leaves.  Levels near one evenly space leaves
	/// with no gaps between subtrees.  Levels near zero creates
	/// large gaps between subtrees.
	/// </summary>
	public virtual double GetLeafSpacing()
	{
		return vtkTreeOrbitLayoutStrategy_GetLeafSpacing_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeOrbitLayoutStrategy_GetLeafSpacingMaxValue_03(HandleRef pThis);

	/// <summary>
	/// The spacing of leaves.  Levels near one evenly space leaves
	/// with no gaps between subtrees.  Levels near zero creates
	/// large gaps between subtrees.
	/// </summary>
	public virtual double GetLeafSpacingMaxValue()
	{
		return vtkTreeOrbitLayoutStrategy_GetLeafSpacingMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeOrbitLayoutStrategy_GetLeafSpacingMinValue_04(HandleRef pThis);

	/// <summary>
	/// The spacing of leaves.  Levels near one evenly space leaves
	/// with no gaps between subtrees.  Levels near zero creates
	/// large gaps between subtrees.
	/// </summary>
	public virtual double GetLeafSpacingMinValue()
	{
		return vtkTreeOrbitLayoutStrategy_GetLeafSpacingMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeOrbitLayoutStrategy_GetLogSpacingValue_05(HandleRef pThis);

	/// <summary>
	/// The spacing of orbital levels. Levels near zero give more space
	/// to levels near the root, while levels near one (the default)
	/// create evenly-spaced levels. Levels above one give more space
	/// to levels near the leaves.
	/// </summary>
	public virtual double GetLogSpacingValue()
	{
		return vtkTreeOrbitLayoutStrategy_GetLogSpacingValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeOrbitLayoutStrategy_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTreeOrbitLayoutStrategy_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeOrbitLayoutStrategy_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTreeOrbitLayoutStrategy_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeOrbitLayoutStrategy_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTreeOrbitLayoutStrategy_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeOrbitLayoutStrategy_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTreeOrbitLayoutStrategy_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeOrbitLayoutStrategy_Layout_10(HandleRef pThis);

	/// <summary>
	/// Perform the orbital layout.
	/// </summary>
	public override void Layout()
	{
		vtkTreeOrbitLayoutStrategy_Layout_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeOrbitLayoutStrategy_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTreeOrbitLayoutStrategy NewInstance()
	{
		vtkTreeOrbitLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeOrbitLayoutStrategy_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeOrbitLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeOrbitLayoutStrategy_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeOrbitLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkTreeOrbitLayoutStrategy vtkTreeOrbitLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeOrbitLayoutStrategy_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeOrbitLayoutStrategy2 = (vtkTreeOrbitLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeOrbitLayoutStrategy2.Register(null);
			}
		}
		return vtkTreeOrbitLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeOrbitLayoutStrategy_SetChildRadiusFactor_14(HandleRef pThis, double _arg);

	/// <summary>
	/// This is a magic number right now. Controls the radius
	/// of the child layout, all of this should be fixed at
	/// some point with a more logical layout. Defaults to .5 :)
	/// </summary>
	public virtual void SetChildRadiusFactor(double _arg)
	{
		vtkTreeOrbitLayoutStrategy_SetChildRadiusFactor_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeOrbitLayoutStrategy_SetLeafSpacing_15(HandleRef pThis, double _arg);

	/// <summary>
	/// The spacing of leaves.  Levels near one evenly space leaves
	/// with no gaps between subtrees.  Levels near zero creates
	/// large gaps between subtrees.
	/// </summary>
	public virtual void SetLeafSpacing(double _arg)
	{
		vtkTreeOrbitLayoutStrategy_SetLeafSpacing_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeOrbitLayoutStrategy_SetLogSpacingValue_16(HandleRef pThis, double _arg);

	/// <summary>
	/// The spacing of orbital levels. Levels near zero give more space
	/// to levels near the root, while levels near one (the default)
	/// create evenly-spaced levels. Levels above one give more space
	/// to levels near the leaves.
	/// </summary>
	public virtual void SetLogSpacingValue(double _arg)
	{
		vtkTreeOrbitLayoutStrategy_SetLogSpacingValue_16(GetCppThis(), _arg);
	}
}
