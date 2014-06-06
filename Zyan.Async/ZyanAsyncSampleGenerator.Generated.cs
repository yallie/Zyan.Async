﻿// Rewriting XML comments is not supported
#pragma warning disable 1591

// Assembly name: Zyan.Async.TestInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
namespace Zyan.Async.TestInterfaces
{
	/// <summary>
	/// Asynchronous extension methods for the <see cref="Zyan.Async.TestInterfaces.IGenericInterface`2" /> interface.
	/// </summary>
	public static class IGenericInterfaceAsyncExtensions
	{
		// Void GenericProcedure(T)
		public static System.Threading.Tasks.Task GenericProcedureAsync<T, U>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, T value = null)
			where T : class
			where U : new()
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericProcedure(value));
		}

		// T GenericFunction(U)
		public static System.Threading.Tasks.Task<T> GenericFunctionAsync<T, U>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, U value)
			where T : class
			where U : new()
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericFunction(value));
		}

		// System.Collections.Generic.IList`1[T] GenericList(System.Collections.Generic.Dictionary`2[T,U])
		public static System.Threading.Tasks.Task<System.Collections.Generic.IList<T>> GenericListAsync<T, U>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, System.Collections.Generic.Dictionary<T, U> parameters)
			where T : class
			where U : new()
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericList(parameters));
		}

		// System.Collections.Generic.List`1[System.Collections.Generic.Dictionary`2[T,System.Collections.Generic.HashSet`1[R]]] GenericMethod4[R](System.Func`2[T,U])
		public static System.Threading.Tasks.Task<System.Collections.Generic.List<System.Collections.Generic.Dictionary<T, System.Collections.Generic.HashSet<R>>>> GenericMethod4Async<T, U, R>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, System.Func<T, U> func)
			where T : class
			where U : new()
			where R : System.IDisposable
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericMethod4<R>(func));
		}

		// System.Collections.Generic.IEnumerable`1[T] GetEnumerable[R](R)
		public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<T>> GetEnumerableAsync<T, U, R>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, R param = default(R))
			where T : class
			where U : new()
			where R : struct
		{
			return System.Threading.Tasks.Task.Run(() => self.GetEnumerable<R>(param));
		}

		// System.Linq.IQueryable`1[U] GetQuery[R](R)
		public static System.Threading.Tasks.Task<System.Linq.IQueryable<U>> GetQueryAsync<T, U, R>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, R param = null)
			where T : class
			where U : new()
			where R : System.IO.Stream, new()
		{
			return System.Threading.Tasks.Task.Run(() => self.GetQuery<R>(param));
		}

		// System.Collections.Generic.ICollection`1[R] GetCollection[R](R)
		public static System.Threading.Tasks.Task<System.Collections.Generic.ICollection<R>> GetCollectionAsync<T, U, R>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, R param = null)
			where T : class
			where U : new()
			where R : class, System.IDisposable, new()
		{
			return System.Threading.Tasks.Task.Run(() => self.GetCollection<R>(param));
		}

	}
} // Zyan.Async.TestInterfaces.IGenericInterfaceAsyncExtensions

namespace Zyan.Async.TestInterfaces
{
	/// <summary>
	/// Asynchronous extension methods for the <see cref="Zyan.Async.TestInterfaces.IGenericMethods" /> interface.
	/// </summary>
	public static class IGenericMethodsAsyncExtensions
	{
		// Void GenericMethod1[T]()
		public static System.Threading.Tasks.Task GenericMethod1Async<T>(this Zyan.Async.TestInterfaces.IGenericMethods self)
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericMethod1<T>());
		}

		// T GenericMethod2[T]()
		public static System.Threading.Tasks.Task<T> GenericMethod2Async<T>(this Zyan.Async.TestInterfaces.IGenericMethods self)
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericMethod2<T>());
		}

		// System.Collections.Generic.IList`1[T] GenericMethod3[T](System.Collections.Generic.Dictionary`2[System.String,T])
		public static System.Threading.Tasks.Task<System.Collections.Generic.IList<T>> GenericMethod3Async<T>(this Zyan.Async.TestInterfaces.IGenericMethods self, System.Collections.Generic.Dictionary<System.String, T> parameters)
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericMethod3<T>(parameters));
		}

		// System.Collections.Generic.List`1[System.Collections.Generic.Dictionary`2[T,System.Collections.Generic.HashSet`1[R]]] GenericMethod4[T,R](System.Func`2[R,T])
		public static System.Threading.Tasks.Task<System.Collections.Generic.List<System.Collections.Generic.Dictionary<T, System.Collections.Generic.HashSet<R>>>> GenericMethod4Async<T, R>(this Zyan.Async.TestInterfaces.IGenericMethods self, System.Func<R, T> func = null)
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericMethod4<T, R>(func));
		}

		// System.Collections.Generic.IEnumerable`1[T] GetEnumerable[T]()
		public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<T>> GetEnumerableAsync<T>(this Zyan.Async.TestInterfaces.IGenericMethods self)
			where T : struct
		{
			return System.Threading.Tasks.Task.Run(() => self.GetEnumerable<T>());
		}

		// System.Linq.IQueryable`1[T] GetQuery[T]()
		public static System.Threading.Tasks.Task<System.Linq.IQueryable<T>> GetQueryAsync<T>(this Zyan.Async.TestInterfaces.IGenericMethods self)
			where T : class, System.IDisposable, new()
		{
			return System.Threading.Tasks.Task.Run(() => self.GetQuery<T>());
		}

	}
} // Zyan.Async.TestInterfaces.IGenericMethodsAsyncExtensions

