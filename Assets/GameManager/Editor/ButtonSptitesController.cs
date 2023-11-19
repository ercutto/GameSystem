
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

[CustomEditor(typeof(ButtonSprites))]
public class ButtonSptitesController  :Editor
{
   

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        ButtonSprites _buttonSprites = (ButtonSprites)target;

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("blue"))
        {
            for (int i = 0; i < _buttonSprites.spritesToChange.Length; i++)
            {
                _buttonSprites.spritesToChange[i].gameObject.GetComponent<Image>().sprite = _buttonSprites.buttonSprites[0];
            }

        }

        if (GUILayout.Button("Red"))
        {
            for (int i = 0; i < _buttonSprites.spritesToChange.Length; i++)
            {
                _buttonSprites.spritesToChange[i].gameObject.GetComponent<Image>().sprite = _buttonSprites.buttonSprites[1];
            }

        }
        if (GUILayout.Button("Green"))
        {
            for (int i = 0; i < _buttonSprites.spritesToChange.Length; i++)
            {
                _buttonSprites.spritesToChange[i].gameObject.GetComponent<Image>().sprite = _buttonSprites.buttonSprites[2];
            }

        }
        if (GUILayout.Button("Orange"))
        {
            for (int i = 0; i < _buttonSprites.spritesToChange.Length; i++)
            {
                _buttonSprites.spritesToChange[i].gameObject.GetComponent<Image>().sprite = _buttonSprites.buttonSprites[3];
            }

        }

        GUILayout.EndHorizontal();
    }
}
