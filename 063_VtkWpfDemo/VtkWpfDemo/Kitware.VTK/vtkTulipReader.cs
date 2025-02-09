using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTulipReader
/// </summary>
/// <remarks>
///    Reads tulip graph files.
///
///
/// vtkTulipReader reads in files in the Tulip format.
/// Definition of the Tulip file format can be found online at:
/// http://tulip.labri.fr/tlpformat.php
/// An example is the following
/// &lt;code&gt;
/// (nodes 0 1 2 3 4 5 6 7 8 9)
/// (edge 0 0 1)
/// (edge 1 1 2)
/// (edge 2 2 3)
/// (edge 3 3 4)
/// (edge 4 4 5)
/// (edge 5 5 6)
/// (edge 6 6 7)
/// (edge 7 7 8)
/// (edge 8 8 9)
/// (edge 9 9 0)
/// (edge 10 0 5)
/// (edge 11 2 7)
/// (edge 12 4 9)
/// &lt;/code&gt;
/// where "nodes" defines all the nodes ids in the graph, and "edge"
/// is a triple of edge id, source vertex id, and target vertex id.
/// The graph is read in as undirected graph. Pedigree ids are set on the output
/// graph's vertices and edges that match the node and edge ids defined in the
/// Tulip file.
///
/// Clusters are output as a vtkAnnotationLayers on output port 1. Each cluster
/// name is used to create an annotation layer, and each cluster with that name
/// is added to the layer as a vtkSelectionNode. Nesting hierarchies are treated
/// as if they were flat. See vtkGraphAnnotationLayersFilter for an example of
/// how the clusters can be represented visually.
///
/// @attention
/// Only string, int, and double properties are supported. Display information
/// is discarded.
///
/// @par Thanks:
/// Thanks to Colin Myers, University of Leeds for extending this implementation.
/// </remarks>
public class vtkTulipReader : vtkUndirectedGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTulipReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTulipReader()
	{
		MRClassNameKey = "class vtkTulipReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTulipReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTulipReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTulipReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTulipReader New()
	{
		vtkTulipReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTulipReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTulipReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTulipReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTulipReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTulipReader_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// The Tulip file name.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkTulipReader_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTulipReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTulipReader_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTulipReader_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTulipReader_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTulipReader_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTulipReader_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTulipReader_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTulipReader_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTulipReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTulipReader NewInstance()
	{
		vtkTulipReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTulipReader_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTulipReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTulipReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTulipReader SafeDownCast(vtkObjectBase o)
	{
		vtkTulipReader vtkTulipReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTulipReader_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTulipReader2 = (vtkTulipReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTulipReader2.Register(null);
			}
		}
		return vtkTulipReader2;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTulipReader_SetFileName_09(HandleRef pThis, string _arg);

	/// <summary>
	/// The Tulip file name.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkTulipReader_SetFileName_09(GetCppThis(), _arg);
	}
}
