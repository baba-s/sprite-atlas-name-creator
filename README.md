[日本語の Readme はこちら](https://github.com/baba-s/sprite-atlas-name-creator/blob/master/README_JP.md)  

# SpriteAtlasNameCreator

Editor extension to create a class that can get sprite included in SpriteAtlas by property instead of string.

# Feature

## Get a sprite at properties.

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

For example, if you want to set a sprite included in SpriteAtlas to Image.sprite,  
We use SpriteAtlas.GetSprite( "hoge" ),  
Since this method specifies the sprite name as a character string,  
There is a problem of mistyping the input of the sprite name.  

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

By creating a dedicated class using "SpriteAtlasNameCreator",  
As mention above, you can get sprites as properties,  
It is possible to prevent mistyping of sprite name.  

## Acquire a sprite by format specification.

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

For example, If you want to change sprites with PARAM_TYPE, 
Although it may be described as above,  

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

You can also get a sprite like this way.  

## Extend functionality with partial class.

```cs
[Serializable]
public partial class CommonAtlas : AtlasBase
{
    ...
}
```

Since the created class is a partial class,  

```cs
public partial class CommonAtlas : AtlasBase
{
    public Sprite GetParamIcon( PARAM_TYPE paramType )
    {
        return m_atlas.get_icon( paramType.ToString() );
    }
}
```

By defining frequently used relationships in another file,  

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

You can get sprites more intuitively.  

# Version

- Unity 2017.3.0f3

# Install

1. Go to the following page and download "SpriteAtlasNameCreator.unitypackage".  
https://github.com/baba-s/sprite-atlas-name-creator/blob/master/SpriteAtlasNameCreator.unitypackage?raw=true
2. Import the downloaded "SpriteAtlasNameCreator.unitypackage" into the Unity project.  

# Usage

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20180311/20180311164028.png)

As mentioned above, if SpriteAtlas exists in the Unity project,  

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20180311/20180311164104.png)

When you select "Kogane > Create > Sprite Atlas Name" in the Unity menu,  

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20180311/20180311164128.png)

A file "SpriteAtlasName" is created,   

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

Such a class is defined.  
Then, For example, if you want to use a "CommonAtlas" class to obtain a sprite,  

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

By defining such a class,  
Attach to the game object of the scene,  

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20180311/20180311164840.png)

Set SpriteAtlas with Inspector.  