﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace YGOEditor.Util {
    public class YEFormFactory {
        public static DockContent CreateForm(Persist persist){
            try {
                Type type = Type.GetType(persist.TypeName);
                Assembly assembly = Assembly.GetAssembly(type);
                object o = assembly.CreateInstance(persist.TypeName);
                if (o is IYEForm) {
                    IYEForm yef = o as IYEForm;
                    yef.SetParams(persist.Params);
                }
                return o as DockContent;
            }
            catch (System.Exception ex) {
                throw ex;
            }
        }

        public static DockContent CreateForm(string persistString) {
            return CreateForm(new Persist(persistString));
        }

//         public static DockContent CreateForm(string TypeName) {
// 
//             try {
//                 Type type = Type.GetType(TypeName);
//                 Assembly assembly = Assembly.GetAssembly(type);
//                 object o = assembly.CreateInstance(TypeName);
//                 return o as DockContent;
//             }
//             catch (System.Exception ex) {
//                 throw ex;
//             }
//         }

    }
}
