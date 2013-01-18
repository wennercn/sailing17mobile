using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ATLDATALib;

namespace sailing17Mobile {
    public class AtlData2Model<T> where T : new() {
        //获取类的属性列表
        public static List<string> GetProperties(){
            Type t = typeof(T);         
            System.Reflection.PropertyInfo[] properties = t.GetProperties();
            List<string> ps = new List<string>();
            foreach (System.Reflection.PropertyInfo property in properties) {
                ps.Add(property.Name);
            }
            return ps;
        }
        //转换单个对象
        public static T Convert (ATLDATALib.IDBDataAtl datas = null) {
            T item = new T();
            var ps = GetProperties();
            if (datas != null && datas.IsOK() && datas.GetRowCount() > 0) {
                ATLDATALib.IDBDataAtl data = (ATLDATALib.IDBDataAtl)datas.GetDataTIndex(0);
                foreach (string name in ps) {
                    string value = data.GetStringTName(name);
                    System.Type type = item.GetType();
                    System.Reflection.PropertyInfo pi = type.GetProperty(name);
                    pi.SetValue(item, value, null);
                }
            }
            return item;
        }

        //转换LIST
        public List<T> ConvertList (ATLDATALib.IDBDataAtl datas) {
            List<T> items = new List<T>();
            var ps = GetProperties();
            if (datas != null && datas.IsOK() && datas.GetRowCount() > 0) {
                for (var i = 0; i < datas.GetRowCount(); i++) {
                    T model = new T();
                    ATLDATALib.IDBDataAtl data = (ATLDATALib.IDBDataAtl)datas.GetDataTIndex(i);
                    foreach (string name in ps) {
                        string value = data.GetStringTName(name);
                        System.Type type = model.GetType();                        
                        System.Reflection.PropertyInfo pi = type.GetProperty(name);
                        pi.SetValue(model, value, null);        
                        //测试总不成功..
                        //System.Reflection.FieldInfo field = type.GetField(name);
                        //field.SetValue(item, data.GetStringTName(name));
                    }
                    items.Add(model);
                }
            }

            return items;
        }
    }
}