using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkReaderAlgorithm
/// </summary>
/// <remarks>
///    Superclass for readers that implement a simplified API.
///
/// This class and associated subclasses were created to make it easier to
/// develop readers. When directly subclassing from other algorithm classes
/// one has to learn a general purpose API that somewhat obfuscates pipeline
/// functionality behind information keys. One has to know how to find
/// time and pieces requests using keys for example. Furthermore, these
/// classes together with specialized executives can implement common
/// reader functionality for things such as file series (for time and/or
/// partitions), caching, mapping time requests to indices etc.
/// This class implements the most basic API which is specialized as
/// needed by subclasses (for file series for example).
/// </remarks>
public abstract class vtkReaderAlgorithm : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkReaderAlgorithm";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkReaderAlgorithm()
	{
		MRClassNameKey = "class vtkReaderAlgorithm";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkReaderAlgorithm"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkReaderAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReaderAlgorithm_CreateOutput_01(HandleRef pThis, HandleRef currentOutput, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This can be overridden by a subclass to create an output that
	/// is determined by the file being read. If the output is known at
	/// compile time, it is easier to override FillOutputPortInformation()
	/// to set vtkDataObject::DATA_TYPE_NAME(). The subclass should compare
	/// the new output type with the type of the currentOutput argument and
	/// return currentOutput without changing its reference count if the
	/// types are same.
	/// </summary>
	public virtual vtkDataObject CreateOutput(vtkDataObject currentOutput)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReaderAlgorithm_CreateOutput_01(GetCppThis(), currentOutput?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkReaderAlgorithm_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkReaderAlgorithm_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkReaderAlgorithm_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkReaderAlgorithm_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReaderAlgorithm_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkReaderAlgorithm_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReaderAlgorithm_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkReaderAlgorithm_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReaderAlgorithm_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkReaderAlgorithm NewInstance()
	{
		vtkReaderAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReaderAlgorithm_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkReaderAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReaderAlgorithm_ReadArrays_07(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// Read all the arrays (point, cell, field etc.). This is called after
	/// ReadPoints() so the data object should already contain the mesh and
	/// points.
	/// </summary>
	public virtual int ReadArrays(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkReaderAlgorithm_ReadArrays_07(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReaderAlgorithm_ReadMesh_08(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// Read the mesh (connectivity) for a given set of data partitioning,
	/// number of ghost levels and time step (index). The reader populates
	/// the data object passed in as the last argument. It is OK to read
	/// more than the mesh (points, arrays etc.). However, this may interfere
	/// with any caching implemented by the executive (i.e. cause more reads).
	/// </summary>
	public virtual int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkReaderAlgorithm_ReadMesh_08(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReaderAlgorithm_ReadMetaData_09(HandleRef pThis, HandleRef metadata);

	/// <summary>
	/// Provide meta-data for the pipeline. This meta-data cannot vary over
	/// time as this method will not be called when only a request is changed.
	/// These include things like time steps. Subclasses may have specialized
	/// interfaces making this simpler.
	/// </summary>
	public virtual int ReadMetaData(vtkInformation metadata)
	{
		return vtkReaderAlgorithm_ReadMetaData_09(GetCppThis(), metadata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReaderAlgorithm_ReadPoints_10(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// Read the points. The reader populates the input data object. This is
	/// called after ReadMesh() so the data object should already contain the
	/// mesh.
	/// </summary>
	public virtual int ReadPoints(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkReaderAlgorithm_ReadPoints_10(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReaderAlgorithm_ReadTimeDependentMetaData_11(HandleRef pThis, int arg0, HandleRef arg1);

	/// <summary>
	/// Provide meta-data for the pipeline. This meta-data can vary over time
	/// as this method will be called after a request is changed (such as time)
	/// These include things like whole extent. Subclasses may have specialized
	/// interfaces making this simpler.
	/// </summary>
	public virtual int ReadTimeDependentMetaData(int arg0, vtkInformation arg1)
	{
		return vtkReaderAlgorithm_ReadTimeDependentMetaData_11(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReaderAlgorithm_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkReaderAlgorithm SafeDownCast(vtkObjectBase o)
	{
		vtkReaderAlgorithm vtkReaderAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReaderAlgorithm_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkReaderAlgorithm2 = (vtkReaderAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkReaderAlgorithm2.Register(null);
			}
		}
		return vtkReaderAlgorithm2;
	}
}
