using UnityEditor;
using UnityEngine;

namespace KoganeUnityLib.UI
{
	[CustomPropertyDrawer( typeof( AtlasBase ), true )]
	public class AtlasBaseDrawer : PropertyDrawer
	{
		public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
		{
			var atlasProperty = property.FindPropertyRelative( "m_atlas" );
			EditorGUI.PropertyField( position, atlasProperty, new GUIContent( property.displayName ) );
		}
	}
}