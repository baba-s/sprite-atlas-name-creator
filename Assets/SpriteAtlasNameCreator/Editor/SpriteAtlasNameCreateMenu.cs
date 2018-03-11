using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.U2D;

namespace KoganeUnityLib
{
	public static class SpriteAtlasNameCreateMenu
	{
		private const string ITEM_NAME	= "Kogane/Create/Sprite Atlas Name";
		private const string PATH		= "Assets/SpriteAtlasNameCreator/gen/SpriteAtlasName.cs";

		private static readonly string DIRECTORY_NAME = Path.GetDirectoryName( PATH );

		[MenuItem( ITEM_NAME )]
		private static void Create()
		{
			var spriteAtlasList = AssetDatabase
				.GetAllAssetPaths()
				.Where( c => c.EndsWith( ".spriteatlas" ) )
				.Select( c => AssetDatabase.LoadAssetAtPath<SpriteAtlas>( c ) )
				.ToArray()
			;

			var script = SpriteAtlasNameCreator.Create( spriteAtlasList );

			if ( !Directory.Exists( DIRECTORY_NAME ) )
			{
				Directory.CreateDirectory( DIRECTORY_NAME );
			}

			File.WriteAllText( PATH, script, Encoding.UTF8 );
			AssetDatabase.Refresh( ImportAssetOptions.ImportRecursive );

			EditorUtility.DisplayDialog( "SpriteAtlasName", "作成が完了しました", "OK" );

			var result = AssetDatabase.LoadAssetAtPath<MonoScript>( PATH );
			EditorGUIUtility.PingObject( result );
		}

		[MenuItem( ITEM_NAME, true )]
		private static bool CanCreate()
		{
			return
				!EditorApplication.isPlaying &&
				!Application.isPlaying &&
				!EditorApplication.isCompiling
			;
		}
	}
}