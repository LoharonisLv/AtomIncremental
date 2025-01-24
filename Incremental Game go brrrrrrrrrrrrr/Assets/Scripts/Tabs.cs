using UnityEngine;
using UnityEngine.UI;

public class Tabs : MonoBehaviour
{
    
    //Tabs

    public CanvasGroup hydrogenScreen;
    public CanvasGroup heliumScreen;
    public CanvasGroup menu;
    public CanvasGroup li;
    public CanvasGroup be;
    public CanvasGroup b;
    public CanvasGroup c;
    public CanvasGroup n;
    public CanvasGroup o;
    public CanvasGroup f;
    public CanvasGroup ne;
    public string[] groups = new string[] { "hydrogenScreen" , "heliumScreen", "menu", "li", "be", "b", "c", "n", "o", "f", "ne", "na", "mg", "al", "si", "p", "s", "cl", "ar", "k", "ca","sc", "ti","v", "cr","mn","fe","co", "ni", "cu", "zn", "ga", "ge", "as", "se", "br", "kr", "rb", "sr", "y" , "zr", "nb", "mo", "tc", "ru" , "rh", "pd", "ag", "cd", "in" , "sn", "sb" , "te", "i", "xe", "cs", "ba", "la", "ce", "pr", "nd", "pm", "sm", "eu", "gd", "tb", "dy", "ho", "er", "tm", "yb", "hf", "ta", "w", "re", "os", "ir", "pt", "au", "hg", "tl", "pb", "bi", "po", "at", "rn", "fr", "ra", "ac", "th", "pa", "u", "np", "pu", "am", "cm", "bk", "cf", "es", "fm", "md", "no", "lr", "rf", "db", "sg", "bh", "hs", "mt", "ds", "rg", "cn", "nh", "fl", "mc", "lv", "ts", "og" };

    public void Start()
    {
        ActivateTabs(hydrogenScreen);
        DeactivateTabs(heliumScreen);
        DeactivateTabs(menu);
        DeactivateTabs(li);
        DeactivateTabs(be);
        DeactivateTabs(b);
        DeactivateTabs(c);
        DeactivateTabs(n);
        DeactivateTabs(o);
        DeactivateTabs(f);
        DeactivateTabs(ne);
    }

    
    public void Update()
    {
        
    }

    public void EfficientTabChange(CanvasGroup group, string groups)
    {
        string check;
        check = group.ToString();
        for (int n = 0; n < groups.Length; n++)
        {
           
            
            if (check.Equals(groups[n]))
            {
                ActivateTabs(group);
            }
            else
            {
                DeactivateTabs(group);
            }

        }
    }

    public void SwitchTabs(int id)
    {
        switch (id)
        {
            case 0:
                EfficientTabChange(hydrogenScreen, "hydrogenScreen");
                break;
            case 1:
                DeactivateTabs(hydrogenScreen);
                ActivateTabs(heliumScreen);
                DeactivateTabs(menu);
                DeactivateTabs(li);
                DeactivateTabs(be);
                DeactivateTabs(b);
                DeactivateTabs(c);
                DeactivateTabs(n);
                DeactivateTabs(o);
                DeactivateTabs(f);
                DeactivateTabs(ne);
                break;
            case 2:
                DeactivateTabs(hydrogenScreen);
                DeactivateTabs(heliumScreen);
                ActivateTabs(menu);
                DeactivateTabs(li);
                DeactivateTabs(be);
                DeactivateTabs(b);
                DeactivateTabs(c);
                DeactivateTabs(n);
                DeactivateTabs(o);
                DeactivateTabs(f);
                DeactivateTabs(ne);
                break;
            case 3:
                DeactivateTabs(hydrogenScreen);
                DeactivateTabs(heliumScreen);
                DeactivateTabs(menu);
                ActivateTabs(li);
                DeactivateTabs(be);
                DeactivateTabs(b);
                DeactivateTabs(c);
                DeactivateTabs(n);
                DeactivateTabs(o);
                DeactivateTabs(f);
                DeactivateTabs(ne);
                break;
            case 4:
                DeactivateTabs(hydrogenScreen);
                DeactivateTabs(heliumScreen);
                DeactivateTabs(menu);
                DeactivateTabs(li);
                ActivateTabs(be);
                DeactivateTabs(b);
                DeactivateTabs(c);
                DeactivateTabs(n);
                DeactivateTabs(o);
                DeactivateTabs(f);
                DeactivateTabs(ne);
                break;
            case 5:
                DeactivateTabs(hydrogenScreen);
                DeactivateTabs(heliumScreen);
                DeactivateTabs(menu);
                DeactivateTabs(li);
                DeactivateTabs(be);
                ActivateTabs(b);
                DeactivateTabs(c);
                DeactivateTabs(n);
                DeactivateTabs(o);
                DeactivateTabs(f);
                DeactivateTabs(ne);
                break;
            case 6:
                DeactivateTabs(hydrogenScreen);
                DeactivateTabs(heliumScreen);
                DeactivateTabs(menu);
                DeactivateTabs(li);
                DeactivateTabs(be);
                DeactivateTabs(b);
                ActivateTabs(c);
                DeactivateTabs(n);
                DeactivateTabs(o);
                DeactivateTabs(f);
                DeactivateTabs(ne);
                break;
            case 7:
                DeactivateTabs(hydrogenScreen);
                DeactivateTabs(heliumScreen);
                DeactivateTabs(menu);
                DeactivateTabs(li);
                DeactivateTabs(be);
                DeactivateTabs(b);
                DeactivateTabs(c);
                ActivateTabs(n);
                DeactivateTabs(o);
                DeactivateTabs(f);
                DeactivateTabs(ne);
                break;
            case 8:
                DeactivateTabs(hydrogenScreen);
                DeactivateTabs(heliumScreen);
                DeactivateTabs(menu);
                DeactivateTabs(li);
                DeactivateTabs(be);
                DeactivateTabs(b);
                DeactivateTabs(c);
                DeactivateTabs(n);
                ActivateTabs(o);
                DeactivateTabs(f);
                DeactivateTabs(ne);
                break;
            case 9:
                DeactivateTabs(hydrogenScreen);
                DeactivateTabs(heliumScreen);
                DeactivateTabs(menu);
                DeactivateTabs(li);
                DeactivateTabs(be);
                DeactivateTabs(b);
                DeactivateTabs(c);
                DeactivateTabs(n);
                DeactivateTabs(o);
                ActivateTabs(f);
                DeactivateTabs(ne);
                break;
            case 10:
                DeactivateTabs(hydrogenScreen);
                DeactivateTabs(heliumScreen);
                DeactivateTabs(menu);
                DeactivateTabs(li);
                DeactivateTabs(be);
                DeactivateTabs(b);
                DeactivateTabs(c);
                DeactivateTabs(n);
                DeactivateTabs(o);
                DeactivateTabs(f);
                ActivateTabs(ne);
                break;
            default:
                Debug.Log(message: "Is not assigned");
                break;
        }
    }

    public void ActivateTabs(CanvasGroup group)
    {
        group.alpha = 1;
        group.interactable = true;
        group.blocksRaycasts = true;
    }
    
    public void DeactivateTabs(CanvasGroup group)
    {
        group.alpha = 0;
        group.interactable = false;
        group.blocksRaycasts = false;
    }

    public void DoExitGame()
    {
        Application.Quit();
    }

    
}
