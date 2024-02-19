using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManagement : MonoBehaviour
{
    public int puzzleActual;
    public bool[] puzzlesCompletados;
    public GameObject zonaSiguienteNivel;

    public void ComprobarPuzzleCompletado()
    {
        if (puzzleActual == 3)
        {
            zonaSiguienteNivel.SetActive(true);
        }
        else
        {
            puzzleActual++;
            DesactivarPuzzleActual();
        }
        puzzlesCompletados[puzzleActual - 1] = true;
    }

    public void ComprobarAccesoPuzzle()
    {
        if (!puzzlesCompletados[puzzleActual - 1])
        {
            // Mostrar mensaje informativo
            return;
        }
        // Permitir acceso al puzzle
    }

    public void ReiniciarJuego()
    {
        puzzleActual = 1;
        puzzlesCompletados = new bool[3] { false, false, false };
        zonaSiguienteNivel.SetActive(false);
    }

    private void DesactivarPuzzleActual()
    {
        // Desactivar el GameObject del puzzle actual
    }
}
