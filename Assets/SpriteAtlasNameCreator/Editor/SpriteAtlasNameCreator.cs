using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.U2D;

namespace KoganeUnityLib
{
	public static class SpriteAtlasNameCreator
	{
		private static readonly string[] INVALID_CHARS =
		{
			" ", "!", "\"", "#", "$",
			"%", "&", "\'", "(", ")",
			"-", "=", "^",  "~", "\\",
			"|", "[", "{",  "@", "`",
			"]", "}", ":",  "*", ";",
			"+", "/", "?",  ".", ">",
			",", "<"
		};

		public static string Create( IEnumerable<SpriteAtlas> spriteAtlasList )
		{
			var builder = new StringBuilder();

			builder.AppendLine( "using System;" );
			builder.AppendLine( "using UnityEngine;" );
			builder.AppendLine( "using UnityEngine.U2D;" );
			builder.AppendLine();
			builder.AppendLine( "namespace KoganeUnityLib.UI" );
			builder.AppendLine( "{" );

			foreach ( var spriteAtlas in spriteAtlasList )
			{
				var atlasName = spriteAtlas.name;
				var atlasNameSafe = RemoveInvalidChars( atlasName );

				builder.Append( "\t" ).AppendLine( "[Serializable]" );
				builder.Append( "\t" ).AppendFormat( "public partial class {0} : AtlasBase", atlasNameSafe ).AppendLine();
				builder.Append( "\t" ).AppendLine( "{" );

				builder.Append( "\t\t" ).AppendLine( "[SerializeField] private SpriteAtlas m_atlas = null;" );
				builder.Append( "\t\t" ).AppendLine();

				var sprites = new Sprite[ spriteAtlas.spriteCount ];
				spriteAtlas.GetSprites( sprites );

				foreach ( var sprite in sprites )
				{
					var spriteName = sprite.name.Replace( "(Clone)", string.Empty );
					var spriteNameSafe = RemoveInvalidChars( spriteName );

					builder.Append( "\t\t" ).AppendFormat( @"public const string _{0} = ""{1}"";", spriteNameSafe, spriteName ).AppendLine();
				}

				builder.Append( "\t\t" ).AppendLine();

				foreach ( var sprite in sprites )
				{
					var spriteName = sprite.name.Replace( "(Clone)", string.Empty );
					var spriteNameSafe = RemoveInvalidChars( spriteName );

					builder.Append( "\t\t" ).AppendFormat( @"public Sprite {0} {{ get {{ return m_atlas.GetSprite( _{0} ); }} }}", spriteNameSafe ).AppendLine();
				}

				builder.Append( "\t\t" ).AppendLine();
				builder.Append( "\t\t" ).AppendFormat( @"public {0}() {{}}", atlasNameSafe ).AppendLine();
				builder.Append( "\t\t" ).AppendLine();
				builder.Append( "\t\t" ).AppendFormat( @"public {0}( SpriteAtlas atlas ) {{ m_atlas = atlas; }}", atlasNameSafe ).AppendLine();
				builder.Append( "\t\t" ).AppendLine();

				builder.Append( "\t" ).AppendLine( "}" );
				builder.Append( "\t" ).AppendLine();
			}

			builder.AppendLine( "}" );

			return builder.ToString();
		}

		public static string RemoveInvalidChars( string str )
		{
			Array.ForEach( INVALID_CHARS, c => str = str.Replace( c, string.Empty ) );
			return str;
		}
	}
}