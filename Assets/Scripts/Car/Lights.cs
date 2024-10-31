using UnityEngine;

namespace Car
{
    public class Lights : MonoBehaviour
    {
        [SerializeField]
        private GameObject tailLights;
        [SerializeField]
        private GameObject frontLights; // ��������� ���� ��� �������� ���
        [SerializeField]
        private Material material;
        [SerializeField]
        private Material frontLightsMaterial;


        public void TailLights(bool on)
        {
            tailLights.SetActive(on);
            if (on)
            {
                material.EnableKeyword("_EMISSION");
            }
            else
            {
                material.DisableKeyword("_EMISSION");
            }
        }

        public void FrontLights(bool on) // ����� ����� ��� ���������� ��������� ������
        {
            frontLights.SetActive(on);
            if (on)
            {
                frontLightsMaterial.EnableKeyword("_EMISSION");
            }
            else
            {
                frontLightsMaterial.DisableKeyword("_EMISSION");
            }
        }
    }
}