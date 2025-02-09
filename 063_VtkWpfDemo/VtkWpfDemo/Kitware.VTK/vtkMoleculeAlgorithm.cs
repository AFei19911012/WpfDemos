using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMoleculeAlgorithm
/// </summary>
/// <remarks>
///    Superclass for algorithms that operate on
/// vtkMolecules
///
///
///
/// vtkMoleculeAlgorithm is a convenience class to make writing algorithms
/// easier. There are some assumptions and defaults made by this class you
/// should be aware of. This class defaults such that your filter will have
/// one input port and one output port. If that is not the case simply change
/// it with SetNumberOfInputPorts etc. See this class constructor for the
/// default. This class also provides a FillInputPortInfo method that by
/// default says that all inputs will be vtkMolecules. If that isn't the case
/// then please override this method in your subclass. You should implement
/// the subclass's algorithm into RequestData( request, inputVec, outputVec).
/// </remarks>
public class vtkMoleculeAlgorithm : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMoleculeAlgorithm";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMoleculeAlgorithm()
	{
		MRClassNameKey = "class vtkMoleculeAlgorithm";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMoleculeAlgorithm"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMoleculeAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMoleculeAlgorithm New()
	{
		vtkMoleculeAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMoleculeAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMoleculeAlgorithm()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMoleculeAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add an input of this algorithm.  Note that these methods support
	/// old-style pipeline connections.  When writing new code you should
	/// use the more general vtkAlgorithm::AddInputConnection().  See
	/// SetInputData() for details.
	/// </summary>
	public void AddInputData(vtkDataObject arg0)
	{
		vtkMoleculeAlgorithm_AddInputData_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeAlgorithm_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

	/// <summary>
	/// Add an input of this algorithm.  Note that these methods support
	/// old-style pipeline connections.  When writing new code you should
	/// use the more general vtkAlgorithm::AddInputConnection().  See
	/// SetInputData() for details.
	/// </summary>
	public void AddInputData(int arg0, vtkDataObject arg1)
	{
		vtkMoleculeAlgorithm_AddInputData_02(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeAlgorithm_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// see vtkAlgorithm for details
	/// </summary>
	public vtkDataObject GetInput()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeAlgorithm_GetInput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkMoleculeAlgorithm_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// see vtkAlgorithm for details
	/// </summary>
	public vtkDataObject GetInput(int port)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeAlgorithm_GetInput_04(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkMoleculeAlgorithm_GetMoleculeInput_05(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// see vtkAlgorithm for details
	/// </summary>
	public vtkMolecule GetMoleculeInput(int port)
	{
		vtkMolecule vtkMolecule2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeAlgorithm_GetMoleculeInput_05(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMolecule2 = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMolecule2.Register(null);
			}
		}
		return vtkMolecule2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMoleculeAlgorithm_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMoleculeAlgorithm_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMoleculeAlgorithm_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMoleculeAlgorithm_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeAlgorithm_GetOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public vtkMolecule GetOutput()
	{
		vtkMolecule vtkMolecule2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeAlgorithm_GetOutput_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMolecule2 = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMolecule2.Register(null);
			}
		}
		return vtkMolecule2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeAlgorithm_GetOutput_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public vtkMolecule GetOutput(int arg0)
	{
		vtkMolecule vtkMolecule2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeAlgorithm_GetOutput_09(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMolecule2 = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMolecule2.Register(null);
			}
		}
		return vtkMolecule2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeAlgorithm_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMoleculeAlgorithm_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeAlgorithm_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMoleculeAlgorithm_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeAlgorithm_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMoleculeAlgorithm NewInstance()
	{
		vtkMoleculeAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeAlgorithm_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMoleculeAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeAlgorithm_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMoleculeAlgorithm SafeDownCast(vtkObjectBase o)
	{
		vtkMoleculeAlgorithm vtkMoleculeAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeAlgorithm_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMoleculeAlgorithm2 = (vtkMoleculeAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMoleculeAlgorithm2.Register(null);
			}
		}
		return vtkMoleculeAlgorithm2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeAlgorithm_SetInputData_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set an input of this algorithm. You should not override these
	/// methods because they are not the only way to connect a pipeline.
	/// Note that these methods support old-style pipeline connections.
	/// When writing new code you should use the more general
	/// vtkAlgorithm::SetInputConnection().  These methods transform the
	/// input index to the input port index, not an index of a connection
	/// within a single port.
	/// </summary>
	public void SetInputData(vtkDataObject arg0)
	{
		vtkMoleculeAlgorithm_SetInputData_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeAlgorithm_SetInputData_16(HandleRef pThis, int arg0, HandleRef arg1);

	/// <summary>
	/// Set an input of this algorithm. You should not override these
	/// methods because they are not the only way to connect a pipeline.
	/// Note that these methods support old-style pipeline connections.
	/// When writing new code you should use the more general
	/// vtkAlgorithm::SetInputConnection().  These methods transform the
	/// input index to the input port index, not an index of a connection
	/// within a single port.
	/// </summary>
	public void SetInputData(int arg0, vtkDataObject arg1)
	{
		vtkMoleculeAlgorithm_SetInputData_16(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeAlgorithm_SetOutput_17(HandleRef pThis, HandleRef d);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public virtual void SetOutput(vtkMolecule d)
	{
		vtkMoleculeAlgorithm_SetOutput_17(GetCppThis(), d?.GetCppThis() ?? default(HandleRef));
	}
}
