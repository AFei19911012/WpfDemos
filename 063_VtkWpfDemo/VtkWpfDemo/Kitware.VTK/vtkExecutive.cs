using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExecutive
/// </summary>
/// <remarks>
///    Superclass for all pipeline executives in VTK.
///
/// vtkExecutive is the superclass for all pipeline executives in VTK.
/// A VTK executive is responsible for controlling one instance of
/// vtkAlgorithm.  A pipeline consists of one or more executives that
/// control data flow.  Every reader, source, writer, or data
/// processing algorithm in the pipeline is implemented in an instance
/// of vtkAlgorithm.
/// </remarks>
public abstract class vtkExecutive : vtkObject
{
	/// <summary>
	/// Keys to program vtkExecutive::ProcessRequest with the default
	/// behavior for unknown requests.
	/// </summary>
	public enum RequestDownstream_WrapperEnum
	{
		/// <summary>enum member</summary>
		RequestDownstream = 1,
		/// <summary>enum member</summary>
		RequestUpstream = 0
	}

	/// <summary>
	/// Keys to program vtkExecutive::ProcessRequest with the default
	/// behavior for unknown requests.
	/// </summary>
	public enum AfterForward_WrapperEnum
	{
		/// <summary>enum member</summary>
		AfterForward = 1,
		/// <summary>enum member</summary>
		BeforeForward = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExecutive";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExecutive()
	{
		MRClassNameKey = "class vtkExecutive";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExecutive"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExecutive(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkExecutive_ALGORITHM_AFTER_FORWARD_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Keys to program vtkExecutive::ProcessRequest with the default
	/// behavior for unknown requests.
	/// </summary>
	public static vtkInformationIntegerKey ALGORITHM_AFTER_FORWARD()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_ALGORITHM_AFTER_FORWARD_01(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_ALGORITHM_BEFORE_FORWARD_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Keys to program vtkExecutive::ProcessRequest with the default
	/// behavior for unknown requests.
	/// </summary>
	public static vtkInformationIntegerKey ALGORITHM_BEFORE_FORWARD()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_ALGORITHM_BEFORE_FORWARD_02(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_ALGORITHM_DIRECTION_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Keys to program vtkExecutive::ProcessRequest with the default
	/// behavior for unknown requests.
	/// </summary>
	public static vtkInformationIntegerKey ALGORITHM_DIRECTION()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_ALGORITHM_DIRECTION_03(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_CONSUMERS_04(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Information key to store the executive/port number pairs
	/// consuming an information object.
	/// </summary>
	public static vtkInformationExecutivePortVectorKey CONSUMERS()
	{
		vtkInformationExecutivePortVectorKey vtkInformationExecutivePortVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_CONSUMERS_04(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationExecutivePortVectorKey2 = (vtkInformationExecutivePortVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationExecutivePortVectorKey2.Register(null);
			}
		}
		return vtkInformationExecutivePortVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_FORWARD_DIRECTION_05(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Keys to program vtkExecutive::ProcessRequest with the default
	/// behavior for unknown requests.
	/// </summary>
	public static vtkInformationIntegerKey FORWARD_DIRECTION()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_FORWARD_DIRECTION_05(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_FROM_OUTPUT_PORT_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Information key to store the output port number from which a
	/// request is made.
	/// </summary>
	public static vtkInformationIntegerKey FROM_OUTPUT_PORT()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_FROM_OUTPUT_PORT_06(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_GetAlgorithm_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the algorithm to which this executive has been assigned.
	/// </summary>
	public vtkAlgorithm GetAlgorithm()
	{
		vtkAlgorithm vtkAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_GetAlgorithm_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithm2 = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithm2.Register(null);
			}
		}
		return vtkAlgorithm2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_GetInputData_08(HandleRef pThis, int port, int connection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data object for an input port of the algorithm.
	/// </summary>
	public virtual vtkDataObject GetInputData(int port, int connection)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_GetInputData_08(GetCppThis(), port, connection, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkExecutive_GetInputExecutive_09(HandleRef pThis, int port, int connection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the executive managing the given input connection.
	/// </summary>
	public vtkExecutive GetInputExecutive(int port, int connection)
	{
		vtkExecutive vtkExecutive2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_GetInputExecutive_09(GetCppThis(), port, connection, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExecutive2 = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExecutive2.Register(null);
			}
		}
		return vtkExecutive2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_GetInputInformation_10(HandleRef pThis, int port, int connection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the pipeline information for the given input connection.
	/// </summary>
	public vtkInformation GetInputInformation(int port, int connection)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_GetInputInformation_10(GetCppThis(), port, connection, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_GetInputInformation_11(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the pipeline information vectors for the given input port.
	/// </summary>
	public vtkInformationVector GetInputInformation(int port)
	{
		vtkInformationVector vtkInformationVector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_GetInputInformation_11(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationVector2 = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationVector2.Register(null);
			}
		}
		return vtkInformationVector2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExecutive_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExecutive_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExecutive_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExecutive_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutive_GetNumberOfInputConnections_14(HandleRef pThis, int port);

	/// <summary>
	/// Get the number of input connections on the given port.
	/// </summary>
	public int GetNumberOfInputConnections(int port)
	{
		return vtkExecutive_GetNumberOfInputConnections_14(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutive_GetNumberOfInputPorts_15(HandleRef pThis);

	/// <summary>
	/// Get the number of input/output ports for the algorithm associated
	/// with this executive.  Returns 0 if no algorithm is set.
	/// </summary>
	public int GetNumberOfInputPorts()
	{
		return vtkExecutive_GetNumberOfInputPorts_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutive_GetNumberOfOutputPorts_16(HandleRef pThis);

	/// <summary>
	/// Get the number of input/output ports for the algorithm associated
	/// with this executive.  Returns 0 if no algorithm is set.
	/// </summary>
	public int GetNumberOfOutputPorts()
	{
		return vtkExecutive_GetNumberOfOutputPorts_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_GetOutputData_17(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the data object for an output port of the algorithm.
	/// </summary>
	public virtual vtkDataObject GetOutputData(int port)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_GetOutputData_17(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkExecutive_GetOutputInformation_18(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the pipeline information object for the given output port.
	/// </summary>
	public virtual vtkInformation GetOutputInformation(int port)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_GetOutputInformation_18(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_GetOutputInformation_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the pipeline information object for all output ports.
	/// </summary>
	public vtkInformationVector GetOutputInformation()
	{
		vtkInformationVector vtkInformationVector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_GetOutputInformation_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationVector2 = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationVector2.Register(null);
			}
		}
		return vtkInformationVector2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutive_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExecutive_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutive_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExecutive_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_KEYS_TO_COPY_22(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Keys to program vtkExecutive::ProcessRequest with the default
	/// behavior for unknown requests.
	/// </summary>
	public static vtkInformationKeyVectorKey KEYS_TO_COPY()
	{
		vtkInformationKeyVectorKey vtkInformationKeyVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_KEYS_TO_COPY_22(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKeyVectorKey2 = (vtkInformationKeyVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKeyVectorKey2.Register(null);
			}
		}
		return vtkInformationKeyVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExecutive NewInstance()
	{
		vtkExecutive result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_PRODUCER_24(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Information key to store the executive/port number producing an
	/// information object.
	/// </summary>
	public static vtkInformationExecutivePortKey PRODUCER()
	{
		vtkInformationExecutivePortKey vtkInformationExecutivePortKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_PRODUCER_24(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationExecutivePortKey2 = (vtkInformationExecutivePortKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationExecutivePortKey2.Register(null);
			}
		}
		return vtkInformationExecutivePortKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutive_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExecutive SafeDownCast(vtkObjectBase o)
	{
		vtkExecutive vtkExecutive2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutive_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExecutive2 = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExecutive2.Register(null);
			}
		}
		return vtkExecutive2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExecutive_SetOutputData_26(HandleRef pThis, int port, HandleRef arg1, HandleRef info);

	/// <summary>
	/// Get/Set the data object for an output port of the algorithm.
	/// </summary>
	public virtual void SetOutputData(int port, vtkDataObject arg1, vtkInformation info)
	{
		vtkExecutive_SetOutputData_26(GetCppThis(), port, arg1?.GetCppThis() ?? default(HandleRef), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExecutive_SetOutputData_27(HandleRef pThis, int port, HandleRef arg1);

	/// <summary>
	/// Get/Set the data object for an output port of the algorithm.
	/// </summary>
	public virtual void SetOutputData(int port, vtkDataObject arg1)
	{
		vtkExecutive_SetOutputData_27(GetCppThis(), port, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExecutive_SetSharedOutputInformation_28(HandleRef pThis, HandleRef outInfoVec);

	/// <summary>
	/// Set a pointer to an outside instance of input or output
	/// information vectors.  No references are held to the given
	/// vectors, and setting this does not change the executive object
	/// modification time.  This is a preliminary interface to use in
	/// implementing filters with internal pipelines, and may change
	/// without notice when a future interface is created.
	/// </summary>
	public void SetSharedOutputInformation(vtkInformationVector outInfoVec)
	{
		vtkExecutive_SetSharedOutputInformation_28(GetCppThis(), outInfoVec?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutive_Update_29(HandleRef pThis);

	/// <summary>
	/// Bring the algorithm's outputs up-to-date.  Returns 1 for success
	/// and 0 for failure.
	/// </summary>
	public virtual int Update()
	{
		return vtkExecutive_Update_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutive_Update_30(HandleRef pThis, int port);

	/// <summary>
	/// Bring the algorithm's outputs up-to-date.  Returns 1 for success
	/// and 0 for failure.
	/// </summary>
	public virtual int Update(int port)
	{
		return vtkExecutive_Update_30(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutive_UpdateInformation_31(HandleRef pThis);

	/// <summary>
	/// Bring the output information up to date.
	/// </summary>
	public virtual int UpdateInformation()
	{
		return vtkExecutive_UpdateInformation_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExecutive_UsesGarbageCollector_32(HandleRef pThis);

	/// <summary>
	/// Participate in garbage collection.
	/// </summary>
	public override bool UsesGarbageCollector()
	{
		return (vtkExecutive_UsesGarbageCollector_32(GetCppThis()) != 0) ? true : false;
	}
}
