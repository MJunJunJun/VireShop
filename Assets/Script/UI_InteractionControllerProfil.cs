using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;

public class UI_InteractionControllerProfil : MonoBehaviour
{
    public ManagementRightSwitcher managementRightSwitcher;
    public adaPetunjukTidak petunjukAktif;
    public bool aktifkanPetunjuk;

    [SerializeField]
    GameObject UIController;

    [SerializeField]
    GameObject BaseController;

    [SerializeField]
    InputActionReference inputActionReference_UISwitcher;

    //[SerializeField]
    //InputActionReference inputActionReference_UISwitcher_Biasa;

    bool isUICanvasActive = false;

    [SerializeField]
    GameObject UICanvasGameobject;

    [SerializeField]
    Vector3 positionOffsetForUICanvasGameobject;
    public GameObject uiProfil;

   

    private void OnEnable()
    {
        inputActionReference_UISwitcher.action.performed += ActivateUIMode;
    }
    private void OnDisable()
    {
        inputActionReference_UISwitcher.action.performed -= ActivateUIMode;

    }

    private void Start()
    {
        aktifkanPetunjuk = true;
        //Deactivating UI Canvas Gameobject by default
        UICanvasGameobject.SetActive(false);
        uiProfil.SetActive(false);

        //Deactivating UI Controller by default
        UIController.GetComponent<XRRayInteractor>().enabled = false;
        UIController.GetComponent<XRInteractorLineVisual>().enabled = false;
    }

    /// <summary>
    /// This method is called when the player presses UI Switcher Button which is the input action defined in Default Input Actions.
    /// When it is called, UI interaction mode is switched on and off according to the previous state of the UI Canvas.
    /// </summary>
    /// <param name="obj"></param>
    private void ActivateUIMode(InputAction.CallbackContext obj)
    {
        if (!managementRightSwitcher.switcherModeOn)
        {
            managementRightSwitcher.switcherModeOn = true;
            uiProfil.SetActive(true);

            //Activating UI Controller by enabling its XR Ray Interactor and XR Interactor Line Visual
            UIController.GetComponent<XRRayInteractor>().enabled = true;
            UIController.GetComponent<XRInteractorLineVisual>().enabled = true;

            //Deactivating Base Controller by disabling its XR Direct Interactor
            BaseController.GetComponent<XRDirectInteractor>().enabled = false;

            //Adjusting the transform of the UI Canvas Gameobject according to the VR Player transform
            Vector3 positionVec = new Vector3(UIController.transform.position.x, positionOffsetForUICanvasGameobject.y, UIController.transform.position.z);
            Vector3 directionVec = UIController.transform.forward;
            directionVec.y = 0f;
            UICanvasGameobject.transform.position = positionVec + positionOffsetForUICanvasGameobject.magnitude * directionVec;
            UICanvasGameobject.transform.rotation = Quaternion.LookRotation(directionVec);


            UICanvasGameobject.SetActive(true);
            if (aktifkanPetunjuk==false)
            {
                //Activating the UI Canvas Gameobject
                UICanvasGameobject.SetActive(true);
            }
        }
        else
        {
            uiProfil.SetActive(false);
            managementRightSwitcher.switcherModeOn = false;

            //De-Activating UI Controller by enabling its XR Ray Interactor and XR Interactor Line Visual
            UIController.GetComponent<XRRayInteractor>().enabled = false;
            UIController.GetComponent<XRInteractorLineVisual>().enabled = false;

            //Activating Base Controller by disabling its XR Direct Interactor
            BaseController.GetComponent<XRDirectInteractor>().enabled = true;

            //De-Activating the UI Canvas Gameobject
            UICanvasGameobject.SetActive(false);
        }

    }
}
