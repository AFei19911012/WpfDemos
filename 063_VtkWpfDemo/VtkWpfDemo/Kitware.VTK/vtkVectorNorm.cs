using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVectorNorm
/// </summary>
/// <remarks>
///    generate scalars from Euclidean norm of vectors
///
/// vtkVectorNorm is a filter that generates scalar values by computing
/// Euclidean norm of vector triplets. Scalars can be normalized
/// 0&lt;=s&lt;=1 if desired.
///
/// Note that this filter operates on point or cell attribute data, or
/// both.  By default, the filter operates on both point and cell data
/// if vector point and cell data, respectively, are available from the
/// input. Alternatively, you can choose to generate scalar norm values
/// for just cell or point data.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
/// </remarks>
public class vtkVectorNorm : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVectorNorm";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVectorNorm()
	{
		MRClassNameKey = "class vtkVectorNorm";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVectorNorm"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVectorNorm(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVectorNorm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with normalize flag off.
	/// </summary>
	public new static vtkVectorNorm New()
	{
		vtkVectorNorm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVectorNorm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVectorNorm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with normalize flag off.
	/// </summary>
	public vtkVectorNorm()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVectorNorm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVectorNorm_GetAttributeMode_01(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate scalar data from the
	/// input vector data. By default, (AttributeModeToDefault) the
	/// filter will generate the scalar norm for point and cell data (if
	/// vector data present in the input). Alternatively, you can
	/// explicitly set the filter to generate point data
	/// (AttributeModeToUsePointData) or cell data
	/// (AttributeModeToUseCellData).
	/// </summary>
	public virtual int GetAttributeMode()
	{
		return vtkVectorNorm_GetAttributeMode_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVectorNorm_GetAttributeModeAsString_02(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate scalar data from the
	/// input vector data. By default, (AttributeModeToDefault) the
	/// filter will generate the scalar norm for point and cell data (if
	/// vector data present in the input). Alternatively, you can
	/// explicitly set the filter to generate point data
	/// (AttributeModeToUsePointData) or cell data
	/// (AttributeModeToUseCellData).
	/// </summary>
	public string GetAttributeModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkVectorNorm_GetAttributeModeAsString_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVectorNorm_GetNormalize_03(HandleRef pThis);

	/// <summary>
	/// Construct with normalize flag off.
	/// </summary>
	public virtual int GetNormalize()
	{
		return vtkVectorNorm_GetNormalize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVectorNorm_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVectorNorm_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVectorNorm_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVectorNorm_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVectorNorm_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVectorNorm_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVectorNorm_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVectorNorm_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVectorNorm_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVectorNorm NewInstance()
	{
		vtkVectorNorm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVectorNorm_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVectorNorm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorNorm_NormalizeOff_10(HandleRef pThis);

	/// <summary>
	/// Construct with normalize flag off.
	/// </summary>
	public virtual void NormalizeOff()
	{
		vtkVectorNorm_NormalizeOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorNorm_NormalizeOn_11(HandleRef pThis);

	/// <summary>
	/// Construct with normalize flag off.
	/// </summary>
	public virtual void NormalizeOn()
	{
		vtkVectorNorm_NormalizeOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVectorNorm_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVectorNorm SafeDownCast(vtkObjectBase o)
	{
		vtkVectorNorm vtkVectorNorm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVectorNorm_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVectorNorm2 = (vtkVectorNorm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVectorNorm2.Register(null);
			}
		}
		return vtkVectorNorm2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorNorm_SetAttributeMode_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the filter works to generate scalar data from the
	/// input vector data. By default, (AttributeModeToDefault) the
	/// filter will generate the scalar norm for point and cell data (if
	/// vector data present in the input). Alternatively, you can
	/// explicitly set the filter to generate point data
	/// (AttributeModeToUsePointData) or cell data
	/// (AttributeModeToUseCellData).
	/// </summary>
	public virtual void SetAttributeMode(int _arg)
	{
		vtkVectorNorm_SetAttributeMode_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorNorm_SetAttributeModeToDefault_14(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate scalar data from the
	/// input vector data. By default, (AttributeModeToDefault) the
	/// filter will generate the scalar norm for point and cell data (if
	/// vector data present in the input). Alternatively, you can
	/// explicitly set the filter to generate point data
	/// (AttributeModeToUsePointData) or cell data
	/// (AttributeModeToUseCellData).
	/// </summary>
	public void SetAttributeModeToDefault()
	{
		vtkVectorNorm_SetAttributeModeToDefault_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorNorm_SetAttributeModeToUseCellData_15(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate scalar data from the
	/// input vector data. By default, (AttributeModeToDefault) the
	/// filter will generate the scalar norm for point and cell data (if
	/// vector data present in the input). Alternatively, you can
	/// explicitly set the filter to generate point data
	/// (AttributeModeToUsePointData) or cell data
	/// (AttributeModeToUseCellData).
	/// </summary>
	public void SetAttributeModeToUseCellData()
	{
		vtkVectorNorm_SetAttributeModeToUseCellData_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorNorm_SetAttributeModeToUsePointData_16(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate scalar data from the
	/// input vector data. By default, (AttributeModeToDefault) the
	/// filter will generate the scalar norm for point and cell data (if
	/// vector data present in the input). Alternatively, you can
	/// explicitly set the filter to generate point data
	/// (AttributeModeToUsePointData) or cell data
	/// (AttributeModeToUseCellData).
	/// </summary>
	public void SetAttributeModeToUsePointData()
	{
		vtkVectorNorm_SetAttributeModeToUsePointData_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorNorm_SetNormalize_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Construct with normalize flag off.
	/// </summary>
	public virtual void SetNormalize(int _arg)
	{
		vtkVectorNorm_SetNormalize_17(GetCppThis(), _arg);
	}
}
