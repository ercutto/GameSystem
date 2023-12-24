using UnityEngine;
using UnityEditor;

public class SpriteChangerForUI : EditorWindow
{
    [MenuItem("QuickTools/SpriteChanger")]
    static void ShowWindow()
    {
        SpriteChangerForUI window =(SpriteChangerForUI)GetWindow(typeof(SpriteChangerForUI));
        window.minSize = new Vector2(600, 300);
        window.Show();
    }

}
