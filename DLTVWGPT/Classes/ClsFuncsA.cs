﻿using DLTLib.Classes;
using DLTVWGPT.XTGL;
using Gizmox.WebGUI.Forms;
using JXC.JH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DLTVWGPT.Classes
{
    public class ClsFuncsA : ClsFuncs
    {
        private TabPage tp;
        public ClsFuncsA(TabPage aTp)
        {
            tp = aTp;
        }

        public override void Call(int aId, string aBm,
            string aMc)
        {
            tp.Controls.Clear();
            //#region 系统管理
            //if(string.Compare(aBm,"mkgl",true)==0)
            //{
            //    FrmMKGL c = new FrmMKGL();
            //    tp.Controls.Add(c);
            //    return;
            //}
            //#endregion

            #region 系统管理
            //模块管理
            if (string.Compare(aBm, "xtgl-mkgl", true) == 0)
                //判断选中的功能菜单
                //string compare的第三个参数为true表示忽略大小写的比较
            {
                FrmMKGL c = new FrmMKGL();
                //创建FrmMKGL类的对象
                tp.Controls.Clear();
                //将tpMain中的控件清除
                tp.Controls.Add(c);
                //将创建的FrmMKGL对象加载到tpMain中
                return;
            }
            #endregion

            #region 选项管理
            //选项管理
            //int a=string.Compare(aBm, "xtgl-xxgl", true);
            // int a1 = string.Compare("xtgl-xxgl", "xtgl-xxgl", true);
            if (string.Compare(aBm, "xtgl-xxgl", true) == 0)
            {
                FrmOptionLBLB c = new FrmOptionLBLB();
                tp.Controls.Add(c);
                return;
            }
            #endregion
            
            #region 角色管理
            //角色管理
            if (string.Compare(aBm, "xtgl-jsgl", true) == 0)
            {
                FrmRolesLB c = new FrmRolesLB();
                tp.Controls.Add(c);
                return;
            }
            #endregion
            
            #region 配置管理
            //配置管理
            if (string.Compare(aBm,"xtgl-config",true)==0)
            {
                FrmConfig c = new FrmConfig();
                tp.Controls.Add(c);
                return;
            }
            #endregion

            #region 员工管理
            //员工管理
            if (string.Compare(aBm, "xtgl-yggl", true) == 0)
            {
                FrmYuanGongLB c = new FrmYuanGongLB();
                c.Dock = DockStyle.Fill;
                tp.Controls.Add(c);
                return;
            }
            #endregion

            #region 机构管理
            //机构管理
            if (string.Compare(aBm,"xtgl-jggl",true)==0)
            {
                FrmJGGL c = new FrmJGGL();
                tp.Controls.Add(c);
                return;
            }
            #endregion

            //进销存
            #region 进销存
            if (string.Compare(aBm, "jxc-jhdlr", true) == 0)
            {
                FrmJhdLB c = new FrmJhdLB();
                c.Dock = DockStyle.Left;
                tp.Controls.Add(c);
                return;
            }
            #endregion

            ClsMsgBox.Jg(aId + "," + aBm + "," + aMc + Environment.NewLine
                + "此功能这在实现中..");




        }
    }
}