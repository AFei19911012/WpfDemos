using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRecursiveSphereDirectionEncoder
/// </summary>
/// <remarks>
///    A direction encoder based on the recursive subdivision of an octahedron
///
/// vtkRecursiveSphereDirectionEncoder is a direction encoder which uses the
/// vertices of a recursive subdivision of an octahedron (with the vertices
/// pushed out onto the surface of an enclosing sphere) to encode directions
/// into a two byte value.
///
/// </remarks>
/// <seealso>
///
/// vtkDirectionEncoder
/// </seealso>
public class vtkRecursiveSphereDirectionEncoder : vtkDirectionEncoder
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRecursiveSphereDirectionEncoder";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRecursiveSphereDirectionEncoder()
	{
		MRClassNameKey = "class vtkRecursiveSphereDirectionEncoder";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRecursiveSphereDirectionEncoder"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRecursiveSphereDirectionEncoder(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct the object. Initialize the index table which will be
	/// used to map the normal into a patch on the recursively subdivided
	/// sphere.
	/// </summary>
	public new static vtkRecursiveSphereDirectionEncoder New()
	{
		vtkRecursiveSphereDirectionEncoder result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRecursiveSphereDirectionEncoder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRecursiveSphereDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct the object. Initialize the index table which will be
	/// used to map the normal into a patch on the recursively subdivided
	/// sphere.
	/// </summary>
	public vtkRecursiveSphereDirectionEncoder()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRecursiveSphereDirectionEncoder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_GetDecodedGradient_01(HandleRef pThis, int value);

	/// <summary>
	/// / Given an encoded value, return a pointer to the normal vector
	/// </summary>
	public override float[] GetDecodedGradient(int value)
	{
		IntPtr intPtr = vtkRecursiveSphereDirectionEncoder_GetDecodedGradient_01(GetCppThis(), value);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_GetDecodedGradientTable_02(HandleRef pThis);

	/// <summary>
	/// Get the decoded gradient table. There are
	/// this-&gt;GetNumberOfEncodedDirections() entries in the table, each
	/// containing a normal (direction) vector. This is a flat structure -
	/// 3 times the number of directions floats in an array.
	/// </summary>
	public override IntPtr GetDecodedGradientTable()
	{
		return vtkRecursiveSphereDirectionEncoder_GetDecodedGradientTable_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRecursiveSphereDirectionEncoder_GetEncodedDirection_03(HandleRef pThis, IntPtr n);

	/// <summary>
	/// Given a normal vector n, return the encoded direction
	/// </summary>
	public override int GetEncodedDirection(IntPtr n)
	{
		return vtkRecursiveSphereDirectionEncoder_GetEncodedDirection_03(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRecursiveSphereDirectionEncoder_GetNumberOfEncodedDirections_04(HandleRef pThis);

	/// <summary>
	/// Return the number of encoded directions
	/// </summary>
	public override int GetNumberOfEncodedDirections()
	{
		return vtkRecursiveSphereDirectionEncoder_GetNumberOfEncodedDirections_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRecursiveSphereDirectionEncoder_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRecursiveSphereDirectionEncoder_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRecursiveSphereDirectionEncoder_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRecursiveSphereDirectionEncoder_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRecursiveSphereDirectionEncoder_GetRecursionDepth_07(HandleRef pThis);

	/// <summary>
	/// Set / Get the recursion depth for the subdivision. This
	/// indicates how many time one triangle on the initial 8-sided
	/// sphere model is replaced by four triangles formed by connecting
	/// triangle edge midpoints. A recursion level of 0 yields 8 triangles
	/// with 6 unique vertices. The normals are the vectors from the
	/// sphere center through the vertices. The number of directions
	/// will be 11 since the four normals with 0 z values will be
	/// duplicated in the table - once with +0 values and the other
	/// time with -0 values, and an addition index will be used to
	/// represent the (0,0,0) normal. If we instead choose a recursion
	/// level of 6 (the maximum that can fit within 2 bytes) the number
	/// of directions is 16643, with 16386 unique directions and a
	/// zero normal.
	/// </summary>
	public virtual int GetRecursionDepth()
	{
		return vtkRecursiveSphereDirectionEncoder_GetRecursionDepth_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRecursiveSphereDirectionEncoder_GetRecursionDepthMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set / Get the recursion depth for the subdivision. This
	/// indicates how many time one triangle on the initial 8-sided
	/// sphere model is replaced by four triangles formed by connecting
	/// triangle edge midpoints. A recursion level of 0 yields 8 triangles
	/// with 6 unique vertices. The normals are the vectors from the
	/// sphere center through the vertices. The number of directions
	/// will be 11 since the four normals with 0 z values will be
	/// duplicated in the table - once with +0 values and the other
	/// time with -0 values, and an addition index will be used to
	/// represent the (0,0,0) normal. If we instead choose a recursion
	/// level of 6 (the maximum that can fit within 2 bytes) the number
	/// of directions is 16643, with 16386 unique directions and a
	/// zero normal.
	/// </summary>
	public virtual int GetRecursionDepthMaxValue()
	{
		return vtkRecursiveSphereDirectionEncoder_GetRecursionDepthMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRecursiveSphereDirectionEncoder_GetRecursionDepthMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set / Get the recursion depth for the subdivision. This
	/// indicates how many time one triangle on the initial 8-sided
	/// sphere model is replaced by four triangles formed by connecting
	/// triangle edge midpoints. A recursion level of 0 yields 8 triangles
	/// with 6 unique vertices. The normals are the vectors from the
	/// sphere center through the vertices. The number of directions
	/// will be 11 since the four normals with 0 z values will be
	/// duplicated in the table - once with +0 values and the other
	/// time with -0 values, and an addition index will be used to
	/// represent the (0,0,0) normal. If we instead choose a recursion
	/// level of 6 (the maximum that can fit within 2 bytes) the number
	/// of directions is 16643, with 16386 unique directions and a
	/// zero normal.
	/// </summary>
	public virtual int GetRecursionDepthMinValue()
	{
		return vtkRecursiveSphereDirectionEncoder_GetRecursionDepthMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRecursiveSphereDirectionEncoder_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRecursiveSphereDirectionEncoder_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRecursiveSphereDirectionEncoder_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRecursiveSphereDirectionEncoder_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRecursiveSphereDirectionEncoder NewInstance()
	{
		vtkRecursiveSphereDirectionEncoder result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRecursiveSphereDirectionEncoder_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRecursiveSphereDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRecursiveSphereDirectionEncoder SafeDownCast(vtkObjectBase o)
	{
		vtkRecursiveSphereDirectionEncoder vtkRecursiveSphereDirectionEncoder2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRecursiveSphereDirectionEncoder_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRecursiveSphereDirectionEncoder2 = (vtkRecursiveSphereDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRecursiveSphereDirectionEncoder2.Register(null);
			}
		}
		return vtkRecursiveSphereDirectionEncoder2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRecursiveSphereDirectionEncoder_SetRecursionDepth_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set / Get the recursion depth for the subdivision. This
	/// indicates how many time one triangle on the initial 8-sided
	/// sphere model is replaced by four triangles formed by connecting
	/// triangle edge midpoints. A recursion level of 0 yields 8 triangles
	/// with 6 unique vertices. The normals are the vectors from the
	/// sphere center through the vertices. The number of directions
	/// will be 11 since the four normals with 0 z values will be
	/// duplicated in the table - once with +0 values and the other
	/// time with -0 values, and an addition index will be used to
	/// represent the (0,0,0) normal. If we instead choose a recursion
	/// level of 6 (the maximum that can fit within 2 bytes) the number
	/// of directions is 16643, with 16386 unique directions and a
	/// zero normal.
	/// </summary>
	public virtual void SetRecursionDepth(int _arg)
	{
		vtkRecursiveSphereDirectionEncoder_SetRecursionDepth_15(GetCppThis(), _arg);
	}
}
