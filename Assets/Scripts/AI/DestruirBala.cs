using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirBala : MonoBehaviour
{
    public GameObject Bala;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 1f);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
