using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDicer
/// </summary>
/// <remarks>
///    abstract superclass to divide dataset into pieces
///
/// Subclasses of vtkDicer divides the input dataset into separate
/// pieces.  These pieces can then be operated on by other filters
/// (e.g., vtkThreshold). One application is to break very large
/// polygonal models into pieces and performing viewing and occlusion
/// culling on the pieces. Multiple pieces can also be streamed through
/// the visualization pipeline.
///
/// To use this filter, you must specify the execution mode of the
/// filter; i.e., set the way that the piece size is controlled (do
/// this by setting the DiceMode ivar). The filter does not change the
/// geometry or topology of the input dataset, rather it generates
/// integer numbers that indicate which piece a particular point
/// belongs to (i.e., it modifies the point and cell attribute
/// data). The integer number can be placed into the output scalar
/// data, or the output field data.
///
/// @warning
/// The number of pieces generated may not equal the specified number
/// of pieces. Use the method GetNumberOfActualPieces() after filter
/// execution to get the actual number of pieces generated.
///
/// </remarks>
/// <seealso>
///
/// vtkOBBDicer vtkConnectedDicer vtkSpatialDicer
/// </seealso>
public class vtkDicer : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDicer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDicer()
	{
		MRClassNameKey = "class vtkDicer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDicer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDicer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDicer_FieldDataOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which controls whether to generate point scalar
	/// data or point field data. If this flag is off, scalar data is
	/// generated.  Otherwise, field data is generated. Note that the
	/// generated the data are integer numbers indicating which piece a
	/// particular point belongs to.
	/// </summary>
	public virtual void FieldDataOff()
	{
		vtkDicer_FieldDataOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDicer_FieldDataOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which controls whether to generate point scalar
	/// data or point field data. If this flag is off, scalar data is
	/// generated.  Otherwise, field data is generated. Note that the
	/// generated the data are integer numbers indicating which piece a
	/// particular point belongs to.
	/// </summary>
	public virtual void FieldDataOn()
	{
		vtkDicer_FieldDataOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_GetDiceMode_03(HandleRef pThis);

	/// <summary>
	/// Specify the method to determine how many pieces the data should be
	/// broken into. By default, the number of points per piece is used.
	/// </summary>
	public virtual int GetDiceMode()
	{
		return vtkDicer_GetDiceMode_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_GetDiceModeMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Specify the method to determine how many pieces the data should be
	/// broken into. By default, the number of points per piece is used.
	/// </summary>
	public virtual int GetDiceModeMaxValue()
	{
		return vtkDicer_GetDiceModeMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_GetDiceModeMinValue_05(HandleRef pThis);

	/// <summary>
	/// Specify the method to determine how many pieces the data should be
	/// broken into. By default, the number of points per piece is used.
	/// </summary>
	public virtual int GetDiceModeMinValue()
	{
		return vtkDicer_GetDiceModeMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_GetFieldData_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which controls whether to generate point scalar
	/// data or point field data. If this flag is off, scalar data is
	/// generated.  Otherwise, field data is generated. Note that the
	/// generated the data are integer numbers indicating which piece a
	/// particular point belongs to.
	/// </summary>
	public virtual int GetFieldData()
	{
		return vtkDicer_GetFieldData_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDicer_GetMemoryLimit_07(HandleRef pThis);

	/// <summary>
	/// Control piece size based on a memory limit.  (This ivar has
	/// effect only when the DiceMode is set to
	/// SetDiceModeToMemoryLimit()). The memory limit should be set in
	/// kibibytes (1024 bytes).
	/// </summary>
	public virtual uint GetMemoryLimit()
	{
		return vtkDicer_GetMemoryLimit_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDicer_GetMemoryLimitMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Control piece size based on a memory limit.  (This ivar has
	/// effect only when the DiceMode is set to
	/// SetDiceModeToMemoryLimit()). The memory limit should be set in
	/// kibibytes (1024 bytes).
	/// </summary>
	public virtual uint GetMemoryLimitMaxValue()
	{
		return vtkDicer_GetMemoryLimitMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDicer_GetMemoryLimitMinValue_09(HandleRef pThis);

	/// <summary>
	/// Control piece size based on a memory limit.  (This ivar has
	/// effect only when the DiceMode is set to
	/// SetDiceModeToMemoryLimit()). The memory limit should be set in
	/// kibibytes (1024 bytes).
	/// </summary>
	public virtual uint GetMemoryLimitMinValue()
	{
		return vtkDicer_GetMemoryLimitMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_GetNumberOfActualPieces_10(HandleRef pThis);

	/// <summary>
	/// Use the following method after the filter has updated to
	/// determine the actual number of pieces the data was separated
	/// into.
	/// </summary>
	public virtual int GetNumberOfActualPieces()
	{
		return vtkDicer_GetNumberOfActualPieces_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDicer_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDicer_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDicer_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDicer_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_GetNumberOfPieces_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of pieces the object is to be separated into.
	/// (This ivar has effect only when the DiceMode is set to
	/// SetDiceModeToSpecifiedNumber()). Note that the ivar
	/// NumberOfPieces is a target - depending on the particulars of the
	/// data, more or less number of pieces than the target value may be
	/// created.
	/// </summary>
	public virtual int GetNumberOfPieces()
	{
		return vtkDicer_GetNumberOfPieces_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_GetNumberOfPiecesMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of pieces the object is to be separated into.
	/// (This ivar has effect only when the DiceMode is set to
	/// SetDiceModeToSpecifiedNumber()). Note that the ivar
	/// NumberOfPieces is a target - depending on the particulars of the
	/// data, more or less number of pieces than the target value may be
	/// created.
	/// </summary>
	public virtual int GetNumberOfPiecesMaxValue()
	{
		return vtkDicer_GetNumberOfPiecesMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_GetNumberOfPiecesMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of pieces the object is to be separated into.
	/// (This ivar has effect only when the DiceMode is set to
	/// SetDiceModeToSpecifiedNumber()). Note that the ivar
	/// NumberOfPieces is a target - depending on the particulars of the
	/// data, more or less number of pieces than the target value may be
	/// created.
	/// </summary>
	public virtual int GetNumberOfPiecesMinValue()
	{
		return vtkDicer_GetNumberOfPiecesMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_GetNumberOfPointsPerPiece_16(HandleRef pThis);

	/// <summary>
	/// Control piece size based on the maximum number of points per piece.
	/// (This ivar has effect only when the DiceMode is set to
	/// SetDiceModeToNumberOfPoints().)
	/// </summary>
	public virtual int GetNumberOfPointsPerPiece()
	{
		return vtkDicer_GetNumberOfPointsPerPiece_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_GetNumberOfPointsPerPieceMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Control piece size based on the maximum number of points per piece.
	/// (This ivar has effect only when the DiceMode is set to
	/// SetDiceModeToNumberOfPoints().)
	/// </summary>
	public virtual int GetNumberOfPointsPerPieceMaxValue()
	{
		return vtkDicer_GetNumberOfPointsPerPieceMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_GetNumberOfPointsPerPieceMinValue_18(HandleRef pThis);

	/// <summary>
	/// Control piece size based on the maximum number of points per piece.
	/// (This ivar has effect only when the DiceMode is set to
	/// SetDiceModeToNumberOfPoints().)
	/// </summary>
	public virtual int GetNumberOfPointsPerPieceMinValue()
	{
		return vtkDicer_GetNumberOfPointsPerPieceMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDicer_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDicer_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDicer_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDicer_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDicer NewInstance()
	{
		vtkDicer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDicer_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDicer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDicer_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDicer SafeDownCast(vtkObjectBase o)
	{
		vtkDicer vtkDicer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDicer_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDicer2 = (vtkDicer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDicer2.Register(null);
			}
		}
		return vtkDicer2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDicer_SetDiceMode_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the method to determine how many pieces the data should be
	/// broken into. By default, the number of points per piece is used.
	/// </summary>
	public virtual void SetDiceMode(int _arg)
	{
		vtkDicer_SetDiceMode_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDicer_SetDiceModeToMemoryLimitPerPiece_24(HandleRef pThis);

	/// <summary>
	/// Specify the method to determine how many pieces the data should be
	/// broken into. By default, the number of points per piece is used.
	/// </summary>
	public void SetDiceModeToMemoryLimitPerPiece()
	{
		vtkDicer_SetDiceModeToMemoryLimitPerPiece_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDicer_SetDiceModeToNumberOfPointsPerPiece_25(HandleRef pThis);

	/// <summary>
	/// Specify the method to determine how many pieces the data should be
	/// broken into. By default, the number of points per piece is used.
	/// </summary>
	public void SetDiceModeToNumberOfPointsPerPiece()
	{
		vtkDicer_SetDiceModeToNumberOfPointsPerPiece_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDicer_SetDiceModeToSpecifiedNumberOfPieces_26(HandleRef pThis);

	/// <summary>
	/// Specify the method to determine how many pieces the data should be
	/// broken into. By default, the number of points per piece is used.
	/// </summary>
	public void SetDiceModeToSpecifiedNumberOfPieces()
	{
		vtkDicer_SetDiceModeToSpecifiedNumberOfPieces_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDicer_SetFieldData_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which controls whether to generate point scalar
	/// data or point field data. If this flag is off, scalar data is
	/// generated.  Otherwise, field data is generated. Note that the
	/// generated the data are integer numbers indicating which piece a
	/// particular point belongs to.
	/// </summary>
	public virtual void SetFieldData(int _arg)
	{
		vtkDicer_SetFieldData_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDicer_SetMemoryLimit_28(HandleRef pThis, uint _arg);

	/// <summary>
	/// Control piece size based on a memory limit.  (This ivar has
	/// effect only when the DiceMode is set to
	/// SetDiceModeToMemoryLimit()). The memory limit should be set in
	/// kibibytes (1024 bytes).
	/// </summary>
	public virtual void SetMemoryLimit(uint _arg)
	{
		vtkDicer_SetMemoryLimit_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDicer_SetNumberOfPieces_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of pieces the object is to be separated into.
	/// (This ivar has effect only when the DiceMode is set to
	/// SetDiceModeToSpecifiedNumber()). Note that the ivar
	/// NumberOfPieces is a target - depending on the particulars of the
	/// data, more or less number of pieces than the target value may be
	/// created.
	/// </summary>
	public virtual void SetNumberOfPieces(int _arg)
	{
		vtkDicer_SetNumberOfPieces_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDicer_SetNumberOfPointsPerPiece_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Control piece size based on the maximum number of points per piece.
	/// (This ivar has effect only when the DiceMode is set to
	/// SetDiceModeToNumberOfPoints().)
	/// </summary>
	public virtual void SetNumberOfPointsPerPiece(int _arg)
	{
		vtkDicer_SetNumberOfPointsPerPiece_30(GetCppThis(), _arg);
	}
}
