using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Plant : MonoBehaviour
    {
        [SerializeField] private PlantData info;

        private SetPlantInfo spi;

        private void Start()
        {
            spi = GameObject.FindWithTag("PlantInfo").GetComponent<SetPlantInfo>();
        }

        private void OnMouseDown()
        {
            spi.OpenPlantPanel();
            spi.planeName.text = info.Name;
            spi.threatLevel.text = info.Threat.ToString();
            spi.plantIcon.GetComponent<RawImage>().texture = info.Icon;

            if (spi.threatLevel.text == PlantData.THREAT.High.ToString())
            {
                PlayerController.dead = true;
            }
        }
    }
}