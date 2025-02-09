using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTessellatedBoxSource
/// </summary>
/// <remarks>
///    Create a polygonal representation of a box
/// with a given level of subdivision.
///
/// vtkTessellatedBoxSource creates a axis-aligned box defined by its bounds
/// and a level of subdivision. Connectivity is strong: points of the vertices
/// and inside the edges are shared between faces. In other words, faces are
/// connected. Each face looks like a grid of quads, each quad is composed of
/// 2 triangles.
/// Given a level of subdivision `l', each edge has `l'+2 points, `l' of them
/// are internal edge points, the 2 other ones are the vertices.
/// Each face has a total of (`l'+2)*(`l'+2) points, 4 of them are vertices,
/// 4*`l' are internal edge points, it remains `l'^2 internal face points.
///
/// This source only generate geometry, no DataArrays like normals or texture
/// coordinates.
/// </remarks>
public class vtkTessellatedBoxSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTessellatedBoxSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTessellatedBoxSource()
	{
		MRClassNameKey = "class vtkTessellatedBoxSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTessellatedBoxSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTessellatedBoxSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTessellatedBoxSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTessellatedBoxSource New()
	{
		vtkTessellatedBoxSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTessellatedBoxSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTessellatedBoxSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTessellatedBoxSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTessellatedBoxSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTessellatedBoxSource_DuplicateSharedPointsOff_01(HandleRef pThis);

	/// <summary>
	/// Flag to tell the source to duplicate points shared between faces
	/// (vertices of the box and internal edge points). Initial value is false.
	/// Implementation note: duplicating points is an easier method to implement
	/// than a minimal number of points.
	/// </summary>
	public virtual void DuplicateSharedPointsOff()
	{
		vtkTessellatedBoxSource_DuplicateSharedPointsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatedBoxSource_DuplicateSharedPointsOn_02(HandleRef pThis);

	/// <summary>
	/// Flag to tell the source to duplicate points shared between faces
	/// (vertices of the box and internal edge points). Initial value is false.
	/// Implementation note: duplicating points is an easier method to implement
	/// than a minimal number of points.
	/// </summary>
	public virtual void DuplicateSharedPointsOn()
	{
		vtkTessellatedBoxSource_DuplicateSharedPointsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTessellatedBoxSource_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Bounds of the box in world coordinates. This a 6-uple of xmin,xmax,ymin,
	/// ymax,zmin and zmax. Initial value is (-0.5,0.5,-0.5,0.5,-0.5,0.5), bounds
	/// of a cube of length 1 centered at (0,0,0). Bounds are defined such that
	/// xmin&lt;=xmax, ymin&lt;=ymax and zmin&lt;zmax.
	/// \post xmin&lt;=xmax &amp;&amp; ymin&lt;=ymax &amp;&amp; zmin&lt;zmax
	/// </summary>
	public virtual double[] GetBounds()
	{
		IntPtr intPtr = vtkTessellatedBoxSource_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatedBoxSource_GetBounds_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Bounds of the box in world coordinates. This a 6-uple of xmin,xmax,ymin,
	/// ymax,zmin and zmax. Initial value is (-0.5,0.5,-0.5,0.5,-0.5,0.5), bounds
	/// of a cube of length 1 centered at (0,0,0). Bounds are defined such that
	/// xmin&lt;=xmax, ymin&lt;=ymax and zmin&lt;zmax.
	/// \post xmin&lt;=xmax &amp;&amp; ymin&lt;=ymax &amp;&amp; zmin&lt;zmax
	/// </summary>
	public virtual void GetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkTessellatedBoxSource_GetBounds_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatedBoxSource_GetBounds_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Bounds of the box in world coordinates. This a 6-uple of xmin,xmax,ymin,
	/// ymax,zmin and zmax. Initial value is (-0.5,0.5,-0.5,0.5,-0.5,0.5), bounds
	/// of a cube of length 1 centered at (0,0,0). Bounds are defined such that
	/// xmin&lt;=xmax, ymin&lt;=ymax and zmin&lt;zmax.
	/// \post xmin&lt;=xmax &amp;&amp; ymin&lt;=ymax &amp;&amp; zmin&lt;zmax
	/// </summary>
	public virtual void GetBounds(IntPtr _arg)
	{
		vtkTessellatedBoxSource_GetBounds_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatedBoxSource_GetDuplicateSharedPoints_06(HandleRef pThis);

	/// <summary>
	/// Flag to tell the source to duplicate points shared between faces
	/// (vertices of the box and internal edge points). Initial value is false.
	/// Implementation note: duplicating points is an easier method to implement
	/// than a minimal number of points.
	/// </summary>
	public virtual int GetDuplicateSharedPoints()
	{
		return vtkTessellatedBoxSource_GetDuplicateSharedPoints_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatedBoxSource_GetLevel_07(HandleRef pThis);

	/// <summary>
	/// Level of subdivision of the faces. Initial value is 0.
	/// \post positive_level: level&gt;=0
	/// </summary>
	public virtual int GetLevel()
	{
		return vtkTessellatedBoxSource_GetLevel_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTessellatedBoxSource_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTessellatedBoxSource_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTessellatedBoxSource_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTessellatedBoxSource_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatedBoxSource_GetOutputPointsPrecision_10(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkTessellatedBoxSource_GetOutputPointsPrecision_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatedBoxSource_GetQuads_11(HandleRef pThis);

	/// <summary>
	/// Flag to tell the source to generate either a quad or two triangle for a
	/// set of four points. Initial value is false (generate triangles).
	/// </summary>
	public virtual int GetQuads()
	{
		return vtkTessellatedBoxSource_GetQuads_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatedBoxSource_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTessellatedBoxSource_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatedBoxSource_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTessellatedBoxSource_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTessellatedBoxSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTessellatedBoxSource NewInstance()
	{
		vtkTessellatedBoxSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTessellatedBoxSource_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTessellatedBoxSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatedBoxSource_QuadsOff_16(HandleRef pThis);

	/// <summary>
	/// Flag to tell the source to generate either a quad or two triangle for a
	/// set of four points. Initial value is false (generate triangles).
	/// </summary>
	public virtual void QuadsOff()
	{
		vtkTessellatedBoxSource_QuadsOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatedBoxSource_QuadsOn_17(HandleRef pThis);

	/// <summary>
	/// Flag to tell the source to generate either a quad or two triangle for a
	/// set of four points. Initial value is false (generate triangles).
	/// </summary>
	public virtual void QuadsOn()
	{
		vtkTessellatedBoxSource_QuadsOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTessellatedBoxSource_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTessellatedBoxSource SafeDownCast(vtkObjectBase o)
	{
		vtkTessellatedBoxSource vtkTessellatedBoxSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTessellatedBoxSource_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTessellatedBoxSource2 = (vtkTessellatedBoxSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTessellatedBoxSource2.Register(null);
			}
		}
		return vtkTessellatedBoxSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatedBoxSource_SetBounds_19(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set the bounds of the box. See GetBounds() for a detail description.
	/// \pre xmin&lt;=xmax &amp;&amp; ymin&lt;=ymax &amp;&amp; zmin&lt;zmax
	/// </summary>
	public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkTessellatedBoxSource_SetBounds_19(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatedBoxSource_SetBounds_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the bounds of the box. See GetBounds() for a detail description.
	/// \pre xmin&lt;=xmax &amp;&amp; ymin&lt;=ymax &amp;&amp; zmin&lt;zmax
	/// </summary>
	public virtual void SetBounds(IntPtr _arg)
	{
		vtkTessellatedBoxSource_SetBounds_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatedBoxSource_SetDuplicateSharedPoints_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Flag to tell the source to duplicate points shared between faces
	/// (vertices of the box and internal edge points). Initial value is false.
	/// Implementation note: duplicating points is an easier method to implement
	/// than a minimal number of points.
	/// </summary>
	public virtual void SetDuplicateSharedPoints(int _arg)
	{
		vtkTessellatedBoxSource_SetDuplicateSharedPoints_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatedBoxSource_SetLevel_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the level of subdivision of the faces.
	/// \pre positive_level: level&gt;=0
	/// </summary>
	public virtual void SetLevel(int _arg)
	{
		vtkTessellatedBoxSource_SetLevel_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatedBoxSource_SetOutputPointsPrecision_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkTessellatedBoxSource_SetOutputPointsPrecision_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatedBoxSource_SetQuads_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Flag to tell the source to generate either a quad or two triangle for a
	/// set of four points. Initial value is false (generate triangles).
	/// </summary>
	public virtual void SetQuads(int _arg)
	{
		vtkTessellatedBoxSource_SetQuads_24(GetCppThis(), _arg);
	}
}
