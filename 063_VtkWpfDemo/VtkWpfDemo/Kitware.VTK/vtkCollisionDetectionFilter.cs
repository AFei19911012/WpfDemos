using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkCollisionDetectionFilter
/// </summary>
/// <remarks>
///  performs collision determination between two polyhedral surfaces
///
/// vtkCollisionDetectionFilter performs collision determination between
///  two polyhedral surfaces using two instances of vtkOBBTree. Set the
///  polydata inputs, the tolerance and transforms or matrices. If
///  CollisionMode is set to AllContacts, the Contacts output will be lines
///  of contact.  If CollisionMode is FirstContact or HalfContacts then the
///  Contacts output will be vertices.  See below for an explanation of
///  these options.
///
///  This class can be used to clip one polydata surface with another,
///  using the Contacts output as a loop set in vtkSelectPolyData
///
/// @authors Goodwin Lawlor, Bill Lorensen
/// </remarks>
public class vtkCollisionDetectionFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public enum CollisionModes
	{
		/// <summary>enum member</summary>
		VTK_ALL_CONTACTS,
		/// <summary>enum member</summary>
		VTK_FIRST_CONTACT,
		/// <summary>enum member</summary>
		VTK_HALF_CONTACTS
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCollisionDetectionFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCollisionDetectionFilter()
	{
		MRClassNameKey = "class vtkCollisionDetectionFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollisionDetectionFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCollisionDetectionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollisionDetectionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static vtkCollisionDetectionFilter New()
	{
		vtkCollisionDetectionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollisionDetectionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCollisionDetectionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public vtkCollisionDetectionFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCollisionDetectionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_GenerateScalarsOff_01(HandleRef pThis);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual void GenerateScalarsOff()
	{
		vtkCollisionDetectionFilter_GenerateScalarsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_GenerateScalarsOn_02(HandleRef pThis);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual void GenerateScalarsOn()
	{
		vtkCollisionDetectionFilter_GenerateScalarsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkCollisionDetectionFilter_GetBoxTolerance_03(HandleRef pThis);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual float GetBoxTolerance()
	{
		return vtkCollisionDetectionFilter_GetBoxTolerance_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCollisionDetectionFilter_GetCellTolerance_04(HandleRef pThis);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual double GetCellTolerance()
	{
		return vtkCollisionDetectionFilter_GetCellTolerance_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollisionDetectionFilter_GetCollisionMode_05(HandleRef pThis);

	/// <summary>
	/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
	/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
	/// point.
	/// </summary>
	public virtual int GetCollisionMode()
	{
		return vtkCollisionDetectionFilter_GetCollisionMode_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollisionDetectionFilter_GetCollisionModeAsString_06(HandleRef pThis);

	/// <summary>
	/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
	/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
	/// point.
	/// </summary>
	public string GetCollisionModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkCollisionDetectionFilter_GetCollisionModeAsString_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollisionDetectionFilter_GetCollisionModeMaxValue_07(HandleRef pThis);

	/// <summary>
	/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
	/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
	/// point.
	/// </summary>
	public virtual int GetCollisionModeMaxValue()
	{
		return vtkCollisionDetectionFilter_GetCollisionModeMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollisionDetectionFilter_GetCollisionModeMinValue_08(HandleRef pThis);

	/// <summary>
	/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
	/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
	/// point.
	/// </summary>
	public virtual int GetCollisionModeMinValue()
	{
		return vtkCollisionDetectionFilter_GetCollisionModeMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollisionDetectionFilter_GetContactCells_09(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// the "ContactCells" field array in outputs 0 and 1. These arrays index contacting
	/// cells (eg) index 50 of array 0 points to a cell (triangle) which contacts/intersects
	/// a cell at index 50 of array 1. This method is equivalent to
	/// GetOutput(i)-&gt;GetFieldData()-&gt;GetArray("ContactCells")
	/// </summary>
	public vtkIdTypeArray GetContactCells(int i)
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollisionDetectionFilter_GetContactCells_09(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollisionDetectionFilter_GetContactsOutput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public vtkPolyData GetContactsOutput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollisionDetectionFilter_GetContactsOutput_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollisionDetectionFilter_GetContactsOutputPort_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public vtkAlgorithmOutput GetContactsOutputPort()
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollisionDetectionFilter_GetContactsOutputPort_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollisionDetectionFilter_GetGenerateScalars_12(HandleRef pThis);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual int GetGenerateScalars()
	{
		return vtkCollisionDetectionFilter_GetGenerateScalars_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollisionDetectionFilter_GetInputData_13(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set and Get the input vtk polydata models
	/// </summary>
	public vtkPolyData GetInputData(int i)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollisionDetectionFilter_GetInputData_13(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkCollisionDetectionFilter_GetMTime_14(HandleRef pThis);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkCollisionDetectionFilter_GetMTime_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollisionDetectionFilter_GetMatrix_15(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public vtkMatrix4x4 GetMatrix(int i)
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollisionDetectionFilter_GetMatrix_15(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollisionDetectionFilter_GetNumberOfBoxTests_16(HandleRef pThis);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual int GetNumberOfBoxTests()
	{
		return vtkCollisionDetectionFilter_GetNumberOfBoxTests_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollisionDetectionFilter_GetNumberOfCellsPerNode_17(HandleRef pThis);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual int GetNumberOfCellsPerNode()
	{
		return vtkCollisionDetectionFilter_GetNumberOfCellsPerNode_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollisionDetectionFilter_GetNumberOfContacts_18(HandleRef pThis);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public int GetNumberOfContacts()
	{
		return vtkCollisionDetectionFilter_GetNumberOfContacts_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCollisionDetectionFilter_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCollisionDetectionFilter_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCollisionDetectionFilter_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCollisionDetectionFilter_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkCollisionDetectionFilter_GetOpacity_21(HandleRef pThis);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual float GetOpacity()
	{
		return vtkCollisionDetectionFilter_GetOpacity_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkCollisionDetectionFilter_GetOpacityMaxValue_22(HandleRef pThis);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual float GetOpacityMaxValue()
	{
		return vtkCollisionDetectionFilter_GetOpacityMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkCollisionDetectionFilter_GetOpacityMinValue_23(HandleRef pThis);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual float GetOpacityMinValue()
	{
		return vtkCollisionDetectionFilter_GetOpacityMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollisionDetectionFilter_GetTransform_24(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public vtkLinearTransform GetTransform(int i)
	{
		vtkLinearTransform vtkLinearTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollisionDetectionFilter_GetTransform_24(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLinearTransform2 = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLinearTransform2.Register(null);
			}
		}
		return vtkLinearTransform2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollisionDetectionFilter_IntersectPolygonWithPolygon_25(HandleRef pThis, int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol2, IntPtr x1, IntPtr x2, int CollisionMode);

	/// <summary>
	/// Description:
	/// Intersect two polygons, return x1 and x2 as the two points of intersection. If
	/// CollisionMode = VTK_ALL_CONTACTS, both contact points are found. If
	/// CollisionMode = VTK_FIRST_CONTACT or VTK_HALF_CONTACTS, only
	/// one contact point is found.
	/// </summary>
	public int IntersectPolygonWithPolygon(int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol2, IntPtr x1, IntPtr x2, int CollisionMode)
	{
		return vtkCollisionDetectionFilter_IntersectPolygonWithPolygon_25(GetCppThis(), npts, pts, bounds, npts2, pts2, bounds2, tol2, x1, x2, CollisionMode);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollisionDetectionFilter_IsA_26(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCollisionDetectionFilter_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollisionDetectionFilter_IsTypeOf_27(string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCollisionDetectionFilter_IsTypeOf_27(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollisionDetectionFilter_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new vtkCollisionDetectionFilter NewInstance()
	{
		vtkCollisionDetectionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollisionDetectionFilter_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCollisionDetectionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollisionDetectionFilter_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static vtkCollisionDetectionFilter SafeDownCast(vtkObjectBase o)
	{
		vtkCollisionDetectionFilter vtkCollisionDetectionFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollisionDetectionFilter_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCollisionDetectionFilter2 = (vtkCollisionDetectionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCollisionDetectionFilter2.Register(null);
			}
		}
		return vtkCollisionDetectionFilter2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_SetBoxTolerance_31(HandleRef pThis, float _arg);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual void SetBoxTolerance(float _arg)
	{
		vtkCollisionDetectionFilter_SetBoxTolerance_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_SetCellTolerance_32(HandleRef pThis, double _arg);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual void SetCellTolerance(double _arg)
	{
		vtkCollisionDetectionFilter_SetCellTolerance_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_SetCollisionMode_33(HandleRef pThis, int _arg);

	/// <summary>
	/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
	/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
	/// point.
	/// </summary>
	public virtual void SetCollisionMode(int _arg)
	{
		vtkCollisionDetectionFilter_SetCollisionMode_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_SetCollisionModeToAllContacts_34(HandleRef pThis);

	/// <summary>
	/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
	/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
	/// point.
	/// </summary>
	public void SetCollisionModeToAllContacts()
	{
		vtkCollisionDetectionFilter_SetCollisionModeToAllContacts_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_SetCollisionModeToFirstContact_35(HandleRef pThis);

	/// <summary>
	/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
	/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
	/// point.
	/// </summary>
	public void SetCollisionModeToFirstContact()
	{
		vtkCollisionDetectionFilter_SetCollisionModeToFirstContact_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_SetCollisionModeToHalfContacts_36(HandleRef pThis);

	/// <summary>
	/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
	/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
	/// point.
	/// </summary>
	public void SetCollisionModeToHalfContacts()
	{
		vtkCollisionDetectionFilter_SetCollisionModeToHalfContacts_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_SetGenerateScalars_37(HandleRef pThis, int _arg);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual void SetGenerateScalars(int _arg)
	{
		vtkCollisionDetectionFilter_SetGenerateScalars_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_SetInputData_38(HandleRef pThis, int i, HandleRef model);

	/// <summary>
	/// Set and Get the input vtk polydata models
	/// </summary>
	public void SetInputData(int i, vtkPolyData model)
	{
		vtkCollisionDetectionFilter_SetInputData_38(GetCppThis(), i, model?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_SetMatrix_39(HandleRef pThis, int i, HandleRef matrix);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public void SetMatrix(int i, vtkMatrix4x4 matrix)
	{
		vtkCollisionDetectionFilter_SetMatrix_39(GetCppThis(), i, matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_SetNumberOfCellsPerNode_40(HandleRef pThis, int _arg);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual void SetNumberOfCellsPerNode(int _arg)
	{
		vtkCollisionDetectionFilter_SetNumberOfCellsPerNode_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_SetOpacity_41(HandleRef pThis, float _arg);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public virtual void SetOpacity(float _arg)
	{
		vtkCollisionDetectionFilter_SetOpacity_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollisionDetectionFilter_SetTransform_42(HandleRef pThis, int i, HandleRef transform);

	/// <summary>
	///  is equivalent to GetOutputPort(2)/GetOutput(2)
	/// </summary>
	public void SetTransform(int i, vtkLinearTransform transform)
	{
		vtkCollisionDetectionFilter_SetTransform_42(GetCppThis(), i, transform?.GetCppThis() ?? default(HandleRef));
	}
}
