using UnityEngine;

public class AddMeshColliders : MonoBehaviour
{
    public string[] rootNames; // Mảng chứa tên các "root cha" bạn muốn tìm

    void Awake()
    {
        foreach (string rootName in rootNames)
        {
            GameObject rootObject = GameObject.Find(rootName);
            if (rootObject != null)
            {
                // Lấy tất cả các vật thể con của RootObject
                GameObject[] childObjects = GetChildObjects(rootObject);

                foreach (GameObject childObject in childObjects)
                {
                    // Kiểm tra xem vật thể đã có Mesh Collider chưa
                    if (childObject.GetComponent<MeshCollider>() == null)
                    {
                        // Thêm Mesh Collider vào vật thể
                        MeshCollider meshCollider = childObject.AddComponent<MeshCollider>();
                        // Thiết lập mesh của Mesh Collider bằng mesh của vật thể
                        meshCollider.sharedMesh = childObject.GetComponent<MeshFilter>().sharedMesh;
                    }
                }
            }
        }
    }

    GameObject[] GetChildObjects(GameObject parentObject)
    {
        int childCount = parentObject.transform.childCount;
        GameObject[] childObjects = new GameObject[childCount];

        for (int i = 0; i < childCount; i++)
        {
            childObjects[i] = parentObject.transform.GetChild(i).gameObject;
        }

        return childObjects;
    }
}