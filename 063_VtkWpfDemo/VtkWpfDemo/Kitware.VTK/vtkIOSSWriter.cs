using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkIOSSWriter
/// </summary>
/// <remarks>
///  writer using IOSS
///
/// vtkIOSSWriter is a writer to write datasets using IOSS library. Currently
/// this writer supports writing Exodus files. This writer is a work in progress
/// and currently only supports targeted use-cases. The writer will be
/// iteratively cleaned up and fixed to support all types of incoming datasets.
/// </remarks>
public class vtkIOSSWriter : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIOSSWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIOSSWriter()
	{
		MRClassNameKey = "class vtkIOSSWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIOSSWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIOSSWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIOSSWriter New()
	{
		vtkIOSSWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIOSSWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkIOSSWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIOSSWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSWriter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the controller to use when working in parallel. Initialized to
	/// `vtkMultiProcessController::GetGlobalController` in the constructor.
	///
	/// The controller is used to determine the upstream piece request in
	/// RequestUpdateExtent.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSWriter_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIOSSWriter_GetDisplacementMagnitude_02(HandleRef pThis);

	/// <summary>
	/// If input dataset has displacements pre-applied, setting the displacement
	/// magnitude to non-zero ensures that the point coordinates in the dataset are
	/// correctly transformed using the displacement field array, if present.
	///
	/// Defaults to 1.0.
	/// </summary>
	public virtual double GetDisplacementMagnitude()
	{
		return vtkIOSSWriter_GetDisplacementMagnitude_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIOSSWriter_GetDisplacementMagnitudeMaxValue_03(HandleRef pThis);

	/// <summary>
	/// If input dataset has displacements pre-applied, setting the displacement
	/// magnitude to non-zero ensures that the point coordinates in the dataset are
	/// correctly transformed using the displacement field array, if present.
	///
	/// Defaults to 1.0.
	/// </summary>
	public virtual double GetDisplacementMagnitudeMaxValue()
	{
		return vtkIOSSWriter_GetDisplacementMagnitudeMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIOSSWriter_GetDisplacementMagnitudeMinValue_04(HandleRef pThis);

	/// <summary>
	/// If input dataset has displacements pre-applied, setting the displacement
	/// magnitude to non-zero ensures that the point coordinates in the dataset are
	/// correctly transformed using the displacement field array, if present.
	///
	/// Defaults to 1.0.
	/// </summary>
	public virtual double GetDisplacementMagnitudeMinValue()
	{
		return vtkIOSSWriter_GetDisplacementMagnitudeMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSWriter_GetFileName_05(HandleRef pThis);

	/// <summary>
	/// Get/set the filename. When writing in a distributed environment, the
	/// actual filename written out may be different.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkIOSSWriter_GetFileName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSWriter_GetMaximumTimeStepsPerFile_06(HandleRef pThis);

	/// <summary>
	/// A debugging variable, set this to non-zero positive number to save at most
	/// the specified number of timesteps in a single file before starting a new
	/// one. The writer may start new files (aka restarts) automatically if it
	/// determines that the mesh has changed.
	///
	/// Defaults to 0 i.e. unlimited timesteps per file.
	/// </summary>
	public virtual int GetMaximumTimeStepsPerFile()
	{
		return vtkIOSSWriter_GetMaximumTimeStepsPerFile_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSWriter_GetMaximumTimeStepsPerFileMaxValue_07(HandleRef pThis);

	/// <summary>
	/// A debugging variable, set this to non-zero positive number to save at most
	/// the specified number of timesteps in a single file before starting a new
	/// one. The writer may start new files (aka restarts) automatically if it
	/// determines that the mesh has changed.
	///
	/// Defaults to 0 i.e. unlimited timesteps per file.
	/// </summary>
	public virtual int GetMaximumTimeStepsPerFileMaxValue()
	{
		return vtkIOSSWriter_GetMaximumTimeStepsPerFileMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSWriter_GetMaximumTimeStepsPerFileMinValue_08(HandleRef pThis);

	/// <summary>
	/// A debugging variable, set this to non-zero positive number to save at most
	/// the specified number of timesteps in a single file before starting a new
	/// one. The writer may start new files (aka restarts) automatically if it
	/// determines that the mesh has changed.
	///
	/// Defaults to 0 i.e. unlimited timesteps per file.
	/// </summary>
	public virtual int GetMaximumTimeStepsPerFileMinValue()
	{
		return vtkIOSSWriter_GetMaximumTimeStepsPerFileMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIOSSWriter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIOSSWriter_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIOSSWriter_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIOSSWriter_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSWriter_GetOffsetGlobalIds_11(HandleRef pThis);

	/// <summary>
	/// Exodus wants global ids to start with 1, while VTK generally produces
	/// global ids starting with 0. Set this to true (default false), if the global
	/// ids are generated by VTK and hence start with 0. When writing to the output
	/// file, they will be offset by 1 to ensure the ids are valid exodus ids.
	/// </summary>
	public virtual bool GetOffsetGlobalIds()
	{
		return (vtkIOSSWriter_GetOffsetGlobalIds_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSWriter_GetPreserveInputEntityGroups_12(HandleRef pThis);

	/// <summary>
	/// If input is untransformed IOSS dataset, then the writer can preserve entity
	/// group classifications, such as element blocks, side sets etc. The same is
	/// not true if the input has been transformed e.g. through a clip filter. Thus
	/// flag is used to indicate whether the input has valid element
	/// classifications.
	/// </summary>
	public virtual bool GetPreserveInputEntityGroups()
	{
		return (vtkIOSSWriter_GetPreserveInputEntityGroups_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSWriter_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIOSSWriter_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSWriter_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIOSSWriter_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSWriter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkIOSSWriter NewInstance()
	{
		vtkIOSSWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSWriter_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIOSSWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSWriter_OffsetGlobalIdsOff_17(HandleRef pThis);

	/// <summary>
	/// Exodus wants global ids to start with 1, while VTK generally produces
	/// global ids starting with 0. Set this to true (default false), if the global
	/// ids are generated by VTK and hence start with 0. When writing to the output
	/// file, they will be offset by 1 to ensure the ids are valid exodus ids.
	/// </summary>
	public virtual void OffsetGlobalIdsOff()
	{
		vtkIOSSWriter_OffsetGlobalIdsOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSWriter_OffsetGlobalIdsOn_18(HandleRef pThis);

	/// <summary>
	/// Exodus wants global ids to start with 1, while VTK generally produces
	/// global ids starting with 0. Set this to true (default false), if the global
	/// ids are generated by VTK and hence start with 0. When writing to the output
	/// file, they will be offset by 1 to ensure the ids are valid exodus ids.
	/// </summary>
	public virtual void OffsetGlobalIdsOn()
	{
		vtkIOSSWriter_OffsetGlobalIdsOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSWriter_PreserveInputEntityGroupsOff_19(HandleRef pThis);

	/// <summary>
	/// If input is untransformed IOSS dataset, then the writer can preserve entity
	/// group classifications, such as element blocks, side sets etc. The same is
	/// not true if the input has been transformed e.g. through a clip filter. Thus
	/// flag is used to indicate whether the input has valid element
	/// classifications.
	/// </summary>
	public virtual void PreserveInputEntityGroupsOff()
	{
		vtkIOSSWriter_PreserveInputEntityGroupsOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSWriter_PreserveInputEntityGroupsOn_20(HandleRef pThis);

	/// <summary>
	/// If input is untransformed IOSS dataset, then the writer can preserve entity
	/// group classifications, such as element blocks, side sets etc. The same is
	/// not true if the input has been transformed e.g. through a clip filter. Thus
	/// flag is used to indicate whether the input has valid element
	/// classifications.
	/// </summary>
	public virtual void PreserveInputEntityGroupsOn()
	{
		vtkIOSSWriter_PreserveInputEntityGroupsOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSWriter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIOSSWriter SafeDownCast(vtkObjectBase o)
	{
		vtkIOSSWriter vtkIOSSWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSWriter_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIOSSWriter2 = (vtkIOSSWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIOSSWriter2.Register(null);
			}
		}
		return vtkIOSSWriter2;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSWriter_SetController_22(HandleRef pThis, HandleRef controller);

	/// <summary>
	/// Get/Set the controller to use when working in parallel. Initialized to
	/// `vtkMultiProcessController::GetGlobalController` in the constructor.
	///
	/// The controller is used to determine the upstream piece request in
	/// RequestUpdateExtent.
	/// </summary>
	public void SetController(vtkMultiProcessController controller)
	{
		vtkIOSSWriter_SetController_22(GetCppThis(), controller?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSWriter_SetDisplacementMagnitude_23(HandleRef pThis, double _arg);

	/// <summary>
	/// If input dataset has displacements pre-applied, setting the displacement
	/// magnitude to non-zero ensures that the point coordinates in the dataset are
	/// correctly transformed using the displacement field array, if present.
	///
	/// Defaults to 1.0.
	/// </summary>
	public virtual void SetDisplacementMagnitude(double _arg)
	{
		vtkIOSSWriter_SetDisplacementMagnitude_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSWriter_SetFileName_24(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/set the filename. When writing in a distributed environment, the
	/// actual filename written out may be different.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkIOSSWriter_SetFileName_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSWriter_SetMaximumTimeStepsPerFile_25(HandleRef pThis, int _arg);

	/// <summary>
	/// A debugging variable, set this to non-zero positive number to save at most
	/// the specified number of timesteps in a single file before starting a new
	/// one. The writer may start new files (aka restarts) automatically if it
	/// determines that the mesh has changed.
	///
	/// Defaults to 0 i.e. unlimited timesteps per file.
	/// </summary>
	public virtual void SetMaximumTimeStepsPerFile(int _arg)
	{
		vtkIOSSWriter_SetMaximumTimeStepsPerFile_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSWriter_SetOffsetGlobalIds_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Exodus wants global ids to start with 1, while VTK generally produces
	/// global ids starting with 0. Set this to true (default false), if the global
	/// ids are generated by VTK and hence start with 0. When writing to the output
	/// file, they will be offset by 1 to ensure the ids are valid exodus ids.
	/// </summary>
	public virtual void SetOffsetGlobalIds(bool _arg)
	{
		vtkIOSSWriter_SetOffsetGlobalIds_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSWriter_SetPreserveInputEntityGroups_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// If input is untransformed IOSS dataset, then the writer can preserve entity
	/// group classifications, such as element blocks, side sets etc. The same is
	/// not true if the input has been transformed e.g. through a clip filter. Thus
	/// flag is used to indicate whether the input has valid element
	/// classifications.
	/// </summary>
	public virtual void SetPreserveInputEntityGroups(bool _arg)
	{
		vtkIOSSWriter_SetPreserveInputEntityGroups_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSWriter_Write_28(HandleRef pThis);

	/// <summary>
	/// Writes the input dataset.
	/// </summary>
	public bool Write()
	{
		return (vtkIOSSWriter_Write_28(GetCppThis()) != 0) ? true : false;
	}
}
