using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDIMACSGraphReader
/// </summary>
/// <remarks>
///    reads vtkGraph data from a DIMACS
/// formatted file
///
///
/// vtkDIMACSGraphReader is a source object that reads vtkGraph data files
/// from a DIMACS format.
///
/// The reader has special handlers for max-flow and graph coloring problems,
/// which are specified in the problem line as 'max' and 'edge' respectively.
/// Other graphs are treated as generic DIMACS files.
///
/// DIMACS formatted files consist of lines in which the first character in
/// in column 0 specifies the type of the line.
///
/// Generic DIMACS files have the following line types:
/// - problem statement line : p graph num_verts num_edges
/// - node line (optional)   : n node_id node_weight
/// - edge line              : a src_id trg_id edge_weight
/// - alternate edge format  : e src_id trg_id edge_weight
/// - comment lines          : c I am a comment line
/// ** note, there should be one and only one problem statement line per file.
///
///
/// DIMACS graphs are undirected and nodes are numbered 1..n
///
/// See webpage for additional formatting details.
/// -  http://dimacs.rutgers.edu/Challenges/
/// -  http://www.dis.uniroma1.it/~challenge9/format.shtml
///
/// </remarks>
/// <seealso>
///
/// vtkDIMACSGraphWriter
///
/// </seealso>
public class vtkDIMACSGraphReader : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDIMACSGraphReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDIMACSGraphReader()
	{
		MRClassNameKey = "class vtkDIMACSGraphReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDIMACSGraphReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDIMACSGraphReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDIMACSGraphReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDIMACSGraphReader New()
	{
		vtkDIMACSGraphReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDIMACSGraphReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDIMACSGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDIMACSGraphReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDIMACSGraphReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDIMACSGraphReader_GetEdgeAttributeArrayName_01(HandleRef pThis);

	/// <summary>
	/// Edge attribute array name
	/// </summary>
	public virtual string GetEdgeAttributeArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDIMACSGraphReader_GetEdgeAttributeArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDIMACSGraphReader_GetFileName_02(HandleRef pThis);

	/// <summary>
	/// The DIMACS file name.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkDIMACSGraphReader_GetFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDIMACSGraphReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDIMACSGraphReader_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDIMACSGraphReader_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDIMACSGraphReader_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDIMACSGraphReader_GetVertexAttributeArrayName_05(HandleRef pThis);

	/// <summary>
	/// Vertex attribute array name
	/// </summary>
	public virtual string GetVertexAttributeArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDIMACSGraphReader_GetVertexAttributeArrayName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDIMACSGraphReader_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDIMACSGraphReader_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDIMACSGraphReader_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDIMACSGraphReader_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDIMACSGraphReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDIMACSGraphReader NewInstance()
	{
		vtkDIMACSGraphReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDIMACSGraphReader_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDIMACSGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDIMACSGraphReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDIMACSGraphReader SafeDownCast(vtkObjectBase o)
	{
		vtkDIMACSGraphReader vtkDIMACSGraphReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDIMACSGraphReader_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDIMACSGraphReader2 = (vtkDIMACSGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDIMACSGraphReader2.Register(null);
			}
		}
		return vtkDIMACSGraphReader2;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDIMACSGraphReader_SetEdgeAttributeArrayName_11(HandleRef pThis, string _arg);

	/// <summary>
	/// Edge attribute array name
	/// </summary>
	public virtual void SetEdgeAttributeArrayName(string _arg)
	{
		vtkDIMACSGraphReader_SetEdgeAttributeArrayName_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDIMACSGraphReader_SetFileName_12(HandleRef pThis, string _arg);

	/// <summary>
	/// The DIMACS file name.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkDIMACSGraphReader_SetFileName_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDIMACSGraphReader_SetVertexAttributeArrayName_13(HandleRef pThis, string _arg);

	/// <summary>
	/// Vertex attribute array name
	/// </summary>
	public virtual void SetVertexAttributeArrayName(string _arg)
	{
		vtkDIMACSGraphReader_SetVertexAttributeArrayName_13(GetCppThis(), _arg);
	}
}
