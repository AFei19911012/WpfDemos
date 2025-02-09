using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.mummy.Runtime;

public class Methods
{
	private delegate void ObjectRefCountChangedCallback(IntPtr arg0, uint arg1, uint arg2);

	public const string RuntimeEL_dll = "Kitware.mummy.Runtime.Unmanaged.dll";

	private static Methods Instance = new Methods();

	private Hashtable WrappedObjectsTable = null;

	private uint WrappedObjectsTableHits = 0u;

	private uint WrappedObjectsTableMisses = 0u;

	private Hashtable RegisteredTypes = null;

	private Hashtable RegisteredAssemblies = null;

	private ArrayList IndexedConstructors = null;

	private ObjectRefCountChangedCallback Callback = null;

	private uint CallbackId = uint.MaxValue;

	private static bool TraceInternalCalls = false;

	private static bool TraceToConsoleError = true;

	private static bool TraceToConsoleOut = false;

	private static bool TraceToDebug = true;

	private Methods()
	{
	}

	~Methods()
	{
		ForceRemoveCallbacksImpl();
	}

	public static void Trace(string s)
	{
		if (TraceToConsoleError)
		{
			Console.Error.WriteLine(s);
		}
		if (TraceToConsoleOut)
		{
			Console.Out.WriteLine(s);
		}
		if (!TraceToDebug)
		{
		}
	}

	private void Instance_ObjectRefCountChangedCallback(IntPtr rawCppThis, uint oldCount, uint newCount)
	{
		if (2 == newCount && 1 == oldCount)
		{
			EnsureStrongTableReference(rawCppThis);
		}
		else if (1 == newCount && 2 == oldCount)
		{
			EnsureWeakTableReference(rawCppThis);
		}
	}

	private void EnsureStrongTableReference(IntPtr rawCppThis)
	{
		if (null == WrappedObjectsTable)
		{
			return;
		}
		lock (WrappedObjectsTable.SyncRoot)
		{
			if (WrappedObjectsTable.ContainsKey(rawCppThis) && WrappedObjectsTable[rawCppThis] is WeakReference weakReference)
			{
				WrappedObjectsTable[rawCppThis] = weakReference.Target;
				if (TraceInternalCalls)
				{
					Trace($"rawCppThis '0x{(long)rawCppThis:x8}' converted to strong table reference");
				}
			}
		}
	}

	private void EnsureWeakTableReference(IntPtr rawCppThis)
	{
		if (null == WrappedObjectsTable)
		{
			return;
		}
		lock (WrappedObjectsTable.SyncRoot)
		{
			if (!WrappedObjectsTable.ContainsKey(rawCppThis))
			{
				return;
			}
			object obj = WrappedObjectsTable[rawCppThis];
			WeakReference weakReference = obj as WeakReference;
			if (null == weakReference)
			{
				WrappedObjectsTable[rawCppThis] = new WeakReference(obj);
				if (TraceInternalCalls)
				{
					Trace($"rawCppThis '0x{(long)rawCppThis:x8}' converted to weak table reference");
				}
			}
		}
	}

	private void AddTableReferenceImpl(IntPtr rawCppThis, object obj, bool strong)
	{
		if (rawCppThis == IntPtr.Zero)
		{
			throw new Exception($"error: A 'null' rawCppThis pointer may not be used as a WrappedObjectsTable key.");
		}
		if (null == WrappedObjectsTable)
		{
			WrappedObjectsTable = new Hashtable();
			Callback = Instance_ObjectRefCountChangedCallback;
			CallbackId = AddObjectRefCountChangedCallback(Callback);
		}
		lock (WrappedObjectsTable.SyncRoot)
		{
			if (WrappedObjectsTable.ContainsKey(rawCppThis))
			{
				if (!(WrappedObjectsTable[rawCppThis] is WeakReference weakReference))
				{
					throw new Exception($"error: Duplicate rawCppThis - existing strong reference. Attempting to add '0x{(long)rawCppThis:x8}' again.");
				}
				if (weakReference.IsAlive)
				{
					if (strong)
					{
						throw new Exception($"error: Duplicate rawCppThis - weak reference that is still alive. Attempting to add '0x{(long)rawCppThis:x8}' again.");
					}
					Trace("");
					Trace($"error: potential refcounting error: Duplicate rawCppThis - weak reference that is still alive. Attempting to add '0x{(long)rawCppThis:x8}' again.");
					Trace($"       Allowing new wrapped object to take over table key...");
					Trace($"       Original object should *not* have been destroyed while we still had it in our table without notifying us...");
					Trace("");
				}
			}
			if (strong)
			{
				WrappedObjectsTable[rawCppThis] = obj;
				if (TraceInternalCalls)
				{
					Trace($"rawCppThis '0x{(long)rawCppThis:x8}' added as strong table reference");
				}
			}
			else
			{
				WrappedObjectsTable[rawCppThis] = new WeakReference(obj);
				if (TraceInternalCalls)
				{
					Trace($"rawCppThis '0x{(long)rawCppThis:x8}' added as weak table reference");
				}
			}
		}
	}

