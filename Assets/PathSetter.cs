using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathSetter : MonoBehaviour {

    public NextPath[] Paths;
    //protected int CurrentIndex = 0;
    protected NextPath NewPath;

    public void Start(){
		
		SetPath ( Paths[0]);
	}

	public void SetPath(NextPath path){
		Vector3 pos = new Vector3 ();
		pos = GetPosition (path);
        //	SetIndex ();
        NewPath = Paths[(int)Random.Range(0.1f, 1.9f)];
        NewPath = Instantiate(NewPath);
        NewPath.transform.position = pos;
        StartCoroutine(Coroutine());
	}

    //public void SetIndex()
    //{
    //    CurrentIndex++;
    //    if (CurrentIndex == Paths.Length)
    //    {
    //        CurrentIndex = 0;
    //    }
    //}

	public Vector3 GetPosition(NextPath path){
		return path.pivot.transform.position; 
	}

    public IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(2);
        SetPath(NewPath);
    }

    //    public void Start()
    //    {
    //        Paths[CurrentIndex].transform.position = new Vector3(0,0, Paths[CurrentIndex].GetComponent<Collider>().bounds.size.z / 2);
    //        
    //        SetPath();
    //        //SetPath();
    //    }
    //
    //    public void SetPath()
    //    {
    //        Vector3 vec = NextPathPosition(Paths[CurrentIndex]);
    //        SetIndex();
    //        vec.x += Paths[CurrentIndex].GetComponent<Collider>().bounds.size.x/2 - Paths[CurrentIndex].GetComponent<Collider>().bounds.size.x;
    //        vec.z += Paths[CurrentIndex].GetComponent<Collider>().bounds.size.z/2 - Paths[CurrentIndex].GetComponent<Collider>().bounds.size.z;
    //        Paths[CurrentIndex].transform.position = vec;
    //        StartCoroutine(Coroutine());
    //    }
    //    
    //
    //    public IEnumerator Coroutine()
    //    {
    //        yield return new WaitForSeconds(2);
    //        SetPath();
    //    }
    //
    //    public Vector3 NextPathPosition(GameObject obj)
    //    {
    //        Vector3 pos = obj.gameObject.transform.position;
    //        pos.x += obj.GetComponent<Collider>().bounds.size.x / 2 + obj.GetComponent<Collider>().bounds.size.z;
    //        pos.z += obj.GetComponent<Collider>().bounds.size.z / 2 + obj.GetComponent<Collider>().bounds.size.x;
    //        return pos;
    //    }
    //
    //    public void SetIndex()
    //    {
    //        CurrentIndex++;
    //        if (CurrentIndex == Paths.Length)
    //        {
    //            CurrentIndex = 0;
    //        }
    //    }
    //
}
