using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUndirectedGraphAlgorithm
/// </summary>
/// <remarks>
///    Superclass for algorithms that produce undirected graph as output
///
///
/// vtkUndirectedGraphAlgorithm is a convenience class to make writing algorithms
/// easier. It is also designed to help transition old algorithms to the new
/// pipeline edgehitecture. There are some assumptions and defaults made by this
/// class you should be aware of. This class defaults such that your filter
/// will have one input port and one output port. If that is not the case
/// simply change it with SetNumberOfInputPorts etc. See this class
/// constructor for the default. This class also provides a FillInputPortInfo
/// method that by default says that all inputs will be Graph. If that
/// isn't the case then please override this method in your subclass.
///
/// @par Thanks:
/// Thanks to Patricia Crossno, Ken Moreland, Andrew Wilson and Brian Wylie from
/// Sandia National Laboratories for their help in developing this class.
/// </remarks>
public class vtkUndirectedGraphAlgorithm : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUndirectedGraphAlgorithm";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUndirectedGraphAlgorithm()
	{
		MRClassNameKey = "class vtkUndirectedGraphAlgorithm";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUndirectedGraphAlgorithm"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUndirectedGraphAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUndirectedGraphAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUndirectedGraphAlgorithm New()
	{
		vtkUndirectedGraphAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUndirectedGraphAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUndirectedGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUndirectedGraphAlgorithm()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUndirectedGraphAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkUndirectedGraphAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUndirectedGraphAlgorithm_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUndirectedGraphAlgorithm_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUndirectedGraphAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUndirectedGraphAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public vtkUndirectedGraph GetOutput()
	{
		vtkUndirectedGraph vtkUndirectedGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUndirectedGraphAlgorithm_GetOutput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUndirectedGraph2 = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUndirectedGraph2.Register(null);
			}
		}
		return vtkUndirectedGraph2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUndirectedGraphAlgorithm_GetOutput_04(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public vtkUndirectedGraph GetOutput(int index)
	{
		vtkUndirectedGraph vtkUndirectedGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUndirectedGraphAlgorithm_GetOutput_04(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUndirectedGraph2 = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUndirectedGraph2.Register(null);
			}
		}
		return vtkUndirectedGraph2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUndirectedGraphAlgorithm_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUndirectedGraphAlgorithm_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUndirectedGraphAlgorithm_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUndirectedGraphAlgorithm_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUndirectedGraphAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUndirectedGraphAlgorithm NewInstance()
	{
		vtkUndirectedGraphAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUndirectedGraphAlgorithm_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUndirectedGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUndirectedGraphAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUndirectedGraphAlgorithm SafeDownCast(vtkObjectBase o)
	{
		vtkUndirectedGraphAlgorithm vtkUndirectedGraphAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUndirectedGraphAlgorithm_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUndirectedGraphAlgorithm2 = (vtkUndirectedGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUndirectedGraphAlgorithm2.Register(null);
			}
		}
		return vtkUndirectedGraphAlgorithm2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUndirectedGraphAlgorithm_SetInputData_10(HandleRef pThis, HandleRef obj);

	/// <summary>
	/// Assign a data object as input. Note that this method does not
	/// establish a pipeline connection. Use SetInputConnection() to
	/// setup a pipeline connection.
	/// </summary>
	public void SetInputData(vtkDataObject obj)
	{
		vtkUndirectedGraphAlgorithm_SetInputData_10(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUndirectedGraphAlgorithm_SetInputData_11(HandleRef pThis, int index, HandleRef obj);

	/// <summary>
	/// Assign a data object as input. Note that this method does not
	/// establish a pipeline connection. Use SetInputConnection() to
	/// setup a pipeline connection.
	/// </summary>
	public void SetInputData(int index, vtkDataObject obj)
	{
		vtkUndirectedGraphAlgorithm_SetInputData_11(GetCppThis(), index, obj?.GetCppThis() ?? default(HandleRef));
	}
}
