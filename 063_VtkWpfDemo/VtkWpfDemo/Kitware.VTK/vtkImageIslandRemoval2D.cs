using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageIslandRemoval2D
/// </summary>
/// <remarks>
///    Removes small clusters in masks.
///
/// vtkImageIslandRemoval2D computes the area of separate islands in
/// a mask image.  It removes any island that has less than AreaThreshold
/// pixels.  Output has the same ScalarType as input.  It generates
/// the whole 2D output image for any output request.
/// </remarks>
public class vtkImageIslandRemoval2D : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageIslandRemoval2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageIslandRemoval2D()
	{
		MRClassNameKey = "class vtkImageIslandRemoval2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageIslandRemoval2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageIslandRemoval2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageIslandRemoval2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Constructor: Sets default filter to be identity.
	/// </summary>
	public new static vtkImageIslandRemoval2D New()
	{
		vtkImageIslandRemoval2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageIslandRemoval2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageIslandRemoval2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Constructor: Sets default filter to be identity.
	/// </summary>
	public vtkImageIslandRemoval2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageIslandRemoval2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageIslandRemoval2D_GetAreaThreshold_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the cutoff area for removal
	/// </summary>
	public virtual int GetAreaThreshold()
	{
		return vtkImageIslandRemoval2D_GetAreaThreshold_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageIslandRemoval2D_GetIslandValue_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the value to remove.
	/// </summary>
	public virtual double GetIslandValue()
	{
		return vtkImageIslandRemoval2D_GetIslandValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageIslandRemoval2D_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Constructor: Sets default filter to be identity.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageIslandRemoval2D_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageIslandRemoval2D_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Constructor: Sets default filter to be identity.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageIslandRemoval2D_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageIslandRemoval2D_GetReplaceValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the value to put in the place of removed pixels.
	/// </summary>
	public virtual double GetReplaceValue()
	{
		return vtkImageIslandRemoval2D_GetReplaceValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageIslandRemoval2D_GetSquareNeighborhood_06(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to use 4 or 8 neighbors
	/// </summary>
	public virtual int GetSquareNeighborhood()
	{
		return vtkImageIslandRemoval2D_GetSquareNeighborhood_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageIslandRemoval2D_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Constructor: Sets default filter to be identity.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageIslandRemoval2D_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageIslandRemoval2D_IsTypeOf_08(string type);

	/// <summary>
	/// Constructor: Sets default filter to be identity.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageIslandRemoval2D_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageIslandRemoval2D_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Constructor: Sets default filter to be identity.
	/// </summary>
	public new vtkImageIslandRemoval2D NewInstance()
	{
		vtkImageIslandRemoval2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageIslandRemoval2D_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageIslandRemoval2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageIslandRemoval2D_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Constructor: Sets default filter to be identity.
	/// </summary>
	public new static vtkImageIslandRemoval2D SafeDownCast(vtkObjectBase o)
	{
		vtkImageIslandRemoval2D vtkImageIslandRemoval2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageIslandRemoval2D_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageIslandRemoval2D2 = (vtkImageIslandRemoval2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageIslandRemoval2D2.Register(null);
			}
		}
		return vtkImageIslandRemoval2D2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIslandRemoval2D_SetAreaThreshold_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the cutoff area for removal
	/// </summary>
	public virtual void SetAreaThreshold(int _arg)
	{
		vtkImageIslandRemoval2D_SetAreaThreshold_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIslandRemoval2D_SetIslandValue_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the value to remove.
	/// </summary>
	public virtual void SetIslandValue(double _arg)
	{
		vtkImageIslandRemoval2D_SetIslandValue_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIslandRemoval2D_SetReplaceValue_14(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the value to put in the place of removed pixels.
	/// </summary>
	public virtual void SetReplaceValue(double _arg)
	{
		vtkImageIslandRemoval2D_SetReplaceValue_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIslandRemoval2D_SetSquareNeighborhood_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether to use 4 or 8 neighbors
	/// </summary>
	public virtual void SetSquareNeighborhood(int _arg)
	{
		vtkImageIslandRemoval2D_SetSquareNeighborhood_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIslandRemoval2D_SquareNeighborhoodOff_16(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to use 4 or 8 neighbors
	/// </summary>
	public virtual void SquareNeighborhoodOff()
	{
		vtkImageIslandRemoval2D_SquareNeighborhoodOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageIslandRemoval2D_SquareNeighborhoodOn_17(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to use 4 or 8 neighbors
	/// </summary>
	public virtual void SquareNeighborhoodOn()
	{
		vtkImageIslandRemoval2D_SquareNeighborhoodOn_17(GetCppThis());
	}
}
