﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWebdeAM240104.Models
{
    public class Localidad
    {
        public List<SelectListItem> Localidades { get; set; }
        public int nIdMunicipio;
        public string sNombreMunicipio;
        public int nIdPais;
    }
}