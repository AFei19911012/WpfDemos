using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkAMReXParticlesReader
/// </summary>
/// <remarks>
///  reader for AMReX plotfiles particle data.
///
/// vtkAMReXParticlesReader readers particle data from AMReX plotfiles. The
/// reader is based on the  `ParticleContainer::Restart` and
/// `amrex_binary_particles_to_vtp` files in the
/// [AMReX code](https://amrex-codes.github.io/).
///
/// The reader reads all levels in as blocks in output multiblock dataset
/// distributed datasets at each level between ranks in a contiguous fashion.
///
/// To use the reader, one must set the `PlotFileName` and `ParticleType` which
/// identifies the type particles from the PlotFileName to read.
///
/// The reader provides ability to select point data arrays to be made available
/// in the output. Note that due to the nature of the file structure, all
/// variables are still read in and hence deselecting arrays does not reduce I/O
/// calls or initial memory requirements.
/// </remarks>
public class vtkAMReXParticlesReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAMReXParticlesReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAMReXParticlesReader()
	{
		MRClassNameKey = "class vtkAMReXParticlesReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMReXParticlesReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAMReXParticlesReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMReXParticlesReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMReXParticlesReader New()
	{
		vtkAMReXParticlesReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMReXParticlesReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMReXParticlesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAMReXParticlesReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAMReXParticlesReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMReXParticlesReader_CanReadFile_01(string fname, string particlesType);

	/// <summary>
	/// Returns 1 is fname refers to a plotfile that the reader can read.
	/// </summary>
	public static int CanReadFile(string fname, string particlesType)
	{
		return vtkAMReXParticlesReader_CanReadFile_01(fname, particlesType);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMReXParticlesReader_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the controller to use. By default, the global
	/// vtkMultiProcessController will be used.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMReXParticlesReader_GetController_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkAMReXParticlesReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAMReXParticlesReader_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMReXParticlesReader_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAMReXParticlesReader_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkAMReXParticlesReader_GetParticleType_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the particle type to read. By default, this is set to 'particles'.
	/// </summary>
	public string GetParticleType()
	{
		return vtkAMReXParticlesReader_GetParticleType_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMReXParticlesReader_GetPlotFileName_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the AMReX plotfile. Note this is a directory on the filesystem and
	/// not the file.
	/// </summary>
	public string GetPlotFileName()
	{
		return Marshal.PtrToStringAnsi(vtkAMReXParticlesReader_GetPlotFileName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMReXParticlesReader_GetPointDataArraySelection_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get vtkDataArraySelection instance to select point arrays to read. Due to
	/// the nature of the AMReX particles files, all point data is read in from the
	/// disk, despite certain arrays unselected. The unselected arrays will be
	/// discarded from the generated output dataset.
	/// </summary>
	public vtkDataArraySelection GetPointDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMReXParticlesReader_GetPointDataArraySelection_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkAMReXParticlesReader_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAMReXParticlesReader_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMReXParticlesReader_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAMReXParticlesReader_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMReXParticlesReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAMReXParticlesReader NewInstance()
	{
		vtkAMReXParticlesReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMReXParticlesReader_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMReXParticlesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMReXParticlesReader_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMReXParticlesReader SafeDownCast(vtkObjectBase o)
	{
		vtkAMReXParticlesReader vtkAMReXParticlesReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMReXParticlesReader_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAMReXParticlesReader2 = (vtkAMReXParticlesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAMReXParticlesReader2.Register(null);
			}
		}
		return vtkAMReXParticlesReader2;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMReXParticlesReader_SetController_13(HandleRef pThis, HandleRef controller);

	/// <summary>
	/// Get/Set the controller to use. By default, the global
	/// vtkMultiProcessController will be used.
	/// </summary>
	public void SetController(vtkMultiProcessController controller)
	{
		vtkAMReXParticlesReader_SetController_13(GetCppThis(), controller?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMReXParticlesReader_SetParticleType_14(HandleRef pThis, string str);

	/// <summary>
	/// Get/Set the particle type to read. By default, this is set to 'particles'.
	/// </summary>
	public void SetParticleType(string str)
	{
		vtkAMReXParticlesReader_SetParticleType_14(GetCppThis(), str);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMReXParticlesReader_SetPlotFileName_15(HandleRef pThis, string fname);

	/// <summary>
	/// Get/Set the AMReX plotfile. Note this is a directory on the filesystem and
	/// not the file.
	/// </summary>
	public void SetPlotFileName(string fname)
	{
		vtkAMReXParticlesReader_SetPlotFileName_15(GetCppThis(), fname);
	}
}
