using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChessPiece : MonoBehaviour
{
    //Stores the types of chess pieces
    public enum options
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        Queen,
        King
    };

    public int moveRadius;

    //The default chess piece and colors
    public options currentOption = options.Pawn;

    //Set chess piece sprite and color
    [Header("Piece Settings")]
    public Color pieceColor = Color.white;

    public Sprite pawnSprite;
    public Sprite rookSprite;
    public Sprite knightSprite;
    public Sprite bishopSprite;
    public Sprite queenSprite;
    public Sprite kingSprite;

    [Header("Move Display")]
    public Color moveColor = Color.green;

    private SpriteRenderer spriteRenderer;

    private void OnValidate()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null)
        {
            spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        }

        spriteRenderer.color = pieceColor;

        //Change sprite to show correct piece based on type
        switch (currentOption)
        {
            case options.Pawn:
                spriteRenderer.sprite = pawnSprite;
                break;

            case options.Rook:
                spriteRenderer.sprite = rookSprite;
                break;

            case options.Knight:
                spriteRenderer.sprite = knightSprite;
                break;

            case options.Bishop:
                spriteRenderer.sprite = bishopSprite;
                break;

            case options.Queen:
                spriteRenderer.sprite = queenSprite;
                break;

            case options.King:
                spriteRenderer.sprite = kingSprite;
                break;
        }
    }

    // Draws the possible moves for the selected piece
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;

        Gizmos.DrawWireCube(
            transform.position,
            Vector3.one
        );

         Gizmos.color = moveColor;

        //Draws the possible moves for the selected piece based on piece type
        switch (currentOption)
        {
            case options.Pawn:
                DrawPawnMoves();
                moveRadius = 3;
                break;

            case options.Rook:
                DrawRookMoves();
                moveRadius = 10;
                break;

            case options.Knight:
                DrawKnightMoves();
                moveRadius = 3;
                break;

            case options.Bishop:
                DrawBishopMoves();
                moveRadius = 10;
                break;

            case options.Queen:
                DrawQueenMoves();
                moveRadius = 10;
                break;

            case options.King:
                DrawKingMoves();
                moveRadius = 2;
                break;
        }
    }


    private void DrawPawnMoves()
    {
        DrawMoveSquare(0, 1);
        DrawMoveSquare(0, 2);
    }

    private void DrawRookMoves()
    {
        for (int i = 1; i < 8; i++)
        {
            DrawMoveSquare(0, i);
        }
        for (int i = 1; i < 8; i++)
        {
            DrawMoveSquare(0, -i);
        }
        for (int i = 1; i < 8; i++)
        {
            DrawMoveSquare(i, 0);
        }
        for (int i = 1; i < 8; i++)
        {
            DrawMoveSquare(-i, 0);
        }
    }

    private void DrawBishopMoves()
    {
        for (int i = 1; i < 8; i++)
        {
            DrawMoveSquare(i, i);
        }
        for (int i = 1; i < 8; i++)
        {
            DrawMoveSquare(-i, i);
        }
        for (int i = 1; i < 8; i++)
        {
            DrawMoveSquare(i, -i);
        }
        for (int i = 1; i < 8; i++)
        {
            DrawMoveSquare(-i, -i);
        }
    }

    private void DrawQueenMoves()
    {
        DrawRookMoves();
        DrawBishopMoves();
    }

    private void DrawKnightMoves()
    {
        DrawMoveSquare(1, 2);
        DrawMoveSquare(2, 1);

        DrawMoveSquare(-1, 2);
        DrawMoveSquare(-2, 1);

        DrawMoveSquare(1, -2);
        DrawMoveSquare(2, -1);

        DrawMoveSquare(-1, -2);
        DrawMoveSquare(-2, -1);
    }

    private void DrawKingMoves()
    {
        DrawMoveSquare(0, 1);
        DrawMoveSquare(0, -1);
        DrawMoveSquare(1, 0);
        DrawMoveSquare(-1, 0);
        DrawMoveSquare(1, 1);
        DrawMoveSquare(-1, 1);
        DrawMoveSquare(1, -1);
        DrawMoveSquare(-1, -1);
    }

    //Draws the actuall squares for the moves of each selected piece
    private void DrawMoveSquare(int x, int y)
    {
        Vector3 position = transform.position;

        position.x += x;
        position.y += y;

        Vector3 size = new Vector3(
            0.75f,
            0.75f,
            0.1f
        );

        Gizmos.DrawCube(position, size);

        Gizmos.color = Color.yellow;

        Gizmos.DrawWireCube(
            position,
            Vector3.one
        );
        
        Gizmos.color = moveColor;
    }
}



// Added square handle around possible moves for selected piece
[CustomEditor(typeof(ChessPiece))]
public class ChessPieceEditor : Editor
{
    public void OnSceneGUI()
    {
        var t = target as ChessPiece;
        if (t != null)
        {
            var tr = t.transform;
            var pos = tr.position;
            var color = new Color(245f / 255f, 66f / 255f, 236f / 255f, 0.5f);
            float moddedSize = t.moveRadius * 1.5f;
            Vector3 size = new Vector3(moddedSize, moddedSize, moddedSize);
            Handles.color = color;
            Handles.DrawWireCube(pos, size);

        }
    }
}