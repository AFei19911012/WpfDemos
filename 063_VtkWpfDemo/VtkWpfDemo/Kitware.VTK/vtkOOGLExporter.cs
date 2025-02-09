using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOOGLExporter
/// </summary>
/// <remarks>
///    export a scene into Geomview OOGL format.
///
/// vtkOOGLExporter is a concrete subclass of vtkExporter that writes
/// Geomview OOGL files.
///
/// </remarks>
/// <seealso>
///
/// vtkExporter
/// </seealso>
public class vtkOOGLExporter : vtkExporter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOOGLExporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOOGLExporter()
	{
		MRClassNameKey = "class vtkOOGLExporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOOGLExporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOOGLExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOOGLExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOOGLExporter New()
	{
		vtkOOGLExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOOGLExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOOGLExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOOGLExporter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOOGLExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkOOGLExporter_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Specify the name of the Geomview file to write.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkOOGLExporter_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOOGLExporter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOOGLExporter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOOGLExporter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOOGLExporter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOOGLExporter_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOOGLExporter_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOOGLExporter_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOOGLExporter_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOOGLExporter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOOGLExporter NewInstance()
	{
		vtkOOGLExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOOGLExporter_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOOGLExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOOGLExporter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOOGLExporter SafeDownCast(vtkObjectBase o)
	{
		vtkOOGLExporter vtkOOGLExporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOOGLExporter_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOOGLExporter2 = (vtkOOGLExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOOGLExporter2.Register(null);
			}
		}
		return vtkOOGLExporter2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOOGLExporter_SetFileName_09(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of the Geomview file to write.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkOOGLExporter_SetFileName_09(GetCppThis(), _arg);
	}
}
