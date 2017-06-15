
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_TEXTURE_TILING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public const int TEXTURE_TILING_EXT = 0x9580;

		/// <summary>
		/// [GL] Value of GL_DEDICATED_MEMORY_OBJECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public const int DEDICATED_MEMORY_OBJECT_EXT = 0x9581;

		/// <summary>
		/// [GL] Value of GL_PROTECTED_MEMORY_OBJECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public const int PROTECTED_MEMORY_OBJECT_EXT = 0x959B;

		/// <summary>
		/// [GL] Value of GL_NUM_TILING_TYPES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public const int NUM_TILING_TYPES_EXT = 0x9582;

		/// <summary>
		/// [GL] Value of GL_TILING_TYPES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public const int TILING_TYPES_EXT = 0x9583;

		/// <summary>
		/// [GL] Value of GL_OPTIMAL_TILING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public const int OPTIMAL_TILING_EXT = 0x9584;

		/// <summary>
		/// [GL] Value of GL_LINEAR_TILING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public const int LINEAR_TILING_EXT = 0x9585;

		/// <summary>
		/// Binding for glDeleteMemoryObjectsEXT.
		/// </summary>
		/// <param name="memoryObjects">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void DeleteMemoryObjectEXT(UInt32[] memoryObjects)
		{
			unsafe {
				fixed (UInt32* p_memoryObjects = memoryObjects)
				{
					Debug.Assert(Delegates.pglDeleteMemoryObjectsEXT != null, "pglDeleteMemoryObjectsEXT not implemented");
					Delegates.pglDeleteMemoryObjectsEXT((Int32)memoryObjects.Length, p_memoryObjects);
					LogCommand("glDeleteMemoryObjectsEXT", null, memoryObjects.Length, memoryObjects					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsMemoryObjectEXT.
		/// </summary>
		/// <param name="memoryObject">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static bool IsMemoryObjectEXT(UInt32 memoryObject)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsMemoryObjectEXT != null, "pglIsMemoryObjectEXT not implemented");
			retValue = Delegates.pglIsMemoryObjectEXT(memoryObject);
			LogCommand("glIsMemoryObjectEXT", retValue, memoryObject			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glCreateMemoryObjectsEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="memoryObjects">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void CreateMemoryObjectEXT(Int32 n, UInt32[] memoryObjects)
		{
			unsafe {
				fixed (UInt32* p_memoryObjects = memoryObjects)
				{
					Debug.Assert(Delegates.pglCreateMemoryObjectsEXT != null, "pglCreateMemoryObjectsEXT not implemented");
					Delegates.pglCreateMemoryObjectsEXT(n, p_memoryObjects);
					LogCommand("glCreateMemoryObjectsEXT", null, n, memoryObjects					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMemoryObjectParameterivEXT.
		/// </summary>
		/// <param name="memoryObject">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MemoryObjectParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void MemoryObjectParameterEXT(UInt32 memoryObject, MemoryObjectParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMemoryObjectParameterivEXT != null, "pglMemoryObjectParameterivEXT not implemented");
					Delegates.pglMemoryObjectParameterivEXT(memoryObject, (Int32)pname, p_params);
					LogCommand("glMemoryObjectParameterivEXT", null, memoryObject, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMemoryObjectParameterivEXT.
		/// </summary>
		/// <param name="memoryObject">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MemoryObjectParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void GetMemoryObjectParameterEXT(UInt32 memoryObject, MemoryObjectParameterName pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMemoryObjectParameterivEXT != null, "pglGetMemoryObjectParameterivEXT not implemented");
					Delegates.pglGetMemoryObjectParameterivEXT(memoryObject, (Int32)pname, p_params);
					LogCommand("glGetMemoryObjectParameterivEXT", null, memoryObject, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexStorageMem2DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void TexStorageEXT(TextureTarget target, Int32 levels, Int32 internalFormat, Int32 width, Int32 height, UInt32 memory, UInt64 offset)
		{
			Debug.Assert(Delegates.pglTexStorageMem2DEXT != null, "pglTexStorageMem2DEXT not implemented");
			Delegates.pglTexStorageMem2DEXT((Int32)target, levels, internalFormat, width, height, memory, offset);
			LogCommand("glTexStorageMem2DEXT", null, target, levels, internalFormat, width, height, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexStorageMem2DMultisampleEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedSampleLocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void TexStorageMem2DMultisampleEXT(TextureTarget target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations, UInt32 memory, UInt64 offset)
		{
			Debug.Assert(Delegates.pglTexStorageMem2DMultisampleEXT != null, "pglTexStorageMem2DMultisampleEXT not implemented");
			Delegates.pglTexStorageMem2DMultisampleEXT((Int32)target, samples, internalFormat, width, height, fixedSampleLocations, memory, offset);
			LogCommand("glTexStorageMem2DMultisampleEXT", null, target, samples, internalFormat, width, height, fixedSampleLocations, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexStorageMem3DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void TexStorageEXT(TextureTarget target, Int32 levels, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, UInt32 memory, UInt64 offset)
		{
			Debug.Assert(Delegates.pglTexStorageMem3DEXT != null, "pglTexStorageMem3DEXT not implemented");
			Delegates.pglTexStorageMem3DEXT((Int32)target, levels, internalFormat, width, height, depth, memory, offset);
			LogCommand("glTexStorageMem3DEXT", null, target, levels, internalFormat, width, height, depth, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexStorageMem3DMultisampleEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedSampleLocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void TexStorageMem3DMultisampleEXT(TextureTarget target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations, UInt32 memory, UInt64 offset)
		{
			Debug.Assert(Delegates.pglTexStorageMem3DMultisampleEXT != null, "pglTexStorageMem3DMultisampleEXT not implemented");
			Delegates.pglTexStorageMem3DMultisampleEXT((Int32)target, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset);
			LogCommand("glTexStorageMem3DMultisampleEXT", null, target, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBufferStorageMemEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void BufferStorageEXT(Int32 target, UInt32 size, UInt32 memory, UInt64 offset)
		{
			Debug.Assert(Delegates.pglBufferStorageMemEXT != null, "pglBufferStorageMemEXT not implemented");
			Delegates.pglBufferStorageMemEXT(target, size, memory, offset);
			LogCommand("glBufferStorageMemEXT", null, target, size, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorageMem2DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void TextureStorageEXT(UInt32 texture, Int32 levels, Int32 internalFormat, Int32 width, Int32 height, UInt32 memory, UInt64 offset)
		{
			Debug.Assert(Delegates.pglTextureStorageMem2DEXT != null, "pglTextureStorageMem2DEXT not implemented");
			Delegates.pglTextureStorageMem2DEXT(texture, levels, internalFormat, width, height, memory, offset);
			LogCommand("glTextureStorageMem2DEXT", null, texture, levels, internalFormat, width, height, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorageMem2DMultisampleEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedSampleLocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void TextureStorageMem2DMultisampleEXT(UInt32 texture, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations, UInt32 memory, UInt64 offset)
		{
			Debug.Assert(Delegates.pglTextureStorageMem2DMultisampleEXT != null, "pglTextureStorageMem2DMultisampleEXT not implemented");
			Delegates.pglTextureStorageMem2DMultisampleEXT(texture, samples, internalFormat, width, height, fixedSampleLocations, memory, offset);
			LogCommand("glTextureStorageMem2DMultisampleEXT", null, texture, samples, internalFormat, width, height, fixedSampleLocations, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorageMem3DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void TextureStorageEXT(UInt32 texture, Int32 levels, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, UInt32 memory, UInt64 offset)
		{
			Debug.Assert(Delegates.pglTextureStorageMem3DEXT != null, "pglTextureStorageMem3DEXT not implemented");
			Delegates.pglTextureStorageMem3DEXT(texture, levels, internalFormat, width, height, depth, memory, offset);
			LogCommand("glTextureStorageMem3DEXT", null, texture, levels, internalFormat, width, height, depth, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorageMem3DMultisampleEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedSampleLocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void TextureStorageMem3DMultisampleEXT(UInt32 texture, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations, UInt32 memory, UInt64 offset)
		{
			Debug.Assert(Delegates.pglTextureStorageMem3DMultisampleEXT != null, "pglTextureStorageMem3DMultisampleEXT not implemented");
			Delegates.pglTextureStorageMem3DMultisampleEXT(texture, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset);
			LogCommand("glTextureStorageMem3DMultisampleEXT", null, texture, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedBufferStorageMemEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		public static void NamedBufferStorageEXT(UInt32 buffer, UInt32 size, UInt32 memory, UInt64 offset)
		{
			Debug.Assert(Delegates.pglNamedBufferStorageMemEXT != null, "pglNamedBufferStorageMemEXT not implemented");
			Delegates.pglNamedBufferStorageMemEXT(buffer, size, memory, offset);
			LogCommand("glNamedBufferStorageMemEXT", null, buffer, size, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexStorageMem1DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object")]
		public static void TexStorageEXT(TextureTarget target, Int32 levels, Int32 internalFormat, Int32 width, UInt32 memory, UInt64 offset)
		{
			Debug.Assert(Delegates.pglTexStorageMem1DEXT != null, "pglTexStorageMem1DEXT not implemented");
			Delegates.pglTexStorageMem1DEXT((Int32)target, levels, internalFormat, width, memory, offset);
			LogCommand("glTexStorageMem1DEXT", null, target, levels, internalFormat, width, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorageMem1DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object")]
		public static void TextureStorageEXT(UInt32 texture, Int32 levels, Int32 internalFormat, Int32 width, UInt32 memory, UInt64 offset)
		{
			Debug.Assert(Delegates.pglTextureStorageMem1DEXT != null, "pglTextureStorageMem1DEXT not implemented");
			Delegates.pglTextureStorageMem1DEXT(texture, levels, internalFormat, width, memory, offset);
			LogCommand("glTextureStorageMem1DEXT", null, texture, levels, internalFormat, width, memory, offset			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteMemoryObjectsEXT", ExactSpelling = true)]
			internal extern static unsafe void glDeleteMemoryObjectsEXT(Int32 n, UInt32* memoryObjects);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsMemoryObjectEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glIsMemoryObjectEXT(UInt32 memoryObject);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateMemoryObjectsEXT", ExactSpelling = true)]
			internal extern static unsafe void glCreateMemoryObjectsEXT(Int32 n, UInt32* memoryObjects);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMemoryObjectParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glMemoryObjectParameterivEXT(UInt32 memoryObject, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMemoryObjectParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMemoryObjectParameterivEXT(UInt32 memoryObject, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexStorageMem2DEXT", ExactSpelling = true)]
			internal extern static void glTexStorageMem2DEXT(Int32 target, Int32 levels, Int32 internalFormat, Int32 width, Int32 height, UInt32 memory, UInt64 offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexStorageMem2DMultisampleEXT", ExactSpelling = true)]
			internal extern static void glTexStorageMem2DMultisampleEXT(Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations, UInt32 memory, UInt64 offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexStorageMem3DEXT", ExactSpelling = true)]
			internal extern static void glTexStorageMem3DEXT(Int32 target, Int32 levels, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, UInt32 memory, UInt64 offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexStorageMem3DMultisampleEXT", ExactSpelling = true)]
			internal extern static void glTexStorageMem3DMultisampleEXT(Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations, UInt32 memory, UInt64 offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBufferStorageMemEXT", ExactSpelling = true)]
			internal extern static void glBufferStorageMemEXT(Int32 target, UInt32 size, UInt32 memory, UInt64 offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorageMem2DEXT", ExactSpelling = true)]
			internal extern static void glTextureStorageMem2DEXT(UInt32 texture, Int32 levels, Int32 internalFormat, Int32 width, Int32 height, UInt32 memory, UInt64 offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorageMem2DMultisampleEXT", ExactSpelling = true)]
			internal extern static void glTextureStorageMem2DMultisampleEXT(UInt32 texture, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations, UInt32 memory, UInt64 offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorageMem3DEXT", ExactSpelling = true)]
			internal extern static void glTextureStorageMem3DEXT(UInt32 texture, Int32 levels, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, UInt32 memory, UInt64 offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorageMem3DMultisampleEXT", ExactSpelling = true)]
			internal extern static void glTextureStorageMem3DMultisampleEXT(UInt32 texture, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations, UInt32 memory, UInt64 offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedBufferStorageMemEXT", ExactSpelling = true)]
			internal extern static void glNamedBufferStorageMemEXT(UInt32 buffer, UInt32 size, UInt32 memory, UInt64 offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexStorageMem1DEXT", ExactSpelling = true)]
			internal extern static void glTexStorageMem1DEXT(Int32 target, Int32 levels, Int32 internalFormat, Int32 width, UInt32 memory, UInt64 offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorageMem1DEXT", ExactSpelling = true)]
			internal extern static void glTextureStorageMem1DEXT(UInt32 texture, Int32 levels, Int32 internalFormat, Int32 width, UInt32 memory, UInt64 offset);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteMemoryObjectsEXT(Int32 n, UInt32* memoryObjects);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glDeleteMemoryObjectsEXT pglDeleteMemoryObjectsEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsMemoryObjectEXT(UInt32 memoryObject);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glIsMemoryObjectEXT pglIsMemoryObjectEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateMemoryObjectsEXT(Int32 n, UInt32* memoryObjects);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glCreateMemoryObjectsEXT pglCreateMemoryObjectsEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMemoryObjectParameterivEXT(UInt32 memoryObject, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glMemoryObjectParameterivEXT pglMemoryObjectParameterivEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMemoryObjectParameterivEXT(UInt32 memoryObject, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glGetMemoryObjectParameterivEXT pglGetMemoryObjectParameterivEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorageMem2DEXT(Int32 target, Int32 levels, Int32 internalFormat, Int32 width, Int32 height, UInt32 memory, UInt64 offset);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glTexStorageMem2DEXT pglTexStorageMem2DEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorageMem2DMultisampleEXT(Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations, UInt32 memory, UInt64 offset);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glTexStorageMem2DMultisampleEXT pglTexStorageMem2DMultisampleEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorageMem3DEXT(Int32 target, Int32 levels, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, UInt32 memory, UInt64 offset);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glTexStorageMem3DEXT pglTexStorageMem3DEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorageMem3DMultisampleEXT(Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations, UInt32 memory, UInt64 offset);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glTexStorageMem3DMultisampleEXT pglTexStorageMem3DMultisampleEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBufferStorageMemEXT(Int32 target, UInt32 size, UInt32 memory, UInt64 offset);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glBufferStorageMemEXT pglBufferStorageMemEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorageMem2DEXT(UInt32 texture, Int32 levels, Int32 internalFormat, Int32 width, Int32 height, UInt32 memory, UInt64 offset);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glTextureStorageMem2DEXT pglTextureStorageMem2DEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorageMem2DMultisampleEXT(UInt32 texture, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations, UInt32 memory, UInt64 offset);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glTextureStorageMem2DMultisampleEXT pglTextureStorageMem2DMultisampleEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorageMem3DEXT(UInt32 texture, Int32 levels, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, UInt32 memory, UInt64 offset);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glTextureStorageMem3DEXT pglTextureStorageMem3DEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorageMem3DMultisampleEXT(UInt32 texture, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations, UInt32 memory, UInt64 offset);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glTextureStorageMem3DMultisampleEXT pglTextureStorageMem3DMultisampleEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedBufferStorageMemEXT(UInt32 buffer, UInt32 size, UInt32 memory, UInt64 offset);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glNamedBufferStorageMemEXT pglNamedBufferStorageMemEXT;

			[RequiredByFeature("GL_EXT_memory_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorageMem1DEXT(Int32 target, Int32 levels, Int32 internalFormat, Int32 width, UInt32 memory, UInt64 offset);

			[RequiredByFeature("GL_EXT_memory_object")]
			[ThreadStatic]
			internal static glTexStorageMem1DEXT pglTexStorageMem1DEXT;

			[RequiredByFeature("GL_EXT_memory_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorageMem1DEXT(UInt32 texture, Int32 levels, Int32 internalFormat, Int32 width, UInt32 memory, UInt64 offset);

			[RequiredByFeature("GL_EXT_memory_object")]
			[ThreadStatic]
			internal static glTextureStorageMem1DEXT pglTextureStorageMem1DEXT;

		}
	}

}
