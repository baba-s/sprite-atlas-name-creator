using System;
using UnityEngine;
using UnityEngine.U2D;

namespace KoganeUnityLib.UI
{
	[Serializable]
	public partial class CommonAtlas : AtlasBase
	{
		[SerializeField] private SpriteAtlas m_atlas = null;
		
		public const string _blue_panel = "blue_panel";
		public const string _red_panel = "red_panel";
		public const string _grey_panel = "grey_panel";
		public const string _green_panel = "green_panel";
		public const string _yellow_panel = "yellow_panel";
		public const string _grey_button05 = "grey_button05";
		public const string _grey_button06 = "grey_button06";
		public const string _blue_button02 = "blue_button02";
		public const string _blue_button00 = "blue_button00";
		public const string _blue_button04 = "blue_button04";
		public const string _yellow_button13 = "yellow_button13";
		public const string _grey_button01 = "grey_button01";
		public const string _grey_button03 = "grey_button03";
		public const string _green_button04 = "green_button04";
		public const string _green_button02 = "green_button02";
		public const string _green_button00 = "green_button00";
		public const string _red_button10 = "red_button10";
		public const string _red_button11 = "red_button11";
		public const string _red_button13 = "red_button13";
		public const string _red_button01 = "red_button01";
		public const string _blue_button13 = "blue_button13";
		public const string _grey_button14 = "grey_button14";
		public const string _grey_button15 = "grey_button15";
		public const string _yellow_button04 = "yellow_button04";
		public const string _yellow_button02 = "yellow_button02";
		public const string _yellow_button00 = "yellow_button00";
		public const string _green_button13 = "green_button13";
		public const string _blue_button03 = "blue_button03";
		public const string _blue_button01 = "blue_button01";
		public const string _blue_button05 = "blue_button05";
		public const string _grey_button00 = "grey_button00";
		public const string _grey_button02 = "grey_button02";
		public const string _grey_button04 = "grey_button04";
		public const string _green_button05 = "green_button05";
		public const string _green_button03 = "green_button03";
		public const string _green_button01 = "green_button01";
		public const string _red_button12 = "red_button12";
		public const string _red_button02 = "red_button02";
		public const string _red_button00 = "red_button00";
		public const string _yellow_button05 = "yellow_button05";
		public const string _yellow_button03 = "yellow_button03";
		public const string _yellow_button01 = "yellow_button01";
		public const string _dropdownBottom = "dropdownBottom";
		public const string _dropdownMid = "dropdownMid";
		public const string _dropdownTop = "dropdownTop";
		public const string _blue_button06 = "blue_button06";
		public const string _blue_button07 = "blue_button07";
		public const string _blue_button09 = "blue_button09";
		public const string _yellow_button11 = "yellow_button11";
		public const string _grey_button08 = "grey_button08";
		public const string _grey_button07 = "grey_button07";
		public const string _green_button07 = "green_button07";
		public const string _green_button06 = "green_button06";
		public const string _red_button06 = "red_button06";
		public const string _red_button04 = "red_button04";
		public const string _red_button03 = "red_button03";
		public const string _green_button09 = "green_button09";
		public const string _red_button08 = "red_button08";
		public const string _blue_button11 = "blue_button11";
		public const string _grey_button12 = "grey_button12";
		public const string _grey_button10 = "grey_button10";
		public const string _yellow_button09 = "yellow_button09";
		public const string _yellow_button06 = "yellow_button06";
		public const string _yellow_button07 = "yellow_button07";
		public const string _green_button11 = "green_button11";
		public const string _blue_button08 = "blue_button08";
		public const string _grey_button09 = "grey_button09";
		public const string _yellow_button10 = "yellow_button10";
		public const string _yellow_button12 = "yellow_button12";
		public const string _red_button07 = "red_button07";
		public const string _red_button05 = "red_button05";
		public const string _green_button08 = "green_button08";
		public const string _red_button09 = "red_button09";
		public const string _blue_button10 = "blue_button10";
		public const string _blue_button12 = "blue_button12";
		public const string _grey_button13 = "grey_button13";
		public const string _grey_button11 = "grey_button11";
		public const string _yellow_button08 = "yellow_button08";
		public const string _green_button10 = "green_button10";
		public const string _green_button12 = "green_button12";
		public const string _grey_box = "grey_box";
		public const string _yellow_boxCross = "yellow_boxCross";
		public const string _yellow_boxCheckmark = "yellow_boxCheckmark";
		public const string _green_boxCheckmark = "green_boxCheckmark";
		public const string _blue_boxCross = "blue_boxCross";
		public const string _green_boxCross = "green_boxCross";
		public const string _blue_boxCheckmark = "blue_boxCheckmark";
		public const string _grey_boxCross = "grey_boxCross";
		public const string _grey_boxCheckmark = "grey_boxCheckmark";
		public const string _red_boxCross = "red_boxCross";
		public const string _red_boxCheckmark = "red_boxCheckmark";
		public const string _grey_circle = "grey_circle";
		public const string _blue_circle = "blue_circle";
		public const string _red_boxTick = "red_boxTick";
		public const string _green_circle = "green_circle";
		public const string _blue_boxTick = "blue_boxTick";
		public const string _yellow_circle = "yellow_circle";
		public const string _grey_boxTick = "grey_boxTick";
		public const string _yellow_boxTick = "yellow_boxTick";
		public const string _green_boxTick = "green_boxTick";
		public const string _red_circle = "red_circle";
		public const string _yellow_sliderLeft = "yellow_sliderLeft";
		public const string _green_sliderLeft = "green_sliderLeft";
		public const string _grey_sliderLeft = "grey_sliderLeft";
		public const string _red_sliderLeft = "red_sliderLeft";
		public const string _red_sliderRight = "red_sliderRight";
		public const string _blue_sliderRight = "blue_sliderRight";
		public const string _yellow_sliderRight = "yellow_sliderRight";
		public const string _blue_sliderLeft = "blue_sliderLeft";
		public const string _grey_sliderRight = "grey_sliderRight";
		public const string _green_sliderRight = "green_sliderRight";
		public const string _grey_sliderUp = "grey_sliderUp";
		public const string _red_sliderDown = "red_sliderDown";
		public const string _grey_sliderDown = "grey_sliderDown";
		public const string _yellow_sliderUp = "yellow_sliderUp";
		public const string _blue_sliderDown = "blue_sliderDown";
		public const string _red_sliderUp = "red_sliderUp";
		public const string _blue_sliderUp = "blue_sliderUp";
		public const string _green_sliderUp = "green_sliderUp";
		public const string _yellow_sliderDown = "yellow_sliderDown";
		public const string _green_sliderDown = "green_sliderDown";
		public const string _grey_sliderHorizontal = "grey_sliderHorizontal";
		public const string _blue_checkmark = "blue_checkmark";
		public const string _red_checkmark = "red_checkmark";
		public const string _grey_checkmarkGrey = "grey_checkmarkGrey";
		public const string _grey_checkmarkWhite = "grey_checkmarkWhite";
		public const string _green_checkmark = "green_checkmark";
		public const string _yellow_checkmark = "yellow_checkmark";
		public const string _grey_sliderVertical = "grey_sliderVertical";
		public const string _grey_crossGrey = "grey_crossGrey";
		public const string _grey_crossWhite = "grey_crossWhite";
		public const string _red_cross = "red_cross";
		public const string _yellow_cross = "yellow_cross";
		public const string _green_cross = "green_cross";
		public const string _blue_cross = "blue_cross";
		public const string _green_tick = "green_tick";
		public const string _blue_tick = "blue_tick";
		public const string _grey_tickGrey = "grey_tickGrey";
		public const string _grey_tickWhite = "grey_tickWhite";
		public const string _red_tick = "red_tick";
		public const string _yellow_tick = "yellow_tick";
		public const string _grey_arrowDownWhite = "grey_arrowDownWhite";
		public const string _grey_arrowUpGrey = "grey_arrowUpGrey";
		public const string _grey_arrowUpWhite = "grey_arrowUpWhite";
		public const string _grey_arrowDownGrey = "grey_arrowDownGrey";
		public const string _grey_sliderEnd = "grey_sliderEnd";
		
