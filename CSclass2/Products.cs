﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSclass2
{
    class Products
    {
        private List<string> items = new List<string>() { "짜장면", "짬뽕", "탕수육" };
        public string this[int i]
        {
            get { return items[i]; }
            set {
                items[i] = value;
                Console.WriteLine(i + "번쨰 상품을 " + value + "로 설정");
            }
        }
    }
}
