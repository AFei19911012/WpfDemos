using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleFlight
/// </summary>
/// <remarks>
///    provides flight motion routines
///
///
/// Left  mouse button press produces forward motion.
/// Right mouse button press produces reverse motion.
/// Moving mouse during motion steers user in desired direction.
/// Keyboard controls are:
/// Left/Right/Up/Down Arrows for steering direction
/// 'A' forward, 'Z' reverse motion
/// Ctrl Key causes sidestep instead of steering in mouse and key modes
/// Shift key is accelerator in mouse and key modes
/// Ctrl and Shift together causes Roll in mouse and key modes
///
/// By default, one "step" of motion corresponds to 1/250th of the diagonal
/// of bounding box of visible actors, '+' and '-' keys allow user to
/// increase or decrease step size.
/// </remarks>
public class vtkInteractorStyleFlight : vtkInteractorStyle
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleFlight";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleFlight()
	{
		MRClassNameKey = "class vtkInteractorStyleFlight";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleFlight"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleFlight(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleFlight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleFlight New()
	{
		vtkInteractorStyleFlight result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleFlight_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleFlight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleFlight()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleFlight_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_DisableMotionOff_01(HandleRef pThis);

	/// <summary>
	/// Disable motion (temporarily - for viewing etc)
	/// </summary>
	public virtual void DisableMotionOff()
	{
		vtkInteractorStyleFlight_DisableMotionOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_DisableMotionOn_02(HandleRef pThis);

	/// <summary>
	/// Disable motion (temporarily - for viewing etc)
	/// </summary>
	public virtual void DisableMotionOn()
	{
		vtkInteractorStyleFlight_DisableMotionOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_EndForwardFly_03(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Keyboard event bindings for flight
	/// </summary>
	public virtual void EndForwardFly()
	{
		vtkInteractorStyleFlight_EndForwardFly_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_EndReverseFly_04(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Keyboard event bindings for flight
	/// </summary>
	public virtual void EndReverseFly()
	{
		vtkInteractorStyleFlight_EndReverseFly_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_ForwardFly_05(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Keyboard event bindings for flight
	/// </summary>
	public virtual void ForwardFly()
	{
		vtkInteractorStyleFlight_ForwardFly_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInteractorStyleFlight_GetAngleAccelerationFactor_06(HandleRef pThis);

	/// <summary>
	/// Set angular acceleration when shift key is applied : default 5
	/// </summary>
	public virtual double GetAngleAccelerationFactor()
	{
		return vtkInteractorStyleFlight_GetAngleAccelerationFactor_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInteractorStyleFlight_GetAngleStepSize_07(HandleRef pThis);

	/// <summary>
	/// Set the basic angular unit for turning : default 1 degree
	/// </summary>
	public virtual double GetAngleStepSize()
	{
		return vtkInteractorStyleFlight_GetAngleStepSize_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleFlight_GetDefaultUpVector_08(HandleRef pThis);

	/// <summary>
	/// When flying, apply a restorative force to the "Up" vector.
	/// This is activated when the current 'up' is close to the actual 'up'
	/// (as defined in DefaultUpVector). This prevents excessive twisting forces
	/// when viewing from arbitrary angles, but keep the horizon level when
	/// the user is flying over terrain.
	/// </summary>
	public virtual double[] GetDefaultUpVector()
	{
		IntPtr intPtr = vtkInteractorStyleFlight_GetDefaultUpVector_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_GetDefaultUpVector_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// When flying, apply a restorative force to the "Up" vector.
	/// This is activated when the current 'up' is close to the actual 'up'
	/// (as defined in DefaultUpVector). This prevents excessive twisting forces
	/// when viewing from arbitrary angles, but keep the horizon level when
	/// the user is flying over terrain.
	/// </summary>
	public virtual void GetDefaultUpVector(IntPtr data)
	{
		vtkInteractorStyleFlight_GetDefaultUpVector_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleFlight_GetDisableMotion_10(HandleRef pThis);

	/// <summary>
	/// Disable motion (temporarily - for viewing etc)
	/// </summary>
	public virtual int GetDisableMotion()
	{
		return vtkInteractorStyleFlight_GetDisableMotion_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInteractorStyleFlight_GetMotionAccelerationFactor_11(HandleRef pThis);

	/// <summary>
	/// Set acceleration factor when shift key is applied : default 10
	/// </summary>
	public virtual double GetMotionAccelerationFactor()
	{
		return vtkInteractorStyleFlight_GetMotionAccelerationFactor_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInteractorStyleFlight_GetMotionStepSize_12(HandleRef pThis);

	/// <summary>
	/// Set the basic unit step size : by default 1/250 of bounding diagonal
	/// </summary>
	public virtual double GetMotionStepSize()
	{
		return vtkInteractorStyleFlight_GetMotionStepSize_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleFlight_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleFlight_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleFlight_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleFlight_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleFlight_GetRestoreUpVector_15(HandleRef pThis);

	/// <summary>
	/// When flying, apply a restorative force to the "Up" vector.
	/// This is activated when the current 'up' is close to the actual 'up'
	/// (as defined in DefaultUpVector). This prevents excessive twisting forces
	/// when viewing from arbitrary angles, but keep the horizon level when
	/// the user is flying over terrain.
	/// </summary>
	public virtual int GetRestoreUpVector()
	{
		return vtkInteractorStyleFlight_GetRestoreUpVector_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleFlight_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleFlight_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleFlight_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleFlight_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_JumpTo_18(HandleRef pThis, IntPtr campos, IntPtr focpos);

	/// <summary>
	/// Move the Eye/Camera to a specific location (no intermediate
	/// steps are taken
	/// </summary>
	public void JumpTo(IntPtr campos, IntPtr focpos)
	{
		vtkInteractorStyleFlight_JumpTo_18(GetCppThis(), campos, focpos);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleFlight_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleFlight NewInstance()
	{
		vtkInteractorStyleFlight result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleFlight_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleFlight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_OnChar_21(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Keyboard event bindings for flight
	/// </summary>
	public override void OnChar()
	{
		vtkInteractorStyleFlight_OnChar_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_OnKeyDown_22(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Keyboard event bindings for flight
	/// </summary>
	public override void OnKeyDown()
	{
		vtkInteractorStyleFlight_OnKeyDown_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_OnKeyUp_23(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Keyboard event bindings for flight
	/// </summary>
	public override void OnKeyUp()
	{
		vtkInteractorStyleFlight_OnKeyUp_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_OnLeftButtonDown_24(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Mouse event bindings for flight
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleFlight_OnLeftButtonDown_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_OnLeftButtonUp_25(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Mouse event bindings for flight
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleFlight_OnLeftButtonUp_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_OnMiddleButtonDown_26(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Mouse event bindings for flight
	/// </summary>
	public override void OnMiddleButtonDown()
	{
		vtkInteractorStyleFlight_OnMiddleButtonDown_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_OnMiddleButtonUp_27(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Mouse event bindings for flight
	/// </summary>
	public override void OnMiddleButtonUp()
	{
		vtkInteractorStyleFlight_OnMiddleButtonUp_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_OnMouseMove_28(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Mouse event bindings for flight
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleFlight_OnMouseMove_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_OnRightButtonDown_29(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Mouse event bindings for flight
	/// </summary>
	public override void OnRightButtonDown()
	{
		vtkInteractorStyleFlight_OnRightButtonDown_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_OnRightButtonUp_30(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Mouse event bindings for flight
	/// </summary>
	public override void OnRightButtonUp()
	{
		vtkInteractorStyleFlight_OnRightButtonUp_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_OnTimer_31(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Keyboard event bindings for flight
	/// </summary>
	public override void OnTimer()
	{
		vtkInteractorStyleFlight_OnTimer_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_RestoreUpVectorOff_32(HandleRef pThis);

	/// <summary>
	/// When flying, apply a restorative force to the "Up" vector.
	/// This is activated when the current 'up' is close to the actual 'up'
	/// (as defined in DefaultUpVector). This prevents excessive twisting forces
	/// when viewing from arbitrary angles, but keep the horizon level when
	/// the user is flying over terrain.
	/// </summary>
	public virtual void RestoreUpVectorOff()
	{
		vtkInteractorStyleFlight_RestoreUpVectorOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_RestoreUpVectorOn_33(HandleRef pThis);

	/// <summary>
	/// When flying, apply a restorative force to the "Up" vector.
	/// This is activated when the current 'up' is close to the actual 'up'
	/// (as defined in DefaultUpVector). This prevents excessive twisting forces
	/// when viewing from arbitrary angles, but keep the horizon level when
	/// the user is flying over terrain.
	/// </summary>
	public virtual void RestoreUpVectorOn()
	{
		vtkInteractorStyleFlight_RestoreUpVectorOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_ReverseFly_34(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Keyboard event bindings for flight
	/// </summary>
	public virtual void ReverseFly()
	{
		vtkInteractorStyleFlight_ReverseFly_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleFlight_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleFlight SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleFlight vtkInteractorStyleFlight2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleFlight_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleFlight2 = (vtkInteractorStyleFlight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleFlight2.Register(null);
			}
		}
		return vtkInteractorStyleFlight2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_SetAngleAccelerationFactor_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Set angular acceleration when shift key is applied : default 5
	/// </summary>
	public virtual void SetAngleAccelerationFactor(double _arg)
	{
		vtkInteractorStyleFlight_SetAngleAccelerationFactor_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_SetAngleStepSize_37(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the basic angular unit for turning : default 1 degree
	/// </summary>
	public virtual void SetAngleStepSize(double _arg)
	{
		vtkInteractorStyleFlight_SetAngleStepSize_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_SetDefaultUpVector_38(HandleRef pThis, IntPtr data);

	/// <summary>
	/// When flying, apply a restorative force to the "Up" vector.
	/// This is activated when the current 'up' is close to the actual 'up'
	/// (as defined in DefaultUpVector). This prevents excessive twisting forces
	/// when viewing from arbitrary angles, but keep the horizon level when
	/// the user is flying over terrain.
	/// </summary>
	public virtual void SetDefaultUpVector(IntPtr data)
	{
		vtkInteractorStyleFlight_SetDefaultUpVector_38(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_SetDisableMotion_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Disable motion (temporarily - for viewing etc)
	/// </summary>
	public virtual void SetDisableMotion(int _arg)
	{
		vtkInteractorStyleFlight_SetDisableMotion_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_SetMotionAccelerationFactor_40(HandleRef pThis, double _arg);

	/// <summary>
	/// Set acceleration factor when shift key is applied : default 10
	/// </summary>
	public virtual void SetMotionAccelerationFactor(double _arg)
	{
		vtkInteractorStyleFlight_SetMotionAccelerationFactor_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_SetMotionStepSize_41(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the basic unit step size : by default 1/250 of bounding diagonal
	/// </summary>
	public virtual void SetMotionStepSize(double _arg)
	{
		vtkInteractorStyleFlight_SetMotionStepSize_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_SetRestoreUpVector_42(HandleRef pThis, int _arg);

	/// <summary>
	/// When flying, apply a restorative force to the "Up" vector.
	/// This is activated when the current 'up' is close to the actual 'up'
	/// (as defined in DefaultUpVector). This prevents excessive twisting forces
	/// when viewing from arbitrary angles, but keep the horizon level when
	/// the user is flying over terrain.
	/// </summary>
	public virtual void SetRestoreUpVector(int _arg)
	{
		vtkInteractorStyleFlight_SetRestoreUpVector_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_StartForwardFly_43(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Keyboard event bindings for flight
	/// </summary>
	public virtual void StartForwardFly()
	{
		vtkInteractorStyleFlight_StartForwardFly_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleFlight_StartReverseFly_44(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of Keyboard event bindings for flight
	/// </summary>
	public virtual void StartReverseFly()
	{
		vtkInteractorStyleFlight_StartReverseFly_44(GetCppThis());
	}
}
