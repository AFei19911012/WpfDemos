using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExecutableRunner
/// </summary>
/// <remarks>
///    Launch a process on the current machine and get its output
///
/// Launch a process on the current machine and get its standard output and
/// standard error output.
/// </remarks>
public class vtkExecutableRunner : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExecutableRunner";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExecutableRunner()
	{
		MRClassNameKey = "class vtkExecutableRunner";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExecutableRunner"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExecutableRunner(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutableRunner_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExecutableRunner New()
	{
		vtkExecutableRunner result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutableRunner_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExecutableRunner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExecutableRunner()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExecutableRunner_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExecutableRunner_Execute_01(HandleRef pThis);

	/// <summary>
	/// Execute the command currently set if any.
	/// This will update the StdOut and StdErr properties.
	/// </summary>
	public void Execute()
	{
		vtkExecutableRunner_Execute_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutableRunner_GetCommand_02(HandleRef pThis);

	/// <summary>
	/// Set/Get command to execute. An empty command will do nothing.
	/// </summary>
	public virtual string GetCommand()
	{
		return Marshal.PtrToStringAnsi(vtkExecutableRunner_GetCommand_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExecutableRunner_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExecutableRunner_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExecutableRunner_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExecutableRunner_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutableRunner_GetReturnValue_05(HandleRef pThis);

	/// <summary>
	/// Get return value of last command. If no command has been
	/// executed or if the command has failed in some way value is != 0,
	/// else return 0.
	/// </summary>
	public virtual int GetReturnValue()
	{
		return vtkExecutableRunner_GetReturnValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExecutableRunner_GetRightTrimResult_06(HandleRef pThis);

	/// <summary>
	/// Set/Get if we trim the ending whitespaces of the output.
	///
	/// Default is true.
	/// </summary>
	public virtual bool GetRightTrimResult()
	{
		return (vtkExecutableRunner_GetRightTrimResult_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutableRunner_GetStdErr_07(HandleRef pThis);

	/// <summary>
	/// Get output of the previously run command.
	/// </summary>
	public virtual string GetStdErr()
	{
		return Marshal.PtrToStringAnsi(vtkExecutableRunner_GetStdErr_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutableRunner_GetStdOut_08(HandleRef pThis);

	/// <summary>
	/// Get output of the previously run command.
	/// </summary>
	public virtual string GetStdOut()
	{
		return Marshal.PtrToStringAnsi(vtkExecutableRunner_GetStdOut_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExecutableRunner_GetTimeout_09(HandleRef pThis);

	/// <summary>
	/// Set/Get command timeout in seconds.  A non-positive (&lt;= 0) value will
	/// disable the timeout.
	///
	/// Default is 5
	/// </summary>
	public virtual double GetTimeout()
	{
		return vtkExecutableRunner_GetTimeout_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutableRunner_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExecutableRunner_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutableRunner_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExecutableRunner_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutableRunner_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExecutableRunner NewInstance()
	{
		vtkExecutableRunner result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutableRunner_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExecutableRunner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExecutableRunner_RightTrimResultOff_14(HandleRef pThis);

	/// <summary>
	/// Set/Get if we trim the ending whitespaces of the output.
	///
	/// Default is true.
	/// </summary>
	public virtual void RightTrimResultOff()
	{
		vtkExecutableRunner_RightTrimResultOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExecutableRunner_RightTrimResultOn_15(HandleRef pThis);

	/// <summary>
	/// Set/Get if we trim the ending whitespaces of the output.
	///
	/// Default is true.
	/// </summary>
	public virtual void RightTrimResultOn()
	{
		vtkExecutableRunner_RightTrimResultOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutableRunner_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExecutableRunner SafeDownCast(vtkObjectBase o)
	{
		vtkExecutableRunner vtkExecutableRunner2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutableRunner_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExecutableRunner2 = (vtkExecutableRunner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExecutableRunner2.Register(null);
			}
		}
		return vtkExecutableRunner2;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExecutableRunner_SetCommand_17(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get command to execute. An empty command will do nothing.
	/// </summary>
	public virtual void SetCommand(string arg)
	{
		vtkExecutableRunner_SetCommand_17(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExecutableRunner_SetRightTrimResult_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if we trim the ending whitespaces of the output.
	///
	/// Default is true.
	/// </summary>
	public virtual void SetRightTrimResult(bool _arg)
	{
		vtkExecutableRunner_SetRightTrimResult_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExecutableRunner_SetTimeout_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get command timeout in seconds.  A non-positive (&lt;= 0) value will
	/// disable the timeout.
	///
	/// Default is 5
	/// </summary>
	public virtual void SetTimeout(double _arg)
	{
		vtkExecutableRunner_SetTimeout_19(GetCppThis(), _arg);
	}
}
