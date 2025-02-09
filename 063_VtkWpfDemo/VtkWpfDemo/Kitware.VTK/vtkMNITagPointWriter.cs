using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMNITagPointWriter
/// </summary>
/// <remarks>
///    A writer for MNI tag point files.
///
/// The MNI .tag file format is used to store tag points, for use in
/// either registration or labeling of data volumes.  This file
/// format was developed at the McConnell Brain Imaging Centre at
/// the Montreal Neurological Institute and is used by their software.
/// Tag points can be stored for either one volume or two volumes,
/// and this filter can take one or two inputs.  Alternatively, the
/// points to be written can be specified by calling SetPoints().
/// </remarks>
/// <seealso>
///
/// vtkMINCImageReader vtkMNIObjectReader vtkMNITransformReader
/// @par Thanks:
/// Thanks to David Gobbi for contributing this class to VTK.
/// </seealso>
public class vtkMNITagPointWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMNITagPointWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMNITagPointWriter()
	{
		MRClassNameKey = "class vtkMNITagPointWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNITagPointWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMNITagPointWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITagPointWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMNITagPointWriter New()
	{
		vtkMNITagPointWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITagPointWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMNITagPointWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMNITagPointWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMNITagPointWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkMNITagPointWriter_GetComments_01(HandleRef pThis);

	/// <summary>
	/// Set comments to be added to the file.
	/// </summary>
	public virtual string GetComments()
	{
		return Marshal.PtrToStringAnsi(vtkMNITagPointWriter_GetComments_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITagPointWriter_GetDescriptiveName_02(HandleRef pThis);

	/// <summary>
	/// Get the name of this file format.
	/// </summary>
	public virtual string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkMNITagPointWriter_GetDescriptiveName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITagPointWriter_GetFileExtensions_03(HandleRef pThis);

	/// <summary>
	/// Get the extension for this file format.
	/// </summary>
	public virtual string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkMNITagPointWriter_GetFileExtensions_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITagPointWriter_GetFileName_04(HandleRef pThis);

	/// <summary>
	/// Specify file name of vtk polygon data file to write.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMNITagPointWriter_GetFileName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITagPointWriter_GetLabelText_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the labels (unless the input PointData has an
	/// array called LabelText). Labels are optional.
	/// </summary>
	public virtual vtkStringArray GetLabelText()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITagPointWriter_GetLabelText_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkMNITagPointWriter_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// Get the MTime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkMNITagPointWriter_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMNITagPointWriter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMNITagPointWriter_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMNITagPointWriter_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMNITagPointWriter_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITagPointWriter_GetPatientIds_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the structure ids (unless the input PointData has
	/// an array called PatientIds).  These are optional.
	/// </summary>
	public virtual vtkIntArray GetPatientIds()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITagPointWriter_GetPatientIds_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITagPointWriter_GetPoints_10(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the points (unless you set them as inputs).
	/// </summary>
	public virtual vtkPoints GetPoints(int port)
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITagPointWriter_GetPoints_10(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITagPointWriter_GetPoints_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the points (unless you set them as inputs).
	/// </summary>
	public virtual vtkPoints GetPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITagPointWriter_GetPoints_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITagPointWriter_GetStructureIds_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the structure ids (unless the input PointData has
	/// an array called StructureIds).  These are optional.
	/// </summary>
	public virtual vtkIntArray GetStructureIds()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITagPointWriter_GetStructureIds_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITagPointWriter_GetWeights_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the weights (unless the input PointData has an
	/// array called Weights).  Weights are optional.
	/// </summary>
	public virtual vtkDoubleArray GetWeights()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITagPointWriter_GetWeights_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMNITagPointWriter_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMNITagPointWriter_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMNITagPointWriter_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMNITagPointWriter_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITagPointWriter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMNITagPointWriter NewInstance()
	{
		vtkMNITagPointWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITagPointWriter_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMNITagPointWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNITagPointWriter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMNITagPointWriter SafeDownCast(vtkObjectBase o)
	{
		vtkMNITagPointWriter vtkMNITagPointWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNITagPointWriter_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMNITagPointWriter2 = (vtkMNITagPointWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMNITagPointWriter2.Register(null);
			}
		}
		return vtkMNITagPointWriter2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITagPointWriter_SetComments_19(HandleRef pThis, string _arg);

	/// <summary>
	/// Set comments to be added to the file.
	/// </summary>
	public virtual void SetComments(string _arg)
	{
		vtkMNITagPointWriter_SetComments_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITagPointWriter_SetFileName_20(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of vtk polygon data file to write.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkMNITagPointWriter_SetFileName_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITagPointWriter_SetLabelText_21(HandleRef pThis, HandleRef a);

	/// <summary>
	/// Set the labels (unless the input PointData has an
	/// array called LabelText). Labels are optional.
	/// </summary>
	public virtual void SetLabelText(vtkStringArray a)
	{
		vtkMNITagPointWriter_SetLabelText_21(GetCppThis(), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITagPointWriter_SetPatientIds_22(HandleRef pThis, HandleRef a);

	/// <summary>
	/// Set the structure ids (unless the input PointData has
	/// an array called PatientIds).  These are optional.
	/// </summary>
	public virtual void SetPatientIds(vtkIntArray a)
	{
		vtkMNITagPointWriter_SetPatientIds_22(GetCppThis(), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITagPointWriter_SetPoints_23(HandleRef pThis, int port, HandleRef points);

	/// <summary>
	/// Set the points (unless you set them as inputs).
	/// </summary>
	public virtual void SetPoints(int port, vtkPoints points)
	{
		vtkMNITagPointWriter_SetPoints_23(GetCppThis(), port, points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITagPointWriter_SetPoints_24(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Set the points (unless you set them as inputs).
	/// </summary>
	public virtual void SetPoints(vtkPoints points)
	{
		vtkMNITagPointWriter_SetPoints_24(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITagPointWriter_SetStructureIds_25(HandleRef pThis, HandleRef a);

	/// <summary>
	/// Set the structure ids (unless the input PointData has
	/// an array called StructureIds).  These are optional.
	/// </summary>
	public virtual void SetStructureIds(vtkIntArray a)
	{
		vtkMNITagPointWriter_SetStructureIds_25(GetCppThis(), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNITagPointWriter_SetWeights_26(HandleRef pThis, HandleRef a);

	/// <summary>
	/// Set the weights (unless the input PointData has an
	/// array called Weights).  Weights are optional.
	/// </summary>
	public virtual void SetWeights(vtkDoubleArray a)
	{
		vtkMNITagPointWriter_SetWeights_26(GetCppThis(), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMNITagPointWriter_Write_27(HandleRef pThis);

	/// <summary>
	/// Write the file.
	/// </summary>
	public override int Write()
	{
		return vtkMNITagPointWriter_Write_27(GetCppThis());
	}
}
