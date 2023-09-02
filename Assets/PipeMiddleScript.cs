using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    private LogicManagerScript _logicManager;
    
    void Start()
    {
        _logicManager = GameObject.FindGameObjectWithTag(LogicManagerScript.Tag).GetComponent<LogicManagerScript>();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == BirdScript.LayerTag)
        {
            _logicManager.AddScore();
        }
    }
}
