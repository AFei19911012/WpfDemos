using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointPicker
/// </summary>
/// <remarks>
///    select a point by shooting a ray into a graphics window
///
///
/// vtkPointPicker is used to select a point by shooting a ray into a graphics
/// window and intersecting with actor's defining geometry - specifically its
/// points. Beside returning coordinates, actor, and mapper, vtkPointPicker
/// returns the id of the point projecting closest onto the ray (within the
/// specified tolerance).  Ties are broken (i.e., multiple points all
/// projecting within the tolerance along the pick ray) by choosing the point
/// closest to the ray origin (i.e., closest to the eye).
///
///
/// </remarks>
/// <seealso>
///
/// vtkPicker vtkCellPicker
/// </seealso>
public class vtkPointPicker : vtkPicker
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointPicker";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointPicker()
	{
		MRClassNameKey = "class vtkPointPicker";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointPicker"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkPointPicker New()
	{
		vtkPointPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkPointPicker()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointPicker_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointPicker_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointPicker_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointPicker_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointPicker_GetPointId_03(HandleRef pThis);

	/// <summary>
	/// Get the id of the picked point. If PointId = -1, nothing was picked.
	/// </summary>
	public virtual long GetPointId()
	{
		return vtkPointPicker_GetPointId_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPicker_GetUseCells_04(HandleRef pThis);

	/// <summary>
	/// Specify whether the point search should be based on cell points or
	/// directly on the point list.
	/// </summary>
	public virtual int GetUseCells()
	{
		return vtkPointPicker_GetUseCells_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPicker_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointPicker_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPicker_IsTypeOf_06(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointPicker_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointPicker_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkPointPicker NewInstance()
	{
		vtkPointPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointPicker_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointPicker_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkPointPicker SafeDownCast(vtkObjectBase o)
	{
		vtkPointPicker vtkPointPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointPicker_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointPicker2 = (vtkPointPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointPicker2.Register(null);
			}
		}
		return vtkPointPicker2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointPicker_SetUseCells_10(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether the point search should be based on cell points or
	/// directly on the point list.
	/// </summary>
	public virtual void SetUseCells(int _arg)
	{
		vtkPointPicker_SetUseCells_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointPicker_UseCellsOff_11(HandleRef pThis);

	/// <summary>
	/// Specify whether the point search should be based on cell points or
	/// directly on the point list.
	/// </summary>
	public virtual void UseCellsOff()
	{
		vtkPointPicker_UseCellsOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointPicker_UseCellsOn_12(HandleRef pThis);

	/// <summary>
	/// Specify whether the point search should be based on cell points or
	/// directly on the point list.
	/// </summary>
	public virtual void UseCellsOn()
	{
		vtkPointPicker_UseCellsOn_12(GetCppThis());
	}
}
