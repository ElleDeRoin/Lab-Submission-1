using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChessPiece : MonoBehaviour
{
    public static string[] options = new string[] { "Pawn", "Rook", "Knight", "Bishop", "Queen", "King" };
    private static int index = 0;
    [MenuItem("UI Toolkit/Example")]
    
    public static void ShowPopup()
    {
        index = EditorGUILayout.Popup(index, options);
    }



    public void ChangePieceType(string type)
    {
        switch (type) {
            case "Chess_pawn":
            // Change the piece to a pawn
            break;
        case "Chess_rook":
            // Change the piece to a rook
            break;
        case "Chess_knight":
            // Change the piece to a knight
            break;
        case "Chess_bishop":
            // Change the piece to a bishop
            break;
        case "Chess_queen":
            // Change the piece to a queen
            break;
        case "Chess_king":
            // Change the piece to a kings
            break;
        }
        return;
    }
}


