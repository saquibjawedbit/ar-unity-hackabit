using Unity.Mathematics;
using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System.Linq;

public class TrackerHandler : MonoBehaviour
{
    public List<ElementData> Elements;
    public List<Transform> elementPos;

    private MoleculeArranger moleculeArranger;

    public GameObject[] imageObject;
    public GameObject finalProduct;

    public int[] reactantIndex;
    public string[] products;
    public string[] productName;

    private int reactantIndex1 = 0;
    private int reactantIndex2 = 1;
    private int productIndex = 0;
    public TMP_Text text;
    public int nSteps = 1;

    private void Start()
    {
        Vector3 spawnPoint = Vector3.zero;
        for (int i = 0; i < reactantIndex.Length; i++)
        {
            if (reactantIndex[i] != -1)
            {
                Nucleus nucleus = Instantiate(imageObject[i], spawnPoint, Quaternion.identity).GetComponent<Nucleus>();
                nucleus.setElementData(i, Elements[reactantIndex[i]]);
                elementPos.Add(nucleus.transform);
                spawnPoint.x += 5;
            }
            else
            {
                elementPos.Add(elementPos[i - 2]);
            }
        }
        moleculeArranger = elementPos[0].GetComponent<MoleculeArranger>();
    }

    void Update() {
        float distance1 = Vector3.Distance(elementPos[reactantIndex1].position, elementPos[reactantIndex2].position);
        //print($"Source: {elementPos[reactantIndex1].transform.name}, Destination: {elementPos[reactantIndex2].transform.name}");
        if(distance1 <= 0.12 && nSteps > 0) {

            Nucleus nucleus_2 = elementPos[reactantIndex2].GetComponent<Nucleus>();
            Nucleus nucleus_1 = elementPos[reactantIndex1].GetComponent<Nucleus>();

            nucleus_1.text.text = products[productIndex];  // r1 = 2, r2 = 3
            nucleus_1.elementName.text = productName[productIndex++];

            reactantIndex1 += 2;
            reactantIndex2 += 2;
            if (reactantIndex1 >= reactantIndex.Length || reactantIndex[reactantIndex1] == -1) reactantIndex1 -= 2;
            if (reactantIndex2 >= reactantIndex.Length || reactantIndex[reactantIndex2] == -1) reactantIndex2 -= 2;
            if (moleculeArranger != null) moleculeArranger.ArrangeMolecules();
            nucleus_2.MoveTheNucleus(nucleus_1.nucleus.transform.position, nucleus_1.nucleus.transform);

            nSteps--;
            if(nSteps == 0)
            {
                Instantiate(finalProduct, nucleus_1.transform);
            }
        }
        text.text = $"Distance: {distance1}";
    }
}
