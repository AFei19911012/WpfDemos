using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageTransform
/// </summary>
/// <remarks>
///    helper class to transform output of non-axis-aligned images
///
/// vtkImageTransform is a helper class to transform the output of
/// image filters (i.e., filter that input vtkImageData) by applying the
/// Index to Physical transformation from the input image, which can
/// include origin, spacing, direction. The transformation process is
/// threaded with vtkSMPTools for performance.
///
/// Typically in application the single method TransformPointSet() is
/// invoked to transform the output of an image algorithm (assuming
/// that the image's direction/orientation matrix is
/// non-identity). Note that vtkPointSets encompass vtkPolyData as well
/// as vtkUnstructuredGrids. In the future other output types may be
/// added. Note that specific methods for transforming points, normals,
/// and vectors is also provided by this class in case additional
/// output data arrays need to be transformed (since
/// TransformPointSet() only processes data arrays labeled as points,
/// normals, and vectors).
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
public class vtkImageTransform : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageTransform()
	{
		MRClassNameKey = "class vtkImageTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type information, printing.
	/// </summary>
	public new static vtkImageTransform New()
	{
		vtkImageTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for construction, type information, printing.
	/// </summary>
	public vtkImageTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageTransform_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type information, printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageTransform_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageTransform_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for construction, type information, printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageTransform_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTransform_IsA_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type information, printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageTransform_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTransform_IsTypeOf_04(string type);

	/// <summary>
	/// Standard methods for construction, type information, printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageTransform_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageTransform_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type information, printing.
	/// </summary>
	public new vtkImageTransform NewInstance()
	{
		vtkImageTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageTransform_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageTransform_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type information, printing.
	/// </summary>
	public new static vtkImageTransform SafeDownCast(vtkObjectBase o)
	{
		vtkImageTransform vtkImageTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageTransform_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageTransform2 = (vtkImageTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageTransform2.Register(null);
			}
		}
		return vtkImageTransform2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTransform_TransformNormals_08(HandleRef m3, IntPtr spacing, HandleRef da);

	/// <summary>
	/// Given three-component normals represented by a vtkDataArray,
	/// transform the normals using the matrix provided.
	/// </summary>
	public static void TransformNormals(vtkMatrix3x3 m3, IntPtr spacing, vtkDataArray da)
	{
		vtkImageTransform_TransformNormals_08(m3?.GetCppThis() ?? default(HandleRef), spacing, da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTransform_TransformPointSet_09(HandleRef im, HandleRef ps);

	/// <summary>
	/// Given a vtkImageData (and hence its associated orientation
	/// matrix), and an instance of vtkPointSet, transform its points, as
	/// well as any normals and vectors, associated with the
	/// vtkPointSet. This is a convenience function, internally it calls
	/// TranslatePoints(), TransformPoints(), TransformNormals(), and/or
	/// TransformVectors() as appropriate. Note that both the normals and
	/// vectors associated with the point and cell data are transformed
	/// unless the second signature is called, which controls whether to
	/// transform normals and/or vectors.
	/// </summary>
	public static void TransformPointSet(vtkImageData im, vtkPointSet ps)
	{
		vtkImageTransform_TransformPointSet_09(im?.GetCppThis() ?? default(HandleRef), ps?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTransform_TransformPointSet_10(HandleRef im, HandleRef ps, byte transNormals, byte transVectors);

	/// <summary>
	/// Given a vtkImageData (and hence its associated orientation
	/// matrix), and an instance of vtkPointSet, transform its points, as
	/// well as any normals and vectors, associated with the
	/// vtkPointSet. This is a convenience function, internally it calls
	/// TranslatePoints(), TransformPoints(), TransformNormals(), and/or
	/// TransformVectors() as appropriate. Note that both the normals and
	/// vectors associated with the point and cell data are transformed
	/// unless the second signature is called, which controls whether to
	/// transform normals and/or vectors.
	/// </summary>
	public static void TransformPointSet(vtkImageData im, vtkPointSet ps, bool transNormals, bool transVectors)
	{
		vtkImageTransform_TransformPointSet_10(im?.GetCppThis() ?? default(HandleRef), ps?.GetCppThis() ?? default(HandleRef), (byte)(transNormals ? 1u : 0u), (byte)(transVectors ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTransform_TransformPoints_11(HandleRef m4, HandleRef da);

	/// <summary>
	/// Given x-y-z points represented by a vtkDataArray,
	/// transform the points using the matrix provided.
	/// </summary>
	public static void TransformPoints(vtkMatrix4x4 m4, vtkDataArray da)
	{
		vtkImageTransform_TransformPoints_11(m4?.GetCppThis() ?? default(HandleRef), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTransform_TransformVectors_12(HandleRef m3, IntPtr spacing, HandleRef da);

	/// <summary>
	/// Given three-component vectors represented by a vtkDataArray,
	/// transform the vectors using the matrix provided.
	/// </summary>
	public static void TransformVectors(vtkMatrix3x3 m3, IntPtr spacing, vtkDataArray da)
	{
		vtkImageTransform_TransformVectors_12(m3?.GetCppThis() ?? default(HandleRef), spacing, da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTransform_TranslatePoints_13(IntPtr t, HandleRef da);

	/// <summary>
	/// Given x-y-z points represented by a vtkDataArray,
	/// translate the points using the image origin. This
	/// method is useful if there is no orientation or
	/// spacing to apply.
	/// </summary>
	public static void TranslatePoints(IntPtr t, vtkDataArray da)
	{
		vtkImageTransform_TranslatePoints_13(t, da?.GetCppThis() ?? default(HandleRef));
	}
}
