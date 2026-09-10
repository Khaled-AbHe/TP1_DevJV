 using UnityEngine;

public class EffetParallaxee : MonoBehaviour
{
    [Header("Caméra")]
    [SerializeField] private Transform cameraCible;

    [Header("Suivi de la caméra")]
    [SerializeField, Range(0f, 1f)] private float suiviHorizontal = 0.85f;
    [SerializeField, Range(0f, 1f)] private float suiviVertical = 0.90f;

    [Header("Déplacement automatique très lent")]
    [SerializeField] private Vector2 vitesseAutomatique = new(0.01f, 0f);

    private Vector3 positionInitiale;
    private Vector3 positionCameraInitiale;
    private Vector2 decalageAutomatique;

    private void Start()
    {
        // TODO 1 : mémoriser la position initiale de cette couche.
        // TODO 2 : trouver automatiquement la caméra si elle n'est pas assignée.
        // TODO 3 : mémoriser la position initiale de la caméra.
    }

    private void LateUpdate()
    {
        // TODO 4 : arrêter la méthode si aucune caméra n'est disponible.
        // TODO 5 : calculer le déplacement de la caméra.
        // TODO 6 : mettre à jour le déplacement automatique.
        // TODO 7 : calculer et appliquer la nouvelle position de la couche.
    }

    /*
     * BANQUE DE LIGNES — À REPLACER ET À INDENTER
     *
     * Toutes les instructions nécessaires sont présentes.
     * Les accolades des conditions ne sont pas fournies.
     *
     * positionInitiale.z
     * if (cameraCible != null)
     * decalageAutomatique += vitesseAutomatique * Time.deltaTime;
     * positionInitiale = transform.position;
     * positionInitiale.y + mouvementCamera.y * suiviVertical
     *     + decalageAutomatique.y,
     * return;
     * cameraCible = Camera.main.transform;
     * Vector3 mouvementCamera = cameraCible.position - positionCameraInitiale;
     * transform.position = new Vector3(
     * if (cameraCible == null && Camera.main != null)
     * positionCameraInitiale = cameraCible.position;
     * );
     * if (cameraCible == null)
     * positionInitiale.x + mouvementCamera.x * suiviHorizontal
     *     + decalageAutomatique.x,
     */
}
