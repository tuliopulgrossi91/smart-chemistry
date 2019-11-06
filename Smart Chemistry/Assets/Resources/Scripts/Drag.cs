using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    public Vector3 startPosition;
    public Vector3 endPosition;
    public GameObject element;
    #region IBeginDragHandler implementation

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log(gameObject.GetComponentInChildren<Text>().name);
        itemBeingDragged = gameObject;
        startPosition = transform.position;
    }

    #endregion

    #region IDragHandler implementation

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    #endregion

    #region IEndDragHandler implementation

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        Debug.Log(element.transform.position);
        Debug.Log(endPosition.x + 1);
        Debug.Log(transform.position);
        if ((transform.position.x < endPosition.x+10 && transform.position.x > endPosition.x - 10) && (transform.position.y < endPosition.y + 15 && transform.position.y > endPosition.y - 15))
        {
            transform.position = endPosition;
            element.transform.GetChild(1).GetComponent<Text>().text = gameObject.transform.GetChild(0).GetComponent<Text>().text;
            Destroy(gameObject);

        } else
        {
            transform.position = startPosition;
        }
       

    }

    #endregion
}
