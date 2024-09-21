﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CajeroWeb.Models
{
    public class transaccion
    {
        private String sNumeroTarjeta;
        private double fSaldo;

        public transaccion(String tarjeta)
        {
            sNumeroTarjeta = tarjeta;
            fSaldo = 500;
        }
        public transaccion(String tarjeta, double saldo)
        {
            sNumeroTarjeta = tarjeta;
            fSaldo = saldo;
        }
        //metodo get
        public double getSaldo()
        {
            return fSaldo;
        }
        public void setSaldo(double saldo)
        {
            fSaldo = saldo;
        }
        public String getNumTarjeta()
        {
            return sNumeroTarjeta;
        }
        public void setNumTarjeta(String tarjeta)
        {
            sNumeroTarjeta = tarjeta;
        }
        public void transferenciaNacional(double monto)
        {
            fSaldo = fSaldo - monto;
        }
        public void transferenciaInternacional(double monto)
        {
            fSaldo = fSaldo - monto;
        }
    }
}