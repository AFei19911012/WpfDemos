using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkX3DExporter
/// </summary>
/// <remarks>
///    create an x3d file
///
/// vtkX3DExporter is a render window exporter which writes out the rendered
/// scene into an X3D file. X3D is an XML-based format for representation
/// 3D scenes (similar to VRML). Check out http://www.web3d.org/x3d/ for more
/// details.
/// @par Thanks:
/// X3DExporter is contributed by Christophe Mouton at EDF.
/// </remarks>
public class vtkX3DExporter : vtkExporter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkX3DExporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkX3DExporter()
	{
		MRClassNameKey = "class vtkX3DExporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkX3DExporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkX3DExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkX3DExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkX3DExporter New()
	{
		vtkX3DExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkX3DExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkX3DExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkX3DExporter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkX3DExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkX3DExporter_BinaryOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on binary mode
	/// </summary>
	public virtual void BinaryOff()
	{
		vtkX3DExporter_BinaryOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkX3DExporter_BinaryOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on binary mode
	/// </summary>
	public virtual void BinaryOn()
	{
		vtkX3DExporter_BinaryOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkX3DExporter_FastestOff_03(HandleRef pThis);

	/// <summary>
	/// In binary mode use fastest instead of best compression
	/// </summary>
	public virtual void FastestOff()
	{
		vtkX3DExporter_FastestOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkX3DExporter_FastestOn_04(HandleRef pThis);

	/// <summary>
	/// In binary mode use fastest instead of best compression
	/// </summary>
	public virtual void FastestOn()
	{
		vtkX3DExporter_FastestOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkX3DExporter_GetBinary_05(HandleRef pThis);

	/// <summary>
	/// Turn on binary mode
	/// </summary>
	public virtual int GetBinary()
	{
		return vtkX3DExporter_GetBinary_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkX3DExporter_GetBinaryMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Turn on binary mode
	/// </summary>
	public virtual int GetBinaryMaxValue()
	{
		return vtkX3DExporter_GetBinaryMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkX3DExporter_GetBinaryMinValue_07(HandleRef pThis);

	/// <summary>
	/// Turn on binary mode
	/// </summary>
	public virtual int GetBinaryMinValue()
	{
		return vtkX3DExporter_GetBinaryMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkX3DExporter_GetBinaryOutputString_08(HandleRef pThis);

	/// <summary>
	/// When WriteToOutputString in on, then a string is allocated, written to,
	/// and can be retrieved with these methods.  The string is deleted during
	/// the next call to write ...
	/// </summary>
	public IntPtr GetBinaryOutputString()
	{
		return vtkX3DExporter_GetBinaryOutputString_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkX3DExporter_GetFastest_09(HandleRef pThis);

	/// <summary>
	/// In binary mode use fastest instead of best compression
	/// </summary>
	public virtual int GetFastest()
	{
		return vtkX3DExporter_GetFastest_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkX3DExporter_GetFastestMaxValue_10(HandleRef pThis);

	/// <summary>
	/// In binary mode use fastest instead of best compression
	/// </summary>
	public virtual int GetFastestMaxValue()
	{
		return vtkX3DExporter_GetFastestMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkX3DExporter_GetFastestMinValue_11(HandleRef pThis);

	/// <summary>
	/// In binary mode use fastest instead of best compression
	/// </summary>
	public virtual int GetFastestMinValue()
	{
		return vtkX3DExporter_GetFastestMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkX3DExporter_GetFileName_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the output file name.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkX3DExporter_GetFileName_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkX3DExporter_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkX3DExporter_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkX3DExporter_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkX3DExporter_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkX3DExporter_GetOutputString_15(HandleRef pThis);

	/// <summary>
	/// When WriteToOutputString in on, then a string is allocated, written to,
	/// and can be retrieved with these methods.  The string is deleted during
	/// the next call to write ...
	/// </summary>
	public virtual string GetOutputString()
	{
		return Marshal.PtrToStringAnsi(vtkX3DExporter_GetOutputString_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkX3DExporter_GetOutputStringLength_16(HandleRef pThis);

	/// <summary>
	/// When WriteToOutputString in on, then a string is allocated, written to,
	/// and can be retrieved with these methods.  The string is deleted during
	/// the next call to write ...
	/// </summary>
	public virtual long GetOutputStringLength()
	{
		return vtkX3DExporter_GetOutputStringLength_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkX3DExporter_GetSpeed_17(HandleRef pThis);

	/// <summary>
	/// Specify the Speed of navigation. Default is 4.
	/// </summary>
	public virtual double GetSpeed()
	{
		return vtkX3DExporter_GetSpeed_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkX3DExporter_GetWriteToOutputString_18(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual int GetWriteToOutputString()
	{
		return vtkX3DExporter_GetWriteToOutputString_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkX3DExporter_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkX3DExporter_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkX3DExporter_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkX3DExporter_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkX3DExporter_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkX3DExporter NewInstance()
	{
		vtkX3DExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkX3DExporter_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkX3DExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkX3DExporter_RegisterAndGetOutputString_23(HandleRef pThis);

	/// <summary>
	/// This convenience method returns the string, sets the IVAR to nullptr,
	/// so that the user is responsible for deleting the string.
	/// I am not sure what the name should be, so it may change in the future.
	/// </summary>
	public string RegisterAndGetOutputString()
	{
		return Marshal.PtrToStringAnsi(vtkX3DExporter_RegisterAndGetOutputString_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkX3DExporter_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkX3DExporter SafeDownCast(vtkObjectBase o)
	{
		vtkX3DExporter vtkX3DExporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkX3DExporter_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkX3DExporter2 = (vtkX3DExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkX3DExporter2.Register(null);
			}
		}
		return vtkX3DExporter2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkX3DExporter_SetBinary_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on binary mode
	/// </summary>
	public virtual void SetBinary(int _arg)
	{
		vtkX3DExporter_SetBinary_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkX3DExporter_SetFastest_26(HandleRef pThis, int _arg);

	/// <summary>
	/// In binary mode use fastest instead of best compression
	/// </summary>
	public virtual void SetFastest(int _arg)
	{
		vtkX3DExporter_SetFastest_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkX3DExporter_SetFileName_27(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the output file name.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkX3DExporter_SetFileName_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkX3DExporter_SetSpeed_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the Speed of navigation. Default is 4.
	/// </summary>
	public virtual void SetSpeed(double _arg)
	{
		vtkX3DExporter_SetSpeed_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkX3DExporter_SetWriteToOutputString_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual void SetWriteToOutputString(int _arg)
	{
		vtkX3DExporter_SetWriteToOutputString_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkX3DExporter_WriteToOutputStringOff_30(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual void WriteToOutputStringOff()
	{
		vtkX3DExporter_WriteToOutputStringOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkX3DExporter_WriteToOutputStringOn_31(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual void WriteToOutputStringOn()
	{
		vtkX3DExporter_WriteToOutputStringOn_31(GetCppThis());
	}
}
