using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Collections.Generic;
public class ListElements : MonoBehaviour
{
    string path;
    string jsonString;

    void Start()
    {
        path = Application.dataPath + "/Resources/Json/elements.json";
        jsonString = File.ReadAllText(path);
        ElementsCollection elementsCollection = JsonUtility.FromJson<ElementsCollection>(jsonString);
        Debug.Log(elementsCollection.elements[0].name);
        foreach (Element element in elementsCollection.elements)
        {
            Debug.Log(element.name);
            Debug.Log(element.symbol);
            Debug.Log(element.atomicNumber);
            Debug.Log(element.initialPosition);

        }

    }

    public void findByAtomicNumber(Element[] element)
    {

    }
}
