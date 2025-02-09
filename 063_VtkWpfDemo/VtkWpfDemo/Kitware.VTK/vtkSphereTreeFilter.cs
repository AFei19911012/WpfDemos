using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkSphereTreeFilter
/// </summary>
/// <remarks>
///  represent a sphere tree as vtkPolyData
///
/// vtkSphereTreeFilter is a filter that produces a vtkPolyData representation
/// of a sphere tree (vtkSphereTree). Basically it generates a point, a scalar
/// radius, and tree level number for the cell spheres and/or the different levels
/// in the tree hierarchy (assuming that the hierarchy is built). The output
/// can be glyphed using a filter like vtkGlyph3D to actually visualize the
/// sphere tree. The primary use of this class is for visualization of sphere
/// trees, and debugging the construction and use of sphere trees.
///
/// Additional capabilities include production of candidate spheres based on
/// geometric queries. For example, queries based on a point, infinite line,
/// and infinite plane are possible.
///
/// Note that this class may create a sphere tree, and then build it, for the
/// input dataset to this filter (if no sphere tree is provided). If the user
/// specifies a sphere tree, then the specified sphere tree is used. Thus the
/// input to the filter is optional. Consequently this filter can act like a source,
/// or as a filter in a pipeline.
///
/// </remarks>
/// <seealso>
///
/// vtkSphereTree vtkPlaneCutter
/// </seealso>
public class vtkSphereTreeFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSphereTreeFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSphereTreeFilter()
	{
		MRClassNameKey = "class vtkSphereTreeFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereTreeFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSphereTreeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTreeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the sphere tree filter.
	/// </summary>
	public new static vtkSphereTreeFilter New()
	{
		vtkSphereTreeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereTreeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereTreeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the sphere tree filter.
	/// </summary>
	public vtkSphereTreeFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSphereTreeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSphereTreeFilter_GetExtractionMode_01(HandleRef pThis);

	/// <summary>
	/// Specify what information this filter is to extract from the sphere
	/// tree. Options include: spheres that make up one or more levels; spheres
	/// that intersect a specified plane; spheres that intersect a specified line;
	/// and spheres that intersect a specified point. What is extracted are sphere
	/// centers, a radius, and an optional level. By default the specified levels
	/// are extracted.
	/// </summary>
	public virtual int GetExtractionMode()
	{
		return vtkSphereTreeFilter_GetExtractionMode_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTreeFilter_GetExtractionModeAsString_02(HandleRef pThis);

	/// <summary>
	/// Specify what information this filter is to extract from the sphere
	/// tree. Options include: spheres that make up one or more levels; spheres
	/// that intersect a specified plane; spheres that intersect a specified line;
	/// and spheres that intersect a specified point. What is extracted are sphere
	/// centers, a radius, and an optional level. By default the specified levels
	/// are extracted.
	/// </summary>
	public string GetExtractionModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkSphereTreeFilter_GetExtractionModeAsString_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTreeFilter_GetLevel_03(HandleRef pThis);

	/// <summary>
	/// Specify the level of the tree to extract (used when ExtractionMode is
	/// set to Levels). A value of (-1) means all levels. Note that level 0 is
	/// the root of the sphere tree. By default all levels are extracted. Note
	/// that if TreeHierarchy is off, then it is only possible to extract leaf
	/// spheres (i.e., spheres for each cell of the associated dataset).
	/// </summary>
	public virtual int GetLevel()
	{
		return vtkSphereTreeFilter_GetLevel_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTreeFilter_GetLevelMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Specify the level of the tree to extract (used when ExtractionMode is
	/// set to Levels). A value of (-1) means all levels. Note that level 0 is
	/// the root of the sphere tree. By default all levels are extracted. Note
	/// that if TreeHierarchy is off, then it is only possible to extract leaf
	/// spheres (i.e., spheres for each cell of the associated dataset).
	/// </summary>
	public virtual int GetLevelMaxValue()
	{
		return vtkSphereTreeFilter_GetLevelMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTreeFilter_GetLevelMinValue_05(HandleRef pThis);

	/// <summary>
	/// Specify the level of the tree to extract (used when ExtractionMode is
	/// set to Levels). A value of (-1) means all levels. Note that level 0 is
	/// the root of the sphere tree. By default all levels are extracted. Note
	/// that if TreeHierarchy is off, then it is only possible to extract leaf
	/// spheres (i.e., spheres for each cell of the associated dataset).
	/// </summary>
	public virtual int GetLevelMinValue()
	{
		return vtkSphereTreeFilter_GetLevelMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkSphereTreeFilter_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// Modified GetMTime because the sphere tree may have changed.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSphereTreeFilter_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTreeFilter_GetNormal_07(HandleRef pThis);

	/// <summary>
	/// Specify a plane used to extract spheres (used when ExtractionMode is set
	/// to Plane). The plane Normal plus Point define an infinite plane.
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkSphereTreeFilter_GetNormal_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_GetNormal_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a plane used to extract spheres (used when ExtractionMode is set
	/// to Plane). The plane Normal plus Point define an infinite plane.
	/// </summary>
	public virtual void GetNormal(IntPtr data)
	{
		vtkSphereTreeFilter_GetNormal_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereTreeFilter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSphereTreeFilter_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereTreeFilter_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSphereTreeFilter_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTreeFilter_GetPoint_11(HandleRef pThis);

	/// <summary>
	/// Specify a point used to extract one or more leaf spheres. This method is
	/// used when extracting spheres using a point, line, or plane.
	/// </summary>
	public virtual double[] GetPoint()
	{
		IntPtr intPtr = vtkSphereTreeFilter_GetPoint_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_GetPoint_12(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a point used to extract one or more leaf spheres. This method is
	/// used when extracting spheres using a point, line, or plane.
	/// </summary>
	public virtual void GetPoint(IntPtr data)
	{
		vtkSphereTreeFilter_GetPoint_12(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTreeFilter_GetRay_13(HandleRef pThis);

	/// <summary>
	/// Specify a line used to extract spheres (used when ExtractionMode is set
	/// to Line). The Ray plus Point define an infinite line. The ray is a
	/// vector defining the direction of the line.
	/// </summary>
	public virtual double[] GetRay()
	{
		IntPtr intPtr = vtkSphereTreeFilter_GetRay_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_GetRay_14(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a line used to extract spheres (used when ExtractionMode is set
	/// to Line). The Ray plus Point define an infinite line. The ray is a
	/// vector defining the direction of the line.
	/// </summary>
	public virtual void GetRay(IntPtr data)
	{
		vtkSphereTreeFilter_GetRay_14(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTreeFilter_GetSphereTree_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify and retrieve the sphere tree.
	/// </summary>
	public virtual vtkSphereTree GetSphereTree()
	{
		vtkSphereTree vtkSphereTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereTreeFilter_GetSphereTree_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphereTree2 = (vtkSphereTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphereTree2.Register(null);
			}
		}
		return vtkSphereTree2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSphereTreeFilter_GetTreeHierarchy_16(HandleRef pThis);

	/// <summary>
	/// Enable or disable the building and generation of the sphere tree
	/// hierarchy. The hierarchy represents different levels in the tree
	/// and enables rapid traversal of the tree.
	/// </summary>
	public virtual bool GetTreeHierarchy()
	{
		return (vtkSphereTreeFilter_GetTreeHierarchy_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTreeFilter_IsA_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSphereTreeFilter_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTreeFilter_IsTypeOf_18(string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSphereTreeFilter_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTreeFilter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new vtkSphereTreeFilter NewInstance()
	{
		vtkSphereTreeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereTreeFilter_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereTreeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTreeFilter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static vtkSphereTreeFilter SafeDownCast(vtkObjectBase o)
	{
		vtkSphereTreeFilter vtkSphereTreeFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereTreeFilter_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphereTreeFilter2 = (vtkSphereTreeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphereTreeFilter2.Register(null);
			}
		}
		return vtkSphereTreeFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetExtractionMode_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify what information this filter is to extract from the sphere
	/// tree. Options include: spheres that make up one or more levels; spheres
	/// that intersect a specified plane; spheres that intersect a specified line;
	/// and spheres that intersect a specified point. What is extracted are sphere
	/// centers, a radius, and an optional level. By default the specified levels
	/// are extracted.
	/// </summary>
	public virtual void SetExtractionMode(int _arg)
	{
		vtkSphereTreeFilter_SetExtractionMode_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetExtractionModeToLevels_23(HandleRef pThis);

	/// <summary>
	/// Specify what information this filter is to extract from the sphere
	/// tree. Options include: spheres that make up one or more levels; spheres
	/// that intersect a specified plane; spheres that intersect a specified line;
	/// and spheres that intersect a specified point. What is extracted are sphere
	/// centers, a radius, and an optional level. By default the specified levels
	/// are extracted.
	/// </summary>
	public void SetExtractionModeToLevels()
	{
		vtkSphereTreeFilter_SetExtractionModeToLevels_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetExtractionModeToLine_24(HandleRef pThis);

	/// <summary>
	/// Specify what information this filter is to extract from the sphere
	/// tree. Options include: spheres that make up one or more levels; spheres
	/// that intersect a specified plane; spheres that intersect a specified line;
	/// and spheres that intersect a specified point. What is extracted are sphere
	/// centers, a radius, and an optional level. By default the specified levels
	/// are extracted.
	/// </summary>
	public void SetExtractionModeToLine()
	{
		vtkSphereTreeFilter_SetExtractionModeToLine_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetExtractionModeToPlane_25(HandleRef pThis);

	/// <summary>
	/// Specify what information this filter is to extract from the sphere
	/// tree. Options include: spheres that make up one or more levels; spheres
	/// that intersect a specified plane; spheres that intersect a specified line;
	/// and spheres that intersect a specified point. What is extracted are sphere
	/// centers, a radius, and an optional level. By default the specified levels
	/// are extracted.
	/// </summary>
	public void SetExtractionModeToPlane()
	{
		vtkSphereTreeFilter_SetExtractionModeToPlane_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetExtractionModeToPoint_26(HandleRef pThis);

	/// <summary>
	/// Specify what information this filter is to extract from the sphere
	/// tree. Options include: spheres that make up one or more levels; spheres
	/// that intersect a specified plane; spheres that intersect a specified line;
	/// and spheres that intersect a specified point. What is extracted are sphere
	/// centers, a radius, and an optional level. By default the specified levels
	/// are extracted.
	/// </summary>
	public void SetExtractionModeToPoint()
	{
		vtkSphereTreeFilter_SetExtractionModeToPoint_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetLevel_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the level of the tree to extract (used when ExtractionMode is
	/// set to Levels). A value of (-1) means all levels. Note that level 0 is
	/// the root of the sphere tree. By default all levels are extracted. Note
	/// that if TreeHierarchy is off, then it is only possible to extract leaf
	/// spheres (i.e., spheres for each cell of the associated dataset).
	/// </summary>
	public virtual void SetLevel(int _arg)
	{
		vtkSphereTreeFilter_SetLevel_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetNormal_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a plane used to extract spheres (used when ExtractionMode is set
	/// to Plane). The plane Normal plus Point define an infinite plane.
	/// </summary>
	public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkSphereTreeFilter_SetNormal_28(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetNormal_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a plane used to extract spheres (used when ExtractionMode is set
	/// to Plane). The plane Normal plus Point define an infinite plane.
	/// </summary>
	public virtual void SetNormal(IntPtr _arg)
	{
		vtkSphereTreeFilter_SetNormal_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetPoint_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a point used to extract one or more leaf spheres. This method is
	/// used when extracting spheres using a point, line, or plane.
	/// </summary>
	public virtual void SetPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkSphereTreeFilter_SetPoint_30(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetPoint_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a point used to extract one or more leaf spheres. This method is
	/// used when extracting spheres using a point, line, or plane.
	/// </summary>
	public virtual void SetPoint(IntPtr _arg)
	{
		vtkSphereTreeFilter_SetPoint_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetRay_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a line used to extract spheres (used when ExtractionMode is set
	/// to Line). The Ray plus Point define an infinite line. The ray is a
	/// vector defining the direction of the line.
	/// </summary>
	public virtual void SetRay(double _arg1, double _arg2, double _arg3)
	{
		vtkSphereTreeFilter_SetRay_32(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetRay_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a line used to extract spheres (used when ExtractionMode is set
	/// to Line). The Ray plus Point define an infinite line. The ray is a
	/// vector defining the direction of the line.
	/// </summary>
	public virtual void SetRay(IntPtr _arg)
	{
		vtkSphereTreeFilter_SetRay_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetSphereTree_34(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify and retrieve the sphere tree.
	/// </summary>
	public virtual void SetSphereTree(vtkSphereTree arg0)
	{
		vtkSphereTreeFilter_SetSphereTree_34(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_SetTreeHierarchy_35(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable or disable the building and generation of the sphere tree
	/// hierarchy. The hierarchy represents different levels in the tree
	/// and enables rapid traversal of the tree.
	/// </summary>
	public virtual void SetTreeHierarchy(bool _arg)
	{
		vtkSphereTreeFilter_SetTreeHierarchy_35(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_TreeHierarchyOff_36(HandleRef pThis);

	/// <summary>
	/// Enable or disable the building and generation of the sphere tree
	/// hierarchy. The hierarchy represents different levels in the tree
	/// and enables rapid traversal of the tree.
	/// </summary>
	public virtual void TreeHierarchyOff()
	{
		vtkSphereTreeFilter_TreeHierarchyOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTreeFilter_TreeHierarchyOn_37(HandleRef pThis);

	/// <summary>
	/// Enable or disable the building and generation of the sphere tree
	/// hierarchy. The hierarchy represents different levels in the tree
	/// and enables rapid traversal of the tree.
	/// </summary>
	public virtual void TreeHierarchyOn()
	{
		vtkSphereTreeFilter_TreeHierarchyOn_37(GetCppThis());
	}
}
