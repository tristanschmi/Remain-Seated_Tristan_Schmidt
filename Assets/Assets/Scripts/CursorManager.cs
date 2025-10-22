using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] private Texture2D cursorTexturechangeEvent;
    [SerializeField] private Texture2D cursorTexturedefault;
    
    private Vector2 cursorHotspot;
    
    
    void Start()
    {
        cursorHotspot = new Vector2(cursorTexturedefault.width / 2, cursorTexturedefault.height / 2);
        Cursor.SetCursor(cursorTexturedefault, cursorHotspot, CursorMode.Auto);
    }

    public void cursorTexturechange()
    {
        
        cursorHotspot = new Vector2(cursorTexturechangeEvent.width / 2, cursorTexturechangeEvent.height / 2);
        Cursor.SetCursor(cursorTexturechangeEvent, cursorHotspot, CursorMode.Auto);
        
    }
}