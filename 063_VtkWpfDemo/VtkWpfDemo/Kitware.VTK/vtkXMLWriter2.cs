using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkXMLWriter2
/// </summary>
/// <remarks>
///  base class for new-style XML Writers
///
/// vtkXMLWriter2 is designed to eventually replace vtkXMLWriter. This class and
/// its subclasses model a simpler design for the XML writers that does not rely
/// on complex class hierarchy which can cumbersome to develop and debug.
///
/// vtkXMLWriter2 assumes parallel support. While MPI is not required,
/// vtkXMLWriter2 accesses vtkMultiProcessController and uses it to correctly
/// handle distributed execution. This avoids the need for having a parallel
/// variant of the writers as `vtkXMLWriter` hierarchy requires. This further
/// simplifies the development and debugging of these writers.
///
/// A typical XML writer may generate multiple artifacts all of which should be
/// cleaned up if the write fails. vtkXMLWriter2 provides API that the subclasses
/// can use to register such artifacts. If `RequestData` returns failure, then
/// all such artifacts are cleaned up.
/// </remarks>
public abstract class vtkXMLWriter2 : vtkXMLWriterBase
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLWriter2";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLWriter2()
	{
		MRClassNameKey = "class vtkXMLWriter2";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLWriter2"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLWriter2(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLWriter2_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the controller to use. By default, initialized to
	/// `vtkMultiProcessController::GetGlobalController`. The controller is used to
	/// determine which piece to request from upstream.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLWriter2_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLWriter2_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLWriter2_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLWriter2_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLWriter2_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriter2_GetNumberOfGhostLevels_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of ghost-levels to request from upstream pipeline.
	/// Default is 0. Note, this does not mean the output file will have as many
	/// ghost levels as requested. It's just a request. Whether the upstream
	/// pipeline can satisfy the request totally depends on the upstream pipeline
	/// itself.
	/// </summary>
	public virtual int GetNumberOfGhostLevels()
	{
		return vtkXMLWriter2_GetNumberOfGhostLevels_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriter2_GetNumberOfGhostLevelsMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of ghost-levels to request from upstream pipeline.
	/// Default is 0. Note, this does not mean the output file will have as many
	/// ghost levels as requested. It's just a request. Whether the upstream
	/// pipeline can satisfy the request totally depends on the upstream pipeline
	/// itself.
	/// </summary>
	public virtual int GetNumberOfGhostLevelsMaxValue()
	{
		return vtkXMLWriter2_GetNumberOfGhostLevelsMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriter2_GetNumberOfGhostLevelsMinValue_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of ghost-levels to request from upstream pipeline.
	/// Default is 0. Note, this does not mean the output file will have as many
	/// ghost levels as requested. It's just a request. Whether the upstream
	/// pipeline can satisfy the request totally depends on the upstream pipeline
	/// itself.
	/// </summary>
	public virtual int GetNumberOfGhostLevelsMinValue()
	{
		return vtkXMLWriter2_GetNumberOfGhostLevelsMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriter2_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLWriter2_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriter2_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLWriter2_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLWriter2_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLWriter2 NewInstance()
	{
		vtkXMLWriter2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLWriter2_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLWriter2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLWriter2_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLWriter2 SafeDownCast(vtkObjectBase o)
	{
		vtkXMLWriter2 vtkXMLWriter3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLWriter2_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLWriter3 = (vtkXMLWriter2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLWriter3.Register(null);
			}
		}
		return vtkXMLWriter3;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriter2_SetController_11(HandleRef pThis, HandleRef controller);

	/// <summary>
	/// Get/Set the controller to use. By default, initialized to
	/// `vtkMultiProcessController::GetGlobalController`. The controller is used to
	/// determine which piece to request from upstream.
	/// </summary>
	public void SetController(vtkMultiProcessController controller)
	{
		vtkXMLWriter2_SetController_11(GetCppThis(), controller?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriter2_SetNumberOfGhostLevels_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the number of ghost-levels to request from upstream pipeline.
	/// Default is 0. Note, this does not mean the output file will have as many
	/// ghost levels as requested. It's just a request. Whether the upstream
	/// pipeline can satisfy the request totally depends on the upstream pipeline
	/// itself.
	/// </summary>
	public virtual void SetNumberOfGhostLevels(int _arg)
	{
		vtkXMLWriter2_SetNumberOfGhostLevels_12(GetCppThis(), _arg);
	}
}
