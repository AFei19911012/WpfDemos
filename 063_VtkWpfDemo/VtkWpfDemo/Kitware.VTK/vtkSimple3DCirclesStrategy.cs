using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSimple3DCirclesStrategy
/// </summary>
/// <remarks>
///    places vertices on circles in 3D
///
///
/// Places vertices on circles depending on the graph vertices hierarchy level.
/// The source graph could be vtkDirectedAcyclicGraph or vtkDirectedGraph if MarkedStartPoints array
/// was added. The algorithm collects the standalone points, too and take them to a separated circle.
/// If method is FixedRadiusMethod, the radius of the circles will be equal. If method is
/// FixedDistanceMethod, the distance between the points on circles will be equal.
///
/// In first step initial points are searched. A point is initial, if its in degree equal zero and
/// out degree is greater than zero (or marked by MarkedStartVertices and out degree is greater than
/// zero). Independent vertices (in and out degree equal zero) are collected separatelly. In second
/// step the hierarchical level is generated for every vertex. In third step the hierarchical order
/// is generated. If a vertex has no hierarchical level and it is not independent, the graph has loop
/// so the algorithm exit with error message. Finally the vertices positions are calculated by the
/// hierarchical order and by the vertices hierarchy levels.
///
/// @par Thanks:
/// Ferenc Nasztanovics, naszta@naszta.hu, Budapest University of Technology and Economics,
/// Department of Structural Mechanics
///
/// @par References:
/// in 3D rotation was used: http://en.citizendium.org/wiki/Rotation_matrix
/// </remarks>
public class vtkSimple3DCirclesStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum FixedDistanceMethod_WrapperEnum
	{
		/// <summary>enum member</summary>
		FixedDistanceMethod = 1,
		/// <summary>enum member</summary>
		FixedRadiusMethod = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSimple3DCirclesStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSimple3DCirclesStrategy()
	{
		MRClassNameKey = "class vtkSimple3DCirclesStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimple3DCirclesStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSimple3DCirclesStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimple3DCirclesStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSimple3DCirclesStrategy New()
	{
		vtkSimple3DCirclesStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimple3DCirclesStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimple3DCirclesStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSimple3DCirclesStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSimple3DCirclesStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_AutoHeightOff_01(HandleRef pThis);

	/// <summary>
	/// Set or get auto height (Default: false). If AutoHeight is true, (r(i+1) - r(i-1))/Height will
	/// be smaller than tan(MinimumRadian). If you want equal distances and parallel circles, you
	/// should turn off AutoHeight.
	/// </summary>
	public virtual void AutoHeightOff()
	{
		vtkSimple3DCirclesStrategy_AutoHeightOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_AutoHeightOn_02(HandleRef pThis);

	/// <summary>
	/// Set or get auto height (Default: false). If AutoHeight is true, (r(i+1) - r(i-1))/Height will
	/// be smaller than tan(MinimumRadian). If you want equal distances and parallel circles, you
	/// should turn off AutoHeight.
	/// </summary>
	public virtual void AutoHeightOn()
	{
		vtkSimple3DCirclesStrategy_AutoHeightOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_ForceToUseUniversalStartPointsFinderOff_03(HandleRef pThis);

	/// <summary>
	/// Set or get ForceToUseUniversalStartPointsFinder. If ForceToUseUniversalStartPointsFinder is
	/// true, MarkedStartVertices won't be used. In this case the input graph must be
	/// vtkDirectedAcyclicGraph (Default: false).
	/// </summary>
	public virtual void ForceToUseUniversalStartPointsFinderOff()
	{
		vtkSimple3DCirclesStrategy_ForceToUseUniversalStartPointsFinderOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_ForceToUseUniversalStartPointsFinderOn_04(HandleRef pThis);

	/// <summary>
	/// Set or get ForceToUseUniversalStartPointsFinder. If ForceToUseUniversalStartPointsFinder is
	/// true, MarkedStartVertices won't be used. In this case the input graph must be
	/// vtkDirectedAcyclicGraph (Default: false).
	/// </summary>
	public virtual void ForceToUseUniversalStartPointsFinderOn()
	{
		vtkSimple3DCirclesStrategy_ForceToUseUniversalStartPointsFinderOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple3DCirclesStrategy_GetAutoHeight_05(HandleRef pThis);

	/// <summary>
	/// Set or get auto height (Default: false). If AutoHeight is true, (r(i+1) - r(i-1))/Height will
	/// be smaller than tan(MinimumRadian). If you want equal distances and parallel circles, you
	/// should turn off AutoHeight.
	/// </summary>
	public virtual int GetAutoHeight()
	{
		return vtkSimple3DCirclesStrategy_GetAutoHeight_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimple3DCirclesStrategy_GetDirection_06(HandleRef pThis);

	/// <summary>
	/// Set or get the normal vector of the circles plain. The height is growing in this direction. The
	/// direction must not be zero vector. The default vector is (0.0,0.0,1.0)
	/// </summary>
	public virtual double[] GetDirection()
	{
		IntPtr intPtr = vtkSimple3DCirclesStrategy_GetDirection_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_GetDirection_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set or get the normal vector of the circles plain. The height is growing in this direction. The
	/// direction must not be zero vector. The default vector is (0.0,0.0,1.0)
	/// </summary>
	public virtual void GetDirection(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkSimple3DCirclesStrategy_GetDirection_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_GetDirection_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set or get the normal vector of the circles plain. The height is growing in this direction. The
	/// direction must not be zero vector. The default vector is (0.0,0.0,1.0)
	/// </summary>
	public virtual void GetDirection(IntPtr _arg)
	{
		vtkSimple3DCirclesStrategy_GetDirection_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple3DCirclesStrategy_GetForceToUseUniversalStartPointsFinder_09(HandleRef pThis);

	/// <summary>
	/// Set or get ForceToUseUniversalStartPointsFinder. If ForceToUseUniversalStartPointsFinder is
	/// true, MarkedStartVertices won't be used. In this case the input graph must be
	/// vtkDirectedAcyclicGraph (Default: false).
	/// </summary>
	public virtual int GetForceToUseUniversalStartPointsFinder()
	{
		return vtkSimple3DCirclesStrategy_GetForceToUseUniversalStartPointsFinder_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSimple3DCirclesStrategy_GetHeight_10(HandleRef pThis);

	/// <summary>
	/// Set or get the vertical (local z) distance between the circles. If AutoHeight is on, this is
	/// the minimal height between the circle layers
	/// </summary>
	public virtual double GetHeight()
	{
		return vtkSimple3DCirclesStrategy_GetHeight_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimple3DCirclesStrategy_GetHierarchicalLayers_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set or get hierarchical layers id by vertices (An usual vertex's layer id is greater or equal
	/// to zero. If a vertex is standalone, its layer id is -2.) If no HierarchicalLayers array is
	/// defined, vtkSimple3DCirclesStrategy will generate it automatically (default).
	/// </summary>
	public virtual vtkIntArray GetHierarchicalLayers()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimple3DCirclesStrategy_GetHierarchicalLayers_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIntArray2 = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIntArray2.Register(null);
			}
		}
		return vtkIntArray2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimple3DCirclesStrategy_GetHierarchicalOrder_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set or get hierarchical ordering of vertices (The array starts from the first vertex's id. All
	/// id must be greater or equal to zero!) If no HierarchicalOrder is defined,
	/// vtkSimple3DCirclesStrategy will generate it automatically (default).
	/// </summary>
	public virtual vtkIdTypeArray GetHierarchicalOrder()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimple3DCirclesStrategy_GetHierarchicalOrder_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimple3DCirclesStrategy_GetMarkedStartVertices_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set or get initial vertices. If MarkedStartVertices is added, loop is accepted in the graph.
	/// (If all of the loop start vertices are marked in MarkedStartVertices array.)
	/// MarkedStartVertices size must be equal with the number of the vertices in the graph. Start
	/// vertices must be marked by MarkedValue. (E.g.: if MarkedValue=3 and MarkedStartPoints is { 0,
	/// 3, 5, 3 }, the start points ids will be {1,3}.) )
	/// </summary>
	public virtual vtkAbstractArray GetMarkedStartVertices()
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimple3DCirclesStrategy_GetMarkedStartVertices_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimple3DCirclesStrategy_GetMarkedValue_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set or get MarkedValue. See: MarkedStartVertices.
	/// </summary>
	public virtual vtkVariant GetMarkedValue()
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimple3DCirclesStrategy_GetMarkedValue_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple3DCirclesStrategy_GetMethod_15(HandleRef pThis);

	/// <summary>
	/// Set or get circle generating method (FixedRadiusMethod/FixedDistanceMethod). Default is
	/// FixedRadiusMethod.
	/// </summary>
	public virtual int GetMethod()
	{
		return vtkSimple3DCirclesStrategy_GetMethod_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSimple3DCirclesStrategy_GetMinimumDegree_16(HandleRef pThis);

	/// <summary>
	/// Set or get minimum degree (used by auto height). There is no separated minimum degree, so
	/// minimum radian will be changed.
	/// </summary>
	public virtual double GetMinimumDegree()
	{
		return vtkSimple3DCirclesStrategy_GetMinimumDegree_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSimple3DCirclesStrategy_GetMinimumRadian_17(HandleRef pThis);

	/// <summary>
	/// Set or get minimum radian (used by auto height).
	/// </summary>
	public virtual double GetMinimumRadian()
	{
		return vtkSimple3DCirclesStrategy_GetMinimumRadian_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimple3DCirclesStrategy_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSimple3DCirclesStrategy_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimple3DCirclesStrategy_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSimple3DCirclesStrategy_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimple3DCirclesStrategy_GetOrigin_20(HandleRef pThis);

	/// <summary>
	/// Set or get the origin of the geometry. This is the center of the first circle. SetOrigin(x,y,z)
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkSimple3DCirclesStrategy_GetOrigin_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_GetOrigin_21(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set or get the origin of the geometry. This is the center of the first circle. SetOrigin(x,y,z)
	/// </summary>
	public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkSimple3DCirclesStrategy_GetOrigin_21(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_GetOrigin_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set or get the origin of the geometry. This is the center of the first circle. SetOrigin(x,y,z)
	/// </summary>
	public virtual void GetOrigin(IntPtr _arg)
	{
		vtkSimple3DCirclesStrategy_GetOrigin_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSimple3DCirclesStrategy_GetRadius_23(HandleRef pThis);

	/// <summary>
	/// If Method is FixedRadiusMethod: Set or get the radius of the circles.
	/// If Method is FixedDistanceMethod: Set or get the distance of the points in the circle.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkSimple3DCirclesStrategy_GetRadius_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple3DCirclesStrategy_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSimple3DCirclesStrategy_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple3DCirclesStrategy_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSimple3DCirclesStrategy_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_Layout_26(HandleRef pThis);

	/// <summary>
	/// Standard layout method
	/// </summary>
	public override void Layout()
	{
		vtkSimple3DCirclesStrategy_Layout_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimple3DCirclesStrategy_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSimple3DCirclesStrategy NewInstance()
	{
		vtkSimple3DCirclesStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimple3DCirclesStrategy_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimple3DCirclesStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimple3DCirclesStrategy_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSimple3DCirclesStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkSimple3DCirclesStrategy vtkSimple3DCirclesStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimple3DCirclesStrategy_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSimple3DCirclesStrategy2 = (vtkSimple3DCirclesStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSimple3DCirclesStrategy2.Register(null);
			}
		}
		return vtkSimple3DCirclesStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetAutoHeight_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set or get auto height (Default: false). If AutoHeight is true, (r(i+1) - r(i-1))/Height will
	/// be smaller than tan(MinimumRadian). If you want equal distances and parallel circles, you
	/// should turn off AutoHeight.
	/// </summary>
	public virtual void SetAutoHeight(int _arg)
	{
		vtkSimple3DCirclesStrategy_SetAutoHeight_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetDirection_31(HandleRef pThis, double dx, double dy, double dz);

	/// <summary>
	/// Set or get the normal vector of the circles plain. The height is growing in this direction. The
	/// direction must not be zero vector. The default vector is (0.0,0.0,1.0)
	/// </summary>
	public virtual void SetDirection(double dx, double dy, double dz)
	{
		vtkSimple3DCirclesStrategy_SetDirection_31(GetCppThis(), dx, dy, dz);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetDirection_32(HandleRef pThis, IntPtr d);

	/// <summary>
	/// Set or get the normal vector of the circles plain. The height is growing in this direction. The
	/// direction must not be zero vector. The default vector is (0.0,0.0,1.0)
	/// </summary>
	public virtual void SetDirection(IntPtr d)
	{
		vtkSimple3DCirclesStrategy_SetDirection_32(GetCppThis(), d);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetForceToUseUniversalStartPointsFinder_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set or get ForceToUseUniversalStartPointsFinder. If ForceToUseUniversalStartPointsFinder is
	/// true, MarkedStartVertices won't be used. In this case the input graph must be
	/// vtkDirectedAcyclicGraph (Default: false).
	/// </summary>
	public virtual void SetForceToUseUniversalStartPointsFinder(int _arg)
	{
		vtkSimple3DCirclesStrategy_SetForceToUseUniversalStartPointsFinder_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetGraph_34(HandleRef pThis, HandleRef graph);

	/// <summary>
	/// Set graph (warning: HierarchicalOrder and HierarchicalLayers will set to zero. These reference
	/// counts will be decreased!)
	/// </summary>
	public override void SetGraph(vtkGraph graph)
	{
		vtkSimple3DCirclesStrategy_SetGraph_34(GetCppThis(), graph?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetHeight_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Set or get the vertical (local z) distance between the circles. If AutoHeight is on, this is
	/// the minimal height between the circle layers
	/// </summary>
	public virtual void SetHeight(double _arg)
	{
		vtkSimple3DCirclesStrategy_SetHeight_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetHierarchicalLayers_36(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Set or get hierarchical layers id by vertices (An usual vertex's layer id is greater or equal
	/// to zero. If a vertex is standalone, its layer id is -2.) If no HierarchicalLayers array is
	/// defined, vtkSimple3DCirclesStrategy will generate it automatically (default).
	/// </summary>
	public virtual void SetHierarchicalLayers(vtkIntArray _arg)
	{
		vtkSimple3DCirclesStrategy_SetHierarchicalLayers_36(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetHierarchicalOrder_37(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Set or get hierarchical ordering of vertices (The array starts from the first vertex's id. All
	/// id must be greater or equal to zero!) If no HierarchicalOrder is defined,
	/// vtkSimple3DCirclesStrategy will generate it automatically (default).
	/// </summary>
	public virtual void SetHierarchicalOrder(vtkIdTypeArray _arg)
	{
		vtkSimple3DCirclesStrategy_SetHierarchicalOrder_37(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetMarkedStartVertices_38(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Set or get initial vertices. If MarkedStartVertices is added, loop is accepted in the graph.
	/// (If all of the loop start vertices are marked in MarkedStartVertices array.)
	/// MarkedStartVertices size must be equal with the number of the vertices in the graph. Start
	/// vertices must be marked by MarkedValue. (E.g.: if MarkedValue=3 and MarkedStartPoints is { 0,
	/// 3, 5, 3 }, the start points ids will be {1,3}.) )
	/// </summary>
	public virtual void SetMarkedStartVertices(vtkAbstractArray _arg)
	{
		vtkSimple3DCirclesStrategy_SetMarkedStartVertices_38(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetMarkedValue_39(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Set or get MarkedValue. See: MarkedStartVertices.
	/// </summary>
	public virtual void SetMarkedValue(vtkVariant _arg)
	{
		vtkSimple3DCirclesStrategy_SetMarkedValue_39(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetMethod_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Set or get circle generating method (FixedRadiusMethod/FixedDistanceMethod). Default is
	/// FixedRadiusMethod.
	/// </summary>
	public virtual void SetMethod(int _arg)
	{
		vtkSimple3DCirclesStrategy_SetMethod_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetMinimumDegree_41(HandleRef pThis, double degree);

	/// <summary>
	/// Set or get minimum degree (used by auto height). There is no separated minimum degree, so
	/// minimum radian will be changed.
	/// </summary>
	public virtual void SetMinimumDegree(double degree)
	{
		vtkSimple3DCirclesStrategy_SetMinimumDegree_41(GetCppThis(), degree);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetMinimumRadian_42(HandleRef pThis, double _arg);

	/// <summary>
	/// Set or get minimum radian (used by auto height).
	/// </summary>
	public virtual void SetMinimumRadian(double _arg)
	{
		vtkSimple3DCirclesStrategy_SetMinimumRadian_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetOrigin_43(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set or get the origin of the geometry. This is the center of the first circle. SetOrigin(x,y,z)
	/// </summary>
	public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkSimple3DCirclesStrategy_SetOrigin_43(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetOrigin_44(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set or get the origin of the geometry. This is the center of the first circle. SetOrigin(x,y,z)
	/// </summary>
	public virtual void SetOrigin(IntPtr _arg)
	{
		vtkSimple3DCirclesStrategy_SetOrigin_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple3DCirclesStrategy_SetRadius_45(HandleRef pThis, double _arg);

	/// <summary>
	/// If Method is FixedRadiusMethod: Set or get the radius of the circles.
	/// If Method is FixedDistanceMethod: Set or get the distance of the points in the circle.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkSimple3DCirclesStrategy_SetRadius_45(GetCppThis(), _arg);
	}
}
