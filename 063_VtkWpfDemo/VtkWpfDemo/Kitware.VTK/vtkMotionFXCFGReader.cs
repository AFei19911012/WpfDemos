using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkMotionFXCFGReader
/// </summary>
/// <remarks>
///  reader for MotionFX motion definitions cfg files.
///
/// MotionFX files comprise of `motion`s for a collection of STL files. The
/// motions define the transformations to apply to STL geometry to emulate
/// motion like translation, rotation, planetary motion, etc.
///
/// This reader reads such a CFG file and produces a temporal output for the time
/// range defined in the file. The resolution of time can be controlled using the
/// `SetTimeResolution` method. The output is a multiblock dataset with blocks
/// for each of bodies, identified by an STL file, in the cfg file.
///
/// The reader uses PEGTL (https://github.com/taocpp/PEGTL)
/// to define and parse the grammar for the CFG file.
/// </remarks>
public class vtkMotionFXCFGReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMotionFXCFGReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMotionFXCFGReader()
	{
		MRClassNameKey = "class vtkMotionFXCFGReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMotionFXCFGReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMotionFXCFGReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMotionFXCFGReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMotionFXCFGReader New()
	{
		vtkMotionFXCFGReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMotionFXCFGReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMotionFXCFGReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMotionFXCFGReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMotionFXCFGReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMotionFXCFGReader_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Get/Set the filename.
	/// </summary>
	public string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMotionFXCFGReader_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMotionFXCFGReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMotionFXCFGReader_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMotionFXCFGReader_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMotionFXCFGReader_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMotionFXCFGReader_GetTimeResolution_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the time resolution for timesteps produced by the reader.
	/// </summary>
	public virtual int GetTimeResolution()
	{
		return vtkMotionFXCFGReader_GetTimeResolution_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMotionFXCFGReader_GetTimeResolutionMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the time resolution for timesteps produced by the reader.
	/// </summary>
	public virtual int GetTimeResolutionMaxValue()
	{
		return vtkMotionFXCFGReader_GetTimeResolutionMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMotionFXCFGReader_GetTimeResolutionMinValue_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the time resolution for timesteps produced by the reader.
	/// </summary>
	public virtual int GetTimeResolutionMinValue()
	{
		return vtkMotionFXCFGReader_GetTimeResolutionMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMotionFXCFGReader_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMotionFXCFGReader_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMotionFXCFGReader_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMotionFXCFGReader_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMotionFXCFGReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMotionFXCFGReader NewInstance()
	{
		vtkMotionFXCFGReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMotionFXCFGReader_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMotionFXCFGReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMotionFXCFGReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMotionFXCFGReader SafeDownCast(vtkObjectBase o)
	{
		vtkMotionFXCFGReader vtkMotionFXCFGReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMotionFXCFGReader_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMotionFXCFGReader2 = (vtkMotionFXCFGReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMotionFXCFGReader2.Register(null);
			}
		}
		return vtkMotionFXCFGReader2;
	}

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMotionFXCFGReader_SetFileName_12(HandleRef pThis, string fname);

	/// <summary>
	/// Get/Set the filename.
	/// </summary>
	public void SetFileName(string fname)
	{
		vtkMotionFXCFGReader_SetFileName_12(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMotionFXCFGReader_SetTimeResolution_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the time resolution for timesteps produced by the reader.
	/// </summary>
	public virtual void SetTimeResolution(int _arg)
	{
		vtkMotionFXCFGReader_SetTimeResolution_13(GetCppThis(), _arg);
	}
}
