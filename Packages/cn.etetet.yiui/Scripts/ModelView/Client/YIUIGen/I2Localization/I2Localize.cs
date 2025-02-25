using UnityEngine;
using I2.Loc;

namespace ET.Client
{
	public static class I2Localize
	{

		[StaticField]
		public static string Test 		{ get{ return LocalizationManager.GetTranslation ("Test"); } }
		[StaticField]
		public static string TestFormat 		{ get{ return LocalizationManager.GetTranslation ("TestFormat"); } }
	}

    public static class I2Terms
	{

		public const string Test = "Test";
		public const string TestFormat = "TestFormat";
	}
}