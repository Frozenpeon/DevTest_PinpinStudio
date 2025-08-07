using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class ExpressionShower : MonoBehaviour
{
    private Dictionary<Expressions, Texture2D> mappingExpressionToSprite = new Dictionary<Expressions, Texture2D>();
    public List<Expressions> expressions;
    public List<Texture2D> textures;


    private RawImage image;
    void Start()
    {
        if (expressions.Count != textures.Count) {
            Debug.LogError("List length doesn't match");
        }
        for (int i = 0; i < expressions.Count; i++) {
            mappingExpressionToSprite.Add(expressions[i], textures[i]);
        }
        image = GetComponent<RawImage>();
        image.enabled = false; 
        Athlete.showedExpression += showExpression;
    }

   public void showExpression(Expressions e)
    {
        image.enabled = true;
        image.texture = mappingExpressionToSprite[e];
    }
}
