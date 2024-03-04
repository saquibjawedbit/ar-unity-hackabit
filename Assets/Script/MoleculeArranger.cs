using UnityEngine;

public class MoleculeArranger : MonoBehaviour
{
    public Transform axis;

    public void ArrangeMolecules()
    {
        MoveTowards[] mt = GetComponentsInChildren<MoveTowards>();
        if(mt.Length > 0)
        {
            int currentAngle = 0;
            int angle = 360/ (mt.Length+1);
            for(int i = 0; i < mt.Length; i++)
            {
                mt[i].transform.RotateAround(axis.position, Vector3.up, angle);
                currentAngle += angle;
            }
        }
    }
}
