using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
/// <summary>
/// This class takes care of 
/// loading sprites, 
/// and playing sound, & music.
/// 
/// This class should be a Singletone (read more)
/// </summary>
public class AssetManager
{
    protected ContentManager contentManager;

    public AssetManager(ContentManager Content)
    {
        this.contentManager = Content;
    }

    public Texture2D GetSprite(string assetName)
    {
        if (assetName == "")
            return null;
        return contentManager.Load<Texture2D>(assetName);
    }

    public void PlaySound(string assetName)
    {//TODO: Check input?
        SoundEffect snd = contentManager.Load<SoundEffect>(assetName);
        snd.Play();
    }

    public void PlayMusic(string assetName, bool repeat = true)
    {
        MediaPlayer.IsRepeating = repeat;
        MediaPlayer.Play(contentManager.Load<Song>(assetName));
    }

    public ContentManager Content
    {
        get { return contentManager; }
    }
}