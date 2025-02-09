using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkThreadedImageAlgorithm
/// </summary>
/// <remarks>
///    Generic filter that has one input.
///
/// vtkThreadedImageAlgorithm is a filter superclass that hides much of the
/// pipeline complexity. It handles breaking the pipeline execution
/// into smaller extents so that the vtkImageData limits are observed. It
/// also provides support for multithreading. If you don't need any of this
/// functionality, consider using vtkSimpleImageToImageAlgorithm instead.
/// </remarks>
/// <seealso>
///
/// vtkSimpleImageToImageAlgorithm
/// </seealso>
public class vtkThreadedImageAlgorithm : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkThreadedImageAlgorithm";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkThreadedImageAlgorithm()
	{
		MRClassNameKey = "class vtkThreadedImageAlgorithm";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkThreadedImageAlgorithm"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkThreadedImageAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThreadedImageAlgorithm_GetDesiredBytesPerPiece_01(HandleRef pThis);

	/// <summary>
	/// The desired bytes per piece when volume is split for execution.
	/// When SMP is enabled, this is used to subdivide the volume into pieces.
	/// Smaller pieces allow for better dynamic load balancing, but increase
	/// the total overhead. The default is 65536 bytes.
	/// </summary>
	public virtual long GetDesiredBytesPerPiece()
	{
		return vtkThreadedImageAlgorithm_GetDesiredBytesPerPiece_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkThreadedImageAlgorithm_GetEnableSMP_02(HandleRef pThis);

	/// <summary>
	/// Enable/Disable SMP for threading.
	/// </summary>
	public virtual bool GetEnableSMP()
	{
		return (vtkThreadedImageAlgorithm_GetEnableSMP_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkThreadedImageAlgorithm_GetGlobalDefaultEnableSMP_03();

	/// <summary>
	/// Global Disable SMP for all derived Imaging filters.
	/// </summary>
	public static bool GetGlobalDefaultEnableSMP()
	{
		return (vtkThreadedImageAlgorithm_GetGlobalDefaultEnableSMP_03() != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThreadedImageAlgorithm_GetMinimumPieceSize_04(HandleRef pThis);

	/// <summary>
	/// The minimum piece size when volume is split for execution.
	/// By default, the minimum size is (16,1,1).
	/// </summary>
	public virtual int[] GetMinimumPieceSize()
	{
		IntPtr intPtr = vtkThreadedImageAlgorithm_GetMinimumPieceSize_04(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_GetMinimumPieceSize_05(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// The minimum piece size when volume is split for execution.
	/// By default, the minimum size is (16,1,1).
	/// </summary>
	public virtual void GetMinimumPieceSize(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkThreadedImageAlgorithm_GetMinimumPieceSize_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_GetMinimumPieceSize_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The minimum piece size when volume is split for execution.
	/// By default, the minimum size is (16,1,1).
	/// </summary>
	public virtual void GetMinimumPieceSize(IntPtr _arg)
	{
		vtkThreadedImageAlgorithm_GetMinimumPieceSize_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThreadedImageAlgorithm_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkThreadedImageAlgorithm_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThreadedImageAlgorithm_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkThreadedImageAlgorithm_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreadedImageAlgorithm_GetNumberOfThreads_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of threads to create when rendering.
	/// This is ignored if EnableSMP is On.
	/// </summary>
	public virtual int GetNumberOfThreads()
	{
		return vtkThreadedImageAlgorithm_GetNumberOfThreads_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreadedImageAlgorithm_GetNumberOfThreadsMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of threads to create when rendering.
	/// This is ignored if EnableSMP is On.
	/// </summary>
	public virtual int GetNumberOfThreadsMaxValue()
	{
		return vtkThreadedImageAlgorithm_GetNumberOfThreadsMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreadedImageAlgorithm_GetNumberOfThreadsMinValue_11(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of threads to create when rendering.
	/// This is ignored if EnableSMP is On.
	/// </summary>
	public virtual int GetNumberOfThreadsMinValue()
	{
		return vtkThreadedImageAlgorithm_GetNumberOfThreadsMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreadedImageAlgorithm_GetSplitMode_12(HandleRef pThis);

	/// <summary>
	/// Set the method used to divide the volume into pieces.
	/// Slab mode splits the volume along the Z direction first,
	/// Beam mode splits evenly along the Z and Y directions, and
	/// Block mode splits evenly along all three directions.
	/// Most filters use Slab mode as the default.
	/// </summary>
	public virtual int GetSplitMode()
	{
		return vtkThreadedImageAlgorithm_GetSplitMode_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreadedImageAlgorithm_GetSplitModeMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set the method used to divide the volume into pieces.
	/// Slab mode splits the volume along the Z direction first,
	/// Beam mode splits evenly along the Z and Y directions, and
	/// Block mode splits evenly along all three directions.
	/// Most filters use Slab mode as the default.
	/// </summary>
	public virtual int GetSplitModeMaxValue()
	{
		return vtkThreadedImageAlgorithm_GetSplitModeMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreadedImageAlgorithm_GetSplitModeMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set the method used to divide the volume into pieces.
	/// Slab mode splits the volume along the Z direction first,
	/// Beam mode splits evenly along the Z and Y directions, and
	/// Block mode splits evenly along all three directions.
	/// Most filters use Slab mode as the default.
	/// </summary>
	public virtual int GetSplitModeMinValue()
	{
		return vtkThreadedImageAlgorithm_GetSplitModeMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreadedImageAlgorithm_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkThreadedImageAlgorithm_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreadedImageAlgorithm_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkThreadedImageAlgorithm_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThreadedImageAlgorithm_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkThreadedImageAlgorithm NewInstance()
	{
		vtkThreadedImageAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThreadedImageAlgorithm_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThreadedImageAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThreadedImageAlgorithm_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThreadedImageAlgorithm SafeDownCast(vtkObjectBase o)
	{
		vtkThreadedImageAlgorithm vtkThreadedImageAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThreadedImageAlgorithm_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkThreadedImageAlgorithm2 = (vtkThreadedImageAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkThreadedImageAlgorithm2.Register(null);
			}
		}
		return vtkThreadedImageAlgorithm2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_SetDesiredBytesPerPiece_19(HandleRef pThis, long _arg);

	/// <summary>
	/// The desired bytes per piece when volume is split for execution.
	/// When SMP is enabled, this is used to subdivide the volume into pieces.
	/// Smaller pieces allow for better dynamic load balancing, but increase
	/// the total overhead. The default is 65536 bytes.
	/// </summary>
	public virtual void SetDesiredBytesPerPiece(long _arg)
	{
		vtkThreadedImageAlgorithm_SetDesiredBytesPerPiece_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_SetEnableSMP_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/Disable SMP for threading.
	/// </summary>
	public virtual void SetEnableSMP(bool _arg)
	{
		vtkThreadedImageAlgorithm_SetEnableSMP_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_SetGlobalDefaultEnableSMP_21(byte enable);

	/// <summary>
	/// Global Disable SMP for all derived Imaging filters.
	/// </summary>
	public static void SetGlobalDefaultEnableSMP(bool enable)
	{
		vtkThreadedImageAlgorithm_SetGlobalDefaultEnableSMP_21((byte)(enable ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_SetMinimumPieceSize_22(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// The minimum piece size when volume is split for execution.
	/// By default, the minimum size is (16,1,1).
	/// </summary>
	public virtual void SetMinimumPieceSize(int _arg1, int _arg2, int _arg3)
	{
		vtkThreadedImageAlgorithm_SetMinimumPieceSize_22(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_SetMinimumPieceSize_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The minimum piece size when volume is split for execution.
	/// By default, the minimum size is (16,1,1).
	/// </summary>
	public virtual void SetMinimumPieceSize(IntPtr _arg)
	{
		vtkThreadedImageAlgorithm_SetMinimumPieceSize_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_SetNumberOfThreads_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the number of threads to create when rendering.
	/// This is ignored if EnableSMP is On.
	/// </summary>
	public virtual void SetNumberOfThreads(int _arg)
	{
		vtkThreadedImageAlgorithm_SetNumberOfThreads_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_SetSplitMode_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the method used to divide the volume into pieces.
	/// Slab mode splits the volume along the Z direction first,
	/// Beam mode splits evenly along the Z and Y directions, and
	/// Block mode splits evenly along all three directions.
	/// Most filters use Slab mode as the default.
	/// </summary>
	public virtual void SetSplitMode(int _arg)
	{
		vtkThreadedImageAlgorithm_SetSplitMode_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_SetSplitModeToBeam_26(HandleRef pThis);

	/// <summary>
	/// Set the method used to divide the volume into pieces.
	/// Slab mode splits the volume along the Z direction first,
	/// Beam mode splits evenly along the Z and Y directions, and
	/// Block mode splits evenly along all three directions.
	/// Most filters use Slab mode as the default.
	/// </summary>
	public void SetSplitModeToBeam()
	{
		vtkThreadedImageAlgorithm_SetSplitModeToBeam_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_SetSplitModeToBlock_27(HandleRef pThis);

	/// <summary>
	/// Set the method used to divide the volume into pieces.
	/// Slab mode splits the volume along the Z direction first,
	/// Beam mode splits evenly along the Z and Y directions, and
	/// Block mode splits evenly along all three directions.
	/// Most filters use Slab mode as the default.
	/// </summary>
	public void SetSplitModeToBlock()
	{
		vtkThreadedImageAlgorithm_SetSplitModeToBlock_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_SetSplitModeToSlab_28(HandleRef pThis);

	/// <summary>
	/// Set the method used to divide the volume into pieces.
	/// Slab mode splits the volume along the Z direction first,
	/// Beam mode splits evenly along the Z and Y directions, and
	/// Block mode splits evenly along all three directions.
	/// Most filters use Slab mode as the default.
	/// </summary>
	public void SetSplitModeToSlab()
	{
		vtkThreadedImageAlgorithm_SetSplitModeToSlab_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreadedImageAlgorithm_SplitExtent_29(HandleRef pThis, IntPtr splitExt, IntPtr startExt, int num, int total);

	/// <summary>
	/// Putting this here until I merge graphics and imaging streaming.
	/// </summary>
	public virtual int SplitExtent(IntPtr splitExt, IntPtr startExt, int num, int total)
	{
		return vtkThreadedImageAlgorithm_SplitExtent_29(GetCppThis(), splitExt, startExt, num, total);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageAlgorithm_ThreadedExecute_30(HandleRef pThis, HandleRef inData, HandleRef outData, IntPtr extent, int threadId);

	/// <summary>
	/// If the subclass does not define an Execute method, then the task
	/// will be broken up, multiple threads will be spawned, and each thread
	/// will call this method. It is public so that the thread functions
	/// can call this method.
	/// </summary>
	public virtual void ThreadedExecute(vtkImageData inData, vtkImageData outData, IntPtr extent, int threadId)
	{
		vtkThreadedImageAlgorithm_ThreadedExecute_30(GetCppThis(), inData?.GetCppThis() ?? default(HandleRef), outData?.GetCppThis() ?? default(HandleRef), extent, threadId);
	}
}
