<<<<<<< HEAD
﻿// AForge XIMEA Video Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2005-2011
// contacts@aforgenet.com
//

using System;
using System.Runtime.InteropServices;

namespace AForge.Video.Ximea.Internal
{
    [StructLayout( LayoutKind.Sequential )]
    internal struct XimeaImage
    {
        public int StructSize;
        public IntPtr BitmapData;
        public int Size;
        public ImageFormat PixelFormat;
        public int Width;
        public int Height;
        public int FrameNumber;
    }
}
=======
﻿// AForge XIMEA Video Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2005-2011
// contacts@aforgenet.com
//

using System;
using System.Runtime.InteropServices;

namespace AForge.Video.Ximea.Internal
{
    [StructLayout( LayoutKind.Sequential )]
    internal struct XimeaImage
    {
        public int StructSize;
        public IntPtr BitmapData;
        public int Size;
        public ImageFormat PixelFormat;
        public int Width;
        public int Height;
        public int FrameNumber;
    }
}
>>>>>>> 17cbabfd02121ea58e8559f7fcfffdf33cf9e7fd
