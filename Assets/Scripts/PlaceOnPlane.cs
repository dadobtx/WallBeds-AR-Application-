using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.EventSystems;
//using UnityEngine.XR.Interaction.Toolkit.AR;
using System;

namespace UnityEngine.XR.ARFoundation.Samples
{
    /// <summary>
    /// Listens for touch events and performs an AR raycast from the screen touch point.
    /// AR raycasts will only hit detected trackables like feature points and planes.
    ///
    /// If a raycast hits a trackable, the <see cref="placedPrefab"/> is instantiated
    /// and moved to the hit position.
    /// </summary>
    [RequireComponent(typeof(ARRaycastManager))]
    public class PlaceOnPlane : MonoBehaviour

    {
        GameObject Obj;
        //[SerializeField] AssetReference Mesa1;
        //[SerializeField] AssetReference Mesa2;
        [SerializeField]
        [Tooltip("Instantiates this prefab on a plane at the touch location.")]
        GameObject m_PlacedPrefab;
        
        /// <summary>
        /// The prefab to instantiate on touch.
        /// </summary>
        public GameObject placedPrefab
        {
            get { return m_PlacedPrefab; }
            set { m_PlacedPrefab = value; }
        }

       


        /// <summary>
        /// The object instantiated as a result of a successful raycast intersection with a plane.
        /// </summary>
        public GameObject spawnedObject { get; private set; }
        
        public static event Action onPlacedObject;

        void Awake()
        {
            m_RaycastManager = GetComponent<ARRaycastManager>();
        }

        bool TryGetTouchPosition(out Vector2 touchPosition)
        {
            if (Input.touchCount > 0)
            {
                touchPosition = Input.GetTouch(0).position;
                return true;
            }

            touchPosition = default;
            return false;
        }


        // Void Update original
        /*void Update()
        {
            //placedPrefab = GameObject.FindGameObjectWithTag("Objeto");
            AddessableSetting ObjAddressable = GetComponent<AddessableSetting>();
            Obj = ObjAddressable.placedPrefab;
            m_PlacedPrefab = Obj;

            if (!TryGetTouchPosition(out Vector2 touchPosition))
                return;

            if (m_RaycastManager.Raycast(touchPosition, s_Hits, TrackableType.PlaneWithinPolygon)) //no mover si hace click sobre un UI && !touchPosition.IsPointOverUIObject()
            {
                // Raycast hits are sorted by distance, so the first one
                // will be the closest hit.
                var hitPose = s_Hits[0].pose;

                if (spawnedObject == null)
                {
                    spawnedObject = Instantiate(m_PlacedPrefab, hitPose.position, hitPose.rotation);
                }
                else
                {
                    spawnedObject.transform.position = hitPose.position;
                }
            }
        }*/

        void Update()
        {

           

            if (!TryGetTouchPosition(out Vector2 touchPosition))
                return;

            if (m_RaycastManager.Raycast(touchPosition, s_Hits, TrackableType.PlaneWithinPolygon))
            {
                AddessableSetting ObjAddressable = GetComponent<AddessableSetting>();
                Obj = ObjAddressable.placedPrefab;
                m_PlacedPrefab = Obj;
                //Debug.Log("objeto en posicion de mover1 " + touchPosition.IsPointOverUIObject());
                // Raycast hits are sorted by distance, so the first one
                // will be the closest hit.

                var hitPose = s_Hits[0].pose;

                if (spawnedObject == null )
                {
                    spawnedObject = Instantiate(m_PlacedPrefab, hitPose.position, hitPose.rotation);
                    // Debug.Log("objeto en posicion de mover "+ touchPosition.IsPointOverUIObject());
                    if (onPlacedObject != null)
                    {
                        onPlacedObject();
                    }
                }
                else 
                {
                    if (!EventSystem.current.IsPointerOverGameObject())
                    {
                        spawnedObject.transform.position = hitPose.position;
                        //Debug.Log("objeto en posicion de mover2 " + touchPosition.IsPointOverUIObject());
                    }
                       
                    
                        
                                           
                   
                }
            }
        }

       

        static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

        ARRaycastManager m_RaycastManager;
    }


}

