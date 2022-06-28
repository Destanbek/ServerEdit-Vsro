using System;
using System.Windows.Forms;

namespace ServerEditVsro
{
	internal static class Program
	{
		public static string SQL_Acc;

		public static string SQL_Log;

		public static string SQL_Shard;

		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
			Application.Run(new Form2());
			Environment.Exit(0);
		}
	}
}
