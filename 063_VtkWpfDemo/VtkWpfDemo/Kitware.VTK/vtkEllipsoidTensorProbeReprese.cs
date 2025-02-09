using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEllipsoidTensorProbeRepresentation
/// </summary>
/// <remarks>
///    A concrete implementation of vtkTensorProbeRepresentation that renders tensors as
/// ellipoids.
///
/// vtkEllipsoidTensorProbeRepresentation is a concrete implementation of
/// vtkTensorProbeRepresentation. It renders tensors as ellipsoids. Locations
/// between two points when probed have the tensors linearly interpolated
/// from the neighboring locations on the polyline.
///
/// </remarks>
/// <seealso>
///
/// vtkTensorProbeWidget
/// </seealso>
public class vtkEllipsoidTensorProbeRepresentation : vtkTensorProbeRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEllipsoidTensorProbeRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEllipsoidTensorProbeRepresentation()
	{
		MRClassNameKey = "class vtkEllipsoidTensorProbeRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEllipsoidTensorProbeRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEllipsoidTensorProbeRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipsoidTensorProbeRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEllipsoidTensorProbeRepresentation New()
	{
		vtkEllipsoidTensorProbeRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEllipsoidTensorProbeRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEllipsoidTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkEllipsoidTensorProbeRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEllipsoidTensorProbeRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidTensorProbeRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkEllipsoidTensorProbeRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidTensorProbeRepresentation_GetActors_02(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// See vtkProp for details.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkEllipsoidTensorProbeRepresentation_GetActors_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEllipsoidTensorProbeRepresentation_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEllipsoidTensorProbeRepresentation_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEllipsoidTensorProbeRepresentation_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEllipsoidTensorProbeRepresentation_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipsoidTensorProbeRepresentation_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEllipsoidTensorProbeRepresentation_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipsoidTensorProbeRepresentation_IsTypeOf_06(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEllipsoidTensorProbeRepresentation_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipsoidTensorProbeRepresentation_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkEllipsoidTensorProbeRepresentation NewInstance()
	{
		vtkEllipsoidTensorProbeRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEllipsoidTensorProbeRepresentation_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEllipsoidTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidTensorProbeRepresentation_RegisterPickers_09(HandleRef pThis);

	/// <summary>
	/// See vtkProp for details.
	/// </summary>
	public override void RegisterPickers()
	{
		vtkEllipsoidTensorProbeRepresentation_RegisterPickers_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidTensorProbeRepresentation_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// See vtkProp for details.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkEllipsoidTensorProbeRepresentation_ReleaseGraphicsResources_10(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipsoidTensorProbeRepresentation_RenderOpaqueGeometry_11(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkEllipsoidTensorProbeRepresentation_RenderOpaqueGeometry_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipsoidTensorProbeRepresentation_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkEllipsoidTensorProbeRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkEllipsoidTensorProbeRepresentation vtkEllipsoidTensorProbeRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEllipsoidTensorProbeRepresentation_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEllipsoidTensorProbeRepresentation2 = (vtkEllipsoidTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEllipsoidTensorProbeRepresentation2.Register(null);
			}
		}
		return vtkEllipsoidTensorProbeRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipsoidTensorProbeRepresentation_SelectProbe_13(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Can we pick the tensor glyph at the current cursor pos
	/// </summary>
	public override int SelectProbe(IntPtr pos)
	{
		return vtkEllipsoidTensorProbeRepresentation_SelectProbe_13(GetCppThis(), pos);
	}
}
