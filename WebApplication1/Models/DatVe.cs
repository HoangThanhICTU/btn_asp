using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DatVe
    {
        private int _ID;
        private string _code_v, _name_kh, _idcard, _phone_kh;
        public DatVe() { }
        public DatVe(int ID, string code, string name_h, string id_card, string phone_h)
        {
            this._ID = ID;
            this._code_v = code;
            this._name_kh = name_h;
            this._idcard = id_card;
            this._phone_kh = phone_h;
        }
        public DatVe(string code)
        {
            this._code_v = code;
            this._name_kh = "";
            this._idcard = "";
            this._phone_kh = "";
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
                return this._code_v;
            }
            set
            {
                this._code_v = value;
            }
        }
        public string NAME 
        {
            get
            {
                return this._name_kh;
            }
            set
            {
                this._name_kh = value;
            }
        }
        public string IDCARD 
        {
            get
            {
                return this._idcard;
            }
            set
            {
                this._idcard = value;
            }
        }
        public string PHONE 
        {
            get
            {
                return this._phone_kh;
            }
            set
            {
                this._phone_kh = value;
            }
        }
    }
}