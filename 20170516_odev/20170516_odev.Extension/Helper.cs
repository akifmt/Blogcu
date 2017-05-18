using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using _20170516_odev.Entity;

namespace _20170516_odev.Extension
{
    public class Helper
    {
        public static void BindDropDownList<T>(ICollection<T> _sourceList, DropDownList _dropDownList, string _dataValueField, string _dataTextField)
        {
            _dropDownList.DataSource = _sourceList;
            _dropDownList.DataValueField = _dataValueField;
            _dropDownList.DataTextField = _dataTextField;
            _dropDownList.DataBind();
        }

        public static void BindDropDownList<T>(ICollection<T> _sourceList, DropDownList _dropDownList, string _dataValueField, string _dataTextField, string _selectedValue)
        {
            _dropDownList.DataSource = _sourceList;
            _dropDownList.DataValueField = _dataValueField;
            _dropDownList.DataTextField = _dataTextField;
            _dropDownList.SelectedValue = _selectedValue;
            _dropDownList.DataBind();
        }


        public static void BindDataControl<T>(ICollection<T> _sourceList, BaseDataBoundControl _dataControl)
        {
            _dataControl.DataSource = _sourceList;
            _dataControl.DataBind();
        }

        public static void BindDataControl<T>(ICollection<T> _sourceList, Repeater _repeater)
        {
            _repeater.DataSource = _sourceList;
            _repeater.DataBind();
        }




        /*  DYNAMIC MESSAGE */
        /*
        public static string GeneralMessageDynamic<T>(T item)
        {
            string message="";
            foreach (var prop in item.GetType().GetProperties())
            {
                if (prop.Name == "MessagePath")
                {
                    message = prop.GetValue(item, null).ToString();
                }
                else if (prop.Name == "MessageText")
                {
                    message += "path'inde beklenmedik bir durum ile karşılaşıldı:" + prop.GetValue(item, null).ToString();
                }
            }
            return message;
        }
         
         */

        /*
    public static string GeneralMessage(ApplicationMessages item)
    {
        return item.MessagePath + " path'inde beklenmedik bir durum ile karşılaşıldı:" + item.MessageText;
    }
    */

    }
}
