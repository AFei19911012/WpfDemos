using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOverlappingAMRAlgorithm
/// </summary>
/// <remarks>
///    A base class for all algorithms that take as input vtkOverlappingAMR and
///  produce vtkOverlappingAMR.
/// </remarks>
public class vtkOverlappingAMRAlgorithm : vtkUniformGridAMRAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOverlappingAMRAlgorithm";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOverlappingAMRAlgorithm()
	{
		MRClassNameKey = "class vtkOverlappingAMRAlgorithm";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOverlappingAMRAlgorithm"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOverlappingAMRAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMRAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOverlappingAMRAlgorithm New()
	{
		vtkOverlappingAMRAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMRAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOverlappingAMRAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOverlappingAMRAlgorithm()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOverlappingAMRAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkOverlappingAMRAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOverlappingAMRAlgorithm_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOverlappingAMRAlgorithm_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOverlappingAMRAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMRAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm
	/// </summary>
	public new vtkOverlappingAMR GetOutput()
	{
		vtkOverlappingAMR vtkOverlappingAMR2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMRAlgorithm_GetOutput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOverlappingAMR2 = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOverlappingAMR2.Register(null);
			}
		}
		return vtkOverlappingAMR2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMRAlgorithm_GetOutput_04(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm
	/// </summary>
	public new vtkOverlappingAMR GetOutput(int arg0)
	{
		vtkOverlappingAMR vtkOverlappingAMR2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMRAlgorithm_GetOutput_04(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOverlappingAMR2 = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOverlappingAMR2.Register(null);
			}
		}
		return vtkOverlappingAMR2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOverlappingAMRAlgorithm_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOverlappingAMRAlgorithm_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOverlappingAMRAlgorithm_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOverlappingAMRAlgorithm_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMRAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOverlappingAMRAlgorithm NewInstance()
	{
		vtkOverlappingAMRAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMRAlgorithm_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOverlappingAMRAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMRAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOverlappingAMRAlgorithm SafeDownCast(vtkObjectBase o)
	{
		vtkOverlappingAMRAlgorithm vtkOverlappingAMRAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMRAlgorithm_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOverlappingAMRAlgorithm2 = (vtkOverlappingAMRAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOverlappingAMRAlgorithm2.Register(null);
			}
		}
		return vtkOverlappingAMRAlgorithm2;
	}
}
