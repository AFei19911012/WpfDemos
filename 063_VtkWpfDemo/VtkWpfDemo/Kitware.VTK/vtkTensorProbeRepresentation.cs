using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTensorProbeRepresentation
/// </summary>
/// <remarks>
///    Abstract class that serves as a representation for vtkTensorProbeWidget
///
/// The class serves as an abstract geometrical representation for the
/// vtkTensorProbeWidget. It is left to the concrete implementation to render
/// the tensors as it desires. For instance,
/// vtkEllipsoidTensorProbeRepresentation renders the tensors as ellipsoids.
///
/// </remarks>
/// <seealso>
///
/// vtkTensorProbeWidget
/// </seealso>
public abstract class vtkTensorProbeRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTensorProbeRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTensorProbeRepresentation()
	{
		MRClassNameKey = "class vtkTensorProbeRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensorProbeRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTensorProbeRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern void vtkTensorProbeRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// See vtkWidgetRepresentation for details.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkTensorProbeRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorProbeRepresentation_GetActors_02(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// See vtkProp for details.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkTensorProbeRepresentation_GetActors_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTensorProbeRepresentation_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTensorProbeRepresentation_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTensorProbeRepresentation_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTensorProbeRepresentation_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTensorProbeRepresentation_GetProbeCellId_05(HandleRef pThis);

	/// <summary>
	/// Set the position of the Tensor probe.
	/// </summary>
	public virtual long GetProbeCellId()
	{
		return vtkTensorProbeRepresentation_GetProbeCellId_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorProbeRepresentation_GetProbePosition_06(HandleRef pThis);

	/// <summary>
	/// Set the position of the Tensor probe.
	/// </summary>
	public virtual double[] GetProbePosition()
	{
		IntPtr intPtr = vtkTensorProbeRepresentation_GetProbePosition_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorProbeRepresentation_GetProbePosition_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the position of the Tensor probe.
	/// </summary>
	public virtual void GetProbePosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkTensorProbeRepresentation_GetProbePosition_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorProbeRepresentation_GetProbePosition_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the position of the Tensor probe.
	/// </summary>
	public virtual void GetProbePosition(IntPtr _arg)
	{
		vtkTensorProbeRepresentation_GetProbePosition_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorProbeRepresentation_Initialize_09(HandleRef pThis);

	/// <summary>
	/// Set the probe position to a reasonable location on the trajectory.
	/// </summary>
	public void Initialize()
	{
		vtkTensorProbeRepresentation_Initialize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorProbeRepresentation_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTensorProbeRepresentation_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorProbeRepresentation_IsTypeOf_11(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTensorProbeRepresentation_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorProbeRepresentation_Move_12(HandleRef pThis, IntPtr motionVector);

	/// <summary>
	/// INTERNAL - Do not use
	/// This method is invoked by the widget during user interaction.
	/// Move probe based on the position and the motion vector.
	/// </summary>
	public virtual int Move(IntPtr motionVector)
	{
		return vtkTensorProbeRepresentation_Move_12(GetCppThis(), motionVector);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorProbeRepresentation_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkTensorProbeRepresentation NewInstance()
	{
		vtkTensorProbeRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorProbeRepresentation_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorProbeRepresentation_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// See vtkProp for details.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkTensorProbeRepresentation_ReleaseGraphicsResources_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorProbeRepresentation_RenderOpaqueGeometry_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// See vtkWidgetRepresentation for details.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkTensorProbeRepresentation_RenderOpaqueGeometry_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorProbeRepresentation_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkTensorProbeRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkTensorProbeRepresentation vtkTensorProbeRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorProbeRepresentation_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTensorProbeRepresentation2 = (vtkTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTensorProbeRepresentation2.Register(null);
			}
		}
		return vtkTensorProbeRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorProbeRepresentation_SelectProbe_17(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// This method is invoked by the widget during user interaction.
	/// Can we pick the tensor glyph at the current cursor pos
	/// </summary>
	public virtual int SelectProbe(IntPtr pos)
	{
		return vtkTensorProbeRepresentation_SelectProbe_17(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorProbeRepresentation_SetProbeCellId_18(HandleRef pThis, long _arg);

	/// <summary>
	/// Set the position of the Tensor probe.
	/// </summary>
	public virtual void SetProbeCellId(long _arg)
	{
		vtkTensorProbeRepresentation_SetProbeCellId_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorProbeRepresentation_SetProbePosition_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the position of the Tensor probe.
	/// </summary>
	public virtual void SetProbePosition(double _arg1, double _arg2, double _arg3)
	{
		vtkTensorProbeRepresentation_SetProbePosition_19(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorProbeRepresentation_SetProbePosition_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the position of the Tensor probe.
	/// </summary>
	public virtual void SetProbePosition(IntPtr _arg)
	{
		vtkTensorProbeRepresentation_SetProbePosition_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorProbeRepresentation_SetTrajectory_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the trajectory that we are trying to probe tensors on
	/// </summary>
	public virtual void SetTrajectory(vtkPolyData arg0)
	{
		vtkTensorProbeRepresentation_SetTrajectory_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
