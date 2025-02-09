using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkAvatar
/// </summary>
/// <remarks>
///  Renders head and hands for a user in VR
///
/// Set position and orientation for the head and two hands,
/// shows an observer where the avatar is looking and pointing.
/// </remarks>
public class vtkAvatar : vtkActor
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAvatar";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAvatar()
	{
		MRClassNameKey = "class vtkAvatar";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAvatar"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAvatar(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAvatar_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAvatar New()
	{
		vtkAvatar result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAvatar_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAvatar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAvatar()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAvatar_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAvatar_GetHeadOrientation_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual double[] GetHeadOrientation()
	{
		IntPtr intPtr = vtkAvatar_GetHeadOrientation_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetHeadOrientation_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void GetHeadOrientation(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAvatar_GetHeadOrientation_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetHeadOrientation_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void GetHeadOrientation(IntPtr _arg)
	{
		vtkAvatar_GetHeadOrientation_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAvatar_GetHeadPosition_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual double[] GetHeadPosition()
	{
		IntPtr intPtr = vtkAvatar_GetHeadPosition_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetHeadPosition_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void GetHeadPosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAvatar_GetHeadPosition_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetHeadPosition_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void GetHeadPosition(IntPtr _arg)
	{
		vtkAvatar_GetHeadPosition_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAvatar_GetLeftHandOrientation_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual double[] GetLeftHandOrientation()
	{
		IntPtr intPtr = vtkAvatar_GetLeftHandOrientation_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetLeftHandOrientation_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void GetLeftHandOrientation(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAvatar_GetLeftHandOrientation_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetLeftHandOrientation_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void GetLeftHandOrientation(IntPtr _arg)
	{
		vtkAvatar_GetLeftHandOrientation_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAvatar_GetLeftHandPosition_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual double[] GetLeftHandPosition()
	{
		IntPtr intPtr = vtkAvatar_GetLeftHandPosition_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetLeftHandPosition_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void GetLeftHandPosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAvatar_GetLeftHandPosition_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetLeftHandPosition_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void GetLeftHandPosition(IntPtr _arg)
	{
		vtkAvatar_GetLeftHandPosition_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAvatar_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAvatar_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAvatar_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAvatar_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAvatar_GetRightHandOrientation_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual double[] GetRightHandOrientation()
	{
		IntPtr intPtr = vtkAvatar_GetRightHandOrientation_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetRightHandOrientation_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void GetRightHandOrientation(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAvatar_GetRightHandOrientation_16(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetRightHandOrientation_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void GetRightHandOrientation(IntPtr _arg)
	{
		vtkAvatar_GetRightHandOrientation_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAvatar_GetRightHandPosition_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual double[] GetRightHandPosition()
	{
		IntPtr intPtr = vtkAvatar_GetRightHandPosition_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetRightHandPosition_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void GetRightHandPosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAvatar_GetRightHandPosition_19(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetRightHandPosition_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void GetRightHandPosition(IntPtr _arg)
	{
		vtkAvatar_GetRightHandPosition_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAvatar_GetShowHandsOnly_21(HandleRef pThis);

	/// <summary>
	/// Show just the hands. Default false.
	/// </summary>
	public virtual bool GetShowHandsOnly()
	{
		return (vtkAvatar_GetShowHandsOnly_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAvatar_GetUpVector_22(HandleRef pThis);

	/// <summary>
	/// Up vector, in world coords. Must be normalized.
	/// </summary>
	public virtual double[] GetUpVector()
	{
		IntPtr intPtr = vtkAvatar_GetUpVector_22(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetUpVector_23(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Up vector, in world coords. Must be normalized.
	/// </summary>
	public virtual void GetUpVector(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAvatar_GetUpVector_23(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_GetUpVector_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Up vector, in world coords. Must be normalized.
	/// </summary>
	public virtual void GetUpVector(IntPtr _arg)
	{
		vtkAvatar_GetUpVector_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAvatar_GetUseLeftHand_25(HandleRef pThis);

	/// <summary>
	/// Normally, hand position/orientation is set explicitly.
	/// If set to false, hand and arm will follow the torso
	/// in a neutral position.
	/// </summary>
	public virtual bool GetUseLeftHand()
	{
		return (vtkAvatar_GetUseLeftHand_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAvatar_GetUseRightHand_26(HandleRef pThis);

	/// <summary>
	/// Normally, hand position/orientation is set explicitly.
	/// If set to false, hand and arm will follow the torso
	/// in a neutral position.
	/// </summary>
	public virtual bool GetUseRightHand()
	{
		return (vtkAvatar_GetUseRightHand_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAvatar_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAvatar_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAvatar_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAvatar_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAvatar_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAvatar NewInstance()
	{
		vtkAvatar result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAvatar_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAvatar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAvatar_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAvatar SafeDownCast(vtkObjectBase o)
	{
		vtkAvatar vtkAvatar2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAvatar_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAvatar2 = (vtkAvatar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAvatar2.Register(null);
			}
		}
		return vtkAvatar2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetHeadOrientation_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void SetHeadOrientation(double _arg1, double _arg2, double _arg3)
	{
		vtkAvatar_SetHeadOrientation_32(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetHeadOrientation_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void SetHeadOrientation(IntPtr _arg)
	{
		vtkAvatar_SetHeadOrientation_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetHeadPosition_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void SetHeadPosition(double _arg1, double _arg2, double _arg3)
	{
		vtkAvatar_SetHeadPosition_34(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetHeadPosition_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void SetHeadPosition(IntPtr _arg)
	{
		vtkAvatar_SetHeadPosition_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetLeftHandOrientation_36(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void SetLeftHandOrientation(double _arg1, double _arg2, double _arg3)
	{
		vtkAvatar_SetLeftHandOrientation_36(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetLeftHandOrientation_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void SetLeftHandOrientation(IntPtr _arg)
	{
		vtkAvatar_SetLeftHandOrientation_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetLeftHandPosition_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void SetLeftHandPosition(double _arg1, double _arg2, double _arg3)
	{
		vtkAvatar_SetLeftHandPosition_38(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetLeftHandPosition_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void SetLeftHandPosition(IntPtr _arg)
	{
		vtkAvatar_SetLeftHandPosition_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetRightHandOrientation_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void SetRightHandOrientation(double _arg1, double _arg2, double _arg3)
	{
		vtkAvatar_SetRightHandOrientation_40(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetRightHandOrientation_41(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void SetRightHandOrientation(IntPtr _arg)
	{
		vtkAvatar_SetRightHandOrientation_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetRightHandPosition_42(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void SetRightHandPosition(double _arg1, double _arg2, double _arg3)
	{
		vtkAvatar_SetRightHandPosition_42(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetRightHandPosition_43(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the head and hand transforms.
	/// </summary>
	public virtual void SetRightHandPosition(IntPtr _arg)
	{
		vtkAvatar_SetRightHandPosition_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetShowHandsOnly_44(HandleRef pThis, byte _arg);

	/// <summary>
	/// Show just the hands. Default false.
	/// </summary>
	public virtual void SetShowHandsOnly(bool _arg)
	{
		vtkAvatar_SetShowHandsOnly_44(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetUpVector_45(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Up vector, in world coords. Must be normalized.
	/// </summary>
	public virtual void SetUpVector(double _arg1, double _arg2, double _arg3)
	{
		vtkAvatar_SetUpVector_45(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetUpVector_46(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Up vector, in world coords. Must be normalized.
	/// </summary>
	public virtual void SetUpVector(IntPtr _arg)
	{
		vtkAvatar_SetUpVector_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetUseLeftHand_47(HandleRef pThis, byte _arg);

	/// <summary>
	/// Normally, hand position/orientation is set explicitly.
	/// If set to false, hand and arm will follow the torso
	/// in a neutral position.
	/// </summary>
	public virtual void SetUseLeftHand(bool _arg)
	{
		vtkAvatar_SetUseLeftHand_47(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_SetUseRightHand_48(HandleRef pThis, byte _arg);

	/// <summary>
	/// Normally, hand position/orientation is set explicitly.
	/// If set to false, hand and arm will follow the torso
	/// in a neutral position.
	/// </summary>
	public virtual void SetUseRightHand(bool _arg)
	{
		vtkAvatar_SetUseRightHand_48(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_ShowHandsOnlyOff_49(HandleRef pThis);

	/// <summary>
	/// Show just the hands. Default false.
	/// </summary>
	public virtual void ShowHandsOnlyOff()
	{
		vtkAvatar_ShowHandsOnlyOff_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_ShowHandsOnlyOn_50(HandleRef pThis);

	/// <summary>
	/// Show just the hands. Default false.
	/// </summary>
	public virtual void ShowHandsOnlyOn()
	{
		vtkAvatar_ShowHandsOnlyOn_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_UseLeftHandOff_51(HandleRef pThis);

	/// <summary>
	/// Normally, hand position/orientation is set explicitly.
	/// If set to false, hand and arm will follow the torso
	/// in a neutral position.
	/// </summary>
	public virtual void UseLeftHandOff()
	{
		vtkAvatar_UseLeftHandOff_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_UseLeftHandOn_52(HandleRef pThis);

	/// <summary>
	/// Normally, hand position/orientation is set explicitly.
	/// If set to false, hand and arm will follow the torso
	/// in a neutral position.
	/// </summary>
	public virtual void UseLeftHandOn()
	{
		vtkAvatar_UseLeftHandOn_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_UseRightHandOff_53(HandleRef pThis);

	/// <summary>
	/// Normally, hand position/orientation is set explicitly.
	/// If set to false, hand and arm will follow the torso
	/// in a neutral position.
	/// </summary>
	public virtual void UseRightHandOff()
	{
		vtkAvatar_UseRightHandOff_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAvatar_UseRightHandOn_54(HandleRef pThis);

	/// <summary>
	/// Normally, hand position/orientation is set explicitly.
	/// If set to false, hand and arm will follow the torso
	/// in a neutral position.
	/// </summary>
	public virtual void UseRightHandOn()
	{
		vtkAvatar_UseRightHandOn_54(GetCppThis());
	}
}
