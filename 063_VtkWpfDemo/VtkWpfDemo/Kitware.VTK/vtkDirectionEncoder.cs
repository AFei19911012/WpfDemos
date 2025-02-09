using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDirectionEncoder
/// </summary>
/// <remarks>
///    encode a direction into a one or two byte value
///
///
/// Given a direction, encode it into an integer value. This value should
/// be less than 65536, which is the maximum number of encoded directions
/// supported by this superclass. A direction encoded is used to encode
/// normals in a volume for use during volume rendering, and the
/// amount of space that is allocated per normal is 2 bytes.
/// This is an abstract superclass - see the subclasses for specific
/// implementation details.
///
/// </remarks>
/// <seealso>
///
/// vtkRecursiveSphereDirectionEncoder
/// </seealso>
public abstract class vtkDirectionEncoder : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDirectionEncoder";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDirectionEncoder()
	{
		MRClassNameKey = "class vtkDirectionEncoder";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDirectionEncoder"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDirectionEncoder(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern IntPtr vtkDirectionEncoder_GetDecodedGradient_01(HandleRef pThis, int value);

	/// <summary>
	/// / Given an encoded value, return a pointer to the normal vector
	/// </summary>
	public virtual float[] GetDecodedGradient(int value)
	{
		IntPtr intPtr = vtkDirectionEncoder_GetDecodedGradient_01(GetCppThis(), value);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDirectionEncoder_GetDecodedGradientTable_02(HandleRef pThis);

	/// <summary>
	/// Get the decoded gradient table. There are
	/// this-&gt;GetNumberOfEncodedDirections() entries in the table, each
	/// containing a normal (direction) vector. This is a flat structure -
	/// 3 times the number of directions floats in an array.
	/// </summary>
	public virtual IntPtr GetDecodedGradientTable()
	{
		return vtkDirectionEncoder_GetDecodedGradientTable_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDirectionEncoder_GetEncodedDirection_03(HandleRef pThis, IntPtr n);

	/// <summary>
	/// Given a normal vector n, return the encoded direction
	/// </summary>
	public virtual int GetEncodedDirection(IntPtr n)
	{
		return vtkDirectionEncoder_GetEncodedDirection_03(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDirectionEncoder_GetNumberOfEncodedDirections_04(HandleRef pThis);

	/// <summary>
	/// Return the number of encoded directions
	/// </summary>
	public virtual int GetNumberOfEncodedDirections()
	{
		return vtkDirectionEncoder_GetNumberOfEncodedDirections_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDirectionEncoder_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Get the name of this class
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDirectionEncoder_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDirectionEncoder_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Get the name of this class
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDirectionEncoder_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDirectionEncoder_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Get the name of this class
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDirectionEncoder_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDirectionEncoder_IsTypeOf_08(string type);

	/// <summary>
	/// Get the name of this class
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDirectionEncoder_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDirectionEncoder_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the name of this class
	/// </summary>
	public new vtkDirectionEncoder NewInstance()
	{
		vtkDirectionEncoder result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDirectionEncoder_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDirectionEncoder_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the name of this class
	/// </summary>
	public new static vtkDirectionEncoder SafeDownCast(vtkObjectBase o)
	{
		vtkDirectionEncoder vtkDirectionEncoder2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDirectionEncoder_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDirectionEncoder2 = (vtkDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDirectionEncoder2.Register(null);
			}
		}
		return vtkDirectionEncoder2;
	}
}
