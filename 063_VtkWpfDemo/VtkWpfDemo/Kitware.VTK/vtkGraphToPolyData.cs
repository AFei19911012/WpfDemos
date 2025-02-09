using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGraphToPolyData
/// </summary>
/// <remarks>
///    convert a vtkGraph to vtkPolyData
///
///
/// Converts a vtkGraph to a vtkPolyData.  This assumes that the points
/// of the graph have already been filled (perhaps by vtkGraphLayout),
/// and converts all the edge of the graph into lines in the polydata.
/// The vertex data is passed along to the point data, and the edge data
/// is passed along to the cell data.
///
/// Only the owned graph edges (i.e. edges with ghost level 0) are copied
/// into the vtkPolyData.
/// </remarks>
public class vtkGraphToPolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGraphToPolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGraphToPolyData()
	{
		MRClassNameKey = "class vtkGraphToPolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphToPolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGraphToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphToPolyData New()
	{
		vtkGraphToPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphToPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGraphToPolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGraphToPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphToPolyData_EdgeGlyphOutputOff_01(HandleRef pThis);

	/// <summary>
	/// Create a second output containing points and orientation vectors
	/// for drawing arrows or other glyphs on edges.  This output should be
	/// set as the first input to vtkGlyph3D to place glyphs on the edges.
	/// vtkGlyphSource2D's VTK_EDGEARROW_GLYPH provides a good glyph for
	/// drawing arrows.
	/// Default value is off.
	/// </summary>
	public virtual void EdgeGlyphOutputOff()
	{
		vtkGraphToPolyData_EdgeGlyphOutputOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphToPolyData_EdgeGlyphOutputOn_02(HandleRef pThis);

	/// <summary>
	/// Create a second output containing points and orientation vectors
	/// for drawing arrows or other glyphs on edges.  This output should be
	/// set as the first input to vtkGlyph3D to place glyphs on the edges.
	/// vtkGlyphSource2D's VTK_EDGEARROW_GLYPH provides a good glyph for
	/// drawing arrows.
	/// Default value is off.
	/// </summary>
	public virtual void EdgeGlyphOutputOn()
	{
		vtkGraphToPolyData_EdgeGlyphOutputOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphToPolyData_GetEdgeGlyphOutput_03(HandleRef pThis);

	/// <summary>
	/// Create a second output containing points and orientation vectors
	/// for drawing arrows or other glyphs on edges.  This output should be
	/// set as the first input to vtkGlyph3D to place glyphs on the edges.
	/// vtkGlyphSource2D's VTK_EDGEARROW_GLYPH provides a good glyph for
	/// drawing arrows.
	/// Default value is off.
	/// </summary>
	public virtual bool GetEdgeGlyphOutput()
	{
		return (vtkGraphToPolyData_GetEdgeGlyphOutput_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGraphToPolyData_GetEdgeGlyphPosition_04(HandleRef pThis);

	/// <summary>
	/// The position of the glyph point along the edge.
	/// 0 puts a glyph point at the source of each edge.
	/// 1 puts a glyph point at the target of each edge.
	/// An intermediate value will place the glyph point between the source and target.
	/// The default value is 1.
	/// </summary>
	public virtual double GetEdgeGlyphPosition()
	{
		return vtkGraphToPolyData_GetEdgeGlyphPosition_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphToPolyData_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGraphToPolyData_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphToPolyData_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGraphToPolyData_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphToPolyData_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGraphToPolyData_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphToPolyData_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGraphToPolyData_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphToPolyData_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGraphToPolyData NewInstance()
	{
		vtkGraphToPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphToPolyData_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphToPolyData_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphToPolyData SafeDownCast(vtkObjectBase o)
	{
		vtkGraphToPolyData vtkGraphToPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphToPolyData_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphToPolyData2 = (vtkGraphToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphToPolyData2.Register(null);
			}
		}
		return vtkGraphToPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphToPolyData_SetEdgeGlyphOutput_12(HandleRef pThis, byte _arg);

	/// <summary>
	/// Create a second output containing points and orientation vectors
	/// for drawing arrows or other glyphs on edges.  This output should be
	/// set as the first input to vtkGlyph3D to place glyphs on the edges.
	/// vtkGlyphSource2D's VTK_EDGEARROW_GLYPH provides a good glyph for
	/// drawing arrows.
	/// Default value is off.
	/// </summary>
	public virtual void SetEdgeGlyphOutput(bool _arg)
	{
		vtkGraphToPolyData_SetEdgeGlyphOutput_12(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphToPolyData_SetEdgeGlyphPosition_13(HandleRef pThis, double _arg);

	/// <summary>
	/// The position of the glyph point along the edge.
	/// 0 puts a glyph point at the source of each edge.
	/// 1 puts a glyph point at the target of each edge.
	/// An intermediate value will place the glyph point between the source and target.
	/// The default value is 1.
	/// </summary>
	public virtual void SetEdgeGlyphPosition(double _arg)
	{
		vtkGraphToPolyData_SetEdgeGlyphPosition_13(GetCppThis(), _arg);
	}
}
