<<<<<<< HEAD
using System;
using System.Windows.Forms;

namespace Color
{
	/// <summary>
	/// Dummy class to enable  doble buffering in Panel
	/// </summary>
	public class BufferedPanel : System.Windows.Forms.Panel
	{
		// Construcor
		public BufferedPanel( )
		{
			// Update control style
			SetStyle( ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw |
				ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true );
		}
	}
}
=======
using System;
using System.Windows.Forms;

namespace Color
{
	/// <summary>
	/// Dummy class to enable  doble buffering in Panel
	/// </summary>
	public class BufferedPanel : System.Windows.Forms.Panel
	{
		// Construcor
		public BufferedPanel( )
		{
			// Update control style
			SetStyle( ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw |
				ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true );
		}
	}
}
>>>>>>> 17cbabfd02121ea58e8559f7fcfffdf33cf9e7fd
