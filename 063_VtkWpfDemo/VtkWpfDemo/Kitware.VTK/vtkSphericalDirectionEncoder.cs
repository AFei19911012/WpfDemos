using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSphericalDirectionEncoder
/// </summary>
/// <remarks>
///    A direction encoder based on spherical coordinates
///
/// vtkSphericalDirectionEncoder is a direction encoder which uses spherical
/// coordinates for mapping (nx, ny, nz) into an azimuth, elevation pair.
///
/// </remarks>
/// <seealso>
///
/// vtkDirectionEncoder
/// </seealso>
public class vtkSphericalDirectionEncoder : vtkDirectionEncoder
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSphericalDirectionEncoder";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSphericalDirectionEncoder()
	{
		MRClassNameKey = "class vtkSphericalDirectionEncoder";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphericalDirectionEncoder"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSphericalDirectionEncoder(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphericalDirectionEncoder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct the object. Initialize the index table which will be
	/// used to map the normal into a patch on the recursively subdivided
	/// sphere.
	/// </summary>
	public new static vtkSphericalDirectionEncoder New()
	{
		vtkSphericalDirectionEncoder result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphericalDirectionEncoder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphericalDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct the object. Initialize the index table which will be
	/// used to map the normal into a patch on the recursively subdivided
	/// sphere.
	/// </summary>
	public vtkSphericalDirectionEncoder()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSphericalDirectionEncoder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphericalDirectionEncoder_GetDecodedGradient_01(HandleRef pThis, int value);

	/// <summary>
	/// / Given an encoded value, return a pointer to the normal vector
	/// </summary>
	public override float[] GetDecodedGradient(int value)
	{
		IntPtr intPtr = vtkSphericalDirectionEncoder_GetDecodedGradient_01(GetCppThis(), value);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphericalDirectionEncoder_GetDecodedGradientTable_02(HandleRef pThis);

	/// <summary>
	/// Get the decoded gradient table. There are
	/// this-&gt;GetNumberOfEncodedDirections() entries in the table, each
	/// containing a normal (direction) vector. This is a flat structure -
	/// 3 times the number of directions floats in an array.
	/// </summary>
	public override IntPtr GetDecodedGradientTable()
	{
		return vtkSphericalDirectionEncoder_GetDecodedGradientTable_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphericalDirectionEncoder_GetEncodedDirection_03(HandleRef pThis, IntPtr n);

	/// <summary>
	/// Given a normal vector n, return the encoded direction
	/// </summary>
	public override int GetEncodedDirection(IntPtr n)
	{
		return vtkSphericalDirectionEncoder_GetEncodedDirection_03(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphericalDirectionEncoder_GetNumberOfEncodedDirections_04(HandleRef pThis);

	/// <summary>
	/// Return the number of encoded directions
	/// </summary>
	public override int GetNumberOfEncodedDirections()
	{
		return vtkSphericalDirectionEncoder_GetNumberOfEncodedDirections_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphericalDirectionEncoder_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSphericalDirectionEncoder_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphericalDirectionEncoder_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSphericalDirectionEncoder_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphericalDirectionEncoder_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSphericalDirectionEncoder_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphericalDirectionEncoder_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSphericalDirectionEncoder_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphericalDirectionEncoder_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSphericalDirectionEncoder NewInstance()
	{
		vtkSphericalDirectionEncoder result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphericalDirectionEncoder_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphericalDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphericalDirectionEncoder_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSphericalDirectionEncoder SafeDownCast(vtkObjectBase o)
	{
		vtkSphericalDirectionEncoder vtkSphericalDirectionEncoder2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphericalDirectionEncoder_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphericalDirectionEncoder2 = (vtkSphericalDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphericalDirectionEncoder2.Register(null);
			}
		}
		return vtkSphericalDirectionEncoder2;
	}
}
