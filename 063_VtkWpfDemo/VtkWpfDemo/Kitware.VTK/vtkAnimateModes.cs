using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkAnimateModes
/// </summary>
/// <remarks>
///  animate mode shapes
///
/// For certain file formats, like Exodus, simulation codes may use the timesteps
/// and time values to represent quantities other than time. For example, for
/// modal analysis, the natural frequency for each mode may be used as the time
/// value. vtkAnimateModes can be used to reinterpret time as mode shapes.
/// The filter can also animate vibrations for each mode shape (when
/// AnimateVibrations is set to true). In that case, the time requested by the
/// downstream pipeline is used to scale the displacement magnitude
/// for a mode shape in a sinusoidal pattern, `cos(2*pi * requested-time)`.
///
/// Historically, the VTK's Exodus reader (`vtkExodusIIReader`) had support for
/// this internally. However, when implementation the IOSS-based reader for
/// Exodus files (`vtkIossReader`), it was decided that it's cleaner to leave the
/// mode shape and vibration animation logic independent of the reader and thus
/// make it usable with other file formats too. Hence this filter was created.
/// </remarks>
public class vtkAnimateModes : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAnimateModes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAnimateModes()
	{
		MRClassNameKey = "class vtkAnimateModes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnimateModes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAnimateModes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnimateModes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAnimateModes New()
	{
		vtkAnimateModes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnimateModes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAnimateModes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAnimateModes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAnimateModes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAnimateModes_AnimateVibrationsOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the filter should animate the vibrations.
	/// Defaults to true. When set, the requested time is used compute
	/// displacements for the chosen mode shape.
	/// Defaults to true.
	/// </summary>
	public virtual void AnimateVibrationsOff()
	{
		vtkAnimateModes_AnimateVibrationsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimateModes_AnimateVibrationsOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the filter should animate the vibrations.
	/// Defaults to true. When set, the requested time is used compute
	/// displacements for the chosen mode shape.
	/// Defaults to true.
	/// </summary>
	public virtual void AnimateVibrationsOn()
	{
		vtkAnimateModes_AnimateVibrationsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimateModes_DisplacementPreappliedOff_03(HandleRef pThis);

	/// <summary>
	/// Get/Set whether displacements are pre-applied.
	/// Default is false.
	/// </summary>
	public virtual void DisplacementPreappliedOff()
	{
		vtkAnimateModes_DisplacementPreappliedOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimateModes_DisplacementPreappliedOn_04(HandleRef pThis);

	/// <summary>
	/// Get/Set whether displacements are pre-applied.
	/// Default is false.
	/// </summary>
	public virtual void DisplacementPreappliedOn()
	{
		vtkAnimateModes_DisplacementPreappliedOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAnimateModes_GetAnimateVibrations_05(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the filter should animate the vibrations.
	/// Defaults to true. When set, the requested time is used compute
	/// displacements for the chosen mode shape.
	/// Defaults to true.
	/// </summary>
	public virtual bool GetAnimateVibrations()
	{
		return (vtkAnimateModes_GetAnimateVibrations_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAnimateModes_GetDisplacementMagnitude_06(HandleRef pThis);

	/// <summary>
	/// Get/Set a scale factor to apply the displacements.
	/// Defaults to 1.
	/// </summary>
	public virtual double GetDisplacementMagnitude()
	{
		return vtkAnimateModes_GetDisplacementMagnitude_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAnimateModes_GetDisplacementPreapplied_07(HandleRef pThis);

	/// <summary>
	/// Get/Set whether displacements are pre-applied.
	/// Default is false.
	/// </summary>
	public virtual bool GetDisplacementPreapplied()
	{
		return (vtkAnimateModes_GetDisplacementPreapplied_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimateModes_GetModeShape_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode shape to animate. Defaults to 1.
	/// </summary>
	public virtual int GetModeShape()
	{
		return vtkAnimateModes_GetModeShape_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimateModes_GetModeShapeMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode shape to animate. Defaults to 1.
	/// </summary>
	public virtual int GetModeShapeMaxValue()
	{
		return vtkAnimateModes_GetModeShapeMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimateModes_GetModeShapeMinValue_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode shape to animate. Defaults to 1.
	/// </summary>
	public virtual int GetModeShapeMinValue()
	{
		return vtkAnimateModes_GetModeShapeMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnimateModes_GetModeShapesRange_11(HandleRef pThis);

	/// <summary>
	/// Get the range for available mode shapes in the input. One must call
	/// `UpdateInformation` before check the range since the range is determined
	/// based on the number of input timesteps. The range is always `[1, &lt;number of
	/// timesteps&gt;]`.
	/// </summary>
	public virtual int[] GetModeShapesRange()
	{
		IntPtr intPtr = vtkAnimateModes_GetModeShapesRange_11(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimateModes_GetModeShapesRange_12(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get the range for available mode shapes in the input. One must call
	/// `UpdateInformation` before check the range since the range is determined
	/// based on the number of input timesteps. The range is always `[1, &lt;number of
	/// timesteps&gt;]`.
	/// </summary>
	public virtual void GetModeShapesRange(ref int _arg1, ref int _arg2)
	{
		vtkAnimateModes_GetModeShapesRange_12(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimateModes_GetModeShapesRange_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the range for available mode shapes in the input. One must call
	/// `UpdateInformation` before check the range since the range is determined
	/// based on the number of input timesteps. The range is always `[1, &lt;number of
	/// timesteps&gt;]`.
	/// </summary>
	public virtual void GetModeShapesRange(IntPtr _arg)
	{
		vtkAnimateModes_GetModeShapesRange_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAnimateModes_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAnimateModes_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAnimateModes_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAnimateModes_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnimateModes_GetTimeRange_16(HandleRef pThis);

	/// <summary>
	/// This returns (0, 1.0) as the range that can be used when animating a mode
	/// shape.
	/// </summary>
	public virtual double[] GetTimeRange()
	{
		IntPtr intPtr = vtkAnimateModes_GetTimeRange_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimateModes_GetTimeRange_17(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// This returns (0, 1.0) as the range that can be used when animating a mode
	/// shape.
	/// </summary>
	public virtual void GetTimeRange(ref double _arg1, ref double _arg2)
	{
		vtkAnimateModes_GetTimeRange_17(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimateModes_GetTimeRange_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// This returns (0, 1.0) as the range that can be used when animating a mode
	/// shape.
	/// </summary>
	public virtual void GetTimeRange(IntPtr _arg)
	{
		vtkAnimateModes_GetTimeRange_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimateModes_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAnimateModes_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimateModes_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAnimateModes_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnimateModes_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAnimateModes NewInstance()
	{
		vtkAnimateModes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnimateModes_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAnimateModes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnimateModes_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAnimateModes SafeDownCast(vtkObjectBase o)
	{
		vtkAnimateModes vtkAnimateModes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnimateModes_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnimateModes2 = (vtkAnimateModes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnimateModes2.Register(null);
			}
		}
		return vtkAnimateModes2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimateModes_SetAnimateVibrations_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether the filter should animate the vibrations.
	/// Defaults to true. When set, the requested time is used compute
	/// displacements for the chosen mode shape.
	/// Defaults to true.
	/// </summary>
	public virtual void SetAnimateVibrations(bool _arg)
	{
		vtkAnimateModes_SetAnimateVibrations_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimateModes_SetDisplacementMagnitude_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set a scale factor to apply the displacements.
	/// Defaults to 1.
	/// </summary>
	public virtual void SetDisplacementMagnitude(double _arg)
	{
		vtkAnimateModes_SetDisplacementMagnitude_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimateModes_SetDisplacementPreapplied_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set whether displacements are pre-applied.
	/// Default is false.
	/// </summary>
	public virtual void SetDisplacementPreapplied(bool _arg)
	{
		vtkAnimateModes_SetDisplacementPreapplied_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimateModes_SetModeShape_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the mode shape to animate. Defaults to 1.
	/// </summary>
	public virtual void SetModeShape(int _arg)
	{
		vtkAnimateModes_SetModeShape_27(GetCppThis(), _arg);
	}
}
