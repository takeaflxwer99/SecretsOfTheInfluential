using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cinematica : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    private TypeWriter typeWriter;

    void Start()
    {
        typeWriter = GetComponent<TypeWriter>();
        StartCoroutine(InicioEscritura());
    }

    IEnumerator InicioEscritura()
    {
        yield return StartCoroutine(typeWriter.TypeWriterString("En la opulenta mansión Whitewood, Charles Shepherd reemplaza a su hermano en una crucial cena de negocios. Un detective privado en un mundo de magnates, Charles enfrenta un entorno incómodo. Invitados llegan, cada uno con su propia historia: William Davies, entusiasta; los recién casados James y Jessie; Noah, simpático y misterioso; Jessica Mortone, distante pero intrigante; Arnold, un cliente pasado con un oscuro pasado. Grace, elegante y enigmática, capta la atención de Charles.", textMesh));


        yield return new WaitForSeconds(2f);


        textMesh.text = "";


        yield return StartCoroutine(typeWriter.TypeWriterString("La cena comienza con charlas superficiales que se vuelven sutilmente intimidantes. Un anuncio interrumpe la tensión, revelando un lujoso menú. La conversación se relaja, pero un repentino apagón y un estruendoso golpe sacuden la sala. Luces parpadean, revelando a Noah aparentemente sin vida. La trama toma un giro oscuro, dejando a todos perplejos en la mansión Whitewood. El misterio se despliega.", textMesh));

        yield return new WaitForSeconds(5f);

        yield return SceneManager.LoadSceneAsync("SampleScene");

    }
}
