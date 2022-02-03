using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using System;

public class AddessableSetting : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] AssetReference CamaV1;
    [SerializeField] AssetReference CamaV2;
    [SerializeField] AssetReference CamaV3;
    [SerializeField] AssetReference Obj4;
    [SerializeField] AssetReference Obj5;
    [SerializeField] AssetReference Obj6;
    [SerializeField] AssetReference Obj7;
    [SerializeField] AssetReference Obj8;


    [SerializeField] AssetReference ObjPresentacion;


    public GoogleSignInDemo InstanceSessionUser;
    public GameObject SessionUser;

    public DBManager InstanceDBManager;
    public GameObject SessionDBManager;

    // Eliminar este comentario y los comentarios de las lineas 64 y 67
    //public ClaseDatos claseDatosTipoMueble;
    //public DBManager dBManager;

    [SerializeField]
    [Tooltip("Instantiates this prefab on a plane at the touch location.")]
    GameObject m_PlacedPrefab;
    public GameObject placedPrefab
    {
        get { return m_PlacedPrefab; }
        set { m_PlacedPrefab = value; }
    }

   

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        destroyObjectsEscene();
        ShowObject(ObjPresentacion,"AdObjectColor","AdObjectPresentation");
        
        

       

    }
    
    void Awake()
    {
        SessionUser = GameObject.Find("Firebase");
        InstanceSessionUser = SessionUser.GetComponent<GoogleSignInDemo>();

        SessionDBManager = GameObject.Find("DBManager");
        InstanceDBManager = SessionDBManager.GetComponent<DBManager>();
    }

    // General Function
    public void ShowObject(AssetReference objecttoshow,string Color,string TypeofItem)
    {
       destroyObjectsEscene();
        // Overlap the object in the real environment
        Addressables.LoadAssetAsync<GameObject>(objecttoshow).Completed += ObjectLoadDoneCama;
        //Set entities user classs features to be written in Firebase 
        InstanceSessionUser.entitiesUser.Color = Color;
        InstanceSessionUser.entitiesUser.TypeOfItem = TypeofItem;
        //Write all entity user features(Object type, Object Color, User email and user name) in Firebase
        InstanceDBManager.WriteFirebase();
    }


    public void camaV1()
    {
        // Overlap the object in the real environment
        ShowObject(CamaV1, "White","CamaV1");

       
    }

    

    public void camaV2()
    {

        // Overlap the object in the real environment
        ShowObject(CamaV2,"White","CamaV2");
                
    }



    public void camaV3()
    {
        // Overlap the object in the real environment
        ShowObject(CamaV3,"White","CamaV3");
       
    }

    public void obj4()
    {
        // Overlap the object in the real environment
        ShowObject(Obj4, "White", "Obj4");

    }

    public void obj5()
    {
        // Overlap the object in the real environment
        ShowObject(Obj5, "White", "Obj5");

    }

    public void obj6()
    {
        // Overlap the object in the real environment
        ShowObject(Obj6, "White", "Obj6");

    }

    public void obj7()
    {
        // Overlap the object in the real environment
        ShowObject(Obj7, "White", "Obj7");

    }

    public void obj8()
    {
        // Overlap the object in the real environment
        ShowObject(Obj8, "White", "Obj8");

    }

    private void ObjectLoadDoneCama(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void destroyObjectsEscene()
    {
       /*GameObject[] enemies = GameObject.FindGameObjectsWithTag("Mesa");
        foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);*/
        
        GameObject[] enemies2 = GameObject.FindGameObjectsWithTag("Cama");
        foreach (GameObject enemy in enemies2)
            GameObject.Destroy(enemy);
       
    }

    
}
