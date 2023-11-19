using UnityEngine;

public  class Links : MonoBehaviour
{
    public string[] links;
    

    
    public  void LoadLinks(int link)
    {
        Application.OpenURL(links[link]);
    }
}
