using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Utilities
{
    public class AlertUi
    {
        public AlertUi()
        {

        }
        public AlertUi(string text, AlertUiType alertUiType = AlertUiType.error)
        {

            AlertUiType = alertUiType;
            Text = text;

        }
        public string Text { get; set; }


        public AlertUiType AlertUiType { get; set; }

        public string type => AlertUiType.ToString();

        public override string ToString()
        {

            return AlertUiType == AlertUiType.custom ? Text : string.Format(AlertUiConstant.alertFormat, Utility.Instance.JsonSerializer(this));
        }
    }
    public static class AlertUiConstant
    {
        public const string success = "App.UIAlert({type:'success'});";
        public const string error = "App.UIAlert({type:'error'});";
        public const string alertFormat = "App.UIAlert({0});";
    }
    public enum AlertUiType
    {
        error,
        info,
        success,
        custom
    }
}
