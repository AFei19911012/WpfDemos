using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExpandSelectedGraph
/// </summary>
/// <remarks>
///    expands a selection set of a vtkGraph
///
///
/// The first input is a vtkSelection containing the selected vertices.
/// The second input is a vtkGraph.
/// This filter 'grows' the selection set in one of the following ways
/// 1) SetBFSDistance controls how many 'hops' the selection is grown
///    from each seed point in the selection set (defaults to 1)
/// 2) IncludeShortestPaths controls whether this filter tries to
///    'connect' the vertices in the selection set by computing the
///    shortest path between the vertices (if such a path exists)
/// Note: IncludeShortestPaths is currently non-functional
/// </remarks>
public class vtkExpandSelectedGraph : vtkSelectionAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExpandSelectedGraph";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExpandSelectedGraph()
	{
		MRClassNameKey = "class vtkExpandSelectedGraph";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExpandSelectedGraph"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExpandSelectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExpandSelectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExpandSelectedGraph New()
	{
		vtkExpandSelectedGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExpandSelectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExpandSelectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExpandSelectedGraph()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExpandSelectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExpandSelectedGraph_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Specify the first vtkSelection input and the second vtkGraph input.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkExpandSelectedGraph_FillInputPortInformation_01(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExpandSelectedGraph_GetBFSDistance_02(HandleRef pThis);

	/// <summary>
	/// Set/Get BFSDistance which controls how many 'hops' the selection
	/// is grown from each seed point in the selection set (defaults to 1)
	/// </summary>
	public virtual int GetBFSDistance()
	{
		return vtkExpandSelectedGraph_GetBFSDistance_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExpandSelectedGraph_GetDomain_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the vertex domain to use in the expansion.
	/// </summary>
	public virtual string GetDomain()
	{
		return Marshal.PtrToStringAnsi(vtkExpandSelectedGraph_GetDomain_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExpandSelectedGraph_GetIncludeShortestPaths_04(HandleRef pThis);

	/// <summary>
	/// Set/Get IncludeShortestPaths controls whether this filter tries to
	/// 'connect' the vertices in the selection set by computing the
	/// shortest path between the vertices (if such a path exists)
	/// Note: IncludeShortestPaths is currently non-functional
	/// </summary>
	public virtual bool GetIncludeShortestPaths()
	{
		return (vtkExpandSelectedGraph_GetIncludeShortestPaths_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExpandSelectedGraph_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExpandSelectedGraph_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExpandSelectedGraph_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExpandSelectedGraph_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExpandSelectedGraph_GetUseDomain_07(HandleRef pThis);

	/// <summary>
	/// Whether or not to use the domain when deciding to add a vertex to the
	/// expansion. Defaults to false.
	/// </summary>
	public virtual bool GetUseDomain()
	{
		return (vtkExpandSelectedGraph_GetUseDomain_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandSelectedGraph_IncludeShortestPathsOff_08(HandleRef pThis);

	/// <summary>
	/// Set/Get IncludeShortestPaths controls whether this filter tries to
	/// 'connect' the vertices in the selection set by computing the
	/// shortest path between the vertices (if such a path exists)
	/// Note: IncludeShortestPaths is currently non-functional
	/// </summary>
	public virtual void IncludeShortestPathsOff()
	{
		vtkExpandSelectedGraph_IncludeShortestPathsOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandSelectedGraph_IncludeShortestPathsOn_09(HandleRef pThis);

	/// <summary>
	/// Set/Get IncludeShortestPaths controls whether this filter tries to
	/// 'connect' the vertices in the selection set by computing the
	/// shortest path between the vertices (if such a path exists)
	/// Note: IncludeShortestPaths is currently non-functional
	/// </summary>
	public virtual void IncludeShortestPathsOn()
	{
		vtkExpandSelectedGraph_IncludeShortestPathsOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExpandSelectedGraph_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExpandSelectedGraph_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExpandSelectedGraph_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExpandSelectedGraph_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExpandSelectedGraph_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExpandSelectedGraph NewInstance()
	{
		vtkExpandSelectedGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExpandSelectedGraph_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExpandSelectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExpandSelectedGraph_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExpandSelectedGraph SafeDownCast(vtkObjectBase o)
	{
		vtkExpandSelectedGraph vtkExpandSelectedGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExpandSelectedGraph_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExpandSelectedGraph2 = (vtkExpandSelectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExpandSelectedGraph2.Register(null);
			}
		}
		return vtkExpandSelectedGraph2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandSelectedGraph_SetBFSDistance_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get BFSDistance which controls how many 'hops' the selection
	/// is grown from each seed point in the selection set (defaults to 1)
	/// </summary>
	public virtual void SetBFSDistance(int _arg)
	{
		vtkExpandSelectedGraph_SetBFSDistance_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandSelectedGraph_SetDomain_16(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the vertex domain to use in the expansion.
	/// </summary>
	public virtual void SetDomain(string _arg)
	{
		vtkExpandSelectedGraph_SetDomain_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandSelectedGraph_SetGraphConnection_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A convenience method for setting the second input (i.e. the graph).
	/// </summary>
	public void SetGraphConnection(vtkAlgorithmOutput arg0)
	{
		vtkExpandSelectedGraph_SetGraphConnection_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandSelectedGraph_SetIncludeShortestPaths_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get IncludeShortestPaths controls whether this filter tries to
	/// 'connect' the vertices in the selection set by computing the
	/// shortest path between the vertices (if such a path exists)
	/// Note: IncludeShortestPaths is currently non-functional
	/// </summary>
	public virtual void SetIncludeShortestPaths(bool _arg)
	{
		vtkExpandSelectedGraph_SetIncludeShortestPaths_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandSelectedGraph_SetUseDomain_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether or not to use the domain when deciding to add a vertex to the
	/// expansion. Defaults to false.
	/// </summary>
	public virtual void SetUseDomain(bool _arg)
	{
		vtkExpandSelectedGraph_SetUseDomain_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandSelectedGraph_UseDomainOff_20(HandleRef pThis);

	/// <summary>
	/// Whether or not to use the domain when deciding to add a vertex to the
	/// expansion. Defaults to false.
	/// </summary>
	public virtual void UseDomainOff()
	{
		vtkExpandSelectedGraph_UseDomainOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandSelectedGraph_UseDomainOn_21(HandleRef pThis);

	/// <summary>
	/// Whether or not to use the domain when deciding to add a vertex to the
	/// expansion. Defaults to false.
	/// </summary>
	public virtual void UseDomainOn()
	{
		vtkExpandSelectedGraph_UseDomainOn_21(GetCppThis());
	}
}
