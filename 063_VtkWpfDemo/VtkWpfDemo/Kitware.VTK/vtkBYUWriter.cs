using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBYUWriter
/// </summary>
/// <remarks>
///    write MOVIE.BYU files
///
/// vtkBYUWriter writes MOVIE.BYU polygonal files. These files consist
/// of a geometry file (.g), a scalar file (.s), a displacement or
/// vector file (.d), and a 2D texture coordinate file (.t). These files
/// must be specified to the object, the appropriate boolean
/// variables must be true, and data must be available from the input
/// for the files to be written.
/// WARNING: this writer does not currently write triangle strips. Use
/// vtkTriangleFilter to convert strips to triangles.
/// </remarks>
public class vtkBYUWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBYUWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBYUWriter()
	{
		MRClassNameKey = "class vtkBYUWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBYUWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBYUWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBYUWriter New()
	{
		vtkBYUWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBYUWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBYUWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBYUWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBYUWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUWriter_GetDisplacementFileName_01(HandleRef pThis);

	/// <summary>
	/// Specify the name of the displacement file to write.
	/// </summary>
	public virtual string GetDisplacementFileName()
	{
		return Marshal.PtrToStringAnsi(vtkBYUWriter_GetDisplacementFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUWriter_GetGeometryFileName_02(HandleRef pThis);

	/// <summary>
	/// Specify the name of the geometry file to write.
	/// </summary>
	public virtual string GetGeometryFileName()
	{
		return Marshal.PtrToStringAnsi(vtkBYUWriter_GetGeometryFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUWriter_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input to this writer.
	/// </summary>
	public new vtkPolyData GetInput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBYUWriter_GetInput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUWriter_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input to this writer.
	/// </summary>
	public new vtkPolyData GetInput(int port)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBYUWriter_GetInput_04(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBYUWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBYUWriter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBYUWriter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBYUWriter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUWriter_GetScalarFileName_07(HandleRef pThis);

	/// <summary>
	/// Specify the name of the scalar file to write.
	/// </summary>
	public virtual string GetScalarFileName()
	{
		return Marshal.PtrToStringAnsi(vtkBYUWriter_GetScalarFileName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUWriter_GetTextureFileName_08(HandleRef pThis);

	/// <summary>
	/// Specify the name of the texture file to write.
	/// </summary>
	public virtual string GetTextureFileName()
	{
		return Marshal.PtrToStringAnsi(vtkBYUWriter_GetTextureFileName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUWriter_GetWriteDisplacement_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off writing the displacement file.
	/// </summary>
	public virtual int GetWriteDisplacement()
	{
		return vtkBYUWriter_GetWriteDisplacement_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUWriter_GetWriteScalar_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off writing the scalar file.
	/// </summary>
	public virtual int GetWriteScalar()
	{
		return vtkBYUWriter_GetWriteScalar_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUWriter_GetWriteTexture_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off writing the texture file.
	/// </summary>
	public virtual int GetWriteTexture()
	{
		return vtkBYUWriter_GetWriteTexture_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUWriter_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBYUWriter_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUWriter_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBYUWriter_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUWriter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBYUWriter NewInstance()
	{
		vtkBYUWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBYUWriter_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBYUWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUWriter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBYUWriter SafeDownCast(vtkObjectBase o)
	{
		vtkBYUWriter vtkBYUWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBYUWriter_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBYUWriter2 = (vtkBYUWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBYUWriter2.Register(null);
			}
		}
		return vtkBYUWriter2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_SetDisplacementFileName_17(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of the displacement file to write.
	/// </summary>
	public virtual void SetDisplacementFileName(string _arg)
	{
		vtkBYUWriter_SetDisplacementFileName_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_SetGeometryFileName_18(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of the geometry file to write.
	/// </summary>
	public virtual void SetGeometryFileName(string _arg)
	{
		vtkBYUWriter_SetGeometryFileName_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_SetScalarFileName_19(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of the scalar file to write.
	/// </summary>
	public virtual void SetScalarFileName(string _arg)
	{
		vtkBYUWriter_SetScalarFileName_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_SetTextureFileName_20(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of the texture file to write.
	/// </summary>
	public virtual void SetTextureFileName(string _arg)
	{
		vtkBYUWriter_SetTextureFileName_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_SetWriteDisplacement_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off writing the displacement file.
	/// </summary>
	public virtual void SetWriteDisplacement(int _arg)
	{
		vtkBYUWriter_SetWriteDisplacement_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_SetWriteScalar_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off writing the scalar file.
	/// </summary>
	public virtual void SetWriteScalar(int _arg)
	{
		vtkBYUWriter_SetWriteScalar_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_SetWriteTexture_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off writing the texture file.
	/// </summary>
	public virtual void SetWriteTexture(int _arg)
	{
		vtkBYUWriter_SetWriteTexture_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_WriteDisplacementOff_24(HandleRef pThis);

	/// <summary>
	/// Turn on/off writing the displacement file.
	/// </summary>
	public virtual void WriteDisplacementOff()
	{
		vtkBYUWriter_WriteDisplacementOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_WriteDisplacementOn_25(HandleRef pThis);

	/// <summary>
	/// Turn on/off writing the displacement file.
	/// </summary>
	public virtual void WriteDisplacementOn()
	{
		vtkBYUWriter_WriteDisplacementOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_WriteScalarOff_26(HandleRef pThis);

	/// <summary>
	/// Turn on/off writing the scalar file.
	/// </summary>
	public virtual void WriteScalarOff()
	{
		vtkBYUWriter_WriteScalarOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_WriteScalarOn_27(HandleRef pThis);

	/// <summary>
	/// Turn on/off writing the scalar file.
	/// </summary>
	public virtual void WriteScalarOn()
	{
		vtkBYUWriter_WriteScalarOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_WriteTextureOff_28(HandleRef pThis);

	/// <summary>
	/// Turn on/off writing the texture file.
	/// </summary>
	public virtual void WriteTextureOff()
	{
		vtkBYUWriter_WriteTextureOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUWriter_WriteTextureOn_29(HandleRef pThis);

	/// <summary>
	/// Turn on/off writing the texture file.
	/// </summary>
	public virtual void WriteTextureOn()
	{
		vtkBYUWriter_WriteTextureOn_29(GetCppThis());
	}
}
