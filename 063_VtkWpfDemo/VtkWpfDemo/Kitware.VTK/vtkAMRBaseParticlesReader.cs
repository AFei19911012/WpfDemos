using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAMRBaseParticlesReader
/// </summary>
/// <remarks>
///    An abstract base class that implements all the common functionality for
///  all particle readers.
/// </remarks>
public abstract class vtkAMRBaseParticlesReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAMRBaseParticlesReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAMRBaseParticlesReader()
	{
		MRClassNameKey = "class vtkAMRBaseParticlesReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRBaseParticlesReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAMRBaseParticlesReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseParticlesReader_FilterLocationOff_01(HandleRef pThis);

	/// <summary>
	/// Set &amp; Get for filter location and boolean macro
	/// </summary>
	public virtual void FilterLocationOff()
	{
		vtkAMRBaseParticlesReader_FilterLocationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseParticlesReader_FilterLocationOn_02(HandleRef pThis);

	/// <summary>
	/// Set &amp; Get for filter location and boolean macro
	/// </summary>
	public virtual void FilterLocationOn()
	{
		vtkAMRBaseParticlesReader_FilterLocationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseParticlesReader_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set &amp; Get the multi-process controller.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRBaseParticlesReader_GetController_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseParticlesReader_GetFileName_04(HandleRef pThis);

	/// <summary>
	/// Get/Set whether the particle array status.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkAMRBaseParticlesReader_GetFileName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseParticlesReader_GetFilterLocation_05(HandleRef pThis);

	/// <summary>
	/// Set &amp; Get for filter location and boolean macro
	/// </summary>
	public virtual int GetFilterLocation()
	{
		return vtkAMRBaseParticlesReader_GetFilterLocation_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseParticlesReader_GetFrequency_06(HandleRef pThis);

	/// <summary>
	/// Set &amp; Get the frequency.
	/// </summary>
	public virtual int GetFrequency()
	{
		return vtkAMRBaseParticlesReader_GetFrequency_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRBaseParticlesReader_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAMRBaseParticlesReader_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRBaseParticlesReader_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAMRBaseParticlesReader_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseParticlesReader_GetNumberOfParticleArrays_09(HandleRef pThis);

	/// <summary>
	/// Get the number of particles arrays available in the input.
	/// </summary>
	public int GetNumberOfParticleArrays()
	{
		return vtkAMRBaseParticlesReader_GetNumberOfParticleArrays_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseParticlesReader_GetParticleArrayName_10(HandleRef pThis, int index);

	/// <summary>
	/// Get the particle array name of the array associated with the given
	/// index.
	/// </summary>
	public string GetParticleArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkAMRBaseParticlesReader_GetParticleArrayName_10(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseParticlesReader_GetParticleArrayStatus_11(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the particle array status.
	/// </summary>
	public int GetParticleArrayStatus(string name)
	{
		return vtkAMRBaseParticlesReader_GetParticleArrayStatus_11(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseParticlesReader_GetParticleDataArraySelection_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data array selection tables used to configure which data
	/// arrays are loaded by the reader.
	/// </summary>
	public virtual vtkDataArraySelection GetParticleDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRBaseParticlesReader_GetParticleDataArraySelection_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseParticlesReader_GetTotalNumberOfParticles_13(HandleRef pThis);

	/// <summary>
	/// Returns the total number of particles
	/// </summary>
	public virtual int GetTotalNumberOfParticles()
	{
		return vtkAMRBaseParticlesReader_GetTotalNumberOfParticles_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseParticlesReader_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAMRBaseParticlesReader_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseParticlesReader_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAMRBaseParticlesReader_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseParticlesReader_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAMRBaseParticlesReader NewInstance()
	{
		vtkAMRBaseParticlesReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRBaseParticlesReader_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRBaseParticlesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseParticlesReader_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRBaseParticlesReader SafeDownCast(vtkObjectBase o)
	{
		vtkAMRBaseParticlesReader vtkAMRBaseParticlesReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRBaseParticlesReader_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAMRBaseParticlesReader2 = (vtkAMRBaseParticlesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAMRBaseParticlesReader2.Register(null);
			}
		}
		return vtkAMRBaseParticlesReader2;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseParticlesReader_SetController_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set &amp; Get the multi-process controller.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkAMRBaseParticlesReader_SetController_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseParticlesReader_SetFileName_19(HandleRef pThis, string fileName);

	/// <summary>
	/// Get/Set whether the particle array status.
	/// </summary>
	public virtual void SetFileName(string fileName)
	{
		vtkAMRBaseParticlesReader_SetFileName_19(GetCppThis(), fileName);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseParticlesReader_SetFilterLocation_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Set &amp; Get for filter location and boolean macro
	/// </summary>
	public virtual void SetFilterLocation(int _arg)
	{
		vtkAMRBaseParticlesReader_SetFilterLocation_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseParticlesReader_SetFrequency_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set &amp; Get the frequency.
	/// </summary>
	public virtual void SetFrequency(int _arg)
	{
		vtkAMRBaseParticlesReader_SetFrequency_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseParticlesReader_SetMaxLocation_22(HandleRef pThis, double maxx, double maxy, double maxz);

	/// <summary>
	/// Sets the max location
	/// </summary>
	public void SetMaxLocation(double maxx, double maxy, double maxz)
	{
		vtkAMRBaseParticlesReader_SetMaxLocation_22(GetCppThis(), maxx, maxy, maxz);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseParticlesReader_SetMinLocation_23(HandleRef pThis, double minx, double miny, double minz);

	/// <summary>
	/// Sets the min location
	/// </summary>
	public void SetMinLocation(double minx, double miny, double minz)
	{
		vtkAMRBaseParticlesReader_SetMinLocation_23(GetCppThis(), minx, miny, minz);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseParticlesReader_SetParticleArrayStatus_24(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the particle array status.
	/// </summary>
	public void SetParticleArrayStatus(string name, int status)
	{
		vtkAMRBaseParticlesReader_SetParticleArrayStatus_24(GetCppThis(), name, status);
	}
}
