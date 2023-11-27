using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralgen : MonoBehaviour {
  [SerializeField] int width,height;
  [SerializeField] GameObject layer1,layer2,lolipop,candycane;
  [SerializeField] GameObject[] NPCs;
  [SerializeField] GameObject PlayerPrefab,BossPrefab;
  private void Start() {
    Generation();
    Instantiate(PlayerPrefab,new Vector2(0,height),Quaternion.identity);
    Instantiate(BossPrefab,new Vector2(0,height),Quaternion.Inverse(Quaternion.identity));
  }
  void Generation(){
    for (int x = 0; x < width; x++)
    {
      for (int y = 0; y < height; y++)
      {
        SpawnObj(layer2,x,y);
      }
        SpawnObj(layer1,x,height);
        if (Random.Range(0,100) < 20)
        {
          SpawnObj(candycane,x,height+1);
        }else if (Random.Range(0,100) < 30)
          SpawnObj(lolipop,x,height+1);
    }
    //SpawnNpcs();
  }
  void SpawnObj(GameObject obj, int width, int height){
    obj = Instantiate(obj,new Vector2(width,height), Quaternion.identity);
    obj.transform.parent = this.transform;
  }

  void SpawnNpcs(){
    for (int i = 0; i < NPCs.Length; i++)
    {
      SpawnObj(NPCs[Random.Range(0,NPCs.Length)],Random.Range(0,width),height+1);
    }
  }
}
