using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIVExporter
/// </summary>
/// <remarks>
///    export a scene into OpenInventor 2.0 format.
///
/// vtkIVExporter is a concrete subclass of vtkExporter that writes
/// OpenInventor 2.0 files.
///
/// </remarks>
/// <seealso>
///
/// vtkExporter
/// </seealso>
public class vtkIVExporter : vtkExporter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIVExporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIVExporter()
	{
		MRClassNameKey = "class vtkIVExporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIVExporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIVExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIVExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIVExporter New()
	{
		vtkIVExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIVExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIVExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkIVExporter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIVExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIVExporter_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Specify the name of the OpenInventor file to write.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkIVExporter_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIVExporter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIVExporter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIVExporter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIVExporter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIVExporter_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIVExporter_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIVExporter_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIVExporter_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIVExporter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkIVExporter NewInstance()
	{
		vtkIVExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIVExporter_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIVExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIVExporter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIVExporter SafeDownCast(vtkObjectBase o)
	{
		vtkIVExporter vtkIVExporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIVExporter_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIVExporter2 = (vtkIVExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIVExporter2.Register(null);
			}
		}
		return vtkIVExporter2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIVExporter_SetFileName_09(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of the OpenInventor file to write.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkIVExporter_SetFileName_09(GetCppThis(), _arg);
	}
}
