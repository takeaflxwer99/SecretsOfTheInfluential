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
        yield return StartCoroutine(typeWriter.TypeWriterString("En la opulenta mansi�n Whitewood, Charles Shepherd reemplaza a su hermano en una crucial cena de negocios. Un detective privado en un mundo de magnates, Charles enfrenta un entorno inc�modo. Invitados llegan, cada uno con su propia historia: William Davies, entusiasta; los reci�n casados James y Jessie; Noah, simp�tico y misterioso; Jessica Mortone, distante pero intrigante; Arnold, un cliente pasado con un oscuro pasado. Grace, elegante y enigm�tica, capta la atenci�n de Charles.", textMesh));


        yield return new WaitForSeconds(2f);


        textMesh.text = "";


        yield return StartCoroutine(typeWriter.TypeWriterString("La cena comienza con charlas superficiales que se vuelven sutilmente intimidantes. Un anuncio interrumpe la tensi�n, revelando un lujoso men�. La conversaci�n se relaja, pero un repentino apag�n y un estruendoso golpe sacuden la sala. Luces parpadean, revelando a Noah aparentemente sin vida. La trama toma un giro oscuro, dejando a todos perplejos en la mansi�n Whitewood. El misterio se despliega.", textMesh));

        yield return new WaitForSeconds(5f);

        yield return SceneManager.LoadSceneAsync("SampleScene");

    }
}
