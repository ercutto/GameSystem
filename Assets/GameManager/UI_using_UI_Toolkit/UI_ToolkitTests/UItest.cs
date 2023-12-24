
using UnityEngine;
using UnityEngine.UIElements;

public class UItest : MonoBehaviour
{
    private Label sampleLabel;
    
    private Button sampleButton;
    
    private void OnEnable()
    {
        var rootVisualElment = GetComponent<UIDocument>().rootVisualElement;
        sampleButton=rootVisualElment.Q<Button>("sampleButton");
        sampleLabel = rootVisualElment.Q<Label>("Label");
        
        sampleButton.RegisterCallback<ClickEvent>(ev => ChangeText());
    }
    private void ChangeText()
    {
       
        sampleLabel.text = "a";
       
    }
}
