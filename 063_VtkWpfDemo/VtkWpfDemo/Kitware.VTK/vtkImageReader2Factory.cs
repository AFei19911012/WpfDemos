using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageReader2Factory
/// </summary>
/// <remarks>
///    Superclass of binary file readers.
///
/// vtkImageReader2Factory: This class is used to create a vtkImageReader2
/// object given a path name to a file.  It calls CanReadFile on all
/// available readers until one of them returns true.  The available reader
/// list comes from three places.  In the InitializeReaders function of this
/// class, built-in VTK classes are added to the list, users can call
/// RegisterReader, or users can create a vtkObjectFactory that has
/// CreateObject method that returns a new vtkImageReader2 sub class when
/// given the string "vtkImageReaderObject".  This way applications can be
/// extended with new readers via a plugin dll or by calling RegisterReader.
/// Of course all of the readers that are part of the vtk release are made
/// automatically available.
///
/// </remarks>
/// <seealso>
///
/// vtkImageReader2
/// </seealso>
public class vtkImageReader2Factory : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageReader2Factory";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageReader2Factory()
	{
		MRClassNameKey = "class vtkImageReader2Factory";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReader2Factory"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageReader2Factory(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2Factory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageReader2Factory New()
	{
		vtkImageReader2Factory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader2Factory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageReader2Factory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageReader2Factory()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageReader2Factory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageReader2Factory_CheckExtensionIsInExtensions_01(string extension, string extensions);

	/// <summary>
	/// The caller must allocate the vtkImageReader2Collection and pass in the
	/// pointer to this method.
	/// </summary>
	public static bool CheckExtensionIsInExtensions(string extension, string extensions)
	{
		return (vtkImageReader2Factory_CheckExtensionIsInExtensions_01(extension, extensions) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2Factory_CreateImageReader2_02(string path, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// open the image file, it is the callers responsibility to call
	/// Delete on the returned object. If no reader is found, nullptr
	/// is returned.
	/// </summary>
	public static vtkImageReader2 CreateImageReader2(string path)
	{
		vtkImageReader2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader2Factory_CreateImageReader2_02(path, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2Factory_CreateImageReader2FromExtension_03(string extension, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a vtkImageReader2 from a (dotted or not) file extension.
	/// If multiple readers support the same extension, only one reader
	/// will be returned.
	/// It is the callers responsibility to call Delete on the returned object.
	/// If no reader is found, nullptr is returned.
	/// </summary>
	public static vtkImageReader2 CreateImageReader2FromExtension(string extension)
	{
		vtkImageReader2 vtkImageReader3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader2Factory_CreateImageReader2FromExtension_03(extension, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageReader3 = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageReader3.Register(null);
			}
		}
		return vtkImageReader3;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageReader2Factory_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageReader2Factory_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageReader2Factory_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageReader2Factory_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2Factory_GetRegisteredReaders_06(HandleRef arg0);

	/// <summary>
	/// The caller must allocate the vtkImageReader2Collection and pass in the
	/// pointer to this method.
	/// </summary>
	public static void GetRegisteredReaders(vtkImageReader2Collection arg0)
	{
		vtkImageReader2Factory_GetRegisteredReaders_06(arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2Factory_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageReader2Factory_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2Factory_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageReader2Factory_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2Factory_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageReader2Factory NewInstance()
	{
		vtkImageReader2Factory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader2Factory_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageReader2Factory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2Factory_RegisterReader_11(HandleRef r);

	/// <summary>
	/// registered readers will be queried in CreateImageReader2 to
	/// see if they can load a given file.
	/// </summary>
	public static void RegisterReader(vtkImageReader2 r)
	{
		vtkImageReader2Factory_RegisterReader_11(r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2Factory_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageReader2Factory SafeDownCast(vtkObjectBase o)
	{
		vtkImageReader2Factory vtkImageReader2Factory2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader2Factory_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageReader2Factory2 = (vtkImageReader2Factory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageReader2Factory2.Register(null);
			}
		}
		return vtkImageReader2Factory2;
	}
}
