using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLCellToVTKCellMap
/// </summary>
/// <remarks>
///    OpenGL rendering utility functions
///
/// vtkOpenGLCellToVTKCellMap provides functions map from opengl primitive ID to vtk
///
///
/// </remarks>
public class vtkOpenGLCellToVTKCellMap : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLCellToVTKCellMap";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLCellToVTKCellMap()
	{
		MRClassNameKey = "class vtkOpenGLCellToVTKCellMap";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLCellToVTKCellMap"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLCellToVTKCellMap(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLCellToVTKCellMap_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLCellToVTKCellMap New()
	{
		vtkOpenGLCellToVTKCellMap result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLCellToVTKCellMap_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLCellToVTKCellMap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLCellToVTKCellMap()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLCellToVTKCellMap_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLCellToVTKCellMap_ConvertOpenGLCellIdToVTKCellId_01(HandleRef pThis, byte pointPicking, long openGLId);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public long ConvertOpenGLCellIdToVTKCellId(bool pointPicking, long openGLId)
	{
		return vtkOpenGLCellToVTKCellMap_ConvertOpenGLCellIdToVTKCellId_01(GetCppThis(), (byte)(pointPicking ? 1u : 0u), openGLId);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLCellToVTKCellMap_GetFinalOffset_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public long GetFinalOffset()
	{
		return vtkOpenGLCellToVTKCellMap_GetFinalOffset_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLCellToVTKCellMap_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLCellToVTKCellMap_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLCellToVTKCellMap_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLCellToVTKCellMap_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLCellToVTKCellMap_GetPrimitiveOffsets_05(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public IntPtr GetPrimitiveOffsets()
	{
		return vtkOpenGLCellToVTKCellMap_GetPrimitiveOffsets_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkOpenGLCellToVTKCellMap_GetSize_06(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public ulong GetSize()
	{
		return vtkOpenGLCellToVTKCellMap_GetSize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLCellToVTKCellMap_GetValue_07(HandleRef pThis, ulong i);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public long GetValue(ulong i)
	{
		return vtkOpenGLCellToVTKCellMap_GetValue_07(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLCellToVTKCellMap_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLCellToVTKCellMap_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLCellToVTKCellMap_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLCellToVTKCellMap_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLCellToVTKCellMap_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLCellToVTKCellMap NewInstance()
	{
		vtkOpenGLCellToVTKCellMap result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLCellToVTKCellMap_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLCellToVTKCellMap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLCellToVTKCellMap_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLCellToVTKCellMap SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLCellToVTKCellMap vtkOpenGLCellToVTKCellMap2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLCellToVTKCellMap_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLCellToVTKCellMap2 = (vtkOpenGLCellToVTKCellMap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLCellToVTKCellMap2.Register(null);
			}
		}
		return vtkOpenGLCellToVTKCellMap2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLCellToVTKCellMap_SetStartOffset_13(HandleRef pThis, long start);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetStartOffset(long start)
	{
		vtkOpenGLCellToVTKCellMap_SetStartOffset_13(GetCppThis(), start);
	}
}