		public Sprite blue_panel { get { return m_atlas.GetSprite( _blue_panel ); } }
		public Sprite red_panel { get { return m_atlas.GetSprite( _red_panel ); } }
		public Sprite grey_panel { get { return m_atlas.GetSprite( _grey_panel ); } }
		public Sprite green_panel { get { return m_atlas.GetSprite( _green_panel ); } }
		public Sprite yellow_panel { get { return m_atlas.GetSprite( _yellow_panel ); } }
		public Sprite grey_button05 { get { return m_atlas.GetSprite( _grey_button05 ); } }
		public Sprite grey_button06 { get { return m_atlas.GetSprite( _grey_button06 ); } }
		public Sprite blue_button02 { get { return m_atlas.GetSprite( _blue_button02 ); } }
		public Sprite blue_button00 { get { return m_atlas.GetSprite( _blue_button00 ); } }
		public Sprite blue_button04 { get { return m_atlas.GetSprite( _blue_button04 ); } }
		public Sprite yellow_button13 { get { return m_atlas.GetSprite( _yellow_button13 ); } }
		public Sprite grey_button01 { get { return m_atlas.GetSprite( _grey_button01 ); } }
		public Sprite grey_button03 { get { return m_atlas.GetSprite( _grey_button03 ); } }
		public Sprite green_button04 { get { return m_atlas.GetSprite( _green_button04 ); } }
		public Sprite green_button02 { get { return m_atlas.GetSprite( _green_button02 ); } }
		public Sprite green_button00 { get { return m_atlas.GetSprite( _green_button00 ); } }
		public Sprite red_button10 { get { return m_atlas.GetSprite( _red_button10 ); } }
		public Sprite red_button11 { get { return m_atlas.GetSprite( _red_button11 ); } }
		public Sprite red_button13 { get { return m_atlas.GetSprite( _red_button13 ); } }
		public Sprite red_button01 { get { return m_atlas.GetSprite( _red_button01 ); } }
		public Sprite blue_button13 { get { return m_atlas.GetSprite( _blue_button13 ); } }
		public Sprite grey_button14 { get { return m_atlas.GetSprite( _grey_button14 ); } }
		public Sprite grey_button15 { get { return m_atlas.GetSprite( _grey_button15 ); } }
		public Sprite yellow_button04 { get { return m_atlas.GetSprite( _yellow_button04 ); } }
		public Sprite yellow_button02 { get { return m_atlas.GetSprite( _yellow_button02 ); } }
		public Sprite yellow_button00 { get { return m_atlas.GetSprite( _yellow_button00 ); } }
		public Sprite green_button13 { get { return m_atlas.GetSprite( _green_button13 ); } }
		public Sprite blue_button03 { get { return m_atlas.GetSprite( _blue_button03 ); } }
		public Sprite blue_button01 { get { return m_atlas.GetSprite( _blue_button01 ); } }
		public Sprite blue_button05 { get { return m_atlas.GetSprite( _blue_button05 ); } }
		public Sprite grey_button00 { get { return m_atlas.GetSprite( _grey_button00 ); } }
		public Sprite grey_button02 { get { return m_atlas.GetSprite( _grey_button02 ); } }
		public Sprite grey_button04 { get { return m_atlas.GetSprite( _grey_button04 ); } }
		public Sprite green_button05 { get { return m_atlas.GetSprite( _green_button05 ); } }
		public Sprite green_button03 { get { return m_atlas.GetSprite( _green_button03 ); } }
		public Sprite green_button01 { get { return m_atlas.GetSprite( _green_button01 ); } }
		public Sprite red_button12 { get { return m_atlas.GetSprite( _red_button12 ); } }
		public Sprite red_button02 { get { return m_atlas.GetSprite( _red_button02 ); } }
		public Sprite red_button00 { get { return m_atlas.GetSprite( _red_button00 ); } }
		public Sprite yellow_button05 { get { return m_atlas.GetSprite( _yellow_button05 ); } }
		public Sprite yellow_button03 { get { return m_atlas.GetSprite( _yellow_button03 ); } }
		public Sprite yellow_button01 { get { return m_atlas.GetSprite( _yellow_button01 ); } }
		public Sprite dropdownBottom { get { return m_atlas.GetSprite( _dropdownBottom ); } }
		public Sprite dropdownMid { get { return m_atlas.GetSprite( _dropdownMid ); } }
		public Sprite dropdownTop { get { return m_atlas.GetSprite( _dropdownTop ); } }
		public Sprite blue_button06 { get { return m_atlas.GetSprite( _blue_button06 ); } }
		public Sprite blue_button07 { get { return m_atlas.GetSprite( _blue_button07 ); } }
		public Sprite blue_button09 { get { return m_atlas.GetSprite( _blue_button09 ); } }
		public Sprite yellow_button11 { get { return m_atlas.GetSprite( _yellow_button11 ); } }
		public Sprite grey_button08 { get { return m_atlas.GetSprite( _grey_button08 ); } }
		public Sprite grey_button07 { get { return m_atlas.GetSprite( _grey_button07 ); } }
		public Sprite green_button07 { get { return m_atlas.GetSprite( _green_button07 ); } }
		public Sprite green_button06 { get { return m_atlas.GetSprite( _green_button06 ); } }
		public Sprite red_button06 { get { return m_atlas.GetSprite( _red_button06 ); } }
		public Sprite red_button04 { get { return m_atlas.GetSprite( _red_button04 ); } }
		public Sprite red_button03 { get { return m_atlas.GetSprite( _red_button03 ); } }
		public Sprite green_button09 { get { return m_atlas.GetSprite( _green_button09 ); } }
		public Sprite red_button08 { get { return m_atlas.GetSprite( _red_button08 ); } }
		public Sprite blue_button11 { get { return m_atlas.GetSprite( _blue_button11 ); } }
		public Sprite grey_button12 { get { return m_atlas.GetSprite( _grey_button12 ); } }
		public Sprite grey_button10 { get { return m_atlas.GetSprite( _grey_button10 ); } }
		public Sprite yellow_button09 { get { return m_atlas.GetSprite( _yellow_button09 ); } }
		public Sprite yellow_button06 { get { return m_atlas.GetSprite( _yellow_button06 ); } }
		public Sprite yellow_button07 { get { return m_atlas.GetSprite( _yellow_button07 ); } }
		public Sprite green_button11 { get { return m_atlas.GetSprite( _green_button11 ); } }
		public Sprite blue_button08 { get { return m_atlas.GetSprite( _blue_button08 ); } }
		public Sprite grey_button09 { get { return m_atlas.GetSprite( _grey_button09 ); } }
		public Sprite yellow_button10 { get { return m_atlas.GetSprite( _yellow_button10 ); } }
		public Sprite yellow_button12 { get { return m_atlas.GetSprite( _yellow_button12 ); } }
		public Sprite red_button07 { get { return m_atlas.GetSprite( _red_button07 ); } }
		public Sprite red_button05 { get { return m_atlas.GetSprite( _red_button05 ); } }
		public Sprite green_button08 { get { return m_atlas.GetSprite( _green_button08 ); } }
		public Sprite red_button09 { get { return m_atlas.GetSprite( _red_button09 ); } }
		public Sprite blue_button10 { get { return m_atlas.GetSprite( _blue_button10 ); } }
		public Sprite blue_button12 { get { return m_atlas.GetSprite( _blue_button12 ); } }
		public Sprite grey_button13 { get { return m_atlas.GetSprite( _grey_button13 ); } }
		public Sprite grey_button11 { get { return m_atlas.GetSprite( _grey_button11 ); } }
		public Sprite yellow_button08 { get { return m_atlas.GetSprite( _yellow_button08 ); } }
		public Sprite green_button10 { get { return m_atlas.GetSprite( _green_button10 ); } }
		public Sprite green_button12 { get { return m_atlas.GetSprite( _green_button12 ); } }
		public Sprite grey_box { get { return m_atlas.GetSprite( _grey_box ); } }
		public Sprite yellow_boxCross { get { return m_atlas.GetSprite( _yellow_boxCross ); } }
		public Sprite yellow_boxCheckmark { get { return m_atlas.GetSprite( _yellow_boxCheckmark ); } }
		public Sprite green_boxCheckmark { get { return m_atlas.GetSprite( _green_boxCheckmark ); } }
		public Sprite blue_boxCross { get { return m_atlas.GetSprite( _blue_boxCross ); } }
		public Sprite green_boxCross { get { return m_atlas.GetSprite( _green_boxCross ); } }
		public Sprite blue_boxCheckmark { get { return m_atlas.GetSprite( _blue_boxCheckmark ); } }
		public Sprite grey_boxCross { get { return m_atlas.GetSprite( _grey_boxCross ); } }
		public Sprite grey_boxCheckmark { get { return m_atlas.GetSprite( _grey_boxCheckmark ); } }
		public Sprite red_boxCross { get { return m_atlas.GetSprite( _red_boxCross ); } }
		public Sprite red_boxCheckmark { get { return m_atlas.GetSprite( _red_boxCheckmark ); } }
		public Sprite grey_circle { get { return m_atlas.GetSprite( _grey_circle ); } }
		public Sprite blue_circle { get { return m_atlas.GetSprite( _blue_circle ); } }
		public Sprite red_boxTick { get { return m_atlas.GetSprite( _red_boxTick ); } }
		public Sprite green_circle { get { return m_atlas.GetSprite( _green_circle ); } }
		public Sprite blue_boxTick { get { return m_atlas.GetSprite( _blue_boxTick ); } }
		public Sprite yellow_circle { get { return m_atlas.GetSprite( _yellow_circle ); } }
		public Sprite grey_boxTick { get { return m_atlas.GetSprite( _grey_boxTick ); } }
		public Sprite yellow_boxTick { get { return m_atlas.GetSprite( _yellow_boxTick ); } }
		public Sprite green_boxTick { get { return m_atlas.GetSprite( _green_boxTick ); } }
		public Sprite red_circle { get { return m_atlas.GetSprite( _red_circle ); } }
		public Sprite yellow_sliderLeft { get { return m_atlas.GetSprite( _yellow_sliderLeft ); } }
		public Sprite green_sliderLeft { get { return m_atlas.GetSprite( _green_sliderLeft ); } }
		public Sprite grey_sliderLeft { get { return m_atlas.GetSprite( _grey_sliderLeft ); } }
		public Sprite red_sliderLeft { get { return m_atlas.GetSprite( _red_sliderLeft ); } }
		public Sprite red_sliderRight { get { return m_atlas.GetSprite( _red_sliderRight ); } }
		public Sprite blue_sliderRight { get { return m_atlas.GetSprite( _blue_sliderRight ); } }
		public Sprite yellow_sliderRight { get { return m_atlas.GetSprite( _yellow_sliderRight ); } }
		public Sprite blue_sliderLeft { get { return m_atlas.GetSprite( _blue_sliderLeft ); } }
		public Sprite grey_sliderRight { get { return m_atlas.GetSprite( _grey_sliderRight ); } }
		public Sprite green_sliderRight { get { return m_atlas.GetSprite( _green_sliderRight ); } }
		public Sprite grey_sliderUp { get { return m_atlas.GetSprite( _grey_sliderUp ); } }
		public Sprite red_sliderDown { get { return m_atlas.GetSprite( _red_sliderDown ); } }
		public Sprite grey_sliderDown { get { return m_atlas.GetSprite( _grey_sliderDown ); } }
		public Sprite yellow_sliderUp { get { return m_atlas.GetSprite( _yellow_sliderUp ); } }
		public Sprite blue_sliderDown { get { return m_atlas.GetSprite( _blue_sliderDown ); } }
		public Sprite red_sliderUp { get { return m_atlas.GetSprite( _red_sliderUp ); } }
		public Sprite blue_sliderUp { get { return m_atlas.GetSprite( _blue_sliderUp ); } }
		public Sprite green_sliderUp { get { return m_atlas.GetSprite( _green_sliderUp ); } }
		public Sprite yellow_sliderDown { get { return m_atlas.GetSprite( _yellow_sliderDown ); } }
		public Sprite green_sliderDown { get { return m_atlas.GetSprite( _green_sliderDown ); } }
		public Sprite grey_sliderHorizontal { get { return m_atlas.GetSprite( _grey_sliderHorizontal ); } }
		public Sprite blue_checkmark { get { return m_atlas.GetSprite( _blue_checkmark ); } }
		public Sprite red_checkmark { get { return m_atlas.GetSprite( _red_checkmark ); } }
		public Sprite grey_checkmarkGrey { get { return m_atlas.GetSprite( _grey_checkmarkGrey ); } }
		public Sprite grey_checkmarkWhite { get { return m_atlas.GetSprite( _grey_checkmarkWhite ); } }
		public Sprite green_checkmark { get { return m_atlas.GetSprite( _green_checkmark ); } }
		public Sprite yellow_checkmark { get { return m_atlas.GetSprite( _yellow_checkmark ); } }
		public Sprite grey_sliderVertical { get { return m_atlas.GetSprite( _grey_sliderVertical ); } }
		public Sprite grey_crossGrey { get { return m_atlas.GetSprite( _grey_crossGrey ); } }
		public Sprite grey_crossWhite { get { return m_atlas.GetSprite( _grey_crossWhite ); } }
		public Sprite red_cross { get { return m_atlas.GetSprite( _red_cross ); } }
		public Sprite yellow_cross { get { return m_atlas.GetSprite( _yellow_cross ); } }
		public Sprite green_cross { get { return m_atlas.GetSprite( _green_cross ); } }
		public Sprite blue_cross { get { return m_atlas.GetSprite( _blue_cross ); } }
		public Sprite green_tick { get { return m_atlas.GetSprite( _green_tick ); } }
		public Sprite blue_tick { get { return m_atlas.GetSprite( _blue_tick ); } }
		public Sprite grey_tickGrey { get { return m_atlas.GetSprite( _grey_tickGrey ); } }
		public Sprite grey_tickWhite { get { return m_atlas.GetSprite( _grey_tickWhite ); } }
		public Sprite red_tick { get { return m_atlas.GetSprite( _red_tick ); } }
		public Sprite yellow_tick { get { return m_atlas.GetSprite( _yellow_tick ); } }
		public Sprite grey_arrowDownWhite { get { return m_atlas.GetSprite( _grey_arrowDownWhite ); } }
		public Sprite grey_arrowUpGrey { get { return m_atlas.GetSprite( _grey_arrowUpGrey ); } }
		public Sprite grey_arrowUpWhite { get { return m_atlas.GetSprite( _grey_arrowUpWhite ); } }
		public Sprite grey_arrowDownGrey { get { return m_atlas.GetSprite( _grey_arrowDownGrey ); } }
		public Sprite grey_sliderEnd { get { return m_atlas.GetSprite( _grey_sliderEnd ); } }
		
