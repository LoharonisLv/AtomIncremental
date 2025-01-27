using UnityEngine;


public class Tabs : MonoBehaviour
{
    public string check;
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
    //public string[] groupName = { "hydrogenScreen" , "heliumScreen", "menu", "lithiumScreen", "berylliumScreen", "boronScreen", "carbonScreen", "nitrogenScreen", "oxygenScreen", "fluorineScreen", "neonScreen"};

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

    

    private void EfficientTabChange(CanvasGroup group)
    {
        string[] groupName = new string[11] { "hydrogenScreen" , "heliumScreen", "menu", "lithiumScreen", "berylliumScreen", "boronScreen", "carbonScreen", "nitrogenScreen", "oxygenScreen", "fluorineScreen", "neonScreen"};
        check = group.ToString();
        
        foreach (string nos in groupName)
        {
            
            if (check.Equals(nos))
            {
                ActivateTabs(group);
            }
            else
            {
                DeactivateTabs(CanvasGroup.Parse(nos));
            }

        }
    }

    public void SwitchTabs(int id)
    {
        switch (id)
        {
            case 0:
                EfficientTabChange(hydrogenScreen);
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

    private void ActivateTabs(CanvasGroup group)
    {
        group.alpha = 1;
        group.interactable = true;
        group.blocksRaycasts = true;
    }
    
    private void DeactivateTabs(CanvasGroup group)
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
