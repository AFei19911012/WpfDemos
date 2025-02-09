using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkResliceCursorThickLineRepresentation
/// </summary>
/// <remarks>
///    represents a thick slab of the reslice cursor widget
///
/// This class respresents a thick reslice cursor, that can be used to
/// perform interactive thick slab MPR's through data. The class internally
/// uses vtkImageSlabReslice to do its reslicing. The slab thickness is set
/// interactively from the widget. The slab resolution (ie the number of
/// blend points) is set as the minimum spacing along any dimension from
/// the dataset.
/// </remarks>
/// <seealso>
///
/// vtkImageSlabReslice vtkResliceCursorLineRepresentation vtkResliceCursorWidget
/// </seealso>
public class vtkResliceCursorThickLineRepresentation : vtkResliceCursorLineRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorThickLineRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResliceCursorThickLineRepresentation()
	{
		MRClassNameKey = "class vtkResliceCursorThickLineRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorThickLineRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResliceCursorThickLineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorThickLineRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkResliceCursorThickLineRepresentation New()
	{
		vtkResliceCursorThickLineRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorThickLineRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursorThickLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkResliceCursorThickLineRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkResliceCursorThickLineRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorThickLineRepresentation_CreateDefaultResliceAlgorithm_01(HandleRef pThis);

	/// <summary>
	/// INTERNAL - Do not use
	/// Create the thick reformat class. This overrides the superclass
	/// implementation and creates a vtkImageSlabReslice instead of a
	/// vtkImageReslice.
	/// </summary>
	public virtual void CreateDefaultResliceAlgorithm()
	{
		vtkResliceCursorThickLineRepresentation_CreateDefaultResliceAlgorithm_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursorThickLineRepresentation_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResliceCursorThickLineRepresentation_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursorThickLineRepresentation_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResliceCursorThickLineRepresentation_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorThickLineRepresentation_IsA_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResliceCursorThickLineRepresentation_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorThickLineRepresentation_IsTypeOf_05(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResliceCursorThickLineRepresentation_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorThickLineRepresentation_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkResliceCursorThickLineRepresentation NewInstance()
	{
		vtkResliceCursorThickLineRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorThickLineRepresentation_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursorThickLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorThickLineRepresentation_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkResliceCursorThickLineRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkResliceCursorThickLineRepresentation vtkResliceCursorThickLineRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorThickLineRepresentation_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursorThickLineRepresentation2 = (vtkResliceCursorThickLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursorThickLineRepresentation2.Register(null);
			}
		}
		return vtkResliceCursorThickLineRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorThickLineRepresentation_SetResliceParameters_09(HandleRef pThis, double outputSpacingX, double outputSpacingY, int extentX, int extentY);

	/// <summary>
	/// INTERNAL - Do not use
	/// Reslice parameters which are set from vtkResliceCursorWidget based on
	/// user interactions.
	/// </summary>
	public virtual void SetResliceParameters(double outputSpacingX, double outputSpacingY, int extentX, int extentY)
	{
		vtkResliceCursorThickLineRepresentation_SetResliceParameters_09(GetCppThis(), outputSpacingX, outputSpacingY, extentX, extentY);
	}
}
