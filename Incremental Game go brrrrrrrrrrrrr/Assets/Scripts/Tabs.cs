using UnityEngine;
using System.Collections.Generic;

public class Tabs : MonoBehaviour
{
    // Declare all CanvasGroups normally (no Inspector assignment needed)
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

    private List<CanvasGroup> tabs;
    private int currentTabId = -1;
    private int lastTabBeforeMenu = -1;

    private int menuTabIndex; // this will hold the actual index of the menu tab

    private void Awake()
    {
        // Manually ordered list to avoid reflection issues
        tabs = new List<CanvasGroup>
        {
            hydrogenScreen, heliumScreen, menu, li, be, b, c, n, o, f, ne, na, mg, 
            al, si, p, s, cl, ar, k, ca, sc, ti, v, cr, mn, fe, co, ni, cu, zn, ga, 
            ge, ars, se, br, kr, rb, sr, y, zr, nb, mo, tc, ru, rh, pd, ag, cd, ind, 
            sn, sb, te, i, xe, cs, ba, la, ce, pr, nd, pm, sm, eu, gd, tb, dy, ho, er, 
            tm, yb, lu, hf, ta, w, re, os, ir, pt, au, hg, tl, pb, bi, po, at, rn, fr, 
            ra, ac, th, pa, u, np, pu, am, cm, bk, cf, es, fm, md, no, lr, rf, db, sg, 
            bh, hs, mt, ds, rg, cn, nh, fl, mc, lv, ts, og, changelog
        };

        menuTabIndex = tabs.IndexOf(menu);
    }

    private void Start()
    {
        if (tabs.Count > 0)
        {
            SwitchTabs(0); // Start with Hydrogen tab
        }
    }

    public void SwitchTabs(int id)
    {
        if (id < 0 || id >= tabs.Count)
        {
            Debug.LogWarning("Invalid tab ID.");
            return;
        }

        if (id == menuTabIndex)
        {
            // Switching to menu
            if (currentTabId != menuTabIndex)
            {
                lastTabBeforeMenu = currentTabId;
                SetActiveTab(menuTabIndex);
            }
            else
            {
                // Back from menu
                if (lastTabBeforeMenu >= 0)
                {
                    SetActiveTab(lastTabBeforeMenu);
                    lastTabBeforeMenu = -1;
                }
            }
        }
        else
        {
            SetActiveTab(id);
        }
    }

    private void SetActiveTab(int id)
    {
        for (int i = 0; i < tabs.Count; i++)
        {
            bool isActive = (i == id);
            SetTabState(tabs[i], isActive);
        }

        currentTabId = id;
    }

    private void SetTabState(CanvasGroup group, bool active)
    {
        group.alpha = active ? 1 : 0;
        group.interactable = active;
        group.blocksRaycasts = active;
    }

    public void DoExitGame()
    {
        Application.Quit();
    }
}
