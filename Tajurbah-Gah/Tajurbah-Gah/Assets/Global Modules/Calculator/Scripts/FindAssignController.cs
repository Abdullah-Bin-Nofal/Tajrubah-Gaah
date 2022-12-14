using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Tajurbah_Gah
{
    public class FindAssignController : MonoBehaviour, IPointerDownHandler
    {
        public void OnPointerDown(PointerEventData eventData)
        {
            AssignToInput();
        }

        void AssignToInput()
        {
            AssignButtonController Object;
            if (FindObjectOfType<AssignButtonController>())
            {
                Object = FindObjectOfType<AssignButtonController>();
                Object.AssignInputField(GetComponent<InputField>());
            }
        }
    }
}