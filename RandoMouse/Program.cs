using System;
using System.Windows.Forms;

namespace CodeKandis.RandoMouse
{
	/// <summary>
	/// Represents the bootstrap class of the application.
	/// </summary>
	static class Program
	{
		/// <summary>
		/// Represents the bootstrap method of the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run();
		}
	}
}