namespace Zyan.Async.TestInterfaces
{
	/// <summary>
	/// Asynchronous extension methods for the <see cref="Zyan.Async.TestInterfaces.INonGenericMethods" /> interface.
	/// </summary>
	public static class INonGenericMethodsAsyncExtensions
	{
		// Void Start()
		public static System.Threading.Tasks.Task StartAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self)
		{
			return System.Threading.Tasks.Task.Run(() => self.Start());
		}

		// Int32 GetValue()
		public static System.Threading.Tasks.Task<System.Int32> GetValueAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self)
		{
			return System.Threading.Tasks.Task.Run(() => self.GetValue());
		}

		// System.String GenerateName(Int32, System.Decimal)
		public static System.Threading.Tasks.Task<System.String> GenerateNameAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.Int32 a, System.Decimal b = 1.0M)
		{
			return System.Threading.Tasks.Task.Run(() => self.GenerateName(a, b));
		}

		// System.Object CreateMessage(System.String, System.Object[])
		public static System.Threading.Tasks.Task<System.Object> CreateMessageAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.String format = @"", params System.Object[] args)
		{
			return System.Threading.Tasks.Task.Run(() => self.CreateMessage(format, args));
		}

		// System.Collections.Generic.List`1[System.String] ConvertToStrings(System.Collections.Generic.IEnumerable`1[System.Int32])
		public static System.Threading.Tasks.Task<System.Collections.Generic.List<System.String>> ConvertToStringsAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.Collections.Generic.IEnumerable<System.Int32> ints = null)
		{
			return System.Threading.Tasks.Task.Run(() => self.ConvertToStrings(ints));
		}

		// System.String[,,,] MultidimensionalArrayExample(Int32[,,])
		public static System.Threading.Tasks.Task<System.String[,,,]> MultidimensionalArrayExampleAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.Int32[,,] a)
		{
			return System.Threading.Tasks.Task.Run(() => self.MultidimensionalArrayExample(a));
		}

		// Int32[][] JaggedArrayExample(System.String[][][])
		public static System.Threading.Tasks.Task<System.Int32[][]> JaggedArrayExampleAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.String[][][] x)
		{
			return System.Threading.Tasks.Task.Run(() => self.JaggedArrayExample(x));
		}

		// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.Dictionary`2[System.String,System.Int32]][] MixedArrayExample(System.Nullable`1[System.Int32][])
		public static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>[]> MixedArrayExampleAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.Nullable<System.Int32>[] arg)
		{
			return System.Threading.Tasks.Task.Run(() => self.MixedArrayExample(arg));
		}

	}
} // Zyan.Async.TestInterfaces.INonGenericMethodsAsyncExtensions

namespace Zyan.Async.TestInterfaces
{
	/// <summary>
	/// Asynchronous extension methods for the <see cref="Zyan.Async.TestInterfaces.INotSupportedMembers" /> interface.
	/// </summary>
	public static class INotSupportedMembersAsyncExtensions
	{
		// Void Dummy()
		public static System.Threading.Tasks.Task DummyAsync(this Zyan.Async.TestInterfaces.INotSupportedMembers self)
		{
			return System.Threading.Tasks.Task.Run(() => self.Dummy());
		}

	}
} // Zyan.Async.TestInterfaces.INotSupportedMembersAsyncExtensions


