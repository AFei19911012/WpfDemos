using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPLYReader
/// </summary>
/// <remarks>
///    read Stanford University PLY polygonal file format
///
/// vtkPLYReader is a source object that reads polygonal data in
/// Stanford University PLY file format (see
/// http://graphics.stanford.edu/data/3Dscanrep). It requires that
/// the elements "vertex" and "face" are defined. The "vertex" element
/// must have the properties "x", "y", and "z". The "face" element must
/// have the property "vertex_indices" defined. Optionally, if the "face"
/// element has the properties "intensity" and/or the triplet "red",
/// "green", "blue", and optionally "alpha"; these are read and added as scalars
/// to the output data.
/// If the "face" element has the property "texcoord" a new TCoords
/// point array is created and points are duplicated if they have 2 or
/// more different texture coordinates. Points are duplicated only if
/// DuplicatePointsForFaceTexture is true (default).
/// This creates a polygonal data that can be textured without
/// artifacts. If unique points are required use a vtkCleanPolyData
/// filter after this reader or use this reader with DuplicatePointsForFaceTexture
/// set to false.
///
/// </remarks>
/// <seealso>
///
/// vtkPLYWriter, vtkCleanPolyData
/// </seealso>
public class vtkPLYReader : vtkAbstractPolyDataReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPLYReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPLYReader()
	{
		MRClassNameKey = "class vtkPLYReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPLYReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPLYReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with merging set to true.
	/// </summary>
	public new static vtkPLYReader New()
	{
		vtkPLYReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPLYReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPLYReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with merging set to true.
	/// </summary>
	public vtkPLYReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPLYReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYReader_CanReadFile_01(string filename);

	/// <summary>
	/// A simple, non-exhaustive check to see if a file is a valid ply file.
	/// </summary>
	public static int CanReadFile(string filename)
	{
		return vtkPLYReader_CanReadFile_01(filename);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYReader_GetComments_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A simple, non-exhaustive check to see if a file is a valid ply file.
	/// </summary>
	public virtual vtkStringArray GetComments()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPLYReader_GetComments_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPLYReader_GetDuplicatePointsForFaceTexture_03(HandleRef pThis);

	/// <summary>
	/// If true (default) and the "face" element has the property "texcoord" duplicate
	/// face points if they have 2 or more different texture coordinates.
	/// Otherwise, each texture coordinate for a face point overwrites previously set
	/// texture coordinates for that point.
	/// </summary>
	public virtual bool GetDuplicatePointsForFaceTexture()
	{
		return (vtkPLYReader_GetDuplicatePointsForFaceTexture_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkPLYReader_GetFaceTextureTolerance_04(HandleRef pThis);

	/// <summary>
	/// Tolerance used to detect different texture coordinates for shared
	/// points for faces.
	/// </summary>
	public virtual float GetFaceTextureTolerance()
	{
		return vtkPLYReader_GetFaceTextureTolerance_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPLYReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPLYReader_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPLYReader_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPLYReader_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPLYReader_GetReadFromInputString_07(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString instead of the default, a file.
	/// Note that reading from an input stream would be more flexible (enabling
	/// other kind of streams) and possibly more efficient because we don't need
	/// to save the whole stream to a string. However a stream interface
	/// does not translate well to python and the string interface satisfies
	/// our current needs. So we leave the stream interface for future work.
	/// </summary>
	public virtual bool GetReadFromInputString()
	{
		return (vtkPLYReader_GetReadFromInputString_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYReader_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPLYReader_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYReader_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPLYReader_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPLYReader NewInstance()
	{
		vtkPLYReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPLYReader_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPLYReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYReader_ReadFromInputStringOff_12(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString instead of the default, a file.
	/// Note that reading from an input stream would be more flexible (enabling
	/// other kind of streams) and possibly more efficient because we don't need
	/// to save the whole stream to a string. However a stream interface
	/// does not translate well to python and the string interface satisfies
	/// our current needs. So we leave the stream interface for future work.
	/// </summary>
	public virtual void ReadFromInputStringOff()
	{
		vtkPLYReader_ReadFromInputStringOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYReader_ReadFromInputStringOn_13(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString instead of the default, a file.
	/// Note that reading from an input stream would be more flexible (enabling
	/// other kind of streams) and possibly more efficient because we don't need
	/// to save the whole stream to a string. However a stream interface
	/// does not translate well to python and the string interface satisfies
	/// our current needs. So we leave the stream interface for future work.
	/// </summary>
	public virtual void ReadFromInputStringOn()
	{
		vtkPLYReader_ReadFromInputStringOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYReader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPLYReader SafeDownCast(vtkObjectBase o)
	{
		vtkPLYReader vtkPLYReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPLYReader_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPLYReader2 = (vtkPLYReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPLYReader2.Register(null);
			}
		}
		return vtkPLYReader2;
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYReader_SetDuplicatePointsForFaceTexture_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true (default) and the "face" element has the property "texcoord" duplicate
	/// face points if they have 2 or more different texture coordinates.
	/// Otherwise, each texture coordinate for a face point overwrites previously set
	/// texture coordinates for that point.
	/// </summary>
	public virtual void SetDuplicatePointsForFaceTexture(bool _arg)
	{
		vtkPLYReader_SetDuplicatePointsForFaceTexture_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYReader_SetFaceTextureTolerance_16(HandleRef pThis, float _arg);

	/// <summary>
	/// Tolerance used to detect different texture coordinates for shared
	/// points for faces.
	/// </summary>
	public virtual void SetFaceTextureTolerance(float _arg)
	{
		vtkPLYReader_SetFaceTextureTolerance_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYReader_SetInputString_17(HandleRef pThis, string s);

	/// <summary>
	/// Enable reading from an InputString instead of the default, a file.
	/// Note that reading from an input stream would be more flexible (enabling
	/// other kind of streams) and possibly more efficient because we don't need
	/// to save the whole stream to a string. However a stream interface
	/// does not translate well to python and the string interface satisfies
	/// our current needs. So we leave the stream interface for future work.
	/// </summary>
	public void SetInputString(string s)
	{
		vtkPLYReader_SetInputString_17(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYReader_SetReadFromInputString_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable reading from an InputString instead of the default, a file.
	/// Note that reading from an input stream would be more flexible (enabling
	/// other kind of streams) and possibly more efficient because we don't need
	/// to save the whole stream to a string. However a stream interface
	/// does not translate well to python and the string interface satisfies
	/// our current needs. So we leave the stream interface for future work.
	/// </summary>
	public virtual void SetReadFromInputString(bool _arg)
	{
		vtkPLYReader_SetReadFromInputString_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
