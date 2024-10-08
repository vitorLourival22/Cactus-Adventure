using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{public float sensi = 5f;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Obter a posição do mouse no espaço do mundo
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z; // Garantir que a posição z permaneça consistente

        // Calcular a direção do objeto para a posição do mouse
        Vector3 direction = mousePosition - transform.position;

        // Ajustar a direção com a sensibilidade
        direction *= sensi;

        // Calcular o ângulo e aplicar a rotação
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
        
    }
}
