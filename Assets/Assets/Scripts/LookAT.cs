using UnityEngine;
using UnityEngine.Events;

public class LookAT : MonoBehaviour
{
    [Header("LookAt Event")]
    public UnityEvent onLookAt;
    
    public void LookedAt()
    {
        onLookAt.Invoke();
    }
}