		public CommonAtlas() {}
		
		public CommonAtlas( SpriteAtlas atlas ) { m_atlas = atlas; }
		
	}
	
	[Serializable]
	public partial class SpaceAtlas : AtlasBase
	{
		[SerializeField] private SpriteAtlas m_atlas = null;
		
		public const string _glassPanel_tab = "glassPanel_tab";
		public const string _glassPanel_cornerBL = "glassPanel_cornerBL";
		public const string _metalPanel = "metalPanel";
		public const string _glassPanel_cornerBR = "glassPanel_cornerBR";
		public const string _metalPanel_yellow = "metalPanel_yellow";
		public const string _metalPanel_blueCorner = "metalPanel_blueCorner";
		public const string _metalPanel_green = "metalPanel_green";
		public const string _glassPanel = "glassPanel";
		public const string _glassPanel_projection = "glassPanel_projection";
		public const string _metalPanel_blue = "metalPanel_blue";
		public const string _metalPanel_redCorner = "metalPanel_redCorner";
		public const string _glassPanel_corners = "glassPanel_corners";
		public const string _metalPanel_yellowCorner = "metalPanel_yellowCorner";
		public const string _metalPanel_red = "metalPanel_red";
		public const string _glassPanel_cornerTR = "glassPanel_cornerTR";
		public const string _metalPanel_greenCorner = "metalPanel_greenCorner";
		public const string _glassPanel_cornerTL = "glassPanel_cornerTL";
		public const string _metalPanel_plate = "metalPanel_plate";
		public const string _crossair_whiteOutline = "crossair_whiteOutline";
		public const string _crossair_blackOutline = "crossair_blackOutline";
		public const string _crossair_redOutline = "crossair_redOutline";
		public const string _crossair_blueOutline = "crossair_blueOutline";
		public const string _crossair_white = "crossair_white";
		public const string _crossair_blue = "crossair_blue";
		public const string _crossair_black = "crossair_black";
		public const string _crossair_red = "crossair_red";
		public const string _cursor_hand = "cursor_hand";
		public const string _dotWhite = "dotWhite";
		public const string _dotRed = "dotRed";
		public const string _dotBlue = "dotBlue";
		public const string _dotYellow = "dotYellow";
		public const string _dot_shadow = "dot_shadow";
		public const string _dotGreen = "dotGreen";
		public const string _cursor_pointerFlat_shadow = "cursor_pointerFlat_shadow";
		public const string _cursor_pointer3D_shadow = "cursor_pointer3D_shadow";
		public const string _squareRed = "squareRed";
		public const string _squareBlue = "squareBlue";
		public const string _square_shadow = "square_shadow";
		public const string _squareWhite = "squareWhite";
		public const string _squareGreen = "squareGreen";
		public const string _squareYellow = "squareYellow";
		public const string _cursor_pointer3D = "cursor_pointer3D";
		public const string _cursor_pointerFlat = "cursor_pointerFlat";
		public const string _barHorizontal_green_mid = "barHorizontal_green_mid";
		public const string _barHorizontal_yellow_mid = "barHorizontal_yellow_mid";
		public const string _barHorizontal_blue_mid = "barHorizontal_blue_mid";
		public const string _barVertical_blue_mid = "barVertical_blue_mid";
		public const string _barHorizontal_white_mid = "barHorizontal_white_mid";
		public const string _barVertical_red_mid = "barVertical_red_mid";
		public const string _barVertical_white_mid = "barVertical_white_mid";
		public const string _barVertical_shadow_mid = "barVertical_shadow_mid";
		public const string _barHorizontal_shadow_mid = "barHorizontal_shadow_mid";
		public const string _barVertical_yellow_mid = "barVertical_yellow_mid";
		public const string _barHorizontal_red_mid = "barHorizontal_red_mid";
		public const string _barVertical_green_mid = "barVertical_green_mid";
		public const string _barHorizontal_blue_left = "barHorizontal_blue_left";
		public const string _barVertical_blue_top = "barVertical_blue_top";
		public const string _barHorizontal_white_left = "barHorizontal_white_left";
		public const string _barVertical_white_bottom = "barVertical_white_bottom";
		public const string _barHorizontal_shadow_left = "barHorizontal_shadow_left";
		public const string _barHorizontal_shadow_right = "barHorizontal_shadow_right";
		public const string _barHorizontal_green_right = "barHorizontal_green_right";
		public const string _barHorizontal_blue_right = "barHorizontal_blue_right";
		public const string _barHorizontal_green_left = "barHorizontal_green_left";
		public const string _barVertical_green_top = "barVertical_green_top";
		public const string _barHorizontal_yellow_left = "barHorizontal_yellow_left";
		public const string _barHorizontal_yellow_right = "barHorizontal_yellow_right";
		public const string _barVertical_yellow_bottom = "barVertical_yellow_bottom";
		public const string _barVertical_shadow_top = "barVertical_shadow_top";
		public const string _barHorizontal_red_left = "barHorizontal_red_left";
		public const string _barVertical_yellow_top = "barVertical_yellow_top";
		public const string _barHorizontal_white_right = "barHorizontal_white_right";
		public const string _barVertical_red_top = "barVertical_red_top";
		public const string _barVertical_blue_bottom = "barVertical_blue_bottom";
		public const string _barVertical_green_bottom = "barVertical_green_bottom";
		public const string _barHorizontal_red_right = "barHorizontal_red_right";
		public const string _barVertical_shadow_bottom = "barVertical_shadow_bottom";
		public const string _barVertical_red_bottom = "barVertical_red_bottom";
		public const string _barVertical_white_top = "barVertical_white_top";
		
