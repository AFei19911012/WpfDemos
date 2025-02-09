using System;
using System.Reflection;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkNumberToString
/// </summary>
/// <remarks>
///  Convert floating and fixed point numbers to strings
///
/// This class uses the double-conversion library to convert floating point and
/// fixed point numbers to ASCII versions that are represented without
/// numerical precision errors.
///
/// Typical use:
///
/// @code{cpp}
///  #include "vtkNumberToString.h"
///  vtkNumberToString convert;
///  float a = 1.0f/3.0f;
///  std::cout &lt;&lt; convert(a) &lt;&lt; std::endl;
/// @endcode
/// </remarks>
public class vtkNumberToString : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNumberToString";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNumberToString()
	{
		MRClassNameKey = "class vtkNumberToString";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNumberToString"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNumberToString(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
}
