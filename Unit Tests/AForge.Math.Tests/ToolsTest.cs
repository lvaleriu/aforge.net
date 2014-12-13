<<<<<<< HEAD
﻿using System;
using AForge;
using AForge.Math;
using MbUnit.Framework;

namespace AForge.Math.Tests
{
    [TestFixture]
    public class ToolsTest
    {
        [Test]
        [Row( 0, false )]
        [Row( 1, true )]
        [Row( 2, true )]
        [Row( 3, false )]
        [Row( 4, true )]
        [Row( 8, true )]
        [Row( 0x80, true )]
        [Row( 0x81, false )]
        [Row( 0x8000, true )]
        [Row( 0x8001, false )]
        [Row( 0x40000000, true )]
        [Row( 0x3FFFFFFF, false )]
        [Row( -1, false )]
        [Row( -8, false )]
        [Row( int.MinValue, false )]
        public void IsPowerOf2Test( int valueToTest, bool expectedResult )
        {
            Assert.AreEqual<bool>( expectedResult, Tools.IsPowerOf2( valueToTest ) );
        }
    }
}
=======
﻿using System;
using AForge;
using AForge.Math;
using NUnit.Framework;

namespace AForge.Math.Tests
{
    [TestFixture]
    public class ToolsTest
    {
        
        [TestCase( 0, false )]
        [TestCase( 1, true )]
        [TestCase( 2, true )]
        [TestCase( 3, false )]
        [TestCase( 4, true )]
        [TestCase( 8, true )]
        [TestCase( 0x80, true )]
        [TestCase( 0x81, false )]
        [TestCase( 0x8000, true )]
        [TestCase( 0x8001, false )]
        [TestCase( 0x40000000, true )]
        [TestCase( 0x3FFFFFFF, false )]
        [TestCase( -1, false )]
        [TestCase( -8, false )]
        [TestCase( int.MinValue, false )]
        public void IsPowerOf2Test( int valueToTest, bool expectedResult )
        {
            Assert.AreEqual( expectedResult, Tools.IsPowerOf2( valueToTest ) );
        }
    }
}
>>>>>>> 17cbabfd02121ea58e8559f7fcfffdf33cf9e7fd
