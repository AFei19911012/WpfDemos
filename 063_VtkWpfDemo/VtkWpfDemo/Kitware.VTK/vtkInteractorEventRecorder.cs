using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorEventRecorder
/// </summary>
/// <remarks>
///    record and play VTK events passing through a vtkRenderWindowInteractor
///
///
/// vtkInteractorEventRecorder records all VTK events invoked from a
/// vtkRenderWindowInteractor. The events are recorded to a
/// file. vtkInteractorEventRecorder can also be used to play those events
/// back and invoke them on an vtkRenderWindowInteractor. (Note: the events
/// can also be played back from a file or string.)
///
/// Event client data can be recorded as args and will be provided on replay.
/// The following event current support data to be recorded:
///  - DropFilesEvents: record a string array
///
/// The format of the event file is simple. It is:
///  EventName X Y ctrl shift keycode repeatCount keySym dataType [dataNum] [dataVal] [dataVal]
/// The format also allows "#" comments.
/// dataType is defined as follows:
///  - 0 -&gt; None
///  - 1 -&gt; StringArray
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorObserver vtkCallback
/// </seealso>
public class vtkInteractorEventRecorder : vtkInteractorObserver
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum vtkEventDataType
	{
		/// <summary>enum member</summary>
		None,
		/// <summary>enum member</summary>
		StringArray
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorEventRecorder";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorEventRecorder()
	{
		MRClassNameKey = "class vtkInteractorEventRecorder";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorEventRecorder"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorEventRecorder(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorEventRecorder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorEventRecorder New()
	{
		vtkInteractorEventRecorder result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorEventRecorder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorEventRecorder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorEventRecorder()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorEventRecorder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorEventRecorder_Clear_01(HandleRef pThis);

	/// <summary>
	/// Invoke this method to clear recording/playing stream and be able to open
	/// another file using the same recorder.
	/// </summary>
	public void Clear()
	{
		vtkInteractorEventRecorder_Clear_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorEventRecorder_GetFileName_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of a file events should be written to/from.
	/// Will be ignored once record/play has been called.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkInteractorEventRecorder_GetFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorEventRecorder_GetInputString_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the string to read from.
	/// </summary>
	public virtual string GetInputString()
	{
		return Marshal.PtrToStringAnsi(vtkInteractorEventRecorder_GetInputString_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorEventRecorder_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorEventRecorder_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorEventRecorder_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorEventRecorder_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorEventRecorder_GetReadFromInputString_06(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString as compared to the default
	/// behavior, which is to read from a file.
	/// </summary>
	public virtual int GetReadFromInputString()
	{
		return vtkInteractorEventRecorder_GetReadFromInputString_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorEventRecorder_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorEventRecorder_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorEventRecorder_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorEventRecorder_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorEventRecorder_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorEventRecorder NewInstance()
	{
		vtkInteractorEventRecorder result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorEventRecorder_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorEventRecorder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorEventRecorder_Play_11(HandleRef pThis);

	/// <summary>
	/// Invoke this method to begin playing events from the current position.
	/// The events will be played back from the filename indicated.
	/// Once play has been called once, filename will be ignored.
	/// </summary>
	public void Play()
	{
		vtkInteractorEventRecorder_Play_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorEventRecorder_ReadFromInputStringOff_12(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString as compared to the default
	/// behavior, which is to read from a file.
	/// </summary>
	public virtual void ReadFromInputStringOff()
	{
		vtkInteractorEventRecorder_ReadFromInputStringOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorEventRecorder_ReadFromInputStringOn_13(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString as compared to the default
	/// behavior, which is to read from a file.
	/// </summary>
	public virtual void ReadFromInputStringOn()
	{
		vtkInteractorEventRecorder_ReadFromInputStringOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorEventRecorder_Record_14(HandleRef pThis);

	/// <summary>
	/// Invoke this method to begin recording events. The events will be
	/// recorded to the filename indicated.
	/// Once record has been called once, filename will be ignored.
	/// </summary>
	public void Record()
	{
		vtkInteractorEventRecorder_Record_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorEventRecorder_Rewind_15(HandleRef pThis);

	/// <summary>
	/// Rewind the play stream to the beginning of the file.
	/// </summary>
	public void Rewind()
	{
		vtkInteractorEventRecorder_Rewind_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorEventRecorder_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorEventRecorder SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorEventRecorder vtkInteractorEventRecorder2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorEventRecorder_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorEventRecorder2 = (vtkInteractorEventRecorder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorEventRecorder2.Register(null);
			}
		}
		return vtkInteractorEventRecorder2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorEventRecorder_SetEnabled_17(HandleRef pThis, int arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkInteractorEventRecorder_SetEnabled_17(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorEventRecorder_SetFileName_18(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of a file events should be written to/from.
	/// Will be ignored once record/play has been called.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkInteractorEventRecorder_SetFileName_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorEventRecorder_SetInputString_19(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the string to read from.
	/// </summary>
	public virtual void SetInputString(string _arg)
	{
		vtkInteractorEventRecorder_SetInputString_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorEventRecorder_SetInteractor_20(HandleRef pThis, HandleRef iren);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void SetInteractor(vtkRenderWindowInteractor iren)
	{
		vtkInteractorEventRecorder_SetInteractor_20(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorEventRecorder_SetReadFromInputString_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable reading from an InputString as compared to the default
	/// behavior, which is to read from a file.
	/// </summary>
	public virtual void SetReadFromInputString(int _arg)
	{
		vtkInteractorEventRecorder_SetReadFromInputString_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorEventRecorder_Stop_22(HandleRef pThis);

	/// <summary>
	/// Invoke this method to stop recording/playing events.
	/// </summary>
	public void Stop()
	{
		vtkInteractorEventRecorder_Stop_22(GetCppThis());
	}
}
