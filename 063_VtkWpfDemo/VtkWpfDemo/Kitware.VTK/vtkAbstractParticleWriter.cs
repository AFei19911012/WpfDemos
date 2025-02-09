using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractParticleWriter
/// </summary>
/// <remarks>
///    abstract class to write particle data to file
///
/// vtkAbstractParticleWriter is an abstract class which is used by
/// vtkParticleTracerBase to write particles out during simulations.
/// This class is abstract and provides a TimeStep and FileName.
/// Subclasses of this should provide the necessary IO.
///
/// @warning
/// See vtkWriter
///
/// </remarks>
/// <seealso>
///
/// vtkParticleTracerBase
/// </seealso>
public abstract class vtkAbstractParticleWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractParticleWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractParticleWriter()
	{
		MRClassNameKey = "class vtkAbstractParticleWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractParticleWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractParticleWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractParticleWriter_CloseFile_01(HandleRef pThis);

	/// <summary>
	/// Close the file after a write. This is optional but
	/// may protect against data loss in between steps
	/// </summary>
	public virtual void CloseFile()
	{
		vtkAbstractParticleWriter_CloseFile_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractParticleWriter_GetCollectiveIO_02(HandleRef pThis);

	/// <summary>
	/// When running in parallel, this writer may be capable of
	/// Collective IO operations (HDF5). By default, this is off.
	/// </summary>
	public virtual int GetCollectiveIO()
	{
		return vtkAbstractParticleWriter_GetCollectiveIO_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractParticleWriter_GetFileName_03(HandleRef pThis);

	/// <summary>
	/// Set/get the FileName that is being written to
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkAbstractParticleWriter_GetFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractParticleWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractParticleWriter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractParticleWriter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractParticleWriter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractParticleWriter_GetTimeStep_06(HandleRef pThis);

	/// <summary>
	/// Set/get the TimeStep that is being written
	/// </summary>
	public virtual int GetTimeStep()
	{
		return vtkAbstractParticleWriter_GetTimeStep_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAbstractParticleWriter_GetTimeValue_07(HandleRef pThis);

	/// <summary>
	/// Before writing the current data out, set the TimeValue (optional)
	/// The TimeValue is a float/double value that corresponds to the real
	/// time of the data, it may not be regular, whereas the TimeSteps
	/// are simple increments.
	/// </summary>
	public virtual double GetTimeValue()
	{
		return vtkAbstractParticleWriter_GetTimeValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractParticleWriter_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractParticleWriter_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractParticleWriter_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractParticleWriter_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractParticleWriter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractParticleWriter NewInstance()
	{
		vtkAbstractParticleWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractParticleWriter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractParticleWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractParticleWriter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractParticleWriter SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractParticleWriter vtkAbstractParticleWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractParticleWriter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractParticleWriter2 = (vtkAbstractParticleWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractParticleWriter2.Register(null);
			}
		}
		return vtkAbstractParticleWriter2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractParticleWriter_SetCollectiveIO_12(HandleRef pThis, int _arg);

	/// <summary>
	/// When running in parallel, this writer may be capable of
	/// Collective IO operations (HDF5). By default, this is off.
	/// </summary>
	public virtual void SetCollectiveIO(int _arg)
	{
		vtkAbstractParticleWriter_SetCollectiveIO_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractParticleWriter_SetFileName_13(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the FileName that is being written to
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkAbstractParticleWriter_SetFileName_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractParticleWriter_SetTimeStep_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the TimeStep that is being written
	/// </summary>
	public virtual void SetTimeStep(int _arg)
	{
		vtkAbstractParticleWriter_SetTimeStep_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractParticleWriter_SetTimeValue_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Before writing the current data out, set the TimeValue (optional)
	/// The TimeValue is a float/double value that corresponds to the real
	/// time of the data, it may not be regular, whereas the TimeSteps
	/// are simple increments.
	/// </summary>
	public virtual void SetTimeValue(double _arg)
	{
		vtkAbstractParticleWriter_SetTimeValue_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractParticleWriter_SetWriteModeToCollective_16(HandleRef pThis);

	/// <summary>
	/// When running in parallel, this writer may be capable of
	/// Collective IO operations (HDF5). By default, this is off.
	/// </summary>
	public void SetWriteModeToCollective()
	{
		vtkAbstractParticleWriter_SetWriteModeToCollective_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractParticleWriter_SetWriteModeToIndependent_17(HandleRef pThis);

	/// <summary>
	/// When running in parallel, this writer may be capable of
	/// Collective IO operations (HDF5). By default, this is off.
	/// </summary>
	public void SetWriteModeToIndependent()
	{
		vtkAbstractParticleWriter_SetWriteModeToIndependent_17(GetCppThis());
	}
}
