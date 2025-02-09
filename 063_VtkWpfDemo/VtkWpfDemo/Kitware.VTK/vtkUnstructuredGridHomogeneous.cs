using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridHomogeneousRayIntegrator
/// </summary>
/// <remarks>
///    performs piecewise constant ray integration.
///
///
///
/// vtkUnstructuredGridHomogeneousRayIntegrator performs homogeneous ray
/// integration.  This is a good method to use when volume rendering scalars
/// that are defined on cells.
///
/// </remarks>
public class vtkUnstructuredGridHomogeneousRayIntegrator : vtkUnstructuredGridVolumeRayIntegrator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridHomogeneousRayIntegrator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridHomogeneousRayIntegrator()
	{
		MRClassNameKey = "class vtkUnstructuredGridHomogeneousRayIntegrator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridHomogeneousRayIntegrator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridHomogeneousRayIntegrator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridHomogeneousRayIntegrator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridHomogeneousRayIntegrator New()
	{
		vtkUnstructuredGridHomogeneousRayIntegrator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridHomogeneousRayIntegrator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridHomogeneousRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUnstructuredGridHomogeneousRayIntegrator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUnstructuredGridHomogeneousRayIntegrator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridHomogeneousRayIntegrator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridHomogeneousRayIntegrator_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridHomogeneousRayIntegrator_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridHomogeneousRayIntegrator_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridHomogeneousRayIntegrator_GetTransferFunctionTableSize_03(HandleRef pThis);

	/// <summary>
	/// For quick lookup, the transfer function is sampled into a table.
	/// This parameter sets how big of a table to use.  By default, 1024
	/// entries are used.
	/// </summary>
	public virtual int GetTransferFunctionTableSize()
	{
		return vtkUnstructuredGridHomogeneousRayIntegrator_GetTransferFunctionTableSize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridHomogeneousRayIntegrator_Initialize_04(HandleRef pThis, HandleRef volume, HandleRef scalars);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Initialize(vtkVolume volume, vtkDataArray scalars)
	{
		vtkUnstructuredGridHomogeneousRayIntegrator_Initialize_04(GetCppThis(), volume?.GetCppThis() ?? default(HandleRef), scalars?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridHomogeneousRayIntegrator_Integrate_05(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
	{
		vtkUnstructuredGridHomogeneousRayIntegrator_Integrate_05(GetCppThis(), intersectionLengths?.GetCppThis() ?? default(HandleRef), nearIntersections?.GetCppThis() ?? default(HandleRef), farIntersections?.GetCppThis() ?? default(HandleRef), color);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridHomogeneousRayIntegrator_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridHomogeneousRayIntegrator_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridHomogeneousRayIntegrator_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridHomogeneousRayIntegrator_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridHomogeneousRayIntegrator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridHomogeneousRayIntegrator NewInstance()
	{
		vtkUnstructuredGridHomogeneousRayIntegrator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridHomogeneousRayIntegrator_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridHomogeneousRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridHomogeneousRayIntegrator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridHomogeneousRayIntegrator SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridHomogeneousRayIntegrator vtkUnstructuredGridHomogeneousRayIntegrator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridHomogeneousRayIntegrator_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridHomogeneousRayIntegrator2 = (vtkUnstructuredGridHomogeneousRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridHomogeneousRayIntegrator2.Register(null);
			}
		}
		return vtkUnstructuredGridHomogeneousRayIntegrator2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridHomogeneousRayIntegrator_SetTransferFunctionTableSize_11(HandleRef pThis, int _arg);

	/// <summary>
	/// For quick lookup, the transfer function is sampled into a table.
	/// This parameter sets how big of a table to use.  By default, 1024
	/// entries are used.
	/// </summary>
	public virtual void SetTransferFunctionTableSize(int _arg)
	{
		vtkUnstructuredGridHomogeneousRayIntegrator_SetTransferFunctionTableSize_11(GetCppThis(), _arg);
	}
}
