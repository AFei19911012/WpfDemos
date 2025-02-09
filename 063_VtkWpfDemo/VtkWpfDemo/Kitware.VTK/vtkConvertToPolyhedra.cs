using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkConvertToPolyhedra
/// </summary>
/// <remarks>
///    convert 3D linear cells to vtkPolyhedra
///
/// vtkConvertToPolyhedra is a filter that takes a vtkUnstructuredGrid as
/// input and produces a vtkUnstructuredGrid on output, converting 3D linear
/// cells such as tetrahedra, hexahedra, wedges, and pyramids into
/// vtkPolyhedron.
///
/// @warning
/// Certain cells are skipped and not converted, this includes cells of dimension
/// two or less (e.g., triangles, quads, lines, verts, and so on); and higher
/// order cells that cannot easily be converted to vtkPolyhedra. (TODO: tessellate
/// high-order 3D cell faces and then use these to form the polyhedra.)
///
/// @warning
/// This filter is typically used for testing. In general, processing linear cells
/// is preferable to processing polyhedra due to differences in speed of processing,
/// and memory requirements.
///
/// </remarks>
/// <seealso>
///
/// vtkUnstructuredGrid vtkPolyhedron
/// </seealso>
public class vtkConvertToPolyhedra : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkConvertToPolyhedra";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkConvertToPolyhedra()
	{
		MRClassNameKey = "class vtkConvertToPolyhedra";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvertToPolyhedra"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkConvertToPolyhedra(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertToPolyhedra_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public new static vtkConvertToPolyhedra New()
	{
		vtkConvertToPolyhedra result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertToPolyhedra_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConvertToPolyhedra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public vtkConvertToPolyhedra()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkConvertToPolyhedra_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkConvertToPolyhedra_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkConvertToPolyhedra_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConvertToPolyhedra_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkConvertToPolyhedra_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkConvertToPolyhedra_GetOutputAllCells_03(HandleRef pThis);

	/// <summary>
	/// Indicate whether to include non-polyhedral cells in the filter output.
	/// Non-polyhedral cells are cells which cannot be converted to polyhedra,
	/// for example cells of dimension &lt; 3, and higher-order cells.
	/// If enabled, the output will contain a mix of polyhedra and non-polyhedra
	/// cells. If disabled, only polyhedra cells will be output. By default, this
	/// is disabled.
	/// </summary>
	public virtual bool GetOutputAllCells()
	{
		return (vtkConvertToPolyhedra_GetOutputAllCells_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvertToPolyhedra_IsA_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkConvertToPolyhedra_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvertToPolyhedra_IsTypeOf_05(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkConvertToPolyhedra_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertToPolyhedra_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public new vtkConvertToPolyhedra NewInstance()
	{
		vtkConvertToPolyhedra result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertToPolyhedra_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConvertToPolyhedra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertToPolyhedra_OutputAllCellsOff_08(HandleRef pThis);

	/// <summary>
	/// Indicate whether to include non-polyhedral cells in the filter output.
	/// Non-polyhedral cells are cells which cannot be converted to polyhedra,
	/// for example cells of dimension &lt; 3, and higher-order cells.
	/// If enabled, the output will contain a mix of polyhedra and non-polyhedra
	/// cells. If disabled, only polyhedra cells will be output. By default, this
	/// is disabled.
	/// </summary>
	public virtual void OutputAllCellsOff()
	{
		vtkConvertToPolyhedra_OutputAllCellsOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertToPolyhedra_OutputAllCellsOn_09(HandleRef pThis);

	/// <summary>
	/// Indicate whether to include non-polyhedral cells in the filter output.
	/// Non-polyhedral cells are cells which cannot be converted to polyhedra,
	/// for example cells of dimension &lt; 3, and higher-order cells.
	/// If enabled, the output will contain a mix of polyhedra and non-polyhedra
	/// cells. If disabled, only polyhedra cells will be output. By default, this
	/// is disabled.
	/// </summary>
	public virtual void OutputAllCellsOn()
	{
		vtkConvertToPolyhedra_OutputAllCellsOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertToPolyhedra_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public new static vtkConvertToPolyhedra SafeDownCast(vtkObjectBase o)
	{
		vtkConvertToPolyhedra vtkConvertToPolyhedra2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertToPolyhedra_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkConvertToPolyhedra2 = (vtkConvertToPolyhedra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkConvertToPolyhedra2.Register(null);
			}
		}
		return vtkConvertToPolyhedra2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertToPolyhedra_SetOutputAllCells_11(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to include non-polyhedral cells in the filter output.
	/// Non-polyhedral cells are cells which cannot be converted to polyhedra,
	/// for example cells of dimension &lt; 3, and higher-order cells.
	/// If enabled, the output will contain a mix of polyhedra and non-polyhedra
	/// cells. If disabled, only polyhedra cells will be output. By default, this
	/// is disabled.
	/// </summary>
	public virtual void SetOutputAllCells(bool _arg)
	{
		vtkConvertToPolyhedra_SetOutputAllCells_11(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
