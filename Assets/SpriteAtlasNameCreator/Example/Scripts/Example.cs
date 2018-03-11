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
		public Image m_image1;
		public Image m_image2;
		public Image m_image3;
		public Image m_image4;

		private void Awake()
		{
			// 基本的な使い方
			m_image1.sprite = m_commonAtlas.button_blue;

			// 書式指定も可能
			var isOn = true;
			m_image2.sprite = m_commonAtlas.get_check( isOn ? "on" : "off" );

			// スプライト名を管理するクラスは動的に生成可能
			var spaceAtlas = new SpaceAtlas( m_spriteAtlas );
			m_image3.sprite = spaceAtlas.dot_green;

			// スプライト名を定数で参照することも可能
			var name = SpaceAtlas._dot_yellow;
			m_image4.sprite = m_spriteAtlas.GetSprite( name );
		}
	}
}