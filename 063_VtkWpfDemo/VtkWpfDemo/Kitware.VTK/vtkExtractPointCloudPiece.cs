using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractPointCloudPiece
/// </summary>
/// <remarks>
///    Return a piece of a point cloud
///
/// This filter takes the output of a vtkHierarchicalBinningFilter and allows
/// the pipeline to stream it. Pieces are determined from an offset integral
/// array associated with the field data of the input.
/// </remarks>
public class vtkExtractPointCloudPiece : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractPointCloudPiece";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractPointCloudPiece()
	{
		MRClassNameKey = "class vtkExtractPointCloudPiece";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractPointCloudPiece"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractPointCloudPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractPointCloudPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static vtkExtractPointCloudPiece New()
	{
		vtkExtractPointCloudPiece result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractPointCloudPiece_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractPointCloudPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public vtkExtractPointCloudPiece()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractPointCloudPiece_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractPointCloudPiece_GetModuloOrdering_01(HandleRef pThis);

	/// <summary>
	/// Turn on or off modulo sampling of the points. By default this is on and the
	/// points in a given piece will be reordered in an attempt to reduce spatial
	/// coherency.
	/// </summary>
	public virtual bool GetModuloOrdering()
	{
		return (vtkExtractPointCloudPiece_GetModuloOrdering_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractPointCloudPiece_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractPointCloudPiece_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractPointCloudPiece_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractPointCloudPiece_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractPointCloudPiece_IsA_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractPointCloudPiece_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractPointCloudPiece_IsTypeOf_05(string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractPointCloudPiece_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPointCloudPiece_ModuloOrderingOff_06(HandleRef pThis);

	/// <summary>
	/// Turn on or off modulo sampling of the points. By default this is on and the
	/// points in a given piece will be reordered in an attempt to reduce spatial
	/// coherency.
	/// </summary>
	public virtual void ModuloOrderingOff()
	{
		vtkExtractPointCloudPiece_ModuloOrderingOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPointCloudPiece_ModuloOrderingOn_07(HandleRef pThis);

	/// <summary>
	/// Turn on or off modulo sampling of the points. By default this is on and the
	/// points in a given piece will be reordered in an attempt to reduce spatial
	/// coherency.
	/// </summary>
	public virtual void ModuloOrderingOn()
	{
		vtkExtractPointCloudPiece_ModuloOrderingOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractPointCloudPiece_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new vtkExtractPointCloudPiece NewInstance()
	{
		vtkExtractPointCloudPiece result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractPointCloudPiece_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractPointCloudPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractPointCloudPiece_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static vtkExtractPointCloudPiece SafeDownCast(vtkObjectBase o)
	{
		vtkExtractPointCloudPiece vtkExtractPointCloudPiece2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractPointCloudPiece_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractPointCloudPiece2 = (vtkExtractPointCloudPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractPointCloudPiece2.Register(null);
			}
		}
		return vtkExtractPointCloudPiece2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPointCloudPiece_SetModuloOrdering_11(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on or off modulo sampling of the points. By default this is on and the
	/// points in a given piece will be reordered in an attempt to reduce spatial
	/// coherency.
	/// </summary>
	public virtual void SetModuloOrdering(bool _arg)
	{
		vtkExtractPointCloudPiece_SetModuloOrdering_11(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
