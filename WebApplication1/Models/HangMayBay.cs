using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class HangMayBay
    {
        private int _ID;
        private string _code, _name_h, _address_h, _phone_h;
        public HangMayBay() { }
        public HangMayBay(string code, string name_h, string address_h, string phone_h)
        {
            this._code = code;
            this._name_h = name_h;
            this._address_h = address_h;
            this._phone_h = phone_h;
        }
        public HangMayBay(int id, string code, string name_h, string address_h, string phone_h)
        {
            this._ID = id;
            this._code = code;
            this._name_h = name_h;
            this._address_h = address_h;
            this._phone_h = phone_h;
        }
        public int ID 
        {
            get
            {
                return this._ID;
            }
            set
            {
                this._ID = value;
            }
        }
        public string CODE 
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        public string NAME 
        {
            get
            {
                return this._name_h;
            }
            set
            {
                this._name_h = value;
            }
        }
        public string ADDRESS 
        {
            get
            {
                return this._address_h;
            }
            set
            {
                this._address_h = value;
            }
        }
        public string PHONE 
        {
            get
            {
                return this._phone_h;
            }
            set
            {
                this._phone_h = value;
            }
        }
    }
}
