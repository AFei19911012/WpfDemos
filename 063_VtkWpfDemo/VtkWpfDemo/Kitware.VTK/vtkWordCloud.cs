using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWordCloud
/// </summary>
/// <remarks>
///    generate a word cloud visualization of a text document
///
/// Word Clouds, AKA Tag Clouds
/// (https://en.wikipedia.org/wiki/Tag_cloud), are a text visualization
/// technique that displays individual words with properties that
/// depend on the frequency of a word in a document. vtkWordCloud
/// varies the font size based on word frequency. Word Clouds are useful
/// for quickly perceiving the most prominent terms in a document.
/// Also, Word Clouds can identify trends and patterns that would
/// otherwise be unclear or difficult to see in a tabular
/// format. Frequently used keywords stand out better in a word
/// cloud. Common words that might be overlooked in tabular form are
/// highlighted in the larger text, making them pop out when displayed
/// in a word cloud.
///
/// There is some controversy about the usefulness of word
/// clouds. Their best use may be for presentations, see
/// https://tinyurl.com/y59hy7oa
///
/// The generation of the word cloud proceeds as follows:
/// 1. Read the text file
/// 2. Split text into words to be processed
///    Extract words from the text
///    Drop the case of each word for filtering
///    Filter the words
///      Replace words from the ReplacementPairs list
///      Skip the word if it is in the stop list or contains a digit
///      Skip single character words
///    Raise the case of the first letter in each word
///    Sort the word list by frequency
/// 3. Create a rectangular mask image or read a mask image
/// 4. For each word
///    Render the word into an image
///    Try to add the word to the word cloud image.
///      For each orientation, see if the word "fits"
///        If no fit, move along a path to try another location
///
/// NOTE: A word fits if all of the non-zero word cloud pixels in the
/// extent of the text image are background pixels.
///
/// NOTE: The path is an Archimedean Spiral
/// (https://en.wikipedia.org/wiki/Archimedean_spiral)
///
/// NOTE: vtkWordCloud has a built-in list of stop word. Stop words are
/// words that are filtered out before processing of the text, such as
/// the, is, at, which, and so on.
///
/// NOTE: Color names are defined in vtkNamedColors. A visual
/// representation of color names is here: https://tinyurl.com/y3yxcxj6
///
/// NOTE: vtkWordCloud offers Several methods to customize the resulting
/// visualization. The class provides defaults that provide a reasonable
/// result.
///
/// BackgroundColorName - The vtkNamedColors name for the background
/// (MidNightBlue). See https://tinyurl.com/y3yxcxj6 for a visual
/// representation of the named colors.
///
/// ColorDistribution - Distribution of random colors(.6 1.0), if
/// WordColorName is empty.
///
/// ColorSchemeName - Name of a color scheme from vtkColorSeries to be
/// used to select colors for the words (), if WordColorName is empty.
/// See https://tinyurl.com/y3j6c27o for a visual representation of the
/// color schemes.
///
/// DPI - Dots per inch(200) of the rendered text. DPI is used as a
/// scaling mechanism for the words. As DPI increases, the word size
/// increases. If there are too, few skipped words, increase this value,
/// too many, decrease it.
///
/// FontFileName - If empty, the built-in Arial font is used(). The
/// FontFileName is the name of a file that contains a TrueType font.
/// https://www.1001freefonts.com/ is a good source for free TrueType
/// fonts.
///
/// FontMultiplier - Font multiplier(6). The final FontSize is this value
/// times the word frequency.
///
/// Gap - Space gap of words (2). The gap is the number of spaces added to
/// the beginning and end of each word.
///
/// MaskColorName - Name of the color for the mask (black). This is the
/// name of the vtknamedColors that defines the foreground of the
/// mask. Usually black or white.  See https://tinyurl.com/y3yxcxj6 for
/// a visual representation of the named colors.
///
/// MaskFileName - Mask file name(). If a mask file is specified, it will be
/// used as the mask. Otherwise, a black square is used as the mask. The
/// mask file should contain three channels of unsigned char values. If
/// the mask file is just a single unsigned char, specify turn the boolean
/// BWMask on.  If BWmask is on, the class will create a three channel
/// image using vtkImageAppendComponents.
///
/// BWMask - Mask image has a single channel(false). Mask images typically
/// have three channels (r,g,b).
///
/// MaxFontSize - Maximum font size(48).
///
/// MinFontSize - Minimum font size(8).
///
/// MinFrequency - Minimum word frequency accepted(2). Word with
/// frequencies less than this will be ignored.
///
/// OffsetDistribution - Range of uniform random offsets(-size[0]/100.0
/// -size{1]/100.0)(-20 20). These offsets are offsets from the generated
/// path for word layout.
///
/// OrientationDistribution - Ranges of random orientations(-20 20). If
/// discrete orientations are not defined, these orientations will be
/// generated.
///
/// Orientations - Vector of discrete orientations(). If non-empty,
/// these will be used instead of the orientations distribution");
///
/// ReplacementPairs - Replace the first word with another second word
/// ().  The each word will also added to the StopList. The second
/// argument can contain multiple words. For example you could replace
/// "bill" with "Bill Lorensen" or, "vtk" with "VTK . Remember that
/// words are always stored internally with lower case, even though the
/// first letter is capitalized in the Word Cloud.
///
/// Sizes - Size of image(640 480).
///
/// StopWords - User provided stop words(). Stop words are words that
/// are filtered out before processing of the text, such as the, is,
/// at, which, and so on.  vtkWordClass has built-in stop words. The
/// user-provided stop words are added to the built-in list. See
/// https://en.wikipedia.org/wiki/Stop_words for a description.  The
/// built-in stop words were derived from the english stop words at
/// https://www.ranks.nl/stopwords. Stop words for other languages are
/// also available.
///
/// StopListFileName - the name of a file that contains stop words,
/// one word per line (). If present, the stop words in the file
/// replace the built-in stop list.
///
/// Title - Add this word to the document's words and set a high
/// frequency, so that is will be rendered first.
///
/// WordColorName - Name of the color for the words(). The name is
/// selected from vtkNamedColors. If the name is empty, the
/// ColorDistribution will generate random colors.  See
/// https://tinyurl.com/y3yxcxj6 for a visual representation of the
/// named colors.
///
/// The class also provided Get methods that return vectors
/// StopWords, SkippedWords and KeptWords.
/// </remarks>
public class vtkWordCloud : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWordCloud";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWordCloud()
	{
		MRClassNameKey = "class vtkWordCloud";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWordCloud"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWordCloud(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWordCloud_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with vertex cell generation turned off.
	/// </summary>
	public new static vtkWordCloud New()
	{
		vtkWordCloud result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWordCloud_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWordCloud)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with vertex cell generation turned off.
	/// </summary>
	public vtkWordCloud()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWordCloud_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_AddOrientation_01(HandleRef pThis, double arg);

	/// <summary>
	/// Set/Add/Get Orientations, a vector of discrete orientations (). If
	/// non-empty, these will be used instead of the orientations
	/// distribution").
	/// </summary>
	public void AddOrientation(double arg)
	{
		vtkWordCloud_AddOrientation_01(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_AddStopWord_02(HandleRef pThis, string word);

	/// <summary>
	/// Set/Add/Get StopWords, a set of user provided stop
	/// words(). vtkWordClass has built-in stop words. The user-provided
	/// stop words are added to the built-in list.
	/// </summary>
	public void AddStopWord(string word)
	{
		vtkWordCloud_AddStopWord_02(GetCppThis(), word);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_ClearStopWords_03(HandleRef pThis);

	/// <summary>
	/// Set/Add/Get StopWords, a set of user provided stop
	/// words(). vtkWordClass has built-in stop words. The user-provided
	/// stop words are added to the built-in list.
	/// </summary>
	public void ClearStopWords()
	{
		vtkWordCloud_ClearStopWords_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkWordCloud_GetBWMask_04(HandleRef pThis);

	/// <summary>
	/// Set/Get boolean that indicates the mask image is a single
	/// channel(false).
	/// </summary>
	public virtual bool GetBWMask()
	{
		return (vtkWordCloud_GetBWMask_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkWordCloud_GetBackgroundColorName_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the vtkNamedColors name for the background(MidNightBlue).
	/// </summary>
	public virtual string GetBackgroundColorName()
	{
		return vtkWordCloud_GetBackgroundColorName_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkWordCloud_GetColorSchemeName_06(HandleRef pThis);

	/// <summary>
	/// Set/Get ColorSchemeName, the name of a color scheme from
	/// vtkColorScheme to be used to select colors for the words (), if
	/// WordColorName is empty. See https://tinyurl.com/y3j6c27o for a
	/// visual representation of the color schemes.
	/// </summary>
	public virtual string GetColorSchemeName()
	{
		return vtkWordCloud_GetColorSchemeName_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWordCloud_GetDPI_07(HandleRef pThis);

	/// <summary>
	/// Set/GetDPI - Dots per inch(200) of the rendered text. DPI is
	/// used as a scaling mechanism for the words. As DPI increases,
	/// the word size increases. If there are too, few skipped words,
	/// increase this value, too many, decrease it.
	/// </summary>
	public virtual int GetDPI()
	{
		return vtkWordCloud_GetDPI_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkWordCloud_GetFileName_08(HandleRef pThis);

	/// <summary>
	/// Set/Get FileName, the name of the file that contains the text to
	/// be processed.
	/// </summary>
	public virtual string GetFileName()
	{
		return vtkWordCloud_GetFileName_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkWordCloud_GetFontFileName_09(HandleRef pThis);

	/// <summary>
	/// Set/Get FontFileName, If empty, the built-in Arial font is
	/// used(). The FontFileName is the name of a file that contains a
	/// TrueType font.
	/// </summary>
	public virtual string GetFontFileName()
	{
		return vtkWordCloud_GetFontFileName_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWordCloud_GetFontMultiplier_10(HandleRef pThis);

	/// <summary>
	/// Set/Get FontMultiplier, the font multiplier(6). The final
	/// FontSize is this value the word frequency.
	/// </summary>
	public virtual int GetFontMultiplier()
	{
		return vtkWordCloud_GetFontMultiplier_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWordCloud_GetGap_11(HandleRef pThis);

	/// <summary>
	/// Set/Get Gap, the space gap of words (2). The gap is the number
	/// of spaces added to the beginning and end of each word.
	/// </summary>
	public virtual int GetGap()
	{
		return vtkWordCloud_GetGap_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkWordCloud_GetMaskColorName_12(HandleRef pThis);

	/// <summary>
	/// Set/Get MaskColorName, the name of the color for the mask
	/// (black). This is the name of the vtkNamedColors that defines
	/// the foreground of the mask. Usually black or white.
	/// </summary>
	public virtual string GetMaskColorName()
	{
		return vtkWordCloud_GetMaskColorName_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkWordCloud_GetMaskFileName_13(HandleRef pThis);

	/// <summary>
	/// Set/Get MaskFileName, the mask file name(). If a mask file is
	/// specified, it will be used as the mask. Otherwise, a black
	/// square is used as the mask. The mask file should contain three
	/// channels of unsigned char values. If the mask file is just a
	/// single unsigned char, specify turn the boolean BWMask on.  If
	/// BWmask is on, the class will create a three channel image using
	/// vtkImageAppendComponents.
	/// </summary>
	public virtual string GetMaskFileName()
	{
		return vtkWordCloud_GetMaskFileName_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWordCloud_GetMaxFontSize_14(HandleRef pThis);

	/// <summary>
	/// Set/Get MaxFontSize, the maximum font size(48).
	/// </summary>
	public virtual int GetMaxFontSize()
	{
		return vtkWordCloud_GetMaxFontSize_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWordCloud_GetMinFontSize_15(HandleRef pThis);

	/// <summary>
	/// Set/Get MinFontSize, the minimum font size(8).
	/// </summary>
	public virtual int GetMinFontSize()
	{
		return vtkWordCloud_GetMinFontSize_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWordCloud_GetMinFrequency_16(HandleRef pThis);

	/// <summary>
	/// Set/Get MinFrequency, the minimum word frequency
	/// accepted(2). Words with frequencies less than this will be
	/// ignored.
	/// </summary>
	public virtual int GetMinFrequency()
	{
		return vtkWordCloud_GetMinFrequency_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWordCloud_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWordCloud_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWordCloud_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWordCloud_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkWordCloud_GetStopListFileName_19(HandleRef pThis);

	/// <summary>
	/// Set/Get StopListFileName, the name of the file that contains the
	/// stop words, one per line.
	/// </summary>
	public virtual string GetStopListFileName()
	{
		return vtkWordCloud_GetStopListFileName_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkWordCloud_GetTitle_20(HandleRef pThis);

	/// <summary>
	/// Set/Get Title, add this word to the document's words and set a
	/// high frequency, so that is will be rendered first.
	/// </summary>
	public virtual string GetTitle()
	{
		return vtkWordCloud_GetTitle_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkWordCloud_GetWordColorName_21(HandleRef pThis);

	/// <summary>
	/// Set/Get WordColorName, the name of the color for the
	/// words(). The name is selected from vtkNamedColors. If the name
	/// is empty, the ColorDistribution will generate random colors.
	/// </summary>
	public virtual string GetWordColorName()
	{
		return vtkWordCloud_GetWordColorName_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWordCloud_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWordCloud_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWordCloud_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWordCloud_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWordCloud_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWordCloud NewInstance()
	{
		vtkWordCloud result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWordCloud_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWordCloud)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWordCloud_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWordCloud SafeDownCast(vtkObjectBase o)
	{
		vtkWordCloud vtkWordCloud2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWordCloud_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWordCloud2 = (vtkWordCloud)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWordCloud2.Register(null);
			}
		}
		return vtkWordCloud2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetBWMask_27(HandleRef pThis, byte arg);

	/// <summary>
	/// Set/Get boolean that indicates the mask image is a single
	/// channel(false).
	/// </summary>
	public virtual void SetBWMask(bool arg)
	{
		vtkWordCloud_SetBWMask_27(GetCppThis(), (byte)(arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetBackgroundColorName_28(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get the vtkNamedColors name for the background(MidNightBlue).
	/// </summary>
	public virtual void SetBackgroundColorName(string arg)
	{
		vtkWordCloud_SetBackgroundColorName_28(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetColorSchemeName_29(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get ColorSchemeName, the name of a color scheme from
	/// vtkColorScheme to be used to select colors for the words (), if
	/// WordColorName is empty. See https://tinyurl.com/y3j6c27o for a
	/// visual representation of the color schemes.
	/// </summary>
	public virtual void SetColorSchemeName(string arg)
	{
		vtkWordCloud_SetColorSchemeName_29(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetDPI_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/GetDPI - Dots per inch(200) of the rendered text. DPI is
	/// used as a scaling mechanism for the words. As DPI increases,
	/// the word size increases. If there are too, few skipped words,
	/// increase this value, too many, decrease it.
	/// </summary>
	public virtual void SetDPI(int _arg)
	{
		vtkWordCloud_SetDPI_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetFileName_31(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get FileName, the name of the file that contains the text to
	/// be processed.
	/// </summary>
	public virtual void SetFileName(string arg)
	{
		vtkWordCloud_SetFileName_31(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetFontFileName_32(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get FontFileName, If empty, the built-in Arial font is
	/// used(). The FontFileName is the name of a file that contains a
	/// TrueType font.
	/// </summary>
	public virtual void SetFontFileName(string arg)
	{
		vtkWordCloud_SetFontFileName_32(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetFontMultiplier_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get FontMultiplier, the font multiplier(6). The final
	/// FontSize is this value the word frequency.
	/// </summary>
	public virtual void SetFontMultiplier(int _arg)
	{
		vtkWordCloud_SetFontMultiplier_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetGap_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get Gap, the space gap of words (2). The gap is the number
	/// of spaces added to the beginning and end of each word.
	/// </summary>
	public virtual void SetGap(int _arg)
	{
		vtkWordCloud_SetGap_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetMaskColorName_35(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get MaskColorName, the name of the color for the mask
	/// (black). This is the name of the vtkNamedColors that defines
	/// the foreground of the mask. Usually black or white.
	/// </summary>
	public virtual void SetMaskColorName(string arg)
	{
		vtkWordCloud_SetMaskColorName_35(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetMaskFileName_36(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get MaskFileName, the mask file name(). If a mask file is
	/// specified, it will be used as the mask. Otherwise, a black
	/// square is used as the mask. The mask file should contain three
	/// channels of unsigned char values. If the mask file is just a
	/// single unsigned char, specify turn the boolean BWMask on.  If
	/// BWmask is on, the class will create a three channel image using
	/// vtkImageAppendComponents.
	/// </summary>
	public virtual void SetMaskFileName(string arg)
	{
		vtkWordCloud_SetMaskFileName_36(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetMaxFontSize_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get MaxFontSize, the maximum font size(48).
	/// </summary>
	public virtual void SetMaxFontSize(int _arg)
	{
		vtkWordCloud_SetMaxFontSize_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetMinFontSize_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get MinFontSize, the minimum font size(8).
	/// </summary>
	public virtual void SetMinFontSize(int _arg)
	{
		vtkWordCloud_SetMinFontSize_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetMinFrequency_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get MinFrequency, the minimum word frequency
	/// accepted(2). Words with frequencies less than this will be
	/// ignored.
	/// </summary>
	public virtual void SetMinFrequency(int _arg)
	{
		vtkWordCloud_SetMinFrequency_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetStopListFileName_40(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get StopListFileName, the name of the file that contains the
	/// stop words, one per line.
	/// </summary>
	public virtual void SetStopListFileName(string arg)
	{
		vtkWordCloud_SetStopListFileName_40(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetTitle_41(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get Title, add this word to the document's words and set a
	/// high frequency, so that is will be rendered first.
	/// </summary>
	public virtual void SetTitle(string arg)
	{
		vtkWordCloud_SetTitle_41(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWordCloud_SetWordColorName_42(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get WordColorName, the name of the color for the
	/// words(). The name is selected from vtkNamedColors. If the name
	/// is empty, the ColorDistribution will generate random colors.
	/// </summary>
	public virtual void SetWordColorName(string arg)
	{
		vtkWordCloud_SetWordColorName_42(GetCppThis(), arg);
	}
}
