﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace STORE.Model
{
    class Diskon
    {
        public string diskon { get; set; }
        public double potongan { get; set; }

        public Diskon(string diskon, double potongan)
        {
            this.diskon = diskon;
            this.potongan = potongan;
        }
    }
}