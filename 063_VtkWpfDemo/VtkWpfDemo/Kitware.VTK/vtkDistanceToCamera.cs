using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDistanceToCamera
/// </summary>
/// <remarks>
///    calculates distance from points to the camera.
///
///
/// This filter adds a double array containing the distance from each point
/// to the camera. If Scaling is on, it will use the values in the input
/// array to process in order to scale the size of the points. ScreenSize
/// sets the size in screen pixels that you would want a rendered rectangle
/// at that point to be, if it was scaled by the output array.
/// </remarks>
public class vtkDistanceToCamera : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceToCamera";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDistanceToCamera()
	{
		MRClassNameKey = "class vtkDistanceToCamera";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceToCamera"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDistanceToCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceToCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDistanceToCamera New()
	{
		vtkDistanceToCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceToCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistanceToCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDistanceToCamera()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDistanceToCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDistanceToCamera_GetDistanceArrayName_01(HandleRef pThis);

	/// <summary>
	/// The name of the distance array. If not set, the array is
	/// named 'DistanceToCamera'.
	/// </summary>
	public virtual string GetDistanceArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDistanceToCamera_GetDistanceArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDistanceToCamera_GetMTime_02(HandleRef pThis);

	/// <summary>
	/// The modified time of this filter.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkDistanceToCamera_GetMTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistanceToCamera_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDistanceToCamera_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistanceToCamera_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDistanceToCamera_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceToCamera_GetRenderer_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The renderer which will ultimately render these points.
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceToCamera_GetRenderer_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDistanceToCamera_GetScaling_06(HandleRef pThis);

	/// <summary>
	/// Whether to scale the distance by the input array to process.
	/// </summary>
	public virtual bool GetScaling()
	{
		return (vtkDistanceToCamera_GetScaling_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDistanceToCamera_GetScreenSize_07(HandleRef pThis);

	/// <summary>
	/// The desired screen size obtained by scaling glyphs by the distance
	/// array. It assumes the glyph at each point will be unit size.
	/// </summary>
	public virtual double GetScreenSize()
	{
		return vtkDistanceToCamera_GetScreenSize_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceToCamera_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDistanceToCamera_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceToCamera_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDistanceToCamera_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceToCamera_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDistanceToCamera NewInstance()
	{
		vtkDistanceToCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceToCamera_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistanceToCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceToCamera_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDistanceToCamera SafeDownCast(vtkObjectBase o)
	{
		vtkDistanceToCamera vtkDistanceToCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceToCamera_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDistanceToCamera2 = (vtkDistanceToCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDistanceToCamera2.Register(null);
			}
		}
		return vtkDistanceToCamera2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceToCamera_ScalingOff_13(HandleRef pThis);

	/// <summary>
	/// Whether to scale the distance by the input array to process.
	/// </summary>
	public virtual void ScalingOff()
	{
		vtkDistanceToCamera_ScalingOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceToCamera_ScalingOn_14(HandleRef pThis);

	/// <summary>
	/// Whether to scale the distance by the input array to process.
	/// </summary>
	public virtual void ScalingOn()
	{
		vtkDistanceToCamera_ScalingOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceToCamera_SetDistanceArrayName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the distance array. If not set, the array is
	/// named 'DistanceToCamera'.
	/// </summary>
	public virtual void SetDistanceArrayName(string _arg)
	{
		vtkDistanceToCamera_SetDistanceArrayName_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceToCamera_SetRenderer_16(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// The renderer which will ultimately render these points.
	/// </summary>
	public void SetRenderer(vtkRenderer ren)
	{
		vtkDistanceToCamera_SetRenderer_16(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceToCamera_SetScaling_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to scale the distance by the input array to process.
	/// </summary>
	public virtual void SetScaling(bool _arg)
	{
		vtkDistanceToCamera_SetScaling_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceToCamera_SetScreenSize_18(HandleRef pThis, double _arg);

	/// <summary>
	/// The desired screen size obtained by scaling glyphs by the distance
	/// array. It assumes the glyph at each point will be unit size.
	/// </summary>
	public virtual void SetScreenSize(double _arg)
	{
		vtkDistanceToCamera_SetScreenSize_18(GetCppThis(), _arg);
	}
}
