using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    private Vector3 startPosition;
    private Vector3 endPosition;
    public GameObject element;
    private Element elemento;
    #region IBeginDragHandler implementation


    private void Start()
    {


    }

    public void OnBeginDrag(PointerEventData eventData)
    {

        if (gameObject.activeSelf)
        {
            this.elemento = ElementsService.findBySymbol(gameObject.transform.GetChild(0).GetComponent<Text>().text);
            this.endPosition = ElementsService.convertStringtoVector3(this.elemento.startPosition);
            this.element = GameObject.Find(this.elemento.symbol);
        }
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
