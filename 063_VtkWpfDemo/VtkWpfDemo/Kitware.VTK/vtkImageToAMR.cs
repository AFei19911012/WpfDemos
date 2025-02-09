using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageToAMR
/// </summary>
/// <remarks>
///    filter to convert any vtkImageData to a
/// vtkOverlappingAMR.
///
/// vtkImageToAMR is a simple filter that converts any vtkImageData to a
/// vtkOverlappingAMR dataset. The input vtkImageData is treated as the highest
/// refinement available for the highest level. The lower refinements and the
/// number of blocks is controlled properties specified on the filter.
/// </remarks>
public class vtkImageToAMR : vtkOverlappingAMRAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageToAMR";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageToAMR()
	{
		MRClassNameKey = "class vtkImageToAMR";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageToAMR"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageToAMR(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageToAMR_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageToAMR New()
	{
		vtkImageToAMR result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageToAMR_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageToAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageToAMR()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageToAMR_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToAMR_GetMaximumNumberOfBlocks_01(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of blocks in the output
	/// </summary>
	public virtual int GetMaximumNumberOfBlocks()
	{
		return vtkImageToAMR_GetMaximumNumberOfBlocks_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToAMR_GetMaximumNumberOfBlocksMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of blocks in the output
	/// </summary>
	public virtual int GetMaximumNumberOfBlocksMaxValue()
	{
		return vtkImageToAMR_GetMaximumNumberOfBlocksMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToAMR_GetMaximumNumberOfBlocksMinValue_03(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of blocks in the output
	/// </summary>
	public virtual int GetMaximumNumberOfBlocksMinValue()
	{
		return vtkImageToAMR_GetMaximumNumberOfBlocksMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageToAMR_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageToAMR_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageToAMR_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageToAMR_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToAMR_GetNumberOfLevels_06(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of levels in the generated Overlapping-AMR.
	/// </summary>
	public virtual int GetNumberOfLevels()
	{
		return vtkImageToAMR_GetNumberOfLevels_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToAMR_GetNumberOfLevelsMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of levels in the generated Overlapping-AMR.
	/// </summary>
	public virtual int GetNumberOfLevelsMaxValue()
	{
		return vtkImageToAMR_GetNumberOfLevelsMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToAMR_GetNumberOfLevelsMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of levels in the generated Overlapping-AMR.
	/// </summary>
	public virtual int GetNumberOfLevelsMinValue()
	{
		return vtkImageToAMR_GetNumberOfLevelsMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToAMR_GetRefinementRatio_09(HandleRef pThis);

	/// <summary>
	/// Set the refinement ratio for levels. This refinement ratio is used for all
	/// levels.
	/// </summary>
	public virtual int GetRefinementRatio()
	{
		return vtkImageToAMR_GetRefinementRatio_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToAMR_GetRefinementRatioMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set the refinement ratio for levels. This refinement ratio is used for all
	/// levels.
	/// </summary>
	public virtual int GetRefinementRatioMaxValue()
	{
		return vtkImageToAMR_GetRefinementRatioMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToAMR_GetRefinementRatioMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set the refinement ratio for levels. This refinement ratio is used for all
	/// levels.
	/// </summary>
	public virtual int GetRefinementRatioMinValue()
	{
		return vtkImageToAMR_GetRefinementRatioMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToAMR_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageToAMR_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToAMR_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageToAMR_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageToAMR_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageToAMR NewInstance()
	{
		vtkImageToAMR result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageToAMR_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageToAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageToAMR_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageToAMR SafeDownCast(vtkObjectBase o)
	{
		vtkImageToAMR vtkImageToAMR2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageToAMR_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageToAMR2 = (vtkImageToAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageToAMR2.Register(null);
			}
		}
		return vtkImageToAMR2;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToAMR_SetMaximumNumberOfBlocks_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the maximum number of blocks in the output
	/// </summary>
	public virtual void SetMaximumNumberOfBlocks(int _arg)
	{
		vtkImageToAMR_SetMaximumNumberOfBlocks_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToAMR_SetNumberOfLevels_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the maximum number of levels in the generated Overlapping-AMR.
	/// </summary>
	public virtual void SetNumberOfLevels(int _arg)
	{
		vtkImageToAMR_SetNumberOfLevels_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToAMR_SetRefinementRatio_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the refinement ratio for levels. This refinement ratio is used for all
	/// levels.
	/// </summary>
	public virtual void SetRefinementRatio(int _arg)
	{
		vtkImageToAMR_SetRefinementRatio_19(GetCppThis(), _arg);
	}
}
