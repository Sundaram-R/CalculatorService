using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCClient.Models
{
    public class InputModel
    {
        public int _value1;
        public int _value2;
        public int _result;

        public int value1 {
            set {  _value1=value;}
            get { return _value1; }
        }

        public int value2 {
            set {  _value2=value; }
            get { return _value2; }
        }

        public int result
        {
            set {  _result=value; }
            get { return _result; }
        }
    }
}