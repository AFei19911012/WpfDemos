using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkSegYReader
/// </summary>
/// <remarks>
///  Reads SegY data files.
///
/// vtkSegYReader reads SegY data files. We create a vtkStructuredGrid
/// for 2.5D SegY and 3D data. If we set the StructuredGrid option to 0
/// we create a vtkImageData for 3D data. This saves memory and may
/// speed-up certain algorithms, but the position and the shape of the
/// data may not be correct. The axes for the data are: crossline,
/// inline, depth. For situations where traces are missing values of
/// zero are used to fill in the dataset.
/// </remarks>
public class vtkSegYReader : vtkDataSetAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum VTKSegYCoordinateModes
	{
		/// <summary>enum member</summary>
		VTK_SEGY_CDP = 1,
		/// <summary>enum member</summary>
		VTK_SEGY_CUSTOM = 2,
		/// <summary>enum member</summary>
		VTK_SEGY_SOURCE = 0
	}

	/// <summary>
	/// Specify X and Y byte positions for custom XYCoordinateMode.
	/// By default, XCoordByte = 73, YCoordByte = 77 i.e. source xy.
	///
	/// \sa SetXYCoordinatesModeToCustom()
	/// </summary>
	public enum VTKSegYVerticalCRS
	{
		/// <summary>enum member</summary>
		VTK_SEGY_VERTICAL_DEPTHS = 1,
		/// <summary>enum member</summary>
		VTK_SEGY_VERTICAL_HEIGHTS = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSegYReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSegYReader()
	{
		MRClassNameKey = "class vtkSegYReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSegYReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSegYReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSegYReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSegYReader New()
	{
		vtkSegYReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSegYReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSegYReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSegYReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSegYReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_Force2DOff_01(HandleRef pThis);

	/// <summary>
	/// Should we force the data to be interpreted as a 2D dataset? It may be a
	/// 2D sheet through 3D space. When this is turned on we ignore the cross
	/// line and line values and instead build a 2D data by processing and
	/// connecting the traces in order from first to last. The output will be a
	/// Structrured Grid.
	/// </summary>
	public virtual void Force2DOff()
	{
		vtkSegYReader_Force2DOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_Force2DOn_02(HandleRef pThis);

	/// <summary>
	/// Should we force the data to be interpreted as a 2D dataset? It may be a
	/// 2D sheet through 3D space. When this is turned on we ignore the cross
	/// line and line values and instead build a 2D data by processing and
	/// connecting the traces in order from first to last. The output will be a
	/// Structrured Grid.
	/// </summary>
	public virtual void Force2DOn()
	{
		vtkSegYReader_Force2DOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSegYReader_GetFileName_03(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkSegYReader_GetFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSegYReader_GetForce2D_04(HandleRef pThis);

	/// <summary>
	/// Should we force the data to be interpreted as a 2D dataset? It may be a
	/// 2D sheet through 3D space. When this is turned on we ignore the cross
	/// line and line values and instead build a 2D data by processing and
	/// connecting the traces in order from first to last. The output will be a
	/// Structrured Grid.
	/// </summary>
	public virtual bool GetForce2D()
	{
		return (vtkSegYReader_GetForce2D_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSegYReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSegYReader_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSegYReader_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSegYReader_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSegYReader_GetStructuredGrid_07(HandleRef pThis);

	/// <summary>
	/// Specify if we create a vtkStructuredGrid even when the data is
	/// 3D. Note this consumes more memory but it shows the precise
	/// location for each point and the correct shape of the data. The
	/// default value is true.  If we set this option to false we
	/// create a vtkImageData for the SegY 3D dataset.
	/// </summary>
	public virtual int GetStructuredGrid()
	{
		return vtkSegYReader_GetStructuredGrid_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSegYReader_GetVerticalCRS_08(HandleRef pThis);

	/// <summary>
	/// Specify whether the vertical coordinates in the SEG-Y file are heights
	/// (positive up) or depths (positive down). By default, the vertical
	/// coordinates are treated as heights (i.e. positive up). This means that the
	/// Z-axis of the dataset goes from 0 (surface) to -ve depth (last sample).
	/// \note As per the SEG-Y rev 2.0 specification, this information is defined
	/// in the Location Data Stanza of the Extended Textual Header. However, as of
	/// this revision, vtkSegY2DReader does not support reading the extended
	/// textual header.
	/// </summary>
	public virtual int GetVerticalCRS()
	{
		return vtkSegYReader_GetVerticalCRS_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSegYReader_GetXCoordByte_09(HandleRef pThis);

	/// <summary>
	/// Specify X and Y byte positions for custom XYCoordinateMode.
	/// By default, XCoordByte = 73, YCoordByte = 77 i.e. source xy.
	///
	/// \sa SetXYCoordinatesModeToCustom()
	/// </summary>
	public virtual int GetXCoordByte()
	{
		return vtkSegYReader_GetXCoordByte_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSegYReader_GetXYCoordMode_10(HandleRef pThis);

	/// <summary>
	/// Specify whether to use source x/y coordinates or CDP coordinates or custom
	/// byte positions for data position in the SEG-Y trace header. Defaults to
	/// source x/y coordinates.
	///
	/// As per SEG-Y rev 2.0 specification,
	/// Source XY coordinate bytes = (73, 77)
	/// CDP XY coordinate bytes = (181, 185)
	/// </summary>
	public virtual int GetXYCoordMode()
	{
		return vtkSegYReader_GetXYCoordMode_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSegYReader_GetXYCoordModeMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify whether to use source x/y coordinates or CDP coordinates or custom
	/// byte positions for data position in the SEG-Y trace header. Defaults to
	/// source x/y coordinates.
	///
	/// As per SEG-Y rev 2.0 specification,
	/// Source XY coordinate bytes = (73, 77)
	/// CDP XY coordinate bytes = (181, 185)
	/// </summary>
	public virtual int GetXYCoordModeMaxValue()
	{
		return vtkSegYReader_GetXYCoordModeMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSegYReader_GetXYCoordModeMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify whether to use source x/y coordinates or CDP coordinates or custom
	/// byte positions for data position in the SEG-Y trace header. Defaults to
	/// source x/y coordinates.
	///
	/// As per SEG-Y rev 2.0 specification,
	/// Source XY coordinate bytes = (73, 77)
	/// CDP XY coordinate bytes = (181, 185)
	/// </summary>
	public virtual int GetXYCoordModeMinValue()
	{
		return vtkSegYReader_GetXYCoordModeMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSegYReader_GetYCoordByte_13(HandleRef pThis);

	/// <summary>
	/// Specify X and Y byte positions for custom XYCoordinateMode.
	/// By default, XCoordByte = 73, YCoordByte = 77 i.e. source xy.
	///
	/// \sa SetXYCoordinatesModeToCustom()
	/// </summary>
	public virtual int GetYCoordByte()
	{
		return vtkSegYReader_GetYCoordByte_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSegYReader_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSegYReader_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSegYReader_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSegYReader_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSegYReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSegYReader NewInstance()
	{
		vtkSegYReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSegYReader_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSegYReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSegYReader_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSegYReader SafeDownCast(vtkObjectBase o)
	{
		vtkSegYReader vtkSegYReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSegYReader_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSegYReader2 = (vtkSegYReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSegYReader2.Register(null);
			}
		}
		return vtkSegYReader2;
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_SetFileName_19(HandleRef pThis, string _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkSegYReader_SetFileName_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_SetForce2D_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// Should we force the data to be interpreted as a 2D dataset? It may be a
	/// 2D sheet through 3D space. When this is turned on we ignore the cross
	/// line and line values and instead build a 2D data by processing and
	/// connecting the traces in order from first to last. The output will be a
	/// Structrured Grid.
	/// </summary>
	public virtual void SetForce2D(bool _arg)
	{
		vtkSegYReader_SetForce2D_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_SetStructuredGrid_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify if we create a vtkStructuredGrid even when the data is
	/// 3D. Note this consumes more memory but it shows the precise
	/// location for each point and the correct shape of the data. The
	/// default value is true.  If we set this option to false we
	/// create a vtkImageData for the SegY 3D dataset.
	/// </summary>
	public virtual void SetStructuredGrid(int _arg)
	{
		vtkSegYReader_SetStructuredGrid_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_SetVerticalCRS_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether the vertical coordinates in the SEG-Y file are heights
	/// (positive up) or depths (positive down). By default, the vertical
	/// coordinates are treated as heights (i.e. positive up). This means that the
	/// Z-axis of the dataset goes from 0 (surface) to -ve depth (last sample).
	/// \note As per the SEG-Y rev 2.0 specification, this information is defined
	/// in the Location Data Stanza of the Extended Textual Header. However, as of
	/// this revision, vtkSegY2DReader does not support reading the extended
	/// textual header.
	/// </summary>
	public virtual void SetVerticalCRS(int _arg)
	{
		vtkSegYReader_SetVerticalCRS_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_SetXCoordByte_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify X and Y byte positions for custom XYCoordinateMode.
	/// By default, XCoordByte = 73, YCoordByte = 77 i.e. source xy.
	///
	/// \sa SetXYCoordinatesModeToCustom()
	/// </summary>
	public virtual void SetXCoordByte(int _arg)
	{
		vtkSegYReader_SetXCoordByte_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_SetXYCoordMode_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to use source x/y coordinates or CDP coordinates or custom
	/// byte positions for data position in the SEG-Y trace header. Defaults to
	/// source x/y coordinates.
	///
	/// As per SEG-Y rev 2.0 specification,
	/// Source XY coordinate bytes = (73, 77)
	/// CDP XY coordinate bytes = (181, 185)
	/// </summary>
	public virtual void SetXYCoordMode(int _arg)
	{
		vtkSegYReader_SetXYCoordMode_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_SetXYCoordModeToCDP_25(HandleRef pThis);

	/// <summary>
	/// Specify whether to use source x/y coordinates or CDP coordinates or custom
	/// byte positions for data position in the SEG-Y trace header. Defaults to
	/// source x/y coordinates.
	///
	/// As per SEG-Y rev 2.0 specification,
	/// Source XY coordinate bytes = (73, 77)
	/// CDP XY coordinate bytes = (181, 185)
	/// </summary>
	public void SetXYCoordModeToCDP()
	{
		vtkSegYReader_SetXYCoordModeToCDP_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_SetXYCoordModeToCustom_26(HandleRef pThis);

	/// <summary>
	/// Specify whether to use source x/y coordinates or CDP coordinates or custom
	/// byte positions for data position in the SEG-Y trace header. Defaults to
	/// source x/y coordinates.
	///
	/// As per SEG-Y rev 2.0 specification,
	/// Source XY coordinate bytes = (73, 77)
	/// CDP XY coordinate bytes = (181, 185)
	/// </summary>
	public void SetXYCoordModeToCustom()
	{
		vtkSegYReader_SetXYCoordModeToCustom_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_SetXYCoordModeToSource_27(HandleRef pThis);

	/// <summary>
	/// Specify whether to use source x/y coordinates or CDP coordinates or custom
	/// byte positions for data position in the SEG-Y trace header. Defaults to
	/// source x/y coordinates.
	///
	/// As per SEG-Y rev 2.0 specification,
	/// Source XY coordinate bytes = (73, 77)
	/// CDP XY coordinate bytes = (181, 185)
	/// </summary>
	public void SetXYCoordModeToSource()
	{
		vtkSegYReader_SetXYCoordModeToSource_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_SetYCoordByte_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify X and Y byte positions for custom XYCoordinateMode.
	/// By default, XCoordByte = 73, YCoordByte = 77 i.e. source xy.
	///
	/// \sa SetXYCoordinatesModeToCustom()
	/// </summary>
	public virtual void SetYCoordByte(int _arg)
	{
		vtkSegYReader_SetYCoordByte_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_StructuredGridOff_29(HandleRef pThis);

	/// <summary>
	/// Specify if we create a vtkStructuredGrid even when the data is
	/// 3D. Note this consumes more memory but it shows the precise
	/// location for each point and the correct shape of the data. The
	/// default value is true.  If we set this option to false we
	/// create a vtkImageData for the SegY 3D dataset.
	/// </summary>
	public virtual void StructuredGridOff()
	{
		vtkSegYReader_StructuredGridOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSegYReader_StructuredGridOn_30(HandleRef pThis);

	/// <summary>
	/// Specify if we create a vtkStructuredGrid even when the data is
	/// 3D. Note this consumes more memory but it shows the precise
	/// location for each point and the correct shape of the data. The
	/// default value is true.  If we set this option to false we
	/// create a vtkImageData for the SegY 3D dataset.
	/// </summary>
	public virtual void StructuredGridOn()
	{
		vtkSegYReader_StructuredGridOn_30(GetCppThis());
	}
}
