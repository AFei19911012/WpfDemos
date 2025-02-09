using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkJSONRenderWindowExporter
/// </summary>
/// <remarks>
///    Exports a render window for vtk-js
///
/// vtkJSONRenderWindowExporter constructs a scene graph from an input render
/// window and generates an archive for vtk-js. The traversal of the scene graph
/// topology is handled by graph elements constructed by vtkVtkJSViewNodeFactory,
/// the translation from VTK to vtk-js scene elements (renderers, actors,
/// mappers, etc.) is handled by vtkVtkJSSceneGraphSerializer, and the
/// transcription of data is handled by vtkArchiver. The latter two classes are
/// designed to be extensible via inheritance, and derived instances can be used
/// to modify the vtk-js file format and output mode.
///
///
/// </remarks>
/// <seealso>
///
/// vtkVtkJSSceneGraphSerializer vtkVtkJSViewNodeFactory
/// </seealso>
public class vtkJSONRenderWindowExporter : vtkExporter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkJSONRenderWindowExporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkJSONRenderWindowExporter()
	{
		MRClassNameKey = "class vtkJSONRenderWindowExporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkJSONRenderWindowExporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkJSONRenderWindowExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONRenderWindowExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkJSONRenderWindowExporter New()
	{
		vtkJSONRenderWindowExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONRenderWindowExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJSONRenderWindowExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkJSONRenderWindowExporter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkJSONRenderWindowExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkJSONRenderWindowExporter_CompactOutputOff_01(HandleRef pThis);

	/// <summary>
	/// Write scene in compact form (default is true).
	/// </summary>
	public virtual void CompactOutputOff()
	{
		vtkJSONRenderWindowExporter_CompactOutputOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONRenderWindowExporter_CompactOutputOn_02(HandleRef pThis);

	/// <summary>
	/// Write scene in compact form (default is true).
	/// </summary>
	public virtual void CompactOutputOn()
	{
		vtkJSONRenderWindowExporter_CompactOutputOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONRenderWindowExporter_GetArchiver_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the Archiver object
	/// </summary>
	public virtual vtkArchiver GetArchiver()
	{
		vtkArchiver vtkArchiver2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONRenderWindowExporter_GetArchiver_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArchiver2 = (vtkArchiver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArchiver2.Register(null);
			}
		}
		return vtkArchiver2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkJSONRenderWindowExporter_GetCompactOutput_04(HandleRef pThis);

	/// <summary>
	/// Write scene in compact form (default is true).
	/// </summary>
	public virtual bool GetCompactOutput()
	{
		return (vtkJSONRenderWindowExporter_GetCompactOutput_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJSONRenderWindowExporter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkJSONRenderWindowExporter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJSONRenderWindowExporter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkJSONRenderWindowExporter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONRenderWindowExporter_GetSerializer_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the Serializer object
	/// </summary>
	public virtual vtkVtkJSSceneGraphSerializer GetSerializer()
	{
		vtkVtkJSSceneGraphSerializer vtkVtkJSSceneGraphSerializer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONRenderWindowExporter_GetSerializer_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVtkJSSceneGraphSerializer2 = (vtkVtkJSSceneGraphSerializer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVtkJSSceneGraphSerializer2.Register(null);
			}
		}
		return vtkVtkJSSceneGraphSerializer2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJSONRenderWindowExporter_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkJSONRenderWindowExporter_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJSONRenderWindowExporter_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkJSONRenderWindowExporter_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONRenderWindowExporter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkJSONRenderWindowExporter NewInstance()
	{
		vtkJSONRenderWindowExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONRenderWindowExporter_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJSONRenderWindowExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONRenderWindowExporter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkJSONRenderWindowExporter SafeDownCast(vtkObjectBase o)
	{
		vtkJSONRenderWindowExporter vtkJSONRenderWindowExporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONRenderWindowExporter_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkJSONRenderWindowExporter2 = (vtkJSONRenderWindowExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkJSONRenderWindowExporter2.Register(null);
			}
		}
		return vtkJSONRenderWindowExporter2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONRenderWindowExporter_SetArchiver_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the Archiver object
	/// </summary>
	public virtual void SetArchiver(vtkArchiver arg0)
	{
		vtkJSONRenderWindowExporter_SetArchiver_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONRenderWindowExporter_SetCompactOutput_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// Write scene in compact form (default is true).
	/// </summary>
	public virtual void SetCompactOutput(bool _arg)
	{
		vtkJSONRenderWindowExporter_SetCompactOutput_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONRenderWindowExporter_SetSerializer_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the Serializer object
	/// </summary>
	public virtual void SetSerializer(vtkVtkJSSceneGraphSerializer arg0)
	{
		vtkJSONRenderWindowExporter_SetSerializer_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONRenderWindowExporter_WriteData_16(HandleRef pThis);

	/// <summary>
	/// Write scene data.
	/// </summary>
	public virtual void WriteData()
	{
		vtkJSONRenderWindowExporter_WriteData_16(GetCppThis());
	}
}
