using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMatrixToLinearTransform
/// </summary>
/// <remarks>
///    convert a matrix to a transform
///
/// This is a very simple class which allows a vtkMatrix4x4 to be used in
/// place of a vtkLinearTransform or vtkAbstractTransform.  For example,
/// if you use it as a proxy between a matrix and vtkTransformPolyDataFilter
/// then any modifications to the matrix will automatically be reflected in
/// the output of the filter.
/// </remarks>
/// <seealso>
///
/// vtkTransform vtkMatrix4x4 vtkMatrixToHomogeneousTransform
/// </seealso>
public class vtkMatrixToLinearTransform : vtkLinearTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMatrixToLinearTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMatrixToLinearTransform()
	{
		MRClassNameKey = "class vtkMatrixToLinearTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrixToLinearTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMatrixToLinearTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrixToLinearTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMatrixToLinearTransform New()
	{
		vtkMatrixToLinearTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrixToLinearTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMatrixToLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMatrixToLinearTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMatrixToLinearTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrixToLinearTransform_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the input matrix.  Any modifications to the matrix will be
	/// reflected in the transformation.
	/// </summary>
	public virtual vtkMatrix4x4 GetInput()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrixToLinearTransform_GetInput_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkMatrixToLinearTransform_GetMTime_02(HandleRef pThis);

	/// <summary>
	/// Get the MTime: this is the bit of magic that makes everything work.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkMatrixToLinearTransform_GetMTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMatrixToLinearTransform_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMatrixToLinearTransform_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMatrixToLinearTransform_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMatrixToLinearTransform_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrixToLinearTransform_Inverse_05(HandleRef pThis);

	/// <summary>
	/// The input matrix is left as-is, but the transformation matrix
	/// is inverted.
	/// </summary>
	public override void Inverse()
	{
		vtkMatrixToLinearTransform_Inverse_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMatrixToLinearTransform_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMatrixToLinearTransform_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMatrixToLinearTransform_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMatrixToLinearTransform_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrixToLinearTransform_MakeTransform_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make a new transform of the same type.
	/// </summary>
	public override vtkAbstractTransform MakeTransform()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrixToLinearTransform_MakeTransform_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrixToLinearTransform_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMatrixToLinearTransform NewInstance()
	{
		vtkMatrixToLinearTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrixToLinearTransform_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMatrixToLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrixToLinearTransform_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMatrixToLinearTransform SafeDownCast(vtkObjectBase o)
	{
		vtkMatrixToLinearTransform vtkMatrixToLinearTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrixToLinearTransform_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrixToLinearTransform2 = (vtkMatrixToLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrixToLinearTransform2.Register(null);
			}
		}
		return vtkMatrixToLinearTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrixToLinearTransform_SetInput_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the input matrix.  Any modifications to the matrix will be
	/// reflected in the transformation.
	/// </summary>
	public virtual void SetInput(vtkMatrix4x4 arg0)
	{
		vtkMatrixToLinearTransform_SetInput_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
