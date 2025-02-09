using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPropPicker
/// </summary>
/// <remarks>
///    pick an actor/prop using graphics hardware
///
/// vtkPropPicker is used to pick an actor/prop given a selection
/// point (in display coordinates) and a renderer. This class uses
/// graphics hardware/rendering system to pick rapidly (as compared
/// to using ray casting as does vtkCellPicker and vtkPointPicker).
/// This class determines the actor/prop and pick position in world
/// coordinates; point and cell ids are not determined.
///
/// </remarks>
/// <seealso>
///
/// vtkPicker vtkWorldPointPicker vtkCellPicker vtkPointPicker
/// </seealso>
public class vtkPropPicker : vtkAbstractPropPicker
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPropPicker";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPropPicker()
	{
		MRClassNameKey = "class vtkPropPicker";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPropPicker"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPropPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPropPicker New()
	{
		vtkPropPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPropPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPropPicker()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPropPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPropPicker_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPropPicker_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPropPicker_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPropPicker_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropPicker_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPropPicker_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropPicker_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPropPicker_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropPicker_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPropPicker NewInstance()
	{
		vtkPropPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPropPicker_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropPicker_Pick_07(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

	/// <summary>
	/// override superclasses' Pick() method.
	/// </summary>
	public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
	{
		return vtkPropPicker_Pick_07(GetCppThis(), selectionX, selectionY, selectionZ, renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropPicker_Pick_08(HandleRef pThis, IntPtr selectionPt, HandleRef renderer);

	/// <summary>
	/// override superclasses' Pick() method.
	/// </summary>
	public new int Pick(IntPtr selectionPt, vtkRenderer renderer)
	{
		return vtkPropPicker_Pick_08(GetCppThis(), selectionPt, renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropPicker_Pick3DPoint_09(HandleRef pThis, IntPtr selectionPt, HandleRef ren);

	/// <summary>
	/// Perform pick operation with selection point provided. The
	/// selectionPt is in world coordinates.
	/// Return non-zero if something was successfully picked.
	/// </summary>
	public override int Pick3DPoint(IntPtr selectionPt, vtkRenderer ren)
	{
		return vtkPropPicker_Pick3DPoint_09(GetCppThis(), selectionPt, ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropPicker_Pick3DRay_10(HandleRef pThis, IntPtr selectionPt, IntPtr orient, HandleRef ren);

	/// <summary>
	/// Perform pick operation with selection point provided. The
	/// selectionPt is in world coordinates.
	/// Return non-zero if something was successfully picked.
	/// </summary>
	public override int Pick3DRay(IntPtr selectionPt, IntPtr orient, vtkRenderer ren)
	{
		return vtkPropPicker_Pick3DRay_10(GetCppThis(), selectionPt, orient, ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropPicker_PickProp_11(HandleRef pThis, double selectionX, double selectionY, HandleRef renderer);

	/// <summary>
	/// Perform the pick and set the PickedProp ivar. If something is picked, a
	/// 1 is returned, otherwise 0 is returned.  Use the GetViewProp() method
	/// to get the instance of vtkProp that was picked.  Props are picked from
	/// the renderers list of pickable Props.
	/// </summary>
	public int PickProp(double selectionX, double selectionY, vtkRenderer renderer)
	{
		return vtkPropPicker_PickProp_11(GetCppThis(), selectionX, selectionY, renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropPicker_PickProp_12(HandleRef pThis, double selectionX, double selectionY, HandleRef renderer, HandleRef pickfrom);

	/// <summary>
	/// Perform a pick from the user-provided list of vtkProps and not from the
	/// list of vtkProps that the render maintains.
	/// </summary>
	public int PickProp(double selectionX, double selectionY, vtkRenderer renderer, vtkPropCollection pickfrom)
	{
		return vtkPropPicker_PickProp_12(GetCppThis(), selectionX, selectionY, renderer?.GetCppThis() ?? default(HandleRef), pickfrom?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropPicker_PickProp3DPoint_13(HandleRef pThis, IntPtr pos, HandleRef renderer);

	/// <summary>
	/// Perform the pick and set the PickedProp ivar. If something is picked, a
	/// 1 is returned, otherwise 0 is returned.  Use the GetViewProp() method
	/// to get the instance of vtkProp that was picked.  Props are picked from
	/// the renderers list of pickable Props.
	/// </summary>
	public int PickProp3DPoint(IntPtr pos, vtkRenderer renderer)
	{
		return vtkPropPicker_PickProp3DPoint_13(GetCppThis(), pos, renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropPicker_PickProp3DPoint_14(HandleRef pThis, IntPtr pos, HandleRef renderer, HandleRef pickfrom);

	/// <summary>
	/// Perform a pick from the user-provided list of vtkProps and not from the
	/// list of vtkProps that the render maintains.
	/// </summary>
	public int PickProp3DPoint(IntPtr pos, vtkRenderer renderer, vtkPropCollection pickfrom)
	{
		return vtkPropPicker_PickProp3DPoint_14(GetCppThis(), pos, renderer?.GetCppThis() ?? default(HandleRef), pickfrom?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropPicker_PickProp3DRay_15(HandleRef pThis, IntPtr selectionPt, IntPtr eventWorldOrientation, HandleRef renderer, HandleRef pickfrom);

	/// <summary>
	/// Perform a pick from the user-provided list of vtkProps.
	/// </summary>
	public virtual int PickProp3DRay(IntPtr selectionPt, IntPtr eventWorldOrientation, vtkRenderer renderer, vtkPropCollection pickfrom)
	{
		return vtkPropPicker_PickProp3DRay_15(GetCppThis(), selectionPt, eventWorldOrientation, renderer?.GetCppThis() ?? default(HandleRef), pickfrom?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropPicker_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPropPicker SafeDownCast(vtkObjectBase o)
	{
		vtkPropPicker vtkPropPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPropPicker_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPropPicker2 = (vtkPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPropPicker2.Register(null);
			}
		}
		return vtkPropPicker2;
	}
}
