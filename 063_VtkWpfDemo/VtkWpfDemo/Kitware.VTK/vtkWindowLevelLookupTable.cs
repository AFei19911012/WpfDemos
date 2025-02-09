using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWindowLevelLookupTable
/// </summary>
/// <remarks>
///    map scalar values into colors or colors to scalars; generate color table
///
/// vtkWindowLevelLookupTable is an object that is used by mapper objects
/// to map scalar values into rgba (red-green-blue-alpha transparency)
/// color specification, or rgba into scalar values. The color table can
/// be created by direct insertion of color values, or by specifying a
/// window and level. Window / Level is used in medical imaging to specify
/// a linear greyscale ramp. The Level is the center of the ramp.  The
/// Window is the width of the ramp.
///
/// @warning
/// vtkWindowLevelLookupTable is a reference counted object. Therefore, you
/// should always use operator "new" to construct new objects. This procedure
/// will avoid memory problems (see text).
///
/// </remarks>
/// <seealso>
///
/// vtkLogLookupTable
/// </seealso>
public class vtkWindowLevelLookupTable : vtkLookupTable
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWindowLevelLookupTable";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWindowLevelLookupTable()
	{
		MRClassNameKey = "class vtkWindowLevelLookupTable";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindowLevelLookupTable"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWindowLevelLookupTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowLevelLookupTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWindowLevelLookupTable New()
	{
		vtkWindowLevelLookupTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowLevelLookupTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWindowLevelLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkWindowLevelLookupTable()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWindowLevelLookupTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkWindowLevelLookupTable_ForceBuild_01(HandleRef pThis);

	/// <summary>
	/// Generate lookup table as a linear ramp between MinimumTableValue
	/// and MaximumTableValue.
	/// </summary>
	public override void ForceBuild()
	{
		vtkWindowLevelLookupTable_ForceBuild_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowLevelLookupTable_GetInverseVideo_02(HandleRef pThis);

	/// <summary>
	/// Set inverse video on or off.  You can achieve the same effect by
	/// switching the MinimumTableValue and the MaximumTableValue.
	/// </summary>
	public virtual int GetInverseVideo()
	{
		return vtkWindowLevelLookupTable_GetInverseVideo_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWindowLevelLookupTable_GetLevel_03(HandleRef pThis);

	/// <summary>
	/// Set the Level for the lookup table.  The level is the average of
	/// TableRange[0] and TableRange[1].
	/// </summary>
	public virtual double GetLevel()
	{
		return vtkWindowLevelLookupTable_GetLevel_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowLevelLookupTable_GetMaximumTableValue_04(HandleRef pThis);

	/// <summary>
	/// Set the maximum table value. All lookup table entries above the
	/// end of the ramp will be set to this color.  After you change
	/// this value, you must re-build the lookup table.
	/// </summary>
	public virtual double[] GetMaximumTableValue()
	{
		IntPtr intPtr = vtkWindowLevelLookupTable_GetMaximumTableValue_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_GetMaximumTableValue_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set the maximum table value. All lookup table entries above the
	/// end of the ramp will be set to this color.  After you change
	/// this value, you must re-build the lookup table.
	/// </summary>
	public virtual void GetMaximumTableValue(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkWindowLevelLookupTable_GetMaximumTableValue_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_GetMaximumTableValue_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the maximum table value. All lookup table entries above the
	/// end of the ramp will be set to this color.  After you change
	/// this value, you must re-build the lookup table.
	/// </summary>
	public virtual void GetMaximumTableValue(IntPtr _arg)
	{
		vtkWindowLevelLookupTable_GetMaximumTableValue_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowLevelLookupTable_GetMinimumTableValue_07(HandleRef pThis);

	/// <summary>
	/// Set the minimum table value.  All lookup table entries below the
	/// start of the ramp will be set to this color.  After you change
	/// this value, you must re-build the lookup table.
	/// </summary>
	public virtual double[] GetMinimumTableValue()
	{
		IntPtr intPtr = vtkWindowLevelLookupTable_GetMinimumTableValue_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_GetMinimumTableValue_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set the minimum table value.  All lookup table entries below the
	/// start of the ramp will be set to this color.  After you change
	/// this value, you must re-build the lookup table.
	/// </summary>
	public virtual void GetMinimumTableValue(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkWindowLevelLookupTable_GetMinimumTableValue_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_GetMinimumTableValue_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the minimum table value.  All lookup table entries below the
	/// start of the ramp will be set to this color.  After you change
	/// this value, you must re-build the lookup table.
	/// </summary>
	public virtual void GetMinimumTableValue(IntPtr _arg)
	{
		vtkWindowLevelLookupTable_GetMinimumTableValue_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWindowLevelLookupTable_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWindowLevelLookupTable_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWindowLevelLookupTable_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWindowLevelLookupTable_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWindowLevelLookupTable_GetWindow_12(HandleRef pThis);

	/// <summary>
	/// Set the window for the lookup table.  The window is the difference
	/// between TableRange[0] and TableRange[1].
	/// </summary>
	public virtual double GetWindow()
	{
		return vtkWindowLevelLookupTable_GetWindow_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_InverseVideoOff_13(HandleRef pThis);

	/// <summary>
	/// Set inverse video on or off.  You can achieve the same effect by
	/// switching the MinimumTableValue and the MaximumTableValue.
	/// </summary>
	public virtual void InverseVideoOff()
	{
		vtkWindowLevelLookupTable_InverseVideoOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_InverseVideoOn_14(HandleRef pThis);

	/// <summary>
	/// Set inverse video on or off.  You can achieve the same effect by
	/// switching the MinimumTableValue and the MaximumTableValue.
	/// </summary>
	public virtual void InverseVideoOn()
	{
		vtkWindowLevelLookupTable_InverseVideoOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowLevelLookupTable_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWindowLevelLookupTable_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowLevelLookupTable_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWindowLevelLookupTable_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowLevelLookupTable_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWindowLevelLookupTable NewInstance()
	{
		vtkWindowLevelLookupTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowLevelLookupTable_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWindowLevelLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowLevelLookupTable_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWindowLevelLookupTable SafeDownCast(vtkObjectBase o)
	{
		vtkWindowLevelLookupTable vtkWindowLevelLookupTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowLevelLookupTable_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWindowLevelLookupTable2 = (vtkWindowLevelLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWindowLevelLookupTable2.Register(null);
			}
		}
		return vtkWindowLevelLookupTable2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_SetInverseVideo_20(HandleRef pThis, int iv);

	/// <summary>
	/// Set inverse video on or off.  You can achieve the same effect by
	/// switching the MinimumTableValue and the MaximumTableValue.
	/// </summary>
	public void SetInverseVideo(int iv)
	{
		vtkWindowLevelLookupTable_SetInverseVideo_20(GetCppThis(), iv);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_SetLevel_21(HandleRef pThis, double level);

	/// <summary>
	/// Set the Level for the lookup table.  The level is the average of
	/// TableRange[0] and TableRange[1].
	/// </summary>
	public void SetLevel(double level)
	{
		vtkWindowLevelLookupTable_SetLevel_21(GetCppThis(), level);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_SetMaximumTableValue_22(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set the maximum table value. All lookup table entries above the
	/// end of the ramp will be set to this color.  After you change
	/// this value, you must re-build the lookup table.
	/// </summary>
	public virtual void SetMaximumTableValue(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkWindowLevelLookupTable_SetMaximumTableValue_22(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_SetMaximumTableValue_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the maximum table value. All lookup table entries above the
	/// end of the ramp will be set to this color.  After you change
	/// this value, you must re-build the lookup table.
	/// </summary>
	public virtual void SetMaximumTableValue(IntPtr _arg)
	{
		vtkWindowLevelLookupTable_SetMaximumTableValue_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_SetMinimumTableValue_24(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set the minimum table value.  All lookup table entries below the
	/// start of the ramp will be set to this color.  After you change
	/// this value, you must re-build the lookup table.
	/// </summary>
	public virtual void SetMinimumTableValue(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkWindowLevelLookupTable_SetMinimumTableValue_24(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_SetMinimumTableValue_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the minimum table value.  All lookup table entries below the
	/// start of the ramp will be set to this color.  After you change
	/// this value, you must re-build the lookup table.
	/// </summary>
	public virtual void SetMinimumTableValue(IntPtr _arg)
	{
		vtkWindowLevelLookupTable_SetMinimumTableValue_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowLevelLookupTable_SetWindow_26(HandleRef pThis, double window);

	/// <summary>
	/// Set the window for the lookup table.  The window is the difference
	/// between TableRange[0] and TableRange[1].
	/// </summary>
	public void SetWindow(double window)
	{
		vtkWindowLevelLookupTable_SetWindow_26(GetCppThis(), window);
	}
}
