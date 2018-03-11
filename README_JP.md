# SpriteAtlasNameCreator

「SpriteAtlasNameCreator」は、SpriteAtlas に含まれるスプライトを、  
文字列指定ではなくプロパティ経由で取得できるクラスを自動生成するエディタ拡張です  

# できること

## 文字列指定ではなくプロパティ経由でスプライトを取得

```cs
public class Example : MonoBehaviour
{
    public SpriteAtlas m_atlas;
    public Image m_image;

    private void Awake()
    {
        m_image.sprite = m_atlas.GetSprite( "button_blue" );
    }
}
```

例えば、SpriteAtlas に含まれるスプライトを Image.sprite に設定したい場合、  
SpriteAtlas.GetSprite( "hoge" ) を使用しますが、  
この方法は、スプライト名を文字列で指定するため、  
スプライト名の入力をミスしてしまう問題があります  

```cs
public class Example : MonoBehaviour
{
    public CommonAtlas m_atlas;
    public Image m_image;

    private void Awake()
    {
        m_image.sprite = m_atlas.button_blue;
    }
}
```

「SpriteAtlasNameCreator」を使用して専用のクラス  
（この例では「CommonAtlas」クラス）を自動生成することで  
上記のように文字列指定ではなくプロパティ経由でスプライトを取得できるようになり  
スプライト名の入力ミスを防ぐことができます  

## 書式指定でスプライトを取得

```cs
public class Example : MonoBehaviour
{
    public SpriteAtlas m_atlas;
    public Image m_image;

    public void SetImage( PARAM_TYPE paramType )
    {
        var name = "icon_" + paramType.ToString();
        m_image.sprite = m_atlas.GetSprite( name );
    }
}
```

例えば、PARAM_TYPE という列挙型の値によって、  
使用するスプライトを変更したい場合、上記のように記述することがありますが、  

```cs
public class Example : MonoBehaviour
{
    public CommonAtlas m_atlas;
    public Image m_image;

    public void SetImage( PARAM_TYPE paramType )
    {
        m_image.sprite = m_atlas.get_icon( paramType.ToString() );
    }
}
```

このように、書式指定できる関数を使用してスプライトを取得することも可能です  

## partial クラスを定義して独自の機能を拡張

```cs
[Serializable]
public partial class CommonAtlas : AtlasBase
{
    ...
}
```

「SpriteAtlasNameCreator」を使用して生成されるクラスは partial クラスなので  

```cs
public partial class CommonAtlas : AtlasBase
{
    public Sprite GetParamIcon( PARAM_TYPE paramType )
    {
        return m_atlas.get_icon( paramType.ToString() );
    }
}
```

よく使う関数を別のファイルで定義することで  

```cs
public class Example : MonoBehaviour
{
    public CommonAtlas m_atlas;
    public Image m_image;

    public void SetImage( PARAM_TYPE paramType )
    {
        m_image.sprite = m_atlas.GetParamIcon( paramType );
    }
}
```

より直感的に SpriteAtlas からスプライトを取得できるようになります  

# 開発環境

- Unity 2017.3.0f3

# 導入方法

1. 下記のページにアクセスして「SpriteAtlasNameCreator.unitypackage」をダウンロードします  
https://github.com/baba-s/sprite-atlas-name-creator/blob/master/SpriteAtlasNameCreator.unitypackage?raw=true
2. ダウンロードした「SpriteAtlasNameCreator.unitypackage」をUnity プロジェクトにインポートします  

# 使い方

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20180311/20180311164028.png)

例えば、上記のように「CommonAtlas」「SpaceAtlas」という  
2つの SpriteAtlas が Unity プロジェクトに存在する場合に、  

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20180311/20180311164104.png)

Unity メニューの「Kogane>Create>Sprite Atlas Name」を選択すると  

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20180311/20180311164128.png)

「SpriteAtlasName」というファイルが作成され、  

```cs
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
        
        /// <summary>"button_{0}"</summary>
        public Sprite get_button( object arg0 ) { return m_atlas.GetSprite( string.Format( "button_{0}", arg0 ) ); }
        /// <summary>"{0}_{1}"</summary>
        public Sprite get_( object arg0, object arg1 ) { return m_atlas.GetSprite( string.Format( "{0}_{1}", arg0, arg1 ) ); }
        /// <summary>"check_{0}"</summary>
        public Sprite get_check( object arg0 ) { return m_atlas.GetSprite( string.Format( "check_{0}", arg0 ) ); }
        
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
        
        /// <summary>"dot_{0}"</summary>
        public Sprite get_dot( object arg0 ) { return m_atlas.GetSprite( string.Format( "dot_{0}", arg0 ) ); }
        
        public SpaceAtlas() {}
        
        public SpaceAtlas( SpriteAtlas atlas ) { m_atlas = atlas; }
        
    }
    
}
```

このような、SpriteAtlas を包含し、  
各スプライトを返すプロパティを持つクラスが定義されます  

そして、例えば「CommonAtlas」クラスを使用して、  
SpriteAtlas からプロパティ経由でスプライトを取得したい場合、  

```cs
using KoganeUnityLib.UI;
using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    public CommonAtlas m_commonAtlas;
    public Image m_image;

    private void Awake()
    {
        m_image.sprite = m_commonAtlas.button_blue;
    }
}
```

このようなクラスを定義して、シーンのゲームオブジェクトにアタッチして、  

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20180311/20180311164840.png)

Inspector で「CommonAtlas」の欄に SpriteAtlas を設定します  
以上が、「SpriteAtlasNameCreator」の基本的な使い方になります  