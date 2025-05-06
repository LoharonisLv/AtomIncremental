using UnityEngine;


public class Tabs : MonoBehaviour
{
    //Tabs
    public CanvasGroup menu;
    public CanvasGroup hydrogenScreen;
    public CanvasGroup heliumScreen;
    public CanvasGroup li;
    public CanvasGroup be;
    public CanvasGroup b;
    public CanvasGroup c;
    public CanvasGroup n;
    public CanvasGroup o;
    public CanvasGroup f;
    public CanvasGroup ne;
    public CanvasGroup na;
    public CanvasGroup mg;
    public CanvasGroup al;
    public CanvasGroup si;
    public CanvasGroup p;
    public CanvasGroup s;
    public CanvasGroup cl;
    public CanvasGroup ar;
    public CanvasGroup k;
    public CanvasGroup ca;
    public CanvasGroup sc;
    public CanvasGroup ti;
    public CanvasGroup v;
    public CanvasGroup cr;
    public CanvasGroup mn;
    public CanvasGroup fe;
    public CanvasGroup co;
    public CanvasGroup ni;
    public CanvasGroup cu;
    public CanvasGroup zn;
    public CanvasGroup ga;
    public CanvasGroup ge;
    public CanvasGroup ars;
    public CanvasGroup se;
    public CanvasGroup br;
    public CanvasGroup kr;
    public CanvasGroup rb;
    public CanvasGroup sr;
    public CanvasGroup y;
    public CanvasGroup zr;
    public CanvasGroup nb;
    public CanvasGroup mo;
    public CanvasGroup tc;
    public CanvasGroup ru;
    public CanvasGroup rh;
    public CanvasGroup pd;
    public CanvasGroup ag;
    public CanvasGroup cd;
    public CanvasGroup ind;
    public CanvasGroup sn;
    public CanvasGroup sb;
    public CanvasGroup te;
    public CanvasGroup i;
    public CanvasGroup xe;
    public CanvasGroup cs;
    public CanvasGroup ba;
    public CanvasGroup la;
    public CanvasGroup ce;
    public CanvasGroup pr;
    public CanvasGroup nd;
    public CanvasGroup pm;
    public CanvasGroup sm;
    public CanvasGroup eu;
    public CanvasGroup gd;
    public CanvasGroup tb;
    public CanvasGroup dy;
    public CanvasGroup ho;
    public CanvasGroup er;
    public CanvasGroup tm;
    public CanvasGroup yb;
    public CanvasGroup lu;
    public CanvasGroup hf;
    public CanvasGroup ta;
    public CanvasGroup w;
    public CanvasGroup re;
    public CanvasGroup os;
    public CanvasGroup ir;
    public CanvasGroup pt;
    public CanvasGroup au;
    public CanvasGroup hg;
    public CanvasGroup tl;
    public CanvasGroup pb;
    public CanvasGroup bi;
    public CanvasGroup po;
    public CanvasGroup at;
    public CanvasGroup rn;
    public CanvasGroup fr;
    public CanvasGroup ra;
    public CanvasGroup ac;
    public CanvasGroup th;
    public CanvasGroup pa;
    public CanvasGroup u;
    public CanvasGroup np;
    public CanvasGroup pu;
    public CanvasGroup am;
    public CanvasGroup cm;
    public CanvasGroup bk;
    public CanvasGroup cf;
    public CanvasGroup es;
    public CanvasGroup fm;
    public CanvasGroup md;
    public CanvasGroup no;
    public CanvasGroup lr;
    public CanvasGroup rf;
    public CanvasGroup db;
    public CanvasGroup sg;
    public CanvasGroup bh;
    public CanvasGroup hs;
    public CanvasGroup mt;
    public CanvasGroup ds;
    public CanvasGroup rg;
    public CanvasGroup cn;
    public CanvasGroup nh;
    public CanvasGroup fl;
    public CanvasGroup mc;
    public CanvasGroup lv;
    public CanvasGroup ts;
    public CanvasGroup og;
    public CanvasGroup changelog;
    
    //public string[] groupName = { "hydrogenScreen" , "heliumScreen", "menu", "lithiumScreen", "berylliumScreen", "boronScreen", "carbonScreen", "nitrogenScreen", "oxygenScreen", "fluorineScreen", "neonScreen"};

    public void Start()
    {
        EfficientTabChange(hydrogenScreen);
    }

    

    private void EfficientTabChange(object group)
    {
        CanvasGroup [] groups = new CanvasGroup[120] { hydrogenScreen, heliumScreen, menu, li, be, b, c, n, o, f, ne, na, mg, al, si, p, s, cl, ar, k, ca, sc, ti, v, cr, mn, fe, co, ni, cu, zn, ga, ge, ars, se, br, kr, rb, sr, y, zr, nb, mo, tc, ru, rh, pd, ag, cd, ind, sn, sb, te, i, xe, cs, ba, la, ce, pr, nd, pm, sm, eu, gd, tb, dy, ho, er, tm, yb, lu, hf, ta, w, re, os, ir, pt, au, hg, tl, pb, bi, po, at, rn, fr, ra, ac, th, pa, u, np, pu, am, cm, bk, cf, es, fm, md, no, lr, rf, db, sg, bh, hs, mt, ds, rg, cn, nh, fl, mc, lv, ts, og, changelog};
    
        foreach (CanvasGroup g in groups)
        {
            if (g == group)
            {
                ActivateTabs(g);
            }
            else
            {
                DeactivateTabs(g);
            }
        }
    }

    private object[] _tabs;
    private int currentTabId = -1;
    private int lastTabBeforeMenu = -1;
    
    public void SwitchTabs(int id)
    { 
        _tabs = new object[]
        {
            hydrogenScreen, heliumScreen, menu, li, be, b, c, n, o, f, ne, na, mg, al, si, p, s, cl, ar, k, ca, sc, ti, v,
            cr, mn, fe, co, ni, cu, zn, ga, ge, ars, se, br, kr, rb, sr, y, zr, nb, mo, tc, ru, rh, pd, ag, cd, ind, sn, sb,
            te, i, xe, cs, ba, la, ce, pr, nd, pm, sm, eu, gd, tb, dy, ho, er, tm, yb, lu, hf, ta, w, re, os, ir, pt, au, hg,
            tl, pb, bi, po, at, rn, fr, ra, ac, th, pa, u, np, pu, am, cm, bk, cf, es, fm, md, no, lr, rf, db, sg, bh, hs,
            mt, ds, rg, cn, nh, fl, mc, lv, ts, og, changelog
        };
        if (id < 0 || id >= _tabs.Length)
        {
            Debug.Log("Is not assigned");
            return;
        }

        // ID for 'menu' is assumed to be 2
        const int MenuTabId = 2;

        if (id == MenuTabId)
        {
            if (currentTabId == MenuTabId && lastTabBeforeMenu != -1)
            {
                // Going back to the last tab before the menu
                EfficientTabChange(_tabs[lastTabBeforeMenu]);
                currentTabId = lastTabBeforeMenu;
                lastTabBeforeMenu = -1;
            }
            else
            {
                // Going to the menu
                lastTabBeforeMenu = currentTabId;
                EfficientTabChange(_tabs[MenuTabId]);
                currentTabId = MenuTabId;
            }
        }
        else
        {
            EfficientTabChange(_tabs[id]);
            currentTabId = id;
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
