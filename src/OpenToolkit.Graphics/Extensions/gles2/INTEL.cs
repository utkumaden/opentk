using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES2.Extensions
{
    public static partial class INTEL
    {
        public unsafe static partial class ConservativeRasterization
        {
        }
        public unsafe static partial class FramebufferCmaa
        {
            [DllImport("opengl32.dll", EntryPoint = "glApplyFramebufferAttachmentCMAAINTEL")]
            public static extern void GlApplyFramebufferAttachmentCMAA();
            
        }
        public unsafe static partial class BlackholeRender
        {
        }
        public unsafe static partial class PerformanceQuery
        {
            [DllImport("opengl32.dll", EntryPoint = "glBeginPerfQueryINTEL")]
            public static extern void GlBeginPerfQuery(uint queryHandle);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreatePerfQueryINTEL")]
            public static extern void GlCreatePerfQuery(uint queryId, uint* queryHandle);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeletePerfQueryINTEL")]
            public static extern void GlDeletePerfQuery(uint queryHandle);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndPerfQueryINTEL")]
            public static extern void GlEndPerfQuery(uint queryHandle);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFirstPerfQueryIdINTEL")]
            public static extern void GlGetFirstPerfQueryId(uint* queryId);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNextPerfQueryIdINTEL")]
            public static extern void GlGetNextPerfQueryId(uint queryId, uint* nextQueryId);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfCounterInfoINTEL")]
            public static extern void GlGetPerfCounterInfo(uint queryId, uint counterId, uint counterNameLength, char* counterName, uint counterDescLength, char* counterDesc, uint* counterOffset, uint* counterDataSize, uint* counterTypeEnum, uint* counterDataTypeEnum, uint* rawCounterMaxValue);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static extern void GlGetPerfQueryData(uint queryHandle, uint flags, int dataSize, void* data, uint* bytesWritten);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfQueryIdByNameINTEL")]
            public static extern void GlGetPerfQueryIdByName(char* queryName, uint* queryId);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfQueryInfoINTEL")]
            public static extern void GlGetPerfQueryInfo(uint queryId, uint queryNameLength, char* queryName, uint* dataSize, uint* noCounters, uint* noInstances, uint* capsMask);
            
        }
    }
}
