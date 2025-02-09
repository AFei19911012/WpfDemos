using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPTSReader
/// </summary>
/// <remarks>
///    Read ASCII PTS Files.
///
/// vtkPTSReader reads either a text file of
///  points. The first line is the number of points. Point information is
///  either x y z intensity or x y z intensity r g b
/// </remarks>
public class vtkPTSReader : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPTSReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPTSReader()
	{
		MRClassNameKey = "class vtkPTSReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPTSReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPTSReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPTSReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPTSReader New()
	{
		vtkPTSReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPTSReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPTSReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPTSReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPTSReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_CreateCellsOff_01(HandleRef pThis);

	/// <summary>
	/// Boolean value indicates whether or not to create cells
	/// for this dataset. Otherwise only points and scalars
	/// are created. Defaults to true.
	/// </summary>
	public virtual void CreateCellsOff()
	{
		vtkPTSReader_CreateCellsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_CreateCellsOn_02(HandleRef pThis);

	/// <summary>
	/// Boolean value indicates whether or not to create cells
	/// for this dataset. Otherwise only points and scalars
	/// are created. Defaults to true.
	/// </summary>
	public virtual void CreateCellsOn()
	{
		vtkPTSReader_CreateCellsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPTSReader_GetCreateCells_03(HandleRef pThis);

	/// <summary>
	/// Boolean value indicates whether or not to create cells
	/// for this dataset. Otherwise only points and scalars
	/// are created. Defaults to true.
	/// </summary>
	public virtual bool GetCreateCells()
	{
		return (vtkPTSReader_GetCreateCells_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPTSReader_GetFileName_04(HandleRef pThis);

	/// <summary>
	/// Specify file name.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkPTSReader_GetFileName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPTSReader_GetIncludeColorAndLuminance_05(HandleRef pThis);

	/// <summary>
	/// Boolean value indicates when color values are present
	/// if luminance should be read in as well
	/// Defaults to true.
	/// </summary>
	public virtual bool GetIncludeColorAndLuminance()
	{
		return (vtkPTSReader_GetIncludeColorAndLuminance_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPTSReader_GetLimitReadToBounds_06(HandleRef pThis);

	/// <summary>
	/// Boolean value indicates whether or not to limit points read to a specified
	/// (ReadBounds) region.
	/// </summary>
	public virtual bool GetLimitReadToBounds()
	{
		return (vtkPTSReader_GetLimitReadToBounds_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPTSReader_GetLimitToMaxNumberOfPoints_07(HandleRef pThis);

	/// <summary>
	/// Boolean value indicates whether or not to limit number of points read
	/// based on MaxNumbeOfPoints.
	/// </summary>
	public virtual bool GetLimitToMaxNumberOfPoints()
	{
		return (vtkPTSReader_GetLimitToMaxNumberOfPoints_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPTSReader_GetMaxNumberOfPoints_08(HandleRef pThis);

	/// <summary>
	/// The maximum number of points to load if LimitToMaxNumberOfPoints is on/true.
	/// Sets a temporary onRatio.
	/// </summary>
	public virtual long GetMaxNumberOfPoints()
	{
		return vtkPTSReader_GetMaxNumberOfPoints_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPTSReader_GetMaxNumberOfPointsMaxValue_09(HandleRef pThis);

	/// <summary>
	/// The maximum number of points to load if LimitToMaxNumberOfPoints is on/true.
	/// Sets a temporary onRatio.
	/// </summary>
	public virtual long GetMaxNumberOfPointsMaxValue()
	{
		return vtkPTSReader_GetMaxNumberOfPointsMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPTSReader_GetMaxNumberOfPointsMinValue_10(HandleRef pThis);

	/// <summary>
	/// The maximum number of points to load if LimitToMaxNumberOfPoints is on/true.
	/// Sets a temporary onRatio.
	/// </summary>
	public virtual long GetMaxNumberOfPointsMinValue()
	{
		return vtkPTSReader_GetMaxNumberOfPointsMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPTSReader_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPTSReader_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPTSReader_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPTSReader_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPTSReader_GetOutputDataTypeIsDouble_13(HandleRef pThis);

	/// <summary>
	/// The output type defaults to float, but can instead be double.
	/// </summary>
	public virtual bool GetOutputDataTypeIsDouble()
	{
		return (vtkPTSReader_GetOutputDataTypeIsDouble_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPTSReader_GetReadBounds_14(HandleRef pThis);

	/// <summary>
	/// Bounds to use if LimitReadToBounds is On
	/// </summary>
	public virtual double[] GetReadBounds()
	{
		IntPtr intPtr = vtkPTSReader_GetReadBounds_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_GetReadBounds_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Bounds to use if LimitReadToBounds is On
	/// </summary>
	public virtual void GetReadBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkPTSReader_GetReadBounds_15(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_GetReadBounds_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Bounds to use if LimitReadToBounds is On
	/// </summary>
	public virtual void GetReadBounds(IntPtr _arg)
	{
		vtkPTSReader_GetReadBounds_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_IncludeColorAndLuminanceOff_17(HandleRef pThis);

	/// <summary>
	/// Boolean value indicates when color values are present
	/// if luminance should be read in as well
	/// Defaults to true.
	/// </summary>
	public virtual void IncludeColorAndLuminanceOff()
	{
		vtkPTSReader_IncludeColorAndLuminanceOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_IncludeColorAndLuminanceOn_18(HandleRef pThis);

	/// <summary>
	/// Boolean value indicates when color values are present
	/// if luminance should be read in as well
	/// Defaults to true.
	/// </summary>
	public virtual void IncludeColorAndLuminanceOn()
	{
		vtkPTSReader_IncludeColorAndLuminanceOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPTSReader_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPTSReader_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPTSReader_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPTSReader_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_LimitReadToBoundsOff_21(HandleRef pThis);

	/// <summary>
	/// Boolean value indicates whether or not to limit points read to a specified
	/// (ReadBounds) region.
	/// </summary>
	public virtual void LimitReadToBoundsOff()
	{
		vtkPTSReader_LimitReadToBoundsOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_LimitReadToBoundsOn_22(HandleRef pThis);

	/// <summary>
	/// Boolean value indicates whether or not to limit points read to a specified
	/// (ReadBounds) region.
	/// </summary>
	public virtual void LimitReadToBoundsOn()
	{
		vtkPTSReader_LimitReadToBoundsOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_LimitToMaxNumberOfPointsOff_23(HandleRef pThis);

	/// <summary>
	/// Boolean value indicates whether or not to limit number of points read
	/// based on MaxNumbeOfPoints.
	/// </summary>
	public virtual void LimitToMaxNumberOfPointsOff()
	{
		vtkPTSReader_LimitToMaxNumberOfPointsOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_LimitToMaxNumberOfPointsOn_24(HandleRef pThis);

	/// <summary>
	/// Boolean value indicates whether or not to limit number of points read
	/// based on MaxNumbeOfPoints.
	/// </summary>
	public virtual void LimitToMaxNumberOfPointsOn()
	{
		vtkPTSReader_LimitToMaxNumberOfPointsOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPTSReader_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPTSReader NewInstance()
	{
		vtkPTSReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPTSReader_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPTSReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_OutputDataTypeIsDoubleOff_27(HandleRef pThis);

	/// <summary>
	/// The output type defaults to float, but can instead be double.
	/// </summary>
	public virtual void OutputDataTypeIsDoubleOff()
	{
		vtkPTSReader_OutputDataTypeIsDoubleOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_OutputDataTypeIsDoubleOn_28(HandleRef pThis);

	/// <summary>
	/// The output type defaults to float, but can instead be double.
	/// </summary>
	public virtual void OutputDataTypeIsDoubleOn()
	{
		vtkPTSReader_OutputDataTypeIsDoubleOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPTSReader_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPTSReader SafeDownCast(vtkObjectBase o)
	{
		vtkPTSReader vtkPTSReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPTSReader_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPTSReader2 = (vtkPTSReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPTSReader2.Register(null);
			}
		}
		return vtkPTSReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_SetCreateCells_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// Boolean value indicates whether or not to create cells
	/// for this dataset. Otherwise only points and scalars
	/// are created. Defaults to true.
	/// </summary>
	public virtual void SetCreateCells(bool _arg)
	{
		vtkPTSReader_SetCreateCells_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_SetFileName_31(HandleRef pThis, string filename);

	/// <summary>
	/// Specify file name.
	/// </summary>
	public void SetFileName(string filename)
	{
		vtkPTSReader_SetFileName_31(GetCppThis(), filename);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_SetIncludeColorAndLuminance_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Boolean value indicates when color values are present
	/// if luminance should be read in as well
	/// Defaults to true.
	/// </summary>
	public virtual void SetIncludeColorAndLuminance(bool _arg)
	{
		vtkPTSReader_SetIncludeColorAndLuminance_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_SetLimitReadToBounds_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Boolean value indicates whether or not to limit points read to a specified
	/// (ReadBounds) region.
	/// </summary>
	public virtual void SetLimitReadToBounds(bool _arg)
	{
		vtkPTSReader_SetLimitReadToBounds_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_SetLimitToMaxNumberOfPoints_34(HandleRef pThis, byte _arg);

	/// <summary>
	/// Boolean value indicates whether or not to limit number of points read
	/// based on MaxNumbeOfPoints.
	/// </summary>
	public virtual void SetLimitToMaxNumberOfPoints(bool _arg)
	{
		vtkPTSReader_SetLimitToMaxNumberOfPoints_34(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_SetMaxNumberOfPoints_35(HandleRef pThis, long _arg);

	/// <summary>
	/// The maximum number of points to load if LimitToMaxNumberOfPoints is on/true.
	/// Sets a temporary onRatio.
	/// </summary>
	public virtual void SetMaxNumberOfPoints(long _arg)
	{
		vtkPTSReader_SetMaxNumberOfPoints_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_SetOutputDataTypeIsDouble_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// The output type defaults to float, but can instead be double.
	/// </summary>
	public virtual void SetOutputDataTypeIsDouble(bool _arg)
	{
		vtkPTSReader_SetOutputDataTypeIsDouble_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_SetReadBounds_37(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Bounds to use if LimitReadToBounds is On
	/// </summary>
	public virtual void SetReadBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkPTSReader_SetReadBounds_37(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPTSReader_SetReadBounds_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Bounds to use if LimitReadToBounds is On
	/// </summary>
	public virtual void SetReadBounds(IntPtr _arg)
	{
		vtkPTSReader_SetReadBounds_38(GetCppThis(), _arg);
	}
}
