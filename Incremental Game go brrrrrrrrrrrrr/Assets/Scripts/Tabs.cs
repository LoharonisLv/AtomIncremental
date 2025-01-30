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

    

    private void EfficientTabChange(CanvasGroup group)
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

    public void SwitchTabs(int id)
    {
        switch (id)
        {
            case 0:
                EfficientTabChange(hydrogenScreen);
                break;
            case 1:
                EfficientTabChange(heliumScreen);
                break;
            case 2:
                EfficientTabChange(menu);
                break;
            case 3:
                EfficientTabChange(li);
                break;
            case 4:
                EfficientTabChange(be);
                break;
            case 5:
                EfficientTabChange(b);
                break;
            case 6:
                EfficientTabChange(c);
                break;
            case 7:
                EfficientTabChange(n);
                break;
            case 8:
                EfficientTabChange(o);
                break;
            case 9:
                EfficientTabChange(f);
                break;
            case 10:
                EfficientTabChange(ne);
                break;
            case 11:
                EfficientTabChange(na);
                break;
            case 12:
                EfficientTabChange(mg);
                break;
            case 13:
                EfficientTabChange(al);
                break;
            case 14:
                EfficientTabChange(si);
                break;
            case 15:
                EfficientTabChange(p);
                break;
            case 16:
                EfficientTabChange(s);
                break;
            case 17:
                EfficientTabChange(cl);
                break;
            case 18:
                EfficientTabChange(ar);
                break;
            case 19:
                EfficientTabChange(k);
                break;
            case 20:
                EfficientTabChange(ca);
                break;
            case 21:
                EfficientTabChange(sc);
                break;
            case 22:
                EfficientTabChange(ti);
                break;
            case 23:
                EfficientTabChange(v);
                break;
            case 24:
                EfficientTabChange(cr);
                break;
            case 25:
                EfficientTabChange(mn);
                break;
            case 26:
                EfficientTabChange(fe);
                break;
            case 27:
                EfficientTabChange(co);
                break;
            case 28:
                EfficientTabChange(ni);
                break;
            case 29:
                EfficientTabChange(cu);
                break;
            case 30:
                EfficientTabChange(zn);
                break;
            case 31:
                EfficientTabChange(ga);
                break;
            case 32:
                EfficientTabChange(ge);
                break;
            case 33:
                EfficientTabChange(ars);
                break;
            case 34:
                EfficientTabChange(se);
                break;
            case 35:
                EfficientTabChange(br);
                break;
            case 36:
                EfficientTabChange(kr);
                break;
            case 37:
                EfficientTabChange(rb);
                break;
            case 38:
                EfficientTabChange(sr);
                break;
            case 39:
                EfficientTabChange(y);
                break;
            case 40:
                EfficientTabChange(zr);
                break;
            case 41:
                EfficientTabChange(nb);
                break;
            case 42:
                EfficientTabChange(mo);
                break;
            case 43:
                EfficientTabChange(tc);
                break;
            case 44:
                EfficientTabChange(ru);
                break;
            case 45:
                EfficientTabChange(rh);
                break;
            case 46:
                EfficientTabChange(pd);
                break;
            case 47:
                EfficientTabChange(ag);
                break;
            case 48:
                EfficientTabChange(cd);
                break;
            case 49:
                EfficientTabChange(ind);
                break;
            case 50:
                EfficientTabChange(sn);
                break;
            case 51:
                EfficientTabChange(sb);
                break;
            case 52:
                EfficientTabChange(te);
                break;
            case 53:
                EfficientTabChange(i);
                break;
            case 54:
                EfficientTabChange(xe);
                break;
            case 55:
                EfficientTabChange(cs);
                break;
            case 56:
                EfficientTabChange(ba);
                break;
            case 57:
                EfficientTabChange(la);
                break;
            case 58:
                EfficientTabChange(ce);
                break;
            case 59:
                EfficientTabChange(pr);
                break;
            case 60:
                EfficientTabChange(nd);
                break;
            case 61:
                EfficientTabChange(pm);
                break;
            case 62:
                EfficientTabChange(sm);
                break;
            case 63:
                EfficientTabChange(eu);
                break;
            case 64:
                EfficientTabChange(gd);
                break;
            case 65:
                EfficientTabChange(tb);
                break;
            case 66:
                EfficientTabChange(dy);
                break;
            case 67:
                EfficientTabChange(ho);
                break;
            case 68:
                EfficientTabChange(er);
                break;
            case 69:
                EfficientTabChange(tm);
                break;
            case 70:
                EfficientTabChange(yb);
                break;
            case 71:
                EfficientTabChange(lu);
                break;
            case 72:
                EfficientTabChange(hf);
                break;
            case 73:
                EfficientTabChange(ta);
                break;
            case 74:
                EfficientTabChange(w);
                break;
            case 75:
                EfficientTabChange(re);
                break;
            case 76:
                EfficientTabChange(os);
                break;
            case 77:
                EfficientTabChange(ir);
                break;
            case 78:
                EfficientTabChange(pt);
                break;
            case 79:
                EfficientTabChange(au);
                break;
            case 80:
                EfficientTabChange(hg);
                break;
            case 81:
                EfficientTabChange(tl);
                break;
            case 82:
                EfficientTabChange(pb);
                break;
            case 83:
                EfficientTabChange(bi);
                break;
            case 84:
                EfficientTabChange(po);
                break;
            case 85:
                EfficientTabChange(at);
                break;
            case 86:
                EfficientTabChange(rn);
                break;
            case 87:
                EfficientTabChange(fr);
                break;
            case 88:
                EfficientTabChange(ra);
                break;
            case 89:
                EfficientTabChange(ac);
                break;
            case 90:
                EfficientTabChange(th);
                break;
            case 91:
                EfficientTabChange(pa);
                break;
            case 92:
                EfficientTabChange(u);
                break;
            case 93:
                EfficientTabChange(np);
                break;
            case 94:
                EfficientTabChange(pu);
                break;
            case 95:
                EfficientTabChange(am);
                break;
            case 96:
                EfficientTabChange(cm);
                break;
            case 97:
                EfficientTabChange(bk);
                break;
            case 98:
                EfficientTabChange(cf);
                break;
            case 99:
                EfficientTabChange(es);
                break;
            case 100:
                EfficientTabChange(fm);
                break;
            case 101:
                EfficientTabChange(md);
                break;
            case 102:
                EfficientTabChange(no);
                break;
            case 103:
                EfficientTabChange(lr);
                break;
            case 104:
                EfficientTabChange(rf);
                break;
            case 105:
                EfficientTabChange(db);
                break;
            case 106:
                EfficientTabChange(sg);
                break;
            case 107:
                EfficientTabChange(bh);
                break;
            case 108:
                EfficientTabChange(hs);
                break;
            case 109:
                EfficientTabChange(mt);
                break;
            case 110:
                EfficientTabChange(ds);
                break;
            case 111:
                EfficientTabChange(rg);
                break;
            case 112:
                EfficientTabChange(cn);
                break;
            case 113:
                EfficientTabChange(nh);
                break;
            case 114:
                EfficientTabChange(fl);
                break;
            case 115:
                EfficientTabChange(mc);
                break;
            case 116:
                EfficientTabChange(lv);
                break;
            case 117:
                EfficientTabChange(ts);
                break;
            case 118:
                EfficientTabChange(og);
                break;
            case 119:
                EfficientTabChange(changelog);
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
