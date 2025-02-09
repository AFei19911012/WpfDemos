using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProStarReader
/// </summary>
/// <remarks>
///    Reads geometry in proSTAR (STARCD) file format.
///
/// vtkProStarReader creates an unstructured grid dataset.
/// It reads .cel/.vrt files stored in proSTAR (STARCD) ASCII format.
///
/// @par Thanks:
/// Reader written by Mark Olesen
///
/// </remarks>
public class vtkProStarReader : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// The type of material represented by the cell
	/// </summary>
	public enum cellType
	{
		/// <summary>enum member</summary>
		starcdBaffleType = 3,
		/// <summary>enum member</summary>
		starcdFluidType = 1,
		/// <summary>enum member</summary>
		starcdLineType = 5,
		/// <summary>enum member</summary>
		starcdPointType = 6,
		/// <summary>enum member</summary>
		starcdShellType = 4,
		/// <summary>enum member</summary>
		starcdSolidType = 2
	}

	/// <summary>
	/// The primitive cell shape
	/// </summary>
	public enum shapeType
	{
		/// <summary>enum member</summary>
		starcdHex = 11,
		/// <summary>enum member</summary>
		starcdLine = 2,
		/// <summary>enum member</summary>
		starcdPoint = 1,
		/// <summary>enum member</summary>
		starcdPoly = 255,
		/// <summary>enum member</summary>
		starcdPrism = 12,
		/// <summary>enum member</summary>
		starcdPyr = 14,
		/// <summary>enum member</summary>
		starcdShell = 3,
		/// <summary>enum member</summary>
		starcdTet = 13
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProStarReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProStarReader()
	{
		MRClassNameKey = "class vtkProStarReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProStarReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProStarReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProStarReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProStarReader New()
	{
		vtkProStarReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProStarReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProStarReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProStarReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProStarReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkProStarReader_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Specify the file name prefix of the cel/vrt files to read.
	/// The reader will try to open FileName.cel and FileName.vrt files.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkProStarReader_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProStarReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProStarReader_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProStarReader_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProStarReader_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProStarReader_GetScaleFactor_04(HandleRef pThis);

	/// <summary>
	/// The proSTAR files are often in millimeters.
	/// Specify an alternative scaling factor.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkProStarReader_GetScaleFactor_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProStarReader_GetScaleFactorMaxValue_05(HandleRef pThis);

	/// <summary>
	/// The proSTAR files are often in millimeters.
	/// Specify an alternative scaling factor.
	/// </summary>
	public virtual double GetScaleFactorMaxValue()
	{
		return vtkProStarReader_GetScaleFactorMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProStarReader_GetScaleFactorMinValue_06(HandleRef pThis);

	/// <summary>
	/// The proSTAR files are often in millimeters.
	/// Specify an alternative scaling factor.
	/// </summary>
	public virtual double GetScaleFactorMinValue()
	{
		return vtkProStarReader_GetScaleFactorMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProStarReader_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProStarReader_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProStarReader_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProStarReader_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProStarReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProStarReader NewInstance()
	{
		vtkProStarReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProStarReader_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProStarReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProStarReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProStarReader SafeDownCast(vtkObjectBase o)
	{
		vtkProStarReader vtkProStarReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProStarReader_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProStarReader2 = (vtkProStarReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProStarReader2.Register(null);
			}
		}
		return vtkProStarReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProStarReader_SetFileName_12(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the file name prefix of the cel/vrt files to read.
	/// The reader will try to open FileName.cel and FileName.vrt files.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkProStarReader_SetFileName_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProStarReader_SetScaleFactor_13(HandleRef pThis, double _arg);

	/// <summary>
	/// The proSTAR files are often in millimeters.
	/// Specify an alternative scaling factor.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkProStarReader_SetScaleFactor_13(GetCppThis(), _arg);
	}
}
