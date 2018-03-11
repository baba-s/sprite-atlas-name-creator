using KoganeUnityLib.UI;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace Example_SpriteAtlasNameCreator
{
	public class Example : MonoBehaviour
	{
		public SpriteAtlas m_spriteAtlas;
		public CommonAtlas m_commonAtlas;
		public Image m_image;

		private void Awake()
		{
			// 基本的な使い方
			m_image.sprite = m_commonAtlas.blue_button00;

			// スプライト名を管理するクラスは動的に生成可能
			var spaceAtlas = new SpaceAtlas( m_spriteAtlas );
			m_image.sprite = spaceAtlas.dotBlue;

			// スプライト名を定数で参照することも可能
			var name = SpaceAtlas._dotBlue;
			m_image.sprite  = m_spriteAtlas.GetSprite( name );
		}
	}
}