		public Sprite glassPanel_tab { get { return m_atlas.GetSprite( _glassPanel_tab ); } }
		public Sprite glassPanel_cornerBL { get { return m_atlas.GetSprite( _glassPanel_cornerBL ); } }
		public Sprite metalPanel { get { return m_atlas.GetSprite( _metalPanel ); } }
		public Sprite glassPanel_cornerBR { get { return m_atlas.GetSprite( _glassPanel_cornerBR ); } }
		public Sprite metalPanel_yellow { get { return m_atlas.GetSprite( _metalPanel_yellow ); } }
		public Sprite metalPanel_blueCorner { get { return m_atlas.GetSprite( _metalPanel_blueCorner ); } }
		public Sprite metalPanel_green { get { return m_atlas.GetSprite( _metalPanel_green ); } }
		public Sprite glassPanel { get { return m_atlas.GetSprite( _glassPanel ); } }
		public Sprite glassPanel_projection { get { return m_atlas.GetSprite( _glassPanel_projection ); } }
		public Sprite metalPanel_blue { get { return m_atlas.GetSprite( _metalPanel_blue ); } }
		public Sprite metalPanel_redCorner { get { return m_atlas.GetSprite( _metalPanel_redCorner ); } }
		public Sprite glassPanel_corners { get { return m_atlas.GetSprite( _glassPanel_corners ); } }
		public Sprite metalPanel_yellowCorner { get { return m_atlas.GetSprite( _metalPanel_yellowCorner ); } }
		public Sprite metalPanel_red { get { return m_atlas.GetSprite( _metalPanel_red ); } }
		public Sprite glassPanel_cornerTR { get { return m_atlas.GetSprite( _glassPanel_cornerTR ); } }
		public Sprite metalPanel_greenCorner { get { return m_atlas.GetSprite( _metalPanel_greenCorner ); } }
		public Sprite glassPanel_cornerTL { get { return m_atlas.GetSprite( _glassPanel_cornerTL ); } }
		public Sprite metalPanel_plate { get { return m_atlas.GetSprite( _metalPanel_plate ); } }
		public Sprite crossair_whiteOutline { get { return m_atlas.GetSprite( _crossair_whiteOutline ); } }
		public Sprite crossair_blackOutline { get { return m_atlas.GetSprite( _crossair_blackOutline ); } }
		public Sprite crossair_redOutline { get { return m_atlas.GetSprite( _crossair_redOutline ); } }
		public Sprite crossair_blueOutline { get { return m_atlas.GetSprite( _crossair_blueOutline ); } }
		public Sprite crossair_white { get { return m_atlas.GetSprite( _crossair_white ); } }
		public Sprite crossair_blue { get { return m_atlas.GetSprite( _crossair_blue ); } }
		public Sprite crossair_black { get { return m_atlas.GetSprite( _crossair_black ); } }
		public Sprite crossair_red { get { return m_atlas.GetSprite( _crossair_red ); } }
		public Sprite cursor_hand { get { return m_atlas.GetSprite( _cursor_hand ); } }
		public Sprite dotWhite { get { return m_atlas.GetSprite( _dotWhite ); } }
		public Sprite dotRed { get { return m_atlas.GetSprite( _dotRed ); } }
		public Sprite dotBlue { get { return m_atlas.GetSprite( _dotBlue ); } }
		public Sprite dotYellow { get { return m_atlas.GetSprite( _dotYellow ); } }
		public Sprite dot_shadow { get { return m_atlas.GetSprite( _dot_shadow ); } }
		public Sprite dotGreen { get { return m_atlas.GetSprite( _dotGreen ); } }
		public Sprite cursor_pointerFlat_shadow { get { return m_atlas.GetSprite( _cursor_pointerFlat_shadow ); } }
		public Sprite cursor_pointer3D_shadow { get { return m_atlas.GetSprite( _cursor_pointer3D_shadow ); } }
		public Sprite squareRed { get { return m_atlas.GetSprite( _squareRed ); } }
		public Sprite squareBlue { get { return m_atlas.GetSprite( _squareBlue ); } }
		public Sprite square_shadow { get { return m_atlas.GetSprite( _square_shadow ); } }
		public Sprite squareWhite { get { return m_atlas.GetSprite( _squareWhite ); } }
		public Sprite squareGreen { get { return m_atlas.GetSprite( _squareGreen ); } }
		public Sprite squareYellow { get { return m_atlas.GetSprite( _squareYellow ); } }
		public Sprite cursor_pointer3D { get { return m_atlas.GetSprite( _cursor_pointer3D ); } }
		public Sprite cursor_pointerFlat { get { return m_atlas.GetSprite( _cursor_pointerFlat ); } }
		public Sprite barHorizontal_green_mid { get { return m_atlas.GetSprite( _barHorizontal_green_mid ); } }
		public Sprite barHorizontal_yellow_mid { get { return m_atlas.GetSprite( _barHorizontal_yellow_mid ); } }
		public Sprite barHorizontal_blue_mid { get { return m_atlas.GetSprite( _barHorizontal_blue_mid ); } }
		public Sprite barVertical_blue_mid { get { return m_atlas.GetSprite( _barVertical_blue_mid ); } }
		public Sprite barHorizontal_white_mid { get { return m_atlas.GetSprite( _barHorizontal_white_mid ); } }
		public Sprite barVertical_red_mid { get { return m_atlas.GetSprite( _barVertical_red_mid ); } }
		public Sprite barVertical_white_mid { get { return m_atlas.GetSprite( _barVertical_white_mid ); } }
		public Sprite barVertical_shadow_mid { get { return m_atlas.GetSprite( _barVertical_shadow_mid ); } }
		public Sprite barHorizontal_shadow_mid { get { return m_atlas.GetSprite( _barHorizontal_shadow_mid ); } }
		public Sprite barVertical_yellow_mid { get { return m_atlas.GetSprite( _barVertical_yellow_mid ); } }
		public Sprite barHorizontal_red_mid { get { return m_atlas.GetSprite( _barHorizontal_red_mid ); } }
		public Sprite barVertical_green_mid { get { return m_atlas.GetSprite( _barVertical_green_mid ); } }
		public Sprite barHorizontal_blue_left { get { return m_atlas.GetSprite( _barHorizontal_blue_left ); } }
		public Sprite barVertical_blue_top { get { return m_atlas.GetSprite( _barVertical_blue_top ); } }
		public Sprite barHorizontal_white_left { get { return m_atlas.GetSprite( _barHorizontal_white_left ); } }
		public Sprite barVertical_white_bottom { get { return m_atlas.GetSprite( _barVertical_white_bottom ); } }
		public Sprite barHorizontal_shadow_left { get { return m_atlas.GetSprite( _barHorizontal_shadow_left ); } }
		public Sprite barHorizontal_shadow_right { get { return m_atlas.GetSprite( _barHorizontal_shadow_right ); } }
		public Sprite barHorizontal_green_right { get { return m_atlas.GetSprite( _barHorizontal_green_right ); } }
		public Sprite barHorizontal_blue_right { get { return m_atlas.GetSprite( _barHorizontal_blue_right ); } }
		public Sprite barHorizontal_green_left { get { return m_atlas.GetSprite( _barHorizontal_green_left ); } }
		public Sprite barVertical_green_top { get { return m_atlas.GetSprite( _barVertical_green_top ); } }
		public Sprite barHorizontal_yellow_left { get { return m_atlas.GetSprite( _barHorizontal_yellow_left ); } }
		public Sprite barHorizontal_yellow_right { get { return m_atlas.GetSprite( _barHorizontal_yellow_right ); } }
		public Sprite barVertical_yellow_bottom { get { return m_atlas.GetSprite( _barVertical_yellow_bottom ); } }
		public Sprite barVertical_shadow_top { get { return m_atlas.GetSprite( _barVertical_shadow_top ); } }
		public Sprite barHorizontal_red_left { get { return m_atlas.GetSprite( _barHorizontal_red_left ); } }
		public Sprite barVertical_yellow_top { get { return m_atlas.GetSprite( _barVertical_yellow_top ); } }
		public Sprite barHorizontal_white_right { get { return m_atlas.GetSprite( _barHorizontal_white_right ); } }
		public Sprite barVertical_red_top { get { return m_atlas.GetSprite( _barVertical_red_top ); } }
		public Sprite barVertical_blue_bottom { get { return m_atlas.GetSprite( _barVertical_blue_bottom ); } }
		public Sprite barVertical_green_bottom { get { return m_atlas.GetSprite( _barVertical_green_bottom ); } }
		public Sprite barHorizontal_red_right { get { return m_atlas.GetSprite( _barHorizontal_red_right ); } }
		public Sprite barVertical_shadow_bottom { get { return m_atlas.GetSprite( _barVertical_shadow_bottom ); } }
		public Sprite barVertical_red_bottom { get { return m_atlas.GetSprite( _barVertical_red_bottom ); } }
		public Sprite barVertical_white_top { get { return m_atlas.GetSprite( _barVertical_white_top ); } }
		
		public SpaceAtlas() {}
		
		public SpaceAtlas( SpriteAtlas atlas ) { m_atlas = atlas; }
		
	}
	
}