	public static void AddTableReference(IntPtr rawCppThis, object obj, bool strong)
	{
		Instance.AddTableReferenceImpl(rawCppThis, obj, strong);
	}

	private void RemoveTableReferenceImpl(IntPtr rawCppThis)
	{
		if (null == WrappedObjectsTable)
		{
			return;
		}
		lock (WrappedObjectsTable.SyncRoot)
		{
			WrappedObjectsTable.Remove(rawCppThis);
			if (TraceInternalCalls)
			{
				Trace($"rawCppThis '0x{(long)rawCppThis:x8}' removed");
			}
		}
	}

	public static void RemoveTableReference(IntPtr rawCppThis)
	{
		Instance.RemoveTableReferenceImpl(rawCppThis);
	}

	[DllImport("Kitware.mummy.Runtime.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern uint Kitware_mummy_Runtime_AddObjectRefCountChangedCallback(ObjectRefCountChangedCallback cb);

	private static uint AddObjectRefCountChangedCallback(ObjectRefCountChangedCallback cb)
	{
		return Kitware_mummy_Runtime_AddObjectRefCountChangedCallback(cb);
	}

	[DllImport("Kitware.mummy.Runtime.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint Kitware_mummy_Runtime_GetTypeEntryCount();

	public static uint GetTypeEntryCount()
	{
		return Kitware_mummy_Runtime_GetTypeEntryCount();
	}

	[DllImport("Kitware.mummy.Runtime.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr Kitware_mummy_Runtime_GetTypeEntryClassNameKey(uint mteIndex);

	public static string GetTypeEntryClassNameKey(uint mteIndex)
	{
		return Marshal.PtrToStringAnsi(Kitware_mummy_Runtime_GetTypeEntryClassNameKey(mteIndex));
	}

	[DllImport("Kitware.mummy.Runtime.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void Kitware_mummy_Runtime_RemoveObjectRefCountChangedCallback(uint cbid);

	private static void RemoveObjectRefCountChangedCallback(uint cbid)
	{
		Kitware_mummy_Runtime_RemoveObjectRefCountChangedCallback(cbid);
	}

	private void ForceReferenceStaticConstructors(Assembly assembly, string classNameKey)
	{
		if (TraceInternalCalls)
		{
			Trace($"Force loading types from assembly: {assembly.GetName().FullName}");
		}
		Type[] exportedTypes = assembly.GetExportedTypes();
		foreach (Type type in exportedTypes)
		{
			if (!type.IsClass)
			{
				continue;
			}
			FieldInfo field = type.GetField("MRClassNameKey");
			if (null != field && field.IsStatic)
			{
				string text = field.GetValue(null) as string;
				if (null == text)
				{
					throw new Exception($"error: could not get field value MRClassNameKey for class '{type.Name}'.");
				}
			}
		}
	}

	private void RegisterTypeImpl(Assembly assembly, string classNameKey, Type t)
	{
		if (null == RegisteredAssemblies)
		{
			RegisteredAssemblies = new Hashtable();
		}
		if (null == RegisteredTypes)
		{
			RegisteredTypes = new Hashtable();
		}
		if (null == RegisteredAssemblies[assembly])
		{
			RegisteredAssemblies[assembly] = assembly;
			ForceReferenceStaticConstructors(assembly, classNameKey);
		}
		if (null != RegisteredTypes[classNameKey])
		{
			throw new Exception($"error: RegisterType called more than once with classNameKey='{classNameKey}'. Class key duplicated in multiple assemblies? Static initializer called more than once?");
		}
		RegisteredTypes[classNameKey] = t;
	}

	public static void RegisterType(Assembly assembly, string classNameKey, Type t)
	{
		Instance.RegisterTypeImpl(assembly, classNameKey, t);
	}

	private uint ClassNameKeyToIndex(string classNameKey)
	{
		bool flag = false;
		uint num = 0u;
		uint typeEntryCount = GetTypeEntryCount();
		num = 0u;
		while (!flag && num < typeEntryCount)
		{
			if (classNameKey == GetTypeEntryClassNameKey(num))
			{
				return num;
			}
			num++;
		}
		return uint.MaxValue;
	}

	private ConstructorInfo GetConstructorInfo(uint mteIndex)
	{
		ConstructorInfo constructorInfo = null;
		if (null != IndexedConstructors && mteIndex < IndexedConstructors.Count)
		{
			constructorInfo = (ConstructorInfo)IndexedConstructors[(int)mteIndex];
			if (null != constructorInfo && TraceInternalCalls)
			{
				Trace("info: found ci in IndexedConstructors");
			}
		}
		if (null == constructorInfo)
		{
			string typeEntryClassNameKey = GetTypeEntryClassNameKey(mteIndex);
			Type type = null;
			if (null != RegisteredTypes)
			{
				type = (Type)RegisteredTypes[typeEntryClassNameKey];
			}
			if (null == type)
			{
				throw new Exception($"error: could not get registered type - mteIndex='{mteIndex}' classNameKey='{typeEntryClassNameKey}'");
			}
			constructorInfo = type.GetConstructor(new Type[3]
			{
				Type.GetType("System.IntPtr"),
				Type.GetType("System.Boolean"),
				Type.GetType("System.Boolean")
			});
			if (null == constructorInfo)
			{
				throw new Exception("error: expected 3 parameter constructor is unavailable - is it public?");
			}
			if (TraceInternalCalls)
			{
				Trace($"info: found ci via RegisteredTypes lookup - mteIndex: {mteIndex} - classNameKey: {typeEntryClassNameKey}");
			}
			if (null == IndexedConstructors)
			{
				IndexedConstructors = new ArrayList(128);
			}
			if (mteIndex < IndexedConstructors.Count && null != IndexedConstructors[(int)mteIndex])
			{
				throw new Exception($"error: IndexedConstructors table already has a non-null entry at mteIndex {mteIndex}");
			}
			while (mteIndex >= IndexedConstructors.Count)
			{
				IndexedConstructors.Add(null);
			}
			IndexedConstructors[(int)mteIndex] = constructorInfo;
		}
		if (null == constructorInfo)
		{
			throw new Exception("error: mteIndex yields null System.Type in GetSystemType...");
		}
		return constructorInfo;
	}

	private object CreateWrappedObjectImpl(uint mteStatus, uint mteIndex, uint rawRefCount, IntPtr rawCppThis, bool callDisposalMethod, out bool created)
	{
		object obj = null;
		if (null != WrappedObjectsTable)
		{
			lock (WrappedObjectsTable.SyncRoot)
			{
				obj = WrappedObjectsTable[rawCppThis];
				if (obj is WeakReference weakReference)
				{
					obj = weakReference.Target;
				}
			}
		}
		if (null != obj)
		{
			created = false;
			WrappedObjectsTableHits++;
		}
		else
		{
			created = true;
			WrappedObjectsTableMisses++;
			ConstructorInfo constructorInfo = GetConstructorInfo(mteIndex);
			bool flag = true;
			if (mteStatus == 0 || rawRefCount < 2)
			{
				flag = false;
			}
			obj = constructorInfo.Invoke(new object[3] { rawCppThis, callDisposalMethod, flag });
		}
		return obj;
	}

	public static object CreateWrappedObject(uint mteStatus, uint mteIndex, uint rawRefCount, IntPtr rawCppThis, bool callDisposalMethod, out bool found)
	{
		return Instance.CreateWrappedObjectImpl(mteStatus, mteIndex, rawRefCount, rawCppThis, callDisposalMethod, out found);
	}

	private object CreateWrappedObjectImpl(string classNameKey, IntPtr rawCppThis, bool callDisposalMethod, out bool found)
	{
		uint mteIndex = ClassNameKeyToIndex(classNameKey);
		return CreateWrappedObjectImpl(0u, mteIndex, 1u, rawCppThis, callDisposalMethod, out found);
	}

	public static object CreateWrappedObject(string classNameKey, IntPtr rawCppThis, bool callDisposalMethod, out bool found)
	{
		return Instance.CreateWrappedObjectImpl(classNameKey, rawCppThis, callDisposalMethod, out found);
	}

	public static string PrintIndexedConstructorsTable()
	{
		string text = "";
		if (Instance != null && null != Instance.IndexedConstructors)
		{
			text = $"{text}\n  Instance.IndexedConstructors details:";
			text = $"{text}\n    Count: {Instance.IndexedConstructors.Count}";
			int num = 0;
			lock (Instance.IndexedConstructors.SyncRoot)
			{
				foreach (ConstructorInfo indexedConstructor in Instance.IndexedConstructors)
				{
					text = $"{text}\n    Entry: {num}";
					text = $"{text}\n         ci: {indexedConstructor}";
					num++;
				}
			}
		}
		Trace(text);
		return text;
	}

	public static string PrintRegisteredAssembliesTable()
	{
		string text = "";
		if (Instance != null && null != Instance.RegisteredAssemblies)
		{
			text = $"{text}\n  Instance.RegisteredAssemblies details:";
			text = $"{text}\n    Count: {Instance.RegisteredAssemblies.Count}";
			int num = 0;
			lock (Instance.RegisteredAssemblies.SyncRoot)
			{
				foreach (DictionaryEntry registeredAssembly in Instance.RegisteredAssemblies)
				{
					text = $"{text}\n    Entry: {num}";
					text = $"{text}\n        Key: {registeredAssembly.Key}";
					text = $"{text}\n      Value: {registeredAssembly.Value}";
					num++;
				}
			}
		}
		Trace(text);
		return text;
	}

	public static string PrintRegisteredTypesTable()
	{
		string text = "";
		if (null != Instance && null != Instance.RegisteredTypes)
		{
			text = $"{text}\n  Instance.RegisteredTypes details:";
			text = $"{text}\n    Count: {Instance.RegisteredTypes.Count}";
			int num = 0;
			lock (Instance.RegisteredTypes.SyncRoot)
			{
				foreach (DictionaryEntry registeredType in Instance.RegisteredTypes)
				{
					text = $"{text}\n    Entry: {num}";
					text = $"{text}\n        Key: {registeredType.Key}";
					text = $"{text}\n      Value: {registeredType.Value}";
					num++;
				}
			}
		}
		Trace(text);
		return text;
	}

	public static string PrintWrappedObjectsTable()
	{
		string text = "";
		if (Instance != null && null != Instance.WrappedObjectsTable)
		{
			text = $"{text}\n  Instance.WrappedObjectsTable details:";
			text = $"{text}\n    Count: {Instance.WrappedObjectsTable.Count}";
			int num = 0;
			lock (Instance.WrappedObjectsTable.SyncRoot)
			{
				foreach (DictionaryEntry item in Instance.WrappedObjectsTable)
				{
					text = $"{text}\n    Entry: {num}";
					text = $"{text}\n        Key: 0x{(long)(IntPtr)item.Key:x8}";
					text = $"{text}\n      Value: {item.Value}";
					num++;
				}
			}
		}
		Trace(text);
		return text;
	}

	public static string Print(bool details)
	{
		string arg = $"  Instance: {Instance}";
		if (null != Instance)
		{
			arg = $"{arg}\n  Instance.WrappedObjectsTable: {Instance.WrappedObjectsTable}";
			arg = $"{arg}\n  Instance.WrappedObjectsTableHits: {Instance.WrappedObjectsTableHits}";
			arg = $"{arg}\n  Instance.WrappedObjectsTableMisses: {Instance.WrappedObjectsTableMisses}";
			arg = $"{arg}\n  Instance.RegisteredTypes: {Instance.RegisteredTypes}";
			arg = $"{arg}\n  Instance.RegisteredAssemblies: {Instance.RegisteredAssemblies}";
			arg = $"{arg}\n  Instance.IndexedConstructors: {Instance.IndexedConstructors}";
			arg = $"{arg}\n  Instance.CallbackId: {Instance.CallbackId}";
		}
		arg = $"{arg}\n  TraceInternalCalls: {TraceInternalCalls}";
		arg = $"{arg}\n  TraceToConsoleError: {TraceToConsoleError}";
		arg = $"{arg}\n  TraceToConsoleOut: {TraceToConsoleOut}";
		arg = $"{arg}\n  TraceToDebug: {TraceToDebug}";
		Trace(arg);
		if (details)
		{
			arg = $"{arg}\n\n{PrintIndexedConstructorsTable()}";
			arg = $"{arg}\n\n{PrintRegisteredAssembliesTable()}";
			arg = $"{arg}\n\n{PrintRegisteredTypesTable()}";
			arg = $"{arg}\n\n{PrintWrappedObjectsTable()}";
		}
		return arg;
	}

	public static string Print()
	{
		return Print(details: true);
	}

	public static bool Verify()
	{
		return true;
	}

	public static void ForceClearWrappedObjectsTable()
	{
		if (null != Instance.WrappedObjectsTable)
		{
			Instance.WrappedObjectsTable.Clear();
		}
	}

	private void ForceRemoveCallbacksImpl()
	{
		if (-1 != (int)CallbackId)
		{
			RemoveObjectRefCountChangedCallback(CallbackId);
			Callback = null;
			CallbackId = uint.MaxValue;
		}
	}

	public static void ForceRemoveCallbacks()
	{
		Instance.ForceRemoveCallbacksImpl();
	}
}
