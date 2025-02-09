using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSliceCubes
/// </summary>
/// <remarks>
///    generate isosurface(s) from volume four slices at a time
///
/// vtkSliceCubes is a special version of the marching cubes filter. Instead
/// of ingesting an entire volume at once it processes only four slices at
/// a time. This way, it can generate isosurfaces from huge volumes. Also, the
/// output of this object is written to a marching cubes triangle file. That
/// way, output triangles do not need to be held in memory.
///
/// To use vtkSliceCubes you must specify an instance of vtkVolumeReader to
/// read the data. Set this object up with the proper file prefix, image range,
/// data origin, data dimensions, header size, data mask, and swap bytes flag.
/// The vtkSliceCubes object will then take over and read slices as necessary.
/// You also will need to specify the name of an output marching cubes triangle
/// file.
///
/// @warning
/// This process object is both a source and mapper (i.e., it reads and writes
/// data to a file). This is different than the other marching cubes objects
/// (and most process objects in the system). It's specialized to handle very
/// large data.
///
/// @warning
/// This object only extracts a single isosurface. This compares with the other
/// contouring objects in vtk that generate multiple surfaces.
///
/// @warning
/// To read the output file use vtkMCubesReader.
///
/// </remarks>
/// <seealso>
///
/// vtkMarchingCubes vtkContourFilter vtkMCubesReader vtkDividingCubes vtkVolumeReader
/// </seealso>
public class vtkSliceCubes : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSliceCubes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSliceCubes()
	{
		MRClassNameKey = "class vtkSliceCubes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliceCubes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSliceCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliceCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSliceCubes New()
	{
		vtkSliceCubes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliceCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSliceCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSliceCubes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSliceCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliceCubes_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Specify file name of marching cubes output file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkSliceCubes_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliceCubes_GetLimitsFileName_02(HandleRef pThis);

	/// <summary>
	/// Specify file name of marching cubes limits file. The limits file
	/// speeds up subsequent reading of output triangle file.
	/// </summary>
	public virtual string GetLimitsFileName()
	{
		return Marshal.PtrToStringAnsi(vtkSliceCubes_GetLimitsFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSliceCubes_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSliceCubes_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSliceCubes_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSliceCubes_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliceCubes_GetReader_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get object to read slices.
	/// </summary>
	public virtual vtkVolumeReader GetReader()
	{
		vtkVolumeReader vtkVolumeReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliceCubes_GetReader_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeReader2 = (vtkVolumeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeReader2.Register(null);
			}
		}
		return vtkVolumeReader2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSliceCubes_GetValue_06(HandleRef pThis);

	/// <summary>
	/// Set/get isosurface contour value.
	/// </summary>
	public virtual double GetValue()
	{
		return vtkSliceCubes_GetValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliceCubes_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSliceCubes_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliceCubes_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSliceCubes_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliceCubes_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSliceCubes NewInstance()
	{
		vtkSliceCubes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliceCubes_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSliceCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliceCubes_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSliceCubes SafeDownCast(vtkObjectBase o)
	{
		vtkSliceCubes vtkSliceCubes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliceCubes_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSliceCubes2 = (vtkSliceCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSliceCubes2.Register(null);
			}
		}
		return vtkSliceCubes2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliceCubes_SetFileName_12(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of marching cubes output file.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkSliceCubes_SetFileName_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliceCubes_SetLimitsFileName_13(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of marching cubes limits file. The limits file
	/// speeds up subsequent reading of output triangle file.
	/// </summary>
	public virtual void SetLimitsFileName(string _arg)
	{
		vtkSliceCubes_SetLimitsFileName_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliceCubes_SetReader_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get object to read slices.
	/// </summary>
	public virtual void SetReader(vtkVolumeReader arg0)
	{
		vtkSliceCubes_SetReader_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliceCubes_SetValue_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get isosurface contour value.
	/// </summary>
	public virtual void SetValue(double _arg)
	{
		vtkSliceCubes_SetValue_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliceCubes_Update_16(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void Update()
	{
		vtkSliceCubes_Update_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliceCubes_Write_17(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void Write()
	{
		vtkSliceCubes_Write_17(GetCppThis());
	}
}
