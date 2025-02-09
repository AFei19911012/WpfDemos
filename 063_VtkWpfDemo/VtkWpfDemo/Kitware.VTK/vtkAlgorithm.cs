using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAlgorithm
/// </summary>
/// <remarks>
///    Superclass for all sources, filters, and sinks in VTK.
///
/// vtkAlgorithm is the superclass for all sources, filters, and sinks
/// in VTK.  It defines a generalized interface for executing data
/// processing algorithms.  Pipeline connections are associated with
/// input and output ports that are independent of the type of data
/// passing through the connections.
///
/// Instances may be used independently or within pipelines with a
/// variety of architectures and update mechanisms.  Pipelines are
/// controlled by instances of vtkExecutive.  Every vtkAlgorithm
/// instance has an associated vtkExecutive when it is used in a
/// pipeline.  The executive is responsible for data flow.
/// </remarks>
public class vtkAlgorithm : vtkObject
{
	/// <summary>
	/// Values used for setting the desired output precision for various
	/// algorithms. Currently, the following algorithms support changing their
	/// output precision: vtkAppendPolyData, vtkCleanPolyData, vtkClipPolyData,
	/// vtkConnectivityFilter, vtkDecimatePolylineFilter, vtkDecimatePro, vtkDelaunay3D,
	/// vtkFeatureEdges, vtkGlyph3D, vtkHedgeHog, vtkMaskPoints, vtkPolyDataConnectivityFilter,
	/// vtkSmoothPolyDataFilter, vtkStaticCleanPolyData, vtkThresholdPoints, vtkTubeFilter,
	/// vtkAppendPoints, vtkTransformFilter, vtkTransformPolyDataFilter,
	/// vtkLinearToQuadraticCellsFilter, vtkProcrustesAlignmentFilter,
	/// vtkAdaptiveSubdivisionFilter, vtkBoundedPointSource, vtkArcSource, vtkConeSource,
	/// vtkCubeSource, vtkCylinderSource, vtkDiskSource, vtkEllipseArcSource,
	/// vtkEllipticalButtonSource, vtkFrustumSource, vtkGlyphSource2D, vtkLineSource,
	/// vtkOutlineSource, vtkParametricFunctionSource, vtkPlaneSource, vtkPlatonicSolidSource,
	/// vtkPointSource, vtkRectangularButtonSource, vtkRegularPolygonSource, vtkSphereSource,
	/// vtkSuperquadricSource, vtkTessellatedBoxSource, vtkTextSource, vtkTexturedSphereSource,
	/// vtkImageToPoints, vtkDepthImageToPointCloud.
	/// SINGLE_PRECISION - Output single-precision floating-point (i.e. float)
	/// DOUBLE_PRECISION - Output double-precision floating-point (i.e. double)
	/// DEFAULT_PRECISION - Output precision should match the input precision.
	/// </summary>
	public enum DesiredOutputPrecision
	{
		/// <summary>enum member</summary>
		DEFAULT_PRECISION = 2,
		/// <summary>enum member</summary>
		DOUBLE_PRECISION = 1,
		/// <summary>enum member</summary>
		SINGLE_PRECISION = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAlgorithm";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAlgorithm()
	{
		MRClassNameKey = "class vtkAlgorithm";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAlgorithm"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAlgorithm New()
	{
		vtkAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAlgorithm()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_ABORTED_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey ABORTED()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_ABORTED_01(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAlgorithm_AbortExecuteOff_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the AbortExecute flag for the process object. Process objects
	/// may handle premature termination of execution in different ways.
	/// </summary>
	public virtual void AbortExecuteOff()
	{
		vtkAlgorithm_AbortExecuteOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_AbortExecuteOn_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the AbortExecute flag for the process object. Process objects
	/// may handle premature termination of execution in different ways.
	/// </summary>
	public virtual void AbortExecuteOn()
	{
		vtkAlgorithm_AbortExecuteOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_AddInputConnection_04(HandleRef pThis, int port, HandleRef input);

	/// <summary>
	/// Add a connection to the given input port index.  See
	/// SetInputConnection() for details on input connections.  This
	/// method is the complement to RemoveInputConnection() in that it
	/// adds only the connection specified without affecting other
	/// connections.  Typical usage is
	///
	/// filter2-&gt;AddInputConnection(0, filter1-&gt;GetOutputPort(0)).
	/// </summary>
	public virtual void AddInputConnection(int port, vtkAlgorithmOutput input)
	{
		vtkAlgorithm_AddInputConnection_04(GetCppThis(), port, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_AddInputConnection_05(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Add a connection to the given input port index.  See
	/// SetInputConnection() for details on input connections.  This
	/// method is the complement to RemoveInputConnection() in that it
	/// adds only the connection specified without affecting other
	/// connections.  Typical usage is
	///
	/// filter2-&gt;AddInputConnection(0, filter1-&gt;GetOutputPort(0)).
	/// </summary>
	public virtual void AddInputConnection(vtkAlgorithmOutput input)
	{
		vtkAlgorithm_AddInputConnection_05(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_AddInputDataObject_06(HandleRef pThis, int port, HandleRef data);

	/// <summary>
	/// Add the data-object as an input to this given port. This will add a new
	/// input connection on the specified port without affecting any existing
	/// connections on the same input port.
	/// </summary>
	public virtual void AddInputDataObject(int port, vtkDataObject data)
	{
		vtkAlgorithm_AddInputDataObject_06(GetCppThis(), port, data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_AddInputDataObject_07(HandleRef pThis, HandleRef data);

	/// <summary>
	/// Add the data-object as an input to this given port. This will add a new
	/// input connection on the specified port without affecting any existing
	/// connections on the same input port.
	/// </summary>
	public virtual void AddInputDataObject(vtkDataObject data)
	{
		vtkAlgorithm_AddInputDataObject_07(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_CAN_HANDLE_PIECE_REQUEST_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key that tells the pipeline that a particular algorithm
	/// can or cannot handle piece request. If a filter cannot handle
	/// piece requests and is asked for a piece, the executive will
	/// flag an error. If a structured data source cannot handle piece
	/// requests but can produce sub-extents (CAN_PRODUCE_SUB_EXTENT),
	/// the executive will use an extent translator to split the extent
	/// into pieces. Otherwise, if a source cannot handle piece requests,
	/// the executive will ask for the whole data for piece 0 and not
	/// execute the source for other pieces.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey CAN_HANDLE_PIECE_REQUEST()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_CAN_HANDLE_PIECE_REQUEST_08(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_CAN_PRODUCE_SUB_EXTENT_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This key tells the executive that a particular output port
	/// is capable of producing an arbitrary subextent of the whole
	/// extent. Many image sources and readers fall into this category
	/// but some such as the legacy structured data readers cannot
	/// support this feature.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey CAN_PRODUCE_SUB_EXTENT()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_CAN_PRODUCE_SUB_EXTENT_09(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkAlgorithm_CheckAbort_10(HandleRef pThis);

	/// <summary>
	/// Checks to see if this filter should abort.
	/// </summary>
	public bool CheckAbort()
	{
		return (vtkAlgorithm_CheckAbort_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_ConvertTotalInputToPortConnection_11(HandleRef pThis, int ind, ref int port, ref int conn);

	/// <summary>
	/// Convenience routine to convert from a linear ordering of input
	/// connections to a port/connection pair.
	/// </summary>
	public void ConvertTotalInputToPortConnection(int ind, ref int port, ref int conn)
	{
		vtkAlgorithm_ConvertTotalInputToPortConnection_11(GetCppThis(), ind, ref port, ref conn);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_GetAbortExecute_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the AbortExecute flag for the process object. Process objects
	/// may handle premature termination of execution in different ways.
	/// </summary>
	public virtual int GetAbortExecute()
	{
		return vtkAlgorithm_GetAbortExecute_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAlgorithm_GetAbortOutput_13(HandleRef pThis);

	/// <summary>
	/// Set/Get an internal variable used to comunicate between the algorithm and
	/// executive. If the executive sees this value is set, it will initialize
	/// the output data and pass the ABORTED flag downstream.
	///
	/// CheckAbort sets this value to true if the function returns true.
	/// </summary>
	public virtual bool GetAbortOutput()
	{
		return (vtkAlgorithm_GetAbortOutput_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_GetContainerAlgorithm_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get a Container algorithm for this algorithm. Allows this algorithm
	/// to check to abort status of its Container algorithm as well as have access
	/// to its Container's information.
	/// </summary>
	public vtkAlgorithm GetContainerAlgorithm()
	{
		vtkAlgorithm vtkAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetContainerAlgorithm_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkAlgorithm_GetErrorCode_15(HandleRef pThis);

	/// <summary>
	/// The error code contains a possible error that occurred while
	/// reading or writing the file.
	/// </summary>
	public virtual uint GetErrorCode()
	{
		return vtkAlgorithm_GetErrorCode_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_GetExecutive_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get this algorithm's executive.  If it has none, a default
	/// executive will be created.
	/// </summary>
	public vtkExecutive GetExecutive()
	{
		vtkExecutive vtkExecutive2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetExecutive_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetInformation_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the information object associated with this algorithm.
	/// </summary>
	public virtual vtkInformation GetInformation()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetInformation_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetInputAlgorithm_18(HandleRef pThis, int port, int index, ref int algPort, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the algorithm and the output port index of
	/// that algorithm connected to a port-index pair.
	/// </summary>
	public vtkAlgorithm GetInputAlgorithm(int port, int index, ref int algPort)
	{
		vtkAlgorithm vtkAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetInputAlgorithm_18(GetCppThis(), port, index, ref algPort, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetInputAlgorithm_19(HandleRef pThis, int port, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the algorithm connected to a port-index pair.
	/// </summary>
	public vtkAlgorithm GetInputAlgorithm(int port, int index)
	{
		vtkAlgorithm vtkAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetInputAlgorithm_19(GetCppThis(), port, index, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetInputAlgorithm_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Equivalent to GetInputAlgorithm(0, 0).
	/// </summary>
	public vtkAlgorithm GetInputAlgorithm()
	{
		vtkAlgorithm vtkAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetInputAlgorithm_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetInputArrayInformation_21(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the info object for the specified input array to this algorithm
	/// </summary>
	public vtkInformation GetInputArrayInformation(int idx)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetInputArrayInformation_21(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetInputConnection_22(HandleRef pThis, int port, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the algorithm output port connected to an input port.
	/// </summary>
	public vtkAlgorithmOutput GetInputConnection(int port, int index)
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetInputConnection_22(GetCppThis(), port, index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_GetInputDataObject_23(HandleRef pThis, int port, int connection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data object that will contain the algorithm input for the given
	/// port and given connection.
	/// </summary>
	public vtkDataObject GetInputDataObject(int port, int connection)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetInputDataObject_23(GetCppThis(), port, connection, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetInputExecutive_24(HandleRef pThis, int port, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the executive associated with a particular input
	/// connection.
	/// </summary>
	public vtkExecutive GetInputExecutive(int port, int index)
	{
		vtkExecutive vtkExecutive2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetInputExecutive_24(GetCppThis(), port, index, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetInputExecutive_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Equivalent to GetInputExecutive(0, 0)
	/// </summary>
	public vtkExecutive GetInputExecutive()
	{
		vtkExecutive vtkExecutive2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetInputExecutive_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetInputInformation_26(HandleRef pThis, int port, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the information object that is associated with
	/// a particular input connection. This can be used to get
	/// meta-data coming from the REQUEST_INFORMATION pass and set
	/// requests for the REQUEST_UPDATE_EXTENT pass. NOTE:
	/// Do not use this in any of the pipeline passes. Use
	/// the information objects passed as arguments instead.
	/// </summary>
	public vtkInformation GetInputInformation(int port, int index)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetInputInformation_26(GetCppThis(), port, index, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetInputInformation_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Equivalent to GetInputInformation(0, 0)
	/// </summary>
	public vtkInformation GetInputInformation()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetInputInformation_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetInputPortInformation_28(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the information object associated with an input port.  There
	/// is one input port per kind of input to the algorithm.  Each input
	/// port tells executives what kind of data and downstream requests
	/// this algorithm can handle for that input.
	/// </summary>
	public vtkInformation GetInputPortInformation(int port)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetInputPortInformation_28(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkAlgorithm_GetNumberOfGenerationsFromBase_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAlgorithm_GetNumberOfGenerationsFromBase_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAlgorithm_GetNumberOfGenerationsFromBaseType_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAlgorithm_GetNumberOfGenerationsFromBaseType_30(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_GetNumberOfInputConnections_31(HandleRef pThis, int port);

	/// <summary>
	/// Get the number of inputs currently connected to a port.
	/// </summary>
	public int GetNumberOfInputConnections(int port)
	{
		return vtkAlgorithm_GetNumberOfInputConnections_31(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_GetNumberOfInputPorts_32(HandleRef pThis);

	/// <summary>
	/// Get the number of input ports used by the algorithm.
	/// </summary>
	public int GetNumberOfInputPorts()
	{
		return vtkAlgorithm_GetNumberOfInputPorts_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_GetNumberOfOutputPorts_33(HandleRef pThis);

	/// <summary>
	/// Get the number of output ports provided by the algorithm.
	/// </summary>
	public int GetNumberOfOutputPorts()
	{
		return vtkAlgorithm_GetNumberOfOutputPorts_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_GetOutputDataObject_34(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data object that will contain the algorithm output for
	/// the given port.
	/// </summary>
	public vtkDataObject GetOutputDataObject(int port)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetOutputDataObject_34(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetOutputInformation_35(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the information object that is associated with
	/// a particular output port. This can be used to set
	/// meta-data coming during the REQUEST_INFORMATION. NOTE:
	/// Do not use this in any of the pipeline passes. Use
	/// the information objects passed as arguments instead.
	/// </summary>
	public vtkInformation GetOutputInformation(int port)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetOutputInformation_35(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_GetOutputPort_36(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a proxy object corresponding to the given output port of this
	/// algorithm.  The proxy object can be passed to another algorithm's
	/// SetInputConnection(), AddInputConnection(), and
	/// RemoveInputConnection() methods to modify pipeline connectivity.
	/// </summary>
	public vtkAlgorithmOutput GetOutputPort(int index)
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetOutputPort_36(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_GetOutputPort_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a proxy object corresponding to the given output port of this
	/// algorithm.  The proxy object can be passed to another algorithm's
	/// SetInputConnection(), AddInputConnection(), and
	/// RemoveInputConnection() methods to modify pipeline connectivity.
	/// </summary>
	public vtkAlgorithmOutput GetOutputPort()
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetOutputPort_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_GetOutputPortInformation_38(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the information object associated with an output port.  There
	/// is one output port per output from the algorithm.  Each output
	/// port tells executives what kind of upstream requests this
	/// algorithm can handle for that output.
	/// </summary>
	public vtkInformation GetOutputPortInformation(int port)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetOutputPortInformation_38(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkAlgorithm_GetProgress_39(HandleRef pThis);

	/// <summary>
	/// Get the execution progress of a process object.
	/// </summary>
	public virtual double GetProgress()
	{
		return vtkAlgorithm_GetProgress_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_GetProgressObserver_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If an ProgressObserver is set, the algorithm will report
	/// progress through it rather than directly. This means that
	/// it will call UpdateProgress() on the ProgressObserver rather
	/// than itself report it and set progress.
	/// This is most useful in situations where multiple threads
	/// are executing an algorithm at the same time and want to
	/// handle progress locally.
	/// </summary>
	public virtual vtkProgressObserver GetProgressObserver()
	{
		vtkProgressObserver vtkProgressObserver2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_GetProgressObserver_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProgressObserver2 = (vtkProgressObserver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProgressObserver2.Register(null);
			}
		}
		return vtkProgressObserver2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAlgorithm_GetProgressScale_41(HandleRef pThis);

	/// <summary>
	/// Specify the shift and scale values to use to apply to the progress amount
	/// when `UpdateProgress` is called. By default shift is set to 0, and scale is
	/// set to 1.0. This is useful when the vtkAlgorithm instance is used as an
	/// internal algorithm to solve only a part of a whole problem.
	///
	/// If calling on a internal vtkAlgorithm, make sure you take into
	/// consideration that values set of the outer vtkAlgorithm as well since the
	/// outer vtkAlgorithm itself may be nested in another algorithm.
	///
	/// @note SetProgressShiftScale does not modify the MTime of the algorithm.
	/// </summary>
	public virtual double GetProgressScale()
	{
		return vtkAlgorithm_GetProgressScale_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAlgorithm_GetProgressShift_42(HandleRef pThis);

	/// <summary>
	/// Specify the shift and scale values to use to apply to the progress amount
	/// when `UpdateProgress` is called. By default shift is set to 0, and scale is
	/// set to 1.0. This is useful when the vtkAlgorithm instance is used as an
	/// internal algorithm to solve only a part of a whole problem.
	///
	/// If calling on a internal vtkAlgorithm, make sure you take into
	/// consideration that values set of the outer vtkAlgorithm as well since the
	/// outer vtkAlgorithm itself may be nested in another algorithm.
	///
	/// @note SetProgressShiftScale does not modify the MTime of the algorithm.
	/// </summary>
	public virtual double GetProgressShift()
	{
		return vtkAlgorithm_GetProgressShift_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_GetProgressText_43(HandleRef pThis);

	/// <summary>
	/// Set the current text message associated with the progress state.
	/// This may be used by a calling process/GUI.
	/// Note: Because SetProgressText() is called from inside RequestData()
	/// it does not modify the algorithm object. Algorithms are not
	/// allowed to modify themselves from inside RequestData().
	/// </summary>
	public virtual string GetProgressText()
	{
		return Marshal.PtrToStringAnsi(vtkAlgorithm_GetProgressText_43(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_GetReleaseDataFlag_44(HandleRef pThis);

	/// <summary>
	/// Turn release data flag on or off for all output ports.
	/// </summary>
	public virtual int GetReleaseDataFlag()
	{
		return vtkAlgorithm_GetReleaseDataFlag_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_GetTotalNumberOfInputConnections_45(HandleRef pThis);

	/// <summary>
	/// Get the total number of inputs for this algorithm
	/// </summary>
	public int GetTotalNumberOfInputConnections()
	{
		return vtkAlgorithm_GetTotalNumberOfInputConnections_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_GetUpdateExtent_46(HandleRef pThis);

	/// <summary>
	/// These functions return the update extent for output ports that
	/// use 3D extents. Where port is not specified, it is assumed to
	/// be 0.
	/// </summary>
	public int[] GetUpdateExtent()
	{
		IntPtr intPtr = vtkAlgorithm_GetUpdateExtent_46(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_GetUpdateExtent_47(HandleRef pThis, int port);

	/// <summary>
	/// These functions return the update extent for output ports that
	/// use 3D extents. Where port is not specified, it is assumed to
	/// be 0.
	/// </summary>
	public int[] GetUpdateExtent(int port)
	{
		IntPtr intPtr = vtkAlgorithm_GetUpdateExtent_47(GetCppThis(), port);
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_GetUpdateExtent_48(HandleRef pThis, ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1);

	/// <summary>
	/// These functions return the update extent for output ports that
	/// use 3D extents. Where port is not specified, it is assumed to
	/// be 0.
	/// </summary>
	public void GetUpdateExtent(ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1)
	{
		vtkAlgorithm_GetUpdateExtent_48(GetCppThis(), ref x0, ref x1, ref y0, ref y1, ref z0, ref z1);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_GetUpdateExtent_49(HandleRef pThis, int port, ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1);

	/// <summary>
	/// These functions return the update extent for output ports that
	/// use 3D extents. Where port is not specified, it is assumed to
	/// be 0.
	/// </summary>
	public void GetUpdateExtent(int port, ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1)
	{
		vtkAlgorithm_GetUpdateExtent_49(GetCppThis(), port, ref x0, ref x1, ref y0, ref y1, ref z0, ref z1);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_GetUpdateExtent_50(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// These functions return the update extent for output ports that
	/// use 3D extents. Where port is not specified, it is assumed to
	/// be 0.
	/// </summary>
	public void GetUpdateExtent(IntPtr extent)
	{
		vtkAlgorithm_GetUpdateExtent_50(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_GetUpdateExtent_51(HandleRef pThis, int port, IntPtr extent);

	/// <summary>
	/// These functions return the update extent for output ports that
	/// use 3D extents. Where port is not specified, it is assumed to
	/// be 0.
	/// </summary>
	public void GetUpdateExtent(int port, IntPtr extent)
	{
		vtkAlgorithm_GetUpdateExtent_51(GetCppThis(), port, extent);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_GetUpdateGhostLevel_52(HandleRef pThis);

	/// <summary>
	/// These functions return the update extent for output ports that
	/// use piece extents. Where port is not specified, it is assumed to
	/// be 0.
	/// </summary>
	public int GetUpdateGhostLevel()
	{
		return vtkAlgorithm_GetUpdateGhostLevel_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_GetUpdateGhostLevel_53(HandleRef pThis, int port);

	/// <summary>
	/// These functions return the update extent for output ports that
	/// use piece extents. Where port is not specified, it is assumed to
	/// be 0.
	/// </summary>
	public int GetUpdateGhostLevel(int port)
	{
		return vtkAlgorithm_GetUpdateGhostLevel_53(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_GetUpdateNumberOfPieces_54(HandleRef pThis);

	/// <summary>
	/// These functions return the update extent for output ports that
	/// use piece extents. Where port is not specified, it is assumed to
	/// be 0.
	/// </summary>
	public int GetUpdateNumberOfPieces()
	{
		return vtkAlgorithm_GetUpdateNumberOfPieces_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_GetUpdateNumberOfPieces_55(HandleRef pThis, int port);

	/// <summary>
	/// These functions return the update extent for output ports that
	/// use piece extents. Where port is not specified, it is assumed to
	/// be 0.
	/// </summary>
	public int GetUpdateNumberOfPieces(int port)
	{
		return vtkAlgorithm_GetUpdateNumberOfPieces_55(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_GetUpdatePiece_56(HandleRef pThis);

	/// <summary>
	/// These functions return the update extent for output ports that
	/// use piece extents. Where port is not specified, it is assumed to
	/// be 0.
	/// </summary>
	public int GetUpdatePiece()
	{
		return vtkAlgorithm_GetUpdatePiece_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_GetUpdatePiece_57(HandleRef pThis, int port);

	/// <summary>
	/// These functions return the update extent for output ports that
	/// use piece extents. Where port is not specified, it is assumed to
	/// be 0.
	/// </summary>
	public int GetUpdatePiece(int port)
	{
		return vtkAlgorithm_GetUpdatePiece_57(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_HasExecutive_58(HandleRef pThis);

	/// <summary>
	/// Check whether this algorithm has an assigned executive.  This
	/// will NOT create a default executive.
	/// </summary>
	public int HasExecutive()
	{
		return vtkAlgorithm_HasExecutive_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_INPUT_ARRAYS_TO_PROCESS_59(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationInformationVectorKey INPUT_ARRAYS_TO_PROCESS()
	{
		vtkInformationInformationVectorKey vtkInformationInformationVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_INPUT_ARRAYS_TO_PROCESS_59(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationInformationVectorKey2 = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationInformationVectorKey2.Register(null);
			}
		}
		return vtkInformationInformationVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_INPUT_CONNECTION_60(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey INPUT_CONNECTION()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_INPUT_CONNECTION_60(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_INPUT_IS_OPTIONAL_61(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Keys used to specify input port requirements.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey INPUT_IS_OPTIONAL()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_INPUT_IS_OPTIONAL_61(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_INPUT_IS_REPEATABLE_62(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey INPUT_IS_REPEATABLE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_INPUT_IS_REPEATABLE_62(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_INPUT_PORT_63(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey INPUT_PORT()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_INPUT_PORT_63(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAlgorithm_INPUT_REQUIRED_DATA_TYPE_64(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationStringVectorKey INPUT_REQUIRED_DATA_TYPE()
	{
		vtkInformationStringVectorKey vtkInformationStringVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_INPUT_REQUIRED_DATA_TYPE_64(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationStringVectorKey2 = (vtkInformationStringVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationStringVectorKey2.Register(null);
			}
		}
		return vtkInformationStringVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_INPUT_REQUIRED_FIELDS_65(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationInformationVectorKey INPUT_REQUIRED_FIELDS()
	{
		vtkInformationInformationVectorKey vtkInformationInformationVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_INPUT_REQUIRED_FIELDS_65(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationInformationVectorKey2 = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationInformationVectorKey2.Register(null);
			}
		}
		return vtkInformationInformationVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_IsA_66(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAlgorithm_IsA_66(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_IsTypeOf_67(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAlgorithm_IsTypeOf_67(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_ModifyRequest_68(HandleRef pThis, HandleRef request, int when);

	/// <summary>
	/// This method gives the algorithm a chance to modify the contents of a
	/// request before or after (specified in the when argument) it is
	/// forwarded. The default implementation is empty. Returns 1 on success,
	/// 0 on failure. When can be either vtkExecutive::BeforeForward or
	/// vtkExecutive::AfterForward.
	/// </summary>
	public virtual int ModifyRequest(vtkInformation request, int when)
	{
		return vtkAlgorithm_ModifyRequest_68(GetCppThis(), request?.GetCppThis() ?? default(HandleRef), when);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_NewInstance_70(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAlgorithm NewInstance()
	{
		vtkAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_NewInstance_70(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_ProcessRequest_71(HandleRef pThis, HandleRef request, HandleRef inInfo, HandleRef outInfo);

	/// <summary>
	/// Version of ProcessRequest() that is wrapped. This converts the
	/// collection to an array and calls the other version.
	/// </summary>
	public int ProcessRequest(vtkInformation request, vtkCollection inInfo, vtkInformationVector outInfo)
	{
		return vtkAlgorithm_ProcessRequest_71(GetCppThis(), request?.GetCppThis() ?? default(HandleRef), inInfo?.GetCppThis() ?? default(HandleRef), outInfo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_PropagateUpdateExtent_72(HandleRef pThis);

	/// <summary>
	/// Propagate meta-data upstream.
	/// </summary>
	public virtual void PropagateUpdateExtent()
	{
		vtkAlgorithm_PropagateUpdateExtent_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_ReleaseDataFlagOff_73(HandleRef pThis);

	/// <summary>
	/// Turn release data flag on or off for all output ports.
	/// </summary>
	public void ReleaseDataFlagOff()
	{
		vtkAlgorithm_ReleaseDataFlagOff_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_ReleaseDataFlagOn_74(HandleRef pThis);

	/// <summary>
	/// Turn release data flag on or off for all output ports.
	/// </summary>
	public void ReleaseDataFlagOn()
	{
		vtkAlgorithm_ReleaseDataFlagOn_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_RemoveAllInputConnections_75(HandleRef pThis, int port);

	/// <summary>
	/// Removes all input connections.
	/// </summary>
	public virtual void RemoveAllInputConnections(int port)
	{
		vtkAlgorithm_RemoveAllInputConnections_75(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_RemoveAllInputs_76(HandleRef pThis);

	/// <summary>
	/// Remove all the input data.
	/// </summary>
	public void RemoveAllInputs()
	{
		vtkAlgorithm_RemoveAllInputs_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_RemoveInputConnection_77(HandleRef pThis, int port, HandleRef input);

	/// <summary>
	/// Remove a connection from the given input port index.  See
	/// SetInputConnection() for details on input connection.  This
	/// method is the complement to AddInputConnection() in that it
	/// removes only the connection specified without affecting other
	/// connections.  Typical usage is
	///
	/// filter2-&gt;RemoveInputConnection(0, filter1-&gt;GetOutputPort(0)).
	/// </summary>
	public virtual void RemoveInputConnection(int port, vtkAlgorithmOutput input)
	{
		vtkAlgorithm_RemoveInputConnection_77(GetCppThis(), port, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_RemoveInputConnection_78(HandleRef pThis, int port, int idx);

	/// <summary>
	/// Remove a connection given by index idx.
	/// </summary>
	public virtual void RemoveInputConnection(int port, int idx)
	{
		vtkAlgorithm_RemoveInputConnection_78(GetCppThis(), port, idx);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlgorithm_SafeDownCast_79(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAlgorithm SafeDownCast(vtkObjectBase o)
	{
		vtkAlgorithm vtkAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlgorithm_SafeDownCast_79(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAlgorithm_SetAbortExecute_80(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the AbortExecute flag for the process object. Process objects
	/// may handle premature termination of execution in different ways.
	/// </summary>
	public virtual void SetAbortExecute(int _arg)
	{
		vtkAlgorithm_SetAbortExecute_80(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetAbortExecuteAndUpdateTime_81(HandleRef pThis);

	/// <summary>
	///  Set AbortExecute Flag and update LastAbortTime.
	/// </summary>
	public void SetAbortExecuteAndUpdateTime()
	{
		vtkAlgorithm_SetAbortExecuteAndUpdateTime_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetAbortOutput_82(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get an internal variable used to comunicate between the algorithm and
	/// executive. If the executive sees this value is set, it will initialize
	/// the output data and pass the ABORTED flag downstream.
	///
	/// CheckAbort sets this value to true if the function returns true.
	/// </summary>
	public virtual void SetAbortOutput(bool _arg)
	{
		vtkAlgorithm_SetAbortOutput_82(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetContainerAlgorithm_83(HandleRef pThis, HandleRef containerAlg);

	/// <summary>
	/// Set/get a Container algorithm for this algorithm. Allows this algorithm
	/// to check to abort status of its Container algorithm as well as have access
	/// to its Container's information.
	/// </summary>
	public void SetContainerAlgorithm(vtkAlgorithm containerAlg)
	{
		vtkAlgorithm_SetContainerAlgorithm_83(GetCppThis(), containerAlg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetDefaultExecutivePrototype_84(HandleRef proto);

	/// <summary>
	/// If the DefaultExecutivePrototype is set, a copy of it is created
	/// in CreateDefaultExecutive() using NewInstance().
	/// </summary>
	public static void SetDefaultExecutivePrototype(vtkExecutive proto)
	{
		vtkAlgorithm_SetDefaultExecutivePrototype_84(proto?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetExecutive_85(HandleRef pThis, HandleRef executive);

	/// <summary>
	/// Set this algorithm's executive.  This algorithm is removed from
	/// any executive to which it has previously been assigned and then
	/// assigned to the given executive.
	/// </summary>
	public virtual void SetExecutive(vtkExecutive executive)
	{
		vtkAlgorithm_SetExecutive_85(GetCppThis(), executive?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetInformation_86(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the information object associated with this algorithm.
	/// </summary>
	public virtual void SetInformation(vtkInformation arg0)
	{
		vtkAlgorithm_SetInformation_86(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetInputArrayToProcess_87(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, string name);

	/// <summary>
	/// Set the input data arrays that this algorithm will
	/// process. Specifically the idx array that this algorithm will process
	/// (starting from 0) is the array on port, connection with the specified
	/// association and name or attribute type (such as SCALARS). The
	/// fieldAssociation refers to which field in the data object the array is
	/// stored. See vtkDataObject::FieldAssociations for detail.
	/// </summary>
	public virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, string name)
	{
		vtkAlgorithm_SetInputArrayToProcess_87(GetCppThis(), idx, port, connection, fieldAssociation, name);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetInputArrayToProcess_88(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, int fieldAttributeType);

	/// <summary>
	/// Set the input data arrays that this algorithm will
	/// process. Specifically the idx array that this algorithm will process
	/// (starting from 0) is the array on port, connection with the specified
	/// association and name or attribute type (such as SCALARS). The
	/// fieldAssociation refers to which field in the data object the array is
	/// stored. See vtkDataObject::FieldAssociations for detail.
	/// </summary>
	public virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
	{
		vtkAlgorithm_SetInputArrayToProcess_88(GetCppThis(), idx, port, connection, fieldAssociation, fieldAttributeType);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetInputArrayToProcess_89(HandleRef pThis, int idx, HandleRef info);

	/// <summary>
	/// Set the input data arrays that this algorithm will
	/// process. Specifically the idx array that this algorithm will process
	/// (starting from 0) is the array on port, connection with the specified
	/// association and name or attribute type (such as SCALARS). The
	/// fieldAssociation refers to which field in the data object the array is
	/// stored. See vtkDataObject::FieldAssociations for detail.
	/// </summary>
	public virtual void SetInputArrayToProcess(int idx, vtkInformation info)
	{
		vtkAlgorithm_SetInputArrayToProcess_89(GetCppThis(), idx, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetInputArrayToProcess_90(HandleRef pThis, int idx, int port, int connection, string fieldAssociation, string attributeTypeorName);

	/// <summary>
	/// String based versions of SetInputArrayToProcess(). Because
	/// fieldAssociation and fieldAttributeType are enums, they cannot be
	/// easily accessed from scripting language. These methods provides an
	/// easy and safe way of passing association and attribute type
	/// information. Field association is one of the following:
	/// @verbatim
	/// vtkDataObject::FIELD_ASSOCIATION_POINTS
	/// vtkDataObject::FIELD_ASSOCIATION_CELLS
	/// vtkDataObject::FIELD_ASSOCIATION_NONE
	/// vtkDataObject::FIELD_ASSOCIATION_POINTS_THEN_CELLS
	/// @endverbatim
	/// Attribute type is one of the following:
	/// @verbatim
	/// vtkDataSetAttributes::SCALARS
	/// vtkDataSetAttributes::VECTORS
	/// vtkDataSetAttributes::NORMALS
	/// vtkDataSetAttributes::TCOORDS
	/// vtkDataSetAttributes::TENSORS
	/// @endverbatim
	/// If the last argument is not an attribute type, it is assumed to
	/// be an array name.
	/// </summary>
	public virtual void SetInputArrayToProcess(int idx, int port, int connection, string fieldAssociation, string attributeTypeorName)
	{
		vtkAlgorithm_SetInputArrayToProcess_90(GetCppThis(), idx, port, connection, fieldAssociation, attributeTypeorName);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetInputConnection_91(HandleRef pThis, int port, HandleRef input);

	/// <summary>
	/// Set the connection for the given input port index.  Each input
	/// port of a filter has a specific purpose.  A port may have zero or
	/// more connections and the required number is specified by each
	/// filter.  Setting the connection with this method removes all
	/// other connections from the port.  To add more than one connection
	/// use AddInputConnection().
	///
	/// The input for the connection is the output port of another
	/// filter, which is obtained with GetOutputPort().  Typical usage is
	///
	/// filter2-&gt;SetInputConnection(0, filter1-&gt;GetOutputPort(0)).
	/// </summary>
	public virtual void SetInputConnection(int port, vtkAlgorithmOutput input)
	{
		vtkAlgorithm_SetInputConnection_91(GetCppThis(), port, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetInputConnection_92(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the connection for the given input port index.  Each input
	/// port of a filter has a specific purpose.  A port may have zero or
	/// more connections and the required number is specified by each
	/// filter.  Setting the connection with this method removes all
	/// other connections from the port.  To add more than one connection
	/// use AddInputConnection().
	///
	/// The input for the connection is the output port of another
	/// filter, which is obtained with GetOutputPort().  Typical usage is
	///
	/// filter2-&gt;SetInputConnection(0, filter1-&gt;GetOutputPort(0)).
	/// </summary>
	public virtual void SetInputConnection(vtkAlgorithmOutput input)
	{
		vtkAlgorithm_SetInputConnection_92(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetInputDataObject_93(HandleRef pThis, int port, HandleRef data);

	/// <summary>
	/// Sets the data-object as an input on the given port index. Setting the input with
	/// this method removes all other connections from the port. Internally, this
	/// method creates a vtkTrivialProducer instance and sets that as the
	/// input-connection for the given port. It is safe to call this method repeatedly
	/// with the same input data object. The MTime of the vtkAlgorithm will not
	/// change unless the data object changed.
	/// </summary>
	public virtual void SetInputDataObject(int port, vtkDataObject data)
	{
		vtkAlgorithm_SetInputDataObject_93(GetCppThis(), port, data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetInputDataObject_94(HandleRef pThis, HandleRef data);

	/// <summary>
	/// Sets the data-object as an input on the given port index. Setting the input with
	/// this method removes all other connections from the port. Internally, this
	/// method creates a vtkTrivialProducer instance and sets that as the
	/// input-connection for the given port. It is safe to call this method repeatedly
	/// with the same input data object. The MTime of the vtkAlgorithm will not
	/// change unless the data object changed.
	/// </summary>
	public virtual void SetInputDataObject(vtkDataObject data)
	{
		vtkAlgorithm_SetInputDataObject_94(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetProgressObserver_95(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// If an ProgressObserver is set, the algorithm will report
	/// progress through it rather than directly. This means that
	/// it will call UpdateProgress() on the ProgressObserver rather
	/// than itself report it and set progress.
	/// This is most useful in situations where multiple threads
	/// are executing an algorithm at the same time and want to
	/// handle progress locally.
	/// </summary>
	public void SetProgressObserver(vtkProgressObserver arg0)
	{
		vtkAlgorithm_SetProgressObserver_95(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetProgressShiftScale_96(HandleRef pThis, double shift, double scale);

	/// <summary>
	/// Specify the shift and scale values to use to apply to the progress amount
	/// when `UpdateProgress` is called. By default shift is set to 0, and scale is
	/// set to 1.0. This is useful when the vtkAlgorithm instance is used as an
	/// internal algorithm to solve only a part of a whole problem.
	///
	/// If calling on a internal vtkAlgorithm, make sure you take into
	/// consideration that values set of the outer vtkAlgorithm as well since the
	/// outer vtkAlgorithm itself may be nested in another algorithm.
	///
	/// @note SetProgressShiftScale does not modify the MTime of the algorithm.
	/// </summary>
	public void SetProgressShiftScale(double shift, double scale)
	{
		vtkAlgorithm_SetProgressShiftScale_96(GetCppThis(), shift, scale);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetProgressText_97(HandleRef pThis, string ptext);

	/// <summary>
	/// Set the current text message associated with the progress state.
	/// This may be used by a calling process/GUI.
	/// Note: Because SetProgressText() is called from inside RequestData()
	/// it does not modify the algorithm object. Algorithms are not
	/// allowed to modify themselves from inside RequestData().
	/// </summary>
	public void SetProgressText(string ptext)
	{
		vtkAlgorithm_SetProgressText_97(GetCppThis(), ptext);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_SetReleaseDataFlag_98(HandleRef pThis, int arg0);

	/// <summary>
	/// Turn release data flag on or off for all output ports.
	/// </summary>
	public virtual void SetReleaseDataFlag(int arg0)
	{
		vtkAlgorithm_SetReleaseDataFlag_98(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_Update_99(HandleRef pThis, int port, HandleRef requests);

	/// <summary>
	/// This method enables the passing of data requests to the algorithm
	/// to be used during execution (in addition to bringing a particular
	/// port up-to-date). The requests argument should contain an information
	/// object for each port that requests need to be passed. For each
	/// of those, the pipeline will copy all keys to the output information
	/// before execution. This is equivalent to:
	/// \verbatim
	/// algorithm-&gt;UpdateInformation();
	/// for (int i=0; i&lt;algorithm-&gt;GetNumberOfOutputPorts(); i++)
	/// {
	/// vtkInformation* portRequests = requests-&gt;GetInformationObject(i);
	/// if (portRequests)
	/// {
	/// algorithm-&gt;GetOutputInformation(i)-&gt;Append(portRequests);
	/// }
	/// }
	/// algorithm-&gt;Update();
	/// \endverbatim
	/// Available requests include UPDATE_PIECE_NUMBER(), UPDATE_NUMBER_OF_PIECES()
	/// UPDATE_EXTENT() etc etc.
	/// </summary>
	public virtual int Update(int port, vtkInformationVector requests)
	{
		return vtkAlgorithm_Update_99(GetCppThis(), port, requests?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_Update_100(HandleRef pThis, HandleRef requests);

	/// <summary>
	/// Convenience method to update an algorithm after passing requests
	/// to its first output port. See documentation for
	/// Update(int port, vtkInformationVector* requests) for details.
	/// </summary>
	public virtual int Update(vtkInformation requests)
	{
		return vtkAlgorithm_Update_100(GetCppThis(), requests?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_Update_101(HandleRef pThis, int port);

	/// <summary>
	/// Bring this algorithm's outputs up-to-date.
	/// </summary>
	public virtual void Update(int port)
	{
		vtkAlgorithm_Update_101(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_Update_102(HandleRef pThis);

	/// <summary>
	/// Bring this algorithm's outputs up-to-date.
	/// </summary>
	public virtual void Update()
	{
		vtkAlgorithm_Update_102(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_UpdateDataObject_103(HandleRef pThis);

	/// <summary>
	/// Create output object(s).
	/// </summary>
	public virtual void UpdateDataObject()
	{
		vtkAlgorithm_UpdateDataObject_103(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_UpdateExtent_104(HandleRef pThis, IntPtr extents);

	/// <summary>
	/// Convenience method to update an algorithm after passing requests
	/// to its first output port.
	/// Supports extent request.
	/// </summary>
	public virtual int UpdateExtent(IntPtr extents)
	{
		return vtkAlgorithm_UpdateExtent_104(GetCppThis(), extents);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_UpdateExtentIsEmpty_105(HandleRef pThis, HandleRef pinfo, HandleRef output);

	/// <summary>
	/// This detects when the UpdateExtent will generate no data
	/// This condition is satisfied when the UpdateExtent has
	/// zero volume (0,-1,...) or the UpdateNumberOfPieces is 0.
	/// The source uses this call to determine whether to call Execute.
	/// </summary>
	public int UpdateExtentIsEmpty(vtkInformation pinfo, vtkDataObject output)
	{
		return vtkAlgorithm_UpdateExtentIsEmpty_105(GetCppThis(), pinfo?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_UpdateExtentIsEmpty_106(HandleRef pThis, HandleRef pinfo, int extentType);

	/// <summary>
	/// This detects when the UpdateExtent will generate no data
	/// This condition is satisfied when the UpdateExtent has
	/// zero volume (0,-1,...) or the UpdateNumberOfPieces is 0.
	/// The source uses this call to determine whether to call Execute.
	/// </summary>
	public int UpdateExtentIsEmpty(vtkInformation pinfo, int extentType)
	{
		return vtkAlgorithm_UpdateExtentIsEmpty_106(GetCppThis(), pinfo?.GetCppThis() ?? default(HandleRef), extentType);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_UpdateInformation_107(HandleRef pThis);

	/// <summary>
	/// Bring the algorithm's information up-to-date.
	/// </summary>
	public virtual void UpdateInformation()
	{
		vtkAlgorithm_UpdateInformation_107(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_UpdatePiece_108(HandleRef pThis, int piece, int numPieces, int ghostLevels, IntPtr extents);

	/// <summary>
	/// Convenience method to update an algorithm after passing requests
	/// to its first output port. See documentation for
	/// Update(int port, vtkInformationVector* requests) for details.
	/// Supports piece and extent (optional) requests.
	/// </summary>
	public virtual int UpdatePiece(int piece, int numPieces, int ghostLevels, IntPtr extents)
	{
		return vtkAlgorithm_UpdatePiece_108(GetCppThis(), piece, numPieces, ghostLevels, extents);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_UpdateProgress_109(HandleRef pThis, double amount);

	/// <summary>
	/// Update the progress of the process object. If a ProgressMethod exists,
	/// executes it.  Then set the Progress ivar to amount. The parameter amount
	/// should range between (0,1).
	/// </summary>
	public void UpdateProgress(double amount)
	{
		vtkAlgorithm_UpdateProgress_109(GetCppThis(), amount);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlgorithm_UpdateTimeStep_110(HandleRef pThis, double time, int piece, int numPieces, int ghostLevels, IntPtr extents);

	/// <summary>
	/// Convenience method to update an algorithm after passing requests
	/// to its first output port. See documentation for
	/// Update(int port, vtkInformationVector* requests) for details.
	/// Supports time, piece (optional) and extent (optional) requests.
	/// </summary>
	public virtual int UpdateTimeStep(double time, int piece, int numPieces, int ghostLevels, IntPtr extents)
	{
		return vtkAlgorithm_UpdateTimeStep_110(GetCppThis(), time, piece, numPieces, ghostLevels, extents);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlgorithm_UpdateWholeExtent_111(HandleRef pThis);

	/// <summary>
	/// Bring this algorithm's outputs up-to-date.
	/// </summary>
	public virtual void UpdateWholeExtent()
	{
		vtkAlgorithm_UpdateWholeExtent_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAlgorithm_UsesGarbageCollector_112(HandleRef pThis);

	/// <summary>
	/// Participate in garbage collection.
	/// </summary>
	public override bool UsesGarbageCollector()
	{
		return (vtkAlgorithm_UsesGarbageCollector_112(GetCppThis()) != 0) ? true : false;
	}
}
