using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractCellsAlongPolyLine
/// </summary>
/// <remarks>
///    Extracts input cells that are intersected by a list of input lines or poly lines
///
/// This filter extracts input cells that are intersected by a list of input lines or poly lines.
/// The lines / poly lines input is set on input port 1, as a source connection, while the input data
/// set on which cells are extracted is to be set on input port 0. The produced output is a
/// `vtkUnstructuredGrid`. Input lines can be either set inside a `vtkPolyData` or a
/// `vtkUnstructuredGrid`. If the input type has an explicit geometry, i.e. the input is not a
/// `vtkPointSet`, then the user can set the output
/// points precision using `OutputPointsPrecisions`. Otherwise, the point precision is set to be the
/// same as the input.
///
/// This filter uses multi-threading if available.
/// </remarks>
public class vtkExtractCellsAlongPolyLine : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractCellsAlongPolyLine";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractCellsAlongPolyLine()
	{
		MRClassNameKey = "class vtkExtractCellsAlongPolyLine";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractCellsAlongPolyLine"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractCellsAlongPolyLine(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCellsAlongPolyLine_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractCellsAlongPolyLine New()
	{
		vtkExtractCellsAlongPolyLine result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCellsAlongPolyLine_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractCellsAlongPolyLine)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractCellsAlongPolyLine()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractCellsAlongPolyLine_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractCellsAlongPolyLine_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractCellsAlongPolyLine_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractCellsAlongPolyLine_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractCellsAlongPolyLine_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractCellsAlongPolyLine_GetOutputPointsPrecision_03(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings. OutputPointsPrecision is DEFAULT_PRECISION
	/// by default. However, if the input is polymorphic to `vtkPointSet`, then
	/// the points precision of the input's points is used instead.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkExtractCellsAlongPolyLine_GetOutputPointsPrecision_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractCellsAlongPolyLine_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractCellsAlongPolyLine_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractCellsAlongPolyLine_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractCellsAlongPolyLine_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCellsAlongPolyLine_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractCellsAlongPolyLine NewInstance()
	{
		vtkExtractCellsAlongPolyLine result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCellsAlongPolyLine_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractCellsAlongPolyLine)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCellsAlongPolyLine_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractCellsAlongPolyLine SafeDownCast(vtkObjectBase o)
	{
		vtkExtractCellsAlongPolyLine vtkExtractCellsAlongPolyLine2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCellsAlongPolyLine_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractCellsAlongPolyLine2 = (vtkExtractCellsAlongPolyLine)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractCellsAlongPolyLine2.Register(null);
			}
		}
		return vtkExtractCellsAlongPolyLine2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCellsAlongPolyLine_SetOutputPointsPrecision_09(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings. OutputPointsPrecision is DEFAULT_PRECISION
	/// by default. However, if the input is polymorphic to `vtkPointSet`, then
	/// the points precision of the input's points is used instead.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkExtractCellsAlongPolyLine_SetOutputPointsPrecision_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCellsAlongPolyLine_SetSourceConnection_10(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the source for creating the lines to probe from. Only cells of type VTK_LINE or
	/// VTK_POLY_LINE will be processed.
	/// </summary>
	public virtual void SetSourceConnection(vtkAlgorithmOutput input)
	{
		vtkExtractCellsAlongPolyLine_SetSourceConnection_10(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}
}
