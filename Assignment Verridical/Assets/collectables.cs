using UnityEngine;

public class collectables : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    
    public void Spawner()
    {
        Vector3 pos = new Vector3(Random.Range(-13,14),0,Random.Range(-2,12));
        Instantiate(prefab, pos, Quaternion.identity);
        

      
    }


}
