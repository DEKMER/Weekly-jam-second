using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalagaEnemy : MonoBehaviour
{
    public GameObject Shoot;
    public Galaga gal;
    private void OnEnable()
    {
        StartCoroutine(ShootCoolDown());
    }
    public IEnumerator ShootCoolDown()
    {
        yield return new WaitForSeconds(2);
        GameObject shootMicro = Instantiate(Shoot, gameObject.transform.position + new Vector3(0, -30, 0), Quaternion.identity);
        shootMicro.transform.parent = gameObject.transform;
        StartCoroutine(ShootCoolDown());
    }
    public void EnemigosCountMinus() 
    {
        gal.EnemigosCount--;
    }
}
