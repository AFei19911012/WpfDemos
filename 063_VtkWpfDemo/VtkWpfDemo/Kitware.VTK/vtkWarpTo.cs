using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWarpTo
/// </summary>
/// <remarks>
///    deform geometry by warping towards a point
///
/// vtkWarpTo is a filter that modifies point coordinates by moving the
/// points towards a user specified position.
/// </remarks>
public class vtkWarpTo : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWarpTo";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWarpTo()
	{
		MRClassNameKey = "class vtkWarpTo";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpTo"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWarpTo(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpTo_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWarpTo New()
	{
		vtkWarpTo result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpTo_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWarpTo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkWarpTo()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWarpTo_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTo_AbsoluteOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the Absolute ivar. Turning Absolute on causes scale factor
	/// of the new position to be one unit away from Position.
	/// </summary>
	public virtual void AbsoluteOff()
	{
		vtkWarpTo_AbsoluteOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTo_AbsoluteOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the Absolute ivar. Turning Absolute on causes scale factor
	/// of the new position to be one unit away from Position.
	/// </summary>
	public virtual void AbsoluteOn()
	{
		vtkWarpTo_AbsoluteOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpTo_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Set/Get the Absolute ivar. Turning Absolute on causes scale factor
	/// of the new position to be one unit away from Position.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkWarpTo_FillInputPortInformation_03(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpTo_GetAbsolute_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the Absolute ivar. Turning Absolute on causes scale factor
	/// of the new position to be one unit away from Position.
	/// </summary>
	public virtual int GetAbsolute()
	{
		return vtkWarpTo_GetAbsolute_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWarpTo_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWarpTo_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWarpTo_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWarpTo_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpTo_GetPosition_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the position to warp towards.
	/// </summary>
	public virtual double[] GetPosition()
	{
		IntPtr intPtr = vtkWarpTo_GetPosition_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTo_GetPosition_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the position to warp towards.
	/// </summary>
	public virtual void GetPosition(IntPtr data)
	{
		vtkWarpTo_GetPosition_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWarpTo_GetScaleFactor_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the value to scale displacement.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkWarpTo_GetScaleFactor_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpTo_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWarpTo_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpTo_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWarpTo_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpTo_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWarpTo NewInstance()
	{
		vtkWarpTo result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpTo_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWarpTo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpTo_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWarpTo SafeDownCast(vtkObjectBase o)
	{
		vtkWarpTo vtkWarpTo2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpTo_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWarpTo2 = (vtkWarpTo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWarpTo2.Register(null);
			}
		}
		return vtkWarpTo2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTo_SetAbsolute_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the Absolute ivar. Turning Absolute on causes scale factor
	/// of the new position to be one unit away from Position.
	/// </summary>
	public virtual void SetAbsolute(int _arg)
	{
		vtkWarpTo_SetAbsolute_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTo_SetPosition_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the position to warp towards.
	/// </summary>
	public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
	{
		vtkWarpTo_SetPosition_16(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTo_SetPosition_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the position to warp towards.
	/// </summary>
	public virtual void SetPosition(IntPtr _arg)
	{
		vtkWarpTo_SetPosition_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTo_SetScaleFactor_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the value to scale displacement.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkWarpTo_SetScaleFactor_18(GetCppThis(), _arg);
	}
}
