using TMPro;
using UnityEngine;


public class Nucleus : MonoBehaviour
{
    public int valenceElectrons;
    public GameObject electrons;
    public Transform nucleus;
    public TMP_Text text;
    public DefaultObserverEventHandler eventHandler;
    public TMP_Text elementName;
    public int id = 0;
    public Renderer rendrer;

    [SerializeField] private float radius = 0.9f;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Nucleus"))
        {
            //pass
        }
    }

    public void MoveTheNucleus(Vector3 destination, Transform nParent)
    {
        MoveTowards mToward = nucleus.GetComponent<MoveTowards>();
        mToward.transform.SetParent(nParent);
        Vector3 noise = new Vector3(0.018f, 0, 0);
        mToward.destination = destination + noise;
        mToward.enabled = true;

    }

    public void setElementData(int _id, ElementData data)
    {
        id = _id;
        text.text = data.symbol;
        elementName.text = data.name;
        valenceElectrons = data.valenceElectron;
        transform.localScale = transform.localScale + transform.localScale * data.size;

        // Call SetColor using the shader property name "_Color" and setting the color to red
        rendrer.material.color = data.color;

        for (int i = 1; i < valenceElectrons; i++)
        {
            Vector3 spawnPos = Random.insideUnitSphere * radius;
            spawnPos.y = 0;
            Vector3 direction = spawnPos;
            direction.Normalize();
            float dotProduct = Vector3.Dot(transform.forward, direction);
            float dotProductAngle = Mathf.Acos(dotProduct / transform.forward.magnitude * direction.magnitude);

            spawnPos.x = Mathf.Cos(dotProductAngle) * radius;
            spawnPos.z = Mathf.Sin(dotProductAngle * (Random.value > 0.5f ? 1f : -1f)) * radius;
            Transform pos = Instantiate(electrons, nucleus).transform;
            pos.localPosition = spawnPos;
        }
    }
}
