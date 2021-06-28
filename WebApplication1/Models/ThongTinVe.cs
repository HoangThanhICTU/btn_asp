using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ThongTinVe
    {
        private int _ID, _price_v;
        private string _code_v, _type_v, _point_start, _point_end;
        private DateTime _dt_end, _dt_start;
        public ThongTinVe() { }
        public ThongTinVe(int ID, string code_v, string type_v, int price, DateTime dt_start, string point_start, DateTime dt_end, string point_end)
        {
            this._ID = ID;
            this._code_v = code_v;
            this._type_v = type_v;
            this._point_start = point_start;
            this._point_end = point_end;
            this._dt_start = dt_start;
            this._dt_end = dt_end;
            this._price_v = price;
        }
        public int ID {
            get
            {
                return this._ID;
            }
            set
            {
                this._ID = value;
            }
        }
        public string CODE {
            get
            {
                return this._code_v;
            }
            set
            {
                this._code_v = value;
            }
        }
        public string TYPE {
            get
            {
                return this._type_v;
            }
            set
            {
                this._type_v = value;
            }
        }
        public int PRICE {
            get
            {
                return this._price_v;
            }
            set
            {
                this._price_v = value;
            }
        }
        public string POINT_START {
            get
            {
                return this._point_start;
            }
            set
            {
                this._point_start = value;
            }
        }
        public string POINT_END {
            get
            {
                return this._point_end;
            }
            set
            {
                this._point_end = value;
            }
        }
        public DateTime DT_START {
            get
            {
                return this._dt_start;
            }
            set
            {
                this._dt_start = value;
            }
        }
        public DateTime DT_END {
            get
            {
                return this._dt_end;
            }
            set
            {
                this._dt_end = value;
            }
        }
    }
}