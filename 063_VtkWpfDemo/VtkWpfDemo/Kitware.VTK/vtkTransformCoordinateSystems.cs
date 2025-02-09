using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTransformCoordinateSystems
/// </summary>
/// <remarks>
///    transform points into different coordinate systems
///
/// This filter transforms points from one coordinate system to another. The user
/// must specify the coordinate systems in which the input and output are
/// specified. The user must also specify the VTK viewport (i.e., renderer) in
/// which the transformation occurs.
///
/// </remarks>
/// <seealso>
///
/// vtkCoordinate vtkTransformFilter vtkTransformPolyData vtkPolyDataMapper2D
/// </seealso>
public class vtkTransformCoordinateSystems : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTransformCoordinateSystems";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTransformCoordinateSystems()
	{
		MRClassNameKey = "class vtkTransformCoordinateSystems";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformCoordinateSystems"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTransformCoordinateSystems(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformCoordinateSystems_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class. By default no transformation is specified and
	/// the input and output is identical.
	/// </summary>
	public new static vtkTransformCoordinateSystems New()
	{
		vtkTransformCoordinateSystems result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformCoordinateSystems_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransformCoordinateSystems)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class. By default no transformation is specified and
	/// the input and output is identical.
	/// </summary>
	public vtkTransformCoordinateSystems()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTransformCoordinateSystems_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTransformCoordinateSystems_GetInputCoordinateSystem_01(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system in which the input is specified.
	/// The current options are World, Viewport, and Display. By default the
	/// input coordinate system is World.
	/// </summary>
	public virtual int GetInputCoordinateSystem()
	{
		return vtkTransformCoordinateSystems_GetInputCoordinateSystem_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTransformCoordinateSystems_GetMTime_02(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the instance of vtkCoordinate.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkTransformCoordinateSystems_GetMTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransformCoordinateSystems_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTransformCoordinateSystems_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransformCoordinateSystems_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTransformCoordinateSystems_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformCoordinateSystems_GetOutputCoordinateSystem_05(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system to which to transform the output.
	/// The current options are World, Viewport, and Display. By default the
	/// output coordinate system is Display.
	/// </summary>
	public virtual int GetOutputCoordinateSystem()
	{
		return vtkTransformCoordinateSystems_GetOutputCoordinateSystem_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformCoordinateSystems_GetViewport_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// In order for a successful coordinate transformation to occur, an
	/// instance of vtkViewport (e.g., a VTK renderer) must be specified.
	/// NOTE: this is a raw pointer, not a weak pointer nor a reference counted
	/// object, to avoid reference cycle loop between rendering classes and filter
	/// classes.
	/// </summary>
	public virtual vtkViewport GetViewport()
	{
		vtkViewport vtkViewport2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformCoordinateSystems_GetViewport_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewport2 = (vtkViewport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewport2.Register(null);
			}
		}
		return vtkViewport2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformCoordinateSystems_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTransformCoordinateSystems_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformCoordinateSystems_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTransformCoordinateSystems_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformCoordinateSystems_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkTransformCoordinateSystems NewInstance()
	{
		vtkTransformCoordinateSystems result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformCoordinateSystems_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransformCoordinateSystems)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformCoordinateSystems_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkTransformCoordinateSystems SafeDownCast(vtkObjectBase o)
	{
		vtkTransformCoordinateSystems vtkTransformCoordinateSystems2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformCoordinateSystems_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransformCoordinateSystems2 = (vtkTransformCoordinateSystems)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransformCoordinateSystems2.Register(null);
			}
		}
		return vtkTransformCoordinateSystems2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformCoordinateSystems_SetInputCoordinateSystem_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the coordinate system in which the input is specified.
	/// The current options are World, Viewport, and Display. By default the
	/// input coordinate system is World.
	/// </summary>
	public virtual void SetInputCoordinateSystem(int _arg)
	{
		vtkTransformCoordinateSystems_SetInputCoordinateSystem_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformCoordinateSystems_SetInputCoordinateSystemToDisplay_13(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system in which the input is specified.
	/// The current options are World, Viewport, and Display. By default the
	/// input coordinate system is World.
	/// </summary>
	public void SetInputCoordinateSystemToDisplay()
	{
		vtkTransformCoordinateSystems_SetInputCoordinateSystemToDisplay_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformCoordinateSystems_SetInputCoordinateSystemToViewport_14(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system in which the input is specified.
	/// The current options are World, Viewport, and Display. By default the
	/// input coordinate system is World.
	/// </summary>
	public void SetInputCoordinateSystemToViewport()
	{
		vtkTransformCoordinateSystems_SetInputCoordinateSystemToViewport_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformCoordinateSystems_SetInputCoordinateSystemToWorld_15(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system in which the input is specified.
	/// The current options are World, Viewport, and Display. By default the
	/// input coordinate system is World.
	/// </summary>
	public void SetInputCoordinateSystemToWorld()
	{
		vtkTransformCoordinateSystems_SetInputCoordinateSystemToWorld_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformCoordinateSystems_SetOutputCoordinateSystem_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the coordinate system to which to transform the output.
	/// The current options are World, Viewport, and Display. By default the
	/// output coordinate system is Display.
	/// </summary>
	public virtual void SetOutputCoordinateSystem(int _arg)
	{
		vtkTransformCoordinateSystems_SetOutputCoordinateSystem_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformCoordinateSystems_SetOutputCoordinateSystemToDisplay_17(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system to which to transform the output.
	/// The current options are World, Viewport, and Display. By default the
	/// output coordinate system is Display.
	/// </summary>
	public void SetOutputCoordinateSystemToDisplay()
	{
		vtkTransformCoordinateSystems_SetOutputCoordinateSystemToDisplay_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformCoordinateSystems_SetOutputCoordinateSystemToViewport_18(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system to which to transform the output.
	/// The current options are World, Viewport, and Display. By default the
	/// output coordinate system is Display.
	/// </summary>
	public void SetOutputCoordinateSystemToViewport()
	{
		vtkTransformCoordinateSystems_SetOutputCoordinateSystemToViewport_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformCoordinateSystems_SetOutputCoordinateSystemToWorld_19(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system to which to transform the output.
	/// The current options are World, Viewport, and Display. By default the
	/// output coordinate system is Display.
	/// </summary>
	public void SetOutputCoordinateSystemToWorld()
	{
		vtkTransformCoordinateSystems_SetOutputCoordinateSystemToWorld_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformCoordinateSystems_SetViewport_20(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// In order for a successful coordinate transformation to occur, an
	/// instance of vtkViewport (e.g., a VTK renderer) must be specified.
	/// NOTE: this is a raw pointer, not a weak pointer nor a reference counted
	/// object, to avoid reference cycle loop between rendering classes and filter
	/// classes.
	/// </summary>
	public void SetViewport(vtkViewport viewport)
	{
		vtkTransformCoordinateSystems_SetViewport_20(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}
}
