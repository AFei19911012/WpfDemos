using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMNITransformWriter
/// </summary>
/// <remarks>
///    A writer for MNI transformation files.
///
/// The MNI .xfm file format is used to store geometrical
/// transformations.  Three kinds of transformations are supported by
/// the file format: affine, thin-plate spline, and grid transformations.
/// This file format was developed at the McConnell Brain Imaging Centre
/// at the Montreal Neurological Institute and is used by their software.
/// </remarks>
/// <seealso>
///
/// vtkMINCImageWriter vtkMNITransformReader
/// @par Thanks:
/// Thanks to David Gobbi for writing this class and Atamai Inc. for
/// contributing it to VTK.
/// </seealso>
public class vtkMNITransformWriter : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMNITransformWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMNITransformWriter()
	{
		MRClassNameKey = "class vtkMNITransformWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNITransformWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMNITransformWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITransformWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMNITransformWriter New()
	{
		vtkMNITransformWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITransformWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMNITransformWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMNITransformWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMNITransformWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITransformWriter_AddTransform_01(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Add another transform to the file.  The next time that
	/// SetTransform is called, all added transforms will be
	/// removed.
	/// </summary>
	public virtual void AddTransform(vtkAbstractTransform transform)
	{
		vtkMNITransformWriter_AddTransform_01(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITransformWriter_GetComments_02(HandleRef pThis);

	/// <summary>
	/// Set comments to be added to the file.
	/// </summary>
	public virtual string GetComments()
	{
		return Marshal.PtrToStringAnsi(vtkMNITransformWriter_GetComments_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITransformWriter_GetDescriptiveName_03(HandleRef pThis);

	/// <summary>
	/// Get the name of this file format.
	/// </summary>
	public virtual string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkMNITransformWriter_GetDescriptiveName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITransformWriter_GetFileExtensions_04(HandleRef pThis);

	/// <summary>
	/// Get the extension for this file format.
	/// </summary>
	public virtual string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkMNITransformWriter_GetFileExtensions_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITransformWriter_GetFileName_05(HandleRef pThis);

	/// <summary>
	/// Set the file name.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMNITransformWriter_GetFileName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMNITransformWriter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMNITransformWriter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMNITransformWriter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMNITransformWriter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMNITransformWriter_GetNumberOfTransforms_08(HandleRef pThis);

	/// <summary>
	/// Get the number of transforms that will be written.
	/// </summary>
	public virtual int GetNumberOfTransforms()
	{
		return vtkMNITransformWriter_GetNumberOfTransforms_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITransformWriter_GetTransform_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the transform.
	/// </summary>
	public virtual vtkAbstractTransform GetTransform()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITransformWriter_GetTransform_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMNITransformWriter_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMNITransformWriter_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMNITransformWriter_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMNITransformWriter_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITransformWriter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMNITransformWriter NewInstance()
	{
		vtkMNITransformWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITransformWriter_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMNITransformWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITransformWriter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMNITransformWriter SafeDownCast(vtkObjectBase o)
	{
		vtkMNITransformWriter vtkMNITransformWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITransformWriter_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMNITransformWriter2 = (vtkMNITransformWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMNITransformWriter2.Register(null);
			}
		}
		return vtkMNITransformWriter2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITransformWriter_SetComments_15(HandleRef pThis, string _arg);

	/// <summary>
	/// Set comments to be added to the file.
	/// </summary>
	public virtual void SetComments(string _arg)
	{
		vtkMNITransformWriter_SetComments_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITransformWriter_SetFileName_16(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the file name.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkMNITransformWriter_SetFileName_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITransformWriter_SetTransform_17(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Set the transform.
	/// </summary>
	public virtual void SetTransform(vtkAbstractTransform transform)
	{
		vtkMNITransformWriter_SetTransform_17(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITransformWriter_Write_18(HandleRef pThis);

	/// <summary>
	/// Write the file.
	/// </summary>
	public virtual void Write()
	{
		vtkMNITransformWriter_Write_18(GetCppThis());
	}
}
