using System;
using UnityEngine;
using UnityEngine.U2D;

namespace KoganeUnityLib.UI
{
	[Serializable]
	public partial class CommonAtlas : AtlasBase
	{
		[SerializeField] private SpriteAtlas m_atlas = null;
		
		public const string _button_blue = "button_blue";
		public const string _button_yellow = "button_yellow";
		public const string _button_green = "button_green";
		public const string _check_off = "check_off";
		public const string _check_on = "check_on";
		
		public Sprite button_blue { get { return m_atlas.GetSprite( _button_blue ); } }
		public Sprite button_yellow { get { return m_atlas.GetSprite( _button_yellow ); } }
		public Sprite button_green { get { return m_atlas.GetSprite( _button_green ); } }
		public Sprite check_off { get { return m_atlas.GetSprite( _check_off ); } }
		public Sprite check_on { get { return m_atlas.GetSprite( _check_on ); } }
		
		public CommonAtlas() {}
		
		public CommonAtlas( SpriteAtlas atlas ) { m_atlas = atlas; }
		
	}
	
	[Serializable]
	public partial class SpaceAtlas : AtlasBase
	{
		[SerializeField] private SpriteAtlas m_atlas = null;
		
		public const string _dot_blue = "dot_blue";
		public const string _dot_green = "dot_green";
		public const string _dot_yellow = "dot_yellow";
		
		public Sprite dot_blue { get { return m_atlas.GetSprite( _dot_blue ); } }
		public Sprite dot_green { get { return m_atlas.GetSprite( _dot_green ); } }
		public Sprite dot_yellow { get { return m_atlas.GetSprite( _dot_yellow ); } }
		
		public SpaceAtlas() {}
		
		public SpaceAtlas( SpriteAtlas atlas ) { m_atlas = atlas; }
		
	}
	
}
