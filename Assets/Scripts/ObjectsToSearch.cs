using UnityEngine;
using System.Collections;

public class ObjectsToSearch : MonoBehaviour {

	[System.Serializable()]
	public struct ObjectRelation{
		public string objectName;
		public Sprite activeSprite, noactiveSprite;
		
	}
	
	public ObjectRelation[] objects;
	
	
	
}
