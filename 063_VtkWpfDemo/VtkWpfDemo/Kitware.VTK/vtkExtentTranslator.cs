using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtentTranslator
/// </summary>
/// <remarks>
///    Generates a structured extent from unstructured.
///
///
/// vtkExtentTranslator generates a structured extent from an unstructured
/// extent.  It uses a recursive scheme that splits the largest axis.  A hard
/// coded extent can be used for a starting point.
/// </remarks>
public class vtkExtentTranslator : vtkObject
{
	/// <summary>
	/// By default the translator creates N structured subextents by repeatedly
	/// splitting the largest current dimension until there are N pieces.
	/// If you do not want it always split the largest dimension, for instance when the
	/// shortest dimension is the slowest changing and thus least coherent in memory,
	/// use this to tell the translator which dimensions to split.
	/// </summary>
	public enum Modes
	{
		/// <summary>enum member</summary>
		BLOCK_MODE = 3,
		/// <summary>enum member</summary>
		X_SLAB_MODE = 0,
		/// <summary>enum member</summary>
		Y_SLAB_MODE = 1,
		/// <summary>enum member</summary>
		Z_SLAB_MODE = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtentTranslator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtentTranslator()
	{
		MRClassNameKey = "class vtkExtentTranslator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtentTranslator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtentTranslator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentTranslator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtentTranslator New()
	{
		vtkExtentTranslator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtentTranslator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtentTranslator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtentTranslator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentTranslator_GetExtent_01(HandleRef pThis);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual int[] GetExtent()
	{
		IntPtr intPtr = vtkExtentTranslator_GetExtent_01(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_GetExtent_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkExtentTranslator_GetExtent_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_GetExtent_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual void GetExtent(IntPtr _arg)
	{
		vtkExtentTranslator_GetExtent_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentTranslator_GetGhostLevel_04(HandleRef pThis);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual int GetGhostLevel()
	{
		return vtkExtentTranslator_GetGhostLevel_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtentTranslator_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtentTranslator_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtentTranslator_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtentTranslator_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentTranslator_GetNumberOfPieces_07(HandleRef pThis);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual int GetNumberOfPieces()
	{
		return vtkExtentTranslator_GetNumberOfPieces_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentTranslator_GetPiece_08(HandleRef pThis);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual int GetPiece()
	{
		return vtkExtentTranslator_GetPiece_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentTranslator_GetSplitMode_09(HandleRef pThis);

	/// <summary>
	/// How should the streamer break up extents. Block mode
	/// tries to break an extent up into cube blocks.  It always chooses
	/// the largest axis to split.
	/// Slab mode first breaks up the Z axis.  If it gets to one slice,
	/// then it starts breaking up other axes.
	/// </summary>
	public virtual int GetSplitMode()
	{
		return vtkExtentTranslator_GetSplitMode_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentTranslator_GetWholeExtent_10(HandleRef pThis);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual int[] GetWholeExtent()
	{
		IntPtr intPtr = vtkExtentTranslator_GetWholeExtent_10(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_GetWholeExtent_11(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkExtentTranslator_GetWholeExtent_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_GetWholeExtent_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual void GetWholeExtent(IntPtr _arg)
	{
		vtkExtentTranslator_GetWholeExtent_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentTranslator_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtentTranslator_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentTranslator_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtentTranslator_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentTranslator_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtentTranslator NewInstance()
	{
		vtkExtentTranslator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtentTranslator_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentTranslator_PieceToExtent_17(HandleRef pThis);

	/// <summary>
	/// These are the main methods that should be called. These methods
	/// are responsible for converting a piece to an extent. The signatures
	/// without arguments are only thread safe when each thread accesses a
	/// different instance. The signatures with arguments are fully thread
	/// safe.
	/// </summary>
	public virtual int PieceToExtent()
	{
		return vtkExtentTranslator_PieceToExtent_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentTranslator_PieceToExtentByPoints_18(HandleRef pThis);

	/// <summary>
	/// These are the main methods that should be called. These methods
	/// are responsible for converting a piece to an extent. The signatures
	/// without arguments are only thread safe when each thread accesses a
	/// different instance. The signatures with arguments are fully thread
	/// safe.
	/// </summary>
	public virtual int PieceToExtentByPoints()
	{
		return vtkExtentTranslator_PieceToExtentByPoints_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentTranslator_PieceToExtentThreadSafe_19(HandleRef pThis, int piece, int numPieces, int ghostLevel, IntPtr wholeExtent, IntPtr resultExtent, int splitMode, int byPoints);

	/// <summary>
	/// These are the main methods that should be called. These methods
	/// are responsible for converting a piece to an extent. The signatures
	/// without arguments are only thread safe when each thread accesses a
	/// different instance. The signatures with arguments are fully thread
	/// safe.
	/// </summary>
	public virtual int PieceToExtentThreadSafe(int piece, int numPieces, int ghostLevel, IntPtr wholeExtent, IntPtr resultExtent, int splitMode, int byPoints)
	{
		return vtkExtentTranslator_PieceToExtentThreadSafe_19(GetCppThis(), piece, numPieces, ghostLevel, wholeExtent, resultExtent, splitMode, byPoints);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentTranslator_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtentTranslator SafeDownCast(vtkObjectBase o)
	{
		vtkExtentTranslator vtkExtentTranslator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtentTranslator_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtentTranslator2 = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtentTranslator2.Register(null);
			}
		}
		return vtkExtentTranslator2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_SetExtent_21(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual void SetExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkExtentTranslator_SetExtent_21(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_SetExtent_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual void SetExtent(IntPtr _arg)
	{
		vtkExtentTranslator_SetExtent_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_SetGhostLevel_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual void SetGhostLevel(int _arg)
	{
		vtkExtentTranslator_SetGhostLevel_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_SetNumberOfPieces_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual void SetNumberOfPieces(int _arg)
	{
		vtkExtentTranslator_SetNumberOfPieces_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_SetPiece_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual void SetPiece(int _arg)
	{
		vtkExtentTranslator_SetPiece_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_SetSplitModeToBlock_26(HandleRef pThis);

	/// <summary>
	/// How should the streamer break up extents. Block mode
	/// tries to break an extent up into cube blocks.  It always chooses
	/// the largest axis to split.
	/// Slab mode first breaks up the Z axis.  If it gets to one slice,
	/// then it starts breaking up other axes.
	/// </summary>
	public void SetSplitModeToBlock()
	{
		vtkExtentTranslator_SetSplitModeToBlock_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_SetSplitModeToXSlab_27(HandleRef pThis);

	/// <summary>
	/// How should the streamer break up extents. Block mode
	/// tries to break an extent up into cube blocks.  It always chooses
	/// the largest axis to split.
	/// Slab mode first breaks up the Z axis.  If it gets to one slice,
	/// then it starts breaking up other axes.
	/// </summary>
	public void SetSplitModeToXSlab()
	{
		vtkExtentTranslator_SetSplitModeToXSlab_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_SetSplitModeToYSlab_28(HandleRef pThis);

	/// <summary>
	/// How should the streamer break up extents. Block mode
	/// tries to break an extent up into cube blocks.  It always chooses
	/// the largest axis to split.
	/// Slab mode first breaks up the Z axis.  If it gets to one slice,
	/// then it starts breaking up other axes.
	/// </summary>
	public void SetSplitModeToYSlab()
	{
		vtkExtentTranslator_SetSplitModeToYSlab_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_SetSplitModeToZSlab_29(HandleRef pThis);

	/// <summary>
	/// How should the streamer break up extents. Block mode
	/// tries to break an extent up into cube blocks.  It always chooses
	/// the largest axis to split.
	/// Slab mode first breaks up the Z axis.  If it gets to one slice,
	/// then it starts breaking up other axes.
	/// </summary>
	public void SetSplitModeToZSlab()
	{
		vtkExtentTranslator_SetSplitModeToZSlab_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_SetSplitPath_30(HandleRef pThis, int len, IntPtr splitpath);

	/// <summary>
	/// By default the translator creates N structured subextents by repeatedly
	/// splitting the largest current dimension until there are N pieces.
	/// If you do not want it always split the largest dimension, for instance when the
	/// shortest dimension is the slowest changing and thus least coherent in memory,
	/// use this to tell the translator which dimensions to split.
	/// </summary>
	public void SetSplitPath(int len, IntPtr splitpath)
	{
		vtkExtentTranslator_SetSplitPath_30(GetCppThis(), len, splitpath);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_SetWholeExtent_31(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkExtentTranslator_SetWholeExtent_31(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentTranslator_SetWholeExtent_32(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
	/// The result can be obtained from the Extent ivar.
	/// </summary>
	public virtual void SetWholeExtent(IntPtr _arg)
	{
		vtkExtentTranslator_SetWholeExtent_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentTranslator_UPDATE_SPLIT_MODE_33(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key used to request a particular split mode.
	/// This is used by vtkStreamingDemandDrivenPipeline.
	/// </summary>
	public static vtkInformationIntegerRequestKey UPDATE_SPLIT_MODE()
	{
		vtkInformationIntegerRequestKey vtkInformationIntegerRequestKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtentTranslator_UPDATE_SPLIT_MODE_33(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerRequestKey2 = (vtkInformationIntegerRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerRequestKey2.Register(null);
			}
		}
		return vtkInformationIntegerRequestKey2;
	}
